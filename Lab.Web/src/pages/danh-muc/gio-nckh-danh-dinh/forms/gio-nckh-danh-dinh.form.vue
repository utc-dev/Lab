<template>
  <b-form @submit="onSubmit">
    <div class="row q-col-gutter-x-md">
      <div class="col">
        <b-select-criterion v-model="item.tieuChi" label="Tiêu chí" />
      </div>
    </div>
    <div class="row q-col-gutter-x-md">
      <div class="col">
        <b-input-number v-model="item.soGio" label="Số giờ" />
      </div>
      <div class="col">
        <q-select
          v-model="item.namApDung"
          label="Năm bắt đầu áp dụng"
          :options="years"
        ></q-select>
      </div>
    </div>
    <template #actions>
      <q-btn label="Lưu lại" type="submit" color="primary" icon="save">
        <q-tooltip>Lưu lại</q-tooltip>
      </q-btn>
      <q-btn label="Làm lại" type="reset" icon="undo">
        <q-tooltip>Làm lại</q-tooltip>
      </q-btn>
    </template>
  </b-form>
</template>
<script lang="ts" setup>
import { YEARS } from 'src/constants';
import { IModel } from '@blessing-vn/core';
import { reactive, ref } from 'vue';

interface FormProps {
  model: IModel;
}

interface FormEmits {
  (e: 'saveChanges', val: IModel): void;
}

const props = defineProps<FormProps>();
const emit = defineEmits<FormEmits>();

const item = ref(props.model);

const years = reactive(YEARS);

const onSubmit = () => {
  emit('saveChanges', item.value);
};
</script>
