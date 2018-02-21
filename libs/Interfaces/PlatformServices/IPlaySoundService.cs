using DataStructures.Enums;

namespace Interfaces.PlatformServices
{
    public interface IPlaySoundService
    {
        void PlaySound(AppSoundsEnum sound);
    }
}