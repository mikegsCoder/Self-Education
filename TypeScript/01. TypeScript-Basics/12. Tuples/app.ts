// ---------- tuples ----------
let user: [string, number] = ['Tom', 36];

console.log(user[1]);  // 36
user[1] = 37;
console.log(user[1]);  // 37

// ---------- tuples example ----------
for (const prop of user) {
  console.log(prop);
}
