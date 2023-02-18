<template>
  <div class="application-wrapper">
    <div class="left">
      <LeftBar />
    </div>
    <div class="right">
      <div class="top">
        <TopBar />
      </div>
      <div class="main">
        <RouterView v-slot="{ Component }">
          <Transition>
            <component :is="Component" />
          </Transition>
        </RouterView>
      </div>
    </div>
  </div>
</template>

<script>
import LeftBar from "./Menu/LeftBar/LeftBar.vue";
import TopBar from "./Menu/TopBar/TopBar.vue";
export default {
  components: {
    LeftBar,
    TopBar,
  },
};
</script>
