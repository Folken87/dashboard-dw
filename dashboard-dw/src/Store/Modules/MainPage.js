export default {
  namespaced: true,
  state: {
    stats: {
      0: {
        labels: ["VueJs", "EmberJs", "ReactJs", "AngularJs"],
        datasets: [
          {
            label: "Data one",
            backgroundColor: ["#41B883", "#E46651", "#00D8FF", "#DD1B16"],
            data: [40, 20, 80, 10],
          },
        ],
      },
      1: {
        labels: [
          "January",
          "February",
          "March",
          "April",
          "May",
          "June",
          "July",
          "August",
          "September",
          "October",
          "November",
          "December",
        ],
        datasets: [
          {
            label: "Data One",
            backgroundColor: "#f87979",
            data: [40, 20, 12, 39, 10, 40, 39, 80, 40, 20, 12, 11],
          },
          {
            label: "Data Two",
            backgroundColor: "#f87979",
            data: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12],
          },
        ],
      },
      2: {
        labels: [],
        datasets: [
          {
            label: "Сумма",
            backgroundColor: ["#453B90", "#8C64D8", "#DAEF14", "#FA873A"],
            data: [],
            countPeople: [],
          },
        ],
      },
    },
  },
  getters: {
    getStats: (state) => (id) =>
      state.stats[id] || {
        labels: [],
        datasets: [],
      },
  },
  mutations: {
    setR4Data(state, payload) {
      let catNames = new Map();
      let countPeople = new Map();
      payload.forEach((el) => {
        if (catNames.has(el.categoryName)) {
          catNames.set(
            el.categoryName,
            catNames.get(el.categoryName) + el.finReg + el.finMunicip
          );
          countPeople.set(
            el.categoryName,
            countPeople.get(el.categoryName) +
              el.countMembersReg +
              el.countMembersMunicip
          );
        } else {
          catNames.set(el.categoryName, 0);
          countPeople.set(el.categoryName, 0);
        }
      });
      // console.log(countPeople.values());
      state.stats[2].labels = [...catNames.keys()];
      state.stats[2].datasets[0].data = [...catNames.values()].map((el) => {
        return el / 1000000;
      });
      state.stats[2].datasets[0].countPeople = [...countPeople.values()].map(
        (el) => {
          return el;
        }
      );
      console.log(state.stats[2]);
    },
  },
  actions: {
    setR4Data({ commit }, payload) {
      commit("setR4Data", payload);
    },
  },
};
