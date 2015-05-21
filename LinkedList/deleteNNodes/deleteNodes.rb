require '../linkedList.rb'

def deleteMNNodes list,m,n
	iCounter = 1
	current_ptr = list.head
	ref_ptr = list.head
	while iCounter < m
		if ref_ptr.next_node != nil
			current_ptr = current_ptr.next_node
			ref_ptr = ref_ptr.next_node
		end
		iCounter += 1
	end
	iCounter = 0
	while iCounter < n
		if ref_ptr.next_node != nil
			ref_ptr = ref_ptr.next_node
		end
		iCounter += 1
	end
	current_ptr.next_node = ref_ptr.next_node

end

sample = LinkedList.get_sample
sample.print_list
deleteMNNodes(sample,2,9)
puts 'Nodes deleted'
sample.print_list

