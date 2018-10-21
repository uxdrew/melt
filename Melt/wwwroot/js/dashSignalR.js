var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
connection.on("ReceiveMessage", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");

    alert(msg);
    $("#imgTrophy1").addClass("original");
    $("#imgTrophy2").addClass("original");
    $("#imgTrophy3").removeClass("original");
    $("#imgTrophy4").removeClass("grayscale");
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});

$(document).ready(function () {
    $("#btnUpdateMM").on("click", function () {
        var output = $("#slider_value").text();
        var url = window.location.href;
        window.location.replace(url.substring(0, url.indexOf("?")) + "?percent=" + output);


    });
});