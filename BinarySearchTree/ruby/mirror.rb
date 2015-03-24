require './bst'

class Mirror 
	def init
		bst = BinarySearchTree.get_tree()
		bst.traversal
		reversed = mirror(bst.root)
		puts 'Calling reverse'
		bst.traverse reversed
	end

	def mirror (bst)
		if(bst == nil)
			return
		end
		temp = bst.left
		bst.left = bst.right
		bst.right = temp
		mirror(bst.left)
		mirror(bst.right)
		return bst
	end
end

Mirror.new.init
