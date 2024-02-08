// ---------- void ----------
function hello() {
  console.log("Hello TypeScript!");
};

const message: () => void = hello;
message();
