require './linkedList.rb'

def print_nth_from_last  link_list, n
	ref_ptr = link_list.head	
	current = link_list.head
	count = 0
	while count < n do
		if(ref_ptr == nil) 
			puts "Greater than number of nodes"
			return
		end
		ref_ptr = ref_ptr.next_node
		count += 1
	end

	while ref_ptr.next_node != nil do
		ref_ptr = ref_ptr.next_node
		current = current.next_node
	end
	puts current.value
end
sampleList = LinkedList.get_sample
puts "Printing List"
sampleList.print_list
puts "Finding nth element"
print_nth_from_last sampleList , 3
