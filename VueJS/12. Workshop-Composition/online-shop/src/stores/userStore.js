import { defineStore } from 'pinia';
import { ref } from 'vue';

export const useUserStore = defineStore('user', () => {
  const isAuthenticated = ref(false);
  const profile = ref(null);
  const favouritesIDs = ref([]);

  function setProfile(profileData) {
    profile.value = profileData;
    isAuthenticated.value = true;
    sessionStorage.setItem('user-profile', JSON.stringify(profileData));
  }

  function addFavouriteProduct(id) {
    favouritesIDs.value.push(id);
  }

  function removeFavouriteProduct(id) {
    favouritesIDs.value = favouritesIDs.value.filter(favourite => favourite !== id);
  }

  function getPersistedProfile() {
    const persisted = sessionStorage.getItem('user-profile');
    if (!persisted)
      return;
    profile.value = JSON.parse(persisted);
    isAuthenticated.value = true;
  }

  function userStoreLogout() {
    isAuthenticated.value = false;
    profile.value = null;
    sessionStorage.removeItem('user-profile');
  }

  return {
    isAuthenticated,
    profile,
    favouritesIDs,
    setProfile,
    addFavouriteProduct,
    removeFavouriteProduct,
    getPersistedProfile,
    userStoreLogout
  };
});
