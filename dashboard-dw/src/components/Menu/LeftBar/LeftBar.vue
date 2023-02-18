<template>
  <div class="leftBar">
    <div class="logo">
      <!-- <simple-svg :src="require('../../../assets/logo.svg')" /> -->
      <img src="../../../assets/logo.png" alt="" />
    </div>
    <!-- {{ this.$route.name }} -->
    <div
      class="menuBtn"
      v-for="item in getList"
      :class="{ active: item.path === this.$route.path }"
      @click="()=>this.changePage(item.path)"
      :key="item.path"
    >
      <simple-svg :src="require('../../../assets/' + item.img)" />
    </div>
  </div>
</template>

<script>
import { mapGetters } from "vuex";
import { defineComponent } from "vue";
import "./LeftBar.scss";
export default defineComponent({
  computed: {
    ...mapGetters("Menu", ["getList"]),
  },
  data() {},
  methods: {
    changePage(path){
      this.$router.push(path)
    }
  }
});
</script>
