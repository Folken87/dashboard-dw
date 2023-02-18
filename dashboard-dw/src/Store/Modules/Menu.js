export default {
  namespaced: true,
  state: {
    list: [
      {
        name: "Главная",
        path: "/",
        img: "menu1.svg"
      },
      {
        name: "Главная2",
        path: "/test",
        img: "menu1.svg"
      },
    ],
  },
  getters: {
    getList: (state) => state.list,
  },
  mutations: {},
  actions: {},
};
