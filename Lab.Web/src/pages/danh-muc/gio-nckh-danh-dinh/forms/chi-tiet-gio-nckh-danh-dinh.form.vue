<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Tiêu chí" label-size="3" content-size="9">
        <b-criterion :criterion="model.tieuChi" />
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Số giờ">
        <b-number :value="model.soGio"></b-number>
      </b-field-view>
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
