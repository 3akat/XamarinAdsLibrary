using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Cea708InitializationData']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Cea708InitializationData", DoNotGenerateAcw=true)]
	public sealed partial class Cea708InitializationData : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Cea708InitializationData']/field[@name='isWideAspectRatio']"
		[Register ("isWideAspectRatio")]
		public bool IsWideAspectRatio {
			get {
				const string __id = "isWideAspectRatio.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isWideAspectRatio.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Cea708InitializationData", typeof (Cea708InitializationData));

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

		internal Cea708InitializationData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Cea708InitializationData']/method[@name='buildData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildData", "(Z)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<byte[]> BuildData (bool isWideAspectRatio)
		{
			const string __id = "buildData.(Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isWideAspectRatio);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Cea708InitializationData']/method[@name='fromData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;byte[]&gt;']]"
		[Register ("fromData", "(Ljava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Cea708InitializationData;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Cea708InitializationData FromData (global::System.Collections.Generic.IList<byte[]> initializationData)
		{
			const string __id = "fromData.(Ljava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Cea708InitializationData;";
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_initializationData);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Cea708InitializationData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_initializationData);
				global::System.GC.KeepAlive (initializationData);
			}
		}

	}
}
