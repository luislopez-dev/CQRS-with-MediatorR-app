 /*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description: Training Project
 */
 
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