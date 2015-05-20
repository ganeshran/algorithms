class Uniques
	def findUniques(inputArray)
		temp = 0
		inputArray.each do |num|
			temp ^= num
		end
		temp
	end
end

array = [4,5,6,7,7,3,5,4,6,3,2]
puts Uniques.new.findUniques array
