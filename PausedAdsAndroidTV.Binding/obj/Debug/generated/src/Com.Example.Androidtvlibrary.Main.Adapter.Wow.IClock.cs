using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	[Register ("com/example/androidtvlibrary/main/adapter/wow/Clock", DoNotGenerateAcw=true)]
	public abstract class Clock : Java.Lang.Object {
		internal Clock ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock Default {
			get {
				const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/wow/Clock;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/Clock", typeof (Clock));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/wow/Clock", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Clock' type. This type will be removed in a future release.", error: true)]
	public abstract class ClockConsts : Clock {
		private ClockConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/Clock", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClockInvoker")]
	public partial interface IClock : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/method[@name='createHandler' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)Lcom/example/androidtvlibrary/main/adapter/wow/HandlerWrapper;", "GetCreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClockInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper CreateHandler (global::Android.OS.Looper p0, global::Android.OS.Handler.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/method[@name='currentTimeMillis' and count(parameter)=0]"
		[Register ("currentTimeMillis", "()J", "GetCurrentTimeMillisHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClockInvoker, PausedAdsAndroidTV.Binding")]
		long CurrentTimeMillis ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/method[@name='elapsedRealtime' and count(parameter)=0]"
		[Register ("elapsedRealtime", "()J", "GetElapsedRealtimeHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClockInvoker, PausedAdsAndroidTV.Binding")]
		long ElapsedRealtime ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("sleep", "(J)V", "GetSleep_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClockInvoker, PausedAdsAndroidTV.Binding")]
		void Sleep (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Clock']/method[@name='uptimeMillis' and count(parameter)=0]"
		[Register ("uptimeMillis", "()J", "GetUptimeMillisHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClockInvoker, PausedAdsAndroidTV.Binding")]
		long UptimeMillis ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/Clock", DoNotGenerateAcw=true)]
	internal partial class IClockInvoker : global::Java.Lang.Object, IClock {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/Clock", typeof (IClockInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IClock GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClock> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.Clock'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_;
#pragma warning disable 0169
		static Delegate GetCreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_Handler ()
		{
			if (cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ == null)
				cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_);
			return cb_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_;
		}

		static IntPtr n_CreateHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.OS.Handler.ICallback)global::Java.Lang.Object.GetObject<global::Android.OS.Handler.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHandler (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper CreateHandler (global::Android.OS.Looper p0, global::Android.OS.Handler.ICallback p1)
		{
			if (id_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ == IntPtr.Zero)
				id_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_ = JNIEnv.GetMethodID (class_ref, "createHandler", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)Lcom/example/androidtvlibrary/main/adapter/wow/HandlerWrapper;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createHandler_Landroid_os_Looper_Landroid_os_Handler_Callback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeMillis ();
		}
#pragma warning restore 0169

		IntPtr id_currentTimeMillis;
		public unsafe long CurrentTimeMillis ()
		{
			if (id_currentTimeMillis == IntPtr.Zero)
				id_currentTimeMillis = JNIEnv.GetMethodID (class_ref, "currentTimeMillis", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_currentTimeMillis);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedRealtime ();
		}
#pragma warning restore 0169

		IntPtr id_elapsedRealtime;
		public unsafe long ElapsedRealtime ()
		{
			if (id_elapsedRealtime == IntPtr.Zero)
				id_elapsedRealtime = JNIEnv.GetMethodID (class_ref, "elapsedRealtime", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_elapsedRealtime);
		}

		static Delegate cb_sleep_J;
#pragma warning disable 0169
		static Delegate GetSleep_JHandler ()
		{
			if (cb_sleep_J == null)
				cb_sleep_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Sleep_J);
			return cb_sleep_J;
		}

		static void n_Sleep_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sleep (p0);
		}
#pragma warning restore 0169

		IntPtr id_sleep_J;
		public unsafe void Sleep (long p0)
		{
			if (id_sleep_J == IntPtr.Zero)
				id_sleep_J = JNIEnv.GetMethodID (class_ref, "sleep", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sleep_J, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UptimeMillis ();
		}
#pragma warning restore 0169

		IntPtr id_uptimeMillis;
		public unsafe long UptimeMillis ()
		{
			if (id_uptimeMillis == IntPtr.Zero)
				id_uptimeMillis = JNIEnv.GetMethodID (class_ref, "uptimeMillis", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_uptimeMillis);
		}

	}
}
