﻿using Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class Doctor : EntityBase
    {
        public string Name { get; set; }

        public string Specialization { get; set; }

        public int Rating { get; set; }

        public int Price { get; set; }

        public string Location { get; set; }

        public Clinic Clinic { get; set; }
    }
}
