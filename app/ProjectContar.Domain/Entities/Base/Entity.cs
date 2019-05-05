using edrsys.EventNotification.Entities;
using System;

namespace ProjectContar.Domain.Entities.Base
{
    /// <summary>
    /// Represent the common data of entity.
    /// </summary>
    public abstract class Entity : EventNotificationEntity
    {
        /// <summary>
        /// Date of Entity Create.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date of Entity last modify.
        /// </summary>
        public DateTime ModifiedDate { get; set; }        
    }
}