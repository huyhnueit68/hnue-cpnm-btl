<template>
  <div id="app">
    <!-- init main amit web 
    with 3 main component -->
    <!-- init component nav bar for display menu items -->
    <NavBar ref="navBar" :navbarItems="navbarItems" @setToogleIcon="setToogleIcon"/>
    <!-- Display main -->
    <TheMain ref="main" @setNavbarMenu="setNavbarMenu"/>
  </div>
</template>
 
<script>
import NavBar from './components/layout/TheNavBar.vue'
import TheMain from './components/layout/TheMain.vue'
import Vue from 'vue'
import Vuex from 'vuex'
import VTooltip from 'v-tooltip'
import { useWindowSize } from 'vue-window-size';
import Enumeration from './js/common/Enumeration'

Vue.use(VTooltip)
Vue.use(Vuex)

export default {
  name: 'App',
  components: {
    NavBar,
    TheMain
  },
  setup() {
    const { width, height } = useWindowSize();
    return {
      windowWidth: width,
      windowHeight: height,
    };
  },
  watch:{
    windowWidth: function(val){
      if(val <= Enumeration.WindowSize.Width || this.windowHeight <= Enumeration.WindowSize.Height){
        this.$store.state.toogleMenu = false;
      }
    },
    windowHeight: function(val){
      if(val <= Enumeration.WindowSize.Height || this.windowWidth <= Enumeration.WindowSize.Height){
        this.$store.state.toogleMenu = false;
      }
    },
  },
  data() {
    return {
      navbarItems: [
        {
          c_icon: "icon-dashboard",
          m_title: "Tổng quan",
          m_router: "/",
        },
        {
          c_icon: "icon-cash",
          m_title: "Trang cá nhân",
          m_router: "/personal-page",
        },
        {
          c_icon: "icon-deposits",
          m_title: "Lịch sử thi",
          m_router: "/exam-history",
        },
        {
          c_icon: "icon-purchase",
          m_title: "Thi thử",
          m_router: "/exam",
        },
        {
          c_icon: "icon-sell",
          m_title: "Bộ câu hỏi",
          m_router: "/list-question",
        },
        {
          c_icon: "icon-bill",
          m_title: "Danh sách câu hỏi",
          m_router: "/bill",
        },
        {
          c_icon: "icon-warehouse",
          m_title: "Lịch sử trả lời câu hỏi",
          m_router: "/warehouse",
        },
        {
          c_icon: "icon-tools",
          m_title: "Bộ môn thi",
          m_router: "/tools",
        },
        // {
        //   c_icon: "icon-assets",
        //   m_title: "Tài sản cố định",
        //   m_router: "/assets",
        // },
        // {
        //   c_icon: "icon-tax",
        //   m_title: "Thuế",
        //   m_router: "/tax",
        // },
        // {
        //   c_icon: "icon-price",
        //   m_title: "Giá thành",
        //   m_router: "/price",
        // },
        // {
        //   c_icon: "icon-synthetic",
        //   m_title: "Tổng hợp",
        //   m_router: "/synthetic",
        // },
        {
          c_icon: "icon-budget",
          m_title: "Bảng điểm và Bảng xếp hạng",
          m_router: "/budget",
        },
        {
          c_icon: "icon-report",
          m_title: "Thống kê",
          m_router: "/report",
        },
        {
          c_icon: "icon-analysis",
          m_title: "Liên hệ",
          m_router: "/analysis",
        }
      ],
    }
  },
  methods:{
    /**
     * Function set navbar menu
     * CreatedBy:  PQ Huy (19.07.2021)
     */
    setNavbarMenu(){
      this.$refs.navBar.setNavbarMenu();
    },
    /**
     * Fucntion set show toogle icon
     * CreatedBy:  PQ.Huy(19.07.2021)
     */
    setToogleIcon(isShow){
      this.$refs.main.setToogleIcon(isShow);
    }
  }
}

</script>

<style>
  @import url("./assets/css/common/main.css");
  @import url("./assets/css/common/tooltip.css");
</style>