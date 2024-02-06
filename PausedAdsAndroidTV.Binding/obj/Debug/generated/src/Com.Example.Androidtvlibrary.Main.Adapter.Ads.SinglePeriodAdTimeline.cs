using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='SinglePeriodAdTimeline']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/SinglePeriodAdTimeline", DoNotGenerateAcw=true)]
	public sealed partial class SinglePeriodAdTimeline : global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/SinglePeriodAdTimeline", typeof (SinglePeriodAdTimeline));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal SinglePeriodAdTimeline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='SinglePeriodAdTimeline']/constructor[@name='SinglePeriodAdTimeline' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.AdPlaybackStateTest']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;)V", "")]
		public unsafe SinglePeriodAdTimeline (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline contentTimeline, global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest adPlaybackState) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Timeline;Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contentTimeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentTimeline).Handle);
				__args [1] = new JniArgumentValue ((adPlaybackState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adPlaybackState).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (contentTimeline);
				global::System.GC.KeepAlive (adPlaybackState);
			}
		}

	}
}
