using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Item;

namespace Olizia.Libraries.DesignPatterns.Notification.Abstractions.Consumer;

public interface INotificationConsumer<TNotificationItemAbstraction>
    where TNotificationItemAbstraction : INotificationItem
{
    public List<TNotificationItemAbstraction> GetNotifications();
}
