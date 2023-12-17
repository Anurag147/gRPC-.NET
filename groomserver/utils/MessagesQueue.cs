using gRoom.gRPC.Messages;
using Google.Protobuf.WellKnownTypes;

namespace gRoom.gRPC.Utils;

public class MessagesQueue
{
    private static Queue<RecievedMessage> _queue;

    static MessagesQueue()
    {
        _queue = new Queue<RecievedMessage>();
    }

    public static void AddNewsToQueue(NewsFlash news)
    {
        var msg = new RecievedMessage();
        msg.Contents = news.NewsItem;
        msg.User = "NewsBot";
        msg.NewsTime = Timestamp.FromDateTime(DateTime.UtcNow);
        _queue.Enqueue(msg);
    }

    public static RecievedMessage GetNextMessage()
    {
        return _queue.Dequeue();
    }

    public static int GetMessagesCount()
    {
        return _queue.Count;
    }
}