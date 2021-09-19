<template>
    <div class="header-container">
        <!-- init header left -->
        <div class="header-left">
            <!-- toggle icon -->
            <div class="header-icon-toggle" v-show="this.$store.state.toogleMenu" @click="navbarMenu">
                <div class="toogle-icon mi-icon mi-icon-24"></div>
            </div>
            <!-- branch name -->
            <div class="header-branch">
                <div class="branch-name">
                    <span>KHOA CÔNG NGHỆ THÔNG TIN</span>
                </div>
                <div class="branch-drop-icon">
                    <div class="drop-icon mi-icon mi-icon-14"></div>
                </div>
            </div>
        </div>
        <!-- header right -->
        <div class="header-right">
            <!-- icon bell notification -->
            <div class="header-bell-notification">
                <div class="bell-icon mi-icon mi-icon-24"></div>
            </div>
            <!-- acoount with avatar, name -->
            <div class="header-account">
                <div class="account-avatar mi-icon mi-icon-32"></div>
                <div class="account-name">
                    <span>Phạm Quang Huy</span>
                </div>
                <!-- icon show more option -->
                <div class="account-drop">
                    <div class="drop-icon mi-icon mi-icon-14"></div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    data(){
        return {
            isShow: true
        }
    },
    methods: {
        /**
         * Function set navbar menu big/small
         * CreatedBy: PQ Huy (19.07.2021)
         */
        navbarMenu(){
            this.isShow = !this.isShow;
            this.$emit('setNavbarMenu');
        },
        /**
         * Function set toogle icon
         * CreatedBy: PQ Huy (19.07.2021)
         */
        setToogleIcon(isShow){
            this.isShow = isShow;
        }
    }
}
</script>
 
<style>
    @import url('../../assets/css/common/header.css');
</style>