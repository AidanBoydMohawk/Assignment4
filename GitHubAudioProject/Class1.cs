using Raylib_cs;

namespace GitHubAudioProject
{
    public class Audio
    {
        public Sound music;
        private Sound backgroundMusic;
        private Sound hitsound;

        Sound LoadSound(string filename)
        {
            //sound loading i dont really understand but it works
            Sound sound = Raylib.LoadSound($"../../../resources/sounds/{filename}");
            return sound;
        }
        public void hit()
        {
            hitsound = LoadSound("Menu FX example/Menu1A.wav");
        }
        public void bgm()
        {
            //play background music
            backgroundMusic = LoadSound("sounds/awesomeness.wav");
        }
    }
    

}