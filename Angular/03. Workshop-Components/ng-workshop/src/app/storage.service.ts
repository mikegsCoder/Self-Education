interface IStorage {
  setItem<T>(key: string, item: T): T;
  getItem<T>(key: string): T;
}

export class StorageService implements IStorage {
  setItem<T>(key: string, item: T): T {
    return item;
  }
  getItem<T>(key: string): T {
    return null;
  }
}

export class BrowserStorage {
  localStorage = localStorage;

  setItem<T>(key: string, item: T): T {
    const str = typeof item === 'string' ? item : JSON.stringify(item);
    this.localStorage.setItem(key, str);
    return item;
  }

  getItem<T>(key: string): T {
    let item;
    const tmp = this.localStorage.getItem(key);

    if (!tmp) {
      return null;
    }

    try {
      item = JSON.parse(tmp || '');
    } catch {
      item = tmp;
    }

    return item;
  }
}

export class ServerStorage {
  localStorage = {
    data: {},
    setItem<T>(key: string, item: T): void {
      this.data[key] = item;
    },
    getItem<T>(key: string): T {
      return this.data[key];
    },
  };

  setItem<T>(key: string, item: T): T {
    this.localStorage.setItem(key, JSON.stringify(item));

    return item;
  }

  getItem<T>(key: string): T {
    let item;
    const tmp = this.localStorage.getItem(key) as any;

    if (!tmp) {
      return null;
    }

    try {
      item = JSON.parse(tmp);
    } catch {
      item = tmp;
    }

    return item;
  }
}
