class TreeNode:
    def __init__(self, value=0, left=None, right=None):
        self.value = value
        self.left = left
        self.right = right

def inorder_traversal(root):
    if root:
        inorder_traversal(root.left)
        print(root.value, end=" ")
        inorder_traversal(root.right)

if __name__ == "__main__":
    # Construct a binary tree
    root = TreeNode(1)
    root.right = TreeNode(2)
    root.right.left = TreeNode(3)
    
    print("Inorder traversal: ", end="")
    inorder_traversal(root)
    print()
