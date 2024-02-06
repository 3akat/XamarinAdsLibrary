using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource.Factory']"
	[Register ("com/example/androidtvlibrary/main/adapter/DataSource$Factory", "", "Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceFactoryInvoker")]
	public partial interface IDataSourceFactory : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DataSource$Factory", DoNotGenerateAcw=true)]
	internal partial class IDataSourceFactoryInvoker : global::Java.Lang.Object, IDataSourceFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DataSource$Factory", typeof (IDataSourceFactoryInvoker));

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

		public static IDataSourceFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSourceFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.DataSource.Factory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSourceFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']"
	[Register ("com/example/androidtvlibrary/main/adapter/DataSource", "", "Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceInvoker")]
	public partial interface IDataSource : IJavaObject, IJavaPeerable {
		global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler:Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='addTransferListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("addTransferListener", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "GetAddTransferListener_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		void AddTransferListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J", "GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.IDataSourceInvoker, PausedAdsAndroidTV.Binding")]
		int Read (byte[] p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DataSource", DoNotGenerateAcw=true)]
	internal partial class IDataSourceInvoker : global::Java.Lang.Object, IDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DataSource", typeof (IDataSourceInvoker));

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

		public static IDataSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.DataSource'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}
}
