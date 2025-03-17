//sort a linked list. my second attempt with a linked list!
//Honestly I think I did pretty well. It only took a few minutes. This was frustrating because there was no way to test it
//within VS code, so I had to keep submitting and hoping I would get the right answer (because I didn't know how to write my own custom cases, such as
//head being empty

ListNode DeleteDuplicates(ListNode head)
{
    if (head == null) return head;
    ListNode beginning = head;
    while (head.next != null)
    {
        if (head.val == head.next.val)
        {
            try
            {
                head.next = head.next.next;
            }
            catch (Exception e)
            {
                head.next = null;
            }
        }
        if (head.next != null && head.val != head.next.val) head = head.next;
    }
    return beginning;
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