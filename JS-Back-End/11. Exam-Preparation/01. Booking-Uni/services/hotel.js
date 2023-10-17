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

async function bookHotel(hotelId, userId) {
    const hotel = await Hotel.findById(hotelId);
    const user = await User.findById(userId);

    if (user._id == hotel.owner) {
        throw new Error('Cannot book your own hotel.');
    }

    user.bookedHotels.push(hotelId);
    hotel.bookedBy.push(userId);
    hotel.rooms--;

    return Promise.all([user.save(), hotel.save()]);
}

async function deleteHotel(id) {
    return Hotel.findByIdAndDelete(id);
}

module.exports = {
    createHotel,
    getAllHotels,
    getHotelById,
    editHotel,
    bookHotel,
    deleteHotel
};