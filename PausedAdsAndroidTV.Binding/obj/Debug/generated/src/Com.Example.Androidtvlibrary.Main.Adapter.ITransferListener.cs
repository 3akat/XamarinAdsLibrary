using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TransferListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/TransferListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerInvoker")]
	public partial interface ITransferListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TransferListener']/method[@name='onBytesTransferred' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("onBytesTransferred", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;ZI)V", "GetOnBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZIHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnBytesTransferred (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TransferListener']/method[@name='onTransferEnd' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean']]"
		[Register ("onTransferEnd", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V", "GetOnTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnTransferEnd (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TransferListener']/method[@name='onTransferInitializing' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean']]"
		[Register ("onTransferInitializing", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V", "GetOnTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnTransferInitializing (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TransferListener']/method[@name='onTransferStart' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean']]"
		[Register ("onTransferStart", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V", "GetOnTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnTransferStart (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TransferListener", DoNotGenerateAcw=true)]
	internal partial class ITransferListenerInvoker : global::Java.Lang.Object, ITransferListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TransferListener", typeof (ITransferListenerInvoker));

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

		public static ITransferListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransferListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TransferListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransferListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI;
#pragma warning disable 0169
		static Delegate GetOnBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZIHandler ()
		{
			if (cb_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI == null)
				cb_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZI_V) n_OnBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI);
			return cb_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI;
		}

		static void n_OnBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBytesTransferred (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI;
		public unsafe void OnBytesTransferred (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2, int p3)
		{
			if (id_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI == IntPtr.Zero)
				id_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI = JNIEnv.GetMethodID (class_ref, "onBytesTransferred", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;ZI)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBytesTransferred_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZI, __args);
		}

		static Delegate cb_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
#pragma warning disable 0169
		static Delegate GetOnTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZHandler ()
		{
			if (cb_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z == null)
				cb_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_OnTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z);
			return cb_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
		}

		static void n_OnTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferEnd (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
		public unsafe void OnTransferEnd (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			if (id_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z == IntPtr.Zero)
				id_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z = JNIEnv.GetMethodID (class_ref, "onTransferEnd", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferEnd_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z, __args);
		}

		static Delegate cb_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
#pragma warning disable 0169
		static Delegate GetOnTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZHandler ()
		{
			if (cb_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z == null)
				cb_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_OnTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z);
			return cb_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
		}

		static void n_OnTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferInitializing (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
		public unsafe void OnTransferInitializing (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			if (id_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z == IntPtr.Zero)
				id_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z = JNIEnv.GetMethodID (class_ref, "onTransferInitializing", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferInitializing_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z, __args);
		}

		static Delegate cb_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
#pragma warning disable 0169
		static Delegate GetOnTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_ZHandler ()
		{
			if (cb_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z == null)
				cb_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_OnTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z);
			return cb_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
		}

		static void n_OnTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferStart (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z;
		public unsafe void OnTransferStart (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			if (id_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z == IntPtr.Zero)
				id_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z = JNIEnv.GetMethodID (class_ref, "onTransferStart", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferStart_Lcom_example_androidtvlibrary_main_adapter_DataSource_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Z, __args);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.TransferListener.onBytesTransferred
	public partial class BytesTransferredEventArgs : global::System.EventArgs {
		public BytesTransferredEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource P0 {
			get { return p0; }
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest P1 {
			get { return p1; }
		}

		bool p2;

		public bool P2 {
			get { return p2; }
		}

		int p3;

		public int P3 {
			get { return p3; }
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.TransferListener.onTransferEnd
	public partial class TransferEndEventArgs : global::System.EventArgs {
		public TransferEndEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource P0 {
			get { return p0; }
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest P1 {
			get { return p1; }
		}

		bool p2;

		public bool P2 {
			get { return p2; }
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.TransferListener.onTransferInitializing
	public partial class TransferInitializingEventArgs : global::System.EventArgs {
		public TransferInitializingEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource P0 {
			get { return p0; }
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest P1 {
			get { return p1; }
		}

		bool p2;

		public bool P2 {
			get { return p2; }
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.TransferListener.onTransferStart
	public partial class TransferStartEventArgs : global::System.EventArgs {
		public TransferStartEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource P0 {
			get { return p0; }
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest P1 {
			get { return p1; }
		}

		bool p2;

		public bool P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/TransferListenerImplementor")]
	internal sealed partial class ITransferListenerImplementor : global::Java.Lang.Object, ITransferListener {

		object sender;

		public ITransferListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/TransferListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<BytesTransferredEventArgs> OnBytesTransferredHandler;
		#pragma warning restore 0649

		public void OnBytesTransferred (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2, int p3)
		{
			var __h = OnBytesTransferredHandler;
			if (__h != null)
				__h (sender, new BytesTransferredEventArgs (p0, p1, p2, p3));
		}

		#pragma warning disable 0649
		public EventHandler<TransferEndEventArgs> OnTransferEndHandler;
		#pragma warning restore 0649

		public void OnTransferEnd (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			var __h = OnTransferEndHandler;
			if (__h != null)
				__h (sender, new TransferEndEventArgs (p0, p1, p2));
		}

		#pragma warning disable 0649
		public EventHandler<TransferInitializingEventArgs> OnTransferInitializingHandler;
		#pragma warning restore 0649

		public void OnTransferInitializing (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			var __h = OnTransferInitializingHandler;
			if (__h != null)
				__h (sender, new TransferInitializingEventArgs (p0, p1, p2));
		}

		#pragma warning disable 0649
		public EventHandler<TransferStartEventArgs> OnTransferStartHandler;
		#pragma warning restore 0649

		public void OnTransferStart (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p1, bool p2)
		{
			var __h = OnTransferStartHandler;
			if (__h != null)
				__h (sender, new TransferStartEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ITransferListenerImplementor value)
		{
			return value.OnBytesTransferredHandler == null && value.OnTransferEndHandler == null && value.OnTransferInitializingHandler == null && value.OnTransferStartHandler == null;
		}

	}
}
