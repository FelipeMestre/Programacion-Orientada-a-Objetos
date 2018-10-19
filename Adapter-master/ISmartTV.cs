namespace Adapter
{
    interface ISmartTV : ITV
    {
        void PlayNetflix();
        void PlayYoutube();
    }
}