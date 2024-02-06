using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='MediaSourceFactory']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/MediaSourceFactory", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactoryInvoker")]
	public partial interface IMediaSourceFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='MediaSourceFactory']/method[@name='createMediaSource' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("createMediaSource", "(Landroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;", "GetCreateMediaSource_Landroid_net_Uri_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource CreateMediaSource (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='MediaSourceFactory']/method[@name='getSupportedTypes' and count(parameter)=0]"
		[Register ("getSupportedTypes", "()[I", "GetGetSupportedTypesHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		int[] GetSupportedTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='MediaSourceFactory']/method[@name='setDrmSessionManager' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;?&gt;']]"
		[Register ("setDrmSessionManager", "(Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)Lcom/example/androidtvlibrary/main/adapter/Media/MediaSourceFactory;", "GetSetDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactory SetDrmSessionManager (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/MediaSourceFactory", DoNotGenerateAcw=true)]
	internal partial class IMediaSourceFactoryInvoker : global::Java.Lang.Object, IMediaSourceFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/MediaSourceFactory", typeof (IMediaSourceFactoryInvoker));

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

		public static IMediaSourceFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaSourceFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.MediaSourceFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaSourceFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createMediaSource_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetCreateMediaSource_Landroid_net_Uri_Handler ()
		{
			if (cb_createMediaSource_Landroid_net_Uri_ == null)
				cb_createMediaSource_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateMediaSource_Landroid_net_Uri_);
			return cb_createMediaSource_Landroid_net_Uri_;
		}

		static IntPtr n_CreateMediaSource_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateMediaSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createMediaSource_Landroid_net_Uri_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource CreateMediaSource (global::Android.Net.Uri p0)
		{
			if (id_createMediaSource_Landroid_net_Uri_ == IntPtr.Zero)
				id_createMediaSource_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "createMediaSource", "(Landroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createMediaSource_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getSupportedTypes;
#pragma warning disable 0169
		static Delegate GetGetSupportedTypesHandler ()
		{
			if (cb_getSupportedTypes == null)
				cb_getSupportedTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedTypes);
			return cb_getSupportedTypes;
		}

		static IntPtr n_GetSupportedTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSupportedTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getSupportedTypes;
		public unsafe int[] GetSupportedTypes ()
		{
			if (id_getSupportedTypes == IntPtr.Zero)
				id_getSupportedTypes = JNIEnv.GetMethodID (class_ref, "getSupportedTypes", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedTypes), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
#pragma warning disable 0169
		static Delegate GetSetDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Handler ()
		{
			if (cb_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ == null)
				cb_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_);
			return cb_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
		}

		static IntPtr n_SetDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDrmSessionManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactory SetDrmSessionManager (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager p0)
		{
			if (id_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ == IntPtr.Zero)
				id_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ = JNIEnv.GetMethodID (class_ref, "setDrmSessionManager", "(Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)Lcom/example/androidtvlibrary/main/adapter/Media/MediaSourceFactory;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IMediaSourceFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
