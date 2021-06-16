$(function () {
    /*Sayfa yüklendikten sonra çalışacak komutlar*/
    ServerGetAll(null);
    if (window.location.pathname.toLowerCase().includes("server/index")) {
        ServerPage();
    } else if (window.location.pathname.toLowerCase().includes("channel/index")) {
        ChannelPage();
    }

});
function ServerPage() {
    var serverID = window.location.href.split('/').pop();
    ChannelGetAll(serverID);
}
function ChannelPage() {
    var channelID = window.location.href.split('/').pop();
    var curr = $("#current");
    var serverid = curr.data("serverid");
    ChannelGetAll(serverid);
    MessageGetAll(channelID);
}
function ServerGetAll(id) {
    $.get("/Server/List", function (data) {
        console.log("Server'lar çekildi.");
        $("#ServerGetAll").html(data);
        $("#server-" + id).addClass("active");
    });
}
function ChannelGetAll(id) {
    $.get("/Channel/List/" + id, function (data) {
        console.log("Channel'lar çekildi.");
        $("#ChannelGetAll").html(data);
        ServerGetAll(id);//Active
    });
}
function MessageGetAll(id) {
    $.get("/Message/List/" + id, function (data) {
        console.log("Message'lar çekildi.");
        $("#MessageGetAll").html(data);
    });
}
function Message(id) {
    var channelID = window.location.href.split('/').pop();
    $.ajax({
        method: 'POST',
        url: '../../Message/Send',
        data: $("#msg").serialize()
    });
    location.reload();
    MessageGetAll(channelID);
}