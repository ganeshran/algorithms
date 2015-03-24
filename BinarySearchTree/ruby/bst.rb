require './node'

class BinarySearchTree
	@root_node

	def initialize(rootData)
		@root_node = Node.new rootData
	end

	def root
		@root_node
	end

	def add value
		@root_node.add value
	end

	def traversal
		traverse @root_node
	end

	def traverse (node)
		if node == nil
			return
		end
		traverse (node.left)
		puts node.data
		traverse (node.right)
	end

	def self.get_tree
		bst = BinarySearchTree.new 10
		bst.add (8)
		bst.add (5)
		bst.add (12)
		bst.add (16)
		bst.add (11)
		bst.add (9)
		bst.add (6)
		bst
	end
end

