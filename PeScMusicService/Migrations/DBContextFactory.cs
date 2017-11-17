using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PeScMusicService.Repository;

namespace PeScMusicService.Migrations
{
  //public class DbContextFactory : IDesignTimeDbContextFactory<MusicTipsContext>
  //{
  //  public MusicTipsContext CreateDbContext(string[] args)
  //  {
  //    IConfigurationRoot configuration = new ConfigurationBuilder()
  //      .SetBasePath(Directory.GetCurrentDirectory())
  //      .AddJsonFile("appsettings.json")
  //      .Build();

  //    var builder = new DbContextOptionsBuilder<MusicTipsContext>();
  //    var connectionString = configuration["ConnectionStrings:DefaultConnection"];
  //    builder.UseSqlServer(connectionString);
  //    return new MusicTipsContext(builder.Options);
  //  }
  //}
}
