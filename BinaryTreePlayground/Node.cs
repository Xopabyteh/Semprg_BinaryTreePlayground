namespace BinaryTreePlayground;

public class Node
{
    public Node? LeftNode { get; set; }
    public Node? RightNode { get; set; }
    public int Value { get; set; }

    public Node(int value)
    {
        Value = value;
    }
}