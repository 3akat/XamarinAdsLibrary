using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/CompositeMediaSource", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class CompositeMediaSource : global::Com.Example.Androidtvlibrary.Main.Adapter.Media.BaseMediaSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/CompositeMediaSource", typeof (CompositeMediaSource));

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

		protected CompositeMediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/constructor[@name='CompositeMediaSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CompositeMediaSource () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='disableChildSource' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("disableChildSource", "(Ljava/lang/Object;)V", "")]
		protected unsafe void DisableChildSource (global::Java.Lang.Object id)
		{
			const string __id = "disableChildSource.(Ljava/lang/Object;)V";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='enableChildSource' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("enableChildSource", "(Ljava/lang/Object;)V", "")]
		protected unsafe void EnableChildSource (global::Java.Lang.Object id)
		{
			const string __id = "enableChildSource.(Ljava/lang/Object;)V";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_;
#pragma warning disable 0169
		static Delegate GetGetMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Handler ()
		{
			if (cb_getMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_ == null)
				cb_getMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_);
			return cb_getMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_;
		}

		static IntPtr n_GetMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_mediaPeriodId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_id, JniHandleOwnership.DoNotTransfer);
			var mediaPeriodId = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (native_mediaPeriodId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMediaPeriodIdForChildMediaPeriodId (id, mediaPeriodId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='getMediaPeriodIdForChildMediaPeriodId' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId']]"
		[Register ("getMediaPeriodIdForChildMediaPeriodId", "(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;", "GetGetMediaPeriodIdForChildMediaPeriodId_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId GetMediaPeriodIdForChildMediaPeriodId (global::Java.Lang.Object id, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId mediaPeriodId)
		{
			const string __id = "getMediaPeriodIdForChildMediaPeriodId.(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((mediaPeriodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriodId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (mediaPeriodId);
			}
		}

		static Delegate cb_getMediaTimeForChildMediaTime_Ljava_lang_Object_J;
#pragma warning disable 0169
		static Delegate GetGetMediaTimeForChildMediaTime_Ljava_lang_Object_JHandler ()
		{
			if (cb_getMediaTimeForChildMediaTime_Ljava_lang_Object_J == null)
				cb_getMediaTimeForChildMediaTime_Ljava_lang_Object_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_J) n_GetMediaTimeForChildMediaTime_Ljava_lang_Object_J);
			return cb_getMediaTimeForChildMediaTime_Ljava_lang_Object_J;
		}

		static long n_GetMediaTimeForChildMediaTime_Ljava_lang_Object_J (IntPtr jnienv, IntPtr native__this, IntPtr native_id, long mediaTimeMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_id, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetMediaTimeForChildMediaTime (id, mediaTimeMs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='getMediaTimeForChildMediaTime' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='long']]"
		[Register ("getMediaTimeForChildMediaTime", "(Ljava/lang/Object;J)J", "GetGetMediaTimeForChildMediaTime_Ljava_lang_Object_JHandler")]
		protected virtual unsafe long GetMediaTimeForChildMediaTime (global::Java.Lang.Object id, long mediaTimeMs)
		{
			const string __id = "getMediaTimeForChildMediaTime.(Ljava/lang/Object;J)J";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (mediaTimeMs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
			}
		}

		static Delegate cb_getWindowIndexForChildWindowIndex_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetGetWindowIndexForChildWindowIndex_Ljava_lang_Object_IHandler ()
		{
			if (cb_getWindowIndexForChildWindowIndex_Ljava_lang_Object_I == null)
				cb_getWindowIndexForChildWindowIndex_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_GetWindowIndexForChildWindowIndex_Ljava_lang_Object_I);
			return cb_getWindowIndexForChildWindowIndex_Ljava_lang_Object_I;
		}

		static int n_GetWindowIndexForChildWindowIndex_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_id, int windowIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var id = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_id, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetWindowIndexForChildWindowIndex (id, windowIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='getWindowIndexForChildWindowIndex' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='int']]"
		[Register ("getWindowIndexForChildWindowIndex", "(Ljava/lang/Object;I)I", "GetGetWindowIndexForChildWindowIndex_Ljava_lang_Object_IHandler")]
		protected virtual unsafe int GetWindowIndexForChildWindowIndex (global::Java.Lang.Object id, int windowIndex)
		{
			const string __id = "getWindowIndexForChildWindowIndex.(Ljava/lang/Object;I)I";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (windowIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowSourceInfoRefreshError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='maybeThrowSourceInfoRefreshError' and count(parameter)=0]"
		[Register ("maybeThrowSourceInfoRefreshError", "()V", "GetMaybeThrowSourceInfoRefreshErrorHandler")]
		public override unsafe void MaybeThrowSourceInfoRefreshError ()
		{
			const string __id = "maybeThrowSourceInfoRefreshError.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
#pragma warning disable 0169
		static Delegate GetOnChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler ()
		{
			if (cb_onChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ == null)
				cb_onChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_);
			return cb_onChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
		}

		static void n_OnChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnChildSourceInfoRefreshed (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='onChildSourceInfoRefreshed' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("onChildSourceInfoRefreshed", "(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/Timeline;)V", "GetOnChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler")]
		protected abstract void OnChildSourceInfoRefreshed (global::Java.Lang.Object p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='prepareChildSource' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource']]"
		[Register ("prepareChildSource", "(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;)V", "")]
		protected unsafe void PrepareChildSource (global::Java.Lang.Object id, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource mediaSource)
		{
			const string __id = "prepareChildSource.(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;)V";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((mediaSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaSource).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (mediaSource);
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

		static void n_PrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaTransferListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaTransferListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (native_mediaTransferListener, JniHandleOwnership.DoNotTransfer);
			__this.PrepareSourceInternal (mediaTransferListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='prepareSourceInternal' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("prepareSourceInternal", "(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "GetPrepareSourceInternal_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler")]
		protected override unsafe void PrepareSourceInternal (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener mediaTransferListener)
		{
			const string __id = "prepareSourceInternal.(Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaTransferListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaTransferListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaTransferListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='releaseChildSource' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("releaseChildSource", "(Ljava/lang/Object;)V", "")]
		protected unsafe void ReleaseChildSource (global::Java.Lang.Object id)
		{
			const string __id = "releaseChildSource.(Ljava/lang/Object;)V";
			IntPtr native_id = JNIEnv.ToLocalJniHandle (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (id);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSourceInternal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='releaseSourceInternal' and count(parameter)=0]"
		[Register ("releaseSourceInternal", "()V", "GetReleaseSourceInternalHandler")]
		protected override unsafe void ReleaseSourceInternal ()
		{
			const string __id = "releaseSourceInternal.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_shouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_;
#pragma warning disable 0169
		static Delegate GetShouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Handler ()
		{
			if (cb_shouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_ == null)
				cb_shouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ShouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_);
			return cb_shouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_;
		}

		static bool n_ShouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaPeriodId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.CompositeMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaPeriodId = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (native_mediaPeriodId, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldDispatchCreateOrReleaseEvent (mediaPeriodId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='shouldDispatchCreateOrReleaseEvent' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId']]"
		[Register ("shouldDispatchCreateOrReleaseEvent", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)Z", "GetShouldDispatchCreateOrReleaseEvent_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Handler")]
		protected virtual unsafe bool ShouldDispatchCreateOrReleaseEvent (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId mediaPeriodId)
		{
			const string __id = "shouldDispatchCreateOrReleaseEvent.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaPeriodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriodId).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (mediaPeriodId);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/CompositeMediaSource", DoNotGenerateAcw=true)]
	internal partial class CompositeMediaSourceInvoker : CompositeMediaSource {
		public CompositeMediaSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/CompositeMediaSource", typeof (CompositeMediaSourceInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='CompositeMediaSource']/method[@name='onChildSourceInfoRefreshed' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("onChildSourceInfoRefreshed", "(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/Timeline;)V", "GetOnChildSourceInfoRefreshed_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler")]
		protected override unsafe void OnChildSourceInfoRefreshed (global::Java.Lang.Object p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline p2)
		{
			const string __id = "onChildSourceInfoRefreshed.(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/Timeline;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
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
