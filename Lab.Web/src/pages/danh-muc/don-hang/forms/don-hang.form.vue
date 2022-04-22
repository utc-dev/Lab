<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Id">
        {{ model.id }}
      </b-field-view>

      <b-field-view label="Mã đơn hàng">
        {{ model.maDH }}
      </b-field-view>

      <b-field-view label="OrderDate">
        {{ model.orderDate }}
      </b-field-view>

      <b-field-view label="Tên đơn hàng">
        {{ model.tenDH }}
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
