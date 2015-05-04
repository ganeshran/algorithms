class Node
	attr_accessor :value, :next_node

	def initialize val, next_in_line
		@value = val
		@next_node = next_in_line
	end
end
