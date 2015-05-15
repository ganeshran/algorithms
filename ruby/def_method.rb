class String
	def self.add_new_method(name)
		send(:define_method,name) {
			puts "You created a method named #{name} and context is #{self.class}"
		}
	end
end

String.add_new_method("Ganesh")
"Hello".send("Ganesh")


