using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Simple {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public partial class DefaultDrmSessionManager : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/field[@name='INITIAL_DRM_REQUEST_RETRY_COUNT']"
		[Register ("INITIAL_DRM_REQUEST_RETRY_COUNT")]
		public const int InitialDrmRequestRetryCount = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/field[@name='MODE_DOWNLOAD']"
		[Register ("MODE_DOWNLOAD")]
		public const int ModeDownload = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/field[@name='MODE_PLAYBACK']"
		[Register ("MODE_PLAYBACK")]
		public const int ModePlayback = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/field[@name='MODE_QUERY']"
		[Register ("MODE_QUERY")]
		public const int ModeQuery = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/field[@name='MODE_RELEASE']"
		[Register ("MODE_RELEASE")]
		public const int ModeRelease = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/field[@name='PLAYREADY_CUSTOM_DATA_KEY']"
		[Register ("PLAYREADY_CUSTOM_DATA_KEY")]
		public const string PlayreadyCustomDataKey = (string) "PRCustomData";

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='DrmSessionManager']/field[@name='DUMMY']"
			[Register ("DUMMY")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager Dummy {
				get {
					const string __id = "DUMMY.Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/constructor[@name='DefaultDrmSessionManager.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.MediaDrmCallback']]"
			[Register ("build", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager Build (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback mediaDrmCallback)
			{
				const string __id = "build.(Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mediaDrmCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaDrmCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (mediaDrmCallback);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='setKeyRequestParameters' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setKeyRequestParameters", "(Ljava/util/Map;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder SetKeyRequestParameters (global::System.Collections.Generic.IDictionary<string, string> keyRequestParameters)
			{
				const string __id = "setKeyRequestParameters.(Ljava/util/Map;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;";
				IntPtr native_keyRequestParameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyRequestParameters);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_keyRequestParameters);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_keyRequestParameters);
					global::System.GC.KeepAlive (keyRequestParameters);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='setLoadErrorHandlingPolicy' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.LoadErrorHandlingPolicy']]"
			[Register ("setLoadErrorHandlingPolicy", "(Lcom/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder SetLoadErrorHandlingPolicy (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoadErrorHandlingPolicy loadErrorHandlingPolicy)
			{
				const string __id = "setLoadErrorHandlingPolicy.(Lcom/example/androidtvlibrary/main/adapter/Media/LoadErrorHandlingPolicy;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((loadErrorHandlingPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadErrorHandlingPolicy).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (loadErrorHandlingPolicy);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='setMultiSession' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMultiSession", "(Z)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder SetMultiSession (bool multiSession)
			{
				const string __id = "setMultiSession.(Z)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (multiSession);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='setPlayClearSamplesWithoutKeys' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPlayClearSamplesWithoutKeys", "(Z)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder SetPlayClearSamplesWithoutKeys (bool playClearSamplesWithoutKeys)
			{
				const string __id = "setPlayClearSamplesWithoutKeys.(Z)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (playClearSamplesWithoutKeys);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='setUseDrmSessionsForClearContent' and count(parameter)=1 and parameter[1][@type='int...']]"
			[Register ("setUseDrmSessionsForClearContent", "([I)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder SetUseDrmSessionsForClearContent (params int[] useDrmSessionsForClearContentTrackTypes)
			{
				const string __id = "setUseDrmSessionsForClearContent.([I)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;";
				IntPtr native_useDrmSessionsForClearContentTrackTypes = JNIEnv.NewArray (useDrmSessionsForClearContentTrackTypes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_useDrmSessionsForClearContentTrackTypes);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (useDrmSessionsForClearContentTrackTypes != null) {
						JNIEnv.CopyArray (native_useDrmSessionsForClearContentTrackTypes, useDrmSessionsForClearContentTrackTypes);
						JNIEnv.DeleteLocalRef (native_useDrmSessionsForClearContentTrackTypes);
					}
					global::System.GC.KeepAlive (useDrmSessionsForClearContentTrackTypes);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.Builder']/method[@name='setUuidAndExoMediaDrmProvider' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.Provider']]"
			[Register ("setUuidAndExoMediaDrmProvider", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$Provider;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder SetUuidAndExoMediaDrmProvider (global::Java.Util.UUID uuid, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProvider exoMediaDrmProvider)
			{
				const string __id = "setUuidAndExoMediaDrmProvider.(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$Provider;)Lcom/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
					__args [1] = new JniArgumentValue ((exoMediaDrmProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exoMediaDrmProvider).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (uuid);
					global::System.GC.KeepAlive (exoMediaDrmProvider);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager.MissingSchemeDataException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$MissingSchemeDataException", DoNotGenerateAcw=true)]
		public sealed partial class MissingSchemeDataException : global::Java.Lang.Exception {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$MissingSchemeDataException", typeof (MissingSchemeDataException));

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

			internal MissingSchemeDataException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='DefaultDrmSessionManager.Mode']"
		[Register ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Mode", "", "Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager/IModeInvoker")]
		public partial interface IMode : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Mode", DoNotGenerateAcw=true)]
		internal partial class IModeInvoker : global::Java.Lang.Object, IMode {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager$Mode", typeof (IModeInvoker));

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

			public static IMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.simple.DefaultDrmSessionManager.Mode'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/DefaultDrmSessionManager", typeof (DefaultDrmSessionManager));

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

		protected DefaultDrmSessionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/constructor[@name='DefaultDrmSessionManager' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;T&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.drmsession.MediaDrmCallback'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Ljava/util/HashMap;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultDrmSessionManager (global::Java.Util.UUID uuid, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm exoMediaDrm, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback @callback, global::System.Collections.Generic.IDictionary<string, string> keyRequestParameters) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Ljava/util/HashMap;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyRequestParameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyRequestParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue ((exoMediaDrm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exoMediaDrm).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue (native_keyRequestParameters);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyRequestParameters);
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (exoMediaDrm);
				global::System.GC.KeepAlive (@callback);
				global::System.GC.KeepAlive (keyRequestParameters);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/constructor[@name='DefaultDrmSessionManager' and count(parameter)=5 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;T&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.drmsession.MediaDrmCallback'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Ljava/util/HashMap;Z)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultDrmSessionManager (global::Java.Util.UUID uuid, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm exoMediaDrm, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback @callback, global::System.Collections.Generic.IDictionary<string, string> keyRequestParameters, bool multiSession) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Ljava/util/HashMap;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyRequestParameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyRequestParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue ((exoMediaDrm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exoMediaDrm).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue (native_keyRequestParameters);
				__args [4] = new JniArgumentValue (multiSession);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyRequestParameters);
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (exoMediaDrm);
				global::System.GC.KeepAlive (@callback);
				global::System.GC.KeepAlive (keyRequestParameters);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/constructor[@name='DefaultDrmSessionManager' and count(parameter)=6 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm&lt;T&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.drmsession.MediaDrmCallback'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Ljava/util/HashMap;ZI)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultDrmSessionManager (global::Java.Util.UUID uuid, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm exoMediaDrm, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IMediaDrmCallback @callback, global::System.Collections.Generic.IDictionary<string, string> keyRequestParameters, bool multiSession, int initialDrmRequestRetryCount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/UUID;Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm;Lcom/example/androidtvlibrary/main/adapter/drmsession/MediaDrmCallback;Ljava/util/HashMap;ZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyRequestParameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyRequestParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue ((exoMediaDrm == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exoMediaDrm).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue (native_keyRequestParameters);
				__args [4] = new JniArgumentValue (multiSession);
				__args [5] = new JniArgumentValue (initialDrmRequestRetryCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyRequestParameters);
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (exoMediaDrm);
				global::System.GC.KeepAlive (@callback);
				global::System.GC.KeepAlive (keyRequestParameters);
			}
		}

		static Delegate cb_acquirePlaceholderSession_Landroid_os_Looper_I;
#pragma warning disable 0169
		static Delegate GetAcquirePlaceholderSession_Landroid_os_Looper_IHandler ()
		{
			if (cb_acquirePlaceholderSession_Landroid_os_Looper_I == null)
				cb_acquirePlaceholderSession_Landroid_os_Looper_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AcquirePlaceholderSession_Landroid_os_Looper_I);
			return cb_acquirePlaceholderSession_Landroid_os_Looper_I;
		}

		static IntPtr n_AcquirePlaceholderSession_Landroid_os_Looper_I (IntPtr jnienv, IntPtr native__this, IntPtr native_playbackLooper, int trackType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var playbackLooper = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_playbackLooper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquirePlaceholderSession (playbackLooper, trackType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='acquirePlaceholderSession' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='int']]"
		[Register ("acquirePlaceholderSession", "(Landroid/os/Looper;I)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;", "GetAcquirePlaceholderSession_Landroid_os_Looper_IHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession AcquirePlaceholderSession (global::Android.OS.Looper playbackLooper, int trackType)
		{
			const string __id = "acquirePlaceholderSession.(Landroid/os/Looper;I)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((playbackLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackLooper).Handle);
				__args [1] = new JniArgumentValue (trackType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (playbackLooper);
			}
		}

		static Delegate cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
#pragma warning disable 0169
		static Delegate GetAcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler ()
		{
			if (cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == null)
				cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_);
			return cb_acquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		}

		static IntPtr n_AcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_playbackLooper, IntPtr native_drmInitData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var playbackLooper = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_playbackLooper, JniHandleOwnership.DoNotTransfer);
			var drmInitData = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (native_drmInitData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcquireSession (playbackLooper, drmInitData));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='acquireSession' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("acquireSession", "(Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;", "GetAcquireSession_Landroid_os_Looper_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession AcquireSession (global::Android.OS.Looper playbackLooper, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "acquireSession.(Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((playbackLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackLooper).Handle);
				__args [1] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (playbackLooper);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSessionEventListener']]"
		[Register ("addListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSessionEventListener;)V", "")]
		public unsafe void AddListener (global::Android.OS.Handler handler, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IDefaultDrmSessionEventListener eventListener)
		{
			const string __id = "addListener.(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSessionEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		static Delegate cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
#pragma warning disable 0169
		static Delegate GetCanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler ()
		{
			if (cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == null)
				cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_);
			return cb_canAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		}

		static bool n_CanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drmInitData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drmInitData = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (native_drmInitData, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanAcquireSession (drmInitData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='canAcquireSession' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("canAcquireSession", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Z", "GetCanAcquireSession_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler")]
		public virtual unsafe bool CanAcquireSession (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "canAcquireSession.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		static Delegate cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
#pragma warning disable 0169
		static Delegate GetGetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler ()
		{
			if (cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ == null)
				cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_);
			return cb_getExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_;
		}

		static IntPtr n_GetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drmInitData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drmInitData = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (native_drmInitData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetExoMediaCryptoType (drmInitData));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='getExoMediaCryptoType' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("getExoMediaCryptoType", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Ljava/lang/Class;", "GetGetExoMediaCryptoType_Lcom_example_androidtvlibrary_main_adapter_DrmInitData_Handler")]
		public virtual unsafe global::Java.Lang.Class GetExoMediaCryptoType (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "getExoMediaCryptoType.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Ljava/lang/Class;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()V", "")]
		public unsafe void Prepare ()
		{
			const string __id = "prepare.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.DefaultDrmSessionEventListener']]"
		[Register ("removeListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSessionEventListener;)V", "")]
		public unsafe void RemoveListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IDefaultDrmSessionEventListener eventListener)
		{
			const string __id = "removeListener.(Lcom/example/androidtvlibrary/main/adapter/drmsession/DefaultDrmSessionEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventListener);
			}
		}

		static Delegate cb_setMode_IarrayB;
#pragma warning disable 0169
		static Delegate GetSetMode_IarrayBHandler ()
		{
			if (cb_setMode_IarrayB == null)
				cb_setMode_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetMode_IarrayB);
			return cb_setMode_IarrayB;
		}

		static void n_SetMode_IarrayB (IntPtr jnienv, IntPtr native__this, int mode, IntPtr native_offlineLicenseKeySetId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var offlineLicenseKeySetId = (byte[]) JNIEnv.GetArray (native_offlineLicenseKeySetId, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetMode (mode, offlineLicenseKeySetId);
			if (offlineLicenseKeySetId != null)
				JNIEnv.CopyArray (offlineLicenseKeySetId, native_offlineLicenseKeySetId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='DefaultDrmSessionManager']/method[@name='setMode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("setMode", "(I[B)V", "GetSetMode_IarrayBHandler")]
		public virtual unsafe void SetMode ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Simple.DefaultDrmSessionManager", Fields = new string [] {"ModePlayback", "ModeQuery", "ModeDownload", "ModeRelease"})]
		int mode, byte[] offlineLicenseKeySetId)
		{
			const string __id = "setMode.(I[B)V";
			IntPtr native_offlineLicenseKeySetId = JNIEnv.NewArray (offlineLicenseKeySetId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (mode);
				__args [1] = new JniArgumentValue (native_offlineLicenseKeySetId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (offlineLicenseKeySetId != null) {
					JNIEnv.CopyArray (native_offlineLicenseKeySetId, offlineLicenseKeySetId);
					JNIEnv.DeleteLocalRef (native_offlineLicenseKeySetId);
				}
				global::System.GC.KeepAlive (offlineLicenseKeySetId);
			}
		}

	}
}
