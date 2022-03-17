import { TableColumn } from '@blessing-vn/webapp';
import { date } from 'quasar';

export const GioNCKHDanhDinhColumns: TableColumn[] = [
  {
    name: 'actions',
    field: '',
    label: '',
    align: 'center',
    sortable: false,
    required: true,
  },
  {
    name: 'tieuChi',
    label: 'Tiêu chí',
    field: 'tieuChi',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'soGio',
    label: 'Số giờ',
    field: 'soGio',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'namApDung',
    label: 'Nắm bắt đầu áp dụng',
    field: 'namApDung',
    align: 'center',
    sortable: true,
  },
  {
    name: 'createdAt',
    label: 'Tạo lúc',
    field: 'createdAt',
    align: 'center',
    sortable: true,
    format: (val: string) => {
      return date.formatDate(val, 'HH:mm DD/MM/YYYY');
    },
  },
  {
    name: 'lastModifiedAt',
    label: 'Cập nhật lần cuối lúc',
    field: 'lastModifiedAt',
    align: 'center',
    sortable: true,
    format: (val: string) => {
      return date.formatDate(val, 'HH:mm DD/MM/YYYY');
    },
  },
];
