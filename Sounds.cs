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
           player.URL = pathToMedia + "imposible.mp3";
           player.settings.volume = 10;
           player.controls.play();
           //player.settings.setMode("loop", true);
       }

       public void PlayEat()
       {
           player.URL = pathToMedia + "EetSound.wav";
           player.settings.volume = 50;
           player.controls.play();
       }

       public void PlaySpsEat()
       {
           player.URL = pathToMedia + "SPSEat.mp3";
           player.settings.volume = 70;
           player.controls.play();
       }
       public void PlayBadEat()
       {
           player.URL = pathToMedia + "SPSEat.mp3";
           player.settings.volume = 70;
           player.controls.play();
       }

       public void Stop()
       {
           player.URL = pathToMedia + "imposible.mp3";
           //player.settings.setMode("loop", true);
           player.controls.stop();
       }

       public void GameEnd()
       {
           player.URL = pathToMedia + "scream.mp3";
           player.controls.play();
       }

    }
}