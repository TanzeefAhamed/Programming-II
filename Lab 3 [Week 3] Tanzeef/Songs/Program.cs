namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Song("Baby", "Justin Bieber", 3.35, SongGenre.Pop));

            Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));

            Library.LoadSongs("Week_03_lab_09_songs4.txt"); 
            Console.WriteLine("\n\nAll songs");
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine($"\n\n{genre} songs");
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine($"\n\nSongs by {artist}");
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine($"\n\nSongs more than {length}mins");
            Library.DisplaySongs(length);
            Console.ReadKey();
        }
    }

    [Flags]
    public enum SongGenre
    {
        Unclassified = 0,
        Pop = 0b1,
        Rock = 0b10,
        Blues = 0b100,
        Country = 0b1_000,
        Metal = 0b10_000,
        Soul = 0b100_000
    }

    public class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length { get; }
        public SongGenre Genre { get; }

        public Song(string title, string artist, double length, SongGenre genre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist} ({Genre}) {Length}min";
        }
    }

    public static class Library
    {
        private static List<Song> songs = new List<Song>();

        public static void LoadSongs(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string title = reader.ReadLine();
                while (title != null)
                {
                    string artist = reader.ReadLine();
                    double length = Convert.ToDouble(reader.ReadLine());

                    string genreString = reader.ReadLine();

                    SongGenre genre = SongGenre.Unclassified;
                    if (genreString == "Pop")
                    {
                        genre = SongGenre.Pop;
                    }
                    else if (genreString == "Rock")
                    {
                        genre = SongGenre.Rock;
                    }
                    else if (genreString == "Blues")
                    {
                        genre = SongGenre.Blues;
                    }
                    else if (genreString == "Country")
                    {
                        genre = SongGenre.Country;
                    }
                    else if (genreString == "Metal")
                    {
                        genre = SongGenre.Metal;
                    }
                    else if (genreString == "Soul")
                    {
                        genre = SongGenre.Soul;
                    }

                    Song song = new Song(title, artist, length, genre);
                    songs.Add(song);

                    title = reader.ReadLine();
                }
            }
        }

        public static void DisplaySongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song);
            }
        }

        public static void DisplaySongs(double longerThan)
        {
            foreach (Song song in songs)
            {
                if (song.Length > longerThan)
                {
                    Console.WriteLine(song);
                }
            }
        }

        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song song in songs)
            {
                if ((song.Genre & genre) == genre)
                {
                    Console.WriteLine(song);
                }
            }
        }

        public static void DisplaySongs(string artist)
        {
            foreach (Song song in songs)
            {
                if (song.Artist == artist)
                {
                    Console.WriteLine(song);
                }
            }
        }
    }
}