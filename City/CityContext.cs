﻿using System.Data.Entity;

namespace Cities
{
    public class CityContext : DbContext
    {
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
    }
}
