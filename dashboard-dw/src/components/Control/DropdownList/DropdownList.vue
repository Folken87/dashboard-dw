<template>
  <select @change="onChange">
    <option v-for="it in $props.items" :value="it[0]">{{ it[1] }}</option>
  </select>
</template>
<script>
import { defineComponent } from "vue";
import "./DropdownList.scss";
export default defineComponent({
  data() {
    return {}
  },
  props: {
    items: Array,
  },
  methods: {
    onChange(e) {
      this.$emit("changeVal", e.target.value);
    },
  },
});
</script>
