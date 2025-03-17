//leetcode easy
//this is sorta my first foray into linked lists. Didn't go too poorly, I didn't have to copy a tutorial verbatim, I was able to hear concepts and extrapolate on my own. 

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode temp = new ListNode();
    ListNode newList = temp;

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            temp.next = list1;
            list1 = list1.next;
        }
        else
        {
            temp.next = list2;
            list2 = list2.next;
        }
        temp = temp.next;
    }

    if (list1 != null)
    {
        temp.next = list1;
    }
    else
    {
        temp.next = list2;
    }

    return newList.next;
}

Console.WriteLine(MergeTwoLists([1, 2, 4, 5], [3, 4, 5]));

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