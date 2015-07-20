def mergesort(list)
	return list if list.size <= 1
	mid = list.size / 2
	left  = list[0, mid]
	right = list[mid, list.size-mid]
	merge(mergesort(left), mergesort(right))
end

def merge(left, right)
	sorted = []
	until left.empty? or right.empty?
		if left.first <= right.first
			sorted << left.shift
		else
			sorted << right.shift
		end
	end
	sorted.concat(left).concat(right)
end


sortedArray = mergesort [1,6,3,4,5,2,8,7]
puts sortedArray
