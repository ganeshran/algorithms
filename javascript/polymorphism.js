var answer = {
	get: function fn1() {
		return this.val;
	},
	val: 42
};

var firmAnswer = Object.create(answer);
firmAnswer.get = function fn2() {
	return answer.get.call(this) + '!!';
};

console.log(answer.get());
firmAnswer.val = 3.14;
console.log(firmAnswer.get());
