using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac4Util", DoNotGenerateAcw=true)]
	public sealed partial class Ac4Util : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/field[@name='AC40_SYNCWORD']"
		[Register ("AC40_SYNCWORD")]
		public const int Ac40Syncword = (int) 44096;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/field[@name='AC41_SYNCWORD']"
		[Register ("AC41_SYNCWORD")]
		public const int Ac41Syncword = (int) 44097;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/field[@name='HEADER_SIZE_FOR_PARSER']"
		[Register ("HEADER_SIZE_FOR_PARSER")]
		public const int HeaderSizeForParser = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/field[@name='SAMPLE_HEADER_SIZE']"
		[Register ("SAMPLE_HEADER_SIZE")]
		public const int SampleHeaderSize = (int) 7;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util.SyncFrameInfo']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac4Util$SyncFrameInfo", DoNotGenerateAcw=true)]
		public sealed partial class SyncFrameInfo : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util.SyncFrameInfo']/field[@name='bitstreamVersion']"
			[Register ("bitstreamVersion")]
			public int BitstreamVersion {
				get {
					const string __id = "bitstreamVersion.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "bitstreamVersion.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util.SyncFrameInfo']/field[@name='channelCount']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util.SyncFrameInfo']/field[@name='frameSize']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util.SyncFrameInfo']/field[@name='sampleCount']"
			[Register ("sampleCount")]
			public int SampleCount {
				get {
					const string __id = "sampleCount.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sampleCount.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util.SyncFrameInfo']/field[@name='sampleRate']"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac4Util$SyncFrameInfo", typeof (SyncFrameInfo));

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

			internal SyncFrameInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac4Util", typeof (Ac4Util));

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

		internal Ac4Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/method[@name='getAc4SampleHeader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("getAc4SampleHeader", "(ILcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "")]
		public static unsafe void GetAc4SampleHeader (int size, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray buffer)
		{
			const string __id = "getAc4SampleHeader.(ILcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (size);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/method[@name='parseAc4AnnexEFormat' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("parseAc4AnnexEFormat", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format ParseAc4AnnexEFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, string trackId, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "parseAc4AnnexEFormat.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_trackId = JNIEnv.NewString (trackId);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (native_trackId);
				__args [2] = new JniArgumentValue (native_language);
				__args [3] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_trackId);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/method[@name='parseAc4SyncframeAudioSampleCount' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseAc4SyncframeAudioSampleCount", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ParseAc4SyncframeAudioSampleCount (global::Java.Nio.ByteBuffer buffer)
		{
			const string __id = "parseAc4SyncframeAudioSampleCount.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/method[@name='parseAc4SyncframeInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableBitArray']]"
		[Register ("parseAc4SyncframeInfo", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Ac4Util$SyncFrameInfo;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac4Util.SyncFrameInfo ParseAc4SyncframeInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableBitArray data)
		{
			const string __id = "parseAc4SyncframeInfo.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Ac4Util$SyncFrameInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac4Util.SyncFrameInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac4Util']/method[@name='parseAc4SyncframeSize' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parseAc4SyncframeSize", "([BI)I", "")]
		public static unsafe int ParseAc4SyncframeSize (byte[] data, int syncword)
		{
			const string __id = "parseAc4SyncframeSize.([BI)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (syncword);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
