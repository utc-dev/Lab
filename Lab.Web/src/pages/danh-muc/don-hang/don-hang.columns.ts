import { TableColumn } from '@blessing-vn/webapp';

export const DonHangColumns: TableColumn[] = [
  {
    name: 'actions',
    field: '',
    label: '',
    align: 'center',
    sortable: false,
    required: true,
  },
  {
    name: 'id',
    label: 'Id',
    field: 'id',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'MaDH',
    label: 'Mã đơn hàng',
    field: 'maDH',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'OrderDate',
    label: 'OrderDate',
    field: 'orderDate',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'TenDH',
    label: 'Tên đơn hàng',
    field: 'tenDH',
    align: 'left',
    sortable: true,
    required: true,
  },
  
];
