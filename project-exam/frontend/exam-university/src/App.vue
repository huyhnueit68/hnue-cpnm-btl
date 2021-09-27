<template>
  <div id="app">
    <!-- init component nav bar for display menu items -->
    <NavBar
      v-if="this.$store.state.isLogin"
      ref="navBar"
      :navbarItems="navbarItems"
      @setToogleIcon="setToogleIcon"
    />
    <!-- Display main -->
    <TheMain
      v-if="this.$store.state.isLogin"
      ref="main"
      @setNavbarMenu="setNavbarMenu"
    />
    <!-- init main amit web with 3 main component -->
    <Login v-if="!this.$store.state.isLogin" />
  </div>
</template>

<script>
import NavBar from "./components/layout/TheNavBar.vue";
import TheMain from "./components/layout/TheMain.vue";
import Vue from "vue";
import Vuex from "vuex";
import VTooltip from "v-tooltip";
import { useWindowSize } from "vue-window-size";
import Enumeration from "./js/common/Enumeration";
import Login from "./components/common/Login";

Vue.use(VTooltip);
Vue.use(Vuex);

export default {
  name: "App",
  components: {
    NavBar,
    TheMain,
    Login,
  },
  setup() {
    const { width, height } = useWindowSize();
    return {
      windowWidth: width,
      windowHeight: height,
    };
  },
  created() {
    this.CheckSessionLogin();
  },
  watch: {
    windowWidth: function(val) {
      if (
        val <= Enumeration.WindowSize.Width ||
        this.windowHeight <= Enumeration.WindowSize.Height
      ) {
        this.$store.state.toogleMenu = false;
      }
    },
    windowHeight: function(val) {
      if (
        val <= Enumeration.WindowSize.Height ||
        this.windowWidth <= Enumeration.WindowSize.Height
      ) {
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
        },
      ],
    };
  },
  methods: {
    /**
     * Function set navbar menu
     * CreatedBy:  PQ Huy (19.07.2021)
     */
    setNavbarMenu() {
      this.$refs.navBar.setNavbarMenu();
    },
    /**
     * Fucntion set show toogle icon
     * CreatedBy:  PQ.Huy(19.07.2021)
     */
    setToogleIcon(isShow) {
      this.$refs.main.setToogleIcon(isShow);
    },
    /**
     * Function check session login status
     * CreatedBy: PQ Huy (27.09.2021)
     */
    CheckSessionLogin() {
      // debugger // eslint-disable-line no-debugger
      this.$store.state.isLogin;
    },
  },
};
</script>

<style>
@import url("./assets/css/common/main.css");
@import url("./assets/css/common/tooltip.css");
</style>
