using BinaryTreePlayground;

BinaryTree binaryTree = new BinaryTree();

binaryTree.Insert(8);
binaryTree.Insert(5);
binaryTree.Insert(10);
binaryTree.Insert(9);
binaryTree.Insert(4);


binaryTree.GetValues().ForEach(x=>Console.Write($"{x}, "));
Console.WriteLine($"\n{binaryTree.Contains(10)}, {binaryTree.Contains(9)}, {binaryTree.Contains(6)}");
Console.ReadLine();