using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='ProjectionDecoder']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/ProjectionDecoder", DoNotGenerateAcw=true)]
	public sealed partial class ProjectionDecoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/ProjectionDecoder", typeof (ProjectionDecoder));

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

		internal ProjectionDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='ProjectionDecoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decode", "([BI)Lcom/example/androidtvlibrary/main/adapter/player/Projection;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection Decode (byte[] projectionData, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", ""})]
		int stereoMode)
		{
			const string __id = "decode.([BI)Lcom/example/androidtvlibrary/main/adapter/player/Projection;";
			IntPtr native_projectionData = JNIEnv.NewArray (projectionData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_projectionData);
				__args [1] = new JniArgumentValue (stereoMode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (projectionData != null) {
					JNIEnv.CopyArray (native_projectionData, projectionData);
					JNIEnv.DeleteLocalRef (native_projectionData);
				}
				global::System.GC.KeepAlive (projectionData);
			}
		}

	}
}
