using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/IcyDataSource", DoNotGenerateAcw=true)]
	public sealed partial class IcyDataSource : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='IcyDataSource.Listener']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/IcyDataSource$Listener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.IcyDataSource/IListenerInvoker")]
		public partial interface IListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='IcyDataSource.Listener']/method[@name='onIcyMetadata' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
			[Register ("onIcyMetadata", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "GetOnIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IcyDataSource/IListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnIcyMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/IcyDataSource$Listener", DoNotGenerateAcw=true)]
		internal partial class IListenerInvoker : global::Java.Lang.Object, IListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/IcyDataSource$Listener", typeof (IListenerInvoker));

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

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.IcyDataSource.Listener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
#pragma warning disable 0169
			static Delegate GetOnIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler ()
			{
				if (cb_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ == null)
					cb_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_);
				return cb_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
			}

			static void n_OnIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IcyDataSource.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIcyMetadata (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
			public unsafe void OnIcyMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0)
			{
				if (id_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ == IntPtr.Zero)
					id_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ = JNIEnv.GetMethodID (class_ref, "onIcyMetadata", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIcyMetadata_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.Media.IcyDataSource.Listener.onIcyMetadata
		public partial class EventArgs : global::System.EventArgs {
			public EventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0)
			{
				this.p0 = p0;
			}

			global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0;

			public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/Media/IcyDataSource_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/Media/IcyDataSource_ListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
			#pragma warning restore 0649

			public void OnIcyMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/IcyDataSource", typeof (IcyDataSource));

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

		internal IcyDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/constructor[@name='IcyDataSource' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='int'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.IcyDataSource.Listener']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;ILcom/example/androidtvlibrary/main/adapter/Media/IcyDataSource$Listener;)V", "")]
		public unsafe IcyDataSource (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource upstream, int metadataIntervalBytes, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IcyDataSource.IListener listener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/DataSource;ILcom/example/androidtvlibrary/main/adapter/Media/IcyDataSource$Listener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((upstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) upstream).Handle);
				__args [1] = new JniArgumentValue (metadataIntervalBytes);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (upstream);
				global::System.GC.KeepAlive (listener);
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getResponseHeaders.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "")]
			get {
				const string __id = "getUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/method[@name='addTransferListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("addTransferListener", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "")]
		public unsafe void AddTransferListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener transferListener)
		{
			const string __id = "addTransferListener.(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transferListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transferListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (transferListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
		[Register ("open", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J", "")]
		public unsafe long Open (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec)
		{
			const string __id = "open.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='IcyDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public unsafe int Read (byte[] buffer, int offset, int readLength)
		{
			const string __id = "read.([BII)I";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (readLength);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.BytesTransferredEventArgs> BytesTransferred {
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

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.TransferInitializingEventArgs> TransferInitializing {
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

	}
}
