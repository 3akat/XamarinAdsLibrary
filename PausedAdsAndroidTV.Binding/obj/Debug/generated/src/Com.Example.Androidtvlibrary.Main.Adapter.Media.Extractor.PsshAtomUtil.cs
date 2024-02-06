using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/PsshAtomUtil", DoNotGenerateAcw=true)]
	public sealed partial class PsshAtomUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/PsshAtomUtil", typeof (PsshAtomUtil));

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

		internal PsshAtomUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']/method[@name='buildPsshAtom' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("buildPsshAtom", "(Ljava/util/UUID;[B)[B", "")]
		public static unsafe byte[] BuildPsshAtom (global::Java.Util.UUID systemId, byte[] data)
		{
			const string __id = "buildPsshAtom.(Ljava/util/UUID;[B)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((systemId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) systemId).Handle);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (systemId);
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']/method[@name='buildPsshAtom' and count(parameter)=3 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID[]'] and parameter[3][@type='byte[]']]"
		[Register ("buildPsshAtom", "(Ljava/util/UUID;[Ljava/util/UUID;[B)[B", "")]
		public static unsafe byte[] BuildPsshAtom (global::Java.Util.UUID systemId, global::Java.Util.UUID[] keyIds, byte[] data)
		{
			const string __id = "buildPsshAtom.(Ljava/util/UUID;[Ljava/util/UUID;[B)[B";
			IntPtr native_keyIds = JNIEnv.NewArray (keyIds);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((systemId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) systemId).Handle);
				__args [1] = new JniArgumentValue (native_keyIds);
				__args [2] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (keyIds != null) {
					JNIEnv.CopyArray (native_keyIds, keyIds);
					JNIEnv.DeleteLocalRef (native_keyIds);
				}
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (systemId);
				global::System.GC.KeepAlive (keyIds);
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']/method[@name='isPsshAtom' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isPsshAtom", "([B)Z", "")]
		public static unsafe bool IsPsshAtom (byte[] data)
		{
			const string __id = "isPsshAtom.([B)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']/method[@name='parseSchemeSpecificData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.UUID']]"
		[Register ("parseSchemeSpecificData", "([BLjava/util/UUID;)[B", "")]
		public static unsafe byte[] ParseSchemeSpecificData (byte[] atom, global::Java.Util.UUID uuid)
		{
			const string __id = "parseSchemeSpecificData.([BLjava/util/UUID;)[B";
			IntPtr native_atom = JNIEnv.NewArray (atom);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_atom);
				__args [1] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (atom != null) {
					JNIEnv.CopyArray (native_atom, atom);
					JNIEnv.DeleteLocalRef (native_atom);
				}
				global::System.GC.KeepAlive (atom);
				global::System.GC.KeepAlive (uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']/method[@name='parseUuid' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseUuid", "([B)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID ParseUuid (byte[] atom)
		{
			const string __id = "parseUuid.([B)Ljava/util/UUID;";
			IntPtr native_atom = JNIEnv.NewArray (atom);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_atom);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (atom != null) {
					JNIEnv.CopyArray (native_atom, atom);
					JNIEnv.DeleteLocalRef (native_atom);
				}
				global::System.GC.KeepAlive (atom);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='PsshAtomUtil']/method[@name='parseVersion' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseVersion", "([B)I", "")]
		public static unsafe int ParseVersion (byte[] atom)
		{
			const string __id = "parseVersion.([B)I";
			IntPtr native_atom = JNIEnv.NewArray (atom);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_atom);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (atom != null) {
					JNIEnv.CopyArray (native_atom, atom);
					JNIEnv.DeleteLocalRef (native_atom);
				}
				global::System.GC.KeepAlive (atom);
			}
		}

	}
}
