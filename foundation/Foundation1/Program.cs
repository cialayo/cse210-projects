using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Console.WriteLine("Video Program");
        Console.WriteLine("************************************");

        Video firstVideo = new Video("video1", "author1", 10);
        firstVideo.AddComment(new Comment("commentAuthor1", "textComment1"));
        firstVideo.AddComment(new Comment("commentAuthor2", "textComment2"));
        firstVideo.AddComment(new Comment("commentAuthor3", "textComment3"));
        firstVideo.AddComment(new Comment("commentAuthor4", "textComment4"));
        videoList.Add(firstVideo);

        Video secondVideo = new Video("video2", "author2", 20);
        secondVideo.AddComment(new Comment("commentAuthorA", "textCommentA"));
        secondVideo.AddComment(new Comment("commentAuthorB", "textCommentB"));
        secondVideo.AddComment(new Comment("commentAuthorC", "textCommentC"));
        secondVideo.AddComment(new Comment("commentAuthorD", "textCommentD"));
        videoList.Add(secondVideo);

        Video thirdVideo = new Video("video3", "author3", 30);
        thirdVideo.AddComment(new Comment("commentAuthorE", "textCommentE"));
        thirdVideo.AddComment(new Comment("commentAuthorF", "textCommentF"));
        thirdVideo.AddComment(new Comment("commentAuthorG", "textCommentG"));
        videoList.Add(thirdVideo);

        foreach (Video video in videoList)
        {
            string videoDisplayed = video.GetDisplayVideo();
            Console.WriteLine(videoDisplayed);
            Console.WriteLine("Video Comments:");
            string commentsDisplayed = video.GetDisplayComments();
            Console.WriteLine(commentsDisplayed);
            Console.WriteLine("************************************");
        }

    }
}