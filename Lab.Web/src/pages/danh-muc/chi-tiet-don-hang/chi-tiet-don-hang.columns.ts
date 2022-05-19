import { TableColumn } from '@blessing-vn/webapp';

export const ChiTietDonHangColumns: TableColumn[] = [
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
    name: 'maDH',
    label: 'maDH',
    field: 'maDH',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'MaSP',
    label: 'MaSP',
    field: 'maSP',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'SoLuong',
    label: 'So Luong',
    field: 'soLuong',
    align: 'left',
    sortable: true,
    required: true,
  },

  {
    name: 'NgayTaoDon',
    label: 'NgayTaoDon',
    field: 'ngayTaoDon',
    align: 'left',
    sortable: true,
    required: true,
  },

  {
    name: 'TrangThai',
    label: 'TrangThai',
    field: 'trangThai',
    align: 'left',
    sortable: true,
    required: true,
  },
  
];
