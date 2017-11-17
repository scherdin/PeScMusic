using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PeScMusicService.Repository
{
  public class MusicTipsRepository : IMusicTipsRepository
  {
    private readonly MusicTipsContext _context;

    public MusicTipsRepository(MusicTipsContext context)
    {
      _context = context;
    }

    public int Save()
    {
      try
      {
        Tips tips = null;

        if (_context.ChangeTracker.Entries<Tips>().Any(e => e.State == EntityState.Added))
        {
          tips = _context.ChangeTracker.Entries<Tips>().FirstOrDefault(e => e.State == EntityState.Added)?.Entity;
        }

        _context.SaveChanges();
        return tips?.Id ?? 0;
      }
      catch (DbUpdateException ex)
      {
        throw new Exception(ex.Message);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    public void Insert(Tips tips)
    {
      _context.Add(tips);
    }

    public void Update(Tips tips)
    {
      _context.Update(tips);
    }

    public Tips GetById(int id)
    {
      var tips = _context.Tips.AsNoTracking().FirstOrDefault(t => t.Id == id);
      return tips;
    }

    public List<Tips> GetbyArtistId(string id)
    {
      IQueryable<Tips> tipsList = _context.Tips.AsNoTracking().Where(t => t.ArtistId == id);
      return tipsList.ToList();
    }

    public void Delete(Tips tips)
    {
      _context.Tips.Remove(tips);
      _context.SaveChanges();
    }
  }
}