using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/BaseRenderer", DoNotGenerateAcw=true)]
	public abstract partial class BaseRenderer : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities {
		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.wow.Renderer

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/field[@name='STATE_DISABLED']"
			[Register ("STATE_DISABLED")]
			public const int StateDisabled = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/field[@name='STATE_ENABLED']"
			[Register ("STATE_ENABLED")]
			public const int StateEnabled = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/field[@name='STATE_STARTED']"
			[Register ("STATE_STARTED")]
			public const int StateStarted = (int) 2;

			// The following are fields from: com.example.androidtvlibrary.main.adapter.wow.RendererCapabilities

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='ADAPTIVE_NOT_SEAMLESS']"
			[Register ("ADAPTIVE_NOT_SEAMLESS")]
			public const int AdaptiveNotSeamless = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='ADAPTIVE_NOT_SUPPORTED']"
			[Register ("ADAPTIVE_NOT_SUPPORTED")]
			public const int AdaptiveNotSupported = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='ADAPTIVE_SEAMLESS']"
			[Register ("ADAPTIVE_SEAMLESS")]
			public const int AdaptiveSeamless = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='ADAPTIVE_SUPPORT_MASK']"
			[Register ("ADAPTIVE_SUPPORT_MASK")]
			public const int AdaptiveSupportMask = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='FORMAT_EXCEEDS_CAPABILITIES']"
			[Register ("FORMAT_EXCEEDS_CAPABILITIES")]
			public const int FormatExceedsCapabilities = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='FORMAT_HANDLED']"
			[Register ("FORMAT_HANDLED")]
			public const int FormatHandled = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='FORMAT_SUPPORT_MASK']"
			[Register ("FORMAT_SUPPORT_MASK")]
			public const int FormatSupportMask = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='FORMAT_UNSUPPORTED_DRM']"
			[Register ("FORMAT_UNSUPPORTED_DRM")]
			public const int FormatUnsupportedDrm = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='FORMAT_UNSUPPORTED_SUBTYPE']"
			[Register ("FORMAT_UNSUPPORTED_SUBTYPE")]
			public const int FormatUnsupportedSubtype = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='FORMAT_UNSUPPORTED_TYPE']"
			[Register ("FORMAT_UNSUPPORTED_TYPE")]
			public const int FormatUnsupportedType = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='TUNNELING_NOT_SUPPORTED']"
			[Register ("TUNNELING_NOT_SUPPORTED")]
			public const int TunnelingNotSupported = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='TUNNELING_SUPPORTED']"
			[Register ("TUNNELING_SUPPORTED")]
			public const int TunnelingSupported = (int) 32;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/field[@name='TUNNELING_SUPPORT_MASK']"
			[Register ("TUNNELING_SUPPORT_MASK")]
			public const int TunnelingSupportMask = (int) 32;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/BaseRenderer", typeof (BaseRenderer));

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

		protected BaseRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/constructor[@name='BaseRenderer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BaseRenderer (int trackType) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (trackType);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities Capabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getCapabilities' and count(parameter)=0]"
			[Register ("getCapabilities", "()Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;", "")]
			get {
				const string __id = "getCapabilities.()Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;", "")]
			get {
				const string __id = "getConfiguration.()Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder FormatHolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getFormatHolder' and count(parameter)=0]"
			[Register ("getFormatHolder", "()Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;", "")]
			get {
				const string __id = "getFormatHolder.()Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool HasReadStreamToEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='hasReadStreamToEnd' and count(parameter)=0]"
			[Register ("hasReadStreamToEnd", "()Z", "")]
			get {
				const string __id = "hasReadStreamToEnd.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe int Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()I", "")]
			get {
				const string __id = "getIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsCurrentStreamFinal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='isCurrentStreamFinal' and count(parameter)=0]"
			[Register ("isCurrentStreamFinal", "()Z", "")]
			get {
				const string __id = "isCurrentStreamFinal.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected unsafe bool IsSourceReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='isSourceReady' and count(parameter)=0]"
			[Register ("isSourceReady", "()Z", "")]
			get {
				const string __id = "isSourceReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMediaClock;
#pragma warning disable 0169
		static Delegate GetGetMediaClockHandler ()
		{
			if (cb_getMediaClock == null)
				cb_getMediaClock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMediaClock);
			return cb_getMediaClock;
		}

		static IntPtr n_GetMediaClock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaClock);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock MediaClock {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getMediaClock' and count(parameter)=0]"
			[Register ("getMediaClock", "()Lcom/example/androidtvlibrary/main/adapter/wow/MediaClock;", "GetGetMediaClockHandler")]
			get {
				const string __id = "getMediaClock.()Lcom/example/androidtvlibrary/main/adapter/wow/MediaClock;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long ReadingPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getReadingPositionUs' and count(parameter)=0]"
			[Register ("getReadingPositionUs", "()J", "")]
			get {
				const string __id = "getReadingPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "")]
			get {
				const string __id = "getState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;", "")]
			get {
				const string __id = "getStream.()Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int TrackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getTrackType' and count(parameter)=0]"
			[Register ("getTrackType", "()I", "")]
			get {
				const string __id = "getTrackType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='createRendererException' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("createRendererException", "(Ljava/lang/Exception;Lcom/example/androidtvlibrary/main/adapter/Format;)Ljava/lang/Exception;", "")]
		protected unsafe global::Java.Lang.Exception CreateRendererException (global::Java.Lang.Exception cause, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "createRendererException.(Ljava/lang/Exception;Lcom/example/androidtvlibrary/main/adapter/Format;)Ljava/lang/Exception;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cause);
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public unsafe void Disable ()
		{
			const string __id = "disable.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='enable' and count(parameter)=6 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererConfiguration'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format[]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.SampleStream'] and parameter[4][@type='long'] and parameter[5][@type='boolean'] and parameter[6][@type='long']]"
		[Register ("enable", "(Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;[Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;JZJ)V", "")]
		public unsafe void Enable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration configuration, global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] formats, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream stream, long positionUs, bool joining, long offsetUs)
		{
			const string __id = "enable.(Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;[Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;JZJ)V";
			IntPtr native_formats = JNIEnv.NewArray (formats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [1] = new JniArgumentValue (native_formats);
				__args [2] = new JniArgumentValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
				__args [3] = new JniArgumentValue (positionUs);
				__args [4] = new JniArgumentValue (joining);
				__args [5] = new JniArgumentValue (offsetUs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (formats != null) {
					JNIEnv.CopyArray (native_formats, formats);
					JNIEnv.DeleteLocalRef (native_formats);
				}
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (formats);
				global::System.GC.KeepAlive (stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getStreamFormats' and count(parameter)=0]"
		[Register ("getStreamFormats", "()[Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] GetStreamFormats ()
		{
			const string __id = "getStreamFormats.()[Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='getUpdatedSourceDrmSession' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;T&gt;'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.wow.DrmSession&lt;T&gt;']]"
		[Register ("getUpdatedSourceDrmSession", "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession GetUpdatedSourceDrmSession (global::Com.Example.Androidtvlibrary.Main.Adapter.Format oldFormat, global::Com.Example.Androidtvlibrary.Main.Adapter.Format newFormat, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession existingSourceSession)
		{
			const string __id = "getUpdatedSourceDrmSession.(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((oldFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldFormat).Handle);
				__args [1] = new JniArgumentValue ((newFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newFormat).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [3] = new JniArgumentValue ((existingSourceSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) existingSourceSession).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (oldFormat);
				global::System.GC.KeepAlive (newFormat);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (existingSourceSession);
			}
		}

		static Delegate cb_handleMessage_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_ILjava_lang_Object_Handler ()
		{
			if (cb_handleMessage_ILjava_lang_Object_ == null)
				cb_handleMessage_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_HandleMessage_ILjava_lang_Object_);
			return cb_handleMessage_ILjava_lang_Object_;
		}

		static void n_HandleMessage_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int what, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (what, @object);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("handleMessage", "(ILjava/lang/Object;)V", "GetHandleMessage_ILjava_lang_Object_Handler")]
		public virtual unsafe void HandleMessage (int what, global::Java.Lang.Object @object)
		{
			const string __id = "handleMessage.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@object);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='maybeThrowStreamError' and count(parameter)=0]"
		[Register ("maybeThrowStreamError", "()V", "")]
		public unsafe void MaybeThrowStreamError ()
		{
			const string __id = "maybeThrowStreamError.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDisabled;
#pragma warning disable 0169
		static Delegate GetOnDisabledHandler ()
		{
			if (cb_onDisabled == null)
				cb_onDisabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDisabled);
			return cb_onDisabled;
		}

		static void n_OnDisabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onDisabled' and count(parameter)=0]"
		[Register ("onDisabled", "()V", "GetOnDisabledHandler")]
		protected virtual unsafe void OnDisabled ()
		{
			const string __id = "onDisabled.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onEnabled_Z;
#pragma warning disable 0169
		static Delegate GetOnEnabled_ZHandler ()
		{
			if (cb_onEnabled_Z == null)
				cb_onEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnEnabled_Z);
			return cb_onEnabled_Z;
		}

		static void n_OnEnabled_Z (IntPtr jnienv, IntPtr native__this, bool joining)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEnabled (joining);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onEnabled", "(Z)V", "GetOnEnabled_ZHandler")]
		protected virtual unsafe void OnEnabled (bool joining)
		{
			const string __id = "onEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (joining);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPositionReset_JZ;
#pragma warning disable 0169
		static Delegate GetOnPositionReset_JZHandler ()
		{
			if (cb_onPositionReset_JZ == null)
				cb_onPositionReset_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJZ_V) n_OnPositionReset_JZ);
			return cb_onPositionReset_JZ;
		}

		static void n_OnPositionReset_JZ (IntPtr jnienv, IntPtr native__this, long positionUs, bool joining)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPositionReset (positionUs, joining);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onPositionReset' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("onPositionReset", "(JZ)V", "GetOnPositionReset_JZHandler")]
		protected virtual unsafe void OnPositionReset (long positionUs, bool joining)
		{
			const string __id = "onPositionReset.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (joining);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onReset;
#pragma warning disable 0169
		static Delegate GetOnResetHandler ()
		{
			if (cb_onReset == null)
				cb_onReset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReset);
			return cb_onReset;
		}

		static void n_OnReset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onReset' and count(parameter)=0]"
		[Register ("onReset", "()V", "GetOnResetHandler")]
		protected virtual unsafe void OnReset ()
		{
			const string __id = "onReset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStarted;
#pragma warning disable 0169
		static Delegate GetOnStartedHandler ()
		{
			if (cb_onStarted == null)
				cb_onStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStarted);
			return cb_onStarted;
		}

		static void n_OnStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStarted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onStarted' and count(parameter)=0]"
		[Register ("onStarted", "()V", "GetOnStartedHandler")]
		protected virtual unsafe void OnStarted ()
		{
			const string __id = "onStarted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStopped;
#pragma warning disable 0169
		static Delegate GetOnStoppedHandler ()
		{
			if (cb_onStopped == null)
				cb_onStopped = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStopped);
			return cb_onStopped;
		}

		static void n_OnStopped (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onStopped' and count(parameter)=0]"
		[Register ("onStopped", "()V", "GetOnStoppedHandler")]
		protected virtual unsafe void OnStopped ()
		{
			const string __id = "onStopped.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_J;
#pragma warning disable 0169
		static Delegate GetOnStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_JHandler ()
		{
			if (cb_onStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_J == null)
				cb_onStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_OnStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_J);
			return cb_onStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_J;
		}

		static void n_OnStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_J (IntPtr jnienv, IntPtr native__this, IntPtr native_formats, long offsetUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var formats = (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (native_formats, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			__this.OnStreamChanged (formats, offsetUs);
			if (formats != null)
				JNIEnv.CopyArray (formats, native_formats);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='onStreamChanged' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format[]'] and parameter[2][@type='long']]"
		[Register ("onStreamChanged", "([Lcom/example/androidtvlibrary/main/adapter/Format;J)V", "GetOnStreamChanged_arrayLcom_example_androidtvlibrary_main_adapter_Format_JHandler")]
		protected virtual unsafe void OnStreamChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] formats, long offsetUs)
		{
			const string __id = "onStreamChanged.([Lcom/example/androidtvlibrary/main/adapter/Format;J)V";
			IntPtr native_formats = JNIEnv.NewArray (formats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_formats);
				__args [1] = new JniArgumentValue (offsetUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (formats != null) {
					JNIEnv.CopyArray (native_formats, formats);
					JNIEnv.DeleteLocalRef (native_formats);
				}
				global::System.GC.KeepAlive (formats);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='readSource' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.FormatHolder'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DecoderInputBuffer'] and parameter[3][@type='boolean']]"
		[Register ("readSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;Z)I", "")]
		protected unsafe int ReadSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder formatHolder, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer buffer, bool formatRequired)
		{
			const string __id = "readSource.(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((formatHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatHolder).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [2] = new JniArgumentValue (formatRequired);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (formatHolder);
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='replaceStream' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.SampleStream'] and parameter[3][@type='long']]"
		[Register ("replaceStream", "([Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;J)V", "")]
		public unsafe void ReplaceStream (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] formats, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream stream, long offsetUs)
		{
			const string __id = "replaceStream.([Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;J)V";
			IntPtr native_formats = JNIEnv.NewArray (formats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_formats);
				__args [1] = new JniArgumentValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
				__args [2] = new JniArgumentValue (offsetUs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (formats != null) {
					JNIEnv.CopyArray (native_formats, formats);
					JNIEnv.DeleteLocalRef (native_formats);
				}
				global::System.GC.KeepAlive (formats);
				global::System.GC.KeepAlive (stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='resetPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("resetPosition", "(J)V", "")]
		public unsafe void ResetPosition (long positionUs)
		{
			const string __id = "resetPosition.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='setCurrentStreamFinal' and count(parameter)=0]"
		[Register ("setCurrentStreamFinal", "()V", "")]
		public unsafe void SetCurrentStreamFinal ()
		{
			const string __id = "setCurrentStreamFinal.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='setIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndex", "(I)V", "")]
		public unsafe void SetIndex (int index)
		{
			const string __id = "setIndex.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_skipSource_J;
#pragma warning disable 0169
		static Delegate GetSkipSource_JHandler ()
		{
			if (cb_skipSource_J == null)
				cb_skipSource_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_I) n_SkipSource_J);
			return cb_skipSource_J;
		}

		static int n_SkipSource_J (IntPtr jnienv, IntPtr native__this, long positionUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipSource (positionUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='skipSource' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skipSource", "(J)I", "GetSkipSource_JHandler")]
		protected virtual unsafe int SkipSource (long positionUs)
		{
			const string __id = "skipSource.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='supportsFormatDrm' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;?&gt;'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("supportsFormatDrm", "(Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Z", "")]
		protected static unsafe bool SupportsFormatDrm (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "supportsFormatDrm.(Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [1] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		static Delegate cb_supportsMixedMimeTypeAdaptation;
#pragma warning disable 0169
		static Delegate GetSupportsMixedMimeTypeAdaptationHandler ()
		{
			if (cb_supportsMixedMimeTypeAdaptation == null)
				cb_supportsMixedMimeTypeAdaptation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_SupportsMixedMimeTypeAdaptation);
			return cb_supportsMixedMimeTypeAdaptation;
		}

		static int n_SupportsMixedMimeTypeAdaptation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportsMixedMimeTypeAdaptation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='supportsMixedMimeTypeAdaptation' and count(parameter)=0]"
		[Register ("supportsMixedMimeTypeAdaptation", "()I", "GetSupportsMixedMimeTypeAdaptationHandler")]
		public virtual unsafe int SupportsMixedMimeTypeAdaptation ()
		{
			const string __id = "supportsMixedMimeTypeAdaptation.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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

		static void n_Render_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Render (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='render' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("render", "(JJ)V", "GetRender_JJHandler")]
		public abstract void Render (long p0, long p1);

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnded;
		}
#pragma warning restore 0169

		public abstract bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		public abstract bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get; 
		}

		static Delegate cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static int n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SupportsFormat (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/method[@name='supportsFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		public abstract int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/BaseRenderer", DoNotGenerateAcw=true)]
	internal partial class BaseRendererInvoker : BaseRenderer {
		public BaseRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/BaseRenderer", typeof (BaseRendererInvoker));

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

		public override unsafe bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler")]
			get {
				const string __id = "isEnded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseRenderer']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				const string __id = "isReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='render' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("render", "(JJ)V", "GetRender_JJHandler")]
		public override unsafe void Render (long p0, long p1)
		{
			const string __id = "render.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='RendererCapabilities']/method[@name='supportsFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		public override unsafe int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
		{
			const string __id = "supportsFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
