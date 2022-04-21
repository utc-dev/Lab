<template>
  <b-form @submit="onSubmit">
    <!-- Thử -->
    <q-btn flat round color="primary" @click="addAuthor" icon="fas fa-plus" />
    <table>
      <tbody>
        <tr v-for="(model, index) in models" :key="index">
          <div class="row q-col-gutter-x-md">
            <div class="col">
              <q-input v-model="model.bookId" type="number" label="BookId" :rules="rules.bookId" />
            </div>

            <div class="col">
              <q-input v-model="model.ten" label="Tên tác giả" />
            </div>

            <div class="col">
              <q-input v-model="model.birthday" dense="false" type="date" label="Ngày sinh" :stack-label="true"/>
              <!-- <q-input v-model="model.birthday" label="Ngay sinh" /> -->
            </div>

            <div class="col">
              <q-input v-model="model.loaiTacGia" label="Loại tác giả" />
            </div>

            <div class="col">
              <q-input v-model="model.address" label="Địa chỉ" />
            </div>

            <div class="col">
              <q-input v-model="model.mobile" label="Số điện thoại" />
            </div>

          </div>  
          <q-btn flat round color="primary" icon="fas fa-backspace" v-on:click="removeAuthor(index)" />
        </tr>
      </tbody>
    </table>
    <!-- Thử -->
    <!--
    <q-btn flat round color="primary" 
    @click="showContent = !showContent"
    icon="fas fa-plus" />
      <div class="row q-col-gutter-x-md" v-if="showContent">
        <div class="col">
            <q-input v-model="item.bookId" label="BookId" />
        </div>

        <div class="col">
            <q-input v-model="item.ten" label="Tên tác giả" />
        </div>

        <div class="col">
            <q-input v-model="item.birthday" label="Ngày sinh" />
        </div>

        <div class="col">
            <q-input v-model="item.loaiTacGia" label="Loại tác giả" />
        </div>

        <div class="col">
            <q-input v-model="item.address" label="Địa chỉ" />
        </div>

        <div class="col">
            <q-input v-model="item.mobile" label="Số điện thoại" />
        </div>
      </div>
    -->

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
import { reactive, readonly, ref } from 'vue';

interface FormProps {
  model: IModel;
}
interface FormEmits {
  (e: 'saveChanges', val: IModel): void;
  (e: 'saveMultiple', vals: IModel[]): void;
}

const props = defineProps<FormProps>();
const emit = defineEmits<FormEmits>();

const item = ref(props.model);

const years = reactive(YEARS);
const showContent = ref(false);
const models = ref<IModel[]>([]);
const onSubmit = () => {
  console.log(models.value)
  emit('saveMultiple', models.value);
};

const addAuthor = () => {
  if (!models.value) {
    models.value = [];
  }
  models.value.push({});
}
const removeAuthor = (index: number) => {
  models.value.splice(index, 1);
}
// const addNumber = () => {
//   item.value.numbers.push((item.value.numbers.length) + 1);
// }

// const removeElement = () => {
//   item.value.number.remove((item.value.numbers.length) - 1);
// }
const rules = readonly<IModel>({
  bookId: [(val: number | string) => !!val || 'Field is required'],
});
</script>
