﻿using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class Movie : INamedEntity, IDateInfo, IEntityState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public EntityState EntityState { get; set; }
        public int AgeLimit { get; set; }
        public string Description { get; set; }
        public Genre Genre { get;set; }
        public Producer Producer { get; set; }


        public int GenreId { get; set; }
        public int ProducerId { get; set; }

    }
}