using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DrmSession.DrmSessionException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException", DoNotGenerateAcw=true)]
	public partial class DrmSessionDrmSessionException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException", typeof (DrmSessionDrmSessionException));

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

		protected DrmSessionDrmSessionException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DrmSession.DrmSessionException']/constructor[@name='DrmSession.DrmSessionException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe DrmSessionDrmSessionException (global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession.State']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession$State", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionStateInvoker")]
	public partial interface IDrmSessionState : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession$State", DoNotGenerateAcw=true)]
	internal partial class IDrmSessionStateInvoker : global::Java.Lang.Object, IDrmSessionState {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DrmSession$State", typeof (IDrmSessionStateInvoker));

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

		public static IDrmSessionState GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrmSessionState> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.DrmSession.State'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrmSessionStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession", DoNotGenerateAcw=true)]
	public abstract class DrmSession : Java.Lang.Object {
		internal DrmSession ()
		{
		}

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='replaceSession' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DrmSession&lt;T&gt;'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DrmSession&lt;T&gt;']]"
		[Register ("replaceSession", "(Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
		public static unsafe void ReplaceSession (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession previousSession, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession newSession)
		{
			const string __id = "replaceSession.(Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((previousSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) previousSession).Handle);
				__args [1] = new JniArgumentValue ((newSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newSession).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (previousSession);
				global::System.GC.KeepAlive (newSession);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DrmSession", typeof (DrmSession));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'DrmSession' type. This type will be removed in a future release.", error: true)]
	public abstract class DrmSessionConsts : DrmSession {
		private DrmSessionConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial interface IDrmSession : IJavaObject, IJavaPeerable {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;", "GetGetErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Java.Lang.Object MediaCrypto {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='getMediaCrypto' and count(parameter)=0]"
			[Register ("getMediaCrypto", "()Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;", "GetGetMediaCryptoHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "GetAcquireHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
		void Acquire ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='getOfflineLicenseKeySetId' and count(parameter)=0]"
		[Register ("getOfflineLicenseKeySetId", "()[B", "GetGetOfflineLicenseKeySetIdHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
		byte[] GetOfflineLicenseKeySetId ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='queryKeyStatus' and count(parameter)=0]"
		[Register ("queryKeyStatus", "()Ljava/util/Map;", "GetQueryKeyStatusHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
		global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSessionInvoker, PausedAdsAndroidTV.Binding")]
		void Release ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DrmSession", DoNotGenerateAcw=true)]
	internal partial class IDrmSessionInvoker : global::Java.Lang.Object, IDrmSession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DrmSession", typeof (IDrmSessionInvoker));

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

		public static IDrmSession GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrmSession> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.DrmSession'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrmSessionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		IntPtr id_getError;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException Error {
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMediaCrypto;
#pragma warning disable 0169
		static Delegate GetGetMediaCryptoHandler ()
		{
			if (cb_getMediaCrypto == null)
				cb_getMediaCrypto = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMediaCrypto);
			return cb_getMediaCrypto;
		}

		static IntPtr n_GetMediaCrypto (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaCrypto);
		}
#pragma warning restore 0169

		IntPtr id_getMediaCrypto;
		public unsafe global::Java.Lang.Object MediaCrypto {
			get {
				if (id_getMediaCrypto == IntPtr.Zero)
					id_getMediaCrypto = JNIEnv.GetMethodID (class_ref, "getMediaCrypto", "()Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaCrypto), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe int State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getState);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOfflineLicenseKeySetId ());
		}
#pragma warning restore 0169

		IntPtr id_getOfflineLicenseKeySetId;
		public unsafe byte[] GetOfflineLicenseKeySetId ()
		{
			if (id_getOfflineLicenseKeySetId == IntPtr.Zero)
				id_getOfflineLicenseKeySetId = JNIEnv.GetMethodID (class_ref, "getOfflineLicenseKeySetId", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOfflineLicenseKeySetId), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.QueryKeyStatus ());
		}
#pragma warning restore 0169

		IntPtr id_queryKeyStatus;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus ()
		{
			if (id_queryKeyStatus == IntPtr.Zero)
				id_queryKeyStatus = JNIEnv.GetMethodID (class_ref, "queryKeyStatus", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryKeyStatus), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}
}
