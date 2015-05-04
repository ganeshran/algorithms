require './node.rb'

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
end
