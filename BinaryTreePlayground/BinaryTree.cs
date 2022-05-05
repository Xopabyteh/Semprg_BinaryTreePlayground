namespace BinaryTreePlayground;

public class BinaryTree
{
    /*
     * Naprogramujte vlastní BST, který bude umět minimálně následující operace:
     *   
     *   Insert(int value) - vložení nového prvku,
     *   bool Contains(int value) - ověření existence prvku,
     *   List<int> GetValues() - výpis všech hodnot ve stromu (vyzkoušejte si různé podoby navštěvování uzlů - pre-order, in-order, post-order)
     */

    private Node? rootNode;


    public void Insert(int value)
    {
        if (rootNode is null)
        {
            rootNode = new Node(value);
            return;
        }
        NestNode(value,rootNode);
    }

    private void NestNode(int value, Node node)
    {
        if (value < node.Value)
        {
            if (node.LeftNode is null)
            {
                node.LeftNode = new Node(value);
            }
            else
            {
                NestNode(value,node.LeftNode);
            }
        }
        else
        {
            if (node.RightNode is null)
            {
                node.RightNode = new Node(value);
            }
            else
            {
                NestNode(value, node.RightNode);
            }
        }
    }

    public bool Contains(int value)
    {
        if (rootNode is null)
            return false;
        if(value < rootNode.Value)
        {
            return Contains(value, rootNode.LeftNode);
        }
        else
        {
            return Contains(value, rootNode.RightNode);
        }
    }
    private bool Contains(int value, Node? from)
    {
        if (from is null)
            return false;
        if (value.Equals(from.Value))
            return true;

        if (value < from.Value)
        {
            return Contains(value, from.LeftNode);
        }
        else
        {
            return Contains(value, from.RightNode);
        }
    }
    public List<int> GetValues()
    {
        List<int> values = new List<int>();
        if (rootNode is null)
        {
            return values;
        }
        values.Add(rootNode.Value);
        values.AddRange(GetValues(rootNode.LeftNode));
        values.AddRange(GetValues(rootNode.RightNode));
        return values;
    }


    private List<int> GetValues(Node? from)
    {
        List<int> values = new List<int>();
        
        if (from is null)
            return values;

        values.Add(from.Value);
        values.AddRange(GetValues(from.LeftNode));
        values.AddRange(GetValues(from.RightNode));

        return values;
    }
}