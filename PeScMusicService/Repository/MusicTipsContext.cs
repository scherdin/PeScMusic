using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PeScMusicService.Repository
{
  public class MusicTipsContext : DbContext
  {
    public MusicTipsContext(DbContextOptions<MusicTipsContext> options): base(options)
    {
      
    }

    public DbSet<Tips> Tips { get; set; }
  }
}
