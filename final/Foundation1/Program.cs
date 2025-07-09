using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> listOfVideos = new List<Video>();

        Video v1 = new Video("Video Title 1", "Author 1", 30);
        Comment c1 = new Comment();
        c1.SetCommentorsName("Commentor name 1 for v1");
        c1.SetCommentorsText("Commentor text 1 for v1");
        v1._comments.Add(c1);
        Comment c2 = new Comment();
        c2.SetCommentorsName("Commentor name 2 for v1");
        c2.SetCommentorsText("Commentor text 2 for v1");
        v1._comments.Add(c2);
        Comment c3 = new Comment();
        c3.SetCommentorsName("Commentor name 3 for v1");
        c3.SetCommentorsText("Commentor text 3 for v1");
        v1._comments.Add(c3);

        Video v2 = new Video("Video Title 2", "Author 2", 60);
        Comment c4 = new Comment();
        c4.SetCommentorsName("Commentor name 4 for v2");
        c4.SetCommentorsText("Commentor text 4 for v2");
        v2._comments.Add(c4);
        Comment c5 = new Comment();
        c5.SetCommentorsName("Commentor name 5 for v2");
        c5.SetCommentorsText("Commentor text 5 for v2");
        v2._comments.Add(c5);
        Comment c6 = new Comment();
        c6.SetCommentorsName("Commentor name 6 for v2");
        c6.SetCommentorsText("Commentor text 6 for v2");
        v2._comments.Add(c6);

        Video v3 = new Video("Video Title 3", "Author 3", 90);
        Comment c7 = new Comment();
        c7.SetCommentorsName("Commentor name 7 for v3");
        c7.SetCommentorsText("Commentor text 7 for v3");
        v3._comments.Add(c7);
        Comment c8 = new Comment();
        c8.SetCommentorsName("Commentor name 8 for v3");
        c8.SetCommentorsText("Commentor text 8 for v3");
        v3._comments.Add(c8);
        Comment c9 = new Comment();
        c9.SetCommentorsName("Commentor name 9 for v3");
        c9.SetCommentorsText("Commentor text 9 for v3");
        v3._comments.Add(c9);

        Video v4 = new Video("Video Title 4", "Author 4", 120);
        Comment c10 = new Comment();
        c10.SetCommentorsName("Commentor name 10 for v4");
        c10.SetCommentorsText("Commentor text 10 for v4");
        v4._comments.Add(c10);
        Comment c11 = new Comment();
        c11.SetCommentorsName("Commentor name 11 for v4");
        c11.SetCommentorsText("Commentor text 11 for v4");
        v4._comments.Add(c11);
        Comment c12 = new Comment();
        c12.SetCommentorsName("Commentor name 12 for v4");
        c12.SetCommentorsText("Commentor text 12 for v4");
        v4._comments.Add(c12);

        // Add videos to listOfVideos
        listOfVideos.Add(v1);
        listOfVideos.Add(v2);
        listOfVideos.Add(v3);
        listOfVideos.Add(v4);

        // Add anonymous objects
        listOfVideos.Add(new Video("Video Title 5", "Author 5", 150));
        listOfVideos[4]._comments.Add(new Comment("Commentor name 13 for v5","Commentor text 13 for v5"));

        // iterate to display all videos with comments
        foreach (Video video in listOfVideos)
        {
            video.DisplayVideoInfo();
        }
        // Console.ReadKey();
    }
}
/*
Program 1: Abstraction with YouTube Videos

Scenario
You have been hired by a company that does product awareness monitoring 
by tracking the placement of their products in YouTube videos. They 
want you to write a program that can help them work with the tens of 
thousands of videos they have identified as well as the comments on them.

Program Specification
Write a program to keep track of YouTube videos and comments left on 
them. As mentioned this could be part of a larger project to analyze 
them, but for this assignment, you will only need to worry about 
storing the information about a video and the comments.

Your program should have a class for a Video that has the responsibility 
to track the title, author, and length (in seconds) of the video. 
Each video also has responsibility to store a list of comments, and 
should have a method to return the number of comments. A comment 
should be defined by the Comment class which has the responsibility 
for tracking both the name of the person who made the comment and the 
text of the comment.

Once you have the classes in place, write a program that creates 3-4 
videos, sets the appropriate values, and for each one add a list of 
3-4 comments (with the commenter's name and text). Put each of these 
videos in a list.

Then, have your program iterate through the list of videos and for 
each one, display the title, author, length, number of comments 
(from the method) and then list out all of the comments for that 
video. Repeat this display for each video in the list.

Note: The YouTube example is just to give you a context for creating 
classes to store information. You will not actually be connecting to 
YouTube or downloading content in any way.

https://youtu.be/aLhAmimoQj8?si=7qJck_UGyuD_uWlS

*/