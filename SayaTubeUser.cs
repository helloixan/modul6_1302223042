public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        setUserName(username);
        setID();
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void setUserName(string username)
    {
        this.username = username;
    }

    public void setID()
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
    }

    public string getUsername()
    {
        return username;
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        for (int i = 0; i < this.uploadedVideos.Count; i++)
        {
            totalPlayCount += this.uploadedVideos[i].getPlayCount();
        }

        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");
        for (int i = 0;i < this.uploadedVideos.Count;i++)
        {
            Console.WriteLine($"Video {i+1} judul: {this.uploadedVideos[i].getTitle()}");
        }
    }
}