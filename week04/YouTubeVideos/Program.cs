using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Top 10 Tech Gadgets 2026", "TechReviewerPro", 840);

        video1.AddComment(new Comment("CarlosGamer", "That mechanical keyboard shown at 3:00 looks awesome."));
        video1.AddComment(new Comment("Sofia_Dev", "Does anyone know the brand of the water bottle on the desk?"));
        video1.AddComment(new Comment("TechFanatic", "Great video editing, though the sponsored product placement was a bit long."));
        video1.AddComment(new Comment("Lucia_99", "I bought those headphones because of this review and they're great!"));

        Video video2 = new Video("My Productive Morning Routine", "LauraVlogs", 620);

        video2.AddComment(new Comment("Elena_R", "Loved the minimalist chocolate mug you used at the beginning."));
        video2.AddComment(new Comment("MateoFit", "I recognized that oatmeal brand in the background, they sell it at my local store."));
        video2.AddComment(new Comment("Camila_P", "Great content as always! Your workspace setup is super inspiring."));

        Video video3 = new Video("Desk Setup Tour 2026", "DavidCode", 1050);

        video3.AddComment(new Comment("Andres_IT", "That ergonomic chair looks super comfortable, is it worth it?"));
        video3.AddComment(new Comment("Beatriz_M", "The laptop stand caught my attention, where did you get it?"));
        video3.AddComment(new Comment("Jorge_X", "Super clean setup, love that no cables are visible."));
        video3.AddComment(new Comment("Valeria_Art", "Those monitors are exactly what I was looking for to do design work."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

    }
}