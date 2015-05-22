/*
 *   Insert Node at the end of a linked list 
 *     head pointer input could be NULL as well for empty list
 *       Node is defined as 
 *         class Node {
 *              int data;
 *                   Node next;
 *                     }
 *                     */
Node Insert(Node head,int x) {
	if(head == null)
	{
		head = new Node();
		head.data = x;
		return head;
	}

	Node current_ptr = head;
	while(current_ptr.next != null)
	{
		current_ptr = current_ptr.next;
	}

	current_ptr.next = new Node();
	current_ptr.next.data = x;

	return head;
}
