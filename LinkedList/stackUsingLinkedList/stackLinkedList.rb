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
		temp = @list.head
		@list.head = @list.head.next_node
		temp.value
	end

	def peek
		@list.head.value
	end
end

stack = Stack.new
stack.pop
stack.pop
stack.pop
stack.pop
stack.push(10)
stack.push(42)
stack.push(23)
puts stack.peek
