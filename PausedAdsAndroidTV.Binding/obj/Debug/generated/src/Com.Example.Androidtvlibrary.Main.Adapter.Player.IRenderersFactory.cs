using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='RenderersFactory']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/RenderersFactory", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IRenderersFactoryInvoker")]
	public partial interface IRenderersFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='RenderersFactory']/method[@name='createRenderers' and count(parameter)=6 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.TextOutput'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;']]"
		[Register ("createRenderers", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)[Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;", "GetCreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IRenderersFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] CreateRenderers (global::Android.OS.Handler p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener p2, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput p3, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput p4, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager p5);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/RenderersFactory", DoNotGenerateAcw=true)]
	internal partial class IRenderersFactoryInvoker : global::Java.Lang.Object, IRenderersFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/RenderersFactory", typeof (IRenderersFactoryInvoker));

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

		public static IRenderersFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRenderersFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.RenderersFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRenderersFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
#pragma warning disable 0169
		static Delegate GetCreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Handler ()
		{
			if (cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ == null)
				cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_L) n_CreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_);
			return cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
		}

		static IntPtr n_CreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput> (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.CreateRenderers (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] CreateRenderers (global::Android.OS.Handler p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener p2, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput p3, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput p4, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager p5)
		{
			if (id_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ == IntPtr.Zero)
				id_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ = JNIEnv.GetMethodID (class_ref, "createRenderers", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)[Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;");
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			var __ret = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer));
			return __ret;
		}

	}
}
