def fibo_bu n
	fib = []
	fib[0] = 0
	fib[1] = 1
	for k in 2..n
		fib[k] = fib[k-1] + fib[k-2]
	end
	return fib[n]
end

def fibo_classic n
	if n < 2
		return n
	end
	return fibo_classic(n-1) + fibo_classic(n-2)	
end

num = 40
startTime = Time.now
puts fibo_bu(num)
endTime = Time.now
puts endTime - startTime
startTime = Time.now
puts fibo_classic(num)
endTime = Time.now
puts endTime - startTime
