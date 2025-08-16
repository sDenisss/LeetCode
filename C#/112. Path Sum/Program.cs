public class Program
{
    public static void Main()
    {
        TreeNode root = new TreeNode(5,
            new TreeNode(4,
                new TreeNode(11,
                    new TreeNode(7),
                    new TreeNode(2)
                ),
                null
            ),
            new TreeNode(8,
                new TreeNode(13),
                new TreeNode(4,
                    null,
                    new TreeNode(1)
                )
            )
        );

        Solution.HasPathSum(root, 22);
    }
}

public class TreeNode
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
public class Solution {
    public static bool HasPathSum(TreeNode root, int targetSum) {

        if (root == null)
            return false;

        if (root.left == null && root.right == null)
        {
            return root.val == targetSum;
        }

        int curTargetSum = targetSum - root.val;
        bool leftPath = HasPathSum(root.left, curTargetSum);
        bool rightPath = HasPathSum(root.right, curTargetSum);

        if (leftPath || rightPath)
        {
            return true;
        }

        return false;
    }
}