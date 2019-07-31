var user = {
    init: function () {
        user.loadProvince();
    },
    loadProvince: function () {
        var html = '';
        $.ajax({
            url: '/Admin/Home/LoadProvince',
            type: 'POST',
            dataType: "json",
            success: function (response) {
                if (response.status === true) {
                    var data = response.data;
                    $.each(data, function (i, item) {
                        html += '<option value = ' + item.ProvinceID + '>' + item.ProvinceName + ' </option>'
                    });
                    $('#ddlProvince').html(html);
                }
            }
        });
    }
};
user.init();