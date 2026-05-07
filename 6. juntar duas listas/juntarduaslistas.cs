public class Solution
{
  public ListNode MergeTwoLists(ListNode list1, ListNode list2)
  {
    ListNode dummy = new ListNode(0);
    ListNode atual = dummy;


    while (list1 != null && list2 != null)
    {
      if (list1.val < list2.val)
      {
        atual.next = list1;
        list1 = list1.next;
        atual = atual.next;
      }

      else
      {
        atual.next = list2;
        list2 = list2.next;
        atual = atual.next;
      }
    }
    if (list1 != null)
    {
      atual.next = list1;
    }
    if (list2 != null)
    {
      atual.next = list2;
    }
    return dummy.next;
  }
}