using System.IO;
using System.Reflection;
using DataStructures.Enums;
using Interfaces.PlatformServices;
using Plugin.SimpleAudioPlayer;

namespace XamarinTest.PlatformServices
{
    public class PlaySoundService : IPlaySoundService
    {
        public void PlaySound(AppSoundsEnum sound)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream($"XamarinTest.Resources.Sounds.{sound}.mp3");
            
            var player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            player.Load(audioStream);
            player.Play();
        }
    }
}