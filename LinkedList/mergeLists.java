/*
 *   Insert Node at the end of a linked list 
 *     head pointer input could be NULL as well for empty list
 *       Node is defined as 
 *         class Node {
 *              int data;
 *                   Node next;
 *                     }
 *                     */

Node MergeLists(Node list1, Node list2) {
	Node head;
	if(list1.data > list2.data)
	{
		head = list2;
		list2 = list2.next;
	}
	else
	{
		head = list1;
		list1 = list1.next;
	}

	while(list1 != null || list2 != null)
	{
		if(list1 == null || list1.data > list2.data)
		{
			head.next = list2;
			list2 = list2.next;
		}
		else
		{
			head.next = list1;
			list1 = list1.next;
		}
		head = head.next;
	}

	return head;

}
