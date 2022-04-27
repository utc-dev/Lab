<template>
  <b-form @submit="onSubmit">
    <div class="col">
      <q-input v-model="item.maHD" label="Mã hóa đơn" />
    </div>

    <div class="row q-col-gutter-x-md">

      <div class="col">
        <q-input v-model="item.tenHD" label="Tên hóa đơn" />
      </div>

      <div class="col">
        <q-input v-model="item.maSP" label="Mã sản phẩm" />
      </div>

      <div class="col">
        <q-input v-model="item.soLuong" label="Số lượng" />
      </div>

      <div class="col">
        <q-input v-model="item.note" label="Ghi chú" />
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
import { reactive, ref, onMounted } from 'vue';
import { useService } from '@blessing-vn/webapp';
interface FormProps {
  model: IModel;
}

interface FormEmits {
  (e: 'saveChanges', val: IModel): void;
}

const props = defineProps<FormProps>();
const emit = defineEmits<FormEmits>();

const _authorService = useService('book-author');

const item = ref(props.model);

const years = reactive(YEARS);
const selectAuthorDataSource = ref([]);
const onSubmit = () => {
  emit('saveChanges', item.value);
};

onMounted(async () => {
  await GetDataSourceForDropdown();
});

const GetDataSourceForDropdown = async () => {
  await GetBookAuthors();
};

const GetBookAuthors = async () => {
  const filter = {
    keyword: '',
    page: 1,
    size: 10000,
  };
  const resp = await _authorService.get('', { params: filter });
  selectAuthorDataSource.value = resp.items;
};
</script>
