/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode pre = null;
        ListNode cur = head;
        if(head == null) return null;
        while(cur != null){
            Console.WriteLine(cur.val);
            ListNode next = cur.next; 
            cur.next = pre;  //1.next = null
            pre = cur;
            cur = next;
        }
        //if(cur!=null) Console.WriteLine(cur.val);
        
        return pre;
    }
}