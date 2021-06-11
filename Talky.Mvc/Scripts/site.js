window.onload = pageLoad;

function pageLoad() {
	MessageScroll();
}
function MessageScroll() {
	var elmnt = document.getElementById("message-area");
	elmnt.scrollTop = elmnt.scrollHeight;
}