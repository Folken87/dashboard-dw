<template>
  <div class="widget">
    <span class="header">
      <slot name="header"></slot>
    </span>
    <div class="wrapper">
      <slot></slot>
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
});
</script>
