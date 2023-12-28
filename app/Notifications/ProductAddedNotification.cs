 /*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description: Training Project
 */
 
using app.Entities;
using MediatR;

namespace app.Notifications;

public record ProductAddedNotification(Product Product): INotification;