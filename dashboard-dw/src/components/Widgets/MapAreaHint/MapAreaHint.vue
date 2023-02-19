<template>
    <div class="mapAreaHint">
        <span>{{ $props?.name }}</span>
    </div>
</template>

<script>
import "../style.scss"
import {defineComponent} from "vue";
export default defineComponent({
    props: {
        name: String
    }
})
</script>