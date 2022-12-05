using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Item;

namespace Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;

public interface INotifiableContainer<TNotificationItemAbstraction> 
    where TNotificationItemAbstraction : INotificationItem
{
    public void AddNotification(TNotificationItemAbstraction item);
    public void AddNotifications(List<TNotificationItemAbstraction> items);
    public List<TNotificationItemAbstraction> GetNotifications();
}
