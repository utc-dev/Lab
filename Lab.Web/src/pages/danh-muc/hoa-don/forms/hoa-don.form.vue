<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Id">
        {{ model.id }}
      </b-field-view>

      <b-field-view label="Mã hóa đơn">
        {{ model.maHD }}
      </b-field-view>

      <b-field-view label="Tên hóa đơn">
        {{ model.tenHD }}
      </b-field-view>

      <b-field-view label="Mã sản phẩm">
        {{ model.maSP }}
      </b-field-view>

      <b-field-view label="SoLuong">
        {{ model.soLuong }}
      </b-field-view>

      <b-field-view label="Ghi chú">
        {{ model.note }}
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
