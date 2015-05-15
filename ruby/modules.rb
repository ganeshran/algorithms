module SpaceStuff

	def self.included(base)
		base.extend(ClassMethods)
	end

	def test
		puts 'Testing'
	end

	module ClassMethods
		def doSomething
			puts "Do Something"
		end
	end
end

module Ranger
	def ranging
		puts "This is a ranger method new one"
	end
end

module Rover
	def ranging
		puts "Rover ranger"
	end
end

class Gravity
	extend Rover
	include Rover

end

class CustomCraft
	def test
		puts " I am a testing method"
	end
end

module AdditionalMethods
	def new_method
		puts "I am a new method added inside a module"
	end
end

craft = CustomCraft.new
craft.extend(AdditionalMethods)
craft.new_method
