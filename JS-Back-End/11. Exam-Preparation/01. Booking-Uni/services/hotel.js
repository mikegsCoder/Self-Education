const Hotel = require('../models/Hotel');
const User = require('../models/User');

async function createHotel(hotelData) {
    const hotel = new Hotel(hotelData);
    await hotel.save();

    return hotel;
}

async function getAllHotels() {
    const hotels = await Hotel.find({}).lean();

    return hotels;
}

async function getHotelById(id) {
    const hotel = await Hotel.findById(id).lean();

    return hotel;
}

async function editHotel(id, hotelData) {
    const hotel = await Hotel.findById(id);

    hotel.name = hotelData.name.trim();
    hotel.city = hotelData.city.trim();
    hotel.imageUrl = hotelData.imageUrl.trim();
    hotel.rooms = Number(hotelData.rooms);

    return hotel.save();
}

module.exports = {
    createHotel,
    getAllHotels,
    getHotelById,
    editHotel
};