// ---------- namespaces ----------
var Personnel1;
(function (Personnel1) {
    var Employee1 = /** @class */ (function () {
        function Employee1(name) {
            this.name = name;
        }
        return Employee1;
    }());
    Personnel1.Employee1 = Employee1;
})(Personnel1 || (Personnel1 = {}));
var alice = new Personnel1.Employee1('Alice');
console.log(alice.name); // Alice
// ---------- namespaces example ---------
var Personnel2;
(function (Personnel2) {
    var Employee2 = /** @class */ (function () {
        function Employee2(name) {
            this.name = name;
        }
        return Employee2;
    }());
    Personnel2.Employee2 = Employee2;
    function work(emp) {
        console.log(emp.name, 'is working');
    }
    Personnel2.work = work;
    Personnel2.defaultUser = { name: 'Kate' };
    Personnel2.value = 'Hello';
})(Personnel2 || (Personnel2 = {}));
var tom = new Personnel2.Employee2('Tom');
Personnel2.work(tom); // Tom is working
console.log(Personnel2.defaultUser.name); // Kate
console.log(Personnel2.value); // Hello
