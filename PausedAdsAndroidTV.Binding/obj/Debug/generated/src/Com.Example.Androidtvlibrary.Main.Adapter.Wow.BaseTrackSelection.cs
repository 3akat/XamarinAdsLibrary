using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/BaseTrackSelection", DoNotGenerateAcw=true)]
	public abstract partial class BaseTrackSelection : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/field[@name='group']"
		[Register ("group")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup Group {
			get {
				const string __id = "group.Lcom/example/androidtvlibrary/main/adapter/TrackGroup;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "group.Lcom/example/androidtvlibrary/main/adapter/TrackGroup;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/field[@name='tracks']"
		[Register ("tracks")]
		protected IList<int> Tracks {
			get {
				const string __id = "tracks.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tracks.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.TrackSelection

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/field[@name='SELECTION_REASON_UNKNOWN']"
			[Register ("SELECTION_REASON_UNKNOWN")]
			public const int SelectionReasonUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/field[@name='TYPE_CUSTOM_BASE']"
			[Register ("TYPE_CUSTOM_BASE")]
			public const int TypeCustomBase = (int) 10000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/field[@name='TYPE_UNSET']"
			[Register ("TYPE_UNSET")]
			public const int TypeUnset = (int) 0;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/BaseTrackSelection", typeof (BaseTrackSelection));

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

		protected BaseTrackSelection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/constructor[@name='BaseTrackSelection' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int...']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[I)V", "")]
		public unsafe BaseTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, params int[] tracks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tracks = JNIEnv.NewArray (tracks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (native_tracks);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (tracks != null) {
					JNIEnv.CopyArray (native_tracks, tracks);
					JNIEnv.DeleteLocalRef (native_tracks);
				}
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (tracks);
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format SelectedFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectedFormat' and count(parameter)=0]"
			[Register ("getSelectedFormat", "()Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
			get {
				const string __id = "getSelectedFormat.()Lcom/example/androidtvlibrary/main/adapter/Format;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int SelectedIndexInTrackGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectedIndexInTrackGroup' and count(parameter)=0]"
			[Register ("getSelectedIndexInTrackGroup", "()I", "")]
			get {
				const string __id = "getSelectedIndexInTrackGroup.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup TrackGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getTrackGroup' and count(parameter)=0]"
			[Register ("getTrackGroup", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroup;", "")]
			get {
				const string __id = "getTrackGroup.()Lcom/example/androidtvlibrary/main/adapter/TrackGroup;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='blacklist' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("blacklist", "(IJ)Z", "")]
		public unsafe bool Blacklist (int index, long blacklistDurationMs)
		{
			const string __id = "blacklist.(IJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (blacklistDurationMs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public virtual unsafe void Disable ()
		{
			const string __id = "disable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler")]
		public virtual unsafe void Enable ()
		{
			const string __id = "enable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_evaluateQueueSize_JLjava_util_List_;
#pragma warning disable 0169
		static Delegate GetEvaluateQueueSize_JLjava_util_List_Handler ()
		{
			if (cb_evaluateQueueSize_JLjava_util_List_ == null)
				cb_evaluateQueueSize_JLjava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_I) n_EvaluateQueueSize_JLjava_util_List_);
			return cb_evaluateQueueSize_JLjava_util_List_;
		}

		static int n_EvaluateQueueSize_JLjava_util_List_ (IntPtr jnienv, IntPtr native__this, long playbackPositionUs, IntPtr native_queue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var queue = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.FromJniHandle (native_queue, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EvaluateQueueSize (playbackPositionUs, queue);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='evaluateQueueSize' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;']]"
		[Register ("evaluateQueueSize", "(JLjava/util/List;)I", "GetEvaluateQueueSize_JLjava_util_List_Handler")]
		public virtual unsafe int EvaluateQueueSize (long playbackPositionUs, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> queue)
		{
			const string __id = "evaluateQueueSize.(JLjava/util/List;)I";
			IntPtr native_queue = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.ToLocalJniHandle (queue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (playbackPositionUs);
				__args [1] = new JniArgumentValue (native_queue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_queue);
				global::System.GC.KeepAlive (queue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFormat", "(I)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format GetFormat (int index)
		{
			const string __id = "getFormat.(I)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getIndexInTrackGroup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexInTrackGroup", "(I)I", "")]
		public unsafe int GetIndexInTrackGroup (int index)
		{
			const string __id = "getIndexInTrackGroup.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("indexOf", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I", "")]
		public unsafe int IndexOf (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "indexOf.(Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("indexOf", "(I)I", "")]
		public unsafe int IndexOf (int indexInTrackGroup)
		{
			const string __id = "indexOf.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (indexInTrackGroup);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='isBlacklisted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("isBlacklisted", "(IJ)Z", "")]
		protected unsafe bool IsBlacklisted (int index, long nowMs)
		{
			const string __id = "isBlacklisted.(IJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (nowMs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "")]
		public unsafe int Length ()
		{
			const string __id = "length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onPlaybackSpeed_F;
#pragma warning disable 0169
		static Delegate GetOnPlaybackSpeed_FHandler ()
		{
			if (cb_onPlaybackSpeed_F == null)
				cb_onPlaybackSpeed_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_OnPlaybackSpeed_F);
			return cb_onPlaybackSpeed_F;
		}

		static void n_OnPlaybackSpeed_F (IntPtr jnienv, IntPtr native__this, float playbackSpeed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaybackSpeed (playbackSpeed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='onPlaybackSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onPlaybackSpeed", "(F)V", "GetOnPlaybackSpeed_FHandler")]
		public virtual unsafe void OnPlaybackSpeed (float playbackSpeed)
		{
			const string __id = "onPlaybackSpeed.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (playbackSpeed);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
#pragma warning disable 0169
		static Delegate GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler ()
		{
			if (cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ == null)
				cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJJLL_V) n_UpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_);
			return cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
		}

		static void n_UpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, long p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator));
			__this.UpdateSelectedTrack (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='updateSelectedTrack' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.MediaChunkIterator[]']]"
		[Register ("updateSelectedTrack", "(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V", "GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler")]
		public abstract void UpdateSelectedTrack (long p0, long p1, long p2, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> p3, global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[] p4);

		static Delegate cb_getSelectedIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedIndexHandler ()
		{
			if (cb_getSelectedIndex == null)
				cb_getSelectedIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedIndex);
			return cb_getSelectedIndex;
		}

		static int n_GetSelectedIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedIndex;
		}
#pragma warning restore 0169

		public abstract int SelectedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectedIndex' and count(parameter)=0]"
			[Register ("getSelectedIndex", "()I", "GetGetSelectedIndexHandler")]
			get; 
		}

		static Delegate cb_getSelectionData;
#pragma warning disable 0169
		static Delegate GetGetSelectionDataHandler ()
		{
			if (cb_getSelectionData == null)
				cb_getSelectionData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSelectionData);
			return cb_getSelectionData;
		}

		static IntPtr n_GetSelectionData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionData);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Object SelectionData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectionData' and count(parameter)=0]"
			[Register ("getSelectionData", "()Ljava/lang/Object;", "GetGetSelectionDataHandler")]
			get; 
		}

		static Delegate cb_getSelectionReason;
#pragma warning disable 0169
		static Delegate GetGetSelectionReasonHandler ()
		{
			if (cb_getSelectionReason == null)
				cb_getSelectionReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectionReason);
			return cb_getSelectionReason;
		}

		static int n_GetSelectionReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionReason;
		}
#pragma warning restore 0169

		public abstract int SelectionReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectionReason' and count(parameter)=0]"
			[Register ("getSelectionReason", "()I", "GetGetSelectionReasonHandler")]
			get; 
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/BaseTrackSelection", DoNotGenerateAcw=true)]
	internal partial class BaseTrackSelectionInvoker : BaseTrackSelection {
		public BaseTrackSelectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/BaseTrackSelection", typeof (BaseTrackSelectionInvoker));

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

		public override unsafe int SelectedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectedIndex' and count(parameter)=0]"
			[Register ("getSelectedIndex", "()I", "GetGetSelectedIndexHandler")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectionData' and count(parameter)=0]"
			[Register ("getSelectionData", "()Ljava/lang/Object;", "GetGetSelectionDataHandler")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getSelectionReason' and count(parameter)=0]"
			[Register ("getSelectionReason", "()I", "GetGetSelectionReasonHandler")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='BaseTrackSelection']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='updateSelectedTrack' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.MediaChunkIterator[]']]"
		[Register ("updateSelectedTrack", "(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V", "GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler")]
		public override unsafe void UpdateSelectedTrack (long p0, long p1, long p2, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> p3, global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[] p4)
		{
			const string __id = "updateSelectedTrack.(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V";
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
			}
		}

	}
}
