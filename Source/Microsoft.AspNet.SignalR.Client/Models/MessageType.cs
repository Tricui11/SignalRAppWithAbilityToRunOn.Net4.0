namespace Microsoft.AspNet.SignalR.Client.Models
{
    public enum MessageType
    {
        Send,
        Broadcast,
        Join,
        PrivateMessage,
        AddToGroup,
        RemoveFromGroup,
        SendToGroup,
        BroadcastExceptMe,
        DisconnectUser
    }
}
