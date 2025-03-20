using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // Generate 5-digit ID
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0)
        {
            throw new ArgumentException("Play count tidak boleh negatif");
        }
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}\n");
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}

class SayaTubeUser
{
    private int id;
    private string Username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // Generate 5-digit ID
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
        {
            throw new ArgumentNullException("Video tidak boleh null");
        }
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }
}

class Jurnal6_2211104012
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Nadiaputri");

        List<string> filmList = new List<string>
        {
            "Review Film oleh Praktikan: Inception",
            "Review Film oleh Praktikan: Interstellar",
            "Review Film oleh Praktikan: The Dark Knight",
            "Review Film oleh Praktikan: Parasite",
            "Review Film oleh Praktikan: The Matrix",
            "Review Film oleh Praktikan: Avenger: Endgame",
            "Review Film oleh Praktikan: Spiderman: No Way Home",
            "Review Film oleh Praktikan: Joker",
            "Review Film oleh Praktikan: The Godfather",
            "Review Film oleh Praktikan: Fight Club"
        };

        foreach (var film in filmList)
        {
            SayaTubeVideo video = new SayaTubeVideo(film);
            user.AddVideo(video);
            video.IncreasePlayCount(new Random().Next(1000, 10000)); // Simulasi jumlah views
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
    }
}
