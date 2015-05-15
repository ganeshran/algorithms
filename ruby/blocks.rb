def hello_world(&proc)
	5.times {proc.call}
end

#block is a chunk of code
#A def is a plain method
#A proc is an object that points to a block
# A block is a piece of code that is declared but not run in the place 
# it's written. The idea is to leave it up to the reciever"

def proc_example
	say_hi = proc {|name| puts "Hi #{name}"}
	say_hi.call("Ganesh")
end

def twice_do (action)
	action.call
	action.call
end

def call_twice_proc
	twice_do (proc {puts "hi"})
end
