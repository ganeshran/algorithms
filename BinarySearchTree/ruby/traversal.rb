require './bst'

class InOrderTraversal
	def init
		bst = BinarySearchTree.get_tree()

		traverse bst.root
	end

	def traverse node
		if node == nil
			return
		end
		traverse(node.left)
		puts node.data
		traverse(node.right)
	end
end

InOrderTraversal.new.init




