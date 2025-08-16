public class Program
{
    public static void Main()
    {
        var list = new ListNode(1, new ListNode(1, new ListNode(2)));
        Solution.DeleteDuplicates(list);
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public static ListNode DeleteDuplicates(ListNode head)
    {
        ListNode current = head;
        if (head == null || head.next == null)
        {
            return head;
        }


        while (current.next != null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        System.Console.WriteLine($"Deleting {head.val}");
        return head;
    }
}