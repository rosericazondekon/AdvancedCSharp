using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Subscriber
{
    public string Name { get; set; }
    public Subscriber(string name){
        Name = name;
    }
    public void SongPlayedHandler(string songTitle)
    {
        Console.WriteLine($"{Name} is now enjoying: {songTitle}");
    }

    public void SongPausedHandler(string songTitle)
    {
        Console.WriteLine($"{Name} paused: {songTitle}");
    }

    public void SongStoppedHandler(string songTitle)
    {
        Console.WriteLine($"{Name} stopped: {songTitle}");
    }

    public void SongSkippedHandler(string currentSongTitle, string nextSongTitle)
    {
        Console.WriteLine($"{Name} skipped from {currentSongTitle} to: {nextSongTitle}");
    }
}