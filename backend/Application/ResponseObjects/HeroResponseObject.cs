﻿using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.ResponseObjects
{
    public class HeroResponseObject
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public string HeroName { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public virtual List<SuperPowerEntity> SuperPowers { get; set; }
    }
}
