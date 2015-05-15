class Account
	attr_accessor :name, :address, :email, :notes

	def assign_values(values)
		values.each_key do |k|
			self.send("#{k}=",values[k])
		end
	end
end

user_info = {
	:name => "Matt",
	:address => "Some Random Address",
	:email => "someone@gmail.com",
	:notes => "MINSWAN"
}	

account = Account.new
account.assign_values(user_info)
puts account.inspect
