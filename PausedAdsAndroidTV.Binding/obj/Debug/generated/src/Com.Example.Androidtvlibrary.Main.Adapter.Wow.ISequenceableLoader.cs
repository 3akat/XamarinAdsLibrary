using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader.Callback']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/SequenceableLoader$Callback", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.SequenceableLoader"})]
	public partial interface ISequenceableLoaderCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader.Callback']/method[@name='onContinueLoadingRequested' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onContinueLoadingRequested", "(Lcom/example/androidtvlibrary/main/adapter/wow/SequenceableLoader;)V", "GetOnContinueLoadingRequested_Lcom_example_androidtvlibrary_main_adapter_wow_SequenceableLoader_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderCallbackInvoker, PausedAdsAndroidTV.Binding")]
		void OnContinueLoadingRequested (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/SequenceableLoader$Callback", DoNotGenerateAcw=true)]
	internal partial class ISequenceableLoaderCallbackInvoker : global::Java.Lang.Object, ISequenceableLoaderCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/SequenceableLoader$Callback", typeof (ISequenceableLoaderCallbackInvoker));

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

		public static ISequenceableLoaderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISequenceableLoaderCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.SequenceableLoader.Callback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISequenceableLoaderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/SequenceableLoader", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderInvoker")]
	public partial interface ISequenceableLoader : IJavaObject, IJavaPeerable {
		long BufferedPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader']/method[@name='getBufferedPositionUs' and count(parameter)=0]"
			[Register ("getBufferedPositionUs", "()J", "GetGetBufferedPositionUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long NextLoadPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader']/method[@name='getNextLoadPositionUs' and count(parameter)=0]"
			[Register ("getNextLoadPositionUs", "()J", "GetGetNextLoadPositionUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader']/method[@name='continueLoading' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("continueLoading", "(J)Z", "GetContinueLoading_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderInvoker, PausedAdsAndroidTV.Binding")]
		bool ContinueLoading (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SequenceableLoader']/method[@name='reevaluateBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("reevaluateBuffer", "(J)V", "GetReevaluateBuffer_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoaderInvoker, PausedAdsAndroidTV.Binding")]
		void ReevaluateBuffer (long p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/SequenceableLoader", DoNotGenerateAcw=true)]
	internal partial class ISequenceableLoaderInvoker : global::Java.Lang.Object, ISequenceableLoader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/SequenceableLoader", typeof (ISequenceableLoaderInvoker));

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

		public static ISequenceableLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISequenceableLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.SequenceableLoader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISequenceableLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISequenceableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}
}
