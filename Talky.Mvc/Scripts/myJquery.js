$(function () {
    /*Sayfa yüklendikten sonra çalışacak komutlar*/
    HomePage();
    ServerPage();
    ChannelPage();
});
function HomePage() {
    ServerGetAll();
}
function ServerPage() {
    if (window.location.pathname.toLowerCase().includes("server/index")) {
        var serverID = window.location.href.split('/').pop();
        ChannelGetAll(serverID);
    }
}
function ChannelPage() {
    if (window.location.pathname.toLowerCase().includes("channel/index")) {
        var curr = $("#current");
        var id = curr.data("serverid");
        ChannelGetAll(id);
    }
}
function ServerGetAll() {
    $.get("/Server/List", function (data) {
        console.log("Server'lar çekildi.");
        $("#ServerGetAll").html(data);
    });
}
function ChannelGetAll(id) {
    $.get("/Channel/List/" + id, function (data) {
        console.log("Channel'lar çekildi.");
        $("#ChannelGetAll").html(data);
    });
}