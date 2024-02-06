using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecAudioRenderer", DoNotGenerateAcw=true)]
	public partial class MediaCodecAudioRenderer : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecAudioRenderer", typeof (MediaCodecAudioRenderer));

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

		protected MediaCodecAudioRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;)V", "")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='android.os.Handler'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;)V", "")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [3] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='boolean'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.player.AudioSink']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioSink;)V", "")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, bool enableDecoderFallback, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink audioSink) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioSink;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue (enableDecoderFallback);
				__args [3] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [4] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [5] = new JniArgumentValue ((audioSink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioSink).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (audioSink);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Z)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue (playClearSamplesWithoutKeys);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [4] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [5] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.player.AudioCapabilities'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor...']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities audioCapabilities, params global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] audioProcessors) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_audioProcessors = JNIEnv.NewArray (audioProcessors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [4] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [5] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [6] = new JniArgumentValue ((audioCapabilities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioCapabilities).Handle);
				__args [7] = new JniArgumentValue (native_audioProcessors);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (audioProcessors != null) {
					JNIEnv.CopyArray (native_audioProcessors, audioProcessors);
					JNIEnv.DeleteLocalRef (native_audioProcessors);
				}
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (audioCapabilities);
				global::System.GC.KeepAlive (audioProcessors);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.player.AudioSink']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioSink;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink audioSink) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioSink;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [4] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [5] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [6] = new JniArgumentValue ((audioSink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioSink).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (audioSink);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/constructor[@name='MediaCodecAudioRenderer' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='android.os.Handler'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.player.AudioSink']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioSink;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecAudioRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink audioSink) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioSink;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [4] = new JniArgumentValue (enableDecoderFallback);
				__args [5] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [6] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [7] = new JniArgumentValue ((audioSink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioSink).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (audioSink);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_playbackParameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var playbackParameters = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (native_playbackParameters, JniHandleOwnership.DoNotTransfer);
			__this.PlaybackParameters = playbackParameters;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='getPlaybackParameters' and count(parameter)=0]"
			[Register ("getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "GetGetPlaybackParametersHandler")]
			get {
				const string __id = "getPlaybackParameters.()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='setPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V", "GetSetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler")]
			set {
				const string __id = "setPlaybackParameters.(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPositionUs;
#pragma warning disable 0169
		static Delegate GetGetPositionUsHandler ()
		{
			if (cb_getPositionUs == null)
				cb_getPositionUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPositionUs);
			return cb_getPositionUs;
		}

		static long n_GetPositionUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositionUs;
		}
#pragma warning restore 0169

		public virtual unsafe long PositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='getPositionUs' and count(parameter)=0]"
			[Register ("getPositionUs", "()J", "GetGetPositionUsHandler")]
			get {
				const string __id = "getPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_allowPassthrough_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAllowPassthrough_ILjava_lang_String_Handler ()
		{
			if (cb_allowPassthrough_ILjava_lang_String_ == null)
				cb_allowPassthrough_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_AllowPassthrough_ILjava_lang_String_);
			return cb_allowPassthrough_ILjava_lang_String_;
		}

		static bool n_AllowPassthrough_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int channelCount, IntPtr native_mimeType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mimeType = JNIEnv.GetString (native_mimeType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AllowPassthrough (channelCount, mimeType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='allowPassthrough' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("allowPassthrough", "(ILjava/lang/String;)Z", "GetAllowPassthrough_ILjava_lang_String_Handler")]
		protected virtual unsafe bool AllowPassthrough (int channelCount, string mimeType)
		{
			const string __id = "allowPassthrough.(ILjava/lang/String;)Z";
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelCount);
				__args [1] = new JniArgumentValue (native_mimeType);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		static Delegate cb_canKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetCanKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_canKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_canKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_CanKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_canKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static bool n_CanKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldFormat, IntPtr native_newFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldFormat = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_oldFormat, JniHandleOwnership.DoNotTransfer);
			var newFormat = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_newFormat, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanKeepCodecWithFlush (oldFormat, newFormat);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='canKeepCodecWithFlush' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("canKeepCodecWithFlush", "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;)Z", "GetCanKeepCodecWithFlush_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected virtual unsafe bool CanKeepCodecWithFlush (global::Com.Example.Androidtvlibrary.Main.Adapter.Format oldFormat, global::Com.Example.Androidtvlibrary.Main.Adapter.Format newFormat)
		{
			const string __id = "canKeepCodecWithFlush.(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((oldFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldFormat).Handle);
				__args [1] = new JniArgumentValue ((newFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (oldFormat);
				global::System.GC.KeepAlive (newFormat);
			}
		}

		static Delegate cb_configureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F;
#pragma warning disable 0169
		static Delegate GetConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_FHandler ()
		{
			if (cb_configureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F == null)
				cb_configureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLF_V) n_ConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F);
			return cb_configureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F;
		}

		static void n_ConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F (IntPtr jnienv, IntPtr native__this, IntPtr native_codecInfo, IntPtr native_codec, IntPtr native_format, IntPtr native_crypto, float codecOperatingRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var crypto = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCrypto> (native_crypto, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureCodec (codecInfo, codec, format, crypto, codecOperatingRate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='configureCodec' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[2][@type='android.media.MediaCodec'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='android.media.MediaCrypto'] and parameter[5][@type='float']]"
		[Register ("configureCodec", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaCrypto;F)V", "GetConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_FHandler")]
		protected override unsafe void ConfigureCodec (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo, global::Android.Media.MediaCodec codec, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Android.Media.MediaCrypto crypto, float codecOperatingRate)
		{
			const string __id = "configureCodec.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaCrypto;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
				__args [1] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [3] = new JniArgumentValue ((crypto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) crypto).Handle);
				__args [4] = new JniArgumentValue (codecOperatingRate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codecInfo);
				global::System.GC.KeepAlive (codec);
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (crypto);
			}
		}

		static Delegate cb_getCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetGetCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_getCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_getCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_GetCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_getCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static int n_GetCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codecInfo, IntPtr native_format, IntPtr native_streamFormats)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var streamFormats = (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (native_streamFormats, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			int __ret = __this.GetCodecMaxInputSize (codecInfo, format, streamFormats);
			if (streamFormats != null)
				JNIEnv.CopyArray (streamFormats, native_streamFormats);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='getCodecMaxInputSize' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format[]']]"
		[Register ("getCodecMaxInputSize", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Lcom/example/androidtvlibrary/main/adapter/Format;[Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetGetCodecMaxInputSize_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected virtual unsafe int GetCodecMaxInputSize (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] streamFormats)
		{
			const string __id = "getCodecMaxInputSize.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Lcom/example/androidtvlibrary/main/adapter/Format;[Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			IntPtr native_streamFormats = JNIEnv.NewArray (streamFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_streamFormats);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (streamFormats != null) {
					JNIEnv.CopyArray (native_streamFormats, streamFormats);
					JNIEnv.DeleteLocalRef (native_streamFormats);
				}
				global::System.GC.KeepAlive (codecInfo);
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (streamFormats);
			}
		}

		static Delegate cb_getDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z;
#pragma warning disable 0169
		static Delegate GetGetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_ZHandler ()
		{
			if (cb_getDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z == null)
				cb_getDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_L) n_GetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z);
			return cb_getDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z;
		}

		static IntPtr n_GetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaCodecSelector, IntPtr native_format, bool requiresSecureDecoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.ToLocalJniHandle (__this.GetDecoderInfos (mediaCodecSelector, format, requiresSecureDecoder));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='getDecoderInfos' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='boolean']]"
		[Register ("getDecoderInfos", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Ljava/util/List;", "GetGetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_ZHandler")]
		protected override unsafe global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfos (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, bool requiresSecureDecoder)
		{
			const string __id = "getDecoderInfos.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (requiresSecureDecoder);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IF;
#pragma warning disable 0169
		static Delegate GetGetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IFHandler ()
		{
			if (cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IF == null)
				cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIF_L) n_GetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IF);
			return cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IF;
		}

		static IntPtr n_GetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_codecMimeType, int codecMaxInputSize, float codecOperatingRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var codecMimeType = JNIEnv.GetString (native_codecMimeType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMediaFormat (format, codecMimeType, codecMaxInputSize, codecOperatingRate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='getMediaFormat' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("getMediaFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/String;IF)Landroid/media/MediaFormat;", "GetGetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_IFHandler")]
		protected virtual unsafe global::Android.Media.MediaFormat GetMediaFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, string codecMimeType, int codecMaxInputSize, float codecOperatingRate)
		{
			const string __id = "getMediaFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/String;IF)Landroid/media/MediaFormat;";
			IntPtr native_codecMimeType = JNIEnv.NewString (codecMimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_codecMimeType);
				__args [2] = new JniArgumentValue (codecMaxInputSize);
				__args [3] = new JniArgumentValue (codecOperatingRate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_codecMimeType);
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_getPassthroughEncoding_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPassthroughEncoding_ILjava_lang_String_Handler ()
		{
			if (cb_getPassthroughEncoding_ILjava_lang_String_ == null)
				cb_getPassthroughEncoding_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_GetPassthroughEncoding_ILjava_lang_String_);
			return cb_getPassthroughEncoding_ILjava_lang_String_;
		}

		static int n_GetPassthroughEncoding_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int channelCount, IntPtr native_mimeType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mimeType = JNIEnv.GetString (native_mimeType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPassthroughEncoding (channelCount, mimeType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='getPassthroughEncoding' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPassthroughEncoding", "(ILjava/lang/String;)I", "GetGetPassthroughEncoding_ILjava_lang_String_Handler")]
		protected virtual unsafe int GetPassthroughEncoding (int channelCount, string mimeType)
		{
			const string __id = "getPassthroughEncoding.(ILjava/lang/String;)I";
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelCount);
				__args [1] = new JniArgumentValue (native_mimeType);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		static Delegate cb_onAudioSessionId_I;
#pragma warning disable 0169
		static Delegate GetOnAudioSessionId_IHandler ()
		{
			if (cb_onAudioSessionId_I == null)
				cb_onAudioSessionId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnAudioSessionId_I);
			return cb_onAudioSessionId_I;
		}

		static void n_OnAudioSessionId_I (IntPtr jnienv, IntPtr native__this, int audioSessionId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioSessionId (audioSessionId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='onAudioSessionId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAudioSessionId", "(I)V", "GetOnAudioSessionId_IHandler")]
		protected virtual unsafe void OnAudioSessionId (int audioSessionId)
		{
			const string __id = "onAudioSessionId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (audioSessionId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAudioTrackPositionDiscontinuity;
#pragma warning disable 0169
		static Delegate GetOnAudioTrackPositionDiscontinuityHandler ()
		{
			if (cb_onAudioTrackPositionDiscontinuity == null)
				cb_onAudioTrackPositionDiscontinuity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAudioTrackPositionDiscontinuity);
			return cb_onAudioTrackPositionDiscontinuity;
		}

		static void n_OnAudioTrackPositionDiscontinuity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioTrackPositionDiscontinuity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='onAudioTrackPositionDiscontinuity' and count(parameter)=0]"
		[Register ("onAudioTrackPositionDiscontinuity", "()V", "GetOnAudioTrackPositionDiscontinuityHandler")]
		protected virtual unsafe void OnAudioTrackPositionDiscontinuity ()
		{
			const string __id = "onAudioTrackPositionDiscontinuity.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onAudioTrackUnderrun_IJJ;
#pragma warning disable 0169
		static Delegate GetOnAudioTrackUnderrun_IJJHandler ()
		{
			if (cb_onAudioTrackUnderrun_IJJ == null)
				cb_onAudioTrackUnderrun_IJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJJ_V) n_OnAudioTrackUnderrun_IJJ);
			return cb_onAudioTrackUnderrun_IJJ;
		}

		static void n_OnAudioTrackUnderrun_IJJ (IntPtr jnienv, IntPtr native__this, int bufferSize, long bufferSizeMs, long elapsedSinceLastFeedMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioTrackUnderrun (bufferSize, bufferSizeMs, elapsedSinceLastFeedMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='onAudioTrackUnderrun' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onAudioTrackUnderrun", "(IJJ)V", "GetOnAudioTrackUnderrun_IJJHandler")]
		protected virtual unsafe void OnAudioTrackUnderrun (int bufferSize, long bufferSizeMs, long elapsedSinceLastFeedMs)
		{
			const string __id = "onAudioTrackUnderrun.(IJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (bufferSize);
				__args [1] = new JniArgumentValue (bufferSizeMs);
				__args [2] = new JniArgumentValue (elapsedSinceLastFeedMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_processOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_processOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_processOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJLLIIJZZL_Z) n_ProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_processOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static bool n_ProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, long positionUs, long elapsedRealtimeUs, IntPtr native_codec, IntPtr native_buffer, int bufferIndex, int bufferFlags, long bufferPresentationTimeUs, bool isDecodeOnlyBuffer, bool isLastBuffer, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessOutputBuffer (positionUs, elapsedRealtimeUs, codec, buffer, bufferIndex, bufferFlags, bufferPresentationTimeUs, isDecodeOnlyBuffer, isLastBuffer, format);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='processOutputBuffer' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='android.media.MediaCodec'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='long'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("processOutputBuffer", "(JJLandroid/media/MediaCodec;Ljava/nio/ByteBuffer;IIJZZLcom/example/androidtvlibrary/main/adapter/Format;)Z", "GetProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected override unsafe bool ProcessOutputBuffer (long positionUs, long elapsedRealtimeUs, global::Android.Media.MediaCodec codec, global::Java.Nio.ByteBuffer buffer, int bufferIndex, int bufferFlags, long bufferPresentationTimeUs, bool isDecodeOnlyBuffer, bool isLastBuffer, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "processOutputBuffer.(JJLandroid/media/MediaCodec;Ljava/nio/ByteBuffer;IIJZZLcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (elapsedRealtimeUs);
				__args [2] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [3] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [4] = new JniArgumentValue (bufferIndex);
				__args [5] = new JniArgumentValue (bufferFlags);
				__args [6] = new JniArgumentValue (bufferPresentationTimeUs);
				__args [7] = new JniArgumentValue (isDecodeOnlyBuffer);
				__args [8] = new JniArgumentValue (isLastBuffer);
				__args [9] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (codec);
				global::System.GC.KeepAlive (buffer);
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static int n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaCodecSelector, IntPtr native_drmSessionManager, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecAudioRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			var drmSessionManager = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_drmSessionManager, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SupportsFormat (mediaCodecSelector, drmSessionManager, format);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecAudioRenderer']/method[@name='supportsFormat' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected override unsafe int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "supportsFormat.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [1] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (format);
			}
		}

	}
}
