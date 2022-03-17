import { CriterionOption } from './models';

const DEFAULT_YEAR: number = new Date().getFullYear();
const lengthOfYear = DEFAULT_YEAR - 2016 + 5;
const YEARS: number[] = Array<number>(lengthOfYear)
  .fill(2016)
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
    group: 'Nhiệm vụ KHCN mà CBGV chủ trì được cấp mới trong năm tới',
    items: [
      { value: 1, label: 'Cấp quốc gia/quốc tế' },
      { value: 2, label: 'Cấp Bộ và tương đương' },
      { value: 3, label: 'Cấp Trường trọng điểm' },
      { value: 4, label: 'Cấp Trường' },
    ],
  },
  {
    group: 'Đề tài NCKH của SV trong năm học',
    items: [
      { value: 5, label: 'Nghiệm thu cấp Trường' },
      { value: 6, label: 'Đạt giải ngoài Trường' },
    ],
  },
  {
    group: 'Bài báo tạp chí khoa học do CBGV công bố trong năm học',
    items: [
      { value: 7, label: 'SCIE/SSCI/A&HCI/ESCI' },
      { value: 8, label: 'Scopus' },
      { value: 9, label: 'Quốc tế khác' },
      { value: 10, label: 'Trong nước' },
    ],
  },
  {
    group: 'Báo cáo hội nghị hội thảo khoa học của CBGV trong năm học',
    items: [
      { value: 11, label: 'Quốc tế' },
      { value: 12, label: 'Trong nước' },
    ],
  },
  {
    group: 'Đăng ký SHTT, biên soạn TCCS trong năm học',
    items: [
      { value: 13, label: 'Sáng chế' },
      { value: 14, label: 'Giải pháp hữu ích, TCCS' },
    ],
  },
  {
    group: 'HNHT khoa học tổ chức trong năm học',
    items: [
      { value: 15, label: 'Quốc tế' },
      { value: 16, label: 'Trong nước' },
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
