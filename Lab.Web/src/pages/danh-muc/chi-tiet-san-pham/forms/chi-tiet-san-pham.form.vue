<template>
  <b-form @submit="onSubmit">
    <div class="col">
      <q-select 
      :options="selectCategoryDataSource"
      v-model="item.loai"
      emit-value
      option-value="ten"
      option-label="ten"
      label="Thể loại sách" 
      ></q-select>
    </div>
    <div class="row q-col-gutter-x-md">
      <div class="col">
        <q-input v-model="item.ten" label="Tên sách" />
      </div>
      <div class="col">
        <q-select
          v-model="item.publishYear"
          label="Năm sản xuất"
          :options="years"
        ></q-select>
      </div>
      <div class="col">
        <q-select
          :options="selectAuthorDataSource"
          v-model="item.author"
          emit-value
          option-value="ten"
          option-label="ten"
          label="Tên tác giả"
        ></q-select>
      </div>
      <div class="col">
        <b-input-number v-model="item.soLuong" label="Số lượng" />
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
const _categoryService = useService('book-category');
const item = ref(props.model);

const years = reactive(YEARS);
const selectAuthorDataSource = ref([]);
const selectCategoryDataSource = ref([]);
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
  const resp1 = await _categoryService.get('', { params : filter });
  selectAuthorDataSource.value = resp.items;
  selectCategoryDataSource.value = resp1.items;
};
</script>
