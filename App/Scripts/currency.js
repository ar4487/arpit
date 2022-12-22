var appkey = '';
$(function () {
    appkey = 'P7LIbl4R2c9GpESNGCRdGUXHv6RrVL0k';
    //Bind Currency code dropdown
    var client = new RestClient("https://api.apilayer.com/exchangerates_data/convert?to=GBP&from=EUR&amount=5");
    client.Timeout = -1;

    var request = new RestRequest(Method.GET);
    request.AddHeader("apikey", "P7LIbl4R2c9GpESNGCRdGUXHv6RrVL0k");

    IRestResponse response = client.Execute(request);
    Console.WriteLine(response.Content);
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
    $.get("https://api.apilayer.com/exchangerates_data/live?base=USD&symbols=EUR,GBP/" + appkey + "/pair/" + $("#ddlfrom").val() + "/" + $("#ddlTo").val() + "/" + Number($("#txtamount").val()) + "", {}, function (data) {
        $("#txtoutput").val(data.conversion_result);
    }).fail(function (d) {
        alert("Error while calling API");
        console.log(d.responseText);
    });
}