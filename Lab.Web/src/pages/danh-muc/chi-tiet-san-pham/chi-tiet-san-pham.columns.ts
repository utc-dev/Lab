import { TableColumn } from '@blessing-vn/webapp';

export const ChiTietSanPhamColumns: TableColumn[] = [
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
    name: 'Ten',
    label: 'Tên',
    field: 'ten',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'PublishYear',
    label: 'Năm sản xuất',
    field: 'publishYear',
    align: 'center',
    sortable: true,
    
  },
  {
    name: 'Author',
    label: 'Tác giả',
    field: 'author',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'SoLuong',
    label: 'Số lượng',
    field: 'soLuong',
    align: 'center',
    sortable: true,
    required: true,
  },
  {
    name: 'Loai',
    label: 'Loại',
    field: 'loai',
    align: 'center',
    sortable: true,
    required: true,
  },
];
