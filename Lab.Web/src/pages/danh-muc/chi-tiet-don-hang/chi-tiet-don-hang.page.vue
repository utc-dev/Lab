<template>
  <b-page-title :title="title"></b-page-title>
  <q-table
    :title="title"
    :rows="items"
    :columns="columns"
    :visibleColumns="visibleColumns"
    v-model:pagination="pagination"
    :loading="loading"
    @request="onTableRequest"
    :row-key="primaryKey"
    loading-label="Đang tải dữ liệu"
    no-data-label="Không có dữ liệu"
    no-results-label="Không tìm thấy kết quả phù hợp"
    flat
    dense
  >
    <template #top-left>
      <q-btn
        flat
        dense
        color="primary"
        icon="add"
        label="Thêm mới"
        @click="add"
      >
        <q-tooltip>Thêm mới <em>Tình trạng thiết bị</em></q-tooltip>
      </q-btn>
    </template>
    <template #top-right="{ inFullscreen, toggleFullscreen }">
      <q-input
        dense
        borderless
        square
        v-model="filterModel.keyword"
        placeholder="Tìm kiếm"
        @keypress.enter="search"
      >
        <template v-slot:append>
          <q-icon name="search" />
          <q-btn flat round icon="filter_list" unelevated dense>
            <q-popup-proxy>
              <q-card flat bordered class="bg-grey-1" style="min-width: 300px">
                <q-card-section class="q-pa-md q-gutter-md">
                  <q-select
                    label="Năm áp dụng"
                    v-model="filterModel.namApDung"
                    :options="years"
                    clearable
                  ></q-select>
                </q-card-section>
                <q-separator />
                <q-card-actions>
                  <q-btn color="primary" @click="search" v-close-popup
                    >Tìm kiếm</q-btn
                  >
                </q-card-actions>
              </q-card>
            </q-popup-proxy>
          </q-btn>
        </template>
      </q-input>
      <q-space />
      <q-btn flat round icon="refresh" @click="refresh()">
        <q-tooltip>Làm mới dữ liệu</q-tooltip>
      </q-btn>
      <q-btn flat round icon="settings">
        <q-tooltip>Cài đặt</q-tooltip>
        <q-popup-proxy>
          <q-card flat bordered class="bg-grey-1">
            <q-card-section>
              <label>Số bản ghi trên 1 trang</label>
              <q-select
                v-model="pagination.rowsPerPage"
                :options="rowsPerPageOptions"
                outlined
                dense
                options-dense
              />
            </q-card-section>
            <q-card-section>
              <label>Hiển thị</label>
              <q-select
                v-model="visibleColumns"
                multiple
                outlined
                dense
                options-dense
                display-value="Cột"
                emit-value
                map-options
                :options="optionsColumns"
                option-value="name"
                options-cover
              />
            </q-card-section>
          </q-card>
        </q-popup-proxy>
      </q-btn>
      <q-btn
        flat
        round
        :icon="inFullscreen ? 'fullscreen_exit' : 'fullscreen'"
        @click="toggleFullscreen"
      />
    </template>
    <template #body-cell-actions="{ row }">
      <q-td style="width: 100px">
        <q-btn flat round color="secondary" icon="info" @click="view(row)">
          <q-tooltip>Chi tiết <em>Lĩnh vực sử dụng</em></q-tooltip>
        </q-btn>
        <q-btn color="grey-7" round flat icon="more_vert">
          <q-menu cover auto-close>
            <q-list>
              <q-item clickable @click="clone(row)">
                <q-item-section avatar>
                  <q-icon name="content_copy" />
                </q-item-section>
                <q-item-section>
                  <q-item-label>Nhân bản</q-item-label>
                </q-item-section>
              </q-item>
              <q-separator />
              <q-item clickable @click="edit(row)">
                <q-item-section avatar>
                  <q-icon color="purple" name="edit" />
                </q-item-section>
                <q-item-section>
                  <q-item-label>Sửa</q-item-label>
                </q-item-section>
              </q-item>
              <q-item clickable @click="remove(row)">
                <q-item-section avatar>
                  <q-icon color="deep-orange" name="delete_outline" />
                </q-item-section>
                <q-item-section>
                  <q-item-label>Xóa</q-item-label>
                </q-item-section>
              </q-item>
            </q-list>
          </q-menu>
        </q-btn>
      </q-td>
    </template>
    <template #bottom="{ pagination, pagesNumber }">
      {{ paginationMessage }}
      <q-space />
      <q-pagination
        :model-value="pagination.page"
        color="grey-8"
        :max="pagesNumber"
        :max-pages="6"
        @update:model-value="changePage"
        boundary-numbers
      />
    </template>
    <template #body-cell-heSo="{ value }">
      <q-td class="text-center">
        <b-number :value="value"></b-number>
      </q-td>
    </template>
  </q-table>
  <b-dialog
    v-model="formShowing"
    :component="formComponent"
    :attributes="formAttributes"
  />
</template>
<script lang="ts" setup>
import { usePage } from '@blessing-vn/webapp';
import { ChiTietDonHangColumns } from './chi-tiet-don-hang.columns';
import { ChiTietDonHangForm, VDonHangForm } from './forms';
import { DEFAULT_YEAR, YEARS } from 'src/constants';

const title = 'Chi Tiết Đơn hàng';
const apiName = 'order-detail';

const {
  items,
  formShowing,
  formComponent,
  formAttributes,
  columns,
  visibleColumns,
  optionsColumns,
  rowsPerPageOptions,
  pagination,
  paginationMessage,
  primaryKey,
  loading,
  filterModel,
  onTableRequest,
  add,
  view,
  clone,
  edit,
  remove,
  refresh,
  changePage,
  search,
} = usePage({
  name: apiName,
  title: title,
  columns: ChiTietDonHangColumns,
  components: {
    addForm: ChiTietDonHangForm,
    editForm: ChiTietDonHangForm,
    viewForm: VDonHangForm,
  },
  events: {
    onAdd: (model) => {
      model.soLuong = 0;
      model.publishYear = DEFAULT_YEAR;
      return model;
    },
  },
  defaultFormAttributes: {
    dialogWidth: '650px',
    dialogHeight: '400px',
  },
});

const years = YEARS;
</script>
