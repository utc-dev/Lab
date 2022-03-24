import { CriterionOption } from './models';

const DEFAULT_YEAR: number = new Date().getFullYear();
const lengthOfYear = DEFAULT_YEAR - 2016 + 5;
const YEARS: number[] = Array<number>(lengthOfYear)
  .fill(1990)
  .map((y, i) => y + i)
  .reverse();
const SCHOLASTICS: { value: number; label: string }[] = YEARS.map((x) => ({ value: x, label: `${x}-${x + 1}` }));

// const ENDPOINT_NGACH_LUONG =
//   'https://usmart-gateway-v5.utc.edu.vn/canbo/v5/DM_NgachLuong/GetAllByFilter';

// const NGACH_GIANG_VIEN = [
//   { id: 'V.07.01.01', code: 'GVCC', label: 'Giảng viên cao cấp' },
//   { id: 'V.07.01.02', code: 'GVC', label: 'Giảng viên chính' },
//   { id: 'V.07.01.03', code: 'GV', label: 'Giảng viên' },
//   { id: 'V.07.01.23', code: 'TG', label: 'Trợ giảng' },
// ];

const CRITERIONS = [
  {
    group: 'Thể loại sách',
    items: [
      { value: 1, label: 'Văn học' },
      { value: 2, label: 'Kinh tế' },
      { value: 3, label: 'Thiếu nhi' },
      { value: 4, label: 'Kỹ năng sống' },
      { value: 5, label: 'Truyện tranh'},
      { value: 6, label: 'Kinh tế'},
      { value: 7, label: ' Từ điển'},
      { value: 8, label: 'Ngoại ngữ'},
      { value: 9, label: 'Tham khảo'},
      { value: 10, label: 'Lịch sử'},
      { value: 11, label: 'Toán học'},
      { value: 12, label: 'Kiến thức tổng hợp'},
    ],
  },
  
];

const CRITERION: { [key: number | string]: CriterionOption } = {};
CRITERIONS.forEach(({ group, items }) => {
  items.forEach(({ value, label }) => {
    CRITERION[value] = {
      group: false,
      value,
      label,
      description: group,
    };
  });
});

export { DEFAULT_YEAR, YEARS, SCHOLASTICS, CRITERIONS, CRITERION };
