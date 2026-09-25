/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;
        // đặt điều kiện của fast thôi, vì fast đi được thì slow cũng đi đc
        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            if( fast == slow) return true;
        }
        return false;
    }
}