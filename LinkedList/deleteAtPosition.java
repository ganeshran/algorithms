Node Delete(Node head, int position) {
	if(position == 0)
		return head.next;

	Node current_ptr = head;
	Node prev_ptr = head;
	for(int i=0;i<position;i++)
	{
		prev_ptr = current_ptr;
		current_ptr = current_ptr.next;
	}

	prev_ptr.next = current_ptr.next;
	return head;
}

