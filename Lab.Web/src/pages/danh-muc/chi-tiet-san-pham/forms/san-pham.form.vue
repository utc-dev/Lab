<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Id">
        {{ model.id }}
      </b-field-view>
      <b-field-view label="Tên">
        {{ model.ten }}
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Năm sản xuất">
        {{ model.publishYear }}
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Tác giả">
        {{ model.author }}
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Số lượng">
        {{ model.soLuong }}
      </b-field-view>
    </b-field-group-view>
    <b-field-group-view>
      <b-field-view label="Loai">
        {{ model.loai }}
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
