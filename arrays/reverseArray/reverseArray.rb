def recursiveReverse inputArray,start,last
	if(start>=last)	
		return
	end
	temp = inputArray[last]
	inputArray[last] = inputArray[start]
	inputArray[start] = temp
	recursiveReverse inputArray,start+1,last-1
end

def printArray inputArray
	inputArray.each do |arr|
		puts arr
	end
end

input = [3,4,6,9,10,2,5]
printArray input
puts "Reversing the Array"
recursiveReverse input,0,input.length-1
printArray input
