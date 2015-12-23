﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Database.Model
{
    public class Room : IdentityBase
    {
        [Index("HotelId_Number", 1, IsUnique = true)]
        public string Number { get; set; }
        public string Description { get; set; }
        public int PlaceCount { get; set; }
        public double CostPerDay { get; set; }
        public RoomState State { get; set; }
        [Index("HotelId_Number", 2, IsUnique = true)]
        public long HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}