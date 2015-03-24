##############################
#Binary Search Tree
###############################

class Node
	@left_node
	@right_node
	@data

	def initialize (data)
		@data = data
	end

	def left
		@left_node
	end

	def left=(value)
		@left_node = value
	end

	def right
		@right_node
	end

	def right=(value)
		@right_node= value
	end

	def data
		@data
	end
end


