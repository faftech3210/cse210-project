using System;
using System.Collections.Generic;
namespace YouTubeVideoTracking{
    class Program
    {
        static void Main(string[] args)
        {
         Video video1 = new Video("Tech Review 2025", "Alice Smith", 300);
            Video video2 = new Video("Fitness Challenge", "John Doe", 450);
            Video video3 = new Video("Cooking Tutorial", "Chef Jamie", 600);

            video1.AddComment(new Comment("Tom", "Great review!"));
            video1.AddComment(new Comment("Lucy", "Very informative, thanks!"));
            video1.AddComment(new Comment("Mike", "Could you cover more gadgets next time?"));

            video2.AddComment(new Comment("Anna", "Wow, this is motivating!"));
            video2.AddComment(new Comment("Chris", "Can't wait to try this myself!"));
            video2.AddComment(new Comment("Kelly", "Love the energy in this video!"));

            video3.AddComment(new Comment("Emily", "This recipe looks amazing!"));
            video3.AddComment(new Comment("David", "I tried it and it was delicious!"));
            video3.AddComment(new Comment("Sophie", "Chef Jamie is my favorite!"));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (Video video in videos)
            {
                video.DisplayDetails();
            }
        }
    }
}


// I commented this part out so as to put the two class in their separat file
// public class Comment
//     {
//         private string _commenterName;
//         private string _commentText;

//         public Comment(string commenterName, string commentText)
//         {
//             _commenterName = commenterName;
//             _commentText = commentText;
//         }

//         public string GetCommenterName()
//         {
//             return _commenterName;
//         }

//         public string GetCommentText()
//         {
//             return _commentText;
//         }

//         public override string ToString()
//         {
//             return $"{_commenterName}: {_commentText}";
//         }
//     }

//     public class Video
//     {
//         private string _title;
//         private string _author;
//         private int _length; // in seconds
//         private List<Comment> _comments;

//         public Video(string title, string author, int length)
//         {
//             _title = title;
//             _author = author;
//             _length = length;
//             _comments = new List<Comment>();
//         }

//         public string GetTitle()
//         {
//             return _title;
//         }

//         public string GetAuthor()
//         {
//             return _author;
//         }

//         public int GetLength()
//         {
//             return _length;
//         }

//         public void AddComment(Comment comment)
//         {
//             _comments.Add(comment);
//         }

//         public int GetNumberOfComments()
//         {
//             return _comments.Count;
//         }

//         public void DisplayDetails()
//         {
//             Console.WriteLine($"Title: {_title}");
//             Console.WriteLine($"Author: {_author}");
//             Console.WriteLine($"Length: {_length} seconds");
//             Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
//             Console.WriteLine("Comments:");
//             foreach (Comment comment in _comments)
//             {
//                 Console.WriteLine(comment);
//             }
//             Console.WriteLine(new string('-', 40));
//         }
//     }
