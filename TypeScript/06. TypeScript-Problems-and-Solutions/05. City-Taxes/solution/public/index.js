//tsc && node ./public/index.js
function cityTaxes(name, population, treasury) {
    const city = {
        name,
        population,
        treasury,
        taxRate: 10,
        collectTaxes: function () {
            this.treasury += Math.floor(this.population * this.taxRate);
        },
        applyGrowth: function (percentage) {
            this.population = Math.floor(this.population * (1 + percentage / 100));
        },
        applyRecession: function (percentage) {
            this.treasury -= Math.floor((this.treasury * percentage) / 100);
        },
    };
    return city;
}
console.log('First test');
const firstCity = cityTaxes('Tortuga', 7000, 15000);
console.log(firstCity);
console.log('Second test');
const secondCity = cityTaxes('Tortuga', 7000, 15000);
secondCity.collectTaxes();
console.log(secondCity.treasury);
secondCity.applyGrowth(5);
console.log(secondCity.population);
