class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Video Title 1", "Author 1", 120);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Loved this!"));
        videos.Add(video1);

        Video video2 = new Video("Video Title 2", "Author 2", 150);
        video2.AddComment(new Comment("User3", "Interesting content"));
        video2.AddComment(new Comment("User4", "Not good"));
        videos.Add(video2);

        Video video3 = new Video("Video Title 3", "Author 3", 100);
        video3.AddComment(new Comment("User4", "Very good"));
        videos.Add(video3);




        foreach (var video in videos)
        {
            // Add parentheses to method calls
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            foreach (var comment in video.GetComments())
            {
                // Access the properties instead of calling methods
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}