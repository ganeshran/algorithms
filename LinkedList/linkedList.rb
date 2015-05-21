class Node
	attr_accessor :value, :next_node

	def initialize val, next_in_line
		@value = val
		@next_node = next_in_line
	end
end

class LinkedList
	attr_accessor :head
	def initialize val
		@head = Node.new(val,nil)
	end

	def add value
		current = @head
		while(current.next_node != nil) do
			current = current.next_node
		end
		current.next_node = Node.new(value,nil)
	end

	def print_list
		current = @head
		while(current.next_node != nil) do
			puts current.value
			current = current.next_node
		end
	end

	def self.get_sample
		puts "Creating new Sample Linked List"
		sample = LinkedList.new(5)
		sample.add 3
		sample.add 7
		sample.add 9
		sample.add 12
		sample.add 2
		sample.add 8
		sample.add 6
		sample.add 16
		sample.add 23
		sample.add 1
		sample
	end

	def self.get_loop_sample
		puts "Creating Looped List"
		sample = LinkedList.new(5)
		headNode = sample.head
		headNode.next_node = Node.new(3,nil)
		headNode.next_node.next_node = Node.new(7,nil)
		headNode.next_node.next_node.next_node = Node.new(9,nil)
		current_ptr = headNode.next_node.next_node.next_node
		current_ptr.next_node = Node.new(11,nil)
		current_ptr.next_node.next_node = Node.new(13,nil)
		current_ptr.next_node.next_node.next_node = current_ptr
		sample
	end

	def self.get_circular_sample
		sample = LinkedList.get_sample
		current_ptr = sample.head
		while(current_ptr.next_node != nil)
			current_ptr = current_ptr.next_node
		end
		current_ptr.next_node = sample.head
		sample
	end
end
