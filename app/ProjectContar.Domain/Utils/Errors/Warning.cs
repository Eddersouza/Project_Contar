using ProjectContar.Domain.Utils.Interfaces.Errors;

namespace ProjectContar.Domain.Utils.Errors
{
    public class Warning : ILevel
    {
        public Warning(string description = "Warning")
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