import { createRouter, createWebHashHistory } from "vue-router";
import ApplicationWrapper from "../components/ApplicationWrapper.vue";
import MainPage from "../components/Pages/MainPage/MainPage.vue";
const Routes = [
  {
    path: "/",
    name: "Главная",
    component: ApplicationWrapper,
    children: [
      {
        name: "Мониторинг эффективности молодежной политики",
        path: "/",
        component: MainPage,
        children: [
          // {
          //   name: "test2",
          //   path: "/test/test2",
          //   component: test2,
          //   children: [],
          // },
        ],
      },
      {
        name: "Анализ данных молодежной политики России",
        path: "/test",
        component: null,
        children: [
          // {
          //   name: "test2",
          //   path: "/test/test2",
          //   component: test2,
          //   children: [],
          // },
        ],
      },
    ],
  },
];

const Router = createRouter({
  history: createWebHashHistory(),
  routes: Routes,
});

export default Router;
