def parity x
	result = 0
	while(x > 0)
		result ^= (x & 1)
		x >>= 1
	end
	result
end

res = parity 14235446788793452343462323434547658
puts res
