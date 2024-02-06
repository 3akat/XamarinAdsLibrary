using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DtsUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/DtsUtil", DoNotGenerateAcw=true)]
	public sealed partial class DtsUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/DtsUtil", typeof (DtsUtil));

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

		internal DtsUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DtsUtil']/method[@name='getDtsFrameSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getDtsFrameSize", "([B)I", "")]
		public static unsafe int GetDtsFrameSize (byte[] data)
		{
			const string __id = "getDtsFrameSize.([B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DtsUtil']/method[@name='isSyncWord' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSyncWord", "(I)Z", "")]
		public static unsafe bool IsSyncWord (int word)
		{
			const string __id = "isSyncWord.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (word);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DtsUtil']/method[@name='parseDtsAudioSampleCount' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseDtsAudioSampleCount", "([B)I", "")]
		public static unsafe int ParseDtsAudioSampleCount (byte[] data)
		{
			const string __id = "parseDtsAudioSampleCount.([B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DtsUtil']/method[@name='parseDtsAudioSampleCount' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseDtsAudioSampleCount", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ParseDtsAudioSampleCount (global::Java.Nio.ByteBuffer buffer)
		{
			const string __id = "parseDtsAudioSampleCount.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DtsUtil']/method[@name='parseDtsFormat' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("parseDtsFormat", "([BLjava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format ParseDtsFormat (byte[] frame, string trackId, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "parseDtsFormat.([BLjava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_frame = JNIEnv.NewArray (frame);
			IntPtr native_trackId = JNIEnv.NewString (trackId);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_frame);
				__args [1] = new JniArgumentValue (native_trackId);
				__args [2] = new JniArgumentValue (native_language);
				__args [3] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (frame != null) {
					JNIEnv.CopyArray (native_frame, frame);
					JNIEnv.DeleteLocalRef (native_frame);
				}
				JNIEnv.DeleteLocalRef (native_trackId);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (frame);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

	}
}
