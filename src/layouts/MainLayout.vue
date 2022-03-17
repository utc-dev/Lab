<template>
  <layout-youtube
    :routes="mainRoutes"
    :navigationGroupLinks="navigationGroupLinks"
  ></layout-youtube>
</template>
<style lang="css" src="@blessing-vn/webapp/style.css"></style>
<script lang="ts" setup>
import { reactive } from 'vue';
import routes, { NavigationGroupLinks } from '../router/routes';

const mainRoutes = reactive(routes);
const navigationGroupLinks = reactive(NavigationGroupLinks);
</script>
