namespace ProjectContar.Domain.Utils.Interfaces
{
    public interface EventNotificationDescriptionBaseContract
    {
        string Message { get; }

        string ToString();
    }
}