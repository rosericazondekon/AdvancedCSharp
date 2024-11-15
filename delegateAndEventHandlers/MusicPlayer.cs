using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public delegate void SongEventHandler(string songTitle);
public delegate void SkipSongEventHandler(string currentSongTitle, string nextSongTitle);

public class MusicPlayer
{
    public void play(string  songTitle){
        Console.WriteLine($"Playing song {songTitle}...");
        SongPlayed?.Invoke(songTitle);
    }
    public void stop(string songTitle){
        Console.WriteLine($"Stopped song: {songTitle}!");
        SongStopped?.Invoke(songTitle);
    }
    public void pause(string songTitle){
        Console.WriteLine($"Paused song: {songTitle}!");
        SongPaused?.Invoke(songTitle);
    }
    public void skip(string currentSongTitle, string nextSongTitle){
        Console.WriteLine($"Skipped from: {currentSongTitle} to: {nextSongTitle}");
        SongSkipped?.Invoke(currentSongTitle, nextSongTitle);
    }
    public event SongEventHandler? SongPlayed;
    public event SongEventHandler? SongStopped;
    public event SongEventHandler? SongPaused;
    public event SkipSongEventHandler? SongSkipped;

}