using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Drmsession {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial class DefaultDrmSession : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/field[@name='schemeDatas']"
		[Register ("schemeDatas")]
		public global::System.Collections.IList SchemeDatas {
			get {
				const string __id = "schemeDatas.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "schemeDatas.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.wow.DrmSession

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_ERROR']"
			[Register ("STATE_ERROR")]
			public const int StateError = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_OPENED']"
			[Register ("STATE_OPENED")]
			public const int StateOpened = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_OPENED_WITH_KEYS']"
			[Register ("STATE_OPENED_WITH_KEYS")]
			public const int StateOpenedWithKeys = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_OPENING']"
			[Register ("STATE_OPENING")]
			public const int StateOpening = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_RELEASED']"
			[Register ("STATE_RELEASED")]
			public const int StateReleased = (int) 0;

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='DefaultDrmSession.ProvisioningManager']"
		[Register ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ProvisioningManager", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession/IProvisioningManagerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
		public partial interface IProvisioningManager : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='DefaultDrmSession.ProvisioningManager']/method[@name='onProvisionCompleted' and count(parameter)=0]"
			[Register ("onProvisionCompleted", "()V", "GetOnProvisionCompletedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession/IProvisioningManagerInvoker, PausedAdsAndroidTV.Binding")]
			void OnProvisionCompleted ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='DefaultDrmSession.ProvisioningManager']/method[@name='onProvisionError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onProvisionError", "(Ljava/lang/Exception;)V", "GetOnProvisionError_Ljava_lang_Exception_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession/IProvisioningManagerInvoker, PausedAdsAndroidTV.Binding")]
			void OnProvisionError (global::Java.Lang.Exception p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='DefaultDrmSession.ProvisioningManager']/method[@name='provisionRequired' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSession&lt;T&gt;']]"
			[Register ("provisionRequired", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession;)V", "GetProvisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession/IProvisioningManagerInvoker, PausedAdsAndroidTV.Binding")]
			void ProvisionRequired (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ProvisioningManager", DoNotGenerateAcw=true)]
		internal partial class IProvisioningManagerInvoker : global::Java.Lang.Object, IProvisioningManager {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ProvisioningManager", typeof (IProvisioningManagerInvoker));

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

			public static IProvisioningManager GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProvisioningManager> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSession.ProvisioningManager'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProvisioningManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProvisionCompleted;
#pragma warning disable 0169
			static Delegate GetOnProvisionCompletedHandler ()
			{
				if (cb_onProvisionCompleted == null)
					cb_onProvisionCompleted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnProvisionCompleted);
				return cb_onProvisionCompleted;
			}

			static void n_OnProvisionCompleted (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession.IProvisioningManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProvisionCompleted ();
			}
#pragma warning restore 0169

			IntPtr id_onProvisionCompleted;
			public unsafe void OnProvisionCompleted ()
			{
				if (id_onProvisionCompleted == IntPtr.Zero)
					id_onProvisionCompleted = JNIEnv.GetMethodID (class_ref, "onProvisionCompleted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProvisionCompleted);
			}

			static Delegate cb_onProvisionError_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnProvisionError_Ljava_lang_Exception_Handler ()
			{
				if (cb_onProvisionError_Ljava_lang_Exception_ == null)
					cb_onProvisionError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnProvisionError_Ljava_lang_Exception_);
				return cb_onProvisionError_Ljava_lang_Exception_;
			}

			static void n_OnProvisionError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession.IProvisioningManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnProvisionError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onProvisionError_Ljava_lang_Exception_;
			public unsafe void OnProvisionError (global::Java.Lang.Exception p0)
			{
				if (id_onProvisionError_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onProvisionError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onProvisionError", "(Ljava/lang/Exception;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProvisionError_Ljava_lang_Exception_, __args);
			}

			static Delegate cb_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_;
#pragma warning disable 0169
			static Delegate GetProvisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_Handler ()
			{
				if (cb_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ == null)
					cb_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ProvisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_);
				return cb_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_;
			}

			static void n_ProvisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession.IProvisioningManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ProvisionRequired (p0);
			}
#pragma warning restore 0169

			IntPtr id_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_;
			public unsafe void ProvisionRequired (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession p0)
			{
				if (id_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ == IntPtr.Zero)
					id_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ = JNIEnv.GetMethodID (class_ref, "provisionRequired", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_provisionRequired_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='DefaultDrmSession.ReleaseCallback']"
		[Register ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ReleaseCallback", "", "Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession/IReleaseCallbackInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
		public partial interface IReleaseCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/interface[@name='DefaultDrmSession.ReleaseCallback']/method[@name='onSessionReleased' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSession&lt;T&gt;']]"
			[Register ("onSessionReleased", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession;)V", "GetOnSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession/IReleaseCallbackInvoker, PausedAdsAndroidTV.Binding")]
			void OnSessionReleased (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ReleaseCallback", DoNotGenerateAcw=true)]
		internal partial class IReleaseCallbackInvoker : global::Java.Lang.Object, IReleaseCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ReleaseCallback", typeof (IReleaseCallbackInvoker));

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

			public static IReleaseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IReleaseCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSession.ReleaseCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IReleaseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_;
#pragma warning disable 0169
			static Delegate GetOnSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_Handler ()
			{
				if (cb_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ == null)
					cb_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_);
				return cb_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_;
			}

			static void n_OnSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession.IReleaseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSessionReleased (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_;
			public unsafe void OnSessionReleased (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession p0)
			{
				if (id_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ == IntPtr.Zero)
					id_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_ = JNIEnv.GetMethodID (class_ref, "onSessionReleased", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSessionReleased_Lcom_example_androidtvlibrary_main_adapter_drmsession_DefaultDrmSession_, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession.UnexpectedDrmSessionException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$UnexpectedDrmSessionException", DoNotGenerateAcw=true)]
		public sealed partial class UnexpectedDrmSessionException : global::Java.IO.IOException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$UnexpectedDrmSessionException", typeof (UnexpectedDrmSessionException));

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

			internal UnexpectedDrmSessionException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession.UnexpectedDrmSessionException']/constructor[@name='DefaultDrmSession.UnexpectedDrmSessionException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
			public unsafe UnexpectedDrmSessionException (global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Throwable;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (cause);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession", typeof (DefaultDrmSession));

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

		protected DefaultDrmSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/constructor[@name='DefaultDrmSession' and count(parameter)=14 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;T&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSession.ProvisioningManager&lt;T&gt;'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSession.ReleaseCallback&lt;T&gt;'] and parameter[5][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData&gt;'] and parameter[6][@type='int'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='byte[]'] and parameter[10][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;'] and parameter[11][@type='com.example.androidtvlibrary.main.adapter.drmsession.MediaDrmCallback'] and parameter[12][@type='android.os.Looper'] and parameter[13][@type='com.example.androidtvlibrary.main.adapter.wow.EventDispatcher&lt;com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSessionEventListener&gt;'] and parameter[14][@type='com.example.androidtvlibrary.main.adapter.Media.LoadErrorHandlingPolicy']]"
		[Register (".ctor", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ProvisioningManager;Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ReleaseCallback;Ljava/util/List;IZZ[BLjava/util/HashMap;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/wow/EventDispatcher;Lcom/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy;)V", "")]
		public unsafe DefaultDrmSession (global::Java.Util.UUID uuid, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm mediaDrm, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession.IProvisioningManager provisioningManager, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession.IReleaseCallback releaseCallback, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> schemeDatas, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager", Fields = new string [] {"ModePlayback", "ModeQuery", "ModeDownload", "ModeRelease"})]
		int mode, bool playClearSamplesWithoutKeys, bool isPlaceholderSession, byte[] offlineLicenseKeySetId, global::System.Collections.Generic.IDictionary<string, string> keyRequestParameters, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback @callback, global::Android.OS.Looper playbackLooper, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.EventDispatcher eventDispatcher, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicy loadErrorHandlingPolicy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ProvisioningManager;Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSession$ReleaseCallback;Ljava/util/List;IZZ[BLjava/util/HashMap;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/wow/EventDispatcher;Lcom/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_schemeDatas = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData>.ToLocalJniHandle (schemeDatas);
			IntPtr native_offlineLicenseKeySetId = JNIEnv.NewArray (offlineLicenseKeySetId);
			IntPtr native_keyRequestParameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyRequestParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue ((mediaDrm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaDrm).Handle);
				__args [2] = new JniArgumentValue ((provisioningManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provisioningManager).Handle);
				__args [3] = new JniArgumentValue ((releaseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releaseCallback).Handle);
				__args [4] = new JniArgumentValue (native_schemeDatas);
				__args [5] = new JniArgumentValue (mode);
				__args [6] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [7] = new JniArgumentValue (isPlaceholderSession);
				__args [8] = new JniArgumentValue (native_offlineLicenseKeySetId);
				__args [9] = new JniArgumentValue (native_keyRequestParameters);
				__args [10] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [11] = new JniArgumentValue ((playbackLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackLooper).Handle);
				__args [12] = new JniArgumentValue ((eventDispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventDispatcher).Handle);
				__args [13] = new JniArgumentValue ((loadErrorHandlingPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadErrorHandlingPolicy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_schemeDatas);
				if (offlineLicenseKeySetId != null) {
					JNIEnv.CopyArray (native_offlineLicenseKeySetId, offlineLicenseKeySetId);
					JNIEnv.DeleteLocalRef (native_offlineLicenseKeySetId);
				}
				JNIEnv.DeleteLocalRef (native_keyRequestParameters);
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (mediaDrm);
				global::System.GC.KeepAlive (provisioningManager);
				global::System.GC.KeepAlive (releaseCallback);
				global::System.GC.KeepAlive (schemeDatas);
				global::System.GC.KeepAlive (offlineLicenseKeySetId);
				global::System.GC.KeepAlive (keyRequestParameters);
				global::System.GC.KeepAlive (@callback);
				global::System.GC.KeepAlive (playbackLooper);
				global::System.GC.KeepAlive (eventDispatcher);
				global::System.GC.KeepAlive (loadErrorHandlingPolicy);
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;", "")]
			get {
				const string __id = "getError.()Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object MediaCrypto {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='getMediaCrypto' and count(parameter)=0]"
			[Register ("getMediaCrypto", "()Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;", "")]
			get {
				const string __id = "getMediaCrypto.()Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "")]
			get {
				const string __id = "getState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Acquire ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "GetAcquireHandler")]
		public virtual unsafe void Acquire ()
		{
			const string __id = "acquire.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getOfflineLicenseKeySetId;
#pragma warning disable 0169
		static Delegate GetGetOfflineLicenseKeySetIdHandler ()
		{
			if (cb_getOfflineLicenseKeySetId == null)
				cb_getOfflineLicenseKeySetId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOfflineLicenseKeySetId);
			return cb_getOfflineLicenseKeySetId;
		}

		static IntPtr n_GetOfflineLicenseKeySetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOfflineLicenseKeySetId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='getOfflineLicenseKeySetId' and count(parameter)=0]"
		[Register ("getOfflineLicenseKeySetId", "()[B", "GetGetOfflineLicenseKeySetIdHandler")]
		public virtual unsafe byte[] GetOfflineLicenseKeySetId ()
		{
			const string __id = "getOfflineLicenseKeySetId.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_hasSessionId_arrayB;
#pragma warning disable 0169
		static Delegate GetHasSessionId_arrayBHandler ()
		{
			if (cb_hasSessionId_arrayB == null)
				cb_hasSessionId_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasSessionId_arrayB);
			return cb_hasSessionId_arrayB;
		}

		static bool n_HasSessionId_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_sessionId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sessionId = (byte[]) JNIEnv.GetArray (native_sessionId, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.HasSessionId (sessionId);
			if (sessionId != null)
				JNIEnv.CopyArray (sessionId, native_sessionId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='hasSessionId' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("hasSessionId", "([B)Z", "GetHasSessionId_arrayBHandler")]
		public virtual unsafe bool HasSessionId (byte[] sessionId)
		{
			const string __id = "hasSessionId.([B)Z";
			IntPtr native_sessionId = JNIEnv.NewArray (sessionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sessionId);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (sessionId != null) {
					JNIEnv.CopyArray (native_sessionId, sessionId);
					JNIEnv.DeleteLocalRef (native_sessionId);
				}
				global::System.GC.KeepAlive (sessionId);
			}
		}

		static Delegate cb_onMediaDrmEvent_I;
#pragma warning disable 0169
		static Delegate GetOnMediaDrmEvent_IHandler ()
		{
			if (cb_onMediaDrmEvent_I == null)
				cb_onMediaDrmEvent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMediaDrmEvent_I);
			return cb_onMediaDrmEvent_I;
		}

		static void n_OnMediaDrmEvent_I (IntPtr jnienv, IntPtr native__this, int what)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaDrmEvent (what);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='onMediaDrmEvent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMediaDrmEvent", "(I)V", "GetOnMediaDrmEvent_IHandler")]
		public virtual unsafe void OnMediaDrmEvent (int what)
		{
			const string __id = "onMediaDrmEvent.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (what);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onProvisionCompleted;
#pragma warning disable 0169
		static Delegate GetOnProvisionCompletedHandler ()
		{
			if (cb_onProvisionCompleted == null)
				cb_onProvisionCompleted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnProvisionCompleted);
			return cb_onProvisionCompleted;
		}

		static void n_OnProvisionCompleted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProvisionCompleted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='onProvisionCompleted' and count(parameter)=0]"
		[Register ("onProvisionCompleted", "()V", "GetOnProvisionCompletedHandler")]
		public virtual unsafe void OnProvisionCompleted ()
		{
			const string __id = "onProvisionCompleted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onProvisionError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnProvisionError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onProvisionError_Ljava_lang_Exception_ == null)
				cb_onProvisionError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnProvisionError_Ljava_lang_Exception_);
			return cb_onProvisionError_Ljava_lang_Exception_;
		}

		static void n_OnProvisionError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnProvisionError (error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='onProvisionError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onProvisionError", "(Ljava/lang/Exception;)V", "GetOnProvisionError_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnProvisionError (global::Java.Lang.Exception error)
		{
			const string __id = "onProvisionError.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (error);
			}
		}

		static Delegate cb_playClearSamplesWithoutKeys;
#pragma warning disable 0169
		static Delegate GetPlayClearSamplesWithoutKeysHandler ()
		{
			if (cb_playClearSamplesWithoutKeys == null)
				cb_playClearSamplesWithoutKeys = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_PlayClearSamplesWithoutKeys);
			return cb_playClearSamplesWithoutKeys;
		}

		static bool n_PlayClearSamplesWithoutKeys (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayClearSamplesWithoutKeys ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='playClearSamplesWithoutKeys' and count(parameter)=0]"
		[Register ("playClearSamplesWithoutKeys", "()Z", "GetPlayClearSamplesWithoutKeysHandler")]
		public virtual unsafe bool PlayClearSamplesWithoutKeys ()
		{
			const string __id = "playClearSamplesWithoutKeys.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_provision;
#pragma warning disable 0169
		static Delegate GetProvisionHandler ()
		{
			if (cb_provision == null)
				cb_provision = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Provision);
			return cb_provision;
		}

		static void n_Provision (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Provision ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='provision' and count(parameter)=0]"
		[Register ("provision", "()V", "GetProvisionHandler")]
		public virtual unsafe void Provision ()
		{
			const string __id = "provision.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_queryKeyStatus;
#pragma warning disable 0169
		static Delegate GetQueryKeyStatusHandler ()
		{
			if (cb_queryKeyStatus == null)
				cb_queryKeyStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryKeyStatus);
			return cb_queryKeyStatus;
		}

		static IntPtr n_QueryKeyStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.QueryKeyStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='queryKeyStatus' and count(parameter)=0]"
		[Register ("queryKeyStatus", "()Ljava/util/Map;", "GetQueryKeyStatusHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus ()
		{
			const string __id = "queryKeyStatus.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.DefaultDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='DefaultDrmSession']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
