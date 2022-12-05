using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Item;

namespace Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;

public abstract class NotifiableContainerBase<TNotificationItemAbstraction> : INotifiableContainer<TNotificationItemAbstraction> 
    where TNotificationItemAbstraction : INotificationItem
{
    protected List<TNotificationItemAbstraction> _notification;

    protected NotifiableContainerBase()
    {
        _notification = new List<TNotificationItemAbstraction>();
    }

    public virtual void AddNotification(TNotificationItemAbstraction item)
    {
        _notification.Add(item);
    }

    public virtual void AddNotifications(List<TNotificationItemAbstraction> items)
    {
        _notification.AddRange(items);
    }

    public virtual List<TNotificationItemAbstraction> GetNotifications()
    {
        return _notification;
    }
}
