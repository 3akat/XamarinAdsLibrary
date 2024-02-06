using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/BaseMediaSource", DoNotGenerateAcw=true)]
	public abstract partial class BaseMediaSource : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/BaseMediaSource", typeof (BaseMediaSource));

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

		protected BaseMediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/constructor[@name='BaseMediaSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMediaSource () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		protected unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "")]
			get {
				const string __id = "isEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener']]"
		[Register ("addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V", "")]
		public unsafe void AddEventListener (global::Android.OS.Handler handler, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener eventListener)
		{
			const string __id = "addEventListener.(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='createEventDispatcher' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId']]"
		[Register ("createEventDispatcher", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;", "")]
		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher CreateEventDispatcher (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId mediaPeriodId)
		{
			const string __id = "createEventDispatcher.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaPeriodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriodId).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mediaPeriodId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='createEventDispatcher' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[2][@type='long']]"
		[Register ("createEventDispatcher", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;", "")]
		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher CreateEventDispatcher (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId mediaPeriodId, long mediaTimeOffsetMs)
		{
			const string __id = "createEventDispatcher.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mediaPeriodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriodId).Handle);
				__args [1] = new JniArgumentValue (mediaTimeOffsetMs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mediaPeriodId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='createEventDispatcher' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[3][@type='long']]"
		[Register ("createEventDispatcher", "(ILcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;", "")]
		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher CreateEventDispatcher (int windowIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId mediaPeriodId, long mediaTimeOffsetMs)
		{
			const string __id = "createEventDispatcher.(ILcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue ((mediaPeriodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriodId).Handle);
				__args [2] = new JniArgumentValue (mediaTimeOffsetMs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mediaPeriodId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='disable' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller']]"
		[Register ("disable", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V", "")]
		public unsafe void Disable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller caller)
		{
			const string __id = "disable.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((caller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caller).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (caller);
			}
		}

		static Delegate cb_disableInternal;
#pragma warning disable 0169
		static Delegate GetDisableInternalHandler ()
		{
			if (cb_disableInternal == null)
				cb_disableInternal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableInternal);
			return cb_disableInternal;
		}

		static void n_DisableInternal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableInternal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='disableInternal' and count(parameter)=0]"
		[Register ("disableInternal", "()V", "GetDisableInternalHandler")]
		protected virtual unsafe void DisableInternal ()
		{
			const string __id = "disableInternal.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller']]"
		[Register ("enable", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V", "")]
		public unsafe void Enable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller caller)
		{
			const string __id = "enable.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((caller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caller).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (caller);
			}
		}

		static Delegate cb_enableInternal;
#pragma warning disable 0169
		static Delegate GetEnableInternalHandler ()
		{
			if (cb_enableInternal == null)
				cb_enableInternal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EnableInternal);
			return cb_enableInternal;
		}

		static void n_EnableInternal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableInternal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='enableInternal' and count(parameter)=0]"
		[Register ("enableInternal", "()V", "GetEnableInternalHandler")]
		protected virtual unsafe void EnableInternal ()
		{
			const string __id = "enableInternal.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='prepareSource' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("prepareSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "")]
		public unsafe void PrepareSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller caller, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener mediaTransferListener)
		{
			const string __id = "prepareSource.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((caller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caller).Handle);
				__args [1] = new JniArgumentValue ((mediaTransferListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaTransferListener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (caller);
				global::System.GC.KeepAlive (mediaTransferListener);
			}
		}

		static Delegate cb_prepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
#pragma warning disable 0169
		static Delegate GetPrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler ()
		{
			if (cb_prepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ == null)
				cb_prepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_);
			return cb_prepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
		}

		static void n_PrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareSourceInternal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='prepareSourceInternal' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("prepareSourceInternal", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "GetPrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler")]
		protected abstract void PrepareSourceInternal (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='refreshSourceInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("refreshSourceInfo", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;)V", "")]
		protected unsafe void RefreshSourceInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline)
		{
			const string __id = "refreshSourceInfo.(Lcom/example/androidtvlibrary/main/adapter/Timeline;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='releaseSource' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller']]"
		[Register ("releaseSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V", "")]
		public unsafe void ReleaseSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller caller)
		{
			const string __id = "releaseSource.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((caller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) caller).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (caller);
			}
		}

		static Delegate cb_releaseSourceInternal;
#pragma warning disable 0169
		static Delegate GetReleaseSourceInternalHandler ()
		{
			if (cb_releaseSourceInternal == null)
				cb_releaseSourceInternal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseSourceInternal);
			return cb_releaseSourceInternal;
		}

		static void n_ReleaseSourceInternal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSourceInternal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='releaseSourceInternal' and count(parameter)=0]"
		[Register ("releaseSourceInternal", "()V", "GetReleaseSourceInternalHandler")]
		protected abstract void ReleaseSourceInternal ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener']]"
		[Register ("removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V", "")]
		public unsafe void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener eventListener)
		{
			const string __id = "removeEventListener.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventListener);
			}
		}

		static Delegate cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J;
#pragma warning disable 0169
		static Delegate GetCreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_JHandler ()
		{
			if (cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J == null)
				cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_L) n_CreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J);
			return cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J;
		}

		static IntPtr n_CreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeriod (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='createPeriod' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[3][@type='long']]"
		[Register ("createPeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;", "GetCreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_JHandler")]
		public abstract global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod CreatePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator p1, long p2);

		static Delegate cb_maybeThrowSourceInfoRefreshError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowSourceInfoRefreshErrorHandler ()
		{
			if (cb_maybeThrowSourceInfoRefreshError == null)
				cb_maybeThrowSourceInfoRefreshError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowSourceInfoRefreshError);
			return cb_maybeThrowSourceInfoRefreshError;
		}

		static void n_MaybeThrowSourceInfoRefreshError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowSourceInfoRefreshError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='maybeThrowSourceInfoRefreshError' and count(parameter)=0]"
		[Register ("maybeThrowSourceInfoRefreshError", "()V", "GetMaybeThrowSourceInfoRefreshErrorHandler")]
		public abstract void MaybeThrowSourceInfoRefreshError ();

		static Delegate cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
#pragma warning disable 0169
		static Delegate GetReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler ()
		{
			if (cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ == null)
				cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_);
			return cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
		}

		static void n_ReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleasePeriod (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='releasePeriod' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("releasePeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "GetReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler")]
		public abstract void ReleasePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/BaseMediaSource", DoNotGenerateAcw=true)]
	internal partial class BaseMediaSourceInvoker : BaseMediaSource {
		public BaseMediaSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/BaseMediaSource", typeof (BaseMediaSourceInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='prepareSourceInternal' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("prepareSourceInternal", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "GetPrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler")]
		protected override unsafe void PrepareSourceInternal (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener p0)
		{
			const string __id = "prepareSourceInternal.(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='BaseMediaSource']/method[@name='releaseSourceInternal' and count(parameter)=0]"
		[Register ("releaseSourceInternal", "()V", "GetReleaseSourceInternalHandler")]
		protected override unsafe void ReleaseSourceInternal ()
		{
			const string __id = "releaseSourceInternal.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='createPeriod' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[3][@type='long']]"
		[Register ("createPeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;", "GetCreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_JHandler")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod CreatePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator p1, long p2)
		{
			const string __id = "createPeriod.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='maybeThrowSourceInfoRefreshError' and count(parameter)=0]"
		[Register ("maybeThrowSourceInfoRefreshError", "()V", "GetMaybeThrowSourceInfoRefreshErrorHandler")]
		public override unsafe void MaybeThrowSourceInfoRefreshError ()
		{
			const string __id = "maybeThrowSourceInfoRefreshError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='releasePeriod' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("releasePeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "GetReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler")]
		public override unsafe void ReleasePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod p0)
		{
			const string __id = "releasePeriod.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
