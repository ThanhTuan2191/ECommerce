var user = {
    init: function () {
        user.loadProvince();
        user.registerEvent();
    },
    registerEvent: function () {
        $('#ddlProvince').off('change').on('change', function () {
            var id = $(this).val();
            if (id !== '') {
                user.loadDistrict(id);
            } else {
                $('#ddlDistrict').html('');
            }
        });
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
    },

    loadDistrict: function (id) {
        var html = '';
        $.ajax({
            url: '/Admin/Home/LoadDistrict',
            type: 'POST',
            data: { ProvinceID: id },
            dataType: "json",
            success: function (response) {
                if (response.status === true) {
                    var data = response.data;
                    $.each(data, function (i, item) {
                        html += '<option value = ' + item.DistrictID + '>' + item.DistrictName + '</option>'
                    });
                    $('#ddlDistrict').html(html);
                }
            }
        });
    }
};
user.init();