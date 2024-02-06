using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat", DoNotGenerateAcw=true)]
	public sealed partial class AudioProcessorAudioFormat : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']/field[@name='bytesPerFrame']"
		[Register ("bytesPerFrame")]
		public int BytesPerFrame {
			get {
				const string __id = "bytesPerFrame.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bytesPerFrame.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']/field[@name='channelCount']"
		[Register ("channelCount")]
		public int ChannelCount {
			get {
				const string __id = "channelCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "channelCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']/field[@name='encoding']"
		[Register ("encoding")]
		public int Encoding {
			get {
				const string __id = "encoding.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encoding.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']/field[@name='NOT_SET']"
		[Register ("NOT_SET")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat NotSet {
			get {
				const string __id = "NOT_SET.Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']/field[@name='sampleRate']"
		[Register ("sampleRate")]
		public int SampleRate {
			get {
				const string __id = "sampleRate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sampleRate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat", typeof (AudioProcessorAudioFormat));

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

		internal AudioProcessorAudioFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.AudioFormat']/constructor[@name='AudioProcessor.AudioFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe AudioProcessorAudioFormat (int sampleRate, int channelCount, int encoding) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sampleRate);
				__args [1] = new JniArgumentValue (channelCount);
				__args [2] = new JniArgumentValue (encoding);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.UnhandledAudioFormatException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor$UnhandledAudioFormatException", DoNotGenerateAcw=true)]
	public sealed partial class AudioProcessorUnhandledAudioFormatException : global::Java.Lang.Exception {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor$UnhandledAudioFormatException", typeof (AudioProcessorUnhandledAudioFormatException));

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

		internal AudioProcessorUnhandledAudioFormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioProcessor.UnhandledAudioFormatException']/constructor[@name='AudioProcessor.UnhandledAudioFormatException' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor.AudioFormat']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)V", "")]
		public unsafe AudioProcessorUnhandledAudioFormatException (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat inputAudioFormat) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputAudioFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputAudioFormat).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (inputAudioFormat);
			}
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor", DoNotGenerateAcw=true)]
	public abstract class AudioProcessor : Java.Lang.Object {
		internal AudioProcessor ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/field[@name='EMPTY_BUFFER']"
		[Register ("EMPTY_BUFFER")]
		public static global::Java.Nio.ByteBuffer EmptyBuffer {
			get {
				const string __id = "EMPTY_BUFFER.Ljava/nio/ByteBuffer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor", typeof (AudioProcessor));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AudioProcessor' type. This type will be removed in a future release.", error: true)]
	public abstract class AudioProcessorConsts : AudioProcessor {
		private AudioProcessorConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker")]
	public partial interface IAudioProcessor : IJavaObject, IJavaPeerable {
		bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Java.Nio.ByteBuffer Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/nio/ByteBuffer;", "GetGetOutputHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor.AudioFormat']]"
		[Register ("configure", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;", "GetConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat Configure (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='queueEndOfStream' and count(parameter)=0]"
		[Register ("queueEndOfStream", "()V", "GetQueueEndOfStreamHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void QueueEndOfStream ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='queueInput' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("queueInput", "(Ljava/nio/ByteBuffer;)V", "GetQueueInput_Ljava_nio_ByteBuffer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void QueueInput (global::Java.Nio.ByteBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor", DoNotGenerateAcw=true)]
	internal partial class IAudioProcessorInvoker : global::Java.Lang.Object, IAudioProcessor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioProcessor", typeof (IAudioProcessorInvoker));

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

		public static IAudioProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioProcessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.AudioProcessor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		IntPtr id_isActive;
		public unsafe bool IsActive {
			get {
				if (id_isActive == IntPtr.Zero)
					id_isActive = JNIEnv.GetMethodID (class_ref, "isActive", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isActive);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutput);
			return cb_getOutput;
		}

		static IntPtr n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Output);
		}
#pragma warning restore 0169

		IntPtr id_getOutput;
		public unsafe global::Java.Nio.ByteBuffer Output {
			get {
				if (id_getOutput == IntPtr.Zero)
					id_getOutput = JNIEnv.GetMethodID (class_ref, "getOutput", "()Ljava/nio/ByteBuffer;");
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_;
#pragma warning disable 0169
		static Delegate GetConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_Handler ()
		{
			if (cb_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ == null)
				cb_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_);
			return cb_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_;
		}

		static IntPtr n_Configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Configure (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat Configure (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat p0)
		{
			if (id_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ == IntPtr.Zero)
				id_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ = JNIEnv.GetMethodID (class_ref, "configure", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_configure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_queueEndOfStream;
#pragma warning disable 0169
		static Delegate GetQueueEndOfStreamHandler ()
		{
			if (cb_queueEndOfStream == null)
				cb_queueEndOfStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_QueueEndOfStream);
			return cb_queueEndOfStream;
		}

		static void n_QueueEndOfStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.QueueEndOfStream ();
		}
#pragma warning restore 0169

		IntPtr id_queueEndOfStream;
		public unsafe void QueueEndOfStream ()
		{
			if (id_queueEndOfStream == IntPtr.Zero)
				id_queueEndOfStream = JNIEnv.GetMethodID (class_ref, "queueEndOfStream", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueEndOfStream);
		}

		static Delegate cb_queueInput_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetQueueInput_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_queueInput_Ljava_nio_ByteBuffer_ == null)
				cb_queueInput_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_QueueInput_Ljava_nio_ByteBuffer_);
			return cb_queueInput_Ljava_nio_ByteBuffer_;
		}

		static void n_QueueInput_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueueInput (p0);
		}
#pragma warning restore 0169

		IntPtr id_queueInput_Ljava_nio_ByteBuffer_;
		public unsafe void QueueInput (global::Java.Nio.ByteBuffer p0)
		{
			if (id_queueInput_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_queueInput_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "queueInput", "(Ljava/nio/ByteBuffer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueInput_Ljava_nio_ByteBuffer_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}
}
