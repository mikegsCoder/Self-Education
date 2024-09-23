import { axiosInstance } from './axios';

async function getAllProducts() {
  try {
    const res = await axiosInstance.get('products');
    return res.data;
  }
  catch (error) {
    console.error(error);
    return {
      products: [],
      total: 0,
      skip: 0,
      limit: 0,
    };
  }
}

export { getAllProducts };
