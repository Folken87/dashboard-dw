import { createApp } from "vue";
import AppWrapper from "./App.vue";
import Router from "./Router/Router";
import Store from "./Store/Store";
import VueSimpleSVG from 'vue3-simple-svg'

// eslint-disable-next-line
const App = createApp(AppWrapper)
.use(Store)
.use(Router)
.use(VueSimpleSVG)
.mount("#app");
