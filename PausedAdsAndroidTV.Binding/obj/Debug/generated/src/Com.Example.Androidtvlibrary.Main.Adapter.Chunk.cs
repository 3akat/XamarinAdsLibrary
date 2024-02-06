using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Chunk", DoNotGenerateAcw=true)]
	public abstract partial class Chunk : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.ILoadable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='dataSource']"
		[Register ("dataSource")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.StatsDataSource DataSource {
			get {
				const string __id = "dataSource.Lcom/example/androidtvlibrary/main/adapter/StatsDataSource;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.StatsDataSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dataSource.Lcom/example/androidtvlibrary/main/adapter/StatsDataSource;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='dataSpec']"
		[Register ("dataSpec")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec DataSpec {
			get {
				const string __id = "dataSpec.Lcom/example/androidtvlibrary/main/adapter/DataSpec;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dataSpec.Lcom/example/androidtvlibrary/main/adapter/DataSpec;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='endTimeUs']"
		[Register ("endTimeUs")]
		public long EndTimeUs {
			get {
				const string __id = "endTimeUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "endTimeUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='startTimeUs']"
		[Register ("startTimeUs")]
		public long StartTimeUs {
			get {
				const string __id = "startTimeUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "startTimeUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='trackFormat']"
		[Register ("trackFormat")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Format TrackFormat {
			get {
				const string __id = "trackFormat.Lcom/example/androidtvlibrary/main/adapter/Format;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackFormat.Lcom/example/androidtvlibrary/main/adapter/Format;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='trackSelectionData']"
		[Register ("trackSelectionData")]
		public global::Java.Lang.Object TrackSelectionData {
			get {
				const string __id = "trackSelectionData.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackSelectionData.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='trackSelectionReason']"
		[Register ("trackSelectionReason")]
		public int TrackSelectionReason {
			get {
				const string __id = "trackSelectionReason.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "trackSelectionReason.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/field[@name='type']"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Chunk", typeof (Chunk));

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

		protected Chunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/constructor[@name='Chunk' and count(parameter)=8 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpec'] and parameter[3][@type='int'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.Object'] and parameter[7][@type='long'] and parameter[8][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpec;ILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJ)V", "")]
		public unsafe Chunk (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource dataSource, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec dataSpec, int type, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long startTimeUs, long endTimeUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpec;ILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (type);
				__args [3] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [4] = new JniArgumentValue (trackSelectionReason);
				__args [5] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [6] = new JniArgumentValue (startTimeUs);
				__args [7] = new JniArgumentValue (endTimeUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSource);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
			}
		}

		public unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "")]
			get {
				const string __id = "getDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getResponseHeaders.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "")]
			get {
				const string __id = "getUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Chunk']/method[@name='bytesLoaded' and count(parameter)=0]"
		[Register ("bytesLoaded", "()J", "")]
		public unsafe long BytesLoaded ()
		{
			const string __id = "bytesLoaded.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_cancelLoad;
#pragma warning disable 0169
		static Delegate GetCancelLoadHandler ()
		{
			if (cb_cancelLoad == null)
				cb_cancelLoad = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelLoad);
			return cb_cancelLoad;
		}

		static void n_CancelLoad (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelLoad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']/method[@name='cancelLoad' and count(parameter)=0]"
		[Register ("cancelLoad", "()V", "GetCancelLoadHandler")]
		public abstract void CancelLoad ();

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public abstract void Load ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Chunk", DoNotGenerateAcw=true)]
	internal partial class ChunkInvoker : Chunk {
		public ChunkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Chunk", typeof (ChunkInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']/method[@name='cancelLoad' and count(parameter)=0]"
		[Register ("cancelLoad", "()V", "GetCancelLoadHandler")]
		public override unsafe void CancelLoad ()
		{
			const string __id = "cancelLoad.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public override unsafe void Load ()
		{
			const string __id = "load.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
