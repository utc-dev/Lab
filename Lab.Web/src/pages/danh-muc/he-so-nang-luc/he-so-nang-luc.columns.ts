import { TableColumn } from '@blessing-vn/webapp';
import { date } from 'quasar';

export const HeSoNangLucColumns: TableColumn[] = [
  {
    name: 'actions',
    field: '',
    label: '',
    align: 'center',
    sortable: false,
    required: true,
  },
  {
    name: 'code',
    label: 'Mã năng lực',
    field: 'code',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'heSo',
    label: 'Hệ số',
    field: 'heSo',
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
