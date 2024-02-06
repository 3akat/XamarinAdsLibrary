using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$BaseFactory", DoNotGenerateAcw=true)]
	public abstract partial class HttpDataSourceBaseFactory : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$BaseFactory", typeof (HttpDataSourceBaseFactory));

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

		protected HttpDataSourceBaseFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/constructor[@name='HttpDataSource.BaseFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpDataSourceBaseFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties DefaultRequestProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='getDefaultRequestProperties' and count(parameter)=0]"
			[Register ("getDefaultRequestProperties", "()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;", "")]
			get {
				const string __id = "getDefaultRequestProperties.()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='clearAllDefaultRequestProperties' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearAllDefaultRequestProperties", "()V", "")]
		public unsafe void ClearAllDefaultRequestProperties ()
		{
			const string __id = "clearAllDefaultRequestProperties.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='clearDefaultRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("clearDefaultRequestProperty", "(Ljava/lang/String;)V", "")]
		public unsafe void ClearDefaultRequestProperty (string name)
		{
			const string __id = "clearDefaultRequestProperty.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='createDataSource' and count(parameter)=0]"
		[Register ("createDataSource", "()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource CreateDataSource ()
		{
			const string __id = "createDataSource.()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_;
#pragma warning disable 0169
		static Delegate GetCreateDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_Handler ()
		{
			if (cb_createDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_ == null)
				cb_createDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_);
			return cb_createDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_;
		}

		static IntPtr n_CreateDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceBaseFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDataSourceInternal (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='createDataSourceInternal' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.factory.HttpDataSource.RequestProperties']]"
		[Register ("createDataSourceInternal", "(Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;", "GetCreateDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_Handler")]
		protected abstract global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource CreateDataSourceInternal (global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='setDefaultRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetDefaultRequestProperty (string name, string value)
		{
			const string __id = "setDefaultRequestProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$BaseFactory", DoNotGenerateAcw=true)]
	internal partial class HttpDataSourceBaseFactoryInvoker : HttpDataSourceBaseFactory {
		public HttpDataSourceBaseFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$BaseFactory", typeof (HttpDataSourceBaseFactoryInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.BaseFactory']/method[@name='createDataSourceInternal' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.factory.HttpDataSource.RequestProperties']]"
		[Register ("createDataSourceInternal", "(Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;", "GetCreateDataSourceInternal_Lcom_example_androidtvlibrary_main_adapter_factory_HttpDataSource_RequestProperties_Handler")]
		protected override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource CreateDataSourceInternal (global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties p0)
		{
			const string __id = "createDataSourceInternal.(Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;)Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.Factory']"
	[Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$Factory", "", "Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactoryInvoker")]
	public partial interface IHttpDataSourceFactory : global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceFactory {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties DefaultRequestProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.Factory']/method[@name='getDefaultRequestProperties' and count(parameter)=0]"
			[Register ("getDefaultRequestProperties", "()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;", "GetGetDefaultRequestPropertiesHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.Factory']/method[@name='clearAllDefaultRequestProperties' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearAllDefaultRequestProperties", "()V", "GetClearAllDefaultRequestPropertiesHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		void ClearAllDefaultRequestProperties ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.Factory']/method[@name='clearDefaultRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("clearDefaultRequestProperty", "(Ljava/lang/String;)V", "GetClearDefaultRequestProperty_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		void ClearDefaultRequestProperty (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.Factory']/method[@name='createDataSource' and count(parameter)=0]"
		[Register ("createDataSource", "()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;", "GetCreateDataSourceHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource CreateDataSource ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.Factory']/method[@name='setDefaultRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactoryInvoker, PausedAdsAndroidTV.Binding")]
		void SetDefaultRequestProperty (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$Factory", DoNotGenerateAcw=true)]
	internal partial class IHttpDataSourceFactoryInvoker : global::Java.Lang.Object, IHttpDataSourceFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$Factory", typeof (IHttpDataSourceFactoryInvoker));

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

		public static IHttpDataSourceFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpDataSourceFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.factory.HttpDataSource.Factory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpDataSourceFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDefaultRequestProperties;
#pragma warning disable 0169
		static Delegate GetGetDefaultRequestPropertiesHandler ()
		{
			if (cb_getDefaultRequestProperties == null)
				cb_getDefaultRequestProperties = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultRequestProperties);
			return cb_getDefaultRequestProperties;
		}

		static IntPtr n_GetDefaultRequestProperties (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultRequestProperties);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultRequestProperties;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties DefaultRequestProperties {
			get {
				if (id_getDefaultRequestProperties == IntPtr.Zero)
					id_getDefaultRequestProperties = JNIEnv.GetMethodID (class_ref, "getDefaultRequestProperties", "()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultRequestProperties), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clearAllDefaultRequestProperties;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetClearAllDefaultRequestPropertiesHandler ()
		{
			if (cb_clearAllDefaultRequestProperties == null)
				cb_clearAllDefaultRequestProperties = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearAllDefaultRequestProperties);
			return cb_clearAllDefaultRequestProperties;
		}

		[Obsolete]
		static void n_ClearAllDefaultRequestProperties (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllDefaultRequestProperties ();
		}
#pragma warning restore 0169

		IntPtr id_clearAllDefaultRequestProperties;
		public unsafe void ClearAllDefaultRequestProperties ()
		{
			if (id_clearAllDefaultRequestProperties == IntPtr.Zero)
				id_clearAllDefaultRequestProperties = JNIEnv.GetMethodID (class_ref, "clearAllDefaultRequestProperties", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllDefaultRequestProperties);
		}

		static Delegate cb_clearDefaultRequestProperty_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetClearDefaultRequestProperty_Ljava_lang_String_Handler ()
		{
			if (cb_clearDefaultRequestProperty_Ljava_lang_String_ == null)
				cb_clearDefaultRequestProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearDefaultRequestProperty_Ljava_lang_String_);
			return cb_clearDefaultRequestProperty_Ljava_lang_String_;
		}

		[Obsolete]
		static void n_ClearDefaultRequestProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearDefaultRequestProperty (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearDefaultRequestProperty_Ljava_lang_String_;
		public unsafe void ClearDefaultRequestProperty (string p0)
		{
			if (id_clearDefaultRequestProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_clearDefaultRequestProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearDefaultRequestProperty", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearDefaultRequestProperty_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_createDataSource;
#pragma warning disable 0169
		static Delegate GetCreateDataSourceHandler ()
		{
			if (cb_createDataSource == null)
				cb_createDataSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateDataSource);
			return cb_createDataSource;
		}

		static IntPtr n_CreateDataSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateDataSource ());
		}
#pragma warning restore 0169

		IntPtr id_createDataSource;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource CreateDataSource ()
		{
			if (id_createDataSource == IntPtr.Zero)
				id_createDataSource = JNIEnv.GetMethodID (class_ref, "createDataSource", "()Lcom/example/androidtvlibrary/main/adapter/factory/HttpDataSource;");
			return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createDataSource), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		[Obsolete]
		static void n_SetDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultRequestProperty (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetDefaultRequestProperty (string p0, string p1)
		{
			if (id_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultRequestProperty_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$HttpDataSourceException", DoNotGenerateAcw=true)]
	public partial class HttpDataSourceHttpDataSourceException : global::Java.IO.IOException {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/field[@name='dataSpec']"
		[Register ("dataSpec")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest DataSpec {
			get {
				const string __id = "dataSpec.Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dataSpec.Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				const string __id = "type.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "type.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/field[@name='TYPE_CLOSE']"
		[Register ("TYPE_CLOSE")]
		public const int TypeClose = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/field[@name='TYPE_OPEN']"
		[Register ("TYPE_OPEN")]
		public const int TypeOpen = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/field[@name='TYPE_READ']"
		[Register ("TYPE_READ")]
		public const int TypeRead = (int) 2;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource.HttpDataSourceException.Type']"
		[Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$HttpDataSourceException$Type", "", "Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException/ITypeInvoker")]
		public partial interface IType : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$HttpDataSourceException$Type", DoNotGenerateAcw=true)]
		internal partial class ITypeInvoker : global::Java.Lang.Object, IType {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$HttpDataSourceException$Type", typeof (ITypeInvoker));

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

			public static IType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.factory.HttpDataSource.HttpDataSourceException.Type'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException.IType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException.IType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException.IType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException.IType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$HttpDataSourceException", typeof (HttpDataSourceHttpDataSourceException));

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

		protected HttpDataSourceHttpDataSourceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/constructor[@name='HttpDataSource.HttpDataSourceException' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V", "")]
		public unsafe HttpDataSourceHttpDataSourceException (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/constructor[@name='HttpDataSource.HttpDataSourceException' and count(parameter)=3 and parameter[1][@type='java.io.IOException'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/io/IOException;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V", "")]
		public unsafe HttpDataSourceHttpDataSourceException (global::Java.IO.IOException cause, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/IOException;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cause);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/constructor[@name='HttpDataSource.HttpDataSourceException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V", "")]
		public unsafe HttpDataSourceHttpDataSourceException (string message, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.HttpDataSourceException']/constructor[@name='HttpDataSource.HttpDataSourceException' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.IOException'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/io/IOException;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V", "")]
		public unsafe HttpDataSourceHttpDataSourceException (string message, global::Java.IO.IOException cause, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/io/IOException;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				__args [2] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [3] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (cause);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidContentTypeException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$InvalidContentTypeException", DoNotGenerateAcw=true)]
	public sealed partial class HttpDataSourceInvalidContentTypeException : global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidContentTypeException']/field[@name='contentType']"
		[Register ("contentType")]
		public string ContentType {
			get {
				const string __id = "contentType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "contentType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$InvalidContentTypeException", typeof (HttpDataSourceInvalidContentTypeException));

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

		internal HttpDataSourceInvalidContentTypeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidContentTypeException']/constructor[@name='HttpDataSource.InvalidContentTypeException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V", "")]
		public unsafe HttpDataSourceInvalidContentTypeException (string contentType, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_contentType = JNIEnv.NewString (contentType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_contentType);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contentType);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidResponseCodeException']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$InvalidResponseCodeException", DoNotGenerateAcw=true)]
	public sealed partial class HttpDataSourceInvalidResponseCodeException : global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidResponseCodeException']/field[@name='headerFields']"
		[Register ("headerFields")]
		public global::System.Collections.IDictionary HeaderFields {
			get {
				const string __id = "headerFields.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "headerFields.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidResponseCodeException']/field[@name='responseCode']"
		[Register ("responseCode")]
		public int ResponseCode {
			get {
				const string __id = "responseCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "responseCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidResponseCodeException']/field[@name='responseMessage']"
		[Register ("responseMessage")]
		public string ResponseMessage {
			get {
				const string __id = "responseMessage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "responseMessage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$InvalidResponseCodeException", typeof (HttpDataSourceInvalidResponseCodeException));

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

		internal HttpDataSourceInvalidResponseCodeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidResponseCodeException']/constructor[@name='HttpDataSource.InvalidResponseCodeException' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/util/Map;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V", "")]
		public unsafe HttpDataSourceInvalidResponseCodeException (int responseCode, string responseMessage, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> headerFields, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/util/Map;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_responseMessage = JNIEnv.NewString (responseMessage);
			IntPtr native_headerFields = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (headerFields);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (responseCode);
				__args [1] = new JniArgumentValue (native_responseMessage);
				__args [2] = new JniArgumentValue (native_headerFields);
				__args [3] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseMessage);
				JNIEnv.DeleteLocalRef (native_headerFields);
				global::System.GC.KeepAlive (headerFields);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.InvalidResponseCodeException']/constructor[@name='HttpDataSource.InvalidResponseCodeException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register (".ctor", "(ILjava/util/Map;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe HttpDataSourceInvalidResponseCodeException (int responseCode, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> headerFields, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/util/Map;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_headerFields = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (headerFields);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (responseCode);
				__args [1] = new JniArgumentValue (native_headerFields);
				__args [2] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerFields);
				global::System.GC.KeepAlive (headerFields);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties", DoNotGenerateAcw=true)]
	public sealed partial class HttpDataSourceRequestProperties : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties", typeof (HttpDataSourceRequestProperties));

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

		internal HttpDataSourceRequestProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/constructor[@name='HttpDataSource.RequestProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpDataSourceRequestProperties () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::System.Collections.Generic.IDictionary<string, string> Snapshot {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/method[@name='getSnapshot' and count(parameter)=0]"
			[Register ("getSnapshot", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getSnapshot.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/method[@name='clearAndSet' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("clearAndSet", "(Ljava/util/Map;)V", "")]
		public unsafe void ClearAndSet (global::System.Collections.Generic.IDictionary<string, string> properties)
		{
			const string __id = "clearAndSet.(Ljava/util/Map;)V";
			IntPtr native_properties = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_properties);
				global::System.GC.KeepAlive (properties);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "")]
		public unsafe void Remove (string name)
		{
			const string __id = "remove.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Set (string name, string value)
		{
			const string __id = "set.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='HttpDataSource.RequestProperties']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("set", "(Ljava/util/Map;)V", "")]
		public unsafe void Set (global::System.Collections.Generic.IDictionary<string, string> properties)
		{
			const string __id = "set.(Ljava/util/Map;)V";
			IntPtr native_properties = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (properties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_properties);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_properties);
				global::System.GC.KeepAlive (properties);
			}
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource", DoNotGenerateAcw=true)]
	public abstract class HttpDataSource : Java.Lang.Object {
		internal HttpDataSource ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/field[@name='REJECT_PAYWALL_TYPES']"
		[Register ("REJECT_PAYWALL_TYPES")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate RejectPaywallTypes {
			get {
				const string __id = "REJECT_PAYWALL_TYPES.Lcom/example/androidtvlibrary/main/adapter/factory/Predicate;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IPredicate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// The following are fields from: com.example.androidtvlibrary.main.adapter.DataSource

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource", typeof (HttpDataSource));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpDataSource' type. This type will be removed in a future release.", error: true)]
	public abstract class HttpDataSourceConsts : HttpDataSource {
		private HttpDataSourceConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']"
	[Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource", "", "Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker")]
	public partial interface IHttpDataSource : global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource {
		int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/Map;", "GetGetResponseHeadersHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='clearAllRequestProperties' and count(parameter)=0]"
		[Register ("clearAllRequestProperties", "()V", "GetClearAllRequestPropertiesHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		void ClearAllRequestProperties ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='clearRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearRequestProperty", "(Ljava/lang/String;)V", "GetClearRequestProperty_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		void ClearRequestProperty (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J", "GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		int Read (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/interface[@name='HttpDataSource']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		void SetRequestProperty (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource", DoNotGenerateAcw=true)]
	internal partial class IHttpDataSourceInvoker : global::Java.Lang.Object, IHttpDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/HttpDataSource", typeof (IHttpDataSourceInvoker));

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

		public static IHttpDataSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpDataSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.factory.HttpDataSource'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		IntPtr id_getResponseCode;
		public unsafe int ResponseCode {
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getResponseCode);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.ResponseHeaders);
		}
#pragma warning restore 0169

		IntPtr id_getResponseHeaders;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			get {
				if (id_getResponseHeaders == IntPtr.Zero)
					id_getResponseHeaders = JNIEnv.GetMethodID (class_ref, "getResponseHeaders", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHeaders), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllRequestProperties ();
		}
#pragma warning restore 0169

		IntPtr id_clearAllRequestProperties;
		public unsafe void ClearAllRequestProperties ()
		{
			if (id_clearAllRequestProperties == IntPtr.Zero)
				id_clearAllRequestProperties = JNIEnv.GetMethodID (class_ref, "clearAllRequestProperties", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllRequestProperties);
		}

		static Delegate cb_clearRequestProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearRequestProperty_Ljava_lang_String_Handler ()
		{
			if (cb_clearRequestProperty_Ljava_lang_String_ == null)
				cb_clearRequestProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearRequestProperty_Ljava_lang_String_);
			return cb_clearRequestProperty_Ljava_lang_String_;
		}

		static void n_ClearRequestProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearRequestProperty (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearRequestProperty_Ljava_lang_String_;
		public unsafe void ClearRequestProperty (string p0)
		{
			if (id_clearRequestProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_clearRequestProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearRequestProperty", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearRequestProperty_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_;
#pragma warning disable 0169
		static Delegate GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler ()
		{
			if (cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ == null)
				cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_Open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_);
			return cb_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_;
		}

		static long n_Open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Open (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_;
		public unsafe long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p0)
		{
			if (id_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ == IntPtr.Zero)
				id_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ = JNIEnv.GetMethodID (class_ref, "open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_open_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_, __args);
			return __ret;
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBII;
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetRequestProperty (string p0, string p1)
		{
			if (id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uri);
		}
#pragma warning restore 0169

		IntPtr id_getUri;
		public unsafe global::Android.Net.Uri Uri {
			get {
				if (id_getUri == IntPtr.Zero)
					id_getUri = JNIEnv.GetMethodID (class_ref, "getUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
#pragma warning disable 0169
		static Delegate GetAddTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler ()
		{
			if (cb_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ == null)
				cb_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_);
			return cb_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
		}

		static void n_AddTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.IHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTransferListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
		public unsafe void AddTransferListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener p0)
		{
			if (id_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ == IntPtr.Zero)
				id_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ = JNIEnv.GetMethodID (class_ref, "addTransferListener", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_, __args);
		}

	}
}
