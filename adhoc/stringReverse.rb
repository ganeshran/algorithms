testString = "This is a test string"
outputString =''
for i in 0..testString.length-1 
	outputString << testString[testString.length-1-i]
end

puts outputString
