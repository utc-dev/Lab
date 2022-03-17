<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Mã năng lực">
        {{ model.code }}
      </b-field-view>
      <b-field-view label="Hệ số">
        <b-number :value="model.heSo"></b-number>
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Năm bắt đầu áp dụng">
        {{ model.namApDung }}
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Tạo bởi">
        {{ model.createdBy.fullName }}
      </b-field-view>
      <b-field-view label="Tạo lúc">
        {{ $formatDate(model.createdAt, 'HH:mm DD/MM/YYYY') }}
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Thay đổi lần cuối bởi">
        {{ model.lastModifiedBy.fullName }}
      </b-field-view>
      <b-field-view label="Thay đổi lần cuối lúc">
        {{ $formatDate(model.lastModifiedAt, 'HH:mm DD/MM/YYYY') }}
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
