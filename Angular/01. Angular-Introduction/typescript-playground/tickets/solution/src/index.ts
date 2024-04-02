class Ticket {
  destination: string;
  price: number;
  status: string;

  constructor(destination: string, price: number, status: string) {
    this.destination = destination;
    this.price = price;
    this.status = status;
  }
}

let data = [
  "Philadelphia|94.20|available",
  "New York City|95.99|available",
  "New York City|95.99|sold",
  "Boston|126.20|departed",
];

let sorting = "destination";

let tickets: Ticket[];

data.forEach((element) => {
  let ticketData = element.split("|");
  let currentTicket = new Ticket(
    ticketData[0],
    Number(ticketData[1]),
    ticketData[2]
  );

  tickets.push(currentTicket);
});

var sortedTickets: Ticket[];

if (sorting == "destination") {
  sortedTickets = tickets.sort((n1, n2) => {
    if (n1.destination > n2.destination) {
      return 1;
    }

    if (n1.destination < n2.destination) {
      return -1;
    }

    return 0;
  });
} else if (sorting == "status") {
  sortedTickets = tickets.sort((n1, n2) => {
    if (n1 > n2) {
      return 1;
    }

    if (n1 < n2) {
      return -1;
    }

    return 0;
  });
} else {
  sortedTickets = tickets.sort((n1, n2) => n1.price - n2.price);
}

console.log(sortedTickets);
