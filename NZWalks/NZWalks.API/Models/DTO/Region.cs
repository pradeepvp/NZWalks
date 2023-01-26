﻿using NZWalks.API.Models.Domain;

namespace NZWalks.API.Models.DTO
{
    public class Region
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public Double Area { get; set; }

        public Double Lat { get; set; }

        public Double Long { get; set; }

        public long Population { get; set; }
      
    }
}
