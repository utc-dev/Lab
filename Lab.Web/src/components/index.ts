import { GlobalComponentConstructor, QSelectProps, QSelectSlots } from 'quasar';
import { App } from 'vue';
import BCriterionForm from './criterion-form.component.vue';
import BCriterion from './criterion.component.vue';
import BScholastic from './scholastic.component.vue';
import BSelectCriterion from './select-criterion.component.vue';

export default function install(app: App) {
  app.component(BCriterionForm.name, BCriterionForm);
  app.component(BCriterion.name, BCriterion);
  app.component(BScholastic.name, BScholastic);
  app.component(BSelectCriterion.name, BSelectCriterion);
}

interface BSelectCriterionProps extends Omit<QSelectProps, 'modelValue'> {
  modelValue?: number | string | null;
}

declare module '@vue/runtime-core' {
  interface GlobalComponents {
    BCriterionForm: GlobalComponentConstructor<{
      title: string;
      soLuong: number;
      soGioNckhDanhDinh: number;
      soGioNckhDanhDinhCanDatDuoc: number;
    }>;

    BCriterion: GlobalComponentConstructor<{
      criterion: number | string | null;
    }>;

    BScholastic: GlobalComponentConstructor<{
      scholastic: number | string | null;
    }>;

    BSelectCriterion: GlobalComponentConstructor<
      BSelectCriterionProps,
      QSelectSlots
    >;
  }
}
