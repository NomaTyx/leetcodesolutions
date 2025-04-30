//this took much less time than the very similar puzzle I did last night
//leetcode easy

bool IsSymmetric(TreeNode root)
{
    //edge case of empty or single node tree
    if (root == null || (root.left == null && root.right == null)) return true;
    //if the first two aren't the same there's no need to traverse
    if (root.left == null || root.right == null || root.left.val != root.right.val) return false;

    Stack<TreeNode> left = new Stack<TreeNode>();
    Stack<TreeNode> right = new Stack<TreeNode>();
    left.Push(root.left);
    right.Push(root.right);
    TreeNode currentLeft;
    TreeNode currentRight;

    while (left.Count > 0)
    {
        currentLeft = left.Pop();
        currentRight = right.Pop();
        if (currentLeft.val != currentRight.val) return false;

        if (currentLeft.right != null && currentRight.left != null)
        {

            left.Push(currentLeft.right);
            right.Push(currentRight.left);
        }
        else
        {

            if (currentLeft.right != null || currentRight.left != null) return false;
        }

        if (currentLeft.left != null && currentRight.right != null)
        {

            left.Push(currentLeft.left);
            right.Push(currentRight.right);
        }
        else
        {

            if (currentLeft.left != null || currentRight.right != null) return false;
        }
    }

    return true;
}

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}