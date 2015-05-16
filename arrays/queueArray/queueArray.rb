class Queue

	attr_accessor :store

	def initialize(array)
		@store = array
	end

	def Enqueue(value)
		@store.push(value)
	end

	def Dequeue
		temp = @store[0]
		@store.delete_at(0)
		temp
	end

	def Peek
		@store[0]
	end
end

q = Queue.new([1,2,3,4,5])
puts q.Dequeue
puts q.Dequeue
puts q.Dequeue
q.Enqueue(10)
q.Enqueue(11)
puts q.Dequeue

