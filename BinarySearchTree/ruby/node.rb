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

	def add (value)
		if(value < @data)
			if(@left_node == nil)
				@left_node = Node.new value
				return 
			else
				@left_node.add(value)
			end
		else
			if(@right_node == nil)
				@right_node = Node.new value
				return
			else
				@right_node.add(value)		
			end
		end
	end
end


