using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='VideoFrameMetadataListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListenerInvoker")]
	public partial interface IVideoFrameMetadataListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='VideoFrameMetadataListener']/method[@name='onVideoFrameAboutToBeRendered' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='android.media.MediaFormat']]"
		[Register ("onVideoFrameAboutToBeRendered", "(JJLcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaFormat;)V", "GetOnVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnVideoFrameAboutToBeRendered (long p0, long p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2, global::Android.Media.MediaFormat p3);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener", DoNotGenerateAcw=true)]
	internal partial class IVideoFrameMetadataListenerInvoker : global::Java.Lang.Object, IVideoFrameMetadataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener", typeof (IVideoFrameMetadataListenerInvoker));

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

		public static IVideoFrameMetadataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoFrameMetadataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.VideoFrameMetadataListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoFrameMetadataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetOnVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_ == null)
				cb_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJLL_V) n_OnVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_);
			return cb_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_;
		}

		static void n_OnVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoFrameAboutToBeRendered (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_;
		public unsafe void OnVideoFrameAboutToBeRendered (long p0, long p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2, global::Android.Media.MediaFormat p3)
		{
			if (id_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_ == IntPtr.Zero)
				id_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_ = JNIEnv.GetMethodID (class_ref, "onVideoFrameAboutToBeRendered", "(JJLcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaFormat;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoFrameAboutToBeRendered_JJLcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaFormat_, __args);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.VideoFrameMetadataListener.onVideoFrameAboutToBeRendered
	public partial class VideoFrameMetadataEventArgs : global::System.EventArgs {
		public VideoFrameMetadataEventArgs (long p0, long p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2, global::Android.Media.MediaFormat p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		long p0;

		public long P0 {
			get { return p0; }
		}

		long p1;

		public long P1 {
			get { return p1; }
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.Format P2 {
			get { return p2; }
		}

		global::Android.Media.MediaFormat p3;

		public global::Android.Media.MediaFormat P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/VideoFrameMetadataListenerImplementor")]
	internal sealed partial class IVideoFrameMetadataListenerImplementor : global::Java.Lang.Object, IVideoFrameMetadataListener {

		object sender;

		public IVideoFrameMetadataListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/VideoFrameMetadataListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<VideoFrameMetadataEventArgs> Handler;
		#pragma warning restore 0649

		public void OnVideoFrameAboutToBeRendered (long p0, long p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2, global::Android.Media.MediaFormat p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoFrameMetadataEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IVideoFrameMetadataListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
