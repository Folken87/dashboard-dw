<template>
  <div class="mapAreaInfo" id="10000" @click="this.$emit('getMapArea',-1)">
    {{ $props?.info }}
  </div>
</template>
<script>
import "./MapAreaInfo.scss";
import { defineComponent } from "vue";
export default defineComponent({
  data() {
    return {};
  },
  props: {
    info: Object,
  },
});
</script>
