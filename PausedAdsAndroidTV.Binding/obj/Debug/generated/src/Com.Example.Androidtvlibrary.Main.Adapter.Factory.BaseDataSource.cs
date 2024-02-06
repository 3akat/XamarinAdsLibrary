using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/BaseDataSource", DoNotGenerateAcw=true)]
	public abstract partial class BaseDataSource : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/BaseDataSource", typeof (BaseDataSource));

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

		protected BaseDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/constructor[@name='BaseDataSource' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		protected unsafe BaseDataSource (bool isNetwork) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isNetwork);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='addTransferListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("addTransferListener", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "")]
		public unsafe void AddTransferListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener transferListener)
		{
			const string __id = "addTransferListener.(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transferListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transferListener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (transferListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='bytesTransferred' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bytesTransferred", "(I)V", "")]
		protected unsafe void BytesTransferred (int bytesTransferred)
		{
			const string __id = "bytesTransferred.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bytesTransferred);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='transferEnded' and count(parameter)=0]"
		[Register ("transferEnded", "()V", "")]
		protected unsafe void TransferEnded ()
		{
			const string __id = "transferEnded.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='transferInitializing' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("transferInitializing", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V", "")]
		protected unsafe void TransferInitializing (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec)
		{
			const string __id = "transferInitializing.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='transferStarted' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("transferStarted", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V", "")]
		protected unsafe void TransferStarted (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec)
		{
			const string __id = "transferStarted.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.BytesTransferredEventArgs> BytesTransferredEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				__CreateITransferListenerImplementor,
				AddTransferListener,
				__h => __h.OnBytesTransferredHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor.__IsEmpty,
				__v => {throw new NotSupportedException ("Cannot unregister from Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener.AddTransferListener");},
				__h => __h.OnBytesTransferredHandler -= value);
			}
		}

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.TransferEndEventArgs> TransferEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				__CreateITransferListenerImplementor,
				AddTransferListener,
				__h => __h.OnTransferEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor.__IsEmpty,
				__v => {throw new NotSupportedException ("Cannot unregister from Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener.AddTransferListener");},
				__h => __h.OnTransferEndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.TransferInitializingEventArgs> TransferInitializingEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				__CreateITransferListenerImplementor,
				AddTransferListener,
				__h => __h.OnTransferInitializingHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor.__IsEmpty,
				__v => {throw new NotSupportedException ("Cannot unregister from Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener.AddTransferListener");},
				__h => __h.OnTransferInitializingHandler -= value);
			}
		}

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.TransferStartEventArgs> TransferStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				__CreateITransferListenerImplementor,
				AddTransferListener,
				__h => __h.OnTransferStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor>(
				ref weak_implementor_AddTransferListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor.__IsEmpty,
				__v => {throw new NotSupportedException ("Cannot unregister from Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener.AddTransferListener");},
				__h => __h.OnTransferStartHandler -= value);
			}
		}

		WeakReference weak_implementor_AddTransferListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor __CreateITransferListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListenerImplementor (this);
		}

		#endregion

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.BaseDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.BaseDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Open (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J", "GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler")]
		public abstract long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p0);

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.BaseDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler")]
		public abstract int Read (byte[] p0, int p1, int p2);

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Factory.BaseDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uri);
		}
#pragma warning restore 0169

		public abstract global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/BaseDataSource", DoNotGenerateAcw=true)]
	internal partial class BaseDataSourceInvoker : BaseDataSource {
		public BaseDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/BaseDataSource", typeof (BaseDataSourceInvoker));

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

		public override unsafe global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='BaseDataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
			get {
				const string __id = "getUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J", "GetOpen_Lcom_example_androidtvlibrary_main_adapter_DataSpecTest_Handler")]
		public override unsafe long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest p0)
		{
			const string __id = "open.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler")]
		public override unsafe int Read (byte[] p0, int p1, int p2)
		{
			const string __id = "read.([BII)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
