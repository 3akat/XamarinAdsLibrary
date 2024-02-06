using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	[Register ("com/example/androidtvlibrary/main/adapter/Media/DrmSessionManager", DoNotGenerateAcw=true)]
	public abstract class DrmSessionManager : Java.Lang.Object {
		internal DrmSessionManager ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='DrmSessionManager']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager Dummy {
			get {
				const string __id = "DUMMY.Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/DrmSessionManager", typeof (DrmSessionManager));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/Media/DrmSessionManager", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'DrmSessionManager' type. This type will be removed in a future release.", error: true)]
	public abstract class DrmSessionManagerConsts : DrmSessionManager {
		private DrmSessionManagerConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='DrmSessionManager']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/DrmSessionManager", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManagerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial interface IDrmSessionManager : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='DrmSessionManager']/method[@name='acquireSession' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("acquireSession", "(Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;", "GetAcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManagerInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession AcquireSession (global::Android.OS.Looper p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='DrmSessionManager']/method[@name='canAcquireSession' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("canAcquireSession", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Z", "GetCanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManagerInvoker, PausedAdsAndroidTV.Binding")]
		bool CanAcquireSession (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='DrmSessionManager']/method[@name='getExoMediaCryptoType' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("getExoMediaCryptoType", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Ljava/lang/Class;", "GetGetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManagerInvoker, PausedAdsAndroidTV.Binding")]
		global::Java.Lang.Class GetExoMediaCryptoType (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/DrmSessionManager", DoNotGenerateAcw=true)]
	internal partial class IDrmSessionManagerInvoker : global::Java.Lang.Object, IDrmSessionManager {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/DrmSessionManager", typeof (IDrmSessionManagerInvoker));

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

		public static IDrmSessionManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrmSessionManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrmSessionManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
#pragma warning disable 0169
		static Delegate GetAcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler ()
		{
			if (cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == null)
				cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_);
			return cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		}

		static IntPtr n_AcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireSession (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession AcquireSession (global::Android.OS.Looper p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData p1)
		{
			if (id_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == IntPtr.Zero)
				id_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNIEnv.GetMethodID (class_ref, "acquireSession", "(Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
#pragma warning disable 0169
		static Delegate GetCanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler ()
		{
			if (cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == null)
				cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_);
			return cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		}

		static bool n_CanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanAcquireSession (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		public unsafe bool CanAcquireSession (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData p0)
		{
			if (id_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == IntPtr.Zero)
				id_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNIEnv.GetMethodID (class_ref, "canAcquireSession", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_, __args);
			return __ret;
		}

		static Delegate cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
#pragma warning disable 0169
		static Delegate GetGetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler ()
		{
			if (cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == null)
				cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_);
			return cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		}

		static IntPtr n_GetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetExoMediaCryptoType (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		public unsafe global::Java.Lang.Class GetExoMediaCryptoType (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData p0)
		{
			if (id_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == IntPtr.Zero)
				id_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNIEnv.GetMethodID (class_ref, "getExoMediaCryptoType", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Ljava/lang/Class;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
