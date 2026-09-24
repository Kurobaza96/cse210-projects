using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "Fun Academy",
            720);

        Video video2 = new Video(
            "How to cook rice perfectly",
            "Cooking with Chef Mani",
            945);

        Video video3 = new Video(
            "Revengers: The Final Battle - Movie Review",
            "Kurobaza",
            630);

        Video video4 = new Video(
            "I'm in love with myself",
            "New song by Noir",
            840);

        // Add comments to Video 1
        video1.AddComment(new Comment(
            "Carlos",
            "This was a very helpful introduction!"));

        video1.AddComment(new Comment(
            "Maria",
            "Now I understand the basics"));

        video1.AddComment(new Comment(
            "John",
            "Great explanation and easy to follow."));

        // Add comments to Video 2
        video2.AddComment(new Comment(
            "John",
            "I never knew there were so many ways to cook rice!"));

        video2.AddComment(new Comment(
            "David",
            "I tried this and it worked perfectly!"));

        video2.AddComment(new Comment(
            "Sofia",
            "I think I missed a step, now my rice is a bit sticky."));

        video2.AddComment(new Comment(
            "Luke",
            "Excellent tutorial!"));

        // Add comments to Video 3
        video3.AddComment(new Comment(
            "Luois",
            "I loved the plot twists."));

        video3.AddComment(new Comment(
            "Emma",
            "I want to watch this movie now!"));

        video3.AddComment(new Comment(
            "Mike",
            "When is the next review coming out?"));

        // Add comments to Video 4
        video4.AddComment(new Comment(
            "Elize",
            "This song is so catchy!"));

        video4.AddComment(new Comment(
            "Bob",
            "The lyrics seem familiar!"));

        video4.AddComment(new Comment(
            "Jessie",
            "I can't stop listening to this song!"));

        video4.AddComment(new Comment(
            "Tommy",
            "The music video is amazing!"));

        // Put all videos into a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}