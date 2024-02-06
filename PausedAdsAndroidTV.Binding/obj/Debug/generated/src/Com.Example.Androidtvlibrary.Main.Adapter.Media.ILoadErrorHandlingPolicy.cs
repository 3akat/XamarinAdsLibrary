using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoadErrorHandlingPolicy']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicyInvoker")]
	public partial interface ILoadErrorHandlingPolicy : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoadErrorHandlingPolicy']/method[@name='getBlacklistDurationMsFor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.IOException'] and parameter[4][@type='int']]"
		[Register ("getBlacklistDurationMsFor", "(IJLjava/io/IOException;I)J", "GetGetBlacklistDurationMsFor_IJLjava_io_IOException_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicyInvoker, PausedAdsAndroidTV.Binding")]
		long GetBlacklistDurationMsFor (int p0, long p1, global::Java.IO.IOException p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoadErrorHandlingPolicy']/method[@name='getMinimumLoadableRetryCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMinimumLoadableRetryCount", "(I)I", "GetGetMinimumLoadableRetryCount_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicyInvoker, PausedAdsAndroidTV.Binding")]
		int GetMinimumLoadableRetryCount (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoadErrorHandlingPolicy']/method[@name='getRetryDelayMsFor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.io.IOException'] and parameter[4][@type='int']]"
		[Register ("getRetryDelayMsFor", "(IJLjava/io/IOException;I)J", "GetGetRetryDelayMsFor_IJLjava_io_IOException_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicyInvoker, PausedAdsAndroidTV.Binding")]
		long GetRetryDelayMsFor (int p0, long p1, global::Java.IO.IOException p2, int p3);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy", DoNotGenerateAcw=true)]
	internal partial class ILoadErrorHandlingPolicyInvoker : global::Java.Lang.Object, ILoadErrorHandlingPolicy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy", typeof (ILoadErrorHandlingPolicyInvoker));

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

		public static ILoadErrorHandlingPolicy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadErrorHandlingPolicy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.LoadErrorHandlingPolicy'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadErrorHandlingPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I;
#pragma warning disable 0169
		static Delegate GetGetBlacklistDurationMsFor_IJLjava_io_IOException_IHandler ()
		{
			if (cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I == null)
				cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJLI_J) n_GetBlacklistDurationMsFor_IJLjava_io_IOException_I);
			return cb_getBlacklistDurationMsFor_IJLjava_io_IOException_I;
		}

		static long n_GetBlacklistDurationMsFor_IJLjava_io_IOException_I (IntPtr jnienv, IntPtr native__this, int p0, long p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p2, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetBlacklistDurationMsFor (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBlacklistDurationMsFor_IJLjava_io_IOException_I;
		public unsafe long GetBlacklistDurationMsFor (int p0, long p1, global::Java.IO.IOException p2, int p3)
		{
			if (id_getBlacklistDurationMsFor_IJLjava_io_IOException_I == IntPtr.Zero)
				id_getBlacklistDurationMsFor_IJLjava_io_IOException_I = JNIEnv.GetMethodID (class_ref, "getBlacklistDurationMsFor", "(IJLjava/io/IOException;I)J");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBlacklistDurationMsFor_IJLjava_io_IOException_I, __args);
			return __ret;
		}

		static Delegate cb_getMinimumLoadableRetryCount_I;
#pragma warning disable 0169
		static Delegate GetGetMinimumLoadableRetryCount_IHandler ()
		{
			if (cb_getMinimumLoadableRetryCount_I == null)
				cb_getMinimumLoadableRetryCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetMinimumLoadableRetryCount_I);
			return cb_getMinimumLoadableRetryCount_I;
		}

		static int n_GetMinimumLoadableRetryCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMinimumLoadableRetryCount (p0);
		}
#pragma warning restore 0169

		IntPtr id_getMinimumLoadableRetryCount_I;
		public unsafe int GetMinimumLoadableRetryCount (int p0)
		{
			if (id_getMinimumLoadableRetryCount_I == IntPtr.Zero)
				id_getMinimumLoadableRetryCount_I = JNIEnv.GetMethodID (class_ref, "getMinimumLoadableRetryCount", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinimumLoadableRetryCount_I, __args);
		}

		static Delegate cb_getRetryDelayMsFor_IJLjava_io_IOException_I;
#pragma warning disable 0169
		static Delegate GetGetRetryDelayMsFor_IJLjava_io_IOException_IHandler ()
		{
			if (cb_getRetryDelayMsFor_IJLjava_io_IOException_I == null)
				cb_getRetryDelayMsFor_IJLjava_io_IOException_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJLI_J) n_GetRetryDelayMsFor_IJLjava_io_IOException_I);
			return cb_getRetryDelayMsFor_IJLjava_io_IOException_I;
		}

		static long n_GetRetryDelayMsFor_IJLjava_io_IOException_I (IntPtr jnienv, IntPtr native__this, int p0, long p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p2, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetRetryDelayMsFor (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRetryDelayMsFor_IJLjava_io_IOException_I;
		public unsafe long GetRetryDelayMsFor (int p0, long p1, global::Java.IO.IOException p2, int p3)
		{
			if (id_getRetryDelayMsFor_IJLjava_io_IOException_I == IntPtr.Zero)
				id_getRetryDelayMsFor_IJLjava_io_IOException_I = JNIEnv.GetMethodID (class_ref, "getRetryDelayMsFor", "(IJLjava/io/IOException;I)J");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRetryDelayMsFor_IJLjava_io_IOException_I, __args);
			return __ret;
		}

	}
}
