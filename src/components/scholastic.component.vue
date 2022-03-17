<template>
  {{ displayScholastic }}
</template>
<style lang="scss" scoped>
.criterion {
  padding: 0;
}
</style>
<script lang="ts">
import { computed } from 'vue';

export default {
  name: 'b-scholastic',
};
</script>
<script lang="ts" setup>
interface ScholasticProps {
  scholastic: number | string | null;
}

const props = defineProps<ScholasticProps>();
const displayScholastic = computed(() => {
  if (props.scholastic) {
    let s: number;
    if (typeof props.scholastic === 'string') {
      s = parseInt(props.scholastic);
      if (isNaN(s)) {
        return '';
      }
    } else {
      s = props.scholastic;
    }
    return `${s}-${s + 1}`;
  }
  return '';
});
</script>
