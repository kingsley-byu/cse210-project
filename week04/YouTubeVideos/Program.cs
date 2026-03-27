using System;

class Program
{
    static void Main(string[] args)
    {
        public List<Video> _video = new List<Video>();

        Video video1 = new Video("Best of  lionel messi", "Prince bolton", 689);
        Comment comment1 = new Comment("osawaru kingsley", "wow what a performance by lionel messi");
        Comment comment2 = new Comment("prince wells", "magical messi");
        Comment comment3 = new Comment("Adam steve", "Ohh My world!!, magical messsi");
        Comment comment4 = new Comment("clark newton", "beaitiful by lionel messi");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);


        

        

    }
}