<template>
    <div class="login-page">
        <div class="login-page__lang">
            <div class="lang__box">
                <div class="icon-box">
                    <div class="icon-vn"></div>
                </div>
                <div class="title-lang">Tiếng Việt</div>
                <!-- <div class="lang__box--option">
                    <div class="option--vn">
                        <span class="vn-text">Tiếng Việt</span>
                    </div>
                    <div class="option--eng">
                        <span class="eng-text">English</span>
                    </div>
                </div> -->
            </div>
        </div>
        <div class="login-page__box-login">
            <div class="box-login-container">
                <div class="login-page-container">
                    <div class="box-login--title">
                        <img src="../../assets/img/logo trường.png" class="logo-hnue-custom" alt="">
                        <div class="box-login--title-icon">
                            HỆ THỐNG THI THỬ HNUE
                        </div>
                    </div>
                    <div class="box-login--input-user">
                        <input type="text" class="username focus-blue" placeholder="Số điện thoại/mail">
                    </div>
                    <div class="box-login--input-pass">
                        <input type="password" class="password focus-blue" placeholder="Mật khẩu">
                    </div>
                    <div class="box-login--forgot">
                        <a href="" class="forgot-password">Quên mật khẩu?</a>
                    </div>
                    <div class="box-login--input-login">
                        <div class="login-form-btn">
                            Đăng nhập
                        </div>
                    </div>
                    <div class="box-login--register">
                        <span>Chưa có tài khoản?</span>
                        <a href="" class="register">Đăng ký</a>
                    </div>
                </div>
            </div>
        </div>
        <div class="text-center copy-right-text">Copyright © 2021 - FIT HNUE</div>
    </div>
</template>

<script>
export default {
    data(){
        return {
        }
    },
    methods: {
        
    }
}
</script>
 
<style scoped>
    @import url('../../assets/css/common/login-page.css');
    @import url('../../assets/css/common/main.css');
</style>