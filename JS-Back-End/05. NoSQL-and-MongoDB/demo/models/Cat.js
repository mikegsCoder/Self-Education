const mongoose = require('mongoose');

const catSchema = new mongoose.Schema({
    name: { 
        type: String, 
        required: true,
        validate: {
            validator: function(value) {
                const letter = value.slice(0,1);
                return letter === letter.toLocaleUpperCase();
            },
            // message: props => `Name must begin with capital letter - ${Object.keys(props)}.`
            message: props => `Name must begin with capital letter - ${props.value}.`
        }
    },
    color: { 
        type: String, 
        required: true,
        enum: {
            values: ['Grey', 'Orange', 'White', 'Black', 'Mixed'],
            message: 'Invalid color!'
        }
    }
});

const Cat = mongoose.model('Cat', catSchema);

module.exports = Cat;