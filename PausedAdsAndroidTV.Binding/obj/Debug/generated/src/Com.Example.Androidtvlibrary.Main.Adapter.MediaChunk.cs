using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='MediaChunk']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/MediaChunk", DoNotGenerateAcw=true)]
	public abstract partial class MediaChunk : global::Com.Example.Androidtvlibrary.Main.Adapter.Chunk {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='MediaChunk']/field[@name='chunkIndex']"
		[Register ("chunkIndex")]
		public long ChunkIndex {
			get {
				const string __id = "chunkIndex.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "chunkIndex.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/MediaChunk", typeof (MediaChunk));

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

		protected MediaChunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='MediaChunk']/constructor[@name='MediaChunk' and count(parameter)=8 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpec'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpec;Lcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJ)V", "")]
		public unsafe MediaChunk (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource dataSource, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec dataSpec, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long startTimeUs, long endTimeUs, long chunkIndex) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpec;Lcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [3] = new JniArgumentValue (trackSelectionReason);
				__args [4] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [5] = new JniArgumentValue (startTimeUs);
				__args [6] = new JniArgumentValue (endTimeUs);
				__args [7] = new JniArgumentValue (chunkIndex);
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

		static Delegate cb_isLoadCompleted;
#pragma warning disable 0169
		static Delegate GetIsLoadCompletedHandler ()
		{
			if (cb_isLoadCompleted == null)
				cb_isLoadCompleted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoadCompleted);
			return cb_isLoadCompleted;
		}

		static bool n_IsLoadCompleted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoadCompleted;
		}
#pragma warning restore 0169

		public abstract bool IsLoadCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='MediaChunk']/method[@name='isLoadCompleted' and count(parameter)=0]"
			[Register ("isLoadCompleted", "()Z", "GetIsLoadCompletedHandler")]
			get; 
		}

		static Delegate cb_getNextChunkIndex;
#pragma warning disable 0169
		static Delegate GetGetNextChunkIndexHandler ()
		{
			if (cb_getNextChunkIndex == null)
				cb_getNextChunkIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNextChunkIndex);
			return cb_getNextChunkIndex;
		}

		static long n_GetNextChunkIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextChunkIndex;
		}
#pragma warning restore 0169

		public virtual unsafe long NextChunkIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='MediaChunk']/method[@name='getNextChunkIndex' and count(parameter)=0]"
			[Register ("getNextChunkIndex", "()J", "GetGetNextChunkIndexHandler")]
			get {
				const string __id = "getNextChunkIndex.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/MediaChunk", DoNotGenerateAcw=true)]
	internal partial class MediaChunkInvoker : MediaChunk {
		public MediaChunkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/MediaChunk", typeof (MediaChunkInvoker));

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

		public override unsafe bool IsLoadCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='MediaChunk']/method[@name='isLoadCompleted' and count(parameter)=0]"
			[Register ("isLoadCompleted", "()Z", "GetIsLoadCompletedHandler")]
			get {
				const string __id = "isLoadCompleted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
