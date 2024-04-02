var Ticket = (function () {
    function Ticket(destination, price, status) {
        this.destination = destination;
        this.price = price;
        this.status = status;
    }
    return Ticket;
}());
var data = [
    "Philadelphia|94.20|available",
    "New York City|95.99|available",
    "New York City|95.99|sold",
    "Boston|126.20|departed",
];
var sorting = "destination";
var tickets;
data.forEach(function (element) {
    var ticketData = element.split("|");
    var currentTicket = new Ticket(ticketData[0], Number(ticketData[1]), ticketData[2]);
    tickets.push(currentTicket);
});
var sortedTickets;
if (sorting == "destination") {
    sortedTickets = tickets.sort(function (n1, n2) {
        if (n1.destination > n2.destination) {
            return 1;
        }
        if (n1.destination < n2.destination) {
            return -1;
        }
        return 0;
    });
}
else if (sorting == "status") {
    sortedTickets = tickets.sort(function (n1, n2) {
        if (n1 > n2) {
            return 1;
        }
        if (n1 < n2) {
            return -1;
        }
        return 0;
    });
}
else {
    sortedTickets = tickets.sort(function (n1, n2) { return n1.price - n2.price; });
}
console.log(sortedTickets);
//# sourceMappingURL=index.js.map