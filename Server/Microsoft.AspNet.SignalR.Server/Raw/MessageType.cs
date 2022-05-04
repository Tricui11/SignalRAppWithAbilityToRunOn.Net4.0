namespace Microsoft.AspNet.SignalR.Samples.Raw
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
    }
}