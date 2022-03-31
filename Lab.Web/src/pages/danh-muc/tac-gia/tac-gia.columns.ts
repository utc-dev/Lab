import { TableColumn } from '@blessing-vn/webapp';

export const ChiTietTacGiaColumns: TableColumn[] = [
  {
    name: 'actions',
    field: '',
    label: '',
    align: 'center',
    sortable: false,
    required: true,
  },
  {
    name: 'Id',
    label: 'Id',
    field: 'id',
    align: 'left',
    sortable: true,
    required: true,
  },
  {
    name: 'BookId',
    label: 'BookId',
    field: 'bookId',
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
  {
    name: 'Birthday',
    label: 'Ngày sinh',
    field: 'birthday',
    align: 'center',
    sortable: true,
    
  },
  {
    name: 'LoaiTacGia',
    label: 'Loại tác giả',
    field: 'loaitacgia',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'Address',
    label: 'Địa chỉ',
    field: 'address',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'Mobie',
    label: 'Số điện thoại',
    field: 'mobie',
    align: 'center',
    sortable: true,
    required: true,
  },
];
