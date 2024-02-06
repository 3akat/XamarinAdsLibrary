using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod.Callback']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallbackInvoker")]
	public partial interface IMediaPeriodCallback : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderCallback {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod.Callback']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("onPrepared", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "GetOnPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallbackInvoker, PausedAdsAndroidTV.Binding")]
		void OnPrepared (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback", DoNotGenerateAcw=true)]
	internal partial class IMediaPeriodCallbackInvoker : global::Java.Lang.Object, IMediaPeriodCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback", typeof (IMediaPeriodCallbackInvoker));

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

		public static IMediaPeriodCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPeriodCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.MediaPeriod.Callback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPeriodCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
#pragma warning disable 0169
		static Delegate GetOnPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler ()
		{
			if (cb_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ == null)
				cb_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_);
			return cb_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
		}

		static void n_OnPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
		public unsafe void OnPrepared (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod p0)
		{
			if (id_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ == IntPtr.Zero)
				id_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ = JNIEnv.GetMethodID (class_ref, "onPrepared", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepared_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_, __args);
		}

		static Delegate cb_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_;
#pragma warning disable 0169
		static Delegate GetOnContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_Handler ()
		{
			if (cb_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_ == null)
				cb_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_);
			return cb_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_;
		}

		static void n_OnContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnContinueLoadingRequested (p0);
		}
#pragma warning restore 0169

		IntPtr id_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_;
		public unsafe void OnContinueLoadingRequested (global::Java.Lang.Object p0)
		{
			if (id_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_ == IntPtr.Zero)
				id_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_ = JNIEnv.GetMethodID (class_ref, "onContinueLoadingRequested", "(Lcom/example/androidtvlibrary/main/adapter/wow/SequenceableLoader;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriod", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker")]
	public partial interface IMediaPeriod : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoader {
		long BufferedPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='getBufferedPositionUs' and count(parameter)=0]"
			[Register ("getBufferedPositionUs", "()J", "GetGetBufferedPositionUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long NextLoadPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='getNextLoadPositionUs' and count(parameter)=0]"
			[Register ("getNextLoadPositionUs", "()J", "GetGetNextLoadPositionUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray TrackGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='getTrackGroups' and count(parameter)=0]"
			[Register ("getTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "GetGetTrackGroupsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='continueLoading' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("continueLoading", "(J)Z", "GetContinueLoading_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		bool ContinueLoading (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='discardBuffer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("discardBuffer", "(JZ)V", "GetDiscardBuffer_JZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		void DiscardBuffer (long p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='getAdjustedSeekPositionUs' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.SeekParameters']]"
		[Register ("getAdjustedSeekPositionUs", "(JLcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;)J", "GetGetAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		long GetAdjustedSeekPositionUs (long p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='maybeThrowPrepareError' and count(parameter)=0]"
		[Register ("maybeThrowPrepareError", "()V", "GetMaybeThrowPrepareErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		void MaybeThrowPrepareError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='prepare' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod.Callback'] and parameter[2][@type='long']]"
		[Register ("prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback;J)V", "GetPrepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='readDiscontinuity' and count(parameter)=0]"
		[Register ("readDiscontinuity", "()J", "GetReadDiscontinuityHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		long ReadDiscontinuity ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='reevaluateBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("reevaluateBuffer", "(J)V", "GetReevaluateBuffer_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		void ReevaluateBuffer (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='seekToUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekToUs", "(J)J", "GetSeekToUs_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		long SeekToUs (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaPeriod']/method[@name='selectTracks' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackSelection[]'] and parameter[2][@type='boolean[]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.SampleStream[]'] and parameter[4][@type='boolean[]'] and parameter[5][@type='long']]"
		[Register ("selectTracks", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection;[Z[Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;[ZJ)J", "GetSelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodInvoker, PausedAdsAndroidTV.Binding")]
		long SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] p0, bool[] p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream[] p2, bool[] p3, long p4);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriod", DoNotGenerateAcw=true)]
	internal partial class IMediaPeriodInvoker : global::Java.Lang.Object, IMediaPeriod {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriod", typeof (IMediaPeriodInvoker));

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

		public static IMediaPeriod GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPeriod> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.MediaPeriod'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPeriodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPositionUs;
		}
#pragma warning restore 0169

		IntPtr id_getBufferedPositionUs;
		public unsafe long BufferedPositionUs {
			get {
				if (id_getBufferedPositionUs == IntPtr.Zero)
					id_getBufferedPositionUs = JNIEnv.GetMethodID (class_ref, "getBufferedPositionUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPositionUs);
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		IntPtr id_isLoading;
		public unsafe bool IsLoading {
			get {
				if (id_isLoading == IntPtr.Zero)
					id_isLoading = JNIEnv.GetMethodID (class_ref, "isLoading", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoading);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextLoadPositionUs;
		}
#pragma warning restore 0169

		IntPtr id_getNextLoadPositionUs;
		public unsafe long NextLoadPositionUs {
			get {
				if (id_getNextLoadPositionUs == IntPtr.Zero)
					id_getNextLoadPositionUs = JNIEnv.GetMethodID (class_ref, "getNextLoadPositionUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNextLoadPositionUs);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackGroups);
		}
#pragma warning restore 0169

		IntPtr id_getTrackGroups;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray TrackGroups {
			get {
				if (id_getTrackGroups == IntPtr.Zero)
					id_getTrackGroups = JNIEnv.GetMethodID (class_ref, "getTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackGroups), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_continueLoading_J;
#pragma warning disable 0169
		static Delegate GetContinueLoading_JHandler ()
		{
			if (cb_continueLoading_J == null)
				cb_continueLoading_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_Z) n_ContinueLoading_J);
			return cb_continueLoading_J;
		}

		static bool n_ContinueLoading_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContinueLoading (p0);
		}
#pragma warning restore 0169

		IntPtr id_continueLoading_J;
		public unsafe bool ContinueLoading (long p0)
		{
			if (id_continueLoading_J == IntPtr.Zero)
				id_continueLoading_J = JNIEnv.GetMethodID (class_ref, "continueLoading", "(J)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_continueLoading_J, __args);
		}

		static Delegate cb_discardBuffer_JZ;
#pragma warning disable 0169
		static Delegate GetDiscardBuffer_JZHandler ()
		{
			if (cb_discardBuffer_JZ == null)
				cb_discardBuffer_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJZ_V) n_DiscardBuffer_JZ);
			return cb_discardBuffer_JZ;
		}

		static void n_DiscardBuffer_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiscardBuffer (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_discardBuffer_JZ;
		public unsafe void DiscardBuffer (long p0, bool p1)
		{
			if (id_discardBuffer_JZ == IntPtr.Zero)
				id_discardBuffer_JZ = JNIEnv.GetMethodID (class_ref, "discardBuffer", "(JZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_discardBuffer_JZ, __args);
		}

		static Delegate cb_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_;
#pragma warning disable 0169
		static Delegate GetGetAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_Handler ()
		{
			if (cb_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ == null)
				cb_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_J) n_GetAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_);
			return cb_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_;
		}

		static long n_GetAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetAdjustedSeekPositionUs (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_;
		public unsafe long GetAdjustedSeekPositionUs (long p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters p1)
		{
			if (id_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ == IntPtr.Zero)
				id_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_ = JNIEnv.GetMethodID (class_ref, "getAdjustedSeekPositionUs", "(JLcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustedSeekPositionUs_JLcom_example_androidtvlibrary_main_adapter_wow_SeekParameters_, __args);
			return __ret;
		}

		static Delegate cb_maybeThrowPrepareError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowPrepareErrorHandler ()
		{
			if (cb_maybeThrowPrepareError == null)
				cb_maybeThrowPrepareError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowPrepareError);
			return cb_maybeThrowPrepareError;
		}

		static void n_MaybeThrowPrepareError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowPrepareError ();
		}
#pragma warning restore 0169

		IntPtr id_maybeThrowPrepareError;
		public unsafe void MaybeThrowPrepareError ()
		{
			if (id_maybeThrowPrepareError == IntPtr.Zero)
				id_maybeThrowPrepareError = JNIEnv.GetMethodID (class_ref, "maybeThrowPrepareError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_maybeThrowPrepareError);
		}

		static Delegate cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J;
#pragma warning disable 0169
		static Delegate GetPrepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_JHandler ()
		{
			if (cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J == null)
				cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_Prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J);
			return cb_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J;
		}

		static void n_Prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J;
		public unsafe void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback p0, long p1)
		{
			if (id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J == IntPtr.Zero)
				id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Callback_J, __args);
		}

		static Delegate cb_readDiscontinuity;
#pragma warning disable 0169
		static Delegate GetReadDiscontinuityHandler ()
		{
			if (cb_readDiscontinuity == null)
				cb_readDiscontinuity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_ReadDiscontinuity);
			return cb_readDiscontinuity;
		}

		static long n_ReadDiscontinuity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadDiscontinuity ();
		}
#pragma warning restore 0169

		IntPtr id_readDiscontinuity;
		public unsafe long ReadDiscontinuity ()
		{
			if (id_readDiscontinuity == IntPtr.Zero)
				id_readDiscontinuity = JNIEnv.GetMethodID (class_ref, "readDiscontinuity", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readDiscontinuity);
		}

		static Delegate cb_reevaluateBuffer_J;
#pragma warning disable 0169
		static Delegate GetReevaluateBuffer_JHandler ()
		{
			if (cb_reevaluateBuffer_J == null)
				cb_reevaluateBuffer_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_ReevaluateBuffer_J);
			return cb_reevaluateBuffer_J;
		}

		static void n_ReevaluateBuffer_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReevaluateBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_reevaluateBuffer_J;
		public unsafe void ReevaluateBuffer (long p0)
		{
			if (id_reevaluateBuffer_J == IntPtr.Zero)
				id_reevaluateBuffer_J = JNIEnv.GetMethodID (class_ref, "reevaluateBuffer", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reevaluateBuffer_J, __args);
		}

		static Delegate cb_seekToUs_J;
#pragma warning disable 0169
		static Delegate GetSeekToUs_JHandler ()
		{
			if (cb_seekToUs_J == null)
				cb_seekToUs_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_SeekToUs_J);
			return cb_seekToUs_J;
		}

		static long n_SeekToUs_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeekToUs (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekToUs_J;
		public unsafe long SeekToUs (long p0)
		{
			if (id_seekToUs_J == IntPtr.Zero)
				id_seekToUs_J = JNIEnv.GetMethodID (class_ref, "seekToUs", "(J)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_seekToUs_J, __args);
		}

		static Delegate cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ;
#pragma warning disable 0169
		static Delegate GetSelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJHandler ()
		{
			if (cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ == null)
				cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLJ_J) n_SelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ);
			return cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ;
		}

		static long n_SelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, long p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection));
			var p1 = (bool[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (bool));
			var p2 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream));
			var p3 = (bool[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (bool));
			long __ret = __this.SelectTracks (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ;
		public unsafe long SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] p0, bool[] p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream[] p2, bool[] p3, long p4)
		{
			if (id_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ == IntPtr.Zero)
				id_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ = JNIEnv.GetMethodID (class_ref, "selectTracks", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection;[Z[Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;[ZJ)J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_arrayZarrayLcom_example_androidtvlibrary_main_adapter_wow_SampleStream_arrayZJ, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

	}
}
