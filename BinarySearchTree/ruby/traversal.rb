require './bst'


bst = BinarySearchTree.new 10
bst.root.add (5)
bst.root.add (8)
bst.root.add (12)
bst.root.add (16)
bst.root.add (11)
bst.root.add (7)
bst.root.add (6)

puts bst.root.data
