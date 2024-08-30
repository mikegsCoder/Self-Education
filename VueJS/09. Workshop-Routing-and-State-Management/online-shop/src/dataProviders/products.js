import axios from 'axios';

export async function getAllProducts() {
  try {
    const res = await axios.get('https://dummyjson.com/products');
    return res.data;
  }
  catch (e) {
    console.error('Oops', e);
    return {
      products: [],
      total: 0,
      skip: 0,
      limit: 0,
    };
  }
}

