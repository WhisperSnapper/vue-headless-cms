//Base model ajax binder
//https://jsfiddle.net/q59s90oy/13/ tree effect posibility
//CSS branching https://codepen.io/yukulele/pen/KCvbi
// CSS triangles : https://codepen.io/yukulele/pen/KCvbi

Vue.component('tree-component', {
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
