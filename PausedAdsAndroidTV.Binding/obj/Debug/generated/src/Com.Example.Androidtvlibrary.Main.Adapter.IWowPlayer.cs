using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/WowPlayer$Builder", DoNotGenerateAcw=true)]
	public sealed partial class WowPlayerBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/WowPlayer$Builder", typeof (WowPlayerBuilder));

		internal static IntPtr class_ref {
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

		internal WowPlayerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/constructor[@name='WowPlayer.Builder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer...']]"
		[Register (".ctor", "(Landroid/content/Context;[Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;)V", "")]
		public unsafe WowPlayerBuilder (global::Android.Content.Context context, params global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] renderers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;[Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_renderers = JNIEnv.NewArray (renderers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_renderers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (renderers != null) {
					JNIEnv.CopyArray (native_renderers, renderers);
					JNIEnv.DeleteLocalRef (native_renderers);
				}
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (renderers);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/constructor[@name='WowPlayer.Builder' and count(parameter)=7 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.LoadControl'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter'] and parameter[5][@type='android.os.Looper'] and parameter[6][@type='boolean'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelector;Lcom/example/androidtvlibrary/main/adapter/wow/LoadControl;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;Landroid/os/Looper;ZLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V", "")]
		public unsafe WowPlayerBuilder (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] renderers, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector trackSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl loadControl, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter, global::Android.OS.Looper looper, bool useLazyPreparation, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelector;Lcom/example/androidtvlibrary/main/adapter/wow/LoadControl;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;Landroid/os/Looper;ZLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_renderers = JNIEnv.NewArray (renderers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_renderers);
				__args [1] = new JniArgumentValue ((trackSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelector).Handle);
				__args [2] = new JniArgumentValue ((loadControl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadControl).Handle);
				__args [3] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
				__args [4] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				__args [5] = new JniArgumentValue (useLazyPreparation);
				__args [6] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (renderers != null) {
					JNIEnv.CopyArray (native_renderers, renderers);
					JNIEnv.DeleteLocalRef (native_renderers);
				}
				global::System.GC.KeepAlive (renderers);
				global::System.GC.KeepAlive (trackSelector);
				global::System.GC.KeepAlive (loadControl);
				global::System.GC.KeepAlive (bandwidthMeter);
				global::System.GC.KeepAlive (looper);
				global::System.GC.KeepAlive (clock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/example/androidtvlibrary/main/adapter/WowPlayer;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer Build ()
		{
			const string __id = "build.()Lcom/example/androidtvlibrary/main/adapter/WowPlayer;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setAnalyticsCollector' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.AnalyticsCollector']]"
		[Register ("setAnalyticsCollector", "(Lcom/example/androidtvlibrary/main/adapter/wow/AnalyticsCollector;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetAnalyticsCollector (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AnalyticsCollector analyticsCollector)
		{
			const string __id = "setAnalyticsCollector.(Lcom/example/androidtvlibrary/main/adapter/wow/AnalyticsCollector;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((analyticsCollector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) analyticsCollector).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (analyticsCollector);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setBandwidthMeter' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
		[Register ("setBandwidthMeter", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetBandwidthMeter (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter)
		{
			const string __id = "setBandwidthMeter.(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bandwidthMeter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setClock' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
		[Register ("setClock", "(Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetClock (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock)
		{
			const string __id = "setClock.(Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setLoadControl' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.LoadControl']]"
		[Register ("setLoadControl", "(Lcom/example/androidtvlibrary/main/adapter/wow/LoadControl;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetLoadControl (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl loadControl)
		{
			const string __id = "setLoadControl.(Lcom/example/androidtvlibrary/main/adapter/wow/LoadControl;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((loadControl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadControl).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (loadControl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setLooper' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
		[Register ("setLooper", "(Landroid/os/Looper;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetLooper (global::Android.OS.Looper looper)
		{
			const string __id = "setLooper.(Landroid/os/Looper;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (looper);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setTrackSelector' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelector']]"
		[Register ("setTrackSelector", "(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelector;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetTrackSelector (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector trackSelector)
		{
			const string __id = "setTrackSelector.(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelector;)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trackSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelector).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (trackSelector);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='WowPlayer.Builder']/method[@name='setUseLazyPreparation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseLazyPreparation", "(Z)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder SetUseLazyPreparation (bool useLazyPreparation)
		{
			const string __id = "setUseLazyPreparation.(Z)Lcom/example/androidtvlibrary/main/adapter/WowPlayer$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (useLazyPreparation);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']"
	[Register ("com/example/androidtvlibrary/main/adapter/WowPlayer", "", "Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker")]
	public partial interface IWowPlayer : global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer {
		global::Android.OS.Looper PlaybackLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='getPlaybackLooper' and count(parameter)=0]"
			[Register ("getPlaybackLooper", "()Landroid/os/Looper;", "GetGetPlaybackLooperHandler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters SeekParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='getSeekParameters' and count(parameter)=0]"
			[Register ("getSeekParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;", "GetGetSeekParametersHandler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='setSeekParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.SeekParameters']]"
			[Register ("setSeekParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;)V", "GetSetSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='createMessage' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlayerMessage.Target']]"
		[Register ("createMessage", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target;)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "GetCreateMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage CreateMessage (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource']]"
		[Register ("prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;)V", "GetPrepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='prepare' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;ZZ)V", "GetPrepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZHandler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p0, bool p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='retry' and count(parameter)=0]"
		[Register ("retry", "()V", "GetRetryHandler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Retry ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='WowPlayer']/method[@name='setForegroundMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForegroundMode", "(Z)V", "GetSetForegroundMode_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void SetForegroundMode (bool p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/WowPlayer", DoNotGenerateAcw=true)]
	internal partial class IWowPlayerInvoker : global::Java.Lang.Object, IWowPlayer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/WowPlayer", typeof (IWowPlayerInvoker));

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

		public static IWowPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWowPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.WowPlayer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWowPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPlaybackLooper;
#pragma warning disable 0169
		static Delegate GetGetPlaybackLooperHandler ()
		{
			if (cb_getPlaybackLooper == null)
				cb_getPlaybackLooper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlaybackLooper);
			return cb_getPlaybackLooper;
		}

		static IntPtr n_GetPlaybackLooper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaybackLooper);
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackLooper;
		public unsafe global::Android.OS.Looper PlaybackLooper {
			get {
				if (id_getPlaybackLooper == IntPtr.Zero)
					id_getPlaybackLooper = JNIEnv.GetMethodID (class_ref, "getPlaybackLooper", "()Landroid/os/Looper;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackLooper), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSeekParameters;
#pragma warning disable 0169
		static Delegate GetGetSeekParametersHandler ()
		{
			if (cb_getSeekParameters == null)
				cb_getSeekParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSeekParameters);
			return cb_getSeekParameters;
		}

		static IntPtr n_GetSeekParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekParameters);
		}
#pragma warning restore 0169

		static Delegate cb_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_;
#pragma warning disable 0169
		static Delegate GetSetSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_Handler ()
		{
			if (cb_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ == null)
				cb_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_);
			return cb_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_;
		}

		static void n_SetSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SeekParameters = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSeekParameters;
		IntPtr id_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters SeekParameters {
			get {
				if (id_getSeekParameters == IntPtr.Zero)
					id_getSeekParameters = JNIEnv.GetMethodID (class_ref, "getSeekParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeekParameters), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ == IntPtr.Zero)
					id_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ = JNIEnv.GetMethodID (class_ref, "setSeekParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSeekParameters_Lcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_, __args);
			}
		}

		static Delegate cb_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_;
#pragma warning disable 0169
		static Delegate GetCreateMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_Handler ()
		{
			if (cb_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_ == null)
				cb_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_);
			return cb_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_;
		}

		static IntPtr n_CreateMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage CreateMessage (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget p0)
		{
			if (id_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_ == IntPtr.Zero)
				id_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_ = JNIEnv.GetMethodID (class_ref, "createMessage", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target;)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Target_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_;
#pragma warning disable 0169
		static Delegate GetPrepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Handler ()
		{
			if (cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ == null)
				cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_);
			return cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_;
		}

		static void n_Prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		IntPtr id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_;
		public unsafe void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p0)
		{
			if (id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ == IntPtr.Zero)
				id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_, __args);
		}

		static Delegate cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ;
#pragma warning disable 0169
		static Delegate GetPrepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZHandler ()
		{
			if (cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ == null)
				cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_V) n_Prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ);
			return cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ;
		}

		static void n_Prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ;
		public unsafe void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p0, bool p1, bool p2)
		{
			if (id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ == IntPtr.Zero)
				id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;ZZ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_ZZ, __args);
		}

		static Delegate cb_retry;
#pragma warning disable 0169
		static Delegate GetRetryHandler ()
		{
			if (cb_retry == null)
				cb_retry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Retry);
			return cb_retry;
		}

		static void n_Retry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retry ();
		}
#pragma warning restore 0169

		IntPtr id_retry;
		public unsafe void Retry ()
		{
			if (id_retry == IntPtr.Zero)
				id_retry = JNIEnv.GetMethodID (class_ref, "retry", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retry);
		}

		static Delegate cb_setForegroundMode_Z;
#pragma warning disable 0169
		static Delegate GetSetForegroundMode_ZHandler ()
		{
			if (cb_setForegroundMode_Z == null)
				cb_setForegroundMode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetForegroundMode_Z);
			return cb_setForegroundMode_Z;
		}

		static void n_SetForegroundMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetForegroundMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_setForegroundMode_Z;
		public unsafe void SetForegroundMode (bool p0)
		{
			if (id_setForegroundMode_Z == IntPtr.Zero)
				id_setForegroundMode_Z = JNIEnv.GetMethodID (class_ref, "setForegroundMode", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setForegroundMode_Z, __args);
		}

		static Delegate cb_getApplicationLooper;
#pragma warning disable 0169
		static Delegate GetGetApplicationLooperHandler ()
		{
			if (cb_getApplicationLooper == null)
				cb_getApplicationLooper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApplicationLooper);
			return cb_getApplicationLooper;
		}

		static IntPtr n_GetApplicationLooper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationLooper);
		}
#pragma warning restore 0169

		IntPtr id_getApplicationLooper;
		public unsafe global::Android.OS.Looper ApplicationLooper {
			get {
				if (id_getApplicationLooper == IntPtr.Zero)
					id_getApplicationLooper = JNIEnv.GetMethodID (class_ref, "getApplicationLooper", "()Landroid/os/Looper;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationLooper), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAudioComponent;
#pragma warning disable 0169
		static Delegate GetGetAudioComponentHandler ()
		{
			if (cb_getAudioComponent == null)
				cb_getAudioComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioComponent);
			return cb_getAudioComponent;
		}

		static IntPtr n_GetAudioComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioComponent);
		}
#pragma warning restore 0169

		IntPtr id_getAudioComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent AudioComponent {
			get {
				if (id_getAudioComponent == IntPtr.Zero)
					id_getAudioComponent = JNIEnv.GetMethodID (class_ref, "getAudioComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$AudioComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBufferedPercentage;
#pragma warning disable 0169
		static Delegate GetGetBufferedPercentageHandler ()
		{
			if (cb_getBufferedPercentage == null)
				cb_getBufferedPercentage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBufferedPercentage);
			return cb_getBufferedPercentage;
		}

		static int n_GetBufferedPercentage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPercentage;
		}
#pragma warning restore 0169

		IntPtr id_getBufferedPercentage;
		public unsafe int BufferedPercentage {
			get {
				if (id_getBufferedPercentage == IntPtr.Zero)
					id_getBufferedPercentage = JNIEnv.GetMethodID (class_ref, "getBufferedPercentage", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPercentage);
			}
		}

		static Delegate cb_getBufferedPosition;
#pragma warning disable 0169
		static Delegate GetGetBufferedPositionHandler ()
		{
			if (cb_getBufferedPosition == null)
				cb_getBufferedPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBufferedPosition);
			return cb_getBufferedPosition;
		}

		static long n_GetBufferedPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPosition;
		}
#pragma warning restore 0169

		IntPtr id_getBufferedPosition;
		public unsafe long BufferedPosition {
			get {
				if (id_getBufferedPosition == IntPtr.Zero)
					id_getBufferedPosition = JNIEnv.GetMethodID (class_ref, "getBufferedPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPosition);
			}
		}

		static Delegate cb_getContentBufferedPosition;
#pragma warning disable 0169
		static Delegate GetGetContentBufferedPositionHandler ()
		{
			if (cb_getContentBufferedPosition == null)
				cb_getContentBufferedPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetContentBufferedPosition);
			return cb_getContentBufferedPosition;
		}

		static long n_GetContentBufferedPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentBufferedPosition;
		}
#pragma warning restore 0169

		IntPtr id_getContentBufferedPosition;
		public unsafe long ContentBufferedPosition {
			get {
				if (id_getContentBufferedPosition == IntPtr.Zero)
					id_getContentBufferedPosition = JNIEnv.GetMethodID (class_ref, "getContentBufferedPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentBufferedPosition);
			}
		}

		static Delegate cb_getContentDuration;
#pragma warning disable 0169
		static Delegate GetGetContentDurationHandler ()
		{
			if (cb_getContentDuration == null)
				cb_getContentDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetContentDuration);
			return cb_getContentDuration;
		}

		static long n_GetContentDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentDuration;
		}
#pragma warning restore 0169

		IntPtr id_getContentDuration;
		public unsafe long ContentDuration {
			get {
				if (id_getContentDuration == IntPtr.Zero)
					id_getContentDuration = JNIEnv.GetMethodID (class_ref, "getContentDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentDuration);
			}
		}

		static Delegate cb_getContentPosition;
#pragma warning disable 0169
		static Delegate GetGetContentPositionHandler ()
		{
			if (cb_getContentPosition == null)
				cb_getContentPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetContentPosition);
			return cb_getContentPosition;
		}

		static long n_GetContentPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getContentPosition;
		public unsafe long ContentPosition {
			get {
				if (id_getContentPosition == IntPtr.Zero)
					id_getContentPosition = JNIEnv.GetMethodID (class_ref, "getContentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentPosition);
			}
		}

		static Delegate cb_getCurrentAdGroupIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentAdGroupIndexHandler ()
		{
			if (cb_getCurrentAdGroupIndex == null)
				cb_getCurrentAdGroupIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentAdGroupIndex);
			return cb_getCurrentAdGroupIndex;
		}

		static int n_GetCurrentAdGroupIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentAdGroupIndex;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAdGroupIndex;
		public unsafe int CurrentAdGroupIndex {
			get {
				if (id_getCurrentAdGroupIndex == IntPtr.Zero)
					id_getCurrentAdGroupIndex = JNIEnv.GetMethodID (class_ref, "getCurrentAdGroupIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAdGroupIndex);
			}
		}

		static Delegate cb_getCurrentAdIndexInAdGroup;
#pragma warning disable 0169
		static Delegate GetGetCurrentAdIndexInAdGroupHandler ()
		{
			if (cb_getCurrentAdIndexInAdGroup == null)
				cb_getCurrentAdIndexInAdGroup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentAdIndexInAdGroup);
			return cb_getCurrentAdIndexInAdGroup;
		}

		static int n_GetCurrentAdIndexInAdGroup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentAdIndexInAdGroup;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAdIndexInAdGroup;
		public unsafe int CurrentAdIndexInAdGroup {
			get {
				if (id_getCurrentAdIndexInAdGroup == IntPtr.Zero)
					id_getCurrentAdIndexInAdGroup = JNIEnv.GetMethodID (class_ref, "getCurrentAdIndexInAdGroup", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAdIndexInAdGroup);
			}
		}

		static Delegate cb_getCurrentManifest;
#pragma warning disable 0169
		static Delegate GetGetCurrentManifestHandler ()
		{
			if (cb_getCurrentManifest == null)
				cb_getCurrentManifest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentManifest);
			return cb_getCurrentManifest;
		}

		static IntPtr n_GetCurrentManifest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentManifest);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentManifest;
		public unsafe global::Java.Lang.Object CurrentManifest {
			get {
				if (id_getCurrentManifest == IntPtr.Zero)
					id_getCurrentManifest = JNIEnv.GetMethodID (class_ref, "getCurrentManifest", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentManifest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentPeriodIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentPeriodIndexHandler ()
		{
			if (cb_getCurrentPeriodIndex == null)
				cb_getCurrentPeriodIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentPeriodIndex);
			return cb_getCurrentPeriodIndex;
		}

		static int n_GetCurrentPeriodIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPeriodIndex;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPeriodIndex;
		public unsafe int CurrentPeriodIndex {
			get {
				if (id_getCurrentPeriodIndex == IntPtr.Zero)
					id_getCurrentPeriodIndex = JNIEnv.GetMethodID (class_ref, "getCurrentPeriodIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPeriodIndex);
			}
		}

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static long n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPosition;
		public unsafe long CurrentPosition {
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
			}
		}

		static Delegate cb_getCurrentTag;
#pragma warning disable 0169
		static Delegate GetGetCurrentTagHandler ()
		{
			if (cb_getCurrentTag == null)
				cb_getCurrentTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTag);
			return cb_getCurrentTag;
		}

		static IntPtr n_GetCurrentTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTag);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTag;
		public unsafe global::Java.Lang.Object CurrentTag {
			get {
				if (id_getCurrentTag == IntPtr.Zero)
					id_getCurrentTag = JNIEnv.GetMethodID (class_ref, "getCurrentTag", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentTimeline;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimelineHandler ()
		{
			if (cb_getCurrentTimeline == null)
				cb_getCurrentTimeline = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTimeline);
			return cb_getCurrentTimeline;
		}

		static IntPtr n_GetCurrentTimeline (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTimeline);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTimeline;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline CurrentTimeline {
			get {
				if (id_getCurrentTimeline == IntPtr.Zero)
					id_getCurrentTimeline = JNIEnv.GetMethodID (class_ref, "getCurrentTimeline", "()Lcom/example/androidtvlibrary/main/adapter/Timeline;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTimeline), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentTrackGroups;
#pragma warning disable 0169
		static Delegate GetGetCurrentTrackGroupsHandler ()
		{
			if (cb_getCurrentTrackGroups == null)
				cb_getCurrentTrackGroups = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTrackGroups);
			return cb_getCurrentTrackGroups;
		}

		static IntPtr n_GetCurrentTrackGroups (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTrackGroups);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTrackGroups;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray CurrentTrackGroups {
			get {
				if (id_getCurrentTrackGroups == IntPtr.Zero)
					id_getCurrentTrackGroups = JNIEnv.GetMethodID (class_ref, "getCurrentTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTrackGroups), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentTrackSelections;
#pragma warning disable 0169
		static Delegate GetGetCurrentTrackSelectionsHandler ()
		{
			if (cb_getCurrentTrackSelections == null)
				cb_getCurrentTrackSelections = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTrackSelections);
			return cb_getCurrentTrackSelections;
		}

		static IntPtr n_GetCurrentTrackSelections (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTrackSelections);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTrackSelections;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray CurrentTrackSelections {
			get {
				if (id_getCurrentTrackSelections == IntPtr.Zero)
					id_getCurrentTrackSelections = JNIEnv.GetMethodID (class_ref, "getCurrentTrackSelections", "()Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTrackSelections), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentWindowIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentWindowIndexHandler ()
		{
			if (cb_getCurrentWindowIndex == null)
				cb_getCurrentWindowIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentWindowIndex);
			return cb_getCurrentWindowIndex;
		}

		static int n_GetCurrentWindowIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentWindowIndex;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentWindowIndex;
		public unsafe int CurrentWindowIndex {
			get {
				if (id_getCurrentWindowIndex == IntPtr.Zero)
					id_getCurrentWindowIndex = JNIEnv.GetMethodID (class_ref, "getCurrentWindowIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentWindowIndex);
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public unsafe long Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		IntPtr id_hasNext;
		public unsafe bool HasNext {
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
			}
		}

		static Delegate cb_hasPrevious;
#pragma warning disable 0169
		static Delegate GetHasPreviousHandler ()
		{
			if (cb_hasPrevious == null)
				cb_hasPrevious = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasPrevious);
			return cb_hasPrevious;
		}

		static bool n_HasPrevious (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrevious;
		}
#pragma warning restore 0169

		IntPtr id_hasPrevious;
		public unsafe bool HasPrevious {
			get {
				if (id_hasPrevious == IntPtr.Zero)
					id_hasPrevious = JNIEnv.GetMethodID (class_ref, "hasPrevious", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPrevious);
			}
		}

		static Delegate cb_isCurrentWindowDynamic;
#pragma warning disable 0169
		static Delegate GetIsCurrentWindowDynamicHandler ()
		{
			if (cb_isCurrentWindowDynamic == null)
				cb_isCurrentWindowDynamic = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentWindowDynamic);
			return cb_isCurrentWindowDynamic;
		}

		static bool n_IsCurrentWindowDynamic (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentWindowDynamic;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentWindowDynamic;
		public unsafe bool IsCurrentWindowDynamic {
			get {
				if (id_isCurrentWindowDynamic == IntPtr.Zero)
					id_isCurrentWindowDynamic = JNIEnv.GetMethodID (class_ref, "isCurrentWindowDynamic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentWindowDynamic);
			}
		}

		static Delegate cb_isCurrentWindowLive;
#pragma warning disable 0169
		static Delegate GetIsCurrentWindowLiveHandler ()
		{
			if (cb_isCurrentWindowLive == null)
				cb_isCurrentWindowLive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentWindowLive);
			return cb_isCurrentWindowLive;
		}

		static bool n_IsCurrentWindowLive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentWindowLive;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentWindowLive;
		public unsafe bool IsCurrentWindowLive {
			get {
				if (id_isCurrentWindowLive == IntPtr.Zero)
					id_isCurrentWindowLive = JNIEnv.GetMethodID (class_ref, "isCurrentWindowLive", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentWindowLive);
			}
		}

		static Delegate cb_isCurrentWindowSeekable;
#pragma warning disable 0169
		static Delegate GetIsCurrentWindowSeekableHandler ()
		{
			if (cb_isCurrentWindowSeekable == null)
				cb_isCurrentWindowSeekable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentWindowSeekable);
			return cb_isCurrentWindowSeekable;
		}

		static bool n_IsCurrentWindowSeekable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentWindowSeekable;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentWindowSeekable;
		public unsafe bool IsCurrentWindowSeekable {
			get {
				if (id_isCurrentWindowSeekable == IntPtr.Zero)
					id_isCurrentWindowSeekable = JNIEnv.GetMethodID (class_ref, "isCurrentWindowSeekable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentWindowSeekable);
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		IntPtr id_isLoading;
		public unsafe bool IsLoading {
			get {
				if (id_isLoading == IntPtr.Zero)
					id_isLoading = JNIEnv.GetMethodID (class_ref, "isLoading", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoading);
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		IntPtr id_isPlaying;
		public unsafe bool IsPlaying {
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
			}
		}

		static Delegate cb_isPlayingAd;
#pragma warning disable 0169
		static Delegate GetIsPlayingAdHandler ()
		{
			if (cb_isPlayingAd == null)
				cb_isPlayingAd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPlayingAd);
			return cb_isPlayingAd;
		}

		static bool n_IsPlayingAd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlayingAd;
		}
#pragma warning restore 0169

		IntPtr id_isPlayingAd;
		public unsafe bool IsPlayingAd {
			get {
				if (id_isPlayingAd == IntPtr.Zero)
					id_isPlayingAd = JNIEnv.GetMethodID (class_ref, "isPlayingAd", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlayingAd);
			}
		}

		static Delegate cb_getMetadataComponent;
#pragma warning disable 0169
		static Delegate GetGetMetadataComponentHandler ()
		{
			if (cb_getMetadataComponent == null)
				cb_getMetadataComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMetadataComponent);
			return cb_getMetadataComponent;
		}

		static IntPtr n_GetMetadataComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MetadataComponent);
		}
#pragma warning restore 0169

		IntPtr id_getMetadataComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent MetadataComponent {
			get {
				if (id_getMetadataComponent == IntPtr.Zero)
					id_getMetadataComponent = JNIEnv.GetMethodID (class_ref, "getMetadataComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadataComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNextWindowIndex;
#pragma warning disable 0169
		static Delegate GetGetNextWindowIndexHandler ()
		{
			if (cb_getNextWindowIndex == null)
				cb_getNextWindowIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNextWindowIndex);
			return cb_getNextWindowIndex;
		}

		static int n_GetNextWindowIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextWindowIndex;
		}
#pragma warning restore 0169

		IntPtr id_getNextWindowIndex;
		public unsafe int NextWindowIndex {
			get {
				if (id_getNextWindowIndex == IntPtr.Zero)
					id_getNextWindowIndex = JNIEnv.GetMethodID (class_ref, "getNextWindowIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNextWindowIndex);
			}
		}

		static Delegate cb_getPlayWhenReady;
#pragma warning disable 0169
		static Delegate GetGetPlayWhenReadyHandler ()
		{
			if (cb_getPlayWhenReady == null)
				cb_getPlayWhenReady = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetPlayWhenReady);
			return cb_getPlayWhenReady;
		}

		static bool n_GetPlayWhenReady (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayWhenReady;
		}
#pragma warning restore 0169

		static Delegate cb_setPlayWhenReady_Z;
#pragma warning disable 0169
		static Delegate GetSetPlayWhenReady_ZHandler ()
		{
			if (cb_setPlayWhenReady_Z == null)
				cb_setPlayWhenReady_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPlayWhenReady_Z);
			return cb_setPlayWhenReady_Z;
		}

		static void n_SetPlayWhenReady_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayWhenReady = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlayWhenReady;
		IntPtr id_setPlayWhenReady_Z;
		public unsafe bool PlayWhenReady {
			get {
				if (id_getPlayWhenReady == IntPtr.Zero)
					id_getPlayWhenReady = JNIEnv.GetMethodID (class_ref, "getPlayWhenReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getPlayWhenReady);
			}
			set {
				if (id_setPlayWhenReady_Z == IntPtr.Zero)
					id_setPlayWhenReady_Z = JNIEnv.GetMethodID (class_ref, "setPlayWhenReady", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayWhenReady_Z, __args);
			}
		}

		static Delegate cb_getPlaybackError;
#pragma warning disable 0169
		static Delegate GetGetPlaybackErrorHandler ()
		{
			if (cb_getPlaybackError == null)
				cb_getPlaybackError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlaybackError);
			return cb_getPlaybackError;
		}

		static IntPtr n_GetPlaybackError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaybackError);
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackError;
		public unsafe global::Java.Lang.Exception PlaybackError {
			get {
				if (id_getPlaybackError == IntPtr.Zero)
					id_getPlaybackError = JNIEnv.GetMethodID (class_ref, "getPlaybackError", "()Ljava/lang/Exception;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlaybackParameters;
#pragma warning disable 0169
		static Delegate GetGetPlaybackParametersHandler ()
		{
			if (cb_getPlaybackParameters == null)
				cb_getPlaybackParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlaybackParameters);
			return cb_getPlaybackParameters;
		}

		static IntPtr n_GetPlaybackParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaybackParameters);
		}
#pragma warning restore 0169

		static Delegate cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
#pragma warning disable 0169
		static Delegate GetSetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler ()
		{
			if (cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == null)
				cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_);
			return cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
		}

		static void n_SetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlaybackParameters = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackParameters;
		IntPtr id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			get {
				if (id_getPlaybackParameters == IntPtr.Zero)
					id_getPlaybackParameters = JNIEnv.GetMethodID (class_ref, "getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackParameters), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == IntPtr.Zero)
					id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNIEnv.GetMethodID (class_ref, "setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_, __args);
			}
		}

		static Delegate cb_getPlaybackState;
#pragma warning disable 0169
		static Delegate GetGetPlaybackStateHandler ()
		{
			if (cb_getPlaybackState == null)
				cb_getPlaybackState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPlaybackState);
			return cb_getPlaybackState;
		}

		static int n_GetPlaybackState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlaybackState;
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackState;
		public unsafe int PlaybackState {
			get {
				if (id_getPlaybackState == IntPtr.Zero)
					id_getPlaybackState = JNIEnv.GetMethodID (class_ref, "getPlaybackState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackState);
			}
		}

		static Delegate cb_getPlaybackSuppressionReason;
#pragma warning disable 0169
		static Delegate GetGetPlaybackSuppressionReasonHandler ()
		{
			if (cb_getPlaybackSuppressionReason == null)
				cb_getPlaybackSuppressionReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPlaybackSuppressionReason);
			return cb_getPlaybackSuppressionReason;
		}

		static int n_GetPlaybackSuppressionReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlaybackSuppressionReason;
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackSuppressionReason;
		public unsafe int PlaybackSuppressionReason {
			get {
				if (id_getPlaybackSuppressionReason == IntPtr.Zero)
					id_getPlaybackSuppressionReason = JNIEnv.GetMethodID (class_ref, "getPlaybackSuppressionReason", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackSuppressionReason);
			}
		}

		static Delegate cb_getPreviousWindowIndex;
#pragma warning disable 0169
		static Delegate GetGetPreviousWindowIndexHandler ()
		{
			if (cb_getPreviousWindowIndex == null)
				cb_getPreviousWindowIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPreviousWindowIndex);
			return cb_getPreviousWindowIndex;
		}

		static int n_GetPreviousWindowIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousWindowIndex;
		}
#pragma warning restore 0169

		IntPtr id_getPreviousWindowIndex;
		public unsafe int PreviousWindowIndex {
			get {
				if (id_getPreviousWindowIndex == IntPtr.Zero)
					id_getPreviousWindowIndex = JNIEnv.GetMethodID (class_ref, "getPreviousWindowIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreviousWindowIndex);
			}
		}

		static Delegate cb_getRendererCount;
#pragma warning disable 0169
		static Delegate GetGetRendererCountHandler ()
		{
			if (cb_getRendererCount == null)
				cb_getRendererCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRendererCount);
			return cb_getRendererCount;
		}

		static int n_GetRendererCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RendererCount;
		}
#pragma warning restore 0169

		IntPtr id_getRendererCount;
		public unsafe int RendererCount {
			get {
				if (id_getRendererCount == IntPtr.Zero)
					id_getRendererCount = JNIEnv.GetMethodID (class_ref, "getRendererCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRendererCount);
			}
		}

		static Delegate cb_getRepeatMode;
#pragma warning disable 0169
		static Delegate GetGetRepeatModeHandler ()
		{
			if (cb_getRepeatMode == null)
				cb_getRepeatMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRepeatMode);
			return cb_getRepeatMode;
		}

		static int n_GetRepeatMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatMode;
		}
#pragma warning restore 0169

		static Delegate cb_setRepeatMode_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatMode_IHandler ()
		{
			if (cb_setRepeatMode_I == null)
				cb_setRepeatMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRepeatMode_I);
			return cb_setRepeatMode_I;
		}

		static void n_SetRepeatMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RepeatMode = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRepeatMode;
		IntPtr id_setRepeatMode_I;
		public unsafe int RepeatMode {
			get {
				if (id_getRepeatMode == IntPtr.Zero)
					id_getRepeatMode = JNIEnv.GetMethodID (class_ref, "getRepeatMode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRepeatMode);
			}
			set {
				if (id_setRepeatMode_I == IntPtr.Zero)
					id_setRepeatMode_I = JNIEnv.GetMethodID (class_ref, "setRepeatMode", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRepeatMode_I, __args);
			}
		}

		static Delegate cb_getShuffleModeEnabled;
#pragma warning disable 0169
		static Delegate GetGetShuffleModeEnabledHandler ()
		{
			if (cb_getShuffleModeEnabled == null)
				cb_getShuffleModeEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetShuffleModeEnabled);
			return cb_getShuffleModeEnabled;
		}

		static bool n_GetShuffleModeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShuffleModeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setShuffleModeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetShuffleModeEnabled_ZHandler ()
		{
			if (cb_setShuffleModeEnabled_Z == null)
				cb_setShuffleModeEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShuffleModeEnabled_Z);
			return cb_setShuffleModeEnabled_Z;
		}

		static void n_SetShuffleModeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShuffleModeEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_getShuffleModeEnabled;
		IntPtr id_setShuffleModeEnabled_Z;
		public unsafe bool ShuffleModeEnabled {
			get {
				if (id_getShuffleModeEnabled == IntPtr.Zero)
					id_getShuffleModeEnabled = JNIEnv.GetMethodID (class_ref, "getShuffleModeEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getShuffleModeEnabled);
			}
			set {
				if (id_setShuffleModeEnabled_Z == IntPtr.Zero)
					id_setShuffleModeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setShuffleModeEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShuffleModeEnabled_Z, __args);
			}
		}

		static Delegate cb_getTextComponent;
#pragma warning disable 0169
		static Delegate GetGetTextComponentHandler ()
		{
			if (cb_getTextComponent == null)
				cb_getTextComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTextComponent);
			return cb_getTextComponent;
		}

		static IntPtr n_GetTextComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextComponent);
		}
#pragma warning restore 0169

		IntPtr id_getTextComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent TextComponent {
			get {
				if (id_getTextComponent == IntPtr.Zero)
					id_getTextComponent = JNIEnv.GetMethodID (class_ref, "getTextComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTotalBufferedDuration;
#pragma warning disable 0169
		static Delegate GetGetTotalBufferedDurationHandler ()
		{
			if (cb_getTotalBufferedDuration == null)
				cb_getTotalBufferedDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTotalBufferedDuration);
			return cb_getTotalBufferedDuration;
		}

		static long n_GetTotalBufferedDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalBufferedDuration;
		}
#pragma warning restore 0169

		IntPtr id_getTotalBufferedDuration;
		public unsafe long TotalBufferedDuration {
			get {
				if (id_getTotalBufferedDuration == IntPtr.Zero)
					id_getTotalBufferedDuration = JNIEnv.GetMethodID (class_ref, "getTotalBufferedDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTotalBufferedDuration);
			}
		}

		static Delegate cb_getVideoComponent;
#pragma warning disable 0169
		static Delegate GetGetVideoComponentHandler ()
		{
			if (cb_getVideoComponent == null)
				cb_getVideoComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoComponent);
			return cb_getVideoComponent;
		}

		static IntPtr n_GetVideoComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoComponent);
		}
#pragma warning restore 0169

		IntPtr id_getVideoComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent VideoComponent {
			get {
				if (id_getVideoComponent == IntPtr.Zero)
					id_getVideoComponent = JNIEnv.GetMethodID (class_ref, "getVideoComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_Handler ()
		{
			if (cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == null)
				cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_);
			return cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		}

		static void n_AddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		public unsafe void AddListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener p0)
		{
			if (id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == IntPtr.Zero)
				id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_, __args);
		}

		static Delegate cb_getRendererType_I;
#pragma warning disable 0169
		static Delegate GetGetRendererType_IHandler ()
		{
			if (cb_getRendererType_I == null)
				cb_getRendererType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRendererType_I);
			return cb_getRendererType_I;
		}

		static int n_GetRendererType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRendererType (p0);
		}
#pragma warning restore 0169

		IntPtr id_getRendererType_I;
		public unsafe int GetRendererType (int p0)
		{
			if (id_getRendererType_I == IntPtr.Zero)
				id_getRendererType_I = JNIEnv.GetMethodID (class_ref, "getRendererType", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRendererType_I, __args);
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Next);
			return cb_next;
		}

		static void n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next ();
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe void Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_next);
		}

		static Delegate cb_previous;
#pragma warning disable 0169
		static Delegate GetPreviousHandler ()
		{
			if (cb_previous == null)
				cb_previous = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Previous);
			return cb_previous;
		}

		static void n_Previous (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Previous ();
		}
#pragma warning restore 0169

		IntPtr id_previous;
		public unsafe void Previous ()
		{
			if (id_previous == IntPtr.Zero)
				id_previous = JNIEnv.GetMethodID (class_ref, "previous", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_previous);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_Handler ()
		{
			if (cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == null)
				cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_);
			return cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		}

		static void n_RemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		public unsafe void RemoveListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener p0)
		{
			if (id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == IntPtr.Zero)
				id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_, __args);
		}

		static Delegate cb_seekTo_IJ;
#pragma warning disable 0169
		static Delegate GetSeekTo_IJHandler ()
		{
			if (cb_seekTo_IJ == null)
				cb_seekTo_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_V) n_SeekTo_IJ);
			return cb_seekTo_IJ;
		}

		static void n_SeekTo_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_IJ;
		public unsafe void SeekTo (int p0, long p1)
		{
			if (id_seekTo_IJ == IntPtr.Zero)
				id_seekTo_IJ = JNIEnv.GetMethodID (class_ref, "seekTo", "(IJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_IJ, __args);
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static void n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_J;
		public unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
		}

		static Delegate cb_seekToDefaultPosition;
#pragma warning disable 0169
		static Delegate GetSeekToDefaultPositionHandler ()
		{
			if (cb_seekToDefaultPosition == null)
				cb_seekToDefaultPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SeekToDefaultPosition);
			return cb_seekToDefaultPosition;
		}

		static void n_SeekToDefaultPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekToDefaultPosition ();
		}
#pragma warning restore 0169

		IntPtr id_seekToDefaultPosition;
		public unsafe void SeekToDefaultPosition ()
		{
			if (id_seekToDefaultPosition == IntPtr.Zero)
				id_seekToDefaultPosition = JNIEnv.GetMethodID (class_ref, "seekToDefaultPosition", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekToDefaultPosition);
		}

		static Delegate cb_seekToDefaultPosition_I;
#pragma warning disable 0169
		static Delegate GetSeekToDefaultPosition_IHandler ()
		{
			if (cb_seekToDefaultPosition_I == null)
				cb_seekToDefaultPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SeekToDefaultPosition_I);
			return cb_seekToDefaultPosition_I;
		}

		static void n_SeekToDefaultPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekToDefaultPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekToDefaultPosition_I;
		public unsafe void SeekToDefaultPosition (int p0)
		{
			if (id_seekToDefaultPosition_I == IntPtr.Zero)
				id_seekToDefaultPosition_I = JNIEnv.GetMethodID (class_ref, "seekToDefaultPosition", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekToDefaultPosition_I, __args);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

		static Delegate cb_stop_Z;
#pragma warning disable 0169
		static Delegate GetStop_ZHandler ()
		{
			if (cb_stop_Z == null)
				cb_stop_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Stop_Z);
			return cb_stop_Z;
		}

		static void n_Stop_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IWowPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop (p0);
		}
#pragma warning restore 0169

		IntPtr id_stop_Z;
		public unsafe void Stop (bool p0)
		{
			if (id_stop_Z == IntPtr.Zero)
				id_stop_Z = JNIEnv.GetMethodID (class_ref, "stop", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop_Z, __args);
		}

	}
}
