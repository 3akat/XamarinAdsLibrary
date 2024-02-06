using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Drmsession {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='MediaDrmCallback']"
	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallbackInvoker")]
	public partial interface IMediaDrmCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='MediaDrmCallback']/method[@name='executeKeyRequest' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.KeyRequest']]"
		[Register ("executeKeyRequest", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest;)[B", "GetExecuteKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallbackInvoker, PausedAdsAndroidTV.Binding")]
		byte[] ExecuteKeyRequest (global::Java.Util.UUID p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='MediaDrmCallback']/method[@name='executeProvisionRequest' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.ProvisionRequest']]"
		[Register ("executeProvisionRequest", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest;)[B", "GetExecuteProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallbackInvoker, PausedAdsAndroidTV.Binding")]
		byte[] ExecuteProvisionRequest (global::Java.Util.UUID p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback", DoNotGenerateAcw=true)]
	internal partial class IMediaDrmCallbackInvoker : global::Java.Lang.Object, IMediaDrmCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback", typeof (IMediaDrmCallbackInvoker));

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

		public static IMediaDrmCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaDrmCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.MediaDrmCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaDrmCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_;
#pragma warning disable 0169
		static Delegate GetExecuteKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_Handler ()
		{
			if (cb_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_ == null)
				cb_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ExecuteKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_);
			return cb_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_;
		}

		static IntPtr n_ExecuteKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ExecuteKeyRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_;
		public unsafe byte[] ExecuteKeyRequest (global::Java.Util.UUID p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest p1)
		{
			if (id_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_ == IntPtr.Zero)
				id_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_ = JNIEnv.GetMethodID (class_ref, "executeKeyRequest", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest;)[B");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeKeyRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_KeyRequest_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			return __ret;
		}

		static Delegate cb_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_;
#pragma warning disable 0169
		static Delegate GetExecuteProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_Handler ()
		{
			if (cb_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_ == null)
				cb_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ExecuteProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_);
			return cb_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_;
		}

		static IntPtr n_ExecuteProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ExecuteProvisionRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_;
		public unsafe byte[] ExecuteProvisionRequest (global::Java.Util.UUID p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest p1)
		{
			if (id_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_ == IntPtr.Zero)
				id_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_ = JNIEnv.GetMethodID (class_ref, "executeProvisionRequest", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest;)[B");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeProvisionRequest_Ljava_util_UUID_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_ProvisionRequest_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			return __ret;
		}

	}
}
