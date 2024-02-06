using System;

namespace XamarinAdsLibrary
{
    public interface IPausedAds
    {
        String TestText { get; }

        public void StartAds(bool skipped);

    }
}