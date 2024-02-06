var User = /** @class */ (function () {
    function User(_name) {
        this.name = _name;
    }
    return User;
}());
var user = new User("Michael");
var header = this.document.getElementById("header");
header.innerHTML = "Hello, " + user.name + "!";
