<template>
  <b-page-title title="Đăng ký"></b-page-title>
  <b-input-number v-model="val"></b-input-number>
</template>
<script lang="ts">
import { ref } from 'vue';

export default {};
</script>
<script lang="ts" setup>
// const val = ref(999999999999999);
const val = ref(9007199254740991);
</script>
