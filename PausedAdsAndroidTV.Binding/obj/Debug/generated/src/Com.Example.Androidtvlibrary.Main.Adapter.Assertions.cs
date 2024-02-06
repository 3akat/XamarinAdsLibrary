using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Assertions", DoNotGenerateAcw=true)]
	public sealed partial class Assertions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Assertions", typeof (Assertions));

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

		internal Assertions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkArgument", "(Z)V", "")]
		public static unsafe void CheckArgument (bool expression)
		{
			const string __id = "checkArgument.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expression);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkArgument", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool expression, global::Java.Lang.Object errorMessage)
		{
			const string __id = "checkArgument.(ZLjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expression);
				__args [1] = new JniArgumentValue ((errorMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorMessage).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (errorMessage);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkIndex", "(III)I", "")]
		public static unsafe int CheckIndex (int index, int start, int limit)
		{
			const string __id = "checkIndex.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (limit);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkMainThread' and count(parameter)=0]"
		[Register ("checkMainThread", "()V", "")]
		public static unsafe void CheckMainThread ()
		{
			const string __id = "checkMainThread.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkNotEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkNotEmpty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CheckNotEmpty (string @string)
		{
			const string __id = "checkNotEmpty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkNotEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotEmpty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string CheckNotEmpty (string @string, global::Java.Lang.Object errorMessage)
		{
			const string __id = "checkNotEmpty.(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue ((errorMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorMessage).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				global::System.GC.KeepAlive (errorMessage);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object reference)
		{
			const string __id = "checkNotNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_reference = JNIEnv.ToLocalJniHandle (reference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reference);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_reference);
				global::System.GC.KeepAlive (reference);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object reference, global::Java.Lang.Object errorMessage)
		{
			const string __id = "checkNotNull.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_reference = JNIEnv.ToLocalJniHandle (reference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_reference);
				__args [1] = new JniArgumentValue ((errorMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorMessage).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_reference);
				global::System.GC.KeepAlive (reference);
				global::System.GC.KeepAlive (errorMessage);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkState", "(Z)V", "")]
		public static unsafe void CheckState (bool expression)
		{
			const string __id = "checkState.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expression);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkState", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool expression, global::Java.Lang.Object errorMessage)
		{
			const string __id = "checkState.(ZLjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (expression);
				__args [1] = new JniArgumentValue ((errorMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorMessage).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (errorMessage);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkStateNotNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkStateNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckStateNotNull (global::Java.Lang.Object reference)
		{
			const string __id = "checkStateNotNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_reference = JNIEnv.ToLocalJniHandle (reference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reference);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_reference);
				global::System.GC.KeepAlive (reference);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Assertions']/method[@name='checkStateNotNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkStateNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckStateNotNull (global::Java.Lang.Object reference, global::Java.Lang.Object errorMessage)
		{
			const string __id = "checkStateNotNull.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_reference = JNIEnv.ToLocalJniHandle (reference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_reference);
				__args [1] = new JniArgumentValue ((errorMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorMessage).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_reference);
				global::System.GC.KeepAlive (reference);
				global::System.GC.KeepAlive (errorMessage);
			}
		}

	}
}
