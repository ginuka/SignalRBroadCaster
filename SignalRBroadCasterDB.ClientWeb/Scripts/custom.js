$(function () {

    var connection = $.connection('http://localhost:59389/signalr/hubs');

    connection.start(function () {
        console.log("connection started!");
    });

    //var chat = $.connection.servicestatushub;
    //$.connection.hub.start().done(function () {
    //    console.log('strat');
    //});
    //chat.client.GetStatus = function (data) {
    //    $('#discussion').append('Message' + data + '<br />');
    //};
});