class TryCatch
	def throwExc(divisor)
		begin
			puts 2/divisor
		rescue ZeroDivisionError
			puts "Don't give zero

		rescue StandardError
			puts "The Standard Error catch block"
		end
	end
end
