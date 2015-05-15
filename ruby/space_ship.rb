class Rocket
	attr_accessor :name

	def initialize(name)
		self.name = name
	end

	def ==(other)
		name == other.name
	end
end

class SpaceShip
	attr_writer :destination

	def launch(destination)
		@destination = destination
	end

	private
	def test_private
		puts "Private method"
	end

end

class SpaceShip
	private
	def test_private
		puts "Monkey Patched Private Method"
	end
end

