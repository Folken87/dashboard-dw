<template>
  <div class="customChart">
    <div class="chart">
      <slot name="chart"></slot>
      <div class="centerChart">
        <slot name="centerChart"></slot>
      </div>
    </div>
    <div class="legend">
      <span class="headerText">
        <slot name="headerText"></slot>
      </span>
      <slot name="legend"></slot>
    </div>
  </div>
</template>

<script>
import "../style.scss";
import { defineComponent } from "vue";
export default defineComponent({
  data() {
    return {
      labelsFilter: [],
    };
  },
});
</script>
