using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer", DoNotGenerateAcw=true)]
	public partial class MediaCodecVideoRenderer : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.CodecMaxValues']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$CodecMaxValues", DoNotGenerateAcw=true)]
		protected internal sealed partial class CodecMaxValues : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.CodecMaxValues']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					const string __id = "height.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "height.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.CodecMaxValues']/field[@name='inputSize']"
			[Register ("inputSize")]
			public int InputSize {
				get {
					const string __id = "inputSize.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "inputSize.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.CodecMaxValues']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					const string __id = "width.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "width.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$CodecMaxValues", typeof (CodecMaxValues));

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

			internal CodecMaxValues (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.CodecMaxValues']/constructor[@name='MediaCodecVideoRenderer.CodecMaxValues' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe CodecMaxValues (int width, int height, int inputSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (inputSize);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.VideoDecoderException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$VideoDecoderException", DoNotGenerateAcw=true)]
		public sealed partial class VideoDecoderException : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer.DecoderException {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.VideoDecoderException']/field[@name='isSurfaceValid']"
			[Register ("isSurfaceValid")]
			public bool IsSurfaceValid {
				get {
					const string __id = "isSurfaceValid.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isSurfaceValid.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.VideoDecoderException']/field[@name='surfaceIdentityHashCode']"
			[Register ("surfaceIdentityHashCode")]
			public int SurfaceIdentityHashCode {
				get {
					const string __id = "surfaceIdentityHashCode.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "surfaceIdentityHashCode.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$VideoDecoderException", typeof (VideoDecoderException));

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

			internal VideoDecoderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer.VideoDecoderException']/constructor[@name='MediaCodecVideoRenderer.VideoDecoderException' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[3][@type='android.view.Surface']]"
			[Register (".ctor", "(Ljava/lang/Throwable;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/view/Surface;)V", "")]
			public unsafe VideoDecoderException (global::Java.Lang.Throwable cause, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo, global::Android.Views.Surface surface) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Throwable;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/view/Surface;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					__args [1] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
					__args [2] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (cause);
					global::System.GC.KeepAlive (codecInfo);
					global::System.GC.KeepAlive (surface);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer", typeof (MediaCodecVideoRenderer));

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

		protected MediaCodecVideoRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/constructor[@name='MediaCodecVideoRenderer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;)V", "")]
		public unsafe MediaCodecVideoRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/constructor[@name='MediaCodecVideoRenderer' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;J)V", "")]
		public unsafe MediaCodecVideoRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, long allowedJoiningTimeMs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue (allowedJoiningTimeMs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/constructor[@name='MediaCodecVideoRenderer' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='long'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V", "")]
		public unsafe MediaCodecVideoRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, long allowedJoiningTimeMs, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener eventListener, int maxDroppedFramesToNotify) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue (allowedJoiningTimeMs);
				__args [3] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [4] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [5] = new JniArgumentValue (maxDroppedFramesToNotify);
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/constructor[@name='MediaCodecVideoRenderer' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='long'] and parameter[4][@type='boolean'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V", "")]
		public unsafe MediaCodecVideoRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, long allowedJoiningTimeMs, bool enableDecoderFallback, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener eventListener, int maxDroppedFramesToNotify) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue (allowedJoiningTimeMs);
				__args [3] = new JniArgumentValue (enableDecoderFallback);
				__args [4] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [5] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [6] = new JniArgumentValue (maxDroppedFramesToNotify);
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/constructor[@name='MediaCodecVideoRenderer' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='long'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='android.os.Handler'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JLcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecVideoRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, long allowedJoiningTimeMs, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener eventListener, int maxDroppedFramesToNotify) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JLcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue (allowedJoiningTimeMs);
				__args [3] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [4] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [5] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [6] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [7] = new JniArgumentValue (maxDroppedFramesToNotify);
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/constructor[@name='MediaCodecVideoRenderer' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='long'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='android.os.Handler'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[9][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JLcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MediaCodecVideoRenderer (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, long allowedJoiningTimeMs, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener eventListener, int maxDroppedFramesToNotify) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;JLcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue (allowedJoiningTimeMs);
				__args [3] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [4] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [5] = new JniArgumentValue (enableDecoderFallback);
				__args [6] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [7] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [8] = new JniArgumentValue (maxDroppedFramesToNotify);
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

		static Delegate cb_getOutputStreamOffsetUs;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamOffsetUsHandler ()
		{
			if (cb_getOutputStreamOffsetUs == null)
				cb_getOutputStreamOffsetUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetOutputStreamOffsetUs);
			return cb_getOutputStreamOffsetUs;
		}

		static long n_GetOutputStreamOffsetUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputStreamOffsetUs;
		}
#pragma warning restore 0169

		protected virtual unsafe long OutputStreamOffsetUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='getOutputStreamOffsetUs' and count(parameter)=0]"
			[Register ("getOutputStreamOffsetUs", "()J", "GetGetOutputStreamOffsetUsHandler")]
			get {
				const string __id = "getOutputStreamOffsetUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSurface;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHandler ()
		{
			if (cb_getSurface == null)
				cb_getSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurface);
			return cb_getSurface;
		}

		static IntPtr n_GetSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get {
				const string __id = "getSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_codecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCodecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_Handler ()
		{
			if (cb_codecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_ == null)
				cb_codecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CodecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_);
			return cb_codecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_;
		}

		static bool n_CodecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CodecNeedsSetOutputSurfaceWorkaround (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='codecNeedsSetOutputSurfaceWorkaround' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("codecNeedsSetOutputSurfaceWorkaround", "(Ljava/lang/String;)Z", "GetCodecNeedsSetOutputSurfaceWorkaround_Ljava_lang_String_Handler")]
		protected virtual unsafe bool CodecNeedsSetOutputSurfaceWorkaround (string name)
		{
			const string __id = "codecNeedsSetOutputSurfaceWorkaround.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var crypto = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCrypto> (native_crypto, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureCodec (codecInfo, codec, format, crypto, codecOperatingRate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='configureCodec' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[2][@type='android.media.MediaCodec'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='android.media.MediaCrypto'] and parameter[5][@type='float']]"
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

		static Delegate cb_dropOutputBuffer_Landroid_media_MediaCodec_IJ;
#pragma warning disable 0169
		static Delegate GetDropOutputBuffer_Landroid_media_MediaCodec_IJHandler ()
		{
			if (cb_dropOutputBuffer_Landroid_media_MediaCodec_IJ == null)
				cb_dropOutputBuffer_Landroid_media_MediaCodec_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJ_V) n_DropOutputBuffer_Landroid_media_MediaCodec_IJ);
			return cb_dropOutputBuffer_Landroid_media_MediaCodec_IJ;
		}

		static void n_DropOutputBuffer_Landroid_media_MediaCodec_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, int index, long presentationTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			__this.DropOutputBuffer (codec, index, presentationTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='dropOutputBuffer' and count(parameter)=3 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("dropOutputBuffer", "(Landroid/media/MediaCodec;IJ)V", "GetDropOutputBuffer_Landroid_media_MediaCodec_IJHandler")]
		protected virtual unsafe void DropOutputBuffer (global::Android.Media.MediaCodec codec, int index, long presentationTimeUs)
		{
			const string __id = "dropOutputBuffer.(Landroid/media/MediaCodec;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue (index);
				__args [2] = new JniArgumentValue (presentationTimeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codec);
			}
		}

		static Delegate cb_getCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetGetCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_getCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_getCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_getCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static IntPtr n_GetCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codecInfo, IntPtr native_format, IntPtr native_streamFormats)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var streamFormats = (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (native_streamFormats, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCodecMaxValues (codecInfo, format, streamFormats));
			if (streamFormats != null)
				JNIEnv.CopyArray (streamFormats, native_streamFormats);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='getCodecMaxValues' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format[]']]"
		[Register ("getCodecMaxValues", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Lcom/example/androidtvlibrary/main/adapter/Format;[Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$CodecMaxValues;", "GetGetCodecMaxValues_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer.CodecMaxValues GetCodecMaxValues (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] streamFormats)
		{
			const string __id = "getCodecMaxValues.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Lcom/example/androidtvlibrary/main/adapter/Format;[Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$CodecMaxValues;";
			IntPtr native_streamFormats = JNIEnv.NewArray (streamFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_streamFormats);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer.CodecMaxValues> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.ToLocalJniHandle (__this.GetDecoderInfos (mediaCodecSelector, format, requiresSecureDecoder));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='getDecoderInfos' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='boolean']]"
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

		static Delegate cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZI;
#pragma warning disable 0169
		static Delegate GetGetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZIHandler ()
		{
			if (cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZI == null)
				cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLFZI_L) n_GetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZI);
			return cb_getMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZI;
		}

		static IntPtr n_GetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZI (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_codecMimeType, IntPtr native_codecMaxValues, float codecOperatingRate, bool deviceNeedsNoPostProcessWorkaround, int tunnelingAudioSessionId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var codecMimeType = JNIEnv.GetString (native_codecMimeType, JniHandleOwnership.DoNotTransfer);
			var codecMaxValues = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer.CodecMaxValues> (native_codecMaxValues, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMediaFormat (format, codecMimeType, codecMaxValues, codecOperatingRate, deviceNeedsNoPostProcessWorkaround, tunnelingAudioSessionId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='getMediaFormat' and count(parameter)=6 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecVideoRenderer.CodecMaxValues'] and parameter[4][@type='float'] and parameter[5][@type='boolean'] and parameter[6][@type='int']]"
		[Register ("getMediaFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$CodecMaxValues;FZI)Landroid/media/MediaFormat;", "GetGetMediaFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Ljava_lang_String_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecVideoRenderer_CodecMaxValues_FZIHandler")]
		protected virtual unsafe global::Android.Media.MediaFormat GetMediaFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, string codecMimeType, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer.CodecMaxValues codecMaxValues, float codecOperatingRate, bool deviceNeedsNoPostProcessWorkaround, int tunnelingAudioSessionId)
		{
			const string __id = "getMediaFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecVideoRenderer$CodecMaxValues;FZI)Landroid/media/MediaFormat;";
			IntPtr native_codecMimeType = JNIEnv.NewString (codecMimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_codecMimeType);
				__args [2] = new JniArgumentValue ((codecMaxValues == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecMaxValues).Handle);
				__args [3] = new JniArgumentValue (codecOperatingRate);
				__args [4] = new JniArgumentValue (deviceNeedsNoPostProcessWorkaround);
				__args [5] = new JniArgumentValue (tunnelingAudioSessionId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_codecMimeType);
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (codecMaxValues);
			}
		}

		static Delegate cb_maybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZ;
#pragma warning disable 0169
		static Delegate GetMaybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZHandler ()
		{
			if (cb_maybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZ == null)
				cb_maybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJJZ_Z) n_MaybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZ);
			return cb_maybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZ;
		}

		static bool n_MaybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, int index, long presentationTimeUs, long positionUs, bool treatDroppedBuffersAsSkipped)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MaybeDropBuffersToKeyframe (codec, index, presentationTimeUs, positionUs, treatDroppedBuffersAsSkipped);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='maybeDropBuffersToKeyframe' and count(parameter)=5 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='boolean']]"
		[Register ("maybeDropBuffersToKeyframe", "(Landroid/media/MediaCodec;IJJZ)Z", "GetMaybeDropBuffersToKeyframe_Landroid_media_MediaCodec_IJJZHandler")]
		protected virtual unsafe bool MaybeDropBuffersToKeyframe (global::Android.Media.MediaCodec codec, int index, long presentationTimeUs, long positionUs, bool treatDroppedBuffersAsSkipped)
		{
			const string __id = "maybeDropBuffersToKeyframe.(Landroid/media/MediaCodec;IJJZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue (index);
				__args [2] = new JniArgumentValue (presentationTimeUs);
				__args [3] = new JniArgumentValue (positionUs);
				__args [4] = new JniArgumentValue (treatDroppedBuffersAsSkipped);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (codec);
			}
		}

		static Delegate cb_onProcessedTunneledBuffer_J;
#pragma warning disable 0169
		static Delegate GetOnProcessedTunneledBuffer_JHandler ()
		{
			if (cb_onProcessedTunneledBuffer_J == null)
				cb_onProcessedTunneledBuffer_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnProcessedTunneledBuffer_J);
			return cb_onProcessedTunneledBuffer_J;
		}

		static void n_OnProcessedTunneledBuffer_J (IntPtr jnienv, IntPtr native__this, long presentationTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProcessedTunneledBuffer (presentationTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='onProcessedTunneledBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onProcessedTunneledBuffer", "(J)V", "GetOnProcessedTunneledBuffer_JHandler")]
		protected virtual unsafe void OnProcessedTunneledBuffer (long presentationTimeUs)
		{
			const string __id = "onProcessedTunneledBuffer.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (presentationTimeUs);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessOutputBuffer (positionUs, elapsedRealtimeUs, codec, buffer, bufferIndex, bufferFlags, bufferPresentationTimeUs, isDecodeOnlyBuffer, isLastBuffer, format);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='processOutputBuffer' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='android.media.MediaCodec'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='long'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='com.example.androidtvlibrary.main.adapter.Format']]"
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

		static Delegate cb_renderOutputBuffer_Landroid_media_MediaCodec_IJ;
#pragma warning disable 0169
		static Delegate GetRenderOutputBuffer_Landroid_media_MediaCodec_IJHandler ()
		{
			if (cb_renderOutputBuffer_Landroid_media_MediaCodec_IJ == null)
				cb_renderOutputBuffer_Landroid_media_MediaCodec_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJ_V) n_RenderOutputBuffer_Landroid_media_MediaCodec_IJ);
			return cb_renderOutputBuffer_Landroid_media_MediaCodec_IJ;
		}

		static void n_RenderOutputBuffer_Landroid_media_MediaCodec_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, int index, long presentationTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			__this.RenderOutputBuffer (codec, index, presentationTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='renderOutputBuffer' and count(parameter)=3 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("renderOutputBuffer", "(Landroid/media/MediaCodec;IJ)V", "GetRenderOutputBuffer_Landroid_media_MediaCodec_IJHandler")]
		protected virtual unsafe void RenderOutputBuffer (global::Android.Media.MediaCodec codec, int index, long presentationTimeUs)
		{
			const string __id = "renderOutputBuffer.(Landroid/media/MediaCodec;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue (index);
				__args [2] = new JniArgumentValue (presentationTimeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codec);
			}
		}

		static Delegate cb_renderOutputBufferV21_Landroid_media_MediaCodec_IJJ;
#pragma warning disable 0169
		static Delegate GetRenderOutputBufferV21_Landroid_media_MediaCodec_IJJHandler ()
		{
			if (cb_renderOutputBufferV21_Landroid_media_MediaCodec_IJJ == null)
				cb_renderOutputBufferV21_Landroid_media_MediaCodec_IJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJJ_V) n_RenderOutputBufferV21_Landroid_media_MediaCodec_IJJ);
			return cb_renderOutputBufferV21_Landroid_media_MediaCodec_IJJ;
		}

		static void n_RenderOutputBufferV21_Landroid_media_MediaCodec_IJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, int index, long presentationTimeUs, long releaseTimeNs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			__this.RenderOutputBufferV21 (codec, index, presentationTimeUs, releaseTimeNs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='renderOutputBufferV21' and count(parameter)=4 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("renderOutputBufferV21", "(Landroid/media/MediaCodec;IJJ)V", "GetRenderOutputBufferV21_Landroid_media_MediaCodec_IJJHandler")]
		protected virtual unsafe void RenderOutputBufferV21 (global::Android.Media.MediaCodec codec, int index, long presentationTimeUs, long releaseTimeNs)
		{
			const string __id = "renderOutputBufferV21.(Landroid/media/MediaCodec;IJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue (index);
				__args [2] = new JniArgumentValue (presentationTimeUs);
				__args [3] = new JniArgumentValue (releaseTimeNs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codec);
			}
		}

		static Delegate cb_shouldDropBuffersToKeyframe_JJZ;
#pragma warning disable 0169
		static Delegate GetShouldDropBuffersToKeyframe_JJZHandler ()
		{
			if (cb_shouldDropBuffersToKeyframe_JJZ == null)
				cb_shouldDropBuffersToKeyframe_JJZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJZ_Z) n_ShouldDropBuffersToKeyframe_JJZ);
			return cb_shouldDropBuffersToKeyframe_JJZ;
		}

		static bool n_ShouldDropBuffersToKeyframe_JJZ (IntPtr jnienv, IntPtr native__this, long earlyUs, long elapsedRealtimeUs, bool isLastBuffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldDropBuffersToKeyframe (earlyUs, elapsedRealtimeUs, isLastBuffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='shouldDropBuffersToKeyframe' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("shouldDropBuffersToKeyframe", "(JJZ)Z", "GetShouldDropBuffersToKeyframe_JJZHandler")]
		protected virtual unsafe bool ShouldDropBuffersToKeyframe (long earlyUs, long elapsedRealtimeUs, bool isLastBuffer)
		{
			const string __id = "shouldDropBuffersToKeyframe.(JJZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (earlyUs);
				__args [1] = new JniArgumentValue (elapsedRealtimeUs);
				__args [2] = new JniArgumentValue (isLastBuffer);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_shouldDropOutputBuffer_JJZ;
#pragma warning disable 0169
		static Delegate GetShouldDropOutputBuffer_JJZHandler ()
		{
			if (cb_shouldDropOutputBuffer_JJZ == null)
				cb_shouldDropOutputBuffer_JJZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJZ_Z) n_ShouldDropOutputBuffer_JJZ);
			return cb_shouldDropOutputBuffer_JJZ;
		}

		static bool n_ShouldDropOutputBuffer_JJZ (IntPtr jnienv, IntPtr native__this, long earlyUs, long elapsedRealtimeUs, bool isLastBuffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldDropOutputBuffer (earlyUs, elapsedRealtimeUs, isLastBuffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='shouldDropOutputBuffer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("shouldDropOutputBuffer", "(JJZ)Z", "GetShouldDropOutputBuffer_JJZHandler")]
		protected virtual unsafe bool ShouldDropOutputBuffer (long earlyUs, long elapsedRealtimeUs, bool isLastBuffer)
		{
			const string __id = "shouldDropOutputBuffer.(JJZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (earlyUs);
				__args [1] = new JniArgumentValue (elapsedRealtimeUs);
				__args [2] = new JniArgumentValue (isLastBuffer);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_shouldForceRenderOutputBuffer_JJ;
#pragma warning disable 0169
		static Delegate GetShouldForceRenderOutputBuffer_JJHandler ()
		{
			if (cb_shouldForceRenderOutputBuffer_JJ == null)
				cb_shouldForceRenderOutputBuffer_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_Z) n_ShouldForceRenderOutputBuffer_JJ);
			return cb_shouldForceRenderOutputBuffer_JJ;
		}

		static bool n_ShouldForceRenderOutputBuffer_JJ (IntPtr jnienv, IntPtr native__this, long earlyUs, long elapsedSinceLastRenderUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldForceRenderOutputBuffer (earlyUs, elapsedSinceLastRenderUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='shouldForceRenderOutputBuffer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("shouldForceRenderOutputBuffer", "(JJ)Z", "GetShouldForceRenderOutputBuffer_JJHandler")]
		protected virtual unsafe bool ShouldForceRenderOutputBuffer (long earlyUs, long elapsedSinceLastRenderUs)
		{
			const string __id = "shouldForceRenderOutputBuffer.(JJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (earlyUs);
				__args [1] = new JniArgumentValue (elapsedSinceLastRenderUs);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_skipOutputBuffer_Landroid_media_MediaCodec_IJ;
#pragma warning disable 0169
		static Delegate GetSkipOutputBuffer_Landroid_media_MediaCodec_IJHandler ()
		{
			if (cb_skipOutputBuffer_Landroid_media_MediaCodec_IJ == null)
				cb_skipOutputBuffer_Landroid_media_MediaCodec_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJ_V) n_SkipOutputBuffer_Landroid_media_MediaCodec_IJ);
			return cb_skipOutputBuffer_Landroid_media_MediaCodec_IJ;
		}

		static void n_SkipOutputBuffer_Landroid_media_MediaCodec_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, int index, long presentationTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			__this.SkipOutputBuffer (codec, index, presentationTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='skipOutputBuffer' and count(parameter)=3 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("skipOutputBuffer", "(Landroid/media/MediaCodec;IJ)V", "GetSkipOutputBuffer_Landroid_media_MediaCodec_IJHandler")]
		protected virtual unsafe void SkipOutputBuffer (global::Android.Media.MediaCodec codec, int index, long presentationTimeUs)
		{
			const string __id = "skipOutputBuffer.(Landroid/media/MediaCodec;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue (index);
				__args [2] = new JniArgumentValue (presentationTimeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codec);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			var drmSessionManager = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_drmSessionManager, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SupportsFormat (mediaCodecSelector, drmSessionManager, format);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='supportsFormat' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format']]"
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

		static Delegate cb_updateDroppedBufferCounters_I;
#pragma warning disable 0169
		static Delegate GetUpdateDroppedBufferCounters_IHandler ()
		{
			if (cb_updateDroppedBufferCounters_I == null)
				cb_updateDroppedBufferCounters_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateDroppedBufferCounters_I);
			return cb_updateDroppedBufferCounters_I;
		}

		static void n_UpdateDroppedBufferCounters_I (IntPtr jnienv, IntPtr native__this, int droppedBufferCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecVideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDroppedBufferCounters (droppedBufferCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecVideoRenderer']/method[@name='updateDroppedBufferCounters' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateDroppedBufferCounters", "(I)V", "GetUpdateDroppedBufferCounters_IHandler")]
		protected virtual unsafe void UpdateDroppedBufferCounters (int droppedBufferCount)
		{
			const string __id = "updateDroppedBufferCounters.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (droppedBufferCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
