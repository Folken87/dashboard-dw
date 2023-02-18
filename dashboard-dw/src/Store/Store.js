import { createStore } from "vuex";
import Menu from "./Modules/Menu";
import MainPage from "./Modules/MainPage";
const Store = createStore({
  state: {},
  getters: {},
  mutations: {},
  actions: {},
  modules: {
    Menu,
    MainPage
  },
});

export default Store;
