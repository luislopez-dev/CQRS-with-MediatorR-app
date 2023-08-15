using app.Data;
using app.Notifications;
using MediatR;

namespace app.Handlers;

public class EmailHandler : INotificationHandler<ProductAddedNotification>
{
    private readonly FakeDataStore _fakeDataStore;

    public EmailHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
    {
        await _fakeDataStore.EventOcurred(notification.Product, "Email Sent");
        await Task.CompletedTask;
    }
}