// tsc && node .\public\index.js
function solve(input) {
    const result = {};
    for (let line of input) {
        const [town, product, price] = line.split(' | ');
        if (result[product] == undefined) {
            result[product] = {};
        }
        result[product][town] = Number(price);
    }
    for (let [product, towns] of Object.entries(result)) {
        const sorted = Object.entries(towns).sort((a, b) => a[1] - b[1]);
        const [town, price] = sorted[0];
        console.log(`${product} -> ${price} (${town})`);
    }
}
