using System.Diagnostics;
using System.Diagnostics.Contracts;

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
        Contract.Requires(username.Length <= 100 && (username != string.Empty && username != null), "username tidak boleh kosong dan maksimal karakternya 100");
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
        Contract.Requires(video != null, "video yang ditambahkan tidak boleh null");
        Contract.Requires(video.getPlayCount() < int.MaxValue);
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");
        for (int i = 0;i < this.uploadedVideos.Count;i++)
        {
            Console.WriteLine($"Video {i+1} judul: {this.uploadedVideos[i].getTitle()}");
        }

        Contract.Ensures(uploadedVideos.Count <= 8, "Jumlah video yang di tampilkan melebihi maksimal 8");
    }
}