<template>
  <div class="criterion-form">
    <div class="text-italic text-weight-light">{{ title }}</div>
    <div
      class="q-table__container q-table--cell-separator column no-wrap q-table__card q-table--square q-table--flat q-table--bordered q-table--dense q-table--no-wrap"
    >
      <div class="q-table__middle scroll">
        <table class="q-table">
          <thead>
            <tr>
              <th>Số lượng đăng ký</th>
              <th>Số giờ NCKH danh định đăng ký</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>
                <b-input-number dense v-model="soLuongDangKy" :minimum-value="0" :precision="0" />
              </td>
              <td>
                <b-number :value="soGioNckhDanhDinhDangKy" />
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { computed, ref } from 'vue';

export default {
  name: 'b-criterion-form',
};
</script>
<script lang="ts" setup>
const props = defineProps<{
  title: string;
  soLuong: number;
  soGioNckhDanhDinh: number;
}>();
const soLuongDangKy = ref(props.soLuong);
const soGioNckhDanhDinhDangKy = computed(() => {
  return soLuongDangKy.value * props.soGioNckhDanhDinh;
});
</script>
