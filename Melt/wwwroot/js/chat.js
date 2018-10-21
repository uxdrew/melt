
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    //var encodedMsg = user + " says " + msg;
    //var li = document.createElement("li");
    //li.textContent = encodedMsg;
    //document.getElementById("messagesList").appendChild(li);
    alert(msg);
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});

$(document).ready(function () {
    document.getElementById("btnDueDate").addEventListener("click", function (event) {
        //alert("Get this");
        connection.invoke("SendMessage", "DueDate").catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });
});