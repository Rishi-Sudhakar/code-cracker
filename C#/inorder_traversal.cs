using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class BinaryTreeInorderTraversal
{
    public void InorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            InorderTraversal(root.left);
            Console.Write(root.val + " ");
            InorderTraversal(root.right);
        }
    }

    public static void Main()
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        BinaryTreeInorderTraversal traversal = new BinaryTreeInorderTraversal();
        Console.Write("Inorder traversal of binary tree: ");
        traversal.InorderTraversal(root);
        Console.WriteLine();
    }
}
