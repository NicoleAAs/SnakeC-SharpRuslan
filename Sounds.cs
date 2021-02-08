using WMPLib;
namespace Snake
{
    public class Sounds
    {
       WindowsMediaPlayer player = new WindowsMediaPlayer();
       private string pathToMedia;

       public Sounds(string pathToResources)
       {
           pathToMedia = pathToResources;
       }

       public void Play()
       {
           player.URL = pathToMedia + "imposible.wav";
           player.settings.volume = 30;
           player.controls.play();
           player.settings.setMode("loop", true);
       }
    }
}