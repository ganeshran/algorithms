/*
 *   Insert Node at the end of a linked list 
 *     head pointer input could be NULL as well for empty list
 *       Node is defined as 
 *         class Node {
 *              int data;
 *                   Node next;
 *                     }
 *                     */
int CompareLists(Node headA, Node headB) {
	while(headA != null && headB != null)
	{
		if((headA.next != null && headB.next == null) || (headA.next == null && headB.next != null))
			return 0;
		if(headA.data != headB.data)
			return 0;
		headA = headA.next;
		headB = headB.next;
	}

	return 1;
}
