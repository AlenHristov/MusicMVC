﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicMVC.Models;

namespace MusicMVC.Data
{
    public class MusicMVCContext : DbContext
    {
        public MusicMVCContext (DbContextOptions<MusicMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MusicMVC.Models.Song> Song { get; set; }
    }
}
