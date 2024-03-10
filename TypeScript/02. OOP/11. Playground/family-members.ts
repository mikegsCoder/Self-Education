/*
Create a Family class with public property family which must be set 
to empty array through the constructor. 
The class must support 2 methods: a method for adding members to the 
family array – addNewMember(member) which is tuple of string and number 
which represents the name and the age of each member and a method 
oldestMember() which returns the oldest member in the family in the 
following format: "The oldest member is {name} and he is {age} years old."
*/

// ---------- solution 1 ----------
type Member = [string, number];

class Family1 {
  public family: Member[];

  constructor(family: Member[] = []) {
    this.family = family
  }

  addNewMember(value: Member) {
    this.family.push(value);
  }

  oldestMember() {
    let oldestMemberName: string = '';
    let oldestAge: number = -Infinity;

    this.family.forEach(([name, age]: Member) => {
      if (oldestAge < age) {
        oldestMemberName = name;
        oldestAge = age;
      }
    });

    return `The oldest member is ${oldestMemberName} and he is ${oldestAge} years old.`;
  }
}

const family1 = new Family1();
family1.addNewMember(['Ivan', 13]);
family1.addNewMember(['Todor', 45]);
family1.addNewMember(['Georgi', 37]);
family1.addNewMember(['Viktor', 30]);

console.log(family1.oldestMember()); // The oldest member is Todor and he is 45 years old.
