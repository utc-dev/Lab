<template>
  <b-form-details>
    <b-field-group-view>
      <b-field-view label="Id">
        {{ model.id }}
      </b-field-view>
      <b-field-view label="Tên tác giả">
        {{ model.ten }}
      </b-field-view>
    </b-field-group-view>

    <b-field-group-view>
      <b-field-view label="BookId">
        {{ model.bookId }}
      </b-field-view>
      <b-field-view label="Ngày sinh">
        {{ model.birthday }}
      </b-field-view>
    </b-field-group-view>

    <b-field-group-view>
      <b-field-view label="Loại tác giả">
        {{ model.loaiTacGia }}
      </b-field-view>
      <b-field-view label="Địa chỉ">
        {{ model.address }}
      </b-field-view>
    </b-field-group-view>

    <b-field-group-view>
      <b-field-view label="Số điện thoại">
        {{ model.mobile }}
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
