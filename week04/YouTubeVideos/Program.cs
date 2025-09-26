using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Comment commentYos1 = new Comment();
        commentYos1._commenterName = "@loucasanastasiou";
        commentYos1._text = "I am from Liverpool, I visited Yosemite 2 years ago. Yosemite is easily the best place I have, and ever will experience. Breathtaking scenery";
        Comment commentYos2 = new Comment();
        commentYos2._commenterName = "@alejgr1";
        commentYos2._text = "Been to all the national parks here in California! For my opinion, California is the most beautiful place to live!";
        Comment commentYos3 = new Comment();
        commentYos3._commenterName = "@heliscat";
        commentYos3._text = "My national parks pass was the best Christmas present I've ever bought myself. I hike Yosemite at least once a month.";
        Comment commentYos4 = new Comment();
        commentYos4._commenterName = "@myrajhall7690";
        commentYos4._text = "I spent my honeymoon camping in Yosemite it was magical!";

        Video yosemite = new Video();
        yosemite._title = "Top 5 Must-See Attractions in Yosemite";
        yosemite._author = "National Geographic";
        yosemite._videoLength = 221;
        yosemite._comments.Add(commentYos1);
        yosemite._comments.Add(commentYos2);
        yosemite._comments.Add(commentYos3);
        yosemite._comments.Add(commentYos4);

        Comment commentGSM1 = new Comment();
        commentGSM1._commenterName = "@Supagetti64";
        commentGSM1._text = "I'll be flying to Tennessee in a week, first time in the US. Hoping to get the chance to head up to the smokies, looks gorgeous.";
        Comment commentGSM2 = new Comment();
        commentGSM2._commenterName = "@Asianstuffy";
        commentGSM2._text = "Went here for spring break but sadly was interrupted mid way through by a wild fire";
        Comment commentGSM3 = new Comment();
        commentGSM3._commenterName = "@davidaaaa4611";
        commentGSM3._text = "My top thing I would do there would be to watch out for bears.";

        Video greatSmokyMtns = new Video();
        greatSmokyMtns._title = "Top Things You NEED To Do In Great Smoky Mountains National Park";
        greatSmokyMtns._author = "Parked in Paradise";
        greatSmokyMtns._videoLength = 523;
        greatSmokyMtns._comments.Add(commentGSM1);
        greatSmokyMtns._comments.Add(commentGSM2);
        greatSmokyMtns._comments.Add(commentGSM3);

        Comment commentAc1 = new Comment();
        commentAc1._commenterName = "@Sora90Kairi";
        commentAc1._text = "I just visited Acadia National Park this summer! woke up at 3:30 am to see the sunrise at Cadillac Summit!";
        Comment commentAc2 = new Comment();
        commentAc2._commenterName = "@JesseandKyle";
        commentAc2._text = "we live in CT and just drove to acadia for the first time. it was beautiful!!";
        Comment commentAc3 = new Comment();
        commentAc3._commenterName = "@ThePatriotrocker";
        commentAc3._text = "Be still my heart. Absolutely gorgeous!  We would move there in a heartbeat if we could swing it.";

        Video acadia = new Video();
        acadia._title = "Acadia National Park";
        acadia._author = "GoTraveler";
        acadia._videoLength = 374;
        acadia._comments.Add(commentAc1);
        acadia._comments.Add(commentAc2);
        acadia._comments.Add(commentAc3);

        //iterate through the list of videos and for each one, display the title, author, length, 
        // number of comments (from the method) and then list out all of the comments for that video. 
        // Repeat this display for each video in the list.

        videos.Add(yosemite);
        videos.Add(greatSmokyMtns);
        videos.Add(acadia);
        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}