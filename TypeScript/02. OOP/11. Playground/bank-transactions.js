/*
Create an abstract generic class CreateAccount that takes two generic
type parameters: bankName and bankID.

Create a class PersonalAccount that extends CreateAccount and has
three properties of its own:
 - Readonly property ownerName (string)
 - Public property money (number) which is initially set to 0
 - Public property recentTransactions which is initially set to
   empty object
Only the ownerName is taken through the constructor.

Make the following three methods:
 - deposit(amount) – simply add the amount to the money you
   currently have
 - expense(amount, expenseType) – check if you have enough money
   (>= 0) to make the expense. If so put the expenseType as key and
   the amount as a value to the recentTransactions object.
   Furthermore, if have made the same expense more than once simply
   add the new amount to the existing one. However, if you don’t have
   enough money for the expense throw a new error:
   “You cant make {expenseType} transaction”
 - showDetails() – Calculate the total amount of money spent on
   expenses and return a message in the following format:

"Bank name: {bankName}
Bank ID: {bankID}
Owner name: {ownerName}
Money: {money}
Money spent: {totalMoneySpentOnExpenses}"
*/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// ---------- solution ----------
var CreateAccount = /** @class */ (function () {
    function CreateAccount(bankName, bankID) {
        this.bankName = bankName;
        this.bankID = bankID;
    }
    return CreateAccount;
}());
var PersonalAccount = /** @class */ (function (_super) {
    __extends(PersonalAccount, _super);
    function PersonalAccount(bankName, bankID, ownerName) {
        var _this = _super.call(this, bankName, bankID) || this;
        _this.money = 0;
        _this.recentTransactions = {};
        _this.ownerName = ownerName;
        return _this;
    }
    PersonalAccount.prototype.deposit = function (amount) {
        this.money += amount;
    };
    PersonalAccount.prototype.expense = function (amount, expenseType) {
        if (this.money >= amount) {
            if (this.recentTransactions[expenseType]) {
                this.recentTransactions[expenseType] += amount;
            }
            else {
                this.recentTransactions[expenseType] = amount;
            }
            this.money -= amount;
        }
        else {
            throw new Error("You can't make ".concat(expenseType, " transaction"));
        }
    };
    PersonalAccount.prototype.showDetails = function () {
        var totalMoneySpentOnExpenses = Object.values(this.recentTransactions)
            .reduce(function (a, c) { return a + c; }, 0);
        return "Bank name: ".concat(this.bankName, "\n") +
            "Bank ID: ".concat(this.bankID, "\n") +
            "Owner name: ".concat(this.ownerName, "\n") +
            "Money: ".concat(this.money, "\n") +
            "Money spent: ".concat(totalMoneySpentOnExpenses);
    };
    return PersonalAccount;
}(CreateAccount));
var account = new PersonalAccount("DSK", 101240, "Ivan Ivanov");
account.deposit(1000);
account.deposit(1000);
account.expense(700, "Buy new phone");
account.expense(400, "Book a vacation");
account.expense(400, "Book a vacation");
account.expense(100, "Buy food");
console.log(account.showDetails());
/*
Bank name: DSK
Bank ID: 101240
Owner name: Ivan Ivanov
Money: 400
Money spent: 1600
*/
var account2 = new PersonalAccount("Fibank", 100000, "Petar Petrov");
account2.deposit(10000);
account2.deposit(7000);
account2.expense(12000, "Buy a new car");
account2.expense(200, "Go to a fancy restaurant");
account2.expense(100, "Go to a bar");
account2.expense(30, "Go to the movies");
console.log(account2.showDetails());
/*
Bank name: Fibank
Bank ID: 100000
Owner name: Petar Petrov
Money: 4670
Money spent: 12330
*/ 
