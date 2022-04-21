<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Mã">
        {{ model.ma }}
      </b-field-view>
      <b-field-view label="Tên">
        {{ model.ten }}
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
