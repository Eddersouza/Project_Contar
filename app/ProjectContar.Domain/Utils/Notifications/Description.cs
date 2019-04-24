using ProjectContar.Domain.Utils.Interfaces;

namespace ProjectContar.Domain.Utils.Notifications
{
    public abstract class Description : IDescription
    {
        protected Description(string message, params string[] args)
        {
            Message = message;

            for (var i = 0; i < args.Length; i++)
            {
                Message = Message.Replace("{" + i + "}", args[i]);
            }
        }

        public string Message { get; }

        public override string ToString() => Message;
    }
}