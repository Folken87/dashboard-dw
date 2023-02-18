<template>
  <div class="mainPage" @mousemove="mMove">
    <div class="header">
      <div class="name">
        <span>Мониторинг эффективности молодежной политики</span>
      </div>
      <div class="controls">
        <!-- <span>Регион</span>
        <span>Регион</span>
        <span>Регион</span> -->
      </div>
    </div>
    <div class="widgets">
      <StandartWidget id="a">
        <template v-slot:header
          >Количество учреждений молодёжной политики</template
        >
        <template v-slot:default>
          <Bar
            :data="getStats(1)"
            :options="{
              resizeDelay: 0,
              responsive: true,
              maintainAspectRatio: false,
              // cutout: 50,
              plugins: {
                legend: {
                  position: 'right',
                  labels: {
                    font: {
                      size: 12,
                      family: 'Tahoma',
                    },
                  },
                },
              },
            }"
          />
        </template>
      </StandartWidget>
      <StandartWidget id="a1">
        <template v-slot:header
          >Бюджеты государственной молодeжной политики по направлениям</template
        >
        <template v-slot:default>
          <Bar
            :data="getStats(1)"
            :options="{
              resizeDelay: 0,
              responsive: true,
              maintainAspectRatio: false,
              // cutout: 50,
              plugins: {
                legend: {
                  position: 'right',
                  labels: {
                    font: {
                      size: 12,
                      family: 'Tahoma',
                    },
                  },
                },
              },
            }"
          /> </template
      ></StandartWidget>
      <StandartWidget id="a2">
        <template v-slot:header
          >Региональные/муниципальные структуры по работе с молодeжью (объемы
          финансирования)</template
        >
        <template v-slot:default>
          <Line
            :data="getStats(1)"
            :options="{
              resizeDelay: 0,
              responsive: true,
              maintainAspectRatio: false,
              // cutout: 50,
              plugins: {
                legend: {
                  position: 'right',
                  labels: {
                    font: {
                      size: 12,
                      family: 'Tahoma',
                    },
                  },
                },
              },
            }"
          />
        </template>
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
                  labels: {
                    font: {
                      size: 12,
                      family: 'Tahoma',
                    },
                  },
                },
              },
            }"
          />
        </template>
      </StandartWidget>
      <StandartWidget id="b">
        <template v-slot:header>Вовлеченность в молодежные форумы</template>
        <template v-slot:default>
          <CustomChart>
            <template v-slot:chart>
              <Doughnut
                :data="GetR4Data"
                :options="{
                  resizeDelay: 0,
                  responsive: true,
                  maintainAspectRatio: false,
                  plugins: {
                    legend: {
                      display: false,
                      maxWidth: 200,
                      position: 'right',
                      labels: {
                        boxWidth: 15,
                        boxHeight: 15,
                        font: {
                          size: 10,
                          family: 'Tahoma',
                        },
                      },
                    },
                  },
                }"
              />
            </template>
            <template v-slot:centerChart>
              {{
                GetR4Data.datasets[0].countPeople.reduce((sum, a) => sum + a, 0)
              }}
              <span style="color: #87868c">чел</span>
            </template>
            <template v-slot:headerText
              >Объемы финансирования, млн руб:</template
            >
            <template v-slot:legend>
              <LegendLabel
                :custom-data="this.getStats(2)"
                @filterIndex="filterR4"
                :filter="this.filterR4Indexes"
              />
            </template>
          </CustomChart>
        </template>
      </StandartWidget>
      <!-- сделано -->
      <StandartWidget id="b1">
        <template v-slot:header>Финансирование молодежных объединений</template>
        <template v-slot:default>
          <CustomChart>
            <template v-slot:chart>
              <Doughnut
                :data="GetR4Data"
                :options="{
                  responsive: true,
                  maintainAspectRatio: false,
                  plugins: {
                    legend: {
                      display: false,
                    },
                  },
                }"
              />
            </template>
            <template v-slot:centerChart>
              {{
                GetR4Data.datasets[0].countPeople
                  .filter((x, i) => this.filterR4Indexes.includes(i) === false)
                  .reduce((sum, a) => sum + a, 0)
              }}
              <span style="color: #87868c">чел</span>
            </template>
            <template v-slot:headerText
              >Объемы финансирования, млн руб:</template
            >
            <template v-slot:legend>
              <LegendLabel
                :custom-data="this.getStats(2)"
                @filterIndex="filterR4"
                :filter="this.filterR4Indexes"
              />
            </template>
          </CustomChart>
        </template>
      </StandartWidget>
      <Map id="c" @getMapArea="GetMapArea" />
    </div>
    <MapAreaInfo
      v-if="this.hoveredMapArea !== -1"
      :info="this.hoveredMapArea"
      :style="{
        top: this.mapAreaInfoPos.y + 100 + 'px',
        left: this.mapAreaInfoPos.x + 15 + 'px',
      }"
      @getMapArea="GetMapArea"
    />
  </div>
</template>

<script>
import {
  Chart as ChartJS,
  ArcElement,
  Tooltip,
  Legend,
  BarElement,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
} from "chart.js";
import { Doughnut, Bar, Line } from "vue-chartjs";
ChartJS.register(ArcElement, Tooltip, Legend);
ChartJS.register(
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend
);
ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend
);
import $ from "jquery";
import { mapGetters, mapActions } from "vuex";
import "./MainPage.scss";
import { defineComponent } from "vue";
import Map from "@/components/Map/Map.vue";
import StandartWidget from "@/components/Widgets/StandartWidget/StandartWidget.vue";
import CustomChart from "@/components/Widgets/CustomChart/CustomChart.vue";
import LegendLabel from "@/components/Widgets/CustomChart/LegendLabel.vue";
import MapAreaInfo from "@/components/Widgets/MapAreaInfo/MapAreaInfo.vue";
export default defineComponent({
  components: {
    Map,
    StandartWidget,
    Doughnut,
    Bar,
    Line,
    CustomChart,
    LegendLabel,
    MapAreaInfo,
  },
  computed: {
    ...mapGetters("MainPage", ["getStats"]),
    ...mapActions("MainPage", ["setR4Data"]),
    GetR4Data() {
      let data = $.extend(true, {}, this.getStats(2));
      data.datasets[0].data = data.datasets[0].data.filter(
        (x, i) => this.filterR4Indexes.includes(i) === false
      );
      return {
        labels: data.labels,
        datasets: [...data.datasets],
      };
    },
  },
  data() {
    return {
      filterR4Indexes: [],
      hoveredMapArea: -1,
      mapAreaInfoPos: { x: -1, y: -1 },
      mPos: { x: 0, y: 0 },
    };
  },
  methods: {
    filterR4(index) {
      console.log(index);
      let tempI = this.filterR4Indexes.findIndex((el) => el == index);
      if (tempI !== -1) this.filterR4Indexes.splice(tempI, 1);
      else this.filterR4Indexes.push(index);
    },
    GetMapArea(id) {
      console.log(id);
      this.mapAreaInfoPos.x = this.mPos.x;
      this.mapAreaInfoPos.y = this.mPos.y;
      this.hoveredMapArea = id;
    },
    mMove(e) {
      this.mPos.x = e.offsetX;
      this.mPos.y = e.offsetY;
    },
  },
  mounted() {
    fetch("R4/GetR4Data")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR4Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
  },
});
</script>
