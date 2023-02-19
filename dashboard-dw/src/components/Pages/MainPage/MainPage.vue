<template>
  <div class="mainPage" @mousemove="mMove">
    <div class="header">
      <div class="name">
        <span>Мониторинг эффективности молодежной политики</span>
      </div>
      <div class="controls">
        <DropdownList :items="[[-1, 'Все регионы'], ...this.getAllRegions]" @changeVal="changeRegionFilter" />
        <DropdownList :items="[[2021, 2021]]" />
        <!-- <span>Регион</span>
        <span>Регион</span>
        <span>Регион</span> -->
      </div>
    </div>
    <div class="widgets">
      <!-- сделано -->
      <StandartWidget id="a">
        <template v-slot:header
          >Распределение бюджетов по направлениям молодёжной политики
          <!-- <span style="color: #87868c">млн руб.</span> -->
        </template>
        <template v-slot:default>
          <div class="row">
            <div class="col w-50 jc-end">
              <div class="row jc-center ali-center">
                <span
                  style="
                    font-size: 0.626vw;
                    line-height: 1.211vmin;
                    font-weight: 400;
                    text-align: center;
                  "
                  >Кол-во молодeжи, задействованной в программных
                  мероприятиях</span
                >
              </div>
              <div class="row ptb-1 ali-end jc-center">
                <span style="font-size: 2.333vmin; line-height: 2.104vmin">{{
                  GetR1Data.datasets[0].countMember
                }}</span
                ><span style="font-size: 1.667vmin; color: #87868c">чел</span>
              </div>
            </div>
            <div class="col w-50 jc-end">
              <div class="row jc-center ali-center">
                <span
                  style="
                    font-size: 0.626vw;
                    line-height: 1.211vmin;
                    font-weight: 400;
                    text-align: center;
                  "
                  >Количество грантов</span
                >
              </div>
              <div class="row ptb-1 ali-end jc-center">
                <span style="font-size: 2.333vmin; line-height: 2.104vmin">{{
                  GetR1Data.datasets[0].countGrant
                }}</span
                ><span style="font-size: 1.667vmin; color: #87868c">шт</span>
              </div>
            </div>
          </div>
          <div class="row h-70">
            <Bar
              :data="GetR1Data"
              :options="{
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                  tooltip: {
                    enabled: false,
                    position: 'nearest',
                    external: this.externalTooltipHandler,
                  },
                  legend: {
                    display: true,
                    position: 'bottom',
                    labels: {
                      usePointStyle: true,
                    },
                  },
                },
                scales: {
                  A: {
                    id: 'A',
                    type: 'linear',
                    position: 'left',
                    display: false,
                  },
                  B: {
                    id: 'B',
                    type: 'linear',
                    position: 'left',
                    display: false,
                  },
                  x: {
                    grid: {
                      display: false,
                    },
                    ticks: {
                      display: false,
                    },
                  },
                  y: {
                    grid: {
                      display: false,
                    },
                    ticks: {
                      display: false,
                      max: 1,
                      min: 0,
                    },
                  },
                },
              }"
            />
          </div>
        </template>
      </StandartWidget>
      <StandartWidget id="a1">
        <template v-slot:header
          >Получатели финансирования на работы с молодёжью
          <!-- <span style="color: #87868c">млн руб.</span> -->
        </template>
        <template v-slot:default>
          <div class="row h-10" style="font-size: 1.396vmin; font-weight: 600">
            Объемы финансирования и расходы на мероприятия
          </div>
          <div class="row h-40">
            <Bar
              :data="GetR2Data"
              :options="{
                indexAxis: 'y',
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                  tooltip: {
                    enabled: false,
                    position: 'nearest',
                    external: this.externalTooltipHandler,
                  },
                  legend: {
                    display: false,
                    position: 'left',
                    labels: {
                      usePointStyle: false,
                    },
                  },
                  datalabels: {
                    color: 'white',
                    align: 'center',
                    anchor: 'center',
                    font: {
                      weight: '600',
                      family: 'GT Eesti LC Text',
                    },
                  },
                },
                scales: {
                  x: {
                    stacked: true,
                    grid: {
                      display: false,
                    },
                    ticks: {
                      display: false,
                    },
                  },
                  y: {
                    stacked: true,
                    grid: {
                      display: false,
                    },
                    ticks: {
                      display: true,
                    },
                  },
                },
              }"
            />
          </div>
          <div class="row h-10" style="font-size: 1.396vmin; font-weight: 600">
            Распределение расходов
          </div>
          <div class="row h-40">
            <Bar
              :data="GetR2Data"
              :options="{
                indexAxis: 'y',
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                  tooltip: {
                    enabled: false,
                    position: 'nearest',
                    external: this.externalTooltipHandler,
                  },
                  legend: {
                    display: false,
                    position: 'left',
                    labels: {
                      usePointStyle: false,
                    },
                  },
                  datalabels: {
                    color: 'white',
                    align: 'center',
                    anchor: 'center',
                    font: {
                      weight: '600',
                      family: 'GT Eesti LC Text',
                    },
                  },
                },
                scales: {
                  x: {
                    stacked: true,
                    grid: {
                      display: false,
                    },
                    ticks: {
                      display: false,
                    },
                  },
                  y: {
                    stacked: true,
                    grid: {
                      display: false,
                    },
                    ticks: {
                      display: true,
                    },
                  },
                },
              }"
            />
          </div>
        </template>
      </StandartWidget>
      <!-- сделано -->
      <StandartWidget id="a2">
        <template v-slot:header
          >Вовлеченность учащихся в общественные объединения
          <!-- <span style="color: #87868c">шт</span> -->
        </template>
        <template v-slot:default>
          <Bar
            :data="GetR4_2Data"
            :options="{
              responsive: true,
              maintainAspectRatio: false,
              plugins: {
                tooltip: {
                  enabled: false,
                  position: 'nearest',
                  external: this.externalTooltipHandler,
                },
                legend: {
                  display: true,
                  position: 'bottom',
                  labels: {
                    usePointStyle: true,
                  },
                },
              },
              scales: {
                A: {
                  id: 'A',
                  type: 'linear',
                  position: 'left',
                  display: false,
                },
                B: {
                  id: 'B',
                  type: 'linear',
                  position: 'left',
                  display: false,
                },
                x: {
                  grid: {
                    display: false,
                  },
                },
                y: {
                  grid: {
                    display: false,
                  },
                  ticks: {
                    display: false,
                  },
                },
              },
            }"
          />
        </template>
      </StandartWidget>
      <!-- сделано -->
      <StandartWidget id="a3">
        <template v-slot:header>Вовлеченность в волонтёрство</template>
        <template v-slot:default>
          <CustomChart>
            <template v-slot:chart>
              <Doughnut
                :data="GetR7Data"
                :options="{
                  responsive: true,
                  maintainAspectRatio: false,
                  borderColor: 'transparent',
                  plugins: {
                    tooltip: {
                      enabled: false,
                      position: 'nearest',
                      external: this.externalTooltipHandler,
                    },
                    legend: {
                      display: false,
                    },
                    datalabels: {
                      display: false,
                    },
                  },
                }"
              />
            </template>
            <template v-slot:centerChart>
              {{ GetR7Data.datasets[0].data.reduce((sum, a) => sum + a, 0) }}
              <span style="color: #87868c">чел</span>
            </template>
            <template v-slot:legend>
              <div class="col p-1">
                <div class="row" style="font-size: 1.396vmin">
                  Количество государственных учреждений:
                </div>
                <div class="row ptb-2 ali-end">
                  <span style="font-size: 3.333vmin; line-height: 2.704vmin"
                    >{{ GetR7Data.datasets[0].countGov }} </span
                  ><span style="font-size: 1.667vmin; color: #87868c">ед.</span>
                </div>
                <div class="row" style="font-size: 1.396vmin">
                  Количество региональных ресурсных центров:
                </div>
                <div class="row ptb-2 ali-end">
                  <span style="font-size: 3.333vmin; line-height: 2.704vmin"
                    >{{ GetR7Data.datasets[0].countRegCenters }} </span
                  ><span style="font-size: 1.667vmin; color: #87868c">
                    ед.</span
                  >
                </div>
              </div>
            </template>
          </CustomChart>
        </template>
      </StandartWidget>
      <!-- сделано -->
      <StandartWidget id="b">
        <template v-slot:header>Вовлеченность в молодежные форумы</template>
        <template v-slot:default>
          <CustomChart>
            <template v-slot:chart>
              <Doughnut
                :data="GetR6Data"
                :options="{
                  responsive: true,
                  maintainAspectRatio: false,
                  borderColor: 'transparent',
                  plugins: {
                    tooltip: {
                      enabled: false,
                      position: 'nearest',
                      external: this.externalTooltipHandler,
                    },
                    legend: {
                      display: false,
                    },
                    datalabels: {
                      display: false,
                    },
                  },
                }"
              />
            </template>
            <template v-slot:centerChart>
              {{ GetR6Data.datasets[0].data.reduce((sum, a) => sum + a, 0) }}
              <span style="color: #87868c">чел</span>
            </template>
            <template v-slot:headerText>Финансирование:</template>
            <template v-slot:legend>
              <div class="col jc-space-around w-85">
                <div class="row jc-space-around">
                  <div class="col">
                    <div class="row jc-center ali-end">
                      <span style="font-size: 3.333vmin; line-height: 2.704vmin"
                        >{{
                          Math.floor(GetR6Data.datasets[0].regVal / 1000000)
                        }} </span
                      ><span style="font-size: 1.667vmin; color: #87868c"
                        >млн</span
                      >
                    </div>
                    <div class="row">
                      <span style="font-size: 1.296vmin">Региональное</span>
                    </div>
                  </div>
                  <div class="col">
                    <div class="row jc-center ali-end">
                      <span style="font-size: 3.333vmin; line-height: 2.704vmin"
                        >{{
                          Math.floor(GetR6Data.datasets[0].munVal / 1000000)
                        }} </span
                      ><span style="font-size: 1.667vmin; color: #87868c"
                        >млн</span
                      >
                    </div>
                    <div class="row">
                      <span style="font-size: 1.296vmin">Муниципальное</span>
                    </div>
                  </div>
                </div>
                <div class="row jc-center">
                  <div class="col p-1">
                    <span style="text-align: center">ВСЕГО,<br />форумов</span>
                  </div>
                  <div class="col p-1">
                    <span
                      style="font-size: 3.333vmin; line-height: 3.704vmin"
                      >{{ GetR6Data.datasets[0].countForum }}</span
                    >
                  </div>
                </div>
              </div>
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
                  borderColor: 'transparent',
                  plugins: {
                    tooltip: {
                      enabled: false,
                      position: 'nearest',
                      external: this.externalTooltipHandler,
                    },
                    legend: {
                      display: false,
                    },
                    datalabels: {
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
      <Map id="c" @getMapArea="GetMapArea" @getMapAreaHint="GetMapAreaHint" />
    </div>
    <MapAreaInfo
      v-if="this.hoveredMapArea !== -1"
      :style="{
        top: this.mapAreaInfoPos.y - 70 + 'px',
        left: this.mapAreaInfoPos.x - 70 + 'px',
      }"
      :area-id="this.hoveredMapArea"
      @getMapArea="GetMapArea"
    />
    <MapAreaHint
      v-if="this.hintMapArea !== -1"
      :name="getSubjectInfo(this.hintMapArea)?.name"
      :style="{
        top: this.hintMapAreaPos.y - 100 + 'px',
        left: this.hintMapAreaPos.x - 80 + 'px',
      }"
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
  scales,
} from "chart.js";
import { Doughnut, Bar, Line } from "vue-chartjs";
import ChartDataLabels from "chartjs-plugin-datalabels";
ChartJS.register(
  BarElement,
  ArcElement,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
  ChartDataLabels
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
import MapAreaHint from "@/components/Widgets/MapAreaHint/MapAreaHint.vue";
import DropdownList from "@/components/Control/DropdownList/DropdownList.vue";
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
    MapAreaHint,
    DropdownList,
  },
  computed: {
    ...mapGetters("MainPage", ["getStats", "getSubjectInfo", "getAllRegions"]),
    ...mapActions("MainPage", ["setR4Data"]),
    GetR4Data() {
      let data = $.extend(true, {}, this.getStats(2));
      data.datasets[0].data = data.datasets[0].data.filter(
        (x, i) => this.filterR4Indexes.includes(i) === false
      );
      data.datasets[0].backgroundColor =
        data.datasets[0].backgroundColor.filter(
          (x, i) => this.filterR4Indexes.includes(i) === false
        );
      return {
        labels: data.labels,
        datasets: [...data.datasets],
      };
    },
    GetR6Data() {
      let data = $.extend(true, {}, this.getStats(6));
      data.datasets[0].data = data.datasets[0].data.filter(
        (x, i) => this.filterR6Indexes.includes(i) === false
      );
      return {
        labels: data.labels,
        datasets: [...data.datasets],
      };
    },
    GetR7Data() {
      let data = $.extend(true, {}, this.getStats(7));
      return {
        labels: data.labels,
        datasets: [...data.datasets],
      };
    },
    GetR2Data() {
      let data = $.extend(true, {}, this.getStats(0));
      return {
        labels: data.labels,
        datasets: [...data.datasets],
      };
    },
    GetR4_2Data() {
      let data = $.extend(true, {}, this.getStats(4));
      data.datasets[0].data = data.datasets[0].data.filter(
        (x, i) => this.filterR6Indexes.includes(i) === false
      );
      return {
        labels: data.labels,
        datasets: [...data.datasets],
      };
    },
    GetR1Data() {
      let data = $.extend(true, {}, this.getStats(1));
      data.datasets[0].data = data.datasets[0].data.filter(
        (x, i) => this.filterR6Indexes.includes(i) === false
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
      filterR6Indexes: [],
      filterR1Indexes: [],
      hoveredMapArea: -1,
      mapAreaInfoPos: { x: 0, y: 0 },
      mPos: { x: 0, y: 0 },
      hintMapArea: -1,
      hintMapAreaPos: { x: 0, y: 0 },
    };
  },
  methods: {
    filterR4(index) {
      let tempI = this.filterR4Indexes.findIndex((el) => el == index);
      if (tempI !== -1) this.filterR4Indexes.splice(tempI, 1);
      else this.filterR4Indexes.push(index);
    },
    filterR6(index) {
      let tempI = this.filterR6Indexes.findIndex((el) => el == index);
      if (tempI !== -1) this.filterR6Indexes.splice(tempI, 1);
      else this.filterR6Indexes.push(index);
    },
    filterR1(index) {
      let tempI = this.filterR1Indexes.findIndex((el) => el == index);
      if (tempI !== -1) this.filterR1Indexes.splice(tempI, 1);
      else this.filterR1Indexes.push(index);
    },
    GetMapAreaHint(id) {
      this.hintMapAreaPos.x = this.mPos.x;
      this.hintMapAreaPos.y = this.mPos.y;
      this.hintMapArea = id;
    },
    GetMapArea(id) {
      this.mapAreaInfoPos.x = this.mPos.x;
      this.mapAreaInfoPos.y = this.mPos.y;
      this.hoveredMapArea = id;
    },
    mMove(e) {
      this.mPos.x = e.x;
      this.mPos.y = e.y;
    },
    externalTooltipHandler(context) {
      // Tooltip Element
      const { chart, tooltip } = context;
      const tooltipEl = this.getOrCreateTooltip(chart);

      // Hide if no tooltip
      if (tooltip.opacity === 0) {
        tooltipEl.style.opacity = 0;
        return;
      }

      // Set Text
      if (tooltip.body) {
        const titleLines = tooltip.title || [];
        const bodyLines = tooltip.body.map((b) => b.lines);

        const tableHead = document.createElement("thead");

        titleLines.forEach((title) => {
          const tr = document.createElement("tr");
          tr.style.borderWidth = 0;

          const th = document.createElement("th");
          th.style.borderWidth = 0;
          const text = document.createTextNode(title);

          th.appendChild(text);
          tr.appendChild(th);
          tableHead.appendChild(tr);
        });

        const tableBody = document.createElement("tbody");
        bodyLines.forEach((body, i) => {
          const colors = tooltip.labelColors[i];

          const span = document.createElement("span");
          span.style.background = colors.backgroundColor;
          span.style.borderColor = colors.borderColor;
          span.style.borderWidth = "2px";
          span.style.marginRight = "10px";
          span.style.height = "10px";
          span.style.width = "10px";
          span.style.display = "inline-block";

          const tr = document.createElement("tr");
          tr.style.backgroundColor = "inherit";
          tr.style.borderWidth = 0;

          const td = document.createElement("td");
          td.style.borderWidth = 0;

          const text = document.createTextNode(body);

          td.appendChild(span);
          td.appendChild(text);
          tr.appendChild(td);
          tableBody.appendChild(tr);
        });

        const tableRoot = tooltipEl.querySelector("table");

        // Remove old children
        while (tableRoot.firstChild) {
          tableRoot.firstChild.remove();
        }

        // Add new children
        tableRoot.appendChild(tableHead);
        tableRoot.appendChild(tableBody);
      }

      const { offsetLeft: positionX, offsetTop: positionY } = chart.canvas;

      // Display, position, and set styles for font
      tooltipEl.style.width = "fit-content";
      tooltipEl.style.maxWidth = "250px";

      tooltipEl.style.opacity = 1;
      tooltipEl.style.zIndex = 5;
      tooltipEl.style.left = this.mPos.x + "px";
      tooltipEl.style.top = this.mPos.y + "px";
      tooltipEl.style.fontFamily = "GT Eesti LC Text";
      tooltipEl.style.fontSize = "1.5vmin";
      tooltipEl.style.fontWeight = "400";
      tooltipEl.style.borderRadius = "10px";

      tooltipEl.style.padding =
        tooltip.options.padding + "px " + tooltip.options.padding + "px";
    },
    getOrCreateTooltip(chart) {
      // console.log(
      //   document.querySelector(".application-wrapper").querySelector(".tooltip")
      // );
      let tooltipEl = document
        .querySelector(".application-wrapper")
        .querySelector(".tooltip");

      if (!tooltipEl) {
        tooltipEl = document.createElement("div");
        tooltipEl.setAttribute("class", "tooltip");
        tooltipEl.style.background = "rgba(0, 0, 0, 0.7)";
        tooltipEl.style.borderRadius = "3px";
        tooltipEl.style.color = "white";
        tooltipEl.style.opacity = 1;
        tooltipEl.style.pointerEvents = "none";
        tooltipEl.style.position = "absolute";
        tooltipEl.style.transform = "translate(-50%, -100%)";
        tooltipEl.style.transition = "all .1s ease";

        const table = document.createElement("table");
        table.style.margin = "0px";

        tooltipEl.appendChild(table);
        document.querySelector(".application-wrapper").appendChild(tooltipEl);
      }

      return tooltipEl;
    },
    changeRegionFilter(val){
      this.$store.dispatch("MainPage/setRegionFilter", val);
    }
  },
  mounted() {
    fetch("Basic/GetSubjects")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setSubjects", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("R4/GetR4Data")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR4Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("R6/GetR6All")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR6Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("R7/GetR7All")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR7Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("R4_2/GetR4-2All")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR4_2Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("R1/GetR1All")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR1Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("R2/GetR2All")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setR2Data", data);
      })
      .catch((e) => {
        console.error(e);
      });
    fetch("AtrtittionYouth/GetAll")
      .then((res) => res.json())
      .then((data) => {
        this.$store.dispatch("MainPage/setAtrtittionYouth", data);
      })
      .catch((e) => {
        console.error(e);
      });
  },
});
</script>
