"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("http://localhost:5000/websocket").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {

    message = "<li>" + new Date().getHours() + " : " + new Date().getMinutes() + " : " + new Date().getSeconds() + "  " + user + ": " + message + "</li>";
    message = message.replace(/:\)/g, "<img src='/img/icon_smile.png' style='height: 30px;' />");
    message = message.replace(/:\@/g, "<img src='/img/AngrySmile.png' style='height: 30px;' />");
    message = message.replace(/:b/g, "<img src='/img/BirthdaySmile.png' style='height: 30px;' />");
    message = message.replace(/:c/g, "<img src='/img/LipSmile.png' style='height: 30px;' />");
    message = message.replace(/:d/g, "<img src='/img/BigSmile.png' style='height: 30px;' />");
    message = message.replace(/:e/g, "<img src='/img/BlueEyesSmile.png' style='height: 30px;' />");
    message = message.replace(/:f/g, "<img src='/img/FloversSmile.png' style='height: 30px;' />");
    message = message.replace(/<3/g, "<img src='/img/LoveSmile.png' style='height: 30px;' />");
    message = message.replace(/:h/g, "<img src='/img/HappySmile.png' style='height: 30px;' />");
    message = message.replace(/:v/g, "<img src='/img/VictorySmile.png' style='height: 30px;' />");

    document.getElementById("messagesList").innerHTML = 
        document.getElementById("messagesList").innerHTML + message;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message);
    event.preventDefault();
});