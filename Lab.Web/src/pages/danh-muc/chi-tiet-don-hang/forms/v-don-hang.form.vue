<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Id">
        {{ model.id }}
      </b-field-view>

      <b-field-view label="Mã đơn hàng">
        {{ model.maDH }}
      </b-field-view>

      <b-field-view label="Mã sản phẩm">
        {{ model.maSP }}
      </b-field-view>

      <b-field-view label="Số lượng">
        {{ model.soLuong }}
      </b-field-view>

      <b-field-view label="Ngày tạo đơn">
        {{ model.ngayTaoDon }}
      </b-field-view>

      <b-field-view label="Trạng thái">
        {{ model.trangThai }}
      </b-field-view>
    </b-field-group-view>
  </b-form-details>
</template>
<script lang="ts" setup>
import { IModel } from '@blessing-vn/core';

interface FormProps {
  model: IModel;
}

defineProps<FormProps>();
</script>
