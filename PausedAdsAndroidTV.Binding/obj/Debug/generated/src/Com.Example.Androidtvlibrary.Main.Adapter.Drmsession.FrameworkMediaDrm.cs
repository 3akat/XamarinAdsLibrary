using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Drmsession {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/FrameworkMediaDrm", DoNotGenerateAcw=true)]
	public sealed partial class FrameworkMediaDrm : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/field[@name='DEFAULT_PROVIDER']"
		[Register ("DEFAULT_PROVIDER")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProvider DefaultProvider {
			get {
				const string __id = "DEFAULT_PROVIDER.Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$Provider;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/FrameworkMediaDrm", typeof (FrameworkMediaDrm));

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

		internal FrameworkMediaDrm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Java.Lang.Class ExoMediaCryptoType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='getExoMediaCryptoType' and count(parameter)=0]"
			[Register ("getExoMediaCryptoType", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getExoMediaCryptoType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.PersistableBundle Metrics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='getMetrics' and count(parameter)=0]"
			[Register ("getMetrics", "()Landroid/os/PersistableBundle;", "")]
			get {
				const string __id = "getMetrics.()Landroid/os/PersistableBundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.PersistableBundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest ProvisionRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='getProvisionRequest' and count(parameter)=0]"
			[Register ("getProvisionRequest", "()Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest;", "")]
			get {
				const string __id = "getProvisionRequest.()Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "")]
		public unsafe void Acquire ()
		{
			const string __id = "acquire.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='closeSession' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("closeSession", "([B)V", "")]
		public unsafe void CloseSession (byte[] sessionId)
		{
			const string __id = "closeSession.([B)V";
			IntPtr native_sessionId = JNIEnv.NewArray (sessionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sessionId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (sessionId != null) {
					JNIEnv.CopyArray (native_sessionId, sessionId);
					JNIEnv.DeleteLocalRef (native_sessionId);
				}
				global::System.GC.KeepAlive (sessionId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='createMediaCrypto' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createMediaCrypto", "([B)Lcom/example/androidtvlibrary/main/adapter/player/FrameworkMediaCrypto;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.FrameworkMediaCrypto CreateMediaCrypto (byte[] initData)
		{
			const string __id = "createMediaCrypto.([B)Lcom/example/androidtvlibrary/main/adapter/player/FrameworkMediaCrypto;";
			IntPtr native_initData = JNIEnv.NewArray (initData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_initData);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.FrameworkMediaCrypto> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (initData != null) {
					JNIEnv.CopyArray (native_initData, initData);
					JNIEnv.DeleteLocalRef (native_initData);
				}
				global::System.GC.KeepAlive (initData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='getKeyRequest' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData&gt;'] and parameter[3][@type='int'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getKeyRequest", "([BLjava/util/List;ILjava/util/HashMap;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest GetKeyRequest (byte[] scope, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> schemeDatas, int keyType, global::System.Collections.Generic.IDictionary<string, string> optionalParameters)
		{
			const string __id = "getKeyRequest.([BLjava/util/List;ILjava/util/HashMap;)Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest;";
			IntPtr native_scope = JNIEnv.NewArray (scope);
			IntPtr native_schemeDatas = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData>.ToLocalJniHandle (schemeDatas);
			IntPtr native_optionalParameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (optionalParameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_scope);
				__args [1] = new JniArgumentValue (native_schemeDatas);
				__args [2] = new JniArgumentValue (keyType);
				__args [3] = new JniArgumentValue (native_optionalParameters);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (scope != null) {
					JNIEnv.CopyArray (native_scope, scope);
					JNIEnv.DeleteLocalRef (native_scope);
				}
				JNIEnv.DeleteLocalRef (native_schemeDatas);
				JNIEnv.DeleteLocalRef (native_optionalParameters);
				global::System.GC.KeepAlive (scope);
				global::System.GC.KeepAlive (schemeDatas);
				global::System.GC.KeepAlive (optionalParameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='getPropertyByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPropertyByteArray", "(Ljava/lang/String;)[B", "")]
		public unsafe byte[] GetPropertyByteArray (string propertyName)
		{
			const string __id = "getPropertyByteArray.(Ljava/lang/String;)[B";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_propertyName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='getPropertyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPropertyString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetPropertyString (string propertyName)
		{
			const string __id = "getPropertyString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_propertyName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='isCryptoSchemeSupported' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("isCryptoSchemeSupported", "(Ljava/util/UUID;)Z", "")]
		public static unsafe bool IsCryptoSchemeSupported (global::Java.Util.UUID uuid)
		{
			const string __id = "isCryptoSchemeSupported.(Ljava/util/UUID;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("newInstance", "(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/drmsession/FrameworkMediaDrm;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.FrameworkMediaDrm NewInstance (global::Java.Util.UUID uuid)
		{
			const string __id = "newInstance.(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/drmsession/FrameworkMediaDrm;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.FrameworkMediaDrm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='openSession' and count(parameter)=0]"
		[Register ("openSession", "()[B", "")]
		public unsafe byte[] OpenSession ()
		{
			const string __id = "openSession.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='provideKeyResponse' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("provideKeyResponse", "([B[B)[B", "")]
		public unsafe byte[] ProvideKeyResponse (byte[] scope, byte[] response)
		{
			const string __id = "provideKeyResponse.([B[B)[B";
			IntPtr native_scope = JNIEnv.NewArray (scope);
			IntPtr native_response = JNIEnv.NewArray (response);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_scope);
				__args [1] = new JniArgumentValue (native_response);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (scope != null) {
					JNIEnv.CopyArray (native_scope, scope);
					JNIEnv.DeleteLocalRef (native_scope);
				}
				if (response != null) {
					JNIEnv.CopyArray (native_response, response);
					JNIEnv.DeleteLocalRef (native_response);
				}
				global::System.GC.KeepAlive (scope);
				global::System.GC.KeepAlive (response);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='provideProvisionResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("provideProvisionResponse", "([B)V", "")]
		public unsafe void ProvideProvisionResponse (byte[] response)
		{
			const string __id = "provideProvisionResponse.([B)V";
			IntPtr native_response = JNIEnv.NewArray (response);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_response);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (response != null) {
					JNIEnv.CopyArray (native_response, response);
					JNIEnv.DeleteLocalRef (native_response);
				}
				global::System.GC.KeepAlive (response);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='queryKeyStatus' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("queryKeyStatus", "([B)Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus (byte[] sessionId)
		{
			const string __id = "queryKeyStatus.([B)Ljava/util/Map;";
			IntPtr native_sessionId = JNIEnv.NewArray (sessionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sessionId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (sessionId != null) {
					JNIEnv.CopyArray (native_sessionId, sessionId);
					JNIEnv.DeleteLocalRef (native_sessionId);
				}
				global::System.GC.KeepAlive (sessionId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='restoreKeys' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("restoreKeys", "([B[B)V", "")]
		public unsafe void RestoreKeys (byte[] sessionId, byte[] keySetId)
		{
			const string __id = "restoreKeys.([B[B)V";
			IntPtr native_sessionId = JNIEnv.NewArray (sessionId);
			IntPtr native_keySetId = JNIEnv.NewArray (keySetId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sessionId);
				__args [1] = new JniArgumentValue (native_keySetId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (sessionId != null) {
					JNIEnv.CopyArray (native_sessionId, sessionId);
					JNIEnv.DeleteLocalRef (native_sessionId);
				}
				if (keySetId != null) {
					JNIEnv.CopyArray (native_keySetId, keySetId);
					JNIEnv.DeleteLocalRef (native_keySetId);
				}
				global::System.GC.KeepAlive (sessionId);
				global::System.GC.KeepAlive (keySetId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='setOnEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnEventListener&lt;? super com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;']]"
		[Register ("setOnEventListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener;)V", "")]
		public unsafe void SetOnEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener listener)
		{
			const string __id = "setOnEventListener.(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='setOnKeyStatusChangeListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.drmsession.ExoMediaDrm.OnKeyStatusChangeListener&lt;? super com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;']]"
		[Register ("setOnKeyStatusChangeListener", "(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener;)V", "")]
		public unsafe void SetOnKeyStatusChangeListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener listener)
		{
			const string __id = "setOnKeyStatusChangeListener.(Lcom/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$OnKeyStatusChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='setPropertyByteArray' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("setPropertyByteArray", "(Ljava/lang/String;[B)V", "")]
		public unsafe void SetPropertyByteArray (string propertyName, byte[] value)
		{
			const string __id = "setPropertyByteArray.(Ljava/lang/String;[B)V";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_propertyName);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='FrameworkMediaDrm']/method[@name='setPropertyString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setPropertyString", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetPropertyString (string propertyName, string value)
		{
			const string __id = "setPropertyString.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_propertyName);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm
		global::Java.Lang.Object global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm.CreateMediaCrypto (byte[] p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(CreateMediaCrypto (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm
		void global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm.SetOnEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener p0)
		{
			SetOnEventListener (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnEventListener>(p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm
		void global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrm.SetOnKeyStatusChangeListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener p0)
		{
			SetOnKeyStatusChangeListener (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.IExoMediaDrmOnKeyStatusChangeListener>(p0));
		}

	}
}
