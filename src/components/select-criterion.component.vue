<template>
  <q-select
    v-model="model"
    :options="options"
    option-value="value"
    option-label="label"
    @update:model-value="(val) => $emit('update:modelValue', val.value)"
    options-dense
  >
    <template #option="{ opt, itemProps }">
      <q-item-label v-if="opt.group" header class="opt-group">
        {{ opt.label }}
      </q-item-label>
      <q-item v-else v-bind="itemProps">
        <q-item-section>
          <q-item-label>{{ opt.label }}</q-item-label>
        </q-item-section>
      </q-item>
    </template>
    <template #append>
      <q-item-label v-if="model" caption>
        {{ model.description }}
      </q-item-label>
    </template>
    <template #selected>
      <q-item-label v-if="model">
        {{ model.label }}
      </q-item-label>
    </template>
  </q-select>
</template>
<style lang="scss" scoped>
.opt-group {
  text-transform: uppercase;
}
</style>
<script lang="ts">
export default {
  name: 'b-select-criterion',
};
</script>
<script lang="ts" setup>
import { QSelectProps } from 'quasar';
import { CRITERIONS } from 'src/constants';
import { CriterionOption } from 'src/models';
import { ref } from 'vue';

interface SelectCriterionProps extends Omit<QSelectProps, 'modelValue'> {
  modelValue?: number | string | null;
}

interface SelectCriterionEmits {
  (e: 'update:modelValue', val: number | string | null): void;
}

const props = defineProps<SelectCriterionProps>();
defineEmits<SelectCriterionEmits>();

const model = ref<CriterionOption | null>();

const options = ref<CriterionOption[]>([]);

CRITERIONS.forEach((c) => {
  options.value.push({
    group: true,
    value: 0,
    label: c.group,
    description: '',
  });
  c.items.forEach(({ value, label }) => {
    const item = {
      group: false,
      value,
      label,
      description: c.group,
    };
    options.value.push(item);
    if (props.modelValue == value) {
      model.value = item;
    }
  });
});
</script>
