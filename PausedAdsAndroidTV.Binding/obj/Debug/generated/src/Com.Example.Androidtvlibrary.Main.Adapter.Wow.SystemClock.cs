using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/SystemClock", DoNotGenerateAcw=true)]
	public partial class SystemClock : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock {
		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.wow.Clock


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock Default {
				get {
					const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/wow/Clock;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/SystemClock", typeof (SystemClock));

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

		protected SystemClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']/constructor[@name='SystemClock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe SystemClock () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetCreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_Handler ()
		{
			if (cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ == null)
				cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_);
			return cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_;
		}

		static IntPtr n_CreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_looper, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SystemClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var looper = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_looper, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHandler (looper, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']/method[@name='createHandler' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)Lcom/example/androidtvlibrary/main/adapter/wow/HandlerWrapper;", "GetCreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_Handler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper CreateHandler (global::Android.OS.Looper looper, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "createHandler.(Landroid/os/Looper;Landroid/os/Handler$Callback;)Lcom/example/androidtvlibrary/main/adapter/wow/HandlerWrapper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (looper);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_currentTimeMillis;
#pragma warning disable 0169
		static Delegate GetCurrentTimeMillisHandler ()
		{
			if (cb_currentTimeMillis == null)
				cb_currentTimeMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_CurrentTimeMillis);
			return cb_currentTimeMillis;
		}

		static long n_CurrentTimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SystemClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeMillis ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']/method[@name='currentTimeMillis' and count(parameter)=0]"
		[Register ("currentTimeMillis", "()J", "GetCurrentTimeMillisHandler")]
		public virtual unsafe long CurrentTimeMillis ()
		{
			const string __id = "currentTimeMillis.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_elapsedRealtime;
#pragma warning disable 0169
		static Delegate GetElapsedRealtimeHandler ()
		{
			if (cb_elapsedRealtime == null)
				cb_elapsedRealtime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_ElapsedRealtime);
			return cb_elapsedRealtime;
		}

		static long n_ElapsedRealtime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SystemClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedRealtime ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']/method[@name='elapsedRealtime' and count(parameter)=0]"
		[Register ("elapsedRealtime", "()J", "GetElapsedRealtimeHandler")]
		public virtual unsafe long ElapsedRealtime ()
		{
			const string __id = "elapsedRealtime.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sleep_J;
#pragma warning disable 0169
		static Delegate GetSleep_JHandler ()
		{
			if (cb_sleep_J == null)
				cb_sleep_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Sleep_J);
			return cb_sleep_J;
		}

		static void n_Sleep_J (IntPtr jnienv, IntPtr native__this, long sleepTimeMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SystemClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sleep (sleepTimeMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("sleep", "(J)V", "GetSleep_JHandler")]
		public virtual unsafe void Sleep (long sleepTimeMs)
		{
			const string __id = "sleep.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sleepTimeMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_uptimeMillis;
#pragma warning disable 0169
		static Delegate GetUptimeMillisHandler ()
		{
			if (cb_uptimeMillis == null)
				cb_uptimeMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_UptimeMillis);
			return cb_uptimeMillis;
		}

		static long n_UptimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SystemClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UptimeMillis ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SystemClock']/method[@name='uptimeMillis' and count(parameter)=0]"
		[Register ("uptimeMillis", "()J", "GetUptimeMillisHandler")]
		public virtual unsafe long UptimeMillis ()
		{
			const string __id = "uptimeMillis.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
