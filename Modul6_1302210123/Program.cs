// See https://aka.ms/new-console-template for more information

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public int getpLayCount()
    {
        return playCount;
    }

    public string getTitle()
    {
        return title;
    }

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount= 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void printVideoDetail()
    {
        Console.WriteLine("video ID:" + id);
        Console.WriteLine("Title:" + title);
        Console.WriteLine("play count: " + playCount);
    }
}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string Username)
    {
        Random random= new Random();
        this.id = random.Next(10000, 99999);
        this.Username = Username;
        this.uploadedVideos= new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPLayCount()
    {
        int total = 0;
        while ( uploadedVideos != null )
        {
            total++;
        }
        return total;

    }

    public void AddVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("user: " + Username);
        for (int i = 0; i <this.uploadedVideos.Count; i++)
        {
            Console.WriteLine("video " + (i + 1) + " judul " + uploadedVideos[i].getTitle());
        }
    }
}

class main
{
    public static void Main()
    {
        
        SayaTubeVideo TubeVideo = new SayaTubeVideo("Shin Kamen Rider");
        SayaTubeVideo TubeVideo2 = new SayaTubeVideo("Shin Uiltraman");
        SayaTubeVideo TubeVideo3 = new SayaTubeVideo("Shin Godzilla");
        SayaTubeVideo TubeVideo4 = new SayaTubeVideo("The Raid 1");
        SayaTubeVideo TubeVideo5 = new SayaTubeVideo("The Raid 2");
        SayaTubeVideo TubeVideo6 = new SayaTubeVideo("John Wick 1");
        SayaTubeVideo TubeVideo7 = new SayaTubeVideo("John Wick 2");
        SayaTubeVideo TubeVideo8 = new SayaTubeVideo("John Wick 3");
        SayaTubeVideo TubeVideo9 = new SayaTubeVideo("John Wick 4");
        SayaTubeVideo TubeVideo10 = new SayaTubeVideo("City of God");
        SayaTubeUser TubeUser = new SayaTubeUser("Rafa Eka");
        TubeUser.AddVideo(TubeVideo);
        TubeUser.AddVideo(TubeVideo2);
        TubeUser.AddVideo(TubeVideo3);
        TubeUser.AddVideo(TubeVideo4);
        TubeUser.AddVideo(TubeVideo5);
        TubeUser.AddVideo(TubeVideo6);
        TubeUser.AddVideo(TubeVideo7);
        TubeUser.AddVideo(TubeVideo8);
        TubeUser.AddVideo(TubeVideo9);
        TubeUser.AddVideo(TubeVideo10);
        TubeUser.PrintAllVideoPlaycount();

    }
}