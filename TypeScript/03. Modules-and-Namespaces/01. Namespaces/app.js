var Personnel;
(function (Personnel) {
    var Employee = /** @class */ (function () {
        function Employee(name) {
            this.name = name;
        }
        return Employee;
    }());
    Personnel.Employee = Employee;
    var Manager = /** @class */ (function () {
        function Manager(name) {
            this.name = name;
        }
        return Manager;
    }());
    Personnel.Manager = Manager;
})(Personnel || (Personnel = {}));
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
// ---------- namespace in separate file ---------
/// <reference path='personnel.ts' />
var bob = new Personnel.Employee('Bob');
console.log(bob.name); // Bob
var sam = new Personnel.Manager('Sam');
console.log(sam.name); // Sam
// tsc --outFile app.js personnel.ts app.ts
// ---------- nested namespaces ---------
var Data1;
(function (Data1) {
    var Personnel3;
    (function (Personnel3) {
        var Employee3 = /** @class */ (function () {
            function Employee3(name) {
                this.name = name;
            }
            return Employee3;
        }());
        Personnel3.Employee3 = Employee3;
    })(Personnel3 = Data1.Personnel3 || (Data1.Personnel3 = {}));
    var Clients;
    (function (Clients) {
        var VipClient = /** @class */ (function () {
            function VipClient(name) {
                this.name = name;
            }
            return VipClient;
        }());
        Clients.VipClient = VipClient;
    })(Clients = Data1.Clients || (Data1.Clients = {}));
})(Data1 || (Data1 = {}));
var greg = new Data1.Personnel3.Employee3('Greg');
console.log(greg.name); // Greg
var jim = new Data1.Clients.VipClient('Jim');
console.log(jim.name); // Jim
