<template>
  <div class="mainPage">
    <div class="header">
      <div class="name">
        <span>Мониторинг эффективности молодежной политики</span>
      </div>
      <div class="controls">
        <span>Регион</span>
        <span>Регион</span>
        <span>Регион</span>
      </div>
    </div>
    <div class="widgets">
      <StandartWidget id="a">
        <template v-slot:header
          >Количество учреждений молодёжной политики</template
        ></StandartWidget
      >
      <StandartWidget id="a1">
        <template v-slot:header
          >Бюджеты государственной молодeжной политики по направлениям</template
        ></StandartWidget
      >
      <StandartWidget id="a2">
        <template v-slot:header
          >Региональные/муниципальные структуры по работе с молодeжью (объемы
          финансирования)</template
        >
      </StandartWidget>
      <StandartWidget id="a3">
        <template v-slot:header
          >Структура молодежных общественных объединений</template
        >
        <template v-slot:default>
          <Doughnut
            :data="getStats(0)"
            :options="{
              resizeDelay: 0,
              responsive: true,
              maintainAspectRatio: false,
              // cutout: 50,
              plugins: {
                legend: {
                  position: 'right',
                },
              },
            }"
          />
        </template>
      </StandartWidget>
      <StandartWidget id="b">
        <template v-slot:header
          >Эффективность проведения молодежных форумов</template
        >
      </StandartWidget>
      <StandartWidget id="b1">
        <template v-slot:header>Портрет волонтера</template>
      </StandartWidget>
      <!-- <StandartWidget id="c"></StandartWidget> -->
      <Map id="c" />
    </div>
  </div>
</template>

<script>
import { Chart as ChartJS, ArcElement, Tooltip, Legend } from "chart.js";
import { Doughnut } from "vue-chartjs";
ChartJS.register(ArcElement, Tooltip, Legend);

import { mapGetters } from "vuex";
import "./MainPage.scss";
import { defineComponent } from "vue";
import Map from "@/components/Map/Map.vue";
import StandartWidget from "@/components/Widgets/StandartWidget/StandartWidget.vue";
export default defineComponent({
  components: {
    Map,
    StandartWidget,
    Doughnut,
  },
  computed: {
    ...mapGetters("MainPage", ["getStats"]),
  },
  data() {
    return {};
  },
  methods: {
  },
});
</script>
