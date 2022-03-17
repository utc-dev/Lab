import { boot } from 'quasar/wrappers';
import useWebApplication, {
  LayoutYoutube,
  NavigationLink,
} from '@blessing-vn/webapp';
import Components from 'src/components';

export default boot(async ({ app, router }) => {
  await useWebApplication(app, router);
  app.component(LayoutYoutube.name, LayoutYoutube);
  app.use(Components);
  router.beforeEach((to) => {
    const meta = to.meta || {};
    const navigation: NavigationLink | undefined = (meta.navigation ||
      {}) as NavigationLink;
    if (navigation && navigation.text) {
      document.title = `${navigation.text} | Quản lý kế hoạch thực hiện nhiệm vụ KHCN`;
    }
  });
});
