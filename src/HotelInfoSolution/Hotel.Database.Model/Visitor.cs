﻿using System;
using System.Collections.Generic;

namespace Hotel.Database.Model
{
    public class Visitor : IdentityBase
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}