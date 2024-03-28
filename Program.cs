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

        // Menguji Postcondition
        user.PrintAllVideoPlayCount();

        //Menguji prekondisi
        SayaTubeVideo newvideo = new SayaTubeVideo(null);
        newvideo.IncreasePlayCount(25000001);
        user.setUserName(null);
        user.AddVideo(null);
        SayaTubeVideo newvideo2 = new SayaTubeVideo("dummy video");
        newvideo2.IncreasePlayCount(int.MaxValue);
        user.AddVideo(newvideo2);

        //Menguji exception
        SayaTubeVideo newvideo3 = new SayaTubeVideo("Overflow video");
        newvideo3.IncreasePlayCount(-500);
        for (int i = 0; i < 10; i++)
        {
            newvideo3.IncreasePlayCount(9900000);
        }
    }
}