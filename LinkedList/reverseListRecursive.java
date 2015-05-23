Node Reverse(Node head) {
	if(head == null)
		return null;
	else
		return ReverseList(head,null);

}

Node ReverseList(Node next, Node current){

	if (next == null)
		return null;
	if(next.next == null)
	{
		next.next = current;
		return next;
	}
	Node rest = this.ReverseList(next.next,next);
	next.next = current;
	return rest;
}

