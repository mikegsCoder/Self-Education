var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// ---------- abstract class ----------
var Figure1 = /** @class */ (function () {
    function Figure1() {
    }
    return Figure1;
}());
// let someFigure = new Figure1()  // Error!
// ---------- abstract class example ----------
var Figure2 = /** @class */ (function () {
    function Figure2() {
    }
    Figure2.prototype.getArea = function () {
        console.log('Not Implemented!');
    };
    return Figure2;
}());
var Rectangle2 = /** @class */ (function (_super) {
    __extends(Rectangle2, _super);
    function Rectangle2(width, height) {
        var _this = _super.call(this) || this;
        _this.width = width;
        _this.height = height;
        return _this;
    }
    Rectangle2.prototype.getArea = function () {
        var square = this.width * this.height;
        console.log('area =', square);
    };
    return Rectangle2;
}(Figure2));
var someFigure2 = new Rectangle2(20, 30);
someFigure2.getArea(); // area = 600
// ---------- abstract method ----------
var Figure3 = /** @class */ (function () {
    function Figure3() {
    }
    return Figure3;
}());
var Rectangle3 = /** @class */ (function (_super) {
    __extends(Rectangle3, _super);
    function Rectangle3(width, height) {
        var _this = _super.call(this) || this;
        _this.width = width;
        _this.height = height;
        return _this;
    }
    Rectangle3.prototype.getArea = function () {
        var square = this.width * this.height;
        console.log('area =', square);
    };
    return Rectangle3;
}(Figure3));
var someFigure3 = new Rectangle3(20, 30);
someFigure3.getArea(); // area = 600
// ---------- abstract field ----------
var Figure4 = /** @class */ (function () {
    function Figure4() {
    }
    return Figure4;
}());
var Rectangle4 = /** @class */ (function (_super) {
    __extends(Rectangle4, _super);
    //x: number;
    //y: number;
    function Rectangle4(x, y, width, height) {
        var _this = _super.call(this) || this;
        _this.x = x;
        _this.y = y;
        _this.width = width;
        _this.height = height;
        return _this;
    }
    Rectangle4.prototype.getArea = function () {
        var square = this.width * this.height;
        console.log('area =', square);
    };
    return Rectangle4;
}(Figure4));
var someFigure = new Rectangle4(10, 10, 20, 25);
someFigure.getArea(); // area = 500
