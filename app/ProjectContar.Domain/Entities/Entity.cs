using ProjectContar.Domain.Utils.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.Domain.Entities
{
    public class Entity
    {
        public Error Errors { get; } = new Error();

        public virtual void Validate() { }

        protected void Fail(
            bool condition, 
            ErrorDescription description)
        {
            if (condition)
                Errors.Add(description);
        }

        public bool IsValid()
        {
            return !Errors.HasErrors;
        }
        
        protected void IsInvalidName(string s, ErrorDescription error)
        {
            Fail(string.IsNullOrWhiteSpace(s), error);
        }        
    }
}
