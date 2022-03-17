<template>
  <b-form @submit="onSubmit">
    <div class="row q-col-gutter-x-md">
      <div class="col-12 col-md-6">
        <q-select
          v-model="item.namHoc"
          label="Năm học"
          :options="scholastics"
        ></q-select>
      </div>
      <div class="col-12 col-md-6"></div>
    </div>
    <div class="q-table__title">NĂNG LỰC GIẢNG VIÊN</div>
    <q-table
      flat
      dense
      square
      separator="cell"
      bordered
      hide-bottom
      :columns="nangLucGiangVienColumns"
      :rows="item.nangLucGiangViens"
    >
      <template #bottom-row="{ cols }">
        <tr>
          <td v-for="col in cols" :key="col.field" :class="`text-${col.align}`">
            {{ item.summary[col.field] }}
          </td>
        </tr>
      </template>
    </q-table>

    <div class="q-table__title">CHỈ TIÊU</div>

    <div class="criterion-title text-bold">
      Số lượng nhiệm vụ KHCN mà CBGV chủ trì được cấp mới trong năm
      {{ item.namHoc?.value + 1 }}
    </div>
    <b-criterion-form
      title="Cấp quốc gia/quốc tế"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Cấp Bộ và tương đương"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Cấp Trường trọng điểm"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Cấp Trường"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>

    <div class="criterion-title text-bold">
      Số lượng đề tài NCKH của SV trong năm học
      <b-scholastic :scholastic="item.namHoc?.value" />
    </div>
    <b-criterion-form
      title="Nghiệm thu cấp trường"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Đạt giải trên cấp Trường"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>

    <div class="criterion-title text-bold">
      Số lượng bài báo tạp chí khoa học do CBGV công bố trong năm học
      <b-scholastic :scholastic="item.namHoc?.value" />
    </div>
    <b-criterion-form
      title="SCIE/SSCI/A&HCI/ESCI"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Scopus"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Quốc tế khác"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Trong nước"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>

    <div class="criterion-title text-bold">
      Số lượng báo cáo hội nghị hội thảo khoa học của CBGV trong năm học
      <b-scholastic :scholastic="item.namHoc?.value" />
    </div>
    <b-criterion-form
      title="Quốc tế"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Trong nước"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>

    <div class="criterion-title text-bold">
      Số lượng đăng ký SHTT, biên soạn TCCS trong năm học
      <b-scholastic :scholastic="item.namHoc?.value" />
    </div>
    <b-criterion-form
      title="Sáng chế"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Giải pháp hữu ích, TCCS"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>

    <div class="criterion-title text-bold">
      Số lượng HNHT khoa học tổ chức trong năm học
      <b-scholastic :scholastic="item.namHoc?.value" />
    </div>
    <b-criterion-form
      title="Quốc tế"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>
    <b-criterion-form
      title="Trong nước"
      :so-luong="0"
      :so-gio-nckh-danh-dinh="400"
      :so-gio-nckh-danh-dinh-can-dat-duoc="450"
    ></b-criterion-form>

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
<style lang="scss" scoped>
.criterion-title {
  text-decoration: underline;
}
</style>
<script lang="ts" setup>
import { SCHOLASTICS } from 'src/constants';
import { IModel } from '@blessing-vn/core';
import { reactive, ref } from 'vue';
import { TableColumn } from '@blessing-vn/webapp';

interface FormProps {
  model: IModel;
}
interface FormEmits {
  (e: 'saveChanges', val: IModel): void;
}

const props = defineProps<FormProps>();
const emit = defineEmits<FormEmits>();

const item = ref(props.model);

const scholastics = reactive(SCHOLASTICS);

const nangLucGiangVienColumns: TableColumn[] = [
  {
    name: 'donVi',
    label: 'Đơn vị',
    field: 'donVi',
    align: 'left',
    sortable: true,
  },
  {
    name: 'ks',
    label: 'KS/CN',
    field: 'ks',
    align: 'right',
    sortable: true,
  },
  {
    name: 'ths',
    label: 'ThS',
    field: 'ths',
    align: 'right',
    sortable: true,
  },
  {
    name: 'ts',
    label: 'TS',
    field: 'ts',
    align: 'right',
    sortable: true,
  },
  {
    name: 'pgs',
    label: 'PGS',
    field: 'pgs',
    align: 'right',
    sortable: true,
  },
  {
    name: 'gs',
    label: 'GS',
    field: 'gs',
    align: 'right',
    sortable: true,
  },
  {
    name: 'nangLuc',
    label: 'Năng lực GV',
    field: 'nangLuc',
    align: 'right',
    sortable: true,
  },
  {
    name: 'tyTrong',
    label: 'Tỷ trọng',
    field: 'tyTrong',
    align: 'right',
    sortable: true,
  },
];

item.value.nangLucGiangViens = [
  {
    donVi: 'Khoa Công nghệ thông tin',
    ks: 10,
    ths: 1,
    ts: 2,
    pgs: 1,
    gs: 1,
    nangLuc: 16,
    tyTrong: 34.71,
  },
  {
    donVi: 'Khoa Cơ khí',
    ks: 7,
    ths: 3,
    ts: 0,
    pgs: 0,
    gs: 5,
    nangLuc: 30.1,
    tyTrong: 65.29,
  },
];
item.value.summary = {
  donVi: 'Chỉ tiêu toàn Trường',
  ks: 17,
  ths: 4,
  ts: 2,
  pgs: 1,
  gs: 6,
  nangLuc: 46.1,
  tyTrong: 100,
};

const onSubmit = () => {
  emit('saveChanges', item.value);
};
</script>
