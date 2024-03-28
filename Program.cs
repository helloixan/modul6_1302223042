using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("iksan");
        string[] rekomVideo = new string[10] {"Harry Potter", "Avenger", "Meet the Robinson", "Your Name", "Now you see me", "MENU", 
            "Suzume", "Spiderman Home Coming", "Tomorrowland", "JUMANJI"};

        for (int i = 0; i < 10;i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film '{rekomVideo[i]}' oleh {user.getUsername()}");
            user.AddVideo(video);
        }

        user.PrintAllVideoPlayCount();
    }
}