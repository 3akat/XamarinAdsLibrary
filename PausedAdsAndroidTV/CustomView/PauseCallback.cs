using System;
using Com.Example.Androidtvlibrary.Main;
using Java.Interop;

namespace PausedAds.CustomView
{
    public class PauseCallback: Java.Lang.Object, IPauseCallback
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IntPtr Handle { get; }
        public void SetJniIdentityHashCode(int value)
        {
            throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        public void Finalized()
        {
            throw new NotImplementedException();
        }

        public int JniIdentityHashCode { get; }
        public JniObjectReference PeerReference { get; }
        public JniPeerMembers JniPeerMembers { get; }
        public JniManagedPeerStates JniManagedPeerState { get; }
        public void OnPauseCall()
        {
        }
    }
}