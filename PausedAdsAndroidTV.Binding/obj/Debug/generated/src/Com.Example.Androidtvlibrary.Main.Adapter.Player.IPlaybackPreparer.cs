using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='PlaybackPreparer']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/PlaybackPreparer", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparerInvoker")]
	public partial interface IPlaybackPreparer : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='PlaybackPreparer']/method[@name='preparePlayback' and count(parameter)=0]"
		[Register ("preparePlayback", "()V", "GetPreparePlaybackHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparerInvoker, PausedAdsAndroidTV.Binding")]
		void PreparePlayback ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/PlaybackPreparer", DoNotGenerateAcw=true)]
	internal partial class IPlaybackPreparerInvoker : global::Java.Lang.Object, IPlaybackPreparer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/PlaybackPreparer", typeof (IPlaybackPreparerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPlaybackPreparer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlaybackPreparer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.PlaybackPreparer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlaybackPreparerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_preparePlayback;
#pragma warning disable 0169
		static Delegate GetPreparePlaybackHandler ()
		{
			if (cb_preparePlayback == null)
				cb_preparePlayback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PreparePlayback);
			return cb_preparePlayback;
		}

		static void n_PreparePlayback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreparePlayback ();
		}
#pragma warning restore 0169

		IntPtr id_preparePlayback;
		public unsafe void PreparePlayback ()
		{
			if (id_preparePlayback == IntPtr.Zero)
				id_preparePlayback = JNIEnv.GetMethodID (class_ref, "preparePlayback", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preparePlayback);
		}

	}
}
