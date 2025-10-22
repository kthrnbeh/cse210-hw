using System;
using System.Collections.Generic;
using YouTubeVideos;
public class Program
{ //Abstraction Part 1
    public static void Main(string[] args)
    {
        // TODO: Create a list to hold multiple Video objects.
        // TODO: Create 3–4 Video objects, each with unique title, author, and length.
        List<Video> videos = new List<Video>();
        videos.Add(new Video("He'll be there", "Connor Austin", 144.60));
        videos.Add(new Video("It's not Hopeless", "Strive to be", 214.80));
        videos.Add(new Video("Serve the Lord", "Strive to be", 207.60));
        //add them from my video playlist
        // TODO: For each video, add 3–4 Comment objects (name + text).//no we already have a list in comments... 
        Comment comment1 = new Comment("@JabsMorjis", "Connor is aggressively sure about what he's saying. Absolutely love the tone of this song");
        Comment comment2 = new Comment("@WitVerdico", "Cool! I wish the youth leaders would share the youth music more often to the youth");
        Comment comment3 = new Comment("@KatherineMagistri", "I Love this music, it brings the spirit.");
        // TODO: Add each video to the main video list.
        videos[0].AddComment(comment1);
        videos[1].AddComment(comment2);
        videos[2].AddComment(comment3);
        // TODO: Loop through the list and call the display method for each video to show details and comments.
        foreach(Video video in videos)
        {//TODO:Display all the Comments for each video
            video.DisplayVideoDetails();
        }
    }
}
