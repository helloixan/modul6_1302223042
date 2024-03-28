using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String judul_video)
    {
        setTitle(judul_video);
        this.playCount = 0;
        Random random = new Random();
        this.id = random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int playTime)
    {
        Contract.Requires(playTime <= 25000000 && playCount >= 0, "setiap penambahan play count memiliki maksimal 25.000.000 dan berupa bilangan positif");
        try
        {
            int hasil = checked(this.playCount + playTime);
            this.playCount = hasil;
        }
        catch (Exception OverFlowException)
        {
            Console.WriteLine("Error: " + OverFlowException.Message);
        }

    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Id: " + getId());
        Console.WriteLine("Title: " + getTitle());
        Console.WriteLine("Play Count: " + getPlayCount() + " Views");
    }

    public void setTitle(String judul_video)
    {
        Contract.Requires(judul_video.Length <= 200 && (judul_video != string.Empty && judul_video != null), "Judul tidak boleh kosong atau melebihi 100 karakter");
        this.title = judul_video;
    }

    public String getTitle()
    {
        return title;
    }

    public int getId()
    {
        return id;
    }

    public int getPlayCount()
    {
        return playCount;
    }
}
