var loginAdmin = function () {
    this.initial = function () {
        registerEvents();
    };


    var registerEvents = function () {
        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            var email = $('#txtEmail').val();
            var password = $('#txtPassword').val();
            login(email, password);
        });
    };

    var login = function (email, password) {
        $.ajax({
            type: 'POST',
            data: {
                Email: email,
                Password: password
            },
            dataType: 'json',
            url: '/Admin/Login/Login',
            success: function (respon) {
                if (respon.Success) {
                    window.location.href = "/Admin/Home/Index";
                }
            }
        })
    }
};