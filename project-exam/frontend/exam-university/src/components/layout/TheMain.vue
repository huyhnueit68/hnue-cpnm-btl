<template>
    <div class="main" :class="{'navbar-small': !$store.state.toogleMenu}">
        <Header @setNavbarMenu="setNavbarMenu" ref="header"/>
        <Content/>
    </div>
</template>

<script>
import Header from './TheHeader.vue'
import Content from './TheContent.vue'

export default {
  components: {
      Header,
      Content
  },
  methods:{
      /**
       * Function set navbar menu
       * CreatedBy: PQ Huy(19.07.2021)
       */
      setNavbarMenu(){
          this.$emit('setNavbarMenu');
      },
      /**
       * Function set show toogle icon
       * CreatedBy:  PQ Huy(19.07.2021)
       */
      setToogleIcon(isShow){
          this.$refs.header.setToogleIcon(isShow);
      }
  }
}
</script>