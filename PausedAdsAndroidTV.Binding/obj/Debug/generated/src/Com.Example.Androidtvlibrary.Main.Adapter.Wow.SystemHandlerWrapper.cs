using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/SystemHandlerWrapper", DoNotGenerateAcw=true)]
	public sealed partial class SystemHandlerWrapper : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/SystemHandlerWrapper", typeof (SystemHandlerWrapper));

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

		internal SystemHandlerWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/constructor[@name='SystemHandlerWrapper' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe SystemHandlerWrapper (global::Android.OS.Handler handler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Handler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		public unsafe global::Android.OS.Looper Looper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='getLooper' and count(parameter)=0]"
			[Register ("getLooper", "()Landroid/os/Looper;", "")]
			get {
				const string __id = "getLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='obtainMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("obtainMessage", "(I)Landroid/os/Message;", "")]
		public unsafe global::Android.OS.Message ObtainMessage (int what)
		{
			const string __id = "obtainMessage.(I)Landroid/os/Message;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (what);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Message> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='obtainMessage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("obtainMessage", "(III)Landroid/os/Message;", "")]
		public unsafe global::Android.OS.Message ObtainMessage (int what, int arg1, int arg2)
		{
			const string __id = "obtainMessage.(III)Landroid/os/Message;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue (arg1);
				__args [2] = new JniArgumentValue (arg2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Message> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='obtainMessage' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object']]"
		[Register ("obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;", "")]
		public unsafe global::Android.OS.Message ObtainMessage (int what, int arg1, int arg2, global::Java.Lang.Object obj)
		{
			const string __id = "obtainMessage.(IIILjava/lang/Object;)Landroid/os/Message;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue (arg1);
				__args [2] = new JniArgumentValue (arg2);
				__args [3] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Message> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='obtainMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;", "")]
		public unsafe global::Android.OS.Message ObtainMessage (int what, global::Java.Lang.Object obj)
		{
			const string __id = "obtainMessage.(ILjava/lang/Object;)Landroid/os/Message;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Message> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("post", "(Ljava/lang/Runnable;)Z", "")]
		public unsafe bool Post (global::Java.Lang.IRunnable runnable)
		{
			const string __id = "post.(Ljava/lang/Runnable;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (runnable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='postDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("postDelayed", "(Ljava/lang/Runnable;J)Z", "")]
		public unsafe bool PostDelayed (global::Java.Lang.IRunnable runnable, long delayMs)
		{
			const string __id = "postDelayed.(Ljava/lang/Runnable;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
				__args [1] = new JniArgumentValue (delayMs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (runnable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='removeCallbacksAndMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeCallbacksAndMessages", "(Ljava/lang/Object;)V", "")]
		public unsafe void RemoveCallbacksAndMessages (global::Java.Lang.Object token)
		{
			const string __id = "removeCallbacksAndMessages.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (token);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='removeMessages' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeMessages", "(I)V", "")]
		public unsafe void RemoveMessages (int what)
		{
			const string __id = "removeMessages.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (what);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='sendEmptyMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendEmptyMessage", "(I)Z", "")]
		public unsafe bool SendEmptyMessage (int what)
		{
			const string __id = "sendEmptyMessage.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (what);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemHandlerWrapper']/method[@name='sendEmptyMessageAtTime' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("sendEmptyMessageAtTime", "(IJ)Z", "")]
		public unsafe bool SendEmptyMessageAtTime (int what, long uptimeMs)
		{
			const string __id = "sendEmptyMessageAtTime.(IJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (what);
				__args [1] = new JniArgumentValue (uptimeMs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
