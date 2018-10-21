"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    if (msg == "DueDate") {
        $("")
    }
    
    //Show the div
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});


document.getElementById("btnDueDate").addEventListener("click", function (event) {
    connection.invoke("SendMessage", "DueDate").catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});



document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});