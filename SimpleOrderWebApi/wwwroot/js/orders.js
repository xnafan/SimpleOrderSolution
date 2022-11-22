"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/OrdersNotifier").build();

//HOOK UP SIGNALS FROM SERVER TO LOCAL METHODS:  ////////////////////////
//updates UI after votes from any client
connection.on("receiveOrders", updateOrders);

let beingPreparedCell = document.querySelector("td.being-prepared");
let readyForPickupCell = document.querySelector("td.ready-for-pickup");

//retrieve current poll status from server when connection is up
connection.start().then(function () {
    askForOrders();
}).catch(function (err) {
    return console.error(err.toString());
});

function askForOrders() {
    connection.invoke("GetUnfinishedOrders").catch(function (err) {
        console.error("Error asking for unfinished orders: " + err.toString());
    });
}

function updateOrders(orders) {
    if (!Array.isArray(orders)) alert("not an array:" + orders);
    clearBothOrderCells();
    for (let i = 0; i < orders.length; i++) {
        let currentOrder = orders[i];
        addOrder(currentOrder.state == "BeingPrepared" ? beingPreparedCell : readyForPickupCell, currentOrder);
    }
}

function clearBothOrderCells() {
    while (beingPreparedCell.firstChild) {
        beingPreparedCell.removeChild(beingPreparedCell.firstChild);
    }
    while (readyForPickupCell.firstChild) {
        readyForPickupCell.removeChild(readyForPickupCell.firstChild);
    }
}
function pulseElement(element) {

    element.style.animation = '';
    void element.offsetWidth;       //important HACK to make the restart of animation work
    element.style.animation = "pulse .2s 1";
}

function addOrder(cell, order) {
    let newOrderDiv = document.createElement("div");
    newOrderDiv.innerText = order.orderNumber;
    newOrderDiv.className = "order";
    cell.appendChild(newOrderDiv);
}