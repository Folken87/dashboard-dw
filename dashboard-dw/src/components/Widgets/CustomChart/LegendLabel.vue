<template>
  <div class="legendLabel" v-for="(x, i) in $props.customData?.labels" @click="()=>this.$emit('filterIndex', i)">
    <div
      class="color"
      :style="{
        backgroundColor: $props.customData?.datasets[0]?.backgroundColor[i],
      }"
    ></div>
    <div class="text" :title="x">
      <span :style="{textDecoration: $props.filter.includes(i) ? 'line-through' : 'none'}">{{ x.split(" ").slice(0, 4).join(" ")+"..." }}</span>
    </div>
    <div class="value" :title="x">
      <span :style="{textDecoration: $props.filter.includes(i) ? 'line-through' : 'none'}">{{ Math.floor($props.customData?.datasets[0]?.data[i]) }}</span>
    </div>
  </div>
</template>

<script>
import { defineComponent } from "vue";
import "../style.scss";
export default defineComponent({
  data() {
    return {};
  },
  props: {
    customData: Object,
    filter: Array
  },
});
</script>
