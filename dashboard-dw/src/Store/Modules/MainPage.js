export default {
  namespaced: true,
  state: {
    stats: {
      0: {
        labels: ["VueJs", "EmberJs", "ReactJs", "AngularJs"],
        datasets: [
          {
            backgroundColor: ["#41B883", "#E46651", "#00D8FF", "#DD1B16"],
            data: [40, 20, 80, 10],
          },
        ],
      },
    },
  },
  getters: {
    getStats: (state) => (id) =>
      state.stats[id] || {
        labels: [],
        data: [],
      },
  },
  mutations: {},
  actions: {},
};
