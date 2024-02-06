using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader", DoNotGenerateAcw=true)]
	public sealed partial class MpegAudioHeader : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='bitrate']"
		[Register ("bitrate")]
		public int Bitrate {
			get {
				const string __id = "bitrate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bitrate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='channels']"
		[Register ("channels")]
		public int Channels {
			get {
				const string __id = "channels.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "channels.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='frameSize']"
		[Register ("frameSize")]
		public int FrameSize {
			get {
				const string __id = "frameSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "frameSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='MAX_FRAME_SIZE_BYTES']"
		[Register ("MAX_FRAME_SIZE_BYTES")]
		public const int MaxFrameSizeBytes = (int) 4096;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='mimeType']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='sampleRate']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='samplesPerFrame']"
		[Register ("samplesPerFrame")]
		public int SamplesPerFrame {
			get {
				const string __id = "samplesPerFrame.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "samplesPerFrame.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/field[@name='version']"
		[Register ("version")]
		public int Version {
			get {
				const string __id = "version.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "version.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader", typeof (MpegAudioHeader));

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

		internal MpegAudioHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/constructor[@name='MpegAudioHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MpegAudioHeader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/method[@name='getFrameSampleCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFrameSampleCount", "(I)I", "")]
		public static unsafe int GetFrameSampleCount (int header)
		{
			const string __id = "getFrameSampleCount.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (header);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/method[@name='getFrameSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFrameSize", "(I)I", "")]
		public static unsafe int GetFrameSize (int header)
		{
			const string __id = "getFrameSize.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (header);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='MpegAudioHeader']/method[@name='populateHeader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.mp3.MpegAudioHeader']]"
		[Register ("populateHeader", "(ILcom/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader;)Z", "")]
		public static unsafe bool PopulateHeader (int headerData, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MpegAudioHeader header)
		{
			const string __id = "populateHeader.(ILcom/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (headerData);
				__args [1] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (header);
			}
		}

	}
}
