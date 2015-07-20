require './bst'
require './int'


sample = BinarySearchTree.get_tree

def is_bst_helper(node,min,max)
	
	if node == nil
		return true
	end

#	puts "Data: #{node.data}, Min: #{min}, Max: #{max}"
	if node.data < min || node.data > max
		return false
	end

	return is_bst_helper(node.left,min,node.data-1) &&
	       is_bst_helper(node.right,node.data+1,max)
end

def is_bst(node)
	puts is_bst_helper(node,-5000,5000)
end
#sample.root.left.left.data  = 15
#sample.traverse(sample.root)
puts is_bst(sample.root)
