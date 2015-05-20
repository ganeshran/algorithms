var PersonProto = {
	describe: function() {
		return "Person named " + this.name;
	}
};

var jane = {
	__proto__:PersonProto,
	name: 'Ganesh'
};

var tarzan = {
	__proto__:PersonProto,
	name: 'Tarzan'
}

function Person(name) {
	this.name = name;
	this.describe = function() {
		return "Person named " + this.name;
	};
};

function JunglePerson(jungle) {
	this.jungle = jungle;

};

JunglePerson.prototype = new Person();


var person = new Person('Ganesh');
var junglePerson = new JunglePerson("Tarzan");
console.log(person.describe());
