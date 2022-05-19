import { CriterionOption } from './models';
const DEFAULT_YEAR: number = new Date().getFullYear();
const lengthOfYear = DEFAULT_YEAR - 1990 + 5;
const YEARS: number[] = Array<number>(lengthOfYear)
  .fill(1990)
  .map((y, i) => y + i)
  .reverse();
const SCHOLASTICS: { value: number; label: string }[] = YEARS.map((x) => ({
  value: x,
  label: `${x}-${x + 1}`,
}));

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
    group: 'Trạng thái',
    items: [
      { value: 1, label: 'Hoàn thành' },
      { value: 2, label: 'Chưa hoàn thành' },
    ],
  },
];

const TACGIA = [];

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
