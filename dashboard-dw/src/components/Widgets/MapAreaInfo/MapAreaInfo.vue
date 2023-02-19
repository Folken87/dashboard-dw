<template>
  <div class="mapAreaInfo" id="10000" @click="this.$emit('getMapArea', -1)">
    <span class="subjectName">{{ this.subjectInfo?.name }}</span>
    <span>Всего молодежи: {{ Math.round(this.subjectInfo?.countPeople) }}</span>
    <span>Учреждений МП: {{ this.subjectInfo?.countStruct }}</span>
    <span>Сотрудников: {{ this.subjectInfo?.countWorkers }}</span>
    <span class="leave"
      >Выехавшая молодёжь за год:
      {{ (this.subjectInfo?.percentLeave * 100).toFixed(2) }}%</span
    >
    <span
      >Коэффициент финансирования:
      {{
        isNaN(this.subjectInfo?.koef)
          ? 0
          : Math.floor(this.subjectInfo?.koef * 100)
      }}%</span
    >
  </div>
</template>
<script>
import "./MapAreaInfo.scss";
import { defineComponent } from "vue";
import { mapGetters } from "vuex";
export default defineComponent({
  data() {
    return {
      subjectInfo: null,
    };
  },
  props: {
    areaId: Number,
  },
  mounted() {
    this.subjectInfo = this.getSubjectInfo(this.areaId);
  },
  computed: {
    ...mapGetters("MainPage", ["getSubjectInfo"]),
  },
});
</script>
