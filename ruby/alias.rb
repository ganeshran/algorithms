class AliasTest
	def DoSomething
		puts 'I am doing something'
	end

	def method_missing(name, *args)
		puts 'THIS METHOD DOESNT EXIST'
	end

	def debug_only
		return nil unless @debug
		return nil unless block_given?
		puts "Running debug code..."
		yield @debug_attrs
	end

	alias_method "DoNothing", "DoSomething"
end
