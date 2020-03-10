(function ($) {
    alert("Hello1");
        function User() {
            var $this = this;
            alert("hello2");
            function initilizeModel() {
                $("#modal-action-user").on('loaded.bs.modal', function (e) {

                }).on('hidden.bs.modal', function (e) {
                    $(this).removeData('bs.modal');
                });
            }
            $this.init = function () {
                initilizeModel();
            }
        }
        $(function () {
            var self = new User();
            self.init();
        })
   
}(jQuery))  