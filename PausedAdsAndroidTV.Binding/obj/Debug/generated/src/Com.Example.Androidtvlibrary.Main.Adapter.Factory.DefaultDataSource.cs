using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/factory/DefaultDataSource", DoNotGenerateAcw=true)]
	public sealed partial class DefaultDataSource : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/factory/DefaultDataSource", typeof (DefaultDataSource));

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

		internal DefaultDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/constructor[@name='DefaultDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSource']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/DataSource;)V", "")]
		public unsafe DefaultDataSource (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource baseDataSource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/DataSource;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((baseDataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseDataSource).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (baseDataSource);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/constructor[@name='DefaultDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public unsafe DefaultDataSource (global::Android.Content.Context context, string userAgent, bool allowCrossProtocolRedirects) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_userAgent);
				__args [2] = new JniArgumentValue (allowCrossProtocolRedirects);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/constructor[@name='DefaultDataSource' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;IIZ)V", "")]
		public unsafe DefaultDataSource (global::Android.Content.Context context, string userAgent, int connectTimeoutMillis, int readTimeoutMillis, bool allowCrossProtocolRedirects) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;IIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userAgent = JNIEnv.NewString (userAgent);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_userAgent);
				__args [2] = new JniArgumentValue (connectTimeoutMillis);
				__args [3] = new JniArgumentValue (readTimeoutMillis);
				__args [4] = new JniArgumentValue (allowCrossProtocolRedirects);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userAgent);
				global::System.GC.KeepAlive (context);
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/method[@name='getResponseHeaders' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/method[@name='getUri' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/method[@name='addTransferListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.factory']/class[@name='DefaultDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
