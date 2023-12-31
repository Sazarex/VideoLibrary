﻿using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class User : INamedEntity, IDateInfo, IEntityState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public EntityState? EntityState { get; set; }
        public int? Age { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public DateTime? UpdateDate { get ; set ; }
    }
}
