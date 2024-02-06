using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/CodecSpecificDataUtil", DoNotGenerateAcw=true)]
	public sealed partial class CodecSpecificDataUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/CodecSpecificDataUtil", typeof (CodecSpecificDataUtil));

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

		internal CodecSpecificDataUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='buildAacAudioSpecificConfig' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildAacAudioSpecificConfig", "(III)[B", "")]
		public static unsafe byte[] BuildAacAudioSpecificConfig (int audioObjectType, int sampleRateIndex, int channelConfig)
		{
			const string __id = "buildAacAudioSpecificConfig.(III)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (audioObjectType);
				__args [1] = new JniArgumentValue (sampleRateIndex);
				__args [2] = new JniArgumentValue (channelConfig);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='buildAacLcAudioSpecificConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("buildAacLcAudioSpecificConfig", "(II)[B", "")]
		public static unsafe byte[] BuildAacLcAudioSpecificConfig (int sampleRate, int channelCount)
		{
			const string __id = "buildAacLcAudioSpecificConfig.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sampleRate);
				__args [1] = new JniArgumentValue (channelCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='buildAvcCodecString' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildAvcCodecString", "(III)Ljava/lang/String;", "")]
		public static unsafe string BuildAvcCodecString (int profileIdc, int constraintsFlagsAndReservedZero2Bits, int levelIdc)
		{
			const string __id = "buildAvcCodecString.(III)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (profileIdc);
				__args [1] = new JniArgumentValue (constraintsFlagsAndReservedZero2Bits);
				__args [2] = new JniArgumentValue (levelIdc);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='buildNalUnit' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildNalUnit", "([BII)[B", "")]
		public static unsafe byte[] BuildNalUnit (byte[] data, int offset, int length)
		{
			const string __id = "buildNalUnit.([BII)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='parseAacAudioSpecificConfig' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseAacAudioSpecificConfig", "([B)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair ParseAacAudioSpecificConfig (byte[] audioSpecificConfig)
		{
			const string __id = "parseAacAudioSpecificConfig.([B)Landroid/util/Pair;";
			IntPtr native_audioSpecificConfig = JNIEnv.NewArray (audioSpecificConfig);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_audioSpecificConfig);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (audioSpecificConfig != null) {
					JNIEnv.CopyArray (native_audioSpecificConfig, audioSpecificConfig);
					JNIEnv.DeleteLocalRef (native_audioSpecificConfig);
				}
				global::System.GC.KeepAlive (audioSpecificConfig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='parseAacAudioSpecificConfig' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableBitArray'] and parameter[2][@type='boolean']]"
		[Register ("parseAacAudioSpecificConfig", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;Z)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair ParseAacAudioSpecificConfig (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableBitArray bitArray, bool forceReadToEnd)
		{
			const string __id = "parseAacAudioSpecificConfig.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;Z)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitArray).Handle);
				__args [1] = new JniArgumentValue (forceReadToEnd);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bitArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='parseAlacAudioSpecificConfig' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseAlacAudioSpecificConfig", "([B)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair ParseAlacAudioSpecificConfig (byte[] audioSpecificConfig)
		{
			const string __id = "parseAlacAudioSpecificConfig.([B)Landroid/util/Pair;";
			IntPtr native_audioSpecificConfig = JNIEnv.NewArray (audioSpecificConfig);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_audioSpecificConfig);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (audioSpecificConfig != null) {
					JNIEnv.CopyArray (native_audioSpecificConfig, audioSpecificConfig);
					JNIEnv.DeleteLocalRef (native_audioSpecificConfig);
				}
				global::System.GC.KeepAlive (audioSpecificConfig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CodecSpecificDataUtil']/method[@name='splitNalUnits' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("splitNalUnits", "([B)[[B", "")]
		public static unsafe byte[][] SplitNalUnits (byte[] data)
		{
			const string __id = "splitNalUnits.([B)[[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[][]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte[]));
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
