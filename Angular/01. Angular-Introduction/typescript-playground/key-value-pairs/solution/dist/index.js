var KeyValuePair = (function () {
    function KeyValuePair() {
        this._pairs = [];
    }
    KeyValuePair.prototype.setKeyValue = function (key, value) {
        this._pairs.push({ key: key, value: value });
    };
    KeyValuePair.prototype.display = function () {
        this._pairs.forEach(function (element) {
            console.log("key = ".concat(element.key, ", value = ").concat(element.value));
        });
    };
    return KeyValuePair;
}());
var kvp = new KeyValuePair();
kvp.setKeyValue(1, "Steve");
kvp.display();
//# sourceMappingURL=index.js.map