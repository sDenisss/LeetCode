

// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution {
    public static void Main(string[] args)
    {
        TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(2));
        TreeNode q = new TreeNode(1, new TreeNode(1), new TreeNode(2));
        Solution a = new Solution();
        System.Console.WriteLine(a.IsSameTree(p, q));
    }
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;
        if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}