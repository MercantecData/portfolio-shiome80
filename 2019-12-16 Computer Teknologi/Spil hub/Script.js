// JavaScript source code
function SendMessage()
{
    var x = document.getElementById("message").value;
    var user = document.getElementById("user").value;

    if (user == "" || user == null)
    {
        var input = '<p class="chat-message">' + 'Unnamed user:' + '<br>' + x + '<p/>';
    }
    else
    {
        var input = '<p class="chat-message">' + user + ':' + '<br>' + x + '</p>';
    }

    document.getElementById("chat-message").insertAdjacentHTML('beforeend', input);
    document.getElementById("message").value = "";
}
