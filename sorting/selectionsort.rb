###########################################
#Selection Sort Implementation in Ruby
############################################
#inputArray = [1,6,7,56,32,67]
inputArray = (1..15).to_a.shuffle
n = inputArray.length-1
for i in 0..n
	j = i
	while j>0 and inputArray[j-1] > inputArray[j]
		inputArray[j-1] = inputArray[j-1] ^ inputArray[j]
		inputArray[j] = inputArray[j-1] ^ inputArray[j]
		inputArray[j-1] = inputArray[j-1] ^ inputArray[j]
		j -= 1
	end
end

inputArray.each do |num|
	puts num
end
