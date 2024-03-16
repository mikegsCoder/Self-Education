// ---------- default export ----------
export default class SmartWatch {
  constructor(private model: string) { }

  printModel() {
    console.log(`Model: ${this.model}`);
  }
}