def removeElement(num,inputArray)
	index = 0
	for i in 0..inputArray.length-1
		if inputArray[i] != num
			inputArray[index] = inputArray[i]
			index += 1
		end
	end
	puts "Index #{index}"
	inputArray[0..index-1]
end

removeElement(3,[2,3,4,5,3,6,7,3,9,3]).each do |num|
	puts num
end
