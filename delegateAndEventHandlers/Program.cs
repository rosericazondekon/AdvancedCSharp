// using Player;

MusicPlayer musicPlayer = new MusicPlayer();
Subscriber subscriber1 = new Subscriber("SubUser1");
Subscriber subscriber2 = new Subscriber("SubUser2");

musicPlayer.SongPlayed += subscriber1.SongPlayedHandler;
musicPlayer.SongPlayed += subscriber2.SongPlayedHandler;
musicPlayer.SongPaused += subscriber1.SongPausedHandler;
musicPlayer.SongPaused += subscriber2.SongPausedHandler;
musicPlayer.SongSkipped += subscriber1.SongSkippedHandler;
musicPlayer.SongSkipped += subscriber2.SongSkippedHandler;
musicPlayer.SongStopped += subscriber1.SongStoppedHandler;
musicPlayer.SongStopped += subscriber2.SongStoppedHandler;

while(true){
    Console.WriteLine("\nEnter the action (play, pause, stop, skip) or 'exit' to end:");
    string action = Console.ReadLine().ToLower();

    if(action == "exit") break;

    Console.WriteLine("Enter the song title:");
    string songTitle = Console.ReadLine();

    switch(action){
        case "play":
            musicPlayer.play(songTitle);
            break;
        case "pause":
            musicPlayer.pause(songTitle);
            break;
        case "stop":
            musicPlayer.stop(songTitle);
            break;
        case "skip":
            Console.WriteLine("Enter the next song title:");
            string nextSongTitle = Console.ReadLine();
            musicPlayer.skip(songTitle, nextSongTitle);
            break;
        default:
            Console.WriteLine("Invalid action. Please enter play, pause, stop, skip, or exit.");
            break;

    }
}