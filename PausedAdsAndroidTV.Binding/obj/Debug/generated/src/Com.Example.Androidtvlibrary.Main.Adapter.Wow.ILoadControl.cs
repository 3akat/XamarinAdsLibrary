using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/LoadControl", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker")]
	public partial interface ILoadControl : IJavaObject, IJavaPeerable {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator Allocator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='getAllocator' and count(parameter)=0]"
			[Register ("getAllocator", "()Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;", "GetGetAllocatorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long BackBufferDurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='getBackBufferDurationUs' and count(parameter)=0]"
			[Register ("getBackBufferDurationUs", "()J", "GetGetBackBufferDurationUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='onPrepared' and count(parameter)=0]"
		[Register ("onPrepared", "()V", "GetOnPreparedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		void OnPrepared ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='onReleased' and count(parameter)=0]"
		[Register ("onReleased", "()V", "GetOnReleasedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		void OnReleased ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='onStopped' and count(parameter)=0]"
		[Register ("onStopped", "()V", "GetOnStoppedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		void OnStopped ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='onTracksSelected' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.TrackSelectionArray']]"
		[Register ("onTracksSelected", "([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;)V", "GetOnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		void OnTracksSelected (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray p1, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='retainBackBufferFromKeyframe' and count(parameter)=0]"
		[Register ("retainBackBufferFromKeyframe", "()Z", "GetRetainBackBufferFromKeyframeHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		bool RetainBackBufferFromKeyframe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='shouldContinueLoading' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
		[Register ("shouldContinueLoading", "(JF)Z", "GetShouldContinueLoading_JFHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		bool ShouldContinueLoading (long p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='LoadControl']/method[@name='shouldStartPlayback' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("shouldStartPlayback", "(JFZ)Z", "GetShouldStartPlayback_JFZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControlInvoker, PausedAdsAndroidTV.Binding")]
		bool ShouldStartPlayback (long p0, float p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/LoadControl", DoNotGenerateAcw=true)]
	internal partial class ILoadControlInvoker : global::Java.Lang.Object, ILoadControl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/LoadControl", typeof (ILoadControlInvoker));

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

		public static ILoadControl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadControl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.LoadControl'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadControlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAllocator;
#pragma warning disable 0169
		static Delegate GetGetAllocatorHandler ()
		{
			if (cb_getAllocator == null)
				cb_getAllocator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllocator);
			return cb_getAllocator;
		}

		static IntPtr n_GetAllocator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Allocator);
		}
#pragma warning restore 0169

		IntPtr id_getAllocator;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator Allocator {
			get {
				if (id_getAllocator == IntPtr.Zero)
					id_getAllocator = JNIEnv.GetMethodID (class_ref, "getAllocator", "()Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllocator), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBackBufferDurationUs;
#pragma warning disable 0169
		static Delegate GetGetBackBufferDurationUsHandler ()
		{
			if (cb_getBackBufferDurationUs == null)
				cb_getBackBufferDurationUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBackBufferDurationUs);
			return cb_getBackBufferDurationUs;
		}

		static long n_GetBackBufferDurationUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackBufferDurationUs;
		}
#pragma warning restore 0169

		IntPtr id_getBackBufferDurationUs;
		public unsafe long BackBufferDurationUs {
			get {
				if (id_getBackBufferDurationUs == IntPtr.Zero)
					id_getBackBufferDurationUs = JNIEnv.GetMethodID (class_ref, "getBackBufferDurationUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBackBufferDurationUs);
			}
		}

		static Delegate cb_onPrepared;
#pragma warning disable 0169
		static Delegate GetOnPreparedHandler ()
		{
			if (cb_onPrepared == null)
				cb_onPrepared = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPrepared);
			return cb_onPrepared;
		}

		static void n_OnPrepared (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared ();
		}
#pragma warning restore 0169

		IntPtr id_onPrepared;
		public unsafe void OnPrepared ()
		{
			if (id_onPrepared == IntPtr.Zero)
				id_onPrepared = JNIEnv.GetMethodID (class_ref, "onPrepared", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepared);
		}

		static Delegate cb_onReleased;
#pragma warning disable 0169
		static Delegate GetOnReleasedHandler ()
		{
			if (cb_onReleased == null)
				cb_onReleased = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReleased);
			return cb_onReleased;
		}

		static void n_OnReleased (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReleased ();
		}
#pragma warning restore 0169

		IntPtr id_onReleased;
		public unsafe void OnReleased ()
		{
			if (id_onReleased == IntPtr.Zero)
				id_onReleased = JNIEnv.GetMethodID (class_ref, "onReleased", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReleased);
		}

		static Delegate cb_onStopped;
#pragma warning disable 0169
		static Delegate GetOnStoppedHandler ()
		{
			if (cb_onStopped == null)
				cb_onStopped = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStopped);
			return cb_onStopped;
		}

		static void n_OnStopped (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onStopped;
		public unsafe void OnStopped ()
		{
			if (id_onStopped == IntPtr.Zero)
				id_onStopped = JNIEnv.GetMethodID (class_ref, "onStopped", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopped);
		}

		static Delegate cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
#pragma warning disable 0169
		static Delegate GetOnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_Handler ()
		{
			if (cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ == null)
				cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_);
			return cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
		}

		static void n_OnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer));
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnTracksSelected (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
		public unsafe void OnTracksSelected (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray p1, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray p2)
		{
			if (id_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ == IntPtr.Zero)
				id_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ = JNIEnv.GetMethodID (class_ref, "onTracksSelected", "([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_retainBackBufferFromKeyframe;
#pragma warning disable 0169
		static Delegate GetRetainBackBufferFromKeyframeHandler ()
		{
			if (cb_retainBackBufferFromKeyframe == null)
				cb_retainBackBufferFromKeyframe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RetainBackBufferFromKeyframe);
			return cb_retainBackBufferFromKeyframe;
		}

		static bool n_RetainBackBufferFromKeyframe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetainBackBufferFromKeyframe ();
		}
#pragma warning restore 0169

		IntPtr id_retainBackBufferFromKeyframe;
		public unsafe bool RetainBackBufferFromKeyframe ()
		{
			if (id_retainBackBufferFromKeyframe == IntPtr.Zero)
				id_retainBackBufferFromKeyframe = JNIEnv.GetMethodID (class_ref, "retainBackBufferFromKeyframe", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_retainBackBufferFromKeyframe);
		}

		static Delegate cb_shouldContinueLoading_JF;
#pragma warning disable 0169
		static Delegate GetShouldContinueLoading_JFHandler ()
		{
			if (cb_shouldContinueLoading_JF == null)
				cb_shouldContinueLoading_JF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJF_Z) n_ShouldContinueLoading_JF);
			return cb_shouldContinueLoading_JF;
		}

		static bool n_ShouldContinueLoading_JF (IntPtr jnienv, IntPtr native__this, long p0, float p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldContinueLoading (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_shouldContinueLoading_JF;
		public unsafe bool ShouldContinueLoading (long p0, float p1)
		{
			if (id_shouldContinueLoading_JF == IntPtr.Zero)
				id_shouldContinueLoading_JF = JNIEnv.GetMethodID (class_ref, "shouldContinueLoading", "(JF)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldContinueLoading_JF, __args);
		}

		static Delegate cb_shouldStartPlayback_JFZ;
#pragma warning disable 0169
		static Delegate GetShouldStartPlayback_JFZHandler ()
		{
			if (cb_shouldStartPlayback_JFZ == null)
				cb_shouldStartPlayback_JFZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJFZ_Z) n_ShouldStartPlayback_JFZ);
			return cb_shouldStartPlayback_JFZ;
		}

		static bool n_ShouldStartPlayback_JFZ (IntPtr jnienv, IntPtr native__this, long p0, float p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldStartPlayback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_shouldStartPlayback_JFZ;
		public unsafe bool ShouldStartPlayback (long p0, float p1, bool p2)
		{
			if (id_shouldStartPlayback_JFZ == IntPtr.Zero)
				id_shouldStartPlayback_JFZ = JNIEnv.GetMethodID (class_ref, "shouldStartPlayback", "(JFZ)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldStartPlayback_JFZ, __args);
		}

	}
}
