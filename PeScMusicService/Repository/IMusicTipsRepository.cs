using System.Collections.Generic;

namespace PeScMusicService.Repository
{
  public interface IMusicTipsRepository
  {
    int Save();

    void Insert(Tips tips);

    void Update(Tips tips);

    Tips GetById(int id);

    List<Tips> GetbyArtistId(string id);

    void Delete(Tips tips);
  }
}