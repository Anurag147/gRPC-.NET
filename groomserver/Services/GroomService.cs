using Grpc.Core;
using gRoom.gRPC.Messages;
using Google.Protobuf.WellKnownTypes;
using gRoom.gRPC.Utils;

namespace gRoom.gRPC.Services;

public class GroomService : Groom.GroomBase
{
    private readonly ILogger<GroomService> _logger;
    public GroomService(ILogger<GroomService> logger)
    {
        _logger = logger;
    }

    public override Task<RoomRegistrationResponse> RegisterToRoom(RoomRegistrationRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Service called...");
        var rnd = new Random();
        var roomNum = rnd.Next(1, 100);
        _logger.LogInformation($"Room no. {roomNum}");
        var resp = new RoomRegistrationResponse { RoomId = roomNum };
        return Task.FromResult(resp);
    }

    public override async Task<NewsStreamStatus> SendNewsFlash(IAsyncStreamReader<NewsFlash> newsStream, ServerCallContext context)
    {
        while (await newsStream.MoveNext())
        {
            var news = newsStream.Current;
            MessagesQueue.AddNewsToQueue(news);
            Console.WriteLine(news.NewsItem);
        }

        return new NewsStreamStatus { Success = true };
    }

    public override async Task StartMonitoring(Empty request,
                                               IServerStreamWriter<RecievedMessage> writer,
                                               ServerCallContext context)
    {
        while (true)
        {
            //await writer.WriteAsync(new RecievedMessage { NewsTime = Timestamp.FromDateTime(DateTime.UtcNow), User = "1", Contents = "Test" });
            if (MessagesQueue.GetMessagesCount() > 0)
            {
                await writer.WriteAsync(MessagesQueue.GetNextMessage());
            }
            await Task.Delay(1000);

        }
    }
}
