using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Drmsession {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.AppManagedProvider']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$AppManagedProvider", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public sealed partial class ExoMediaDrmAppManagedProvider : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$AppManagedProvider", typeof (ExoMediaDrmAppManagedProvider));

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

		internal ExoMediaDrmAppManagedProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.AppManagedProvider']/constructor[@name='ExoMediaDrm.AppManagedProvider' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;T&gt;']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;)V", "")]
		public unsafe ExoMediaDrmAppManagedProvider (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm exoMediaDrm) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exoMediaDrm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exoMediaDrm).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (exoMediaDrm);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.AppManagedProvider']/method[@name='acquireExoMediaDrm' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("acquireExoMediaDrm", "(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm AcquireExoMediaDrm (global::Java.Util.UUID uuid)
		{
			const string __id = "acquireExoMediaDrm.(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uuid);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyRequest']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest", DoNotGenerateAcw=true)]
	public sealed partial class ExoMediaDrmKeyRequest : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest", typeof (ExoMediaDrmKeyRequest));

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

		internal ExoMediaDrmKeyRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyRequest']/constructor[@name='ExoMediaDrm.KeyRequest' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;)V", "")]
		public unsafe ExoMediaDrmKeyRequest (byte[] data, string licenseServerUrl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_licenseServerUrl = JNIEnv.NewString (licenseServerUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (native_licenseServerUrl);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				JNIEnv.DeleteLocalRef (native_licenseServerUrl);
				global::System.GC.KeepAlive (data);
			}
		}

		public unsafe string LicenseServerUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyRequest']/method[@name='getLicenseServerUrl' and count(parameter)=0]"
			[Register ("getLicenseServerUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLicenseServerUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyRequest']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "")]
		public unsafe byte[] GetData ()
		{
			const string __id = "getData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyStatus']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyStatus", DoNotGenerateAcw=true)]
	public sealed partial class ExoMediaDrmKeyStatus : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyStatus", typeof (ExoMediaDrmKeyStatus));

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

		internal ExoMediaDrmKeyStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyStatus']/constructor[@name='ExoMediaDrm.KeyStatus' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public unsafe ExoMediaDrmKeyStatus (int statusCode, byte[] keyId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyId = JNIEnv.NewArray (keyId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (statusCode);
				__args [1] = new JniArgumentValue (native_keyId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (keyId != null) {
					JNIEnv.CopyArray (native_keyId, keyId);
					JNIEnv.DeleteLocalRef (native_keyId);
				}
				global::System.GC.KeepAlive (keyId);
			}
		}

		public unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyStatus']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.KeyStatus']/method[@name='getKeyId' and count(parameter)=0]"
		[Register ("getKeyId", "()[B", "")]
		public unsafe byte[] GetKeyId ()
		{
			const string __id = "getKeyId.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm.OnEventListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial interface IExoMediaDrmOnEventListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm.OnEventListener']/method[@name='onEvent' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;? extends T&gt;'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("onEvent", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;[BII[B)V", "GetOnEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnEvent (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, int p2, int p3, byte[] p4);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener", DoNotGenerateAcw=true)]
	internal partial class IExoMediaDrmOnEventListenerInvoker : global::Java.Lang.Object, IExoMediaDrmOnEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener", typeof (IExoMediaDrmOnEventListenerInvoker));

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

		public static IExoMediaDrmOnEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExoMediaDrmOnEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExoMediaDrmOnEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB;
#pragma warning disable 0169
		static Delegate GetOnEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayBHandler ()
		{
			if (cb_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB == null)
				cb_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIL_V) n_OnEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB);
			return cb_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB;
		}

		static void n_OnEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnEvent (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB;
		public unsafe void OnEvent (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, int p2, int p3, byte[] p4)
		{
			if (id_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB == IntPtr.Zero)
				id_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;[BII[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBIIarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnEventListener.onEvent
	public partial class ExoMediaDrmOnEventEventArgs : global::System.EventArgs {
		public ExoMediaDrmOnEventEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, int p2, int p3, byte[] p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm P0 {
			get { return p0; }
		}

		byte[] p1;

		public byte[] P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

		int p3;

		public int P3 {
			get { return p3; }
		}

		byte[] p4;

		public byte[] P4 {
			get { return p4; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm_OnEventListenerImplementor")]
	internal sealed partial class IExoMediaDrmOnEventListenerImplementor : global::Java.Lang.Object, IExoMediaDrmOnEventListener {

		object sender;

		public IExoMediaDrmOnEventListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm_OnEventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ExoMediaDrmOnEventEventArgs> Handler;
		#pragma warning restore 0649

		public void OnEvent (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, int p2, int p3, byte[] p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ExoMediaDrmOnEventEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IExoMediaDrmOnEventListenerImplementor value)
		{
			return value.Handler == null;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm.OnKeyStatusChangeListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial interface IExoMediaDrmOnKeyStatusChangeListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm.OnKeyStatusChangeListener']/method[@name='onKeyStatusChange' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;? extends T&gt;'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.KeyStatus&gt;'] and parameter[4][@type='boolean']]"
		[Register ("onKeyStatusChange", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;[BLjava/util/List;Z)V", "GetOnKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnKeyStatusChange (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus> p2, bool p3);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener", DoNotGenerateAcw=true)]
	internal partial class IExoMediaDrmOnKeyStatusChangeListenerInvoker : global::Java.Lang.Object, IExoMediaDrmOnKeyStatusChangeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener", typeof (IExoMediaDrmOnKeyStatusChangeListenerInvoker));

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

		public static IExoMediaDrmOnKeyStatusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExoMediaDrmOnKeyStatusChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnKeyStatusChangeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExoMediaDrmOnKeyStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetOnKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_ZHandler ()
		{
			if (cb_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z == null)
				cb_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_OnKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z);
			return cb_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z;
		}

		static void n_OnKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyStatusChange (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z;
		public unsafe void OnKeyStatusChange (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus> p2, bool p3)
		{
			if (id_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z == IntPtr.Zero)
				id_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z = JNIEnv.GetMethodID (class_ref, "onKeyStatusChange", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;[BLjava/util/List;Z)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyStatusChange_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_arrayBLjava_util_List_Z, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnKeyStatusChangeListener.onKeyStatusChange
	public partial class ExoMediaDrmOnKeyStatusChangeEventArgs : global::System.EventArgs {
		public ExoMediaDrmOnKeyStatusChangeEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus> p2, bool p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm P0 {
			get { return p0; }
		}

		byte[] p1;

		public byte[] P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus> p2;

		public global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus> P2 {
			get { return p2; }
		}

		bool p3;

		public bool P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm_OnKeyStatusChangeListenerImplementor")]
	internal sealed partial class IExoMediaDrmOnKeyStatusChangeListenerImplementor : global::Java.Lang.Object, IExoMediaDrmOnKeyStatusChangeListener {

		object sender;

		public IExoMediaDrmOnKeyStatusChangeListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm_OnKeyStatusChangeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ExoMediaDrmOnKeyStatusChangeEventArgs> Handler;
		#pragma warning restore 0649

		public void OnKeyStatusChange (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm p0, byte[] p1, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus> p2, bool p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ExoMediaDrmOnKeyStatusChangeEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IExoMediaDrmOnKeyStatusChangeListenerImplementor value)
		{
			return value.Handler == null;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm.Provider']"
	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$Provider", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProviderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial interface IExoMediaDrmProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm.Provider']/method[@name='acquireExoMediaDrm' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("acquireExoMediaDrm", "(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;", "GetAcquireExoMediaDrm_Ljava_util_UUID_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProviderInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm AcquireExoMediaDrm (global::Java.Util.UUID p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$Provider", DoNotGenerateAcw=true)]
	internal partial class IExoMediaDrmProviderInvoker : global::Java.Lang.Object, IExoMediaDrmProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$Provider", typeof (IExoMediaDrmProviderInvoker));

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

		public static IExoMediaDrmProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExoMediaDrmProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.Provider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExoMediaDrmProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_acquireExoMediaDrm_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetAcquireExoMediaDrm_Ljava_util_UUID_Handler ()
		{
			if (cb_acquireExoMediaDrm_Ljava_util_UUID_ == null)
				cb_acquireExoMediaDrm_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AcquireExoMediaDrm_Ljava_util_UUID_);
			return cb_acquireExoMediaDrm_Ljava_util_UUID_;
		}

		static IntPtr n_AcquireExoMediaDrm_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireExoMediaDrm (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acquireExoMediaDrm_Ljava_util_UUID_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm AcquireExoMediaDrm (global::Java.Util.UUID p0)
		{
			if (id_acquireExoMediaDrm_Ljava_util_UUID_ == IntPtr.Zero)
				id_acquireExoMediaDrm_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "acquireExoMediaDrm", "(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquireExoMediaDrm_Ljava_util_UUID_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.ProvisionRequest']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest", DoNotGenerateAcw=true)]
	public sealed partial class ExoMediaDrmProvisionRequest : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest", typeof (ExoMediaDrmProvisionRequest));

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

		internal ExoMediaDrmProvisionRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.ProvisionRequest']/constructor[@name='ExoMediaDrm.ProvisionRequest' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;)V", "")]
		public unsafe ExoMediaDrmProvisionRequest (byte[] data, string defaultUrl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_defaultUrl = JNIEnv.NewString (defaultUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (native_defaultUrl);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				JNIEnv.DeleteLocalRef (native_defaultUrl);
				global::System.GC.KeepAlive (data);
			}
		}

		public unsafe string DefaultUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.ProvisionRequest']/method[@name='getDefaultUrl' and count(parameter)=0]"
			[Register ("getDefaultUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDefaultUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='ExoMediaDrm.ProvisionRequest']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "")]
		public unsafe byte[] GetData ()
		{
			const string __id = "getData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm", DoNotGenerateAcw=true)]
	public abstract class ExoMediaDrm : Java.Lang.Object {
		internal ExoMediaDrm ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/field[@name='EVENT_KEY_EXPIRED']"
		[Register ("EVENT_KEY_EXPIRED")]
		public const int EventKeyExpired = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/field[@name='EVENT_KEY_REQUIRED']"
		[Register ("EVENT_KEY_REQUIRED")]
		public const int EventKeyRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/field[@name='EVENT_PROVISION_REQUIRED']"
		[Register ("EVENT_PROVISION_REQUIRED")]
		public const int EventProvisionRequired = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/field[@name='KEY_TYPE_OFFLINE']"
		[Register ("KEY_TYPE_OFFLINE")]
		public const int KeyTypeOffline = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/field[@name='KEY_TYPE_RELEASE']"
		[Register ("KEY_TYPE_RELEASE")]
		public const int KeyTypeRelease = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/field[@name='KEY_TYPE_STREAMING']"
		[Register ("KEY_TYPE_STREAMING")]
		public const int KeyTypeStreaming = (int) 1;

	}

	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ExoMediaDrm' type. This type will be removed in a future release.", error: true)]
	public abstract class ExoMediaDrmConsts : ExoMediaDrm {
		private ExoMediaDrmConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']"
	[Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial interface IExoMediaDrm : IJavaObject, IJavaPeerable {
		global::Java.Lang.Class ExoMediaCryptoType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='getExoMediaCryptoType' and count(parameter)=0]"
			[Register ("getExoMediaCryptoType", "()Ljava/lang/Class;", "GetGetExoMediaCryptoTypeHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Android.OS.PersistableBundle Metrics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='getMetrics' and count(parameter)=0]"
			[Register ("getMetrics", "()Landroid/os/PersistableBundle;", "GetGetMetricsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest ProvisionRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='getProvisionRequest' and count(parameter)=0]"
			[Register ("getProvisionRequest", "()Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest;", "GetGetProvisionRequestHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "GetAcquireHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void Acquire ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='closeSession' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("closeSession", "([B)V", "GetCloseSession_arrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void CloseSession (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='createMediaCrypto' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createMediaCrypto", "([B)Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;", "GetCreateMediaCrypto_arrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		global::Java.Lang.Object CreateMediaCrypto (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='getKeyRequest' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData&gt;'] and parameter[3][@type='int'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getKeyRequest", "([BLjava/util/List;ILjava/util/HashMap;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest;", "GetGetKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest GetKeyRequest (byte[] p0, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> p1, int p2, global::System.Collections.Generic.IDictionary<string, string> p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='getPropertyByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPropertyByteArray", "(Ljava/lang/String;)[B", "GetGetPropertyByteArray_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		byte[] GetPropertyByteArray (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='getPropertyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPropertyString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetPropertyString_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		string GetPropertyString (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='openSession' and count(parameter)=0]"
		[Register ("openSession", "()[B", "GetOpenSessionHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		byte[] OpenSession ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='provideKeyResponse' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("provideKeyResponse", "([B[B)[B", "GetProvideKeyResponse_arrayBarrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		byte[] ProvideKeyResponse (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='provideProvisionResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("provideProvisionResponse", "([B)V", "GetProvideProvisionResponse_arrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void ProvideProvisionResponse (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='queryKeyStatus' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("queryKeyStatus", "([B)Ljava/util/Map;", "GetQueryKeyStatus_arrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='restoreKeys' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("restoreKeys", "([B[B)V", "GetRestoreKeys_arrayBarrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void RestoreKeys (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='setOnEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnEventListener&lt;? super T&gt;']]"
		[Register ("setOnEventListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener;)V", "GetSetOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void SetOnEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='setOnKeyStatusChangeListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnKeyStatusChangeListener&lt;? super T&gt;']]"
		[Register ("setOnKeyStatusChangeListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener;)V", "GetSetOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void SetOnKeyStatusChangeListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='setPropertyByteArray' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("setPropertyByteArray", "(Ljava/lang/String;[B)V", "GetSetPropertyByteArray_Ljava_lang_String_arrayBHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void SetPropertyByteArray (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='ExoMediaDrm']/method[@name='setPropertyString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setPropertyString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetPropertyString_Ljava_lang_String_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmInvoker, PausedAdsAndroidTV.Binding")]
		void SetPropertyString (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm", DoNotGenerateAcw=true)]
	internal partial class IExoMediaDrmInvoker : global::Java.Lang.Object, IExoMediaDrm {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm", typeof (IExoMediaDrmInvoker));

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

		public static IExoMediaDrm GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExoMediaDrm> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExoMediaDrmInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getExoMediaCryptoType;
#pragma warning disable 0169
		static Delegate GetGetExoMediaCryptoTypeHandler ()
		{
			if (cb_getExoMediaCryptoType == null)
				cb_getExoMediaCryptoType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExoMediaCryptoType);
			return cb_getExoMediaCryptoType;
		}

		static IntPtr n_GetExoMediaCryptoType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExoMediaCryptoType);
		}
#pragma warning restore 0169

		IntPtr id_getExoMediaCryptoType;
		public unsafe global::Java.Lang.Class ExoMediaCryptoType {
			get {
				if (id_getExoMediaCryptoType == IntPtr.Zero)
					id_getExoMediaCryptoType = JNIEnv.GetMethodID (class_ref, "getExoMediaCryptoType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExoMediaCryptoType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMetrics;
#pragma warning disable 0169
		static Delegate GetGetMetricsHandler ()
		{
			if (cb_getMetrics == null)
				cb_getMetrics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMetrics);
			return cb_getMetrics;
		}

		static IntPtr n_GetMetrics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metrics);
		}
#pragma warning restore 0169

		IntPtr id_getMetrics;
		public unsafe global::Android.OS.PersistableBundle Metrics {
			get {
				if (id_getMetrics == IntPtr.Zero)
					id_getMetrics = JNIEnv.GetMethodID (class_ref, "getMetrics", "()Landroid/os/PersistableBundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.PersistableBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetrics), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProvisionRequest;
#pragma warning disable 0169
		static Delegate GetGetProvisionRequestHandler ()
		{
			if (cb_getProvisionRequest == null)
				cb_getProvisionRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProvisionRequest);
			return cb_getProvisionRequest;
		}

		static IntPtr n_GetProvisionRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProvisionRequest);
		}
#pragma warning restore 0169

		IntPtr id_getProvisionRequest;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest ProvisionRequest {
			get {
				if (id_getProvisionRequest == IntPtr.Zero)
					id_getProvisionRequest = JNIEnv.GetMethodID (class_ref, "getProvisionRequest", "()Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvisionRequest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_acquire;
#pragma warning disable 0169
		static Delegate GetAcquireHandler ()
		{
			if (cb_acquire == null)
				cb_acquire = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Acquire);
			return cb_acquire;
		}

		static void n_Acquire (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Acquire ();
		}
#pragma warning restore 0169

		IntPtr id_acquire;
		public unsafe void Acquire ()
		{
			if (id_acquire == IntPtr.Zero)
				id_acquire = JNIEnv.GetMethodID (class_ref, "acquire", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquire);
		}

		static Delegate cb_closeSession_arrayB;
#pragma warning disable 0169
		static Delegate GetCloseSession_arrayBHandler ()
		{
			if (cb_closeSession_arrayB == null)
				cb_closeSession_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CloseSession_arrayB);
			return cb_closeSession_arrayB;
		}

		static void n_CloseSession_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CloseSession (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_closeSession_arrayB;
		public unsafe void CloseSession (byte[] p0)
		{
			if (id_closeSession_arrayB == IntPtr.Zero)
				id_closeSession_arrayB = JNIEnv.GetMethodID (class_ref, "closeSession", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeSession_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createMediaCrypto_arrayB;
#pragma warning disable 0169
		static Delegate GetCreateMediaCrypto_arrayBHandler ()
		{
			if (cb_createMediaCrypto_arrayB == null)
				cb_createMediaCrypto_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateMediaCrypto_arrayB);
			return cb_createMediaCrypto_arrayB;
		}

		static IntPtr n_CreateMediaCrypto_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateMediaCrypto (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createMediaCrypto_arrayB;
		public unsafe global::Java.Lang.Object CreateMediaCrypto (byte[] p0)
		{
			if (id_createMediaCrypto_arrayB == IntPtr.Zero)
				id_createMediaCrypto_arrayB = JNIEnv.GetMethodID (class_ref, "createMediaCrypto", "([B)Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createMediaCrypto_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetGetKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_Handler ()
		{
			if (cb_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_ == null)
				cb_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_L) n_GetKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_);
			return cb_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_;
		}

		static IntPtr n_GetKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetKeyRequest (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest GetKeyRequest (byte[] p0, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> p1, int p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_ == IntPtr.Zero)
				id_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "getKeyRequest", "([BLjava/util/List;ILjava/util/HashMap;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeyRequest_arrayBLjava_util_List_ILjava_util_HashMap_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_getPropertyByteArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPropertyByteArray_Ljava_lang_String_Handler ()
		{
			if (cb_getPropertyByteArray_Ljava_lang_String_ == null)
				cb_getPropertyByteArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPropertyByteArray_Ljava_lang_String_);
			return cb_getPropertyByteArray_Ljava_lang_String_;
		}

		static IntPtr n_GetPropertyByteArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetPropertyByteArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPropertyByteArray_Ljava_lang_String_;
		public unsafe byte[] GetPropertyByteArray (string p0)
		{
			if (id_getPropertyByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_getPropertyByteArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPropertyByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPropertyByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPropertyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPropertyString_Ljava_lang_String_Handler ()
		{
			if (cb_getPropertyString_Ljava_lang_String_ == null)
				cb_getPropertyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPropertyString_Ljava_lang_String_);
			return cb_getPropertyString_Ljava_lang_String_;
		}

		static IntPtr n_GetPropertyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPropertyString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPropertyString_Ljava_lang_String_;
		public unsafe string GetPropertyString (string p0)
		{
			if (id_getPropertyString_Ljava_lang_String_ == IntPtr.Zero)
				id_getPropertyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPropertyString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPropertyString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_openSession;
#pragma warning disable 0169
		static Delegate GetOpenSessionHandler ()
		{
			if (cb_openSession == null)
				cb_openSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OpenSession);
			return cb_openSession;
		}

		static IntPtr n_OpenSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.OpenSession ());
		}
#pragma warning restore 0169

		IntPtr id_openSession;
		public unsafe byte[] OpenSession ()
		{
			if (id_openSession == IntPtr.Zero)
				id_openSession = JNIEnv.GetMethodID (class_ref, "openSession", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openSession), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_provideKeyResponse_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetProvideKeyResponse_arrayBarrayBHandler ()
		{
			if (cb_provideKeyResponse_arrayBarrayB == null)
				cb_provideKeyResponse_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ProvideKeyResponse_arrayBarrayB);
			return cb_provideKeyResponse_arrayBarrayB;
		}

		static IntPtr n_ProvideKeyResponse_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.ProvideKeyResponse (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_provideKeyResponse_arrayBarrayB;
		public unsafe byte[] ProvideKeyResponse (byte[] p0, byte[] p1)
		{
			if (id_provideKeyResponse_arrayBarrayB == IntPtr.Zero)
				id_provideKeyResponse_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "provideKeyResponse", "([B[B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_provideKeyResponse_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_provideProvisionResponse_arrayB;
#pragma warning disable 0169
		static Delegate GetProvideProvisionResponse_arrayBHandler ()
		{
			if (cb_provideProvisionResponse_arrayB == null)
				cb_provideProvisionResponse_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ProvideProvisionResponse_arrayB);
			return cb_provideProvisionResponse_arrayB;
		}

		static void n_ProvideProvisionResponse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ProvideProvisionResponse (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_provideProvisionResponse_arrayB;
		public unsafe void ProvideProvisionResponse (byte[] p0)
		{
			if (id_provideProvisionResponse_arrayB == IntPtr.Zero)
				id_provideProvisionResponse_arrayB = JNIEnv.GetMethodID (class_ref, "provideProvisionResponse", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_provideProvisionResponse_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_queryKeyStatus_arrayB;
#pragma warning disable 0169
		static Delegate GetQueryKeyStatus_arrayBHandler ()
		{
			if (cb_queryKeyStatus_arrayB == null)
				cb_queryKeyStatus_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_QueryKeyStatus_arrayB);
			return cb_queryKeyStatus_arrayB;
		}

		static IntPtr n_QueryKeyStatus_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.QueryKeyStatus (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_queryKeyStatus_arrayB;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus (byte[] p0)
		{
			if (id_queryKeyStatus_arrayB == IntPtr.Zero)
				id_queryKeyStatus_arrayB = JNIEnv.GetMethodID (class_ref, "queryKeyStatus", "([B)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryKeyStatus_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_restoreKeys_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRestoreKeys_arrayBarrayBHandler ()
		{
			if (cb_restoreKeys_arrayBarrayB == null)
				cb_restoreKeys_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RestoreKeys_arrayBarrayB);
			return cb_restoreKeys_arrayBarrayB;
		}

		static void n_RestoreKeys_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.RestoreKeys (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_restoreKeys_arrayBarrayB;
		public unsafe void RestoreKeys (byte[] p0, byte[] p1)
		{
			if (id_restoreKeys_arrayBarrayB == IntPtr.Zero)
				id_restoreKeys_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "restoreKeys", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restoreKeys_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_;
#pragma warning disable 0169
		static Delegate GetSetOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_Handler ()
		{
			if (cb_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_ == null)
				cb_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_);
			return cb_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_;
		}

		static void n_SetOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnEventListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_;
		public unsafe void SetOnEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener p0)
		{
			if (id_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_ == IntPtr.Zero)
				id_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_ = JNIEnv.GetMethodID (class_ref, "setOnEventListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnEventListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnEventListener_, __args);
		}

		static Delegate cb_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_Handler ()
		{
			if (cb_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_ == null)
				cb_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_);
			return cb_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_;
		}

		static void n_SetOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnKeyStatusChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_;
		public unsafe void SetOnKeyStatusChangeListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener p0)
		{
			if (id_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_ == IntPtr.Zero)
				id_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnKeyStatusChangeListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnKeyStatusChangeListener_Lcom_example_androidtvlibrary_main_adapter_drmsession_ExoMediaDrm_OnKeyStatusChangeListener_, __args);
		}

		static Delegate cb_setPropertyByteArray_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPropertyByteArray_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_setPropertyByteArray_Ljava_lang_String_arrayB == null)
				cb_setPropertyByteArray_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetPropertyByteArray_Ljava_lang_String_arrayB);
			return cb_setPropertyByteArray_Ljava_lang_String_arrayB;
		}

		static void n_SetPropertyByteArray_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPropertyByteArray (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_setPropertyByteArray_Ljava_lang_String_arrayB;
		public unsafe void SetPropertyByteArray (string p0, byte[] p1)
		{
			if (id_setPropertyByteArray_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_setPropertyByteArray_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "setPropertyByteArray", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPropertyByteArray_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setPropertyString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPropertyString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setPropertyString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setPropertyString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetPropertyString_Ljava_lang_String_Ljava_lang_String_);
			return cb_setPropertyString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetPropertyString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPropertyString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPropertyString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetPropertyString (string p0, string p1)
		{
			if (id_setPropertyString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setPropertyString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPropertyString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPropertyString_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
