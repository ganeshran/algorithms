function baseClass() {
	this.property1 = 5;
	this.property2 = "Hello world";

	this.method1 = function fn0 (){
		console.log("this is a method in the base class class");
	};
}

function derivedClass() {
	this.childProperty = 10;
	};

derivedClass.prototype = new baseClass();
derivedClass.prototype.method1 = function fn1() {
		console.log("this is a method in the derived class");
	};
 


var instance = new derivedClass();
console.log(instance.property1);
console.log(instance.childProperty);
instance.method1();
