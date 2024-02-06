using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest.AdViewProvider']"
	[Register ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider", "", "Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProviderInvoker")]
	public partial interface IAdsLoaderTestAdViewProvider : IJavaObject, IJavaPeerable {
		global::Android.Views.ViewGroup AdViewGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest.AdViewProvider']/method[@name='getAdViewGroup' and count(parameter)=0]"
			[Register ("getAdViewGroup", "()Landroid/view/ViewGroup;", "GetGetAdViewGroupHandler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProviderInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest.AdViewProvider']/method[@name='getAdOverlayViews' and count(parameter)=0]"
		[Register ("getAdOverlayViews", "()[Landroid/view/View;", "GetGetAdOverlayViewsHandler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProviderInvoker, PausedAdsAndroidTV.Binding")]
		global::Android.Views.View[] GetAdOverlayViews ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider", DoNotGenerateAcw=true)]
	internal partial class IAdsLoaderTestAdViewProviderInvoker : global::Java.Lang.Object, IAdsLoaderTestAdViewProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider", typeof (IAdsLoaderTestAdViewProviderInvoker));

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

		public static IAdsLoaderTestAdViewProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdsLoaderTestAdViewProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.AdsLoaderTest.AdViewProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdsLoaderTestAdViewProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdViewGroup;
#pragma warning disable 0169
		static Delegate GetGetAdViewGroupHandler ()
		{
			if (cb_getAdViewGroup == null)
				cb_getAdViewGroup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdViewGroup);
			return cb_getAdViewGroup;
		}

		static IntPtr n_GetAdViewGroup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdViewGroup);
		}
#pragma warning restore 0169

		IntPtr id_getAdViewGroup;
		public unsafe global::Android.Views.ViewGroup AdViewGroup {
			get {
				if (id_getAdViewGroup == IntPtr.Zero)
					id_getAdViewGroup = JNIEnv.GetMethodID (class_ref, "getAdViewGroup", "()Landroid/view/ViewGroup;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdViewGroup), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdOverlayViews;
#pragma warning disable 0169
		static Delegate GetGetAdOverlayViewsHandler ()
		{
			if (cb_getAdOverlayViews == null)
				cb_getAdOverlayViews = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdOverlayViews);
			return cb_getAdOverlayViews;
		}

		static IntPtr n_GetAdOverlayViews (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAdOverlayViews ());
		}
#pragma warning restore 0169

		IntPtr id_getAdOverlayViews;
		public unsafe global::Android.Views.View[] GetAdOverlayViews ()
		{
			if (id_getAdOverlayViews == IntPtr.Zero)
				id_getAdOverlayViews = JNIEnv.GetMethodID (class_ref, "getAdOverlayViews", "()[Landroid/view/View;");
			return (global::Android.Views.View[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdOverlayViews), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Views.View));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest.EventListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestEventListenerInvoker")]
	public partial interface IAdsLoaderTestEventListener : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener", DoNotGenerateAcw=true)]
	internal partial class IAdsLoaderTestEventListenerInvoker : global::Java.Lang.Object, IAdsLoaderTestEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener", typeof (IAdsLoaderTestEventListenerInvoker));

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

		public static IAdsLoaderTestEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdsLoaderTestEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.AdsLoaderTest.EventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdsLoaderTestEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/AdsLoaderTest_EventListenerImplementor")]
	internal sealed partial class IAdsLoaderTestEventListenerImplementor : global::Java.Lang.Object, IAdsLoaderTestEventListener {
		public IAdsLoaderTestEventListenerImplementor () : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/AdsLoaderTest_EventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}

		internal static bool __IsEmpty (IAdsLoaderTestEventListenerImplementor value)
		{
			return true;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']"
	[Register ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest", "", "Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker")]
	public partial interface IAdsLoaderTest : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']/method[@name='handlePrepareError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.io.IOException']]"
		[Register ("handlePrepareError", "(IILjava/io/IOException;)V", "GetHandlePrepareError_IILjava_io_IOException_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker, PausedAdsAndroidTV.Binding")]
		void HandlePrepareError (int p0, int p1, global::Java.IO.IOException p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker, PausedAdsAndroidTV.Binding")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']/method[@name='setPlayer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer']]"
		[Register ("setPlayer", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;)V", "GetSetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker, PausedAdsAndroidTV.Binding")]
		void SetPlayer (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']/method[@name='setSupportedContentTypes' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setSupportedContentTypes", "([I)V", "GetSetSupportedContentTypes_arrayIHandler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker, PausedAdsAndroidTV.Binding")]
		void SetSupportedContentTypes (params int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']/method[@name='start' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.AdsLoaderTest.EventListener'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.AdsLoaderTest.AdViewProvider']]"
		[Register ("start", "(Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener;Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider;)V", "GetStart_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker, PausedAdsAndroidTV.Binding")]
		void Start (global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestEventListener p0, global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdsLoaderTest']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestInvoker, PausedAdsAndroidTV.Binding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest", DoNotGenerateAcw=true)]
	internal partial class IAdsLoaderTestInvoker : global::Java.Lang.Object, IAdsLoaderTest {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/AdsLoaderTest", typeof (IAdsLoaderTestInvoker));

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

		public static IAdsLoaderTest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdsLoaderTest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.AdsLoaderTest'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdsLoaderTestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handlePrepareError_IILjava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetHandlePrepareError_IILjava_io_IOException_Handler ()
		{
			if (cb_handlePrepareError_IILjava_io_IOException_ == null)
				cb_handlePrepareError_IILjava_io_IOException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_HandlePrepareError_IILjava_io_IOException_);
			return cb_handlePrepareError_IILjava_io_IOException_;
		}

		static void n_HandlePrepareError_IILjava_io_IOException_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.HandlePrepareError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_handlePrepareError_IILjava_io_IOException_;
		public unsafe void HandlePrepareError (int p0, int p1, global::Java.IO.IOException p2)
		{
			if (id_handlePrepareError_IILjava_io_IOException_ == IntPtr.Zero)
				id_handlePrepareError_IILjava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "handlePrepareError", "(IILjava/io/IOException;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handlePrepareError_IILjava_io_IOException_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_;
#pragma warning disable 0169
		static Delegate GetSetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Handler ()
		{
			if (cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ == null)
				cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_);
			return cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_;
		}

		static void n_SetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayer (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_;
		public unsafe void SetPlayer (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0)
		{
			if (id_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ == IntPtr.Zero)
				id_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ = JNIEnv.GetMethodID (class_ref, "setPlayer", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_, __args);
		}

		static Delegate cb_setSupportedContentTypes_arrayI;
#pragma warning disable 0169
		static Delegate GetSetSupportedContentTypes_arrayIHandler ()
		{
			if (cb_setSupportedContentTypes_arrayI == null)
				cb_setSupportedContentTypes_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSupportedContentTypes_arrayI);
			return cb_setSupportedContentTypes_arrayI;
		}

		static void n_SetSupportedContentTypes_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetSupportedContentTypes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setSupportedContentTypes_arrayI;
		public unsafe void SetSupportedContentTypes (params int[] p0)
		{
			if (id_setSupportedContentTypes_arrayI == IntPtr.Zero)
				id_setSupportedContentTypes_arrayI = JNIEnv.GetMethodID (class_ref, "setSupportedContentTypes", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSupportedContentTypes_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_;
#pragma warning disable 0169
		static Delegate GetStart_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_Handler ()
		{
			if (cb_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_ == null)
				cb_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_);
			return cb_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_;
		}

		static void n_Start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_;
		public unsafe void Start (global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestEventListener p0, global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider p1)
		{
			if (id_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_ == IntPtr.Zero)
				id_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_ = JNIEnv.GetMethodID (class_ref, "start", "(Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener;Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_EventListener_Lcom_example_androidtvlibrary_main_adapter_AdsLoaderTest_AdViewProvider_, __args);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}
}
