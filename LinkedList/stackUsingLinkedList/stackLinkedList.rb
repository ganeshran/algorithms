require '../linkedList.rb'

class Stack
	attr_accessor :list

	def initialize
		@list = LinkedList.get_sample()
	end

	def push(value)
		temp = @list.head
		node = Node.new(value,nil)
		node.next_node = temp
		@list.head = node
		
	end

	def print
		@list.print_list
	end


	def pop
	end

	def peek
	end
end

stack = Stack.new
stack.push(10)
stack.push(42)
stack.push(23)
stack.print
