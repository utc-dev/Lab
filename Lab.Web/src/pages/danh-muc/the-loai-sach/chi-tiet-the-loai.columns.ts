import { TableColumn } from '@blessing-vn/webapp';

export const ChiTietTheLoaiColumns: TableColumn[] = [
  {
    name: 'actions',
    field: '',
    label: '',
    align: 'center',
    sortable: false,
    required: true,
  },
  {
    name: 'Ma',
    label: 'Ma',
    field: 'ma',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'Ten',
    label: 'Tên',
    field: 'ten',
    align: 'center',
    sortable: true,
    required: true,
  },
  
];
