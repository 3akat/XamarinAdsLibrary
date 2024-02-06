using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer", DoNotGenerateAcw=true)]
	public abstract partial class MediaCodecRenderer : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/field[@name='CODEC_OPERATING_RATE_UNSET']"
		[Register ("CODEC_OPERATING_RATE_UNSET")]
		protected const float CodecOperatingRateUnset = (float) -1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/field[@name='decoderCounters']"
		[Register ("decoderCounters")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DecoderCounters DecoderCounters {
			get {
				const string __id = "decoderCounters.Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DecoderCounters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "decoderCounters.Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/field[@name='KEEP_CODEC_RESULT_NO']"
		[Register ("KEEP_CODEC_RESULT_NO")]
		protected const int KeepCodecResultNo = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/field[@name='KEEP_CODEC_RESULT_YES_WITHOUT_RECONFIGURATION']"
		[Register ("KEEP_CODEC_RESULT_YES_WITHOUT_RECONFIGURATION")]
		protected const int KeepCodecResultYesWithoutReconfiguration = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/field[@name='KEEP_CODEC_RESULT_YES_WITH_FLUSH']"
		[Register ("KEEP_CODEC_RESULT_YES_WITH_FLUSH")]
		protected const int KeepCodecResultYesWithFlush = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/field[@name='KEEP_CODEC_RESULT_YES_WITH_RECONFIGURATION']"
		[Register ("KEEP_CODEC_RESULT_YES_WITH_RECONFIGURATION")]
		protected const int KeepCodecResultYesWithReconfiguration = (int) 2;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderException", DoNotGenerateAcw=true)]
		public partial class DecoderException : global::Java.Lang.Exception {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderException']/field[@name='codecInfo']"
			[Register ("codecInfo")]
			public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo CodecInfo {
				get {
					const string __id = "codecInfo.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "codecInfo.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderException']/field[@name='diagnosticInfo']"
			[Register ("diagnosticInfo")]
			public string DiagnosticInfo {
				get {
					const string __id = "diagnosticInfo.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "diagnosticInfo.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderException", typeof (DecoderException));

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

			protected DecoderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderException']/constructor[@name='MediaCodecRenderer.DecoderException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo']]"
			[Register (".ctor", "(Ljava/lang/Throwable;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)V", "")]
			public unsafe DecoderException (global::Java.Lang.Throwable cause, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Throwable;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					__args [1] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (cause);
					global::System.GC.KeepAlive (codecInfo);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderInitializationException", DoNotGenerateAcw=true)]
		public partial class DecoderInitializationException : global::Java.Lang.Exception {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/field[@name='codecInfo']"
			[Register ("codecInfo")]
			public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo CodecInfo {
				get {
					const string __id = "codecInfo.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "codecInfo.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/field[@name='diagnosticInfo']"
			[Register ("diagnosticInfo")]
			public string DiagnosticInfo {
				get {
					const string __id = "diagnosticInfo.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "diagnosticInfo.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/field[@name='fallbackDecoderInitializationException']"
			[Register ("fallbackDecoderInitializationException")]
			public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer.DecoderInitializationException FallbackDecoderInitializationException {
				get {
					const string __id = "fallbackDecoderInitializationException.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderInitializationException;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer.DecoderInitializationException> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "fallbackDecoderInitializationException.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderInitializationException;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/field[@name='mimeType']"
			[Register ("mimeType")]
			public string MimeType {
				get {
					const string __id = "mimeType.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mimeType.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/field[@name='secureDecoderRequired']"
			[Register ("secureDecoderRequired")]
			public bool SecureDecoderRequired {
				get {
					const string __id = "secureDecoderRequired.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "secureDecoderRequired.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderInitializationException", typeof (DecoderInitializationException));

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

			protected DecoderInitializationException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/constructor[@name='MediaCodecRenderer.DecoderInitializationException' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='boolean'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/Throwable;ZLcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)V", "")]
			public unsafe DecoderInitializationException (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Java.Lang.Throwable cause, bool secureDecoderRequired, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo mediaCodecInfo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/Throwable;ZLcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
					__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					__args [2] = new JniArgumentValue (secureDecoderRequired);
					__args [3] = new JniArgumentValue ((mediaCodecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecInfo).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (format);
					global::System.GC.KeepAlive (cause);
					global::System.GC.KeepAlive (mediaCodecInfo);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer.DecoderInitializationException']/constructor[@name='MediaCodecRenderer.DecoderInitializationException' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/Throwable;ZI)V", "")]
			public unsafe DecoderInitializationException (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Java.Lang.Throwable cause, bool secureDecoderRequired, int errorCode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/Throwable;ZI)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
					__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					__args [2] = new JniArgumentValue (secureDecoderRequired);
					__args [3] = new JniArgumentValue (errorCode);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (format);
					global::System.GC.KeepAlive (cause);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer", typeof (MediaCodecRenderer));

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

		protected MediaCodecRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/constructor[@name='MediaCodecRenderer' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='float']]"
		[Register (".ctor", "(ILcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZF)V", "")]
		public unsafe MediaCodecRenderer (int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, float assumedMinimumCodecOperatingRate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (trackType);
				__args [1] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [4] = new JniArgumentValue (enableDecoderFallback);
				__args [5] = new JniArgumentValue (assumedMinimumCodecOperatingRate);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		protected unsafe global::Android.Media.MediaCodec Codec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getCodec' and count(parameter)=0]"
			[Register ("getCodec", "()Landroid/media/MediaCodec;", "")]
			get {
				const string __id = "getCodec.()Landroid/media/MediaCodec;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo CodecInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getCodecInfo' and count(parameter)=0]"
			[Register ("getCodecInfo", "()Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;", "")]
			get {
				const string __id = "getCodecInfo.()Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCodecNeedsEosPropagation;
#pragma warning disable 0169
		static Delegate GetGetCodecNeedsEosPropagationHandler ()
		{
			if (cb_getCodecNeedsEosPropagation == null)
				cb_getCodecNeedsEosPropagation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetCodecNeedsEosPropagation);
			return cb_getCodecNeedsEosPropagation;
		}

		static bool n_GetCodecNeedsEosPropagation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodecNeedsEosPropagation;
		}
#pragma warning restore 0169

		protected virtual unsafe bool CodecNeedsEosPropagation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getCodecNeedsEosPropagation' and count(parameter)=0]"
			[Register ("getCodecNeedsEosPropagation", "()Z", "GetGetCodecNeedsEosPropagationHandler")]
			get {
				const string __id = "getCodecNeedsEosPropagation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDequeueOutputBufferTimeoutUs;
#pragma warning disable 0169
		static Delegate GetGetDequeueOutputBufferTimeoutUsHandler ()
		{
			if (cb_getDequeueOutputBufferTimeoutUs == null)
				cb_getDequeueOutputBufferTimeoutUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDequeueOutputBufferTimeoutUs);
			return cb_getDequeueOutputBufferTimeoutUs;
		}

		static long n_GetDequeueOutputBufferTimeoutUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DequeueOutputBufferTimeoutUs;
		}
#pragma warning restore 0169

		protected virtual unsafe long DequeueOutputBufferTimeoutUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getDequeueOutputBufferTimeoutUs' and count(parameter)=0]"
			[Register ("getDequeueOutputBufferTimeoutUs", "()J", "GetGetDequeueOutputBufferTimeoutUsHandler")]
			get {
				const string __id = "getDequeueOutputBufferTimeoutUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnded;
#pragma warning disable 0169
		static Delegate GetIsEndedHandler ()
		{
			if (cb_isEnded == null)
				cb_isEnded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnded);
			return cb_isEnded;
		}

		static bool n_IsEnded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnded;
		}
#pragma warning restore 0169

		public override unsafe bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler")]
			get {
				const string __id = "isEnded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		public override unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				const string __id = "isReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_canKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetCanKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_canKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_canKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_I) n_CanKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_canKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static int n_CanKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, IntPtr native_codecInfo, IntPtr native_oldFormat, IntPtr native_newFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			var oldFormat = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_oldFormat, JniHandleOwnership.DoNotTransfer);
			var newFormat = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_newFormat, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CanKeepCodec (codec, codecInfo, oldFormat, newFormat);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='canKeepCodec' and count(parameter)=4 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("canKeepCodec", "(Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetCanKeepCodec_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Lcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected virtual unsafe int CanKeepCodec (global::Android.Media.MediaCodec codec, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Format oldFormat, global::Com.Example.Androidtvlibrary.Main.Adapter.Format newFormat)
		{
			const string __id = "canKeepCodec.(Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
				__args [2] = new JniArgumentValue ((oldFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldFormat).Handle);
				__args [3] = new JniArgumentValue ((newFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (codec);
				global::System.GC.KeepAlive (codecInfo);
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

		static void n_ConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, float p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCrypto> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureCodec (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='configureCodec' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[2][@type='android.media.MediaCodec'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='android.media.MediaCrypto'] and parameter[5][@type='float']]"
		[Register ("configureCodec", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaCrypto;F)V", "GetConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_FHandler")]
		protected abstract void ConfigureCodec (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo p0, global::Android.Media.MediaCodec p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2, global::Android.Media.MediaCrypto p3, float p4);

		static Delegate cb_createDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_;
#pragma warning disable 0169
		static Delegate GetCreateDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Handler ()
		{
			if (cb_createDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_ == null)
				cb_createDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_);
			return cb_createDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_;
		}

		static IntPtr n_CreateDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cause, IntPtr native_codecInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cause = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_cause, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDecoderException (cause, codecInfo));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='createDecoderException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo']]"
		[Register ("createDecoderException", "(Ljava/lang/Throwable;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderException;", "GetCreateDecoderException_Ljava_lang_Throwable_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer.DecoderException CreateDecoderException (global::Java.Lang.Throwable cause, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo)
		{
			const string __id = "createDecoderException.(Ljava/lang/Throwable;Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer$DecoderException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				__args [1] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer.DecoderException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cause);
				global::System.GC.KeepAlive (codecInfo);
			}
		}

		static Delegate cb_experimental_setRenderTimeLimitMs_J;
#pragma warning disable 0169
		static Delegate GetExperimental_setRenderTimeLimitMs_JHandler ()
		{
			if (cb_experimental_setRenderTimeLimitMs_J == null)
				cb_experimental_setRenderTimeLimitMs_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Experimental_setRenderTimeLimitMs_J);
			return cb_experimental_setRenderTimeLimitMs_J;
		}

		static void n_Experimental_setRenderTimeLimitMs_J (IntPtr jnienv, IntPtr native__this, long renderTimeLimitMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Experimental_setRenderTimeLimitMs (renderTimeLimitMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='experimental_setRenderTimeLimitMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("experimental_setRenderTimeLimitMs", "(J)V", "GetExperimental_setRenderTimeLimitMs_JHandler")]
		public virtual unsafe void Experimental_setRenderTimeLimitMs (long renderTimeLimitMs)
		{
			const string __id = "experimental_setRenderTimeLimitMs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (renderTimeLimitMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_experimental_setSkipMediaCodecStopOnRelease_Z;
#pragma warning disable 0169
		static Delegate GetExperimental_setSkipMediaCodecStopOnRelease_ZHandler ()
		{
			if (cb_experimental_setSkipMediaCodecStopOnRelease_Z == null)
				cb_experimental_setSkipMediaCodecStopOnRelease_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Experimental_setSkipMediaCodecStopOnRelease_Z);
			return cb_experimental_setSkipMediaCodecStopOnRelease_Z;
		}

		static void n_Experimental_setSkipMediaCodecStopOnRelease_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Experimental_setSkipMediaCodecStopOnRelease (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='experimental_setSkipMediaCodecStopOnRelease' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("experimental_setSkipMediaCodecStopOnRelease", "(Z)V", "GetExperimental_setSkipMediaCodecStopOnRelease_ZHandler")]
		public virtual unsafe void Experimental_setSkipMediaCodecStopOnRelease (bool enabled)
		{
			const string __id = "experimental_setSkipMediaCodecStopOnRelease.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='flushOrReinitializeCodec' and count(parameter)=0]"
		[Register ("flushOrReinitializeCodec", "()Z", "")]
		protected unsafe bool FlushOrReinitializeCodec ()
		{
			const string __id = "flushOrReinitializeCodec.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_flushOrReleaseCodec;
#pragma warning disable 0169
		static Delegate GetFlushOrReleaseCodecHandler ()
		{
			if (cb_flushOrReleaseCodec == null)
				cb_flushOrReleaseCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_FlushOrReleaseCodec);
			return cb_flushOrReleaseCodec;
		}

		static bool n_FlushOrReleaseCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlushOrReleaseCodec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='flushOrReleaseCodec' and count(parameter)=0]"
		[Register ("flushOrReleaseCodec", "()Z", "GetFlushOrReleaseCodecHandler")]
		protected virtual unsafe bool FlushOrReleaseCodec ()
		{
			const string __id = "flushOrReleaseCodec.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetGetCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_getCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_getCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFLL_F) n_GetCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_getCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static float n_GetCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, float operatingRate, IntPtr native_format, IntPtr native_streamFormats)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			var streamFormats = (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (native_streamFormats, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			float __ret = __this.GetCodecOperatingRateV23 (operatingRate, format, streamFormats);
			if (streamFormats != null)
				JNIEnv.CopyArray (streamFormats, native_streamFormats);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getCodecOperatingRateV23' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format[]']]"
		[Register ("getCodecOperatingRateV23", "(FLcom/example/androidtvlibrary/main/adapter/Format;[Lcom/example/androidtvlibrary/main/adapter/Format;)F", "GetGetCodecOperatingRateV23_FLcom_example_androidtvlibrary_main_adapter_Format_arrayLcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected virtual unsafe float GetCodecOperatingRateV23 (float operatingRate, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] streamFormats)
		{
			const string __id = "getCodecOperatingRateV23.(FLcom/example/androidtvlibrary/main/adapter/Format;[Lcom/example/androidtvlibrary/main/adapter/Format;)F";
			IntPtr native_streamFormats = JNIEnv.NewArray (streamFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (operatingRate);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (native_streamFormats);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				if (streamFormats != null) {
					JNIEnv.CopyArray (native_streamFormats, streamFormats);
					JNIEnv.DeleteLocalRef (native_streamFormats);
				}
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

		static IntPtr n_GetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.ToLocalJniHandle (__this.GetDecoderInfos (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getDecoderInfos' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='boolean']]"
		[Register ("getDecoderInfos", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Ljava/util/List;", "GetGetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_ZHandler")]
		protected abstract global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfos (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p1, bool p2);

		static Delegate cb_handleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_;
#pragma warning disable 0169
		static Delegate GetHandleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Handler ()
		{
			if (cb_handleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ == null)
				cb_handleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_HandleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_);
			return cb_handleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_;
		}

		static void n_HandleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.HandleInputBufferSupplementalData (buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='handleInputBufferSupplementalData' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DecoderInputBuffer']]"
		[Register ("handleInputBufferSupplementalData", "(Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;)V", "GetHandleInputBufferSupplementalData_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Handler")]
		protected virtual unsafe void HandleInputBufferSupplementalData (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer buffer)
		{
			const string __id = "handleInputBufferSupplementalData.(Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='maybeInitCodec' and count(parameter)=0]"
		[Register ("maybeInitCodec", "()V", "")]
		protected unsafe void MaybeInitCodec ()
		{
			const string __id = "maybeInitCodec.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCodecInitialized_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetOnCodecInitialized_Ljava_lang_String_JJHandler ()
		{
			if (cb_onCodecInitialized_Ljava_lang_String_JJ == null)
				cb_onCodecInitialized_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_V) n_OnCodecInitialized_Ljava_lang_String_JJ);
			return cb_onCodecInitialized_Ljava_lang_String_JJ;
		}

		static void n_OnCodecInitialized_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, long initializedTimestampMs, long initializationDurationMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.OnCodecInitialized (name, initializedTimestampMs, initializationDurationMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='onCodecInitialized' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onCodecInitialized", "(Ljava/lang/String;JJ)V", "GetOnCodecInitialized_Ljava_lang_String_JJHandler")]
		protected virtual unsafe void OnCodecInitialized (string name, long initializedTimestampMs, long initializationDurationMs)
		{
			const string __id = "onCodecInitialized.(Ljava/lang/String;JJ)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (initializedTimestampMs);
				__args [2] = new JniArgumentValue (initializationDurationMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_onInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_;
#pragma warning disable 0169
		static Delegate GetOnInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Handler ()
		{
			if (cb_onInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_ == null)
				cb_onInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_);
			return cb_onInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_;
		}

		static void n_OnInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_formatHolder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var formatHolder = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder> (native_formatHolder, JniHandleOwnership.DoNotTransfer);
			__this.OnInputFormatChanged (formatHolder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='onInputFormatChanged' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.FormatHolder']]"
		[Register ("onInputFormatChanged", "(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;)V", "GetOnInputFormatChanged_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Handler")]
		protected virtual unsafe void OnInputFormatChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder formatHolder)
		{
			const string __id = "onInputFormatChanged.(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((formatHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatHolder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (formatHolder);
			}
		}

		static Delegate cb_onOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetOnOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_onOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_ == null)
				cb_onOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_);
			return cb_onOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_;
		}

		static void n_OnOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec, IntPtr native_outputMediaFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			var outputMediaFormat = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_outputMediaFormat, JniHandleOwnership.DoNotTransfer);
			__this.OnOutputFormatChanged (codec, outputMediaFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='onOutputFormatChanged' and count(parameter)=2 and parameter[1][@type='android.media.MediaCodec'] and parameter[2][@type='android.media.MediaFormat']]"
		[Register ("onOutputFormatChanged", "(Landroid/media/MediaCodec;Landroid/media/MediaFormat;)V", "GetOnOutputFormatChanged_Landroid_media_MediaCodec_Landroid_media_MediaFormat_Handler")]
		protected virtual unsafe void OnOutputFormatChanged (global::Android.Media.MediaCodec codec, global::Android.Media.MediaFormat outputMediaFormat)
		{
			const string __id = "onOutputFormatChanged.(Landroid/media/MediaCodec;Landroid/media/MediaFormat;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [1] = new JniArgumentValue ((outputMediaFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMediaFormat).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codec);
				global::System.GC.KeepAlive (outputMediaFormat);
			}
		}

		static Delegate cb_onProcessedOutputBuffer_J;
#pragma warning disable 0169
		static Delegate GetOnProcessedOutputBuffer_JHandler ()
		{
			if (cb_onProcessedOutputBuffer_J == null)
				cb_onProcessedOutputBuffer_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnProcessedOutputBuffer_J);
			return cb_onProcessedOutputBuffer_J;
		}

		static void n_OnProcessedOutputBuffer_J (IntPtr jnienv, IntPtr native__this, long presentationTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProcessedOutputBuffer (presentationTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='onProcessedOutputBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onProcessedOutputBuffer", "(J)V", "GetOnProcessedOutputBuffer_JHandler")]
		protected virtual unsafe void OnProcessedOutputBuffer (long presentationTimeUs)
		{
			const string __id = "onProcessedOutputBuffer.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (presentationTimeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_;
#pragma warning disable 0169
		static Delegate GetOnQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Handler ()
		{
			if (cb_onQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ == null)
				cb_onQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_);
			return cb_onQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_;
		}

		static void n_OnQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.OnQueueInputBuffer (buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='onQueueInputBuffer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DecoderInputBuffer']]"
		[Register ("onQueueInputBuffer", "(Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;)V", "GetOnQueueInputBuffer_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Handler")]
		protected virtual unsafe void OnQueueInputBuffer (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer buffer)
		{
			const string __id = "onQueueInputBuffer.(Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (buffer);
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

		static bool n_ProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, long p6, bool p7, bool p8, IntPtr native_p9)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p9 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p9, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessOutputBuffer (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='processOutputBuffer' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='android.media.MediaCodec'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='long'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("processOutputBuffer", "(JJLandroid/media/MediaCodec;Ljava/nio/ByteBuffer;IIJZZLcom/example/androidtvlibrary/main/adapter/Format;)Z", "GetProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected abstract bool ProcessOutputBuffer (long p0, long p1, global::Android.Media.MediaCodec p2, global::Java.Nio.ByteBuffer p3, int p4, int p5, long p6, bool p7, bool p8, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p9);

		static Delegate cb_releaseCodec;
#pragma warning disable 0169
		static Delegate GetReleaseCodecHandler ()
		{
			if (cb_releaseCodec == null)
				cb_releaseCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseCodec);
			return cb_releaseCodec;
		}

		static void n_ReleaseCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseCodec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='releaseCodec' and count(parameter)=0]"
		[Register ("releaseCodec", "()V", "GetReleaseCodecHandler")]
		protected virtual unsafe void ReleaseCodec ()
		{
			const string __id = "releaseCodec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_render_JJ;
#pragma warning disable 0169
		static Delegate GetRender_JJHandler ()
		{
			if (cb_render_JJ == null)
				cb_render_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_Render_JJ);
			return cb_render_JJ;
		}

		static void n_Render_JJ (IntPtr jnienv, IntPtr native__this, long positionUs, long elapsedRealtimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Render (positionUs, elapsedRealtimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='render' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("render", "(JJ)V", "GetRender_JJHandler")]
		public override unsafe void Render (long positionUs, long elapsedRealtimeUs)
		{
			const string __id = "render.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (elapsedRealtimeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_renderToEndOfStream;
#pragma warning disable 0169
		static Delegate GetRenderToEndOfStreamHandler ()
		{
			if (cb_renderToEndOfStream == null)
				cb_renderToEndOfStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RenderToEndOfStream);
			return cb_renderToEndOfStream;
		}

		static void n_RenderToEndOfStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RenderToEndOfStream ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='renderToEndOfStream' and count(parameter)=0]"
		[Register ("renderToEndOfStream", "()V", "GetRenderToEndOfStreamHandler")]
		protected virtual unsafe void RenderToEndOfStream ()
		{
			const string __id = "renderToEndOfStream.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='setOperatingRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setOperatingRate", "(F)V", "")]
		public unsafe void SetOperatingRate (float operatingRate)
		{
			const string __id = "setOperatingRate.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (operatingRate);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='setPendingOutputEndOfStream' and count(parameter)=0]"
		[Register ("setPendingOutputEndOfStream", "()V", "")]
		protected unsafe void SetPendingOutputEndOfStream ()
		{
			const string __id = "setPendingOutputEndOfStream.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_shouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_;
#pragma warning disable 0169
		static Delegate GetShouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Handler ()
		{
			if (cb_shouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_ == null)
				cb_shouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ShouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_);
			return cb_shouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_;
		}

		static bool n_ShouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codecInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codecInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (native_codecInfo, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldInitCodec (codecInfo);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='shouldInitCodec' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo']]"
		[Register ("shouldInitCodec", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)Z", "GetShouldInitCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Handler")]
		protected virtual unsafe bool ShouldInitCodec (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo codecInfo)
		{
			const string __id = "shouldInitCodec.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((codecInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecInfo).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (codecInfo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='supportsFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I", "")]
		public override sealed unsafe int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "supportsFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
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

		static int n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SupportsFormat (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='supportsFormat' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected abstract int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='supportsMixedMimeTypeAdaptation' and count(parameter)=0]"
		[Register ("supportsMixedMimeTypeAdaptation", "()I", "")]
		public override sealed unsafe int SupportsMixedMimeTypeAdaptation ()
		{
			const string __id = "supportsMixedMimeTypeAdaptation.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='updateOutputFormatForTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("updateOutputFormatForTime", "(J)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format UpdateOutputFormatForTime (long presentationTimeUs)
		{
			const string __id = "updateOutputFormatForTime.(J)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (presentationTimeUs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer", DoNotGenerateAcw=true)]
	internal partial class MediaCodecRendererInvoker : MediaCodecRenderer {
		public MediaCodecRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecRenderer", typeof (MediaCodecRendererInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='configureCodec' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo'] and parameter[2][@type='android.media.MediaCodec'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='android.media.MediaCrypto'] and parameter[5][@type='float']]"
		[Register ("configureCodec", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaCrypto;F)V", "GetConfigureCodec_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecInfo_Landroid_media_MediaCodec_Lcom_example_androidtvlibrary_main_adapter_Format_Landroid_media_MediaCrypto_FHandler")]
		protected override unsafe void ConfigureCodec (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo p0, global::Android.Media.MediaCodec p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2, global::Android.Media.MediaCrypto p3, float p4)
		{
			const string __id = "configureCodec.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;Landroid/media/MediaCodec;Lcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaCrypto;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='getDecoderInfos' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='boolean']]"
		[Register ("getDecoderInfos", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Ljava/util/List;", "GetGetDecoderInfos_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Format_ZHandler")]
		protected override unsafe global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfos (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p1, bool p2)
		{
			const string __id = "getDecoderInfos.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='processOutputBuffer' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='android.media.MediaCodec'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='long'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("processOutputBuffer", "(JJLandroid/media/MediaCodec;Ljava/nio/ByteBuffer;IIJZZLcom/example/androidtvlibrary/main/adapter/Format;)Z", "GetProcessOutputBuffer_JJLandroid_media_MediaCodec_Ljava_nio_ByteBuffer_IIJZZLcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected override unsafe bool ProcessOutputBuffer (long p0, long p1, global::Android.Media.MediaCodec p2, global::Java.Nio.ByteBuffer p3, int p4, int p5, long p6, bool p7, bool p8, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p9)
		{
			const string __id = "processOutputBuffer.(JJLandroid/media/MediaCodec;Ljava/nio/ByteBuffer;IIJZZLcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (p8);
				__args [9] = new JniArgumentValue ((p9 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p9).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p9);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecRenderer']/method[@name='supportsFormat' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected override unsafe int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Format p2)
		{
			const string __id = "supportsFormat.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
