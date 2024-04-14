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
