import { axiosInstance } from './axios';

async function getAllCategories() {
  try {
    const res = await axiosInstance.get('products/categories');
    return res.data;
  }
  catch (error) {
    console.error(error);
    return [];
  }
}

export { getAllCategories };
