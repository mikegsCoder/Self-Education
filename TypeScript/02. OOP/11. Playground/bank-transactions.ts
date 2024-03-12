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

// ---------- solution ----------
abstract class CreateAccount<BankName, BankID> {
  constructor(readonly bankName: BankName, readonly bankID: BankID) { }

  abstract showDetails(): string;
}

class PersonalAccount<BankName, BankID> extends CreateAccount<BankName, BankID> {
  readonly ownerName: string;
  money: number = 0;
  recentTransactions: { [key: string]: number } = {};

  constructor(bankName: BankName, bankID: BankID, ownerName: string) {
    super(bankName, bankID);
    this.ownerName = ownerName;
  }

  deposit(amount: number): void {
    this.money += amount;
  }

  expense(amount: number, expenseType: string): void {
    if (this.money >= amount) {
      if (this.recentTransactions[expenseType]) {
        this.recentTransactions[expenseType] += amount;
      } else {
        this.recentTransactions[expenseType] = amount;
      }

      this.money -= amount;
    } else {
      throw new Error(`You can't make ${expenseType} transaction`);
    }
  }

  showDetails(): string {
    const totalMoneySpentOnExpenses = Object.values(this.recentTransactions)
      .reduce((a, c) => a + c, 0);

    return `Bank name: ${this.bankName}\n` +
      `Bank ID: ${this.bankID}\n` +
      `Owner name: ${this.ownerName}\n` +
      `Money: ${this.money}\n` +
      `Money spent: ${totalMoneySpentOnExpenses}`;
  }
}

let account = new PersonalAccount("DSK", 101240, "Ivan Ivanov");
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

let account2 = new PersonalAccount("Fibank", 100000, "Petar Petrov");
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