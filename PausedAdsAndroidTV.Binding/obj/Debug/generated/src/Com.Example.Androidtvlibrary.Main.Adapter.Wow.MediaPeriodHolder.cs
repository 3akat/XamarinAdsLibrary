using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriodHolder", DoNotGenerateAcw=true)]
	public partial class MediaPeriodHolder : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/field[@name='hasEnabledTracks']"
		[Register ("hasEnabledTracks")]
		public bool HasEnabledTracks {
			get {
				const string __id = "hasEnabledTracks.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "hasEnabledTracks.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/field[@name='info']"
		[Register ("info")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo Info {
			get {
				const string __id = "info.Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "info.Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/field[@name='mediaPeriod']"
		[Register ("mediaPeriod")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod MediaPeriod {
			get {
				const string __id = "mediaPeriod.Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mediaPeriod.Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/field[@name='prepared']"
		[Register ("prepared")]
		public bool Prepared {
			get {
				const string __id = "prepared.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "prepared.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/field[@name='sampleStreams']"
		[Register ("sampleStreams")]
		public IList<Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> SampleStreams {
			get {
				const string __id = "sampleStreams.[Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleStreams.[Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/field[@name='uid']"
		[Register ("uid")]
		public global::Java.Lang.Object Uid {
			get {
				const string __id = "uid.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uid.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriodHolder", typeof (MediaPeriodHolder));

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

		protected MediaPeriodHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/constructor[@name='MediaPeriodHolder' and count(parameter)=7 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererCapabilities[]'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelector'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriodInfo'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelectorResult']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;JLcom/example/androidtvlibrary/main/adapter/wow/TrackSelector;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;)V", "")]
		public unsafe MediaPeriodHolder (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities[] rendererCapabilities, long rendererPositionOffsetUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector trackSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator allocator, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource mediaSource, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo info, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult emptyTrackSelectorResult) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;JLcom/example/androidtvlibrary/main/adapter/wow/TrackSelector;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rendererCapabilities = JNIEnv.NewArray (rendererCapabilities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_rendererCapabilities);
				__args [1] = new JniArgumentValue (rendererPositionOffsetUs);
				__args [2] = new JniArgumentValue ((trackSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelector).Handle);
				__args [3] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				__args [4] = new JniArgumentValue ((mediaSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaSource).Handle);
				__args [5] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				__args [6] = new JniArgumentValue ((emptyTrackSelectorResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emptyTrackSelectorResult).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rendererCapabilities != null) {
					JNIEnv.CopyArray (native_rendererCapabilities, rendererCapabilities);
					JNIEnv.DeleteLocalRef (native_rendererCapabilities);
				}
				global::System.GC.KeepAlive (rendererCapabilities);
				global::System.GC.KeepAlive (trackSelector);
				global::System.GC.KeepAlive (allocator);
				global::System.GC.KeepAlive (mediaSource);
				global::System.GC.KeepAlive (info);
				global::System.GC.KeepAlive (emptyTrackSelectorResult);
			}
		}

		static Delegate cb_getBufferedPositionUs;
#pragma warning disable 0169
		static Delegate GetGetBufferedPositionUsHandler ()
		{
			if (cb_getBufferedPositionUs == null)
				cb_getBufferedPositionUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBufferedPositionUs);
			return cb_getBufferedPositionUs;
		}

		static long n_GetBufferedPositionUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPositionUs;
		}
#pragma warning restore 0169

		public virtual unsafe long BufferedPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getBufferedPositionUs' and count(parameter)=0]"
			[Register ("getBufferedPositionUs", "()J", "GetGetBufferedPositionUsHandler")]
			get {
				const string __id = "getBufferedPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFullyBuffered;
#pragma warning disable 0169
		static Delegate GetIsFullyBufferedHandler ()
		{
			if (cb_isFullyBuffered == null)
				cb_isFullyBuffered = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFullyBuffered);
			return cb_isFullyBuffered;
		}

		static bool n_IsFullyBuffered (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFullyBuffered;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFullyBuffered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='isFullyBuffered' and count(parameter)=0]"
			[Register ("isFullyBuffered", "()Z", "GetIsFullyBufferedHandler")]
			get {
				const string __id = "isFullyBuffered.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNext;
#pragma warning disable 0169
		static Delegate GetGetNextHandler ()
		{
			if (cb_getNext == null)
				cb_getNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNext);
			return cb_getNext;
		}

		static IntPtr n_GetNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next);
		}
#pragma warning restore 0169

		static Delegate cb_setNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_;
#pragma warning disable 0169
		static Delegate GetSetNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_Handler ()
		{
			if (cb_setNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_ == null)
				cb_setNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_);
			return cb_setNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_;
		}

		static void n_SetNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextMediaPeriodHolder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nextMediaPeriodHolder = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (native_nextMediaPeriodHolder, JniHandleOwnership.DoNotTransfer);
			__this.Next = nextMediaPeriodHolder;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder Next {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getNext' and count(parameter)=0]"
			[Register ("getNext", "()Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodHolder;", "GetGetNextHandler")]
			get {
				const string __id = "getNext.()Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodHolder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='setNext' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriodHolder']]"
			[Register ("setNext", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodHolder;)V", "GetSetNext_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriodHolder_Handler")]
			set {
				const string __id = "setNext.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodHolder;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getNextLoadPositionUs;
#pragma warning disable 0169
		static Delegate GetGetNextLoadPositionUsHandler ()
		{
			if (cb_getNextLoadPositionUs == null)
				cb_getNextLoadPositionUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNextLoadPositionUs);
			return cb_getNextLoadPositionUs;
		}

		static long n_GetNextLoadPositionUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextLoadPositionUs;
		}
#pragma warning restore 0169

		public virtual unsafe long NextLoadPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getNextLoadPositionUs' and count(parameter)=0]"
			[Register ("getNextLoadPositionUs", "()J", "GetGetNextLoadPositionUsHandler")]
			get {
				const string __id = "getNextLoadPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRendererOffset;
#pragma warning disable 0169
		static Delegate GetGetRendererOffsetHandler ()
		{
			if (cb_getRendererOffset == null)
				cb_getRendererOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRendererOffset);
			return cb_getRendererOffset;
		}

		static long n_GetRendererOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RendererOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setRendererOffset_J;
#pragma warning disable 0169
		static Delegate GetSetRendererOffset_JHandler ()
		{
			if (cb_setRendererOffset_J == null)
				cb_setRendererOffset_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetRendererOffset_J);
			return cb_setRendererOffset_J;
		}

		static void n_SetRendererOffset_J (IntPtr jnienv, IntPtr native__this, long rendererPositionOffsetUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RendererOffset = rendererPositionOffsetUs;
		}
#pragma warning restore 0169

		public virtual unsafe long RendererOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getRendererOffset' and count(parameter)=0]"
			[Register ("getRendererOffset", "()J", "GetGetRendererOffsetHandler")]
			get {
				const string __id = "getRendererOffset.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='setRendererOffset' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRendererOffset", "(J)V", "GetSetRendererOffset_JHandler")]
			set {
				const string __id = "setRendererOffset.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartPositionRendererTime;
#pragma warning disable 0169
		static Delegate GetGetStartPositionRendererTimeHandler ()
		{
			if (cb_getStartPositionRendererTime == null)
				cb_getStartPositionRendererTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetStartPositionRendererTime);
			return cb_getStartPositionRendererTime;
		}

		static long n_GetStartPositionRendererTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartPositionRendererTime;
		}
#pragma warning restore 0169

		public virtual unsafe long StartPositionRendererTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getStartPositionRendererTime' and count(parameter)=0]"
			[Register ("getStartPositionRendererTime", "()J", "GetGetStartPositionRendererTimeHandler")]
			get {
				const string __id = "getStartPositionRendererTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTrackGroups;
#pragma warning disable 0169
		static Delegate GetGetTrackGroupsHandler ()
		{
			if (cb_getTrackGroups == null)
				cb_getTrackGroups = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackGroups);
			return cb_getTrackGroups;
		}

		static IntPtr n_GetTrackGroups (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackGroups);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray TrackGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getTrackGroups' and count(parameter)=0]"
			[Register ("getTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "GetGetTrackGroupsHandler")]
			get {
				const string __id = "getTrackGroups.()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackSelectorResult;
#pragma warning disable 0169
		static Delegate GetGetTrackSelectorResultHandler ()
		{
			if (cb_getTrackSelectorResult == null)
				cb_getTrackSelectorResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackSelectorResult);
			return cb_getTrackSelectorResult;
		}

		static IntPtr n_GetTrackSelectorResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackSelectorResult);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult TrackSelectorResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='getTrackSelectorResult' and count(parameter)=0]"
			[Register ("getTrackSelectorResult", "()Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;", "GetGetTrackSelectorResultHandler")]
			get {
				const string __id = "getTrackSelectorResult.()Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZ;
#pragma warning disable 0169
		static Delegate GetApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZHandler ()
		{
			if (cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZ == null)
				cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJZ_J) n_ApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZ);
			return cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZ;
		}

		static long n_ApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackSelectorResult, long positionUs, bool forceRecreateStreams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var trackSelectorResult = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult> (native_trackSelectorResult, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.ApplyTrackSelection (trackSelectorResult, positionUs, forceRecreateStreams);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='applyTrackSelection' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelectorResult'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("applyTrackSelection", "(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;JZ)J", "GetApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZHandler")]
		public virtual unsafe long ApplyTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult trackSelectorResult, long positionUs, bool forceRecreateStreams)
		{
			const string __id = "applyTrackSelection.(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;JZ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((trackSelectorResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectorResult).Handle);
				__args [1] = new JniArgumentValue (positionUs);
				__args [2] = new JniArgumentValue (forceRecreateStreams);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (trackSelectorResult);
			}
		}

		static Delegate cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZ;
#pragma warning disable 0169
		static Delegate GetApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZHandler ()
		{
			if (cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZ == null)
				cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJZL_J) n_ApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZ);
			return cb_applyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZ;
		}

		static long n_ApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_newTrackSelectorResult, long positionUs, bool forceRecreateStreams, IntPtr native_streamResetFlags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newTrackSelectorResult = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult> (native_newTrackSelectorResult, JniHandleOwnership.DoNotTransfer);
			var streamResetFlags = (bool[]) JNIEnv.GetArray (native_streamResetFlags, JniHandleOwnership.DoNotTransfer, typeof (bool));
			long __ret = __this.ApplyTrackSelection (newTrackSelectorResult, positionUs, forceRecreateStreams, streamResetFlags);
			if (streamResetFlags != null)
				JNIEnv.CopyArray (streamResetFlags, native_streamResetFlags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='applyTrackSelection' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelectorResult'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean[]']]"
		[Register ("applyTrackSelection", "(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;JZ[Z)J", "GetApplyTrackSelection_Lcom_example_androidtvlibrary_main_adapter_wow_TrackSelectorResult_JZarrayZHandler")]
		public virtual unsafe long ApplyTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult newTrackSelectorResult, long positionUs, bool forceRecreateStreams, bool[] streamResetFlags)
		{
			const string __id = "applyTrackSelection.(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;JZ[Z)J";
			IntPtr native_streamResetFlags = JNIEnv.NewArray (streamResetFlags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((newTrackSelectorResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newTrackSelectorResult).Handle);
				__args [1] = new JniArgumentValue (positionUs);
				__args [2] = new JniArgumentValue (forceRecreateStreams);
				__args [3] = new JniArgumentValue (native_streamResetFlags);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				if (streamResetFlags != null) {
					JNIEnv.CopyArray (native_streamResetFlags, streamResetFlags);
					JNIEnv.DeleteLocalRef (native_streamResetFlags);
				}
				global::System.GC.KeepAlive (newTrackSelectorResult);
				global::System.GC.KeepAlive (streamResetFlags);
			}
		}

		static Delegate cb_continueLoading_J;
#pragma warning disable 0169
		static Delegate GetContinueLoading_JHandler ()
		{
			if (cb_continueLoading_J == null)
				cb_continueLoading_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_ContinueLoading_J);
			return cb_continueLoading_J;
		}

		static void n_ContinueLoading_J (IntPtr jnienv, IntPtr native__this, long rendererPositionUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContinueLoading (rendererPositionUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='continueLoading' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("continueLoading", "(J)V", "GetContinueLoading_JHandler")]
		public virtual unsafe void ContinueLoading (long rendererPositionUs)
		{
			const string __id = "continueLoading.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rendererPositionUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_handlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_;
#pragma warning disable 0169
		static Delegate GetHandlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_Handler ()
		{
			if (cb_handlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_ == null)
				cb_handlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_V) n_HandlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_);
			return cb_handlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_;
		}

		static void n_HandlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_ (IntPtr jnienv, IntPtr native__this, float playbackSpeed, IntPtr native_timeline)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeline = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_timeline, JniHandleOwnership.DoNotTransfer);
			__this.HandlePrepared (playbackSpeed, timeline);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='handlePrepared' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("handlePrepared", "(FLcom/example/androidtvlibrary/main/adapter/Timeline;)V", "GetHandlePrepared_FLcom_example_androidtvlibrary_main_adapter_Timeline_Handler")]
		public virtual unsafe void HandlePrepared (float playbackSpeed, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline)
		{
			const string __id = "handlePrepared.(FLcom/example/androidtvlibrary/main/adapter/Timeline;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (playbackSpeed);
				__args [1] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
			}
		}

		static Delegate cb_reevaluateBuffer_J;
#pragma warning disable 0169
		static Delegate GetReevaluateBuffer_JHandler ()
		{
			if (cb_reevaluateBuffer_J == null)
				cb_reevaluateBuffer_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_ReevaluateBuffer_J);
			return cb_reevaluateBuffer_J;
		}

		static void n_ReevaluateBuffer_J (IntPtr jnienv, IntPtr native__this, long rendererPositionUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReevaluateBuffer (rendererPositionUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='reevaluateBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("reevaluateBuffer", "(J)V", "GetReevaluateBuffer_JHandler")]
		public virtual unsafe void ReevaluateBuffer (long rendererPositionUs)
		{
			const string __id = "reevaluateBuffer.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rendererPositionUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_selectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_;
#pragma warning disable 0169
		static Delegate GetSelectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_Handler ()
		{
			if (cb_selectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_ == null)
				cb_selectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_L) n_SelectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_);
			return cb_selectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_;
		}

		static IntPtr n_SelectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_ (IntPtr jnienv, IntPtr native__this, float playbackSpeed, IntPtr native_timeline)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeline = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_timeline, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectTracks (playbackSpeed, timeline));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='selectTracks' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("selectTracks", "(FLcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;", "GetSelectTracks_FLcom_example_androidtvlibrary_main_adapter_Timeline_Handler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult SelectTracks (float playbackSpeed, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline)
		{
			const string __id = "selectTracks.(FLcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (playbackSpeed);
				__args [1] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeline);
			}
		}

		static Delegate cb_toPeriodTime_J;
#pragma warning disable 0169
		static Delegate GetToPeriodTime_JHandler ()
		{
			if (cb_toPeriodTime_J == null)
				cb_toPeriodTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_ToPeriodTime_J);
			return cb_toPeriodTime_J;
		}

		static long n_ToPeriodTime_J (IntPtr jnienv, IntPtr native__this, long rendererTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToPeriodTime (rendererTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='toPeriodTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toPeriodTime", "(J)J", "GetToPeriodTime_JHandler")]
		public virtual unsafe long ToPeriodTime (long rendererTimeUs)
		{
			const string __id = "toPeriodTime.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rendererTimeUs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toRendererTime_J;
#pragma warning disable 0169
		static Delegate GetToRendererTime_JHandler ()
		{
			if (cb_toRendererTime_J == null)
				cb_toRendererTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_ToRendererTime_J);
			return cb_toRendererTime_J;
		}

		static long n_ToRendererTime_J (IntPtr jnienv, IntPtr native__this, long periodTimeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToRendererTime (periodTimeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodHolder']/method[@name='toRendererTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toRendererTime", "(J)J", "GetToRendererTime_JHandler")]
		public virtual unsafe long ToRendererTime (long periodTimeUs)
		{
			const string __id = "toRendererTime.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (periodTimeUs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
