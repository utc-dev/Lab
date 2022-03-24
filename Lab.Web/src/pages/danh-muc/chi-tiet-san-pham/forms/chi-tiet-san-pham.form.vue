<template>
  <b-form @submit="onSubmit">
    <div class="row q-col-gutter-x-md">
      <div class="col">
        <b-select-criterion v-model="item.loai" label="Thể loại sách" />
      </div>
    </div>
    <div class="row q-col-gutter-x-md">
      <div class="col">
        <q-input v-model="item.ten" label="Tên sách" />
      </div>
      <div class="col">
        <q-select
          v-model="item.namApDung"
          label="Năm sản xuất"
          :options="years"
        ></q-select>
      </div>
      <div class="col">
        <q-input v-model="item.author" label="Tác giả" />
      </div>
      <div class="col">
        <b-input-number v-model="item.soLuong" label="Số lượng" />
      </div>
      <div class="col">
        <b-input-number v-model="item.id" label="Id" />
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
