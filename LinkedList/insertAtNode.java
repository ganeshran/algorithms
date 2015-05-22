Node InsertNth(Node head, int data, int position) {
	Node newNode;
	if(head == null)
	{
		head = new Node();
		head.data = data;
		return head;
	}

	if(position == 0)
	{
		newNode = new Node();
		newNode.data = data;
		newNode.next = head;
		return newNode;
	}
	Node current_ptr = head;
	for(int i =0; i < position-1;i++)
	{
		current_ptr = current_ptr.next;
	}

	Node temp = current_ptr.next;
	newNode = new Node();
	newNode.data = data;
	current_ptr.next = newNode;
	newNode.next = temp;




	return head;
}
