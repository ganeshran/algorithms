function baseClass() {
	this.property1 = 5;
	this.property2 = "Hello world";

	this.method1 = function fn0 (){
		return this.property1
	};
}

var classEg = new baseClass();
console.log(classEg.method1())

