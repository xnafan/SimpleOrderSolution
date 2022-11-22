"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/OrdersNotifier").build();

//HOOK UP SIGNALS FROM SERVER TO LOCAL METHODS:  ////////////////////////
//updates UI after votes from any client
connection.on("receiveOrders", updateOrders);

//retrieve current poll status from server when connection is up
connection.start().then(function () {
    updateOrders();
}).catch(function (err) {
    return console.error(err.toString());
});


function updateOrders(orders) {
    alert("orders updated");
}

function pulseElement(element) {

    element.style.animation = '';
    void element.offsetWidth;       //important HACK to make the restart of animation work
    element.style.animation = "pulse .2s 1";
}