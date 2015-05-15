var  = Proc.new { |n| puts "Hello #{n}"} 

#block is a chunk of code
def hello_world(&proc)
	5.times {proc.call}
end

hello_world {puts "hello"}
