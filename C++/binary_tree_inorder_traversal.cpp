#include <iostream>
#include <stack>

struct TreeNode {
    int val;
    TreeNode* left;
    TreeNode* right;
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
};

class BinaryTreeInorderTraversal {
public:
    void inorderTraversal(TreeNode* root) {
        std::stack<TreeNode*> stack;
        TreeNode* curr = root;

        while (curr != nullptr || !stack.empty()) {
            while (curr != nullptr) {
                stack.push(curr);
                curr = curr->left;
            }

            curr = stack.top();
            stack.pop();
            std::cout << curr->val << " ";

            curr = curr->right;
        }
    }
};

int main() {
    TreeNode* root = new TreeNode(1);
    root->left = new TreeNode(2);
    root->right = new TreeNode(3);
    root->left->left = new TreeNode(4);
    root->left->right = new TreeNode(5);

    BinaryTreeInorderTraversal traversal;
    std::cout << "Inorder traversal of binary tree: ";
    traversal.inorderTraversal(root);
    std::cout << "\n";

    return 0;
}
