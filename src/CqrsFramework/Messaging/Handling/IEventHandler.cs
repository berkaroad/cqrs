namespace CqrsFramework.Messaging.Handling
{
    public interface IEventHandler { }

    public interface IEventHandler<T> : IEventHandler
        where T : IEvent
    {
        void Handle(T @event);
    }

    public interface IEnvelopedEventHandler<T> : IEventHandler
        where T : IEvent
    {
        void Handle(Envelope<T> envelope);
    }
}