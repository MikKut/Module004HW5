using Module004HW5.Context;
using Module004HW5.Repositories;

namespace Module004HW5.Starters
{
    public static class Starter
    {
        public static void Run()
        {
            Repository repository = new ();
            repository.GetNumberOfSongsInEachGenre();
            repository.GetSongsThatHaveGenreAndExistingArtist();
            repository.GetSongTitleArtistNameGenreName();
            repository.GetSongsThatWereWrittenBeforeYoungestPerformerWasBorn();
        }
    }
}
