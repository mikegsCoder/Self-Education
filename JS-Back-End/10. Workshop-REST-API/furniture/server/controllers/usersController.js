const router = require("express").Router();

const { register, login } = require("../services/users");

router.post("/register", async (req, res) => {
    const { email, password } = req.body;

    try {
        if (!email.trim()) {
            throw new Error("Email is required.");
        }

        if (password.trim().length < 3) {
            throw new Error("Password must be at least 3 characters long.");
        }

        const userData = await register(email.toLocaleLowerCase().trim(), password.trim());

        res.json(userData);
    } catch (err) {
        res.status(err.status || 400).json({ message: err.message });
    }
});

module.exports = router;
