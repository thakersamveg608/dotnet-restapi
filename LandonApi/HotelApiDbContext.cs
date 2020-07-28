﻿using System;
using LandonApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LandonApi
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<RoomEntity> Rooms { get; set; }
    }
}
