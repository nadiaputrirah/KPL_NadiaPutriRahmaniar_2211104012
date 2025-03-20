using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    private const int MAX_PLAYCOUNT = 25000000;

    public SayaTubeVideo(string title)
    {
        if (title == null) throw new ArgumentNullException("Judul video tidak boleh null");
        if (title.Length > 200) throw new ArgumentException("Judul video maksimal 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // Generate ID 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > MAX_PLAYCOUNT)
        {
            Console.WriteLine("Error: Play count maksimal 25.000.000 per panggilan dan tidak boleh bilangan negatif.");
            return;
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas integer.");
        }
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
    private const int MAX_USERNAME_LENGTH = 100;

    public SayaTubeUser(string username)
    {
        if (username == null) throw new ArgumentNullException("Username tidak boleh null");
        if (username.Length > MAX_USERNAME_LENGTH) throw new ArgumentException("Username maksimal 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null) throw new ArgumentNullException("Video tidak boleh null");

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
        for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
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
            "Review Film Interstellar oleh Nadiaputri",
            "Review Film Inception oleh Nadiaputri",
            "Review Film The Dark Knight oleh Nadiaputri",
            "Review Film Parasite oleh Nadiaputri",
            "Review Film The Godfather oleh Nadiaputri",
            "Review Film Whiplash oleh Nadiaputri",
            "Review Film Fight Club oleh Nadiaputri",
            "Review Film Joker oleh Nadiaputri",
            "Review Film Titanic oleh Nadiaputri",
            "Review Film Forrest Gump oleh Nadiaputri"
        };

        foreach (var film in filmList)
        {
            SayaTubeVideo video = new SayaTubeVideo(film);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total play count: {user.GetTotalVideoPlayCount()}");

        // Uji precondition dengan nilai play count yang salah
        SayaTubeVideo testVideo = new SayaTubeVideo("Test Video");
        testVideo.IncreasePlayCount(30000000); // Melebihi batas
    }
}
