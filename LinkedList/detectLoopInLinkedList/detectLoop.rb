require '../linkedList.rb'

def detectLoop list
	current_ptr = list.head
	ref_ptr = list.head

	while(ref_ptr.next_node != nil) do
		current_ptr = current_ptr.next_node
		ref_ptr = ref_ptr.next_node.next_node
		if(current_ptr == ref_ptr)
			puts 'Loop is found'
			return 
		end
	end
	puts 'No Loop Found'
end

sample = LinkedList.get_loop_sample
detectLoop sample
