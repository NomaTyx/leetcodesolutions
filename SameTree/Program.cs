//well, this took a rather embarrassingly long time. cest la vie. Leetcode easy.

bool IsSameTree(TreeNode p, TreeNode q)
{
    if (p == null || q == null)
    {
        if (p == q) return true;
        return false;
    }

    Stack<TreeNode> pValsToCheck = new Stack<TreeNode>();
    Stack<TreeNode> qValsToCheck = new Stack<TreeNode>();
    pValsToCheck.Push(p);
    qValsToCheck.Push(q);
    TreeNode currentP;
    TreeNode currentQ;

    while (pValsToCheck.Count > 0)
    {
        currentP = pValsToCheck.Pop();
        currentQ = qValsToCheck.Pop();

        if (currentP.val != currentQ.val) return false;

        if (currentP.right != null && currentQ.right != null)
        {
            pValsToCheck.Push(currentP.right);
            qValsToCheck.Push(currentQ.right);
        }
        else
        {
            if (currentP.right != null || currentQ.right != null) return false;
        }

        if (currentP.left != null && currentQ.left != null)
        {
            pValsToCheck.Push(currentP.left);
            qValsToCheck.Push(currentQ.left);
        }
        else
        {
            if (currentP.left != null || currentQ.left != null) return false;
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