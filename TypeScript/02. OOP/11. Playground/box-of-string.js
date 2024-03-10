/*
Create a generic class Box that takes one property from the
constructor. This property must be initialized with generic type.
Create a toString() method that returns a message in the following
format:
"{data} is of type {type}".
*/
// ---------- solution ----------
var Box = /** @class */ (function () {
    function Box(data) {
        this._data = data;
    }
    Box.prototype.toString = function () {
        return "".concat(this._data, " is of type ").concat(typeof (this._data));
    };
    return Box;
}());
var box1 = new Box(['test']);
var box2 = new Box(20);
var box3 = new Box('Hello');
console.log(box1.toString()); // 
console.log(box2.toString()); //
console.log(box3.toString()); //
