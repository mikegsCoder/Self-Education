// ---------- method decorators ----------
function deprecated(
  target: any,
  propertyName: string,
  descriptor: PropertyDescriptor) {
  console.log('Method is deprecated');
}

interface PropertyDescriptor {
  configurable?: boolean;
  enumerable?: boolean;
  value?: any;
  writable?: boolean;
  get?(): any;
  set?(v: any): void;
}
