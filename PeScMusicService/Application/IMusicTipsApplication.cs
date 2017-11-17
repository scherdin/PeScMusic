using System.Collections.Generic;

namespace PeScMusicService.Application
{
  public interface IMusicTipsApplication
  {
    int Save(Tips tips);
    Tips GetById(int id);
    List<Tips> GetByArtistId(string id);
    void Delete(int id);
  }
}