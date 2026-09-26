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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int index = 0;
        // xuwr ly khi remove node dau, cuoi, va list chi 1 node do
        int size = 0;
        ListNode cur = head;
        while(cur!= null){ // trả về count of linkedlist
            cur = cur.next;
            ++size;
        }
        // index  = count - n
        // cần đi tới node trước node remove;
        if(n == size){
            return head.next;
        }
        cur = head;
        while(index < size - n -1){
            cur = cur.next;
            ++index;
        }
        Console.WriteLine(cur.val);
        if(cur.next != null){
            cur.next = cur.next.next;
        } 
        
        return head;

    }
}