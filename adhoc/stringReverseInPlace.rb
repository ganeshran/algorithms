testString = "This is a test String"

for i in 0..testString.length/2
	temp = testString[i]
	testString[i] = testString[testString.length-1-i]
	testString[testString.length-1-i] = temp
end

puts testString
