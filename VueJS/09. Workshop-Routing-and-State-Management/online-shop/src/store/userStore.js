import { defineStore } from 'pinia';

export const useUserStore = defineStore('user', {
  state: () => {
    return {
      isAuthenticated: false,
      profile: null,
      favouritesIds: [],
    };
  },
  actions: {
    setProfile(profileData) {
      this.profile = profileData;
      this.isAuthenticated = true;
      sessionStorage.setItem('user-profile', JSON.stringify(profileData));
    },
    addFavouriteProduct(id) {
      this.favouritesIds.push(id);
    },
    removeFavouriteProduct(id) {
      this.favouritesIds = this.favouritesIds.filter(favourite => favourite !== id);
    },
  },
});
