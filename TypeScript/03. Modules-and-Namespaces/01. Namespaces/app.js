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
