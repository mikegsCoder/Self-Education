class KeyValuePair<T, U> {
  private _pairs: {key: T, value: U}[] = [];

  public setKeyValue(key: T, value: U) {
    this._pairs.push({key, value})
  }

  public display() {
    this._pairs.forEach(element => {
      console.log(`key = ${element.key}, value = ${element.value}`);
    })
  }
}

let kvp = new KeyValuePair<number, string>();
kvp.setKeyValue(1, "Steve");
kvp.display();
