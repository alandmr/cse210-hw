using System;

class Program
{ 
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Video video1 = new Video("Devotional For Young Adults","The Church of Jesus Christ of Latter-day Saints",3600);
        Video video2 = new Video("Bearing Our Burdens with Hope","The Church of Jesus Christ of Latter-day Saints",507.60);
        Video video3 = new Video("Christina Perri - A Thousand Years (Piano/Cello Cover)","The Piano Guys",258);        

        Comment comment;

        // COMMENTS FOR THE FIRST VIDEO
        for (int i = 0; i<3; i++){
            switch(i){
                case 0:
                    comment = new Comment("Aland Muñoz","Thank you so much president and sister Oaks");
                    video1.AddVideoComment(comment);
                    break;
                case 1:
                    comment = new Comment("Isabel Pino","I love this devotionals");
                    video1.AddVideoComment(comment);
                    break;
                case 2:
                    comment = new Comment("Henry Silva",
                    "Thank you so much president and sister Oaks, I love this devotional because make me"+
                    " remember the love of the Savior for me");
                    video1.AddVideoComment(comment);
                    break;
                default:
                    break;
            }
        }

        // COMMENTS FOR THE SECOND VIDEO
        for (int i = 0; i<3; i++){
            switch(i){
                case 0:
                    comment = new Comment("Sherley Diaz","Excellet teaching");
                    video2.AddVideoComment(comment);
                    break;
                case 1:
                    comment = new Comment("Maria Fernandez","I love this video");
                    video2.AddVideoComment(comment);
                    break;
                case 2:
                    comment = new Comment("Marcos Alvarez","Awesome, I love this video");
                    video2.AddVideoComment(comment);
                    break;
                default:
                    break;
            }
        }

        // COMMENTS FOR THE THIRD VIDEO
        for (int i = 0; i<3; i++){
            switch(i){
                case 0:
                    comment = new Comment("Ada Barreto","I love this song :)");
                    video3.AddVideoComment(comment);
                    break;
                case 1:
                    comment = new Comment("Barbara Garcia","I like it");
                    video3.AddVideoComment(comment);
                    break;
                case 2:
                    comment = new Comment("Juan Castro","Excellent interpretation");
                    video3.AddVideoComment(comment);
                    break;
                default:
                    break;
            }
        }

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        Console.Clear();

        foreach(Video video in videoList){
            
            Console.WriteLine($"Video Title: {video.GetVideoTitle()}");
            Console.WriteLine($"Author: {video.GetVideoAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength()} seg");
            Console.WriteLine($"Comments: ({video.GetCommentList().Count()})");
            Console.WriteLine();

            int j = 0;
            foreach(Comment c in video.GetCommentList()){
                j += 1;
                Console.WriteLine($"{j}.- {c.GetName()}");
                Console.WriteLine($"    {c.GetComment()}");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("");           
        }
    }
}