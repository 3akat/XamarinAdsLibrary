using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/DefaultHttpDataSource", DoNotGenerateAcw=true)]
	public partial class DefaultHttpDataSource : global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.BaseDataSource, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/field[@name='DEFAULT_CONNECT_TIMEOUT_MILLIS']"
		[Register ("DEFAULT_CONNECT_TIMEOUT_MILLIS")]
		public const int DefaultConnectTimeoutMillis = (int) 8000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/field[@name='DEFAULT_READ_TIMEOUT_MILLIS']"
		[Register ("DEFAULT_READ_TIMEOUT_MILLIS")]
		public const int DefaultReadTimeoutMillis = (int) 8000;

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.factory.HttpDataSource


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/field[@name='REJECT_PAYWALL_TYPES']"
			[Register ("REJECT_PAYWALL_TYPES")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate RejectPaywallTypes {
				get {
					const string __id = "REJECT_PAYWALL_TYPES.Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/DefaultHttpDataSource", typeof (DefaultHttpDataSource));

		internal static new IntPtr class_ref {
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

		protected DefaultHttpDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DefaultHttpDataSource (string userAgent) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userAgent);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.factory.Predicate&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultHttpDataSource (string userAgent, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate contentTypePredicate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_userAgent);
				__args [1] = new JniArgumentValue ((contentTypePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentTypePredicate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
				global::System.GC.KeepAlive (contentTypePredicate);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.factory.Predicate&lt;java.lang.String&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;II)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultHttpDataSource (string userAgent, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate contentTypePredicate, int connectTimeoutMillis, int readTimeoutMillis) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_userAgent);
				__args [1] = new JniArgumentValue ((contentTypePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentTypePredicate).Handle);
				__args [2] = new JniArgumentValue (connectTimeoutMillis);
				__args [3] = new JniArgumentValue (readTimeoutMillis);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
				global::System.GC.KeepAlive (contentTypePredicate);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.factory.Predicate&lt;java.lang.String&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.factory.HttpDataSource.RequestProperties']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;IIZLcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultHttpDataSource (string userAgent, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate contentTypePredicate, int connectTimeoutMillis, int readTimeoutMillis, bool allowCrossProtocolRedirects, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties defaultRequestProperties) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;IIZLcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_userAgent);
				__args [1] = new JniArgumentValue ((contentTypePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentTypePredicate).Handle);
				__args [2] = new JniArgumentValue (connectTimeoutMillis);
				__args [3] = new JniArgumentValue (readTimeoutMillis);
				__args [4] = new JniArgumentValue (allowCrossProtocolRedirects);
				__args [5] = new JniArgumentValue ((defaultRequestProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultRequestProperties).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
				global::System.GC.KeepAlive (contentTypePredicate);
				global::System.GC.KeepAlive (defaultRequestProperties);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;II)V", "")]
		public unsafe DefaultHttpDataSource (string userAgent, int connectTimeoutMillis, int readTimeoutMillis) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_userAgent);
				__args [1] = new JniArgumentValue (connectTimeoutMillis);
				__args [2] = new JniArgumentValue (readTimeoutMillis);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.factory.HttpDataSource.RequestProperties']]"
		[Register (".ctor", "(Ljava/lang/String;IIZLcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)V", "")]
		public unsafe DefaultHttpDataSource (string userAgent, int connectTimeoutMillis, int readTimeoutMillis, bool allowCrossProtocolRedirects, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties defaultRequestProperties) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IIZLcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_userAgent);
				__args [1] = new JniArgumentValue (connectTimeoutMillis);
				__args [2] = new JniArgumentValue (readTimeoutMillis);
				__args [3] = new JniArgumentValue (allowCrossProtocolRedirects);
				__args [4] = new JniArgumentValue ((defaultRequestProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultRequestProperties).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
				global::System.GC.KeepAlive (defaultRequestProperties);
			}
		}

		protected unsafe global::Java.Net.HttpURLConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Ljava/net/HttpURLConnection;", "")]
			get {
				const string __id = "getConnection.()Ljava/net/HttpURLConnection;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static int n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				const string __id = "getResponseCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getResponseHeaders;
#pragma warning disable 0169
		static Delegate GetGetResponseHeadersHandler ()
		{
			if (cb_getResponseHeaders == null)
				cb_getResponseHeaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseHeaders);
			return cb_getResponseHeaders;
		}

		static IntPtr n_GetResponseHeaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.ResponseHeaders);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/Map;", "GetGetResponseHeadersHandler")]
			get {
				const string __id = "getResponseHeaders.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUri;
#pragma warning disable 0169
		static Delegate GetGetUriHandler ()
		{
			if (cb_getUri == null)
				cb_getUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUri);
			return cb_getUri;
		}

		static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uri);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
			get {
				const string __id = "getUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='bytesRead' and count(parameter)=0]"
		[Register ("bytesRead", "()J", "")]
		protected unsafe long BytesRead ()
		{
			const string __id = "bytesRead.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='bytesRemaining' and count(parameter)=0]"
		[Register ("bytesRemaining", "()J", "")]
		protected unsafe long BytesRemaining ()
		{
			const string __id = "bytesRemaining.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='bytesSkipped' and count(parameter)=0]"
		[Register ("bytesSkipped", "()J", "")]
		protected unsafe long BytesSkipped ()
		{
			const string __id = "bytesSkipped.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearAllRequestProperties;
#pragma warning disable 0169
		static Delegate GetClearAllRequestPropertiesHandler ()
		{
			if (cb_clearAllRequestProperties == null)
				cb_clearAllRequestProperties = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearAllRequestProperties);
			return cb_clearAllRequestProperties;
		}

		static void n_ClearAllRequestProperties (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllRequestProperties ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='clearAllRequestProperties' and count(parameter)=0]"
		[Register ("clearAllRequestProperties", "()V", "GetClearAllRequestPropertiesHandler")]
		public virtual unsafe void ClearAllRequestProperties ()
		{
			const string __id = "clearAllRequestProperties.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearRequestProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearRequestProperty_Ljava_lang_String_Handler ()
		{
			if (cb_clearRequestProperty_Ljava_lang_String_ == null)
				cb_clearRequestProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearRequestProperty_Ljava_lang_String_);
			return cb_clearRequestProperty_Ljava_lang_String_;
		}

		static void n_ClearRequestProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.ClearRequestProperty (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='clearRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearRequestProperty", "(Ljava/lang/String;)V", "GetClearRequestProperty_Ljava_lang_String_Handler")]
		public virtual unsafe void ClearRequestProperty (string name)
		{
			const string __id = "clearRequestProperty.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_;
#pragma warning disable 0169
		static Delegate GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler ()
		{
			if (cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ == null)
				cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_Open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_);
			return cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_;
		}

		static long n_Open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSpec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataSpec = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_dataSpec, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Open (dataSpec);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J", "GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler")]
		public override unsafe long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec)
		{
			const string __id = "open.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int offset, int readLength)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (buffer, offset, readLength);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler")]
		public override unsafe int Read (byte[] buffer, int offset, int readLength)
		{
			const string __id = "read.([BII)I";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (readLength);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		static Delegate cb_setContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_;
#pragma warning disable 0169
		static Delegate GetSetContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_Handler ()
		{
			if (cb_setContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_ == null)
				cb_setContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_);
			return cb_setContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_;
		}

		static void n_SetContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentTypePredicate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentTypePredicate = (global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate> (native_contentTypePredicate, JniHandleOwnership.DoNotTransfer);
			__this.SetContentTypePredicate (contentTypePredicate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='setContentTypePredicate' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.factory.Predicate&lt;java.lang.String&gt;']]"
		[Register ("setContentTypePredicate", "(Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;)V", "GetSetContentTypePredicate_Lcom_example_androidtvlibrary_main_adapter_factory_Predicate_Handler")]
		public virtual unsafe void SetContentTypePredicate (global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate contentTypePredicate)
		{
			const string __id = "setContentTypePredicate.(Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((contentTypePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentTypePredicate).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (contentTypePredicate);
			}
		}

		static Delegate cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (name, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultHttpDataSource']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRequestProperty (string name, string value)
		{
			const string __id = "setRequestProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
