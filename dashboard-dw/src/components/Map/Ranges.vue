<template>
  <div
    style="
      position: absolute;
      bottom: 0;
      left: 0;
      display: flex;
      flex-direction: row;
    "
  >
    <span
      v-for="(it, i) in this.colors"
      :style="{
        position: 'absolute',
        left: '0',
        bottom: '0',
        backgroundColor: it,
        width: 85 * (i + 1) + 'px',
        borderRadius: '1.111vmin',
        height: '1.944vmin',
        zIndex: 5 - i,
      }"
      >
    </span>
    <span
      v-for="(it, i) in this.colors"
      :style="{
        position: 'absolute',
        left: 85 * (i)+15 + 'px',
        bottom: '1.137vmin',
        width: 85 * (i + 1) + 'px',
        borderRadius: '1.211vmin',
        height: '1.944vw',
        zIndex: 5 - i,
        color: '#FFFFFF'
      }"
      >
      {{ i * 20 + 1 }} - {{ 20 * (i + 1) }}
    </span>
  </div>
</template>

<script>
import { defineComponent } from "vue";
export default defineComponent({
  data() {
    return {
      colors: ["#CCC360", "#98C59C", "#A4C8D3", "#9899D3", "#8A6FC5"].reverse(),
    };
  },
});
</script>
