using app.Entities;
using MediatR;

namespace app.Notifications;

public record ProductAddedNotification(Product Product): INotification;