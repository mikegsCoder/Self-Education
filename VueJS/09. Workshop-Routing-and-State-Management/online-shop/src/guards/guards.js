import { useUserStore } from '../store/userStore';

export function isUser() {
	const userStore = useUserStore();
	return userStore.isAuthenticated ? userStore.isAuthenticated : { path: '/login' };
};

export function isGuest() {
	const userStore = useUserStore();
	return userStore.isAuthenticated ? { path: '/profile' } : true;
};
