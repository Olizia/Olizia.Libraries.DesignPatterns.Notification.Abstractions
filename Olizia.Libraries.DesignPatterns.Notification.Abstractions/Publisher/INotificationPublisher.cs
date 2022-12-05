using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Item;

namespace Olizia.Libraries.DesignPatterns.Notification.Abstractions.Publisher;

public interface INotificationPublisher<TNotificationItemAbstraction>
    where TNotificationItemAbstraction : INotificationItem
{
    public void AddNotification(TNotificationItemAbstraction notification);
    public void AddNotifications(List<TNotificationItemAbstraction> notifications);
}
