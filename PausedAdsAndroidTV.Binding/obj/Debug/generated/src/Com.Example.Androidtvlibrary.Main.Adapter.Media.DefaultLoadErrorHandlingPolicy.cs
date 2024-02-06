using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/DefaultLoadErrorHandlingPolicy", DoNotGenerateAcw=true)]
	public partial class DefaultLoadErrorHandlingPolicy : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicy {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/field[@name='DEFAULT_MIN_LOADABLE_RETRY_COUNT']"
		[Register ("DEFAULT_MIN_LOADABLE_RETRY_COUNT")]
		public const int DefaultMinLoadableRetryCount = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/field[@name='DEFAULT_MIN_LOADABLE_RETRY_COUNT_PROGRESSIVE_LIVE']"
		[Register ("DEFAULT_MIN_LOADABLE_RETRY_COUNT_PROGRESSIVE_LIVE")]
		public const int DefaultMinLoadableRetryCountProgressiveLive = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/field[@name='DEFAULT_TRACK_BLACKLIST_MS']"
		[Register ("DEFAULT_TRACK_BLACKLIST_MS")]
		public const long DefaultTrackBlacklistMs = (long) 60000;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/DefaultLoadErrorHandlingPolicy", typeof (DefaultLoadErrorHandlingPolicy));

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

		protected DefaultLoadErrorHandlingPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/constructor[@name='DefaultLoadErrorHandlingPolicy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultLoadErrorHandlingPolicy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/constructor[@name='DefaultLoadErrorHandlingPolicy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DefaultLoadErrorHandlingPolicy (int minimumLoadableRetryCount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minimumLoadableRetryCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I;
#pragma warning disable 0169
		static Delegate GetGetBlacklistDurationMsFor_IJLjava_io_IOException_IHandler ()
		{
			if (cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I == null)
				cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJLI_J) n_GetBlacklistDurationMsFor_IJLjava_io_IOException_I);
			return cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I;
		}

		static long n_GetBlacklistDurationMsFor_IJLjava_io_IOException_I (IntPtr jnienv, IntPtr native__this, int dataType, long loadDurationMs, IntPtr native_exception, int errorCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultLoadErrorHandlingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_exception, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetBlacklistDurationMsFor (dataType, loadDurationMs, exception, errorCount);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/method[@name='getBlacklistDurationMsFor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.IOException'] and parameter[4][@type='int']]"
		[Register ("getBlacklistDurationMsFor", "(IJLjava/io/IOException;I)J", "GetGetBlacklistDurationMsFor_IJLjava_io_IOException_IHandler")]
		public virtual unsafe long GetBlacklistDurationMsFor (int dataType, long loadDurationMs, global::Java.IO.IOException exception, int errorCount)
		{
			const string __id = "getBlacklistDurationMsFor.(IJLjava/io/IOException;I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (dataType);
				__args [1] = new JniArgumentValue (loadDurationMs);
				__args [2] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				__args [3] = new JniArgumentValue (errorCount);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

		static Delegate cb_getMinimumLoadableRetryCount_I;
#pragma warning disable 0169
		static Delegate GetGetMinimumLoadableRetryCount_IHandler ()
		{
			if (cb_getMinimumLoadableRetryCount_I == null)
				cb_getMinimumLoadableRetryCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetMinimumLoadableRetryCount_I);
			return cb_getMinimumLoadableRetryCount_I;
		}

		static int n_GetMinimumLoadableRetryCount_I (IntPtr jnienv, IntPtr native__this, int dataType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultLoadErrorHandlingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMinimumLoadableRetryCount (dataType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/method[@name='getMinimumLoadableRetryCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMinimumLoadableRetryCount", "(I)I", "GetGetMinimumLoadableRetryCount_IHandler")]
		public virtual unsafe int GetMinimumLoadableRetryCount (int dataType)
		{
			const string __id = "getMinimumLoadableRetryCount.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dataType);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getRetryDelayMsFor_IJLjava_io_IOException_I;
#pragma warning disable 0169
		static Delegate GetGetRetryDelayMsFor_IJLjava_io_IOException_IHandler ()
		{
			if (cb_getRetryDelayMsFor_IJLjava_io_IOException_I == null)
				cb_getRetryDelayMsFor_IJLjava_io_IOException_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJLI_J) n_GetRetryDelayMsFor_IJLjava_io_IOException_I);
			return cb_getRetryDelayMsFor_IJLjava_io_IOException_I;
		}

		static long n_GetRetryDelayMsFor_IJLjava_io_IOException_I (IntPtr jnienv, IntPtr native__this, int dataType, long loadDurationMs, IntPtr native_exception, int errorCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultLoadErrorHandlingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_exception, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetRetryDelayMsFor (dataType, loadDurationMs, exception, errorCount);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultLoadErrorHandlingPolicy']/method[@name='getRetryDelayMsFor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.IOException'] and parameter[4][@type='int']]"
		[Register ("getRetryDelayMsFor", "(IJLjava/io/IOException;I)J", "GetGetRetryDelayMsFor_IJLjava_io_IOException_IHandler")]
		public virtual unsafe long GetRetryDelayMsFor (int dataType, long loadDurationMs, global::Java.IO.IOException exception, int errorCount)
		{
			const string __id = "getRetryDelayMsFor.(IJLjava/io/IOException;I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (dataType);
				__args [1] = new JniArgumentValue (loadDurationMs);
				__args [2] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				__args [3] = new JniArgumentValue (errorCount);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

	}
}
