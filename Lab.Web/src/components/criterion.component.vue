<template>
  <q-item v-if="criterion" class="criterion">
    <q-item-section>
      <q-item-label>{{ criterion.label }}</q-item-label>
      <q-item-label caption>{{ criterion.description }}</q-item-label>
    </q-item-section>
  </q-item>
</template>
<style lang="scss" scoped>
.criterion {
  padding: 0;
}
</style>
<script lang="ts">
import { CRITERION } from 'src/constants';
import { computed } from 'vue';

export default {
  name: 'b-criterion',
};
</script>
<script lang="ts" setup>
interface CriterionProps {
  criterion: number | string | null;
}

const props = defineProps<CriterionProps>();

const criterion = computed(() => {
  if (props.criterion) {
    return CRITERION[props.criterion];
  }
  return null;
});
</script>
