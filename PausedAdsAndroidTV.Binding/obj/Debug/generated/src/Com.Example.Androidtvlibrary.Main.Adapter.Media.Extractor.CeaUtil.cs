using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CeaUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/CeaUtil", DoNotGenerateAcw=true)]
	public sealed partial class CeaUtil : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CeaUtil']/field[@name='USER_DATA_IDENTIFIER_GA94']"
		[Register ("USER_DATA_IDENTIFIER_GA94")]
		public const int UserDataIdentifierGa94 = (int) 1195456820;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CeaUtil']/field[@name='USER_DATA_TYPE_CODE_MPEG_CC']"
		[Register ("USER_DATA_TYPE_CODE_MPEG_CC")]
		public const int UserDataTypeCodeMpegCc = (int) 3;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/CeaUtil", typeof (CeaUtil));

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

		internal CeaUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CeaUtil']/method[@name='consume' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput[]']]"
		[Register ("consume", "(JLcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;[Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V", "")]
		public static unsafe void Consume (long presentationTimeUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray seiBuffer, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput[] outputs)
		{
			const string __id = "consume.(JLcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;[Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V";
			IntPtr native_outputs = JNIEnv.NewArray (outputs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (presentationTimeUs);
				__args [1] = new JniArgumentValue ((seiBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seiBuffer).Handle);
				__args [2] = new JniArgumentValue (native_outputs);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outputs != null) {
					JNIEnv.CopyArray (native_outputs, outputs);
					JNIEnv.DeleteLocalRef (native_outputs);
				}
				global::System.GC.KeepAlive (seiBuffer);
				global::System.GC.KeepAlive (outputs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='CeaUtil']/method[@name='consumeCcData' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput[]']]"
		[Register ("consumeCcData", "(JLcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;[Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V", "")]
		public static unsafe void ConsumeCcData (long presentationTimeUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray ccDataBuffer, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput[] outputs)
		{
			const string __id = "consumeCcData.(JLcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;[Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V";
			IntPtr native_outputs = JNIEnv.NewArray (outputs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (presentationTimeUs);
				__args [1] = new JniArgumentValue ((ccDataBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ccDataBuffer).Handle);
				__args [2] = new JniArgumentValue (native_outputs);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outputs != null) {
					JNIEnv.CopyArray (native_outputs, outputs);
					JNIEnv.DeleteLocalRef (native_outputs);
				}
				global::System.GC.KeepAlive (ccDataBuffer);
				global::System.GC.KeepAlive (outputs);
			}
		}

	}
}
