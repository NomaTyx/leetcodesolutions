//Leetcode easy. First time doing anything with a tree so i'll take it.
//i'm not 100% that recursion is the easiest solution but I need the practice doing recursive functions

IList<int> InorderTraversal(TreeNode root)
{
    List<int> vals = new List<int>();

    if (root == null) return [];

    foreach (int i in InorderTraversal(root.left))
    {
        vals.Add(i);
    }

    vals.Add(root.val);

    foreach (int i in InorderTraversal(root.right))
    {
        vals.Add(i);
    }

    return vals;
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