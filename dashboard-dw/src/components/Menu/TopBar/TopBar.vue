<template>
  <div class="topBar">
    <span>Росмолодёжь</span>
    <simple-svg :src="require('../../../assets/arrowRight.svg')" />
    <span>{{ this.$route.name }}</span>
  </div>
</template>

<script>
import "./TopBar.scss";
import { defineComponent } from "vue";
export default defineComponent({
  data() {},
});
</script>
