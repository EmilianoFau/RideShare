using System;
using System.Collections.Generic;
using TwitterUCU;

namespace Ridesharing;

public class Rideshare 
{
    public List<Users> Users = new List<Users>();

    public void Add(Users user, string text, string imagen)
    {
        Users.Add(user);
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
        cog.Recognize(@"bill.jpg");
        FoundFace(cog);
    }
    
}
