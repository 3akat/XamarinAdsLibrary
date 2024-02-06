using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Drmsession {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ClearKeyUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ClearKeyUtil", DoNotGenerateAcw=true)]
	public sealed partial class ClearKeyUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ClearKeyUtil", typeof (ClearKeyUtil));

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

		internal ClearKeyUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ClearKeyUtil']/method[@name='adjustRequestData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("adjustRequestData", "([B)[B", "")]
		public static unsafe byte[] AdjustRequestData (byte[] request)
		{
			const string __id = "adjustRequestData.([B)[B";
			IntPtr native_request = JNIEnv.NewArray (request);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_request);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (request != null) {
					JNIEnv.CopyArray (native_request, request);
					JNIEnv.DeleteLocalRef (native_request);
				}
				global::System.GC.KeepAlive (request);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ClearKeyUtil']/method[@name='adjustResponseData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("adjustResponseData", "([B)[B", "")]
		public static unsafe byte[] AdjustResponseData (byte[] response)
		{
			const string __id = "adjustResponseData.([B)[B";
			IntPtr native_response = JNIEnv.NewArray (response);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_response);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (response != null) {
					JNIEnv.CopyArray (native_response, response);
					JNIEnv.DeleteLocalRef (native_response);
				}
				global::System.GC.KeepAlive (response);
			}
		}

	}
}
