using System.Xml;

public class Program
{
    public static void Main(string[] args)
    {

        TreeNode treeNode1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

        Solution sol = new Solution();
        System.Console.WriteLine(sol.MaxDepth(treeNode1));
        // System.Console.WriteLine(sol.MaxDepth(4));
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null!, TreeNode right=null!) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return 1 + Math.Max(left, right);
    }
}