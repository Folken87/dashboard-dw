<template>
  <div class="application">
    <RouterView v-slot="{ Component }">
      <Transition>
        <component :is="Component" />
      </Transition>
    </RouterView>
  </div>
</template>

<script>
import "./style/style.scss"
export default {
  name: "App",
  components: {},
  
};
</script>
