using System;
using System.Collections.Generic;
using PeScMusicService.Repository;

namespace PeScMusicService.Application
{
  public class MusicTipsApplication : IMusicTipsApplication
  {
    private readonly IMusicTipsRepository _repository;

    public MusicTipsApplication(IMusicTipsRepository repository)
    {
      _repository = repository;
    }
    public int Save(Tips tips)
    {
      if (tips.Id > 0)
      {
        var t = _repository.GetById(tips.Id);
        //_t.ArtistId = tips.ArtistId;
        t.Rating = tips.Rating;
        t.Text = tips.Text;

        _repository.Update(t);
      }
      else
      {
        _repository.Insert(tips);
      }
      return _repository.Save();
    }

    public Tips GetById(int id)
    {
      return _repository.GetById(id);
    }


    public List<Tips> GetByArtistId(string id)
    {
      return _repository.GetbyArtistId(id);
    }

    public void Delete(int id)
    {
      var t = _repository.GetById(id);
      if (t == null)
      {
        throw new ApplicationException($"No entry with id '{id}' found");
      }
      _repository.Delete(t);
    }
  }
}
