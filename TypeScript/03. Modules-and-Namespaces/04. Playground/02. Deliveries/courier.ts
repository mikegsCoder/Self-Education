import FoodAndBeverages from './FoodAndBeverages';

class Courier implements FoodAndBeverages.Delivery {
  protected placesToVisit: { customerName: string; visited: boolean }[];

  constructor(placesToVisit: { customerName: string; visited: boolean }[]) {
    this.placesToVisit = placesToVisit;
  }

  newCustomer(customerName: string, visited: boolean = false): void {
    const existingCustomer = this.placesToVisit.find(
      (customer) => customer.customerName === customerName
    );

    if (existingCustomer) {
      throw new Error(`${customerName} is already a customer of yours!`);
    }

    this.placesToVisit.push({ customerName, visited });
    console.log(`${customerName} just became your client.`);
  }

  visitCustomer(customerName: string): string {
    const customer = this.placesToVisit.find(
      (customer) => customer.customerName === customerName
    );

    if (!customer) {
      throw new Error(`${customerName} is not your customer.`);
    }

    customer.visited = true;
    return `${customerName} -> ${customer.visited}`;
  }

  showCustomers(): string {
    let result = '';

    this.placesToVisit.forEach((customer) => {
      result += `${customer.customerName} -> ${customer.visited}\n`;
    });

    return result;
  }
}

// Example usage:
let courier = new Courier([{ customerName: "DHL", visited: false }]);

courier.newCustomer("Speedy");
courier.newCustomer("MTM");
courier.newCustomer("TipTop");

courier.visitCustomer("DHL");
courier.visitCustomer("MTM");
courier.visitCustomer("MTM");

console.log(courier.showCustomers());
