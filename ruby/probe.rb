class Probe
	@@count = 0

	def initialize
	end

	def deploy(deploy_time,return_time)
		puts "Deploying Probe at #{return_time}" 
	end


	def take_sample
		puts @@count
	end

	def self.count
		@@count += 1
		puts @@count
	end
end


class MineralProbe < Probe
	def deploy(deploy_time,return_time)
		puts "Mineral Probing"
		super
	end
end

