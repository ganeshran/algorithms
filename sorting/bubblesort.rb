########################
#Bubble Sort Implementation in Ruby
########################
#inputArray = [1,6,7,56,32,67]
inputArray = (1..15).to_a.shuffle
n = inputArray.length-2

while n > 0 do 
	for i in 0..n
		if inputArray[i] > inputArray[i+1]
			inputArray[i] = inputArray[i] ^ inputArray[i+1]
			inputArray[i+1] = inputArray[i] ^ inputArray[i+1]
			inputArray[i] = inputArray[i] ^ inputArray[i+1]
		end
	end
	n -= 1
end

inputArray.each do |num|
	puts num
end
