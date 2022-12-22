var appkey = '';
$(function () {
    appkey = 'd9fc680b6cafafdace6f875d';
    //Bind Currency code dropdown
    $.get("https://v6.exchangerate-api.com/v6/" + appkey + "/codes", {}, function (data) {
        var row = "";
        $.each(data.supported_codes, function (i, v) {
            row += "<option value='" + v[0] + "'>" + v[0] + '-' + v[1] + "</option>";
        });
        $("#ddlfrom").append(row);
        $("#ddlTo").append(row);
        $("#ddlfrom").val('USD');
        $("#ddlTo").val('EUR');
        calculate();
    }).fail(function (d) {
        alert("Error while calling API");
        console.log(d.responseText);
    });
});
//calculate currency conversion
function calculate() {
    $.get("https://v6.exchangerate-api.com/v6/" + appkey + "/pair/" + $("#ddlfrom").val() + "/" + $("#ddlTo").val() + "/" + Number($("#txtamount").val()) + "", {}, function (data) {
        $("#txtoutput").val(data.conversion_result);
    }).fail(function (d) {
        alert("Error while calling API");
        console.log(d.responseText);
    });
}