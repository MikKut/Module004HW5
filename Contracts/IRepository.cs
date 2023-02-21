namespace Module004HW5.Contracts
{
    public interface IRepository
    {
        void GetSongTitleArtistNameGenreName();
        void GetSongsThatHaveGenreAndExistingArtist();
        void GetNumberOfSongsInEachGenre();
        void GetSongsThatWereWrittenBeforeYoungestPerformerWasBorn();
    }
}
