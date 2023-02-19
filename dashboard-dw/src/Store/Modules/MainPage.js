export default {
  namespaced: true,
  state: {
    stats: {
      0: {
        labels: ["Региональные структуры", "Муниципальные структуры"],
        datasets: [
          {
            borderRadius: 15,
            label: "Финансирование",
            backgroundColor: ["#453B90", "#453B90"],
            data: [0, 0],
          },
          {
            borderRadius: 15,
            label: "Мероприятия",
            backgroundColor: ["#8C64D8", "#8C64D8"],
            data: [0, 0],
          },
        ],
      },
      1: {
        labels: ["Школа", "СПО", "ВУЗ"],
        datasets: [
          {
            label: "Бюджет",
            backgroundColor: "#8C64D8",
            data: [0, 0, 0],
            countPeople: [],
            pointStyle: "rect",
            order: 1,
            borderRadius: 5,
            datalabels: {
              color: "black",
              anchor: "center",
              align: "end",
              formatter: Math.round,
              font: {
                weight: "bold",
                family: "GT Eesti LC Text",
              },
            },
            countGrant: 0,
            countMember: 0,
          },
          {
            label: "Количество организаций",
            backgroundColor: "#FA873A",
            borderColor: "#FA873A",
            data: [0, 0, 0],
            countPeople: [],
            type: "line",
            order: 0,
            pointStyle: "circle",
            datalabels: {
              display: false,
            },
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
      3: {
        labels: ["VueJs", "EmberJs", "ReactJs", "AngularJs"],
        datasets: [
          {
            label: "Data one",
            backgroundColor: ["#41B883", "#E46651", "#00D8FF", "#DD1B16"],
            data: [40, 20, 80, 10],
            countPeople: [],
          },
        ],
      },
      4: {
        labels: ["Школа", "СПО", "ВУЗ"],
        datasets: [
          {
            label: "Количество общественных объединений МП",
            backgroundColor: "#8C64D8",
            data: [0, 0, 0],
            countPeople: [],
            pointStyle: "rect",
            order: 1,
            borderRadius: 5,
            datalabels: {
              color: "black",
              anchor: "center",
              align: "end",
              formatter: Math.round,
              font: {
                weight: "bold",
                family: "GT Eesti LC Text",
              },
            },
          },
          {
            label: "Численность обучающихся",
            backgroundColor: "#FA873A",
            borderColor: "#FA873A",
            data: [0, 0, 0],
            countPeople: [],
            type: "line",
            order: 0,
            pointStyle: "circle",
            datalabels: {
              display: false,
            },
          },
        ],
      },
      6: {
        labels: [],
        datasets: [
          {
            label: "Кол-во",
            backgroundColor: ["#453B90", "#8C64D8", "#DAEF14", "#FA873A"],
            data: [],
            countPeople: [],
            munVal: 0,
            regVal: 0,
            countForum: 0,
          },
        ],
      },
      7: {
        labels: [],
        datasets: [
          {
            label: "Кол-во",
            backgroundColor: ["#453B90", "#8C64D8", "#DAEF14", "#FA873A"],
            data: [],
            countPeople: [],
            countRegCenters: 0,
            countGov: 0,
          },
        ],
      },
    },
    atrtittionYouth: [],
    subjects: [],
    youngForum: [],
    volonteur: [],
    r2: [],
  },
  getters: {
    getStats: (state) => (id) =>
      state.stats[id] || {
        labels: [],
        datasets: [],
      },
    getSubjectInfo: (state) => (id) => {
      let temp = state.subjects.find((el) => el.id === id) || null;
      if (temp == null) return null;
     
      temp.countPeople = state.atrtittionYouth
        .filter((el) => el.subjectId == id)
        .reduce((sum, x) => sum + x.youngCount * 1000, 0);
      temp.percentLeave = state.atrtittionYouth
        .filter((el) => el.subjectId == id)
        .reduce((sum, x) => sum + x.partAttritionYoung, 0);
        let filtered = state.r2
        .filter((el) => el.subjectId == id)
      temp.countStruct = filtered
        .reduce((sum, x) => sum + x.countStruct, 0);
      temp.countWorkers = filtered
        .reduce((sum, x) => sum + x.countWorkers, 0);
      return temp;
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
    },
    setR6Data(state, payload) {
      state.youngForum = payload;
      let categoryForum = new Map();
      payload.forEach((el) => {
        state.stats[6].datasets[0].countForum += el.countForum;
        state.stats[6].datasets[0].regVal += el.finRegVal;
        state.stats[6].datasets[0].munVal += el.finMunVal;
        state.stats[6].datasets[0].countMember += el.countMemberForum;
        if (categoryForum.has(el.r6CatName)) {
          categoryForum.set(
            el.r6CatName,
            categoryForum.get(el.r6CatName) + el.countMemberForum
          );
        } else {
          categoryForum.set(el.r6CatName, 0);
        }
      });
      state.stats[6].labels = [...categoryForum.keys()];
      state.stats[6].datasets[0].data = [...categoryForum.values()];
    },
    setR7Data(state, payload) {
      state.volonteur = payload;
      // let catNames = new Map();
      let ages = new Map();
      payload.forEach((el) => {
        if (el.r7CatId > 1 && el.r7CatId < 9) {
          state.stats[7].datasets[0].countGov += el.val;
        }
        if (el.r7CatId > 8 && el.r7CatId < 13) {
          if (ages.has(el.r7CatName)) {
            ages.set(el.r7CatName, ages.get(el.r7CatName) + el.val);
          } else {
            ages.set(el.r7CatName, 0);
          }
        }
        if (el.r7CatId === 1) {
          state.stats[7].datasets[0].countRegCenters += el.val;
        }
      });
      state.stats[7].labels = [...ages.keys()];
      state.stats[7].datasets[0].data = [...ages.values()];
    },
    setR4_2Data(state, payload) {
      payload.forEach((el) => {
        state.stats[4].datasets[0].data[0] += el.countUnionSch;
        state.stats[4].datasets[0].data[1] += el.countUnionSPO;
        state.stats[4].datasets[0].data[2] += el.countUnionHS;
        state.stats[4].datasets[1].data[0] += el.countUnionSchMembers;
        state.stats[4].datasets[1].data[1] += el.countUnionSPOMembers;
        state.stats[4].datasets[1].data[2] += el.countUnionHSMembers;
      });
    },
    setR1Data(state, payload) {
      let categories = new Map();
      let categories2 = new Map();
      payload.forEach((el) => {
        if (categories.has(el.r1CatName)) {
          categories.set(
            el.r1CatName,
            categories.get(el.r1CatName) +
              (el.budgetSRF + el.budgetMO) / 1000000
          );
        } else {
          categories.set(el.r1CatName, 0);
        }
        if (categories2.has(el.r1CatName)) {
          categories2.set(
            el.r1CatName,
            categories2.get(el.r1CatName) + el.countChildCompany
          );
        } else {
          categories2.set(el.r1CatName, 0);
        }
        state.stats[1].datasets[0].countGrant += el.countGrant;
        state.stats[1].datasets[0].countMember += el.countEventMember;
      });
      let m2 = new Map([...categories.entries()].sort((a, b) => b[1] - a[1]));
      console.log(categories);
      console.log(categories2);
      let map = m2;
      let arrayTmp = Array.from(map).slice(0, 5);
      let myMap = new Map(arrayTmp);
      console.log(myMap);
      state.stats[1].labels = [...myMap.keys()];
      state.stats[1].datasets[0].data = [...myMap.values()];
      for (let i = 0; i < 5; i++) {
        state.stats[1].datasets[1].data[i] = categories2.get(
          state.stats[1].labels[i]
        );
      }
    },
    setR2Data(state, payload) {
      state.r2 = payload;
      payload.forEach((el) => {
        state.stats[0].datasets[el.r2CatId - 1].data[0] += Math.floor(
          el.countFinValue / 1000000
        );
        state.stats[0].datasets[el.r2CatId - 1].data[1] += Math.floor(
          el.costsEvents / 1000000
        );
      });
    },
    setAtrtittionYouth(state, payload) {
      state.atrtittionYouth = payload;
      // console.log(state.atrtittionYouth);
    },
    setSubjects(state, payload) {
      state.subjects = payload;
    },
  },
  actions: {
    setR4Data({ commit }, payload) {
      commit("setR4Data", payload);
    },
    setR6Data({ commit }, payload) {
      commit("setR6Data", payload);
    },
    setR7Data({ commit }, payload) {
      commit("setR7Data", payload);
    },
    setR4_2Data({ commit }, payload) {
      commit("setR4_2Data", payload);
    },
    setR1Data({ commit }, payload) {
      commit("setR1Data", payload);
    },
    setR2Data({ commit }, payload) {
      commit("setR2Data", payload);
    },
    setAtrtittionYouth({ commit }, payload) {
      commit("setAtrtittionYouth", payload);
    },
    setSubjects({ commit }, payload) {
      commit("setSubjects", payload);
    },
  },
};
