<template>
    <div class="hnue-toas"></div>
</template>

<script>
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
    setup() {
        
    },
    props: {
        _icon: String,
        _title: String
    },
    created() {
        this.popupNotification(this._icon, this._title);
    },
    methods: {
        /**
         * Show popup notification
         * @param {string} icon
         * @param {string} title
         * CreatedBy: PQ Huy (25.09.2021)
         */
        popupNotification(icon, title){
            const Toast = Swal.mixin({
                    toast: true,
                    position: 'bottom-end',
                    showConfirmButton: false,
                    timer: 3000,
                    customClass: "popup-success",
                    timerProgressBar: true,
                    didOpen: (toast) => {
                    toast.addEventListener('mouseenter', Swal.stopTimer)
                    toast.addEventListener('mouseleave', Swal.resumeTimer)
                }
            })
            Toast.fire({
                icon: `${icon}`,
                title: `${title}`
            })
        }
    }
})
</script>

<style scoped>

</style>