class String
	def self.add_new_method(name, &logic) 
		send(:define_method, name) { |*args|
			puts "you created a name named #{name}"
			logic.call(*args)
		}
	end
end

String.add_new_method("add_numbers") do |x,y|
	puts "here is our logic"
	puts x+y
end

"This is a string".add_numbers(1,2)

