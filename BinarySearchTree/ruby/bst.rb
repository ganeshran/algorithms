require './node'

class BinarySearchTree
	@root_node

	def initialize(rootData)
		@root_node = Node.new rootData
	end

	def root
		@root_node
	end

	def insert (newNodeData)
		if @rootNode.data > newNodeData
			insert(
	end
end
