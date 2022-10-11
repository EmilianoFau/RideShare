using System;
using System.Collections.Generic;
using TwitterUCU;
using CognitiveCoreUCU;

namespace Ridesharing;

public class Rideshare 
{
    public List<Users> Users = new List<Users>();

    public void Add(Users user, string photo)
    {
        Users.Add(user);
        String text = user.Descripcion();
        CognitiveFace cog = new CognitiveFace(false);
        cog.Recognize(photo);
        user.FoundFace(cog);
        if (user.Face)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(text,photo));
        }

        
    }   
}
