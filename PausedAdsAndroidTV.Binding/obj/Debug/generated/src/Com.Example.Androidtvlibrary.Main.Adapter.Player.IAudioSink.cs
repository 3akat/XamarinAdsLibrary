using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.ConfigurationException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink$ConfigurationException", DoNotGenerateAcw=true)]
	public sealed partial class AudioSinkConfigurationException : global::Java.Lang.Exception {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioSink$ConfigurationException", typeof (AudioSinkConfigurationException));

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

		internal AudioSinkConfigurationException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.ConfigurationException']/constructor[@name='AudioSink.ConfigurationException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AudioSinkConfigurationException (string message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.ConfigurationException']/constructor[@name='AudioSink.ConfigurationException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe AudioSinkConfigurationException (global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cause);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.InitializationException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink$InitializationException", DoNotGenerateAcw=true)]
	public sealed partial class AudioSinkInitializationException : global::Java.Lang.Exception {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.InitializationException']/field[@name='audioTrackState']"
		[Register ("audioTrackState")]
		public int AudioTrackState {
			get {
				const string __id = "audioTrackState.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "audioTrackState.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioSink$InitializationException", typeof (AudioSinkInitializationException));

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

		internal AudioSinkInitializationException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.InitializationException']/constructor[@name='AudioSink.InitializationException' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe AudioSinkInitializationException (int audioTrackState, int sampleRate, int channelConfig, int bufferSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (audioTrackState);
				__args [1] = new JniArgumentValue (sampleRate);
				__args [2] = new JniArgumentValue (channelConfig);
				__args [3] = new JniArgumentValue (bufferSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink.Listener']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink$Listener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListenerInvoker")]
	public partial interface IAudioSinkListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink.Listener']/method[@name='onAudioSessionId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAudioSessionId", "(I)V", "GetOnAudioSessionId_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnAudioSessionId (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink.Listener']/method[@name='onPositionDiscontinuity' and count(parameter)=0]"
		[Register ("onPositionDiscontinuity", "()V", "GetOnPositionDiscontinuityHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnPositionDiscontinuity ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink.Listener']/method[@name='onUnderrun' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onUnderrun", "(IJJ)V", "GetOnUnderrun_IJJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnUnderrun (int p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink$Listener", DoNotGenerateAcw=true)]
	internal partial class IAudioSinkListenerInvoker : global::Java.Lang.Object, IAudioSinkListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioSink$Listener", typeof (IAudioSinkListenerInvoker));

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

		public static IAudioSinkListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioSinkListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.AudioSink.Listener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioSinkListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAudioSessionId_I;
#pragma warning disable 0169
		static Delegate GetOnAudioSessionId_IHandler ()
		{
			if (cb_onAudioSessionId_I == null)
				cb_onAudioSessionId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnAudioSessionId_I);
			return cb_onAudioSessionId_I;
		}

		static void n_OnAudioSessionId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioSessionId (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAudioSessionId_I;
		public unsafe void OnAudioSessionId (int p0)
		{
			if (id_onAudioSessionId_I == IntPtr.Zero)
				id_onAudioSessionId_I = JNIEnv.GetMethodID (class_ref, "onAudioSessionId", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioSessionId_I, __args);
		}

		static Delegate cb_onPositionDiscontinuity;
#pragma warning disable 0169
		static Delegate GetOnPositionDiscontinuityHandler ()
		{
			if (cb_onPositionDiscontinuity == null)
				cb_onPositionDiscontinuity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPositionDiscontinuity);
			return cb_onPositionDiscontinuity;
		}

		static void n_OnPositionDiscontinuity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPositionDiscontinuity ();
		}
#pragma warning restore 0169

		IntPtr id_onPositionDiscontinuity;
		public unsafe void OnPositionDiscontinuity ()
		{
			if (id_onPositionDiscontinuity == IntPtr.Zero)
				id_onPositionDiscontinuity = JNIEnv.GetMethodID (class_ref, "onPositionDiscontinuity", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPositionDiscontinuity);
		}

		static Delegate cb_onUnderrun_IJJ;
#pragma warning disable 0169
		static Delegate GetOnUnderrun_IJJHandler ()
		{
			if (cb_onUnderrun_IJJ == null)
				cb_onUnderrun_IJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJJ_V) n_OnUnderrun_IJJ);
			return cb_onUnderrun_IJJ;
		}

		static void n_OnUnderrun_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnderrun (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onUnderrun_IJJ;
		public unsafe void OnUnderrun (int p0, long p1, long p2)
		{
			if (id_onUnderrun_IJJ == IntPtr.Zero)
				id_onUnderrun_IJJ = JNIEnv.GetMethodID (class_ref, "onUnderrun", "(IJJ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnderrun_IJJ, __args);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.player.AudioSink.Listener.onAudioSessionId
	public partial class AudioSessionIdEventArgs : global::System.EventArgs {
		public AudioSessionIdEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.player.AudioSink.Listener.onUnderrun
	public partial class UnderrunEventArgs : global::System.EventArgs {
		public UnderrunEventArgs (int p0, long p1, long p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		long p1;

		public long P1 {
			get { return p1; }
		}

		long p2;

		public long P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/AudioSink_ListenerImplementor")]
	internal sealed partial class IAudioSinkListenerImplementor : global::Java.Lang.Object, IAudioSinkListener {

		object sender;

		public IAudioSinkListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/AudioSink_ListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<AudioSessionIdEventArgs> OnAudioSessionIdHandler;
		#pragma warning restore 0649

		public void OnAudioSessionId (int p0)
		{
			var __h = OnAudioSessionIdHandler;
			if (__h != null)
				__h (sender, new AudioSessionIdEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnPositionDiscontinuityHandler;
		#pragma warning restore 0649

		public void OnPositionDiscontinuity ()
		{
			var __h = OnPositionDiscontinuityHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<UnderrunEventArgs> OnUnderrunHandler;
		#pragma warning restore 0649

		public void OnUnderrun (int p0, long p1, long p2)
		{
			var __h = OnUnderrunHandler;
			if (__h != null)
				__h (sender, new UnderrunEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IAudioSinkListenerImplementor value)
		{
			return value.OnAudioSessionIdHandler == null && value.OnPositionDiscontinuityHandler == null && value.OnUnderrunHandler == null;
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.WriteException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink$WriteException", DoNotGenerateAcw=true)]
	public sealed partial class AudioSinkWriteException : global::Java.Lang.Exception {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.WriteException']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				const string __id = "errorCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioSink$WriteException", typeof (AudioSinkWriteException));

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

		internal AudioSinkWriteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioSink.WriteException']/constructor[@name='AudioSink.WriteException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AudioSinkWriteException (int errorCode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (errorCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink", DoNotGenerateAcw=true)]
	public abstract class AudioSink : Java.Lang.Object {
		internal AudioSink ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/field[@name='CURRENT_POSITION_NOT_SET']"
		[Register ("CURRENT_POSITION_NOT_SET")]
		public const long CurrentPositionNotSet = (long) -9223372036854775808;

	}

	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AudioSink' type. This type will be removed in a future release.", error: true)]
	public abstract class AudioSinkConsts : AudioSink {
		private AudioSinkConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker")]
	public partial interface IAudioSink : IJavaObject, IJavaPeerable {
		bool HasPendingData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='hasPendingData' and count(parameter)=0]"
			[Register ("hasPendingData", "()Z", "GetHasPendingDataHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='getPlaybackParameters' and count(parameter)=0]"
			[Register ("getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "GetGetPlaybackParametersHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='setPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V", "GetSetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='configure' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int[]'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("configure", "(IIII[III)V", "GetConfigure_IIIIarrayIIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void Configure ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int p0, int p1, int p2, int p3, int[] p4, int p5, int p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='disableTunneling' and count(parameter)=0]"
		[Register ("disableTunneling", "()V", "GetDisableTunnelingHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void DisableTunneling ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='enableTunnelingV21' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableTunnelingV21", "(I)V", "GetEnableTunnelingV21_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void EnableTunnelingV21 (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='getCurrentPositionUs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getCurrentPositionUs", "(Z)J", "GetGetCurrentPositionUs_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		long GetCurrentPositionUs (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='handleBuffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long']]"
		[Register ("handleBuffer", "(Ljava/nio/ByteBuffer;J)Z", "GetHandleBuffer_Ljava_nio_ByteBuffer_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		bool HandleBuffer (global::Java.Nio.ByteBuffer p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='handleDiscontinuity' and count(parameter)=0]"
		[Register ("handleDiscontinuity", "()V", "GetHandleDiscontinuityHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void HandleDiscontinuity ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()V", "GetPlayHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void Play ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='playToEndOfStream' and count(parameter)=0]"
		[Register ("playToEndOfStream", "()V", "GetPlayToEndOfStreamHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void PlayToEndOfStream ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='setAudioAttributes' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioAttributes']]"
		[Register ("setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;)V", "GetSetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void SetAudioAttributes (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='setAudioSessionId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioSessionId", "(I)V", "GetSetAudioSessionId_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void SetAudioSessionId (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='setAuxEffectInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AuxEffectInfo']]"
		[Register ("setAuxEffectInfo", "(Lcom/example/androidtvlibrary/main/adapter/player/AuxEffectInfo;)V", "GetSetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void SetAuxEffectInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioSink.Listener']]"
		[Register ("setListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioSink$Listener;)V", "GetSetListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void SetListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='setVolume' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVolume", "(F)V", "GetSetVolume_FHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		void SetVolume (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/method[@name='supportsOutput' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("supportsOutput", "(II)Z", "GetSupportsOutput_IIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkInvoker, PausedAdsAndroidTV.Binding")]
		bool SupportsOutput (int p0, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioSink", DoNotGenerateAcw=true)]
	internal partial class IAudioSinkInvoker : global::Java.Lang.Object, IAudioSink {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioSink", typeof (IAudioSinkInvoker));

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

		public static IAudioSink GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioSink> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.AudioSink'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasPendingData;
#pragma warning disable 0169
		static Delegate GetHasPendingDataHandler ()
		{
			if (cb_hasPendingData == null)
				cb_hasPendingData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasPendingData);
			return cb_hasPendingData;
		}

		static bool n_HasPendingData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPendingData;
		}
#pragma warning restore 0169

		IntPtr id_hasPendingData;
		public unsafe bool HasPendingData {
			get {
				if (id_hasPendingData == IntPtr.Zero)
					id_hasPendingData = JNIEnv.GetMethodID (class_ref, "hasPendingData", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPendingData);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnded;
		}
#pragma warning restore 0169

		IntPtr id_isEnded;
		public unsafe bool IsEnded {
			get {
				if (id_isEnded == IntPtr.Zero)
					id_isEnded = JNIEnv.GetMethodID (class_ref, "isEnded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnded);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_configure_IIIIarrayIII;
#pragma warning disable 0169
		static Delegate GetConfigure_IIIIarrayIIIHandler ()
		{
			if (cb_configure_IIIIarrayIII == null)
				cb_configure_IIIIarrayIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIILII_V) n_Configure_IIIIarrayIII);
			return cb_configure_IIIIarrayIII;
		}

		static void n_Configure_IIIIarrayIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4, int p5, int p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p4 = (int[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.Configure (p0, p1, p2, p3, p4, p5, p6);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_configure_IIIIarrayIII;
		public unsafe void Configure ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int p0, int p1, int p2, int p3, int[] p4, int p5, int p6)
		{
			if (id_configure_IIIIarrayIII == IntPtr.Zero)
				id_configure_IIIIarrayIII = JNIEnv.GetMethodID (class_ref, "configure", "(IIII[III)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configure_IIIIarrayIII, __args);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_disableTunneling;
#pragma warning disable 0169
		static Delegate GetDisableTunnelingHandler ()
		{
			if (cb_disableTunneling == null)
				cb_disableTunneling = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableTunneling);
			return cb_disableTunneling;
		}

		static void n_DisableTunneling (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableTunneling ();
		}
#pragma warning restore 0169

		IntPtr id_disableTunneling;
		public unsafe void DisableTunneling ()
		{
			if (id_disableTunneling == IntPtr.Zero)
				id_disableTunneling = JNIEnv.GetMethodID (class_ref, "disableTunneling", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableTunneling);
		}

		static Delegate cb_enableTunnelingV21_I;
#pragma warning disable 0169
		static Delegate GetEnableTunnelingV21_IHandler ()
		{
			if (cb_enableTunnelingV21_I == null)
				cb_enableTunnelingV21_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_EnableTunnelingV21_I);
			return cb_enableTunnelingV21_I;
		}

		static void n_EnableTunnelingV21_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableTunnelingV21 (p0);
		}
#pragma warning restore 0169

		IntPtr id_enableTunnelingV21_I;
		public unsafe void EnableTunnelingV21 (int p0)
		{
			if (id_enableTunnelingV21_I == IntPtr.Zero)
				id_enableTunnelingV21_I = JNIEnv.GetMethodID (class_ref, "enableTunnelingV21", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableTunnelingV21_I, __args);
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
		}

		static Delegate cb_getCurrentPositionUs_Z;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionUs_ZHandler ()
		{
			if (cb_getCurrentPositionUs_Z == null)
				cb_getCurrentPositionUs_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_J) n_GetCurrentPositionUs_Z);
			return cb_getCurrentPositionUs_Z;
		}

		static long n_GetCurrentPositionUs_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCurrentPositionUs (p0);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPositionUs_Z;
		public unsafe long GetCurrentPositionUs (bool p0)
		{
			if (id_getCurrentPositionUs_Z == IntPtr.Zero)
				id_getCurrentPositionUs_Z = JNIEnv.GetMethodID (class_ref, "getCurrentPositionUs", "(Z)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPositionUs_Z, __args);
		}

		static Delegate cb_handleBuffer_Ljava_nio_ByteBuffer_J;
#pragma warning disable 0169
		static Delegate GetHandleBuffer_Ljava_nio_ByteBuffer_JHandler ()
		{
			if (cb_handleBuffer_Ljava_nio_ByteBuffer_J == null)
				cb_handleBuffer_Ljava_nio_ByteBuffer_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_Z) n_HandleBuffer_Ljava_nio_ByteBuffer_J);
			return cb_handleBuffer_Ljava_nio_ByteBuffer_J;
		}

		static bool n_HandleBuffer_Ljava_nio_ByteBuffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleBuffer (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleBuffer_Ljava_nio_ByteBuffer_J;
		public unsafe bool HandleBuffer (global::Java.Nio.ByteBuffer p0, long p1)
		{
			if (id_handleBuffer_Ljava_nio_ByteBuffer_J == IntPtr.Zero)
				id_handleBuffer_Ljava_nio_ByteBuffer_J = JNIEnv.GetMethodID (class_ref, "handleBuffer", "(Ljava/nio/ByteBuffer;J)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleBuffer_Ljava_nio_ByteBuffer_J, __args);
			return __ret;
		}

		static Delegate cb_handleDiscontinuity;
#pragma warning disable 0169
		static Delegate GetHandleDiscontinuityHandler ()
		{
			if (cb_handleDiscontinuity == null)
				cb_handleDiscontinuity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_HandleDiscontinuity);
			return cb_handleDiscontinuity;
		}

		static void n_HandleDiscontinuity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleDiscontinuity ();
		}
#pragma warning restore 0169

		IntPtr id_handleDiscontinuity;
		public unsafe void HandleDiscontinuity ()
		{
			if (id_handleDiscontinuity == IntPtr.Zero)
				id_handleDiscontinuity = JNIEnv.GetMethodID (class_ref, "handleDiscontinuity", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleDiscontinuity);
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
		}

		static Delegate cb_play;
#pragma warning disable 0169
		static Delegate GetPlayHandler ()
		{
			if (cb_play == null)
				cb_play = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Play);
			return cb_play;
		}

		static void n_Play (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Play ();
		}
#pragma warning restore 0169

		IntPtr id_play;
		public unsafe void Play ()
		{
			if (id_play == IntPtr.Zero)
				id_play = JNIEnv.GetMethodID (class_ref, "play", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_play);
		}

		static Delegate cb_playToEndOfStream;
#pragma warning disable 0169
		static Delegate GetPlayToEndOfStreamHandler ()
		{
			if (cb_playToEndOfStream == null)
				cb_playToEndOfStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PlayToEndOfStream);
			return cb_playToEndOfStream;
		}

		static void n_PlayToEndOfStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayToEndOfStream ();
		}
#pragma warning restore 0169

		IntPtr id_playToEndOfStream;
		public unsafe void PlayToEndOfStream ()
		{
			if (id_playToEndOfStream == IntPtr.Zero)
				id_playToEndOfStream = JNIEnv.GetMethodID (class_ref, "playToEndOfStream", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playToEndOfStream);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

		static Delegate cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_;
#pragma warning disable 0169
		static Delegate GetSetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Handler ()
		{
			if (cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ == null)
				cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_);
			return cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_;
		}

		static void n_SetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioAttributes (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_;
		public unsafe void SetAudioAttributes (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes p0)
		{
			if (id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ == IntPtr.Zero)
				id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ = JNIEnv.GetMethodID (class_ref, "setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_, __args);
		}

		static Delegate cb_setAudioSessionId_I;
#pragma warning disable 0169
		static Delegate GetSetAudioSessionId_IHandler ()
		{
			if (cb_setAudioSessionId_I == null)
				cb_setAudioSessionId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioSessionId_I);
			return cb_setAudioSessionId_I;
		}

		static void n_SetAudioSessionId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioSessionId (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAudioSessionId_I;
		public unsafe void SetAudioSessionId (int p0)
		{
			if (id_setAudioSessionId_I == IntPtr.Zero)
				id_setAudioSessionId_I = JNIEnv.GetMethodID (class_ref, "setAudioSessionId", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioSessionId_I, __args);
		}

		static Delegate cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_;
#pragma warning disable 0169
		static Delegate GetSetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_Handler ()
		{
			if (cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ == null)
				cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_);
			return cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_;
		}

		static void n_SetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAuxEffectInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_;
		public unsafe void SetAuxEffectInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo p0)
		{
			if (id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ == IntPtr.Zero)
				id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ = JNIEnv.GetMethodID (class_ref, "setAuxEffectInfo", "(Lcom/example/androidtvlibrary/main/adapter/player/AuxEffectInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_, __args);
		}

		static Delegate cb_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_Handler ()
		{
			if (cb_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_ == null)
				cb_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_);
			return cb_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_;
		}

		static void n_SetListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_;
		public unsafe void SetListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener p0)
		{
			if (id_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_ == IntPtr.Zero)
				id_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioSink$Listener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioSink_Listener_, __args);
		}

		static Delegate cb_setVolume_F;
#pragma warning disable 0169
		static Delegate GetSetVolume_FHandler ()
		{
			if (cb_setVolume_F == null)
				cb_setVolume_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetVolume_F);
			return cb_setVolume_F;
		}

		static void n_SetVolume_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVolume_F;
		public unsafe void SetVolume (float p0)
		{
			if (id_setVolume_F == IntPtr.Zero)
				id_setVolume_F = JNIEnv.GetMethodID (class_ref, "setVolume", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_F, __args);
		}

		static Delegate cb_supportsOutput_II;
#pragma warning disable 0169
		static Delegate GetSupportsOutput_IIHandler ()
		{
			if (cb_supportsOutput_II == null)
				cb_supportsOutput_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_SupportsOutput_II);
			return cb_supportsOutput_II;
		}

		static bool n_SupportsOutput_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportsOutput (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_supportsOutput_II;
		public unsafe bool SupportsOutput (int p0, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int p1)
		{
			if (id_supportsOutput_II == IntPtr.Zero)
				id_supportsOutput_II = JNIEnv.GetMethodID (class_ref, "supportsOutput", "(II)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supportsOutput_II, __args);
		}

	}
}
