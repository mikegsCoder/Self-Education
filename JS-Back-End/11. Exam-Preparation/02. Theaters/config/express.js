const hbs = require("express-handlebars");
const express = require("express");
const cookieParser = require("cookie-parser");

module.exports = (app) => {
    app.engine("hbs", hbs.engine({ extname: ".hbs" }));
    app.set("view engine", "hbs");

    app.use("/static", express.static("static"));
    app.use(express.urlencoded({ extended: true }));

    app.use((req, res, next) => {
        if (!req.url.includes("favicon")) {
            console.log(">>>", req.method, req.url);

            if (req.user) {
                console.log("Known user:", req.user.username);
            }
        }

        next();
    });
};
