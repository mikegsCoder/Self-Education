import { axiosInstance } from './axios';

async function loginUser(userData) {
  try {
    const res = await axiosInstance.post('auth/login', userData);
    return res.data;
  }
  catch (error) {
    console.error(error);
    return null;
  }
}

export { loginUser };
