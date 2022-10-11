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
        if (FoundFace(cog))
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(text,photo));
        }

        static bool FoundFace(CognitiveFace cog)
        {
        if (cog.FaceFound)
        {
            Console.WriteLine("Face Found!");
            if (cog.SmileFound)
            {
                Console.WriteLine("Found a Smile :)");
                return true;
            }
            else
            {
                Console.WriteLine("No smile found :(");
            }
        }
        else
        {
            Console.WriteLine("No Face Found");
        }    
        return false;
        }
    }   
}
