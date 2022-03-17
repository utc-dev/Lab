import { TableColumn } from '@blessing-vn/webapp';
import { date } from 'quasar';

export const KeHoachColumns: TableColumn[] = [
  {
    name: 'actions',
    field: '',
    label: '',
    align: 'center',
    sortable: false,
    required: true,
  },
  {
    name: 'namHoc',
    label: 'Năm học',
    field: 'namHoc',
    align: 'center',
    sortable: true,
    required: true,
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
