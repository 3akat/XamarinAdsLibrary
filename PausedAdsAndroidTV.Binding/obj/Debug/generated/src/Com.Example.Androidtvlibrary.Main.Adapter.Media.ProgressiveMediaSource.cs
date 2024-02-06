using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/ProgressiveMediaSource", DoNotGenerateAcw=true)]
	public sealed partial class ProgressiveMediaSource : global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/field[@name='DEFAULT_LOADING_CHECK_INTERVAL_BYTES']"
		[Register ("DEFAULT_LOADING_CHECK_INTERVAL_BYTES")]
		public const int DefaultLoadingCheckIntervalBytes = (int) 1048576;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/ProgressiveMediaSource", typeof (ProgressiveMediaSource));

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

		internal ProgressiveMediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getTag.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='createPeriod' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[3][@type='long']]"
		[Register ("createPeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;", "")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod CreatePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId id, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator allocator, long startPositionUs)
		{
			const string __id = "createPeriod.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [1] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				__args [2] = new JniArgumentValue (startPositionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (allocator);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='maybeThrowSourceInfoRefreshError' and count(parameter)=0]"
		[Register ("maybeThrowSourceInfoRefreshError", "()V", "")]
		public override unsafe void MaybeThrowSourceInfoRefreshError ()
		{
			const string __id = "maybeThrowSourceInfoRefreshError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='onSourceInfoRefreshed' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("onSourceInfoRefreshed", "(JZZ)V", "")]
		public unsafe void OnSourceInfoRefreshed (long durationUs, bool isSeekable, bool isLive)
		{
			const string __id = "onSourceInfoRefreshed.(JZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (durationUs);
				__args [1] = new JniArgumentValue (isSeekable);
				__args [2] = new JniArgumentValue (isLive);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='prepareSourceInternal' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("prepareSourceInternal", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "")]
		protected override unsafe void PrepareSourceInternal (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener mediaTransferListener)
		{
			const string __id = "prepareSourceInternal.(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaTransferListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaTransferListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaTransferListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='releasePeriod' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("releasePeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "")]
		public override unsafe void ReleasePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod mediaPeriod)
		{
			const string __id = "releasePeriod.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaPeriod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriod).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaPeriod);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ProgressiveMediaSource']/method[@name='releaseSourceInternal' and count(parameter)=0]"
		[Register ("releaseSourceInternal", "()V", "")]
		protected override unsafe void ReleaseSourceInternal ()
		{
			const string __id = "releaseSourceInternal.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
