using ProjectContar.Domain.Utils.Interfaces.Errors;

namespace ProjectContar.Domain.Utils.Errors
{
    public class Critical : ILevel
    {
        public Critical(string description = "Critical")
        {
            Description = description;
        }

        public string Description { get; }

        public override string ToString()
        {
            return Description;
        }
    }
}