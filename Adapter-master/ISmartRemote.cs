namespace Adapter
{
    interface ISmartRemote 
    {
        void StartNetflix(ISmartTV smartTv);
        void StartYouTube(ISmartTV smartTv);
    }
}