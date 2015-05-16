array = [1,2,3,4,5,6]

class Stack
	attr_accessor :internalStorage
	def initialize(array)
		@internalStorage = array
	end

	def push(value)
		@internalStorage.unshift(value)
	end

	def pop
		item = @internalStorage[0]
		@internalStorage.delete_at(0)
		item
	end

	def peek
		@internalStorage[0]
	end
end

stack = Stack.new array
puts stack.pop
puts stack.pop
puts stack.pop
stack.push 10
puts stack.peek
puts stack.internalStorage.inspect
puts stack.pop


