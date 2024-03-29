﻿using Models.Entities.Base;

namespace Models.Entities
{
    public class Clinic : EntityBase
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string OpeningHours { get; set; }

        public int SpecialistsCount { get; set; }
    }
}
