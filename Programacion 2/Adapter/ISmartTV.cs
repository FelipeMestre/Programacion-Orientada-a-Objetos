namespace Adapter
{
    public interface ISmartTV : ITV
    {
        void PlayNetflix();
        void PlayYoutube();
    }
}