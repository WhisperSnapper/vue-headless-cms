﻿Vue.component('leaf-component', {
    created() {
        this.$on('success', function (message) {

        });
        this.$on('failure', function (message) {

        });  
        this.$on('invalid', function (message) {

        }); 
        this.$on('created', function (message) {
            //Reload form once created
            this.record = {};
        });
        this.$on('listed', function (message) {

        });
        this.$on('removed', function (message) {

        });
        this.$on('updated', function (message) {

        });
        this.$on('retrieved', function (message) {

        });
    },
    methods: {

    },
    mixins: [crudBaseMixin]
});
