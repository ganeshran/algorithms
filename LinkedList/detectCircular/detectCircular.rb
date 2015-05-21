require '../linkedList.rb'

def detectCircular list
	current_ptr = list.head
	ref_ptr = list.head
	while(ref_ptr.next_node != nil)
		current_ptr = current_ptr.next_node
		ref_ptr = ref_ptr.next_node.next_node
		if(current_ptr == ref_ptr)
			puts "this list is circular"
			return
		end
	end
	puts "this is not a circular list"

end

circular = LinkedList.get_circular_sample
detectCircular circular
sample = LinkedList.get_sample
detectCircular sample

