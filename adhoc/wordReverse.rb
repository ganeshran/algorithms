testString = "This is a test string"
outputString = ''

testString.split(" ").each do |word|
	outputString << "#{word.reverse} " 
end

puts outputString

