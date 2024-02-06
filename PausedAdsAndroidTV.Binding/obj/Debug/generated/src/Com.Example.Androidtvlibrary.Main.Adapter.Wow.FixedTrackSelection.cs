using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/FixedTrackSelection", DoNotGenerateAcw=true)]
	public sealed partial class FixedTrackSelection : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/FixedTrackSelection", typeof (FixedTrackSelection));

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

		internal FixedTrackSelection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/constructor[@name='FixedTrackSelection' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;I)V", "")]
		public unsafe FixedTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, int track) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (track);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (group);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/constructor[@name='FixedTrackSelection' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;II)V", "")]
		public unsafe FixedTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, int track, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection", Fields = new string [] {"TypeUnset"})]
		int type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (track);
				__args [2] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (group);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/constructor[@name='FixedTrackSelection' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;IIILjava/lang/Object;)V", "")]
		public unsafe FixedTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, int track, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection", Fields = new string [] {"TypeUnset"})]
		int type, int reason, global::Java.Lang.Object data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;IIILjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (track);
				__args [2] = new JniArgumentValue (type);
				__args [3] = new JniArgumentValue (reason);
				__args [4] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (data);
			}
		}

		public override unsafe int SelectedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/method[@name='getSelectedIndex' and count(parameter)=0]"
			[Register ("getSelectedIndex", "()I", "")]
			get {
				const string __id = "getSelectedIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Java.Lang.Object SelectionData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/method[@name='getSelectionData' and count(parameter)=0]"
			[Register ("getSelectionData", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getSelectionData.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int SelectionReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/method[@name='getSelectionReason' and count(parameter)=0]"
			[Register ("getSelectionReason", "()I", "")]
			get {
				const string __id = "getSelectionReason.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='FixedTrackSelection']/method[@name='updateSelectedTrack' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.MediaChunkIterator[]']]"
		[Register ("updateSelectedTrack", "(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V", "")]
		public override unsafe void UpdateSelectedTrack (long playbackPositionUs, long bufferedDurationUs, long availableDurationUs, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> queue, global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[] mediaChunkIterators)
		{
			const string __id = "updateSelectedTrack.(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V";
			IntPtr native_queue = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.ToLocalJniHandle (queue);
			IntPtr native_mediaChunkIterators = JNIEnv.NewArray (mediaChunkIterators);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (playbackPositionUs);
				__args [1] = new JniArgumentValue (bufferedDurationUs);
				__args [2] = new JniArgumentValue (availableDurationUs);
				__args [3] = new JniArgumentValue (native_queue);
				__args [4] = new JniArgumentValue (native_mediaChunkIterators);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_queue);
				if (mediaChunkIterators != null) {
					JNIEnv.CopyArray (native_mediaChunkIterators, mediaChunkIterators);
					JNIEnv.DeleteLocalRef (native_mediaChunkIterators);
				}
				global::System.GC.KeepAlive (queue);
				global::System.GC.KeepAlive (mediaChunkIterators);
			}
		}

	}
}
