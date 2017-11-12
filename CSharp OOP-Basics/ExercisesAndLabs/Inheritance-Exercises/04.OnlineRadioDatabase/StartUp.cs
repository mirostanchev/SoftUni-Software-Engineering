namespace _04.OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                var songInfo = Console.ReadLine().Split(';');
                var artistName = songInfo[0];
                var songName = songInfo[1];
                var durationTokens = songInfo[2].Split(':');

                try
                {
                    int res;

                    if (!int.TryParse(durationTokens[0], out res) || !int.TryParse(durationTokens[1], out res))
                    {
                        throw new InvalidSongLengthException();
                    }
                    var minutes = int.Parse(durationTokens[0]);
                    var seconds = int.Parse(durationTokens[1]);

                    var song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");
            var totalSeconds = 0;

            foreach (var song in songs)
            {
                totalSeconds += (song.Minutes * 60) + song.Seconds;
            }

            Console.WriteLine($"Playlist length: {totalSeconds / 3600}h {(totalSeconds / 60) % 60}m {totalSeconds % 60}s");
        }
    }
}