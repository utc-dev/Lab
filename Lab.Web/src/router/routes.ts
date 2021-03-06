import { RouteRecord } from '@blessing-vn/webapp';

export const NavigationGroupLinks: string[] = ['Default', 'Danh mục'];

const routes: RouteRecord[] = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      {
        path: '',
        redirect: 'dang-ky',
      },
      {
        path: 'dang-ky',
        component: () => import('pages/main/dang-ky/dang-ky.page.vue'),
        meta: {
          authorize: true,
          navigation: {
            icon: 'edit_calendar',
            order: 0,
            text: 'Đăng ký',
          },
        },
      },
      {
        path: 'ke-hoach',
        component: () => import('pages/main/ke-hoach/ke-hoach.page.vue'),
        meta: {
          authorize: true,
          navigation: {
            icon: 'pending_actions',
            order: 0,
            text: 'Kế hoạch',
          },
        },
      },
      {
        path: 'danh-muc/he-so-nang-luc',
        component: () =>
          import('pages/danh-muc/he-so-nang-luc/he-so-nang-luc.page.vue'),
        meta: {
          authorize: false,
          navigation: {
            icon: 'trending_up',
            text: 'Hệ số năng lực',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },
      {
        path: 'danh-muc/gio-nckh-danh-dinh',
        component: () =>
          import(
            'pages/danh-muc/gio-nckh-danh-dinh/gio-nckh-danh-dinh.page.vue'
          ),
        meta: {
          authorize: false,
          navigation: {
            icon: 'webhook',
            text: 'Giờ NCKH danh định',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },
      {
        path: 'danh-muc/chi-tiet-san-pham',
        component: () =>
          import('pages/danh-muc/chi-tiet-san-pham/chi-tiet-san-pham.page.vue'),
        meta: {
          authorize: false,
          navigation: {
            icon: 'book',
            text: 'Chi tiết sản phẩm',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },
      {
        path: 'danh-muc/tac-gia',
        component: () =>
          import(
            'pages/danh-muc/tac-gia/tac-gia.page.vue'
          ),
        meta: {
          authorize: false,
          navigation: {
            icon: 'info',
            text: 'Chi tiết tác giả',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },
      {
        path: 'danh-muc/the-loai-sach',
        component: () =>
          import(
            'pages/danh-muc/the-loai-sach/chi-tiet-the-loai.page.vue'
          ),
        meta: {
          authorize: false,
          navigation: {
            icon: 'menu_book',
            text: 'Thể loại sách',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },

      {
        path: 'danh-muc/don-hang',
        component: () =>
          import(
            'pages/danh-muc/don-hang/don-hang.page.vue'
          ),
        meta: {
          authorize: false,
          navigation: {
            icon: 'list_alt',
            text: 'Đơn hàng',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },

      {
        path: 'danh-muc/chi-tiet-don-hang',
        component: () =>
          import(
            'pages/danh-muc/chi-tiet-don-hang/chi-tiet-don-hang.page.vue'
          ),
        meta: {
          authorize: false,
          navigation: {
            icon: 'crop_original',
            text: 'Chi tiết Đơn hàng',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },

      {
        path: 'danh-muc/hoa-don',
        component: () =>
          import(
            'pages/danh-muc/hoa-don/chi-tiet-hoa-don.page.vue'
          ),
        meta: {
          authorize: false,
          navigation: {
            icon: 'credit_card',
            text: 'Chi tiết hóa đơn',
            order: 0,
            group: NavigationGroupLinks[1],
          },
        },
      },


    ],
  },
  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/Error404.vue'),
  },
];

export default routes;
