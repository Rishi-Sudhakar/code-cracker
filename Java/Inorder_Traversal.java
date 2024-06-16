import java.util.Scanner;

class TreeNode {
    int value;
    TreeNode left, right;

    public TreeNode(int item) {
        value = item;
        left = right = null;
    }
}

public class InorderTraversal {
    TreeNode root;

    void inorderTraversal(TreeNode node) {
        if (node == null)
            return;

        inorderTraversal(node.left);
        System.out.print(node.value + " ");
        inorderTraversal(node.right);
    }

    public static void main(String[] args) {
        InorderTraversal tree = new InorderTraversal();
        tree.root = new TreeNode(1);
        tree.root.right = new TreeNode(2);
        tree.root.right.left = new TreeNode(3);

        System.out.print("Inorder traversal: ");
        tree.inorderTraversal(tree.root);
        System.out.println();
    }
}
