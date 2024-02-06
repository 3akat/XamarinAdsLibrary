using Android.Content;
using Android.Util;
using Com.Example.Androidtvlibrary.Main;
using XamarinAdsLibrary.CustomView;

namespace PausedAds.CustomView
{
    public class PlayerView 
        : Com.Example.Androidtvlibrary.Main.Adapter.PlayerView, IPlayerView
    {
        public PlayerView(Context context) : base(context)
        {
        }
        
        public PlayerView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }
        
        public PlayerView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }
        
        public void StartAds(bool skipped)
        {
            base.SetPlayerData();
            // IResumeCallback resumeCallback = new ResumeCallback();
            // IPauseCallback pauseCallback = new PauseCallback();

            base.AdAdsLoader(skipped);
        }

        public void CloseAds()
        {
            base.CloseAdsManager();
        }

        
    }
}