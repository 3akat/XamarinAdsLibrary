using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter.EventListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListenerInvoker")]
	public partial interface IBandwidthMeterEventListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter.EventListener']/method[@name='onBandwidthSample' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onBandwidthSample", "(IJJ)V", "GetOnBandwidthSample_IJJHandler:Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnBandwidthSample (int p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener", DoNotGenerateAcw=true)]
	internal partial class IBandwidthMeterEventListenerInvoker : global::Java.Lang.Object, IBandwidthMeterEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener", typeof (IBandwidthMeterEventListenerInvoker));

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

		public static IBandwidthMeterEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBandwidthMeterEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.BandwidthMeter.EventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBandwidthMeterEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBandwidthSample_IJJ;
#pragma warning disable 0169
		static Delegate GetOnBandwidthSample_IJJHandler ()
		{
			if (cb_onBandwidthSample_IJJ == null)
				cb_onBandwidthSample_IJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJJ_V) n_OnBandwidthSample_IJJ);
			return cb_onBandwidthSample_IJJ;
		}

		static void n_OnBandwidthSample_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBandwidthSample (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onBandwidthSample_IJJ;
		public unsafe void OnBandwidthSample (int p0, long p1, long p2)
		{
			if (id_onBandwidthSample_IJJ == IntPtr.Zero)
				id_onBandwidthSample_IJJ = JNIEnv.GetMethodID (class_ref, "onBandwidthSample", "(IJJ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBandwidthSample_IJJ, __args);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.BandwidthMeter.EventListener.onBandwidthSample
	public partial class BandwidthMeterEventEventArgs : global::System.EventArgs {
		public BandwidthMeterEventEventArgs (int p0, long p1, long p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		long p1;

		public long P1 {
			get { return p1; }
		}

		long p2;

		public long P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/BandwidthMeter_EventListenerImplementor")]
	internal sealed partial class IBandwidthMeterEventListenerImplementor : global::Java.Lang.Object, IBandwidthMeterEventListener {

		object sender;

		public IBandwidthMeterEventListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/BandwidthMeter_EventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<BandwidthMeterEventEventArgs> Handler;
		#pragma warning restore 0649

		public void OnBandwidthSample (int p0, long p1, long p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BandwidthMeterEventEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBandwidthMeterEventListenerImplementor value)
		{
			return value.Handler == null;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter']"
	[Register ("com/example/androidtvlibrary/main/adapter/BandwidthMeter", "", "Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterInvoker")]
	public partial interface IBandwidthMeter : IJavaObject, IJavaPeerable {
		long BitrateEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter']/method[@name='getBitrateEstimate' and count(parameter)=0]"
			[Register ("getBitrateEstimate", "()J", "GetGetBitrateEstimateHandler:Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener TransferListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter']/method[@name='getTransferListener' and count(parameter)=0]"
			[Register ("getTransferListener", "()Lcom/example/androidtvlibrary/main/adapter/TransferListener;", "GetGetTransferListenerHandler:Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter.EventListener']]"
		[Register ("addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V", "GetAddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterInvoker, PausedAdsAndroidTV.Binding")]
		void AddEventListener (global::Android.OS.Handler p0, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='BandwidthMeter']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter.EventListener']]"
		[Register ("removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V", "GetRemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/BandwidthMeter", DoNotGenerateAcw=true)]
	internal partial class IBandwidthMeterInvoker : global::Java.Lang.Object, IBandwidthMeter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/BandwidthMeter", typeof (IBandwidthMeterInvoker));

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

		public static IBandwidthMeter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBandwidthMeter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.BandwidthMeter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBandwidthMeterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBitrateEstimate;
#pragma warning disable 0169
		static Delegate GetGetBitrateEstimateHandler ()
		{
			if (cb_getBitrateEstimate == null)
				cb_getBitrateEstimate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBitrateEstimate);
			return cb_getBitrateEstimate;
		}

		static long n_GetBitrateEstimate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitrateEstimate;
		}
#pragma warning restore 0169

		IntPtr id_getBitrateEstimate;
		public unsafe long BitrateEstimate {
			get {
				if (id_getBitrateEstimate == IntPtr.Zero)
					id_getBitrateEstimate = JNIEnv.GetMethodID (class_ref, "getBitrateEstimate", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBitrateEstimate);
			}
		}

		static Delegate cb_getTransferListener;
#pragma warning disable 0169
		static Delegate GetGetTransferListenerHandler ()
		{
			if (cb_getTransferListener == null)
				cb_getTransferListener = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransferListener);
			return cb_getTransferListener;
		}

		static IntPtr n_GetTransferListener (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransferListener);
		}
#pragma warning restore 0169

		IntPtr id_getTransferListener;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener TransferListener {
			get {
				if (id_getTransferListener == IntPtr.Zero)
					id_getTransferListener = JNIEnv.GetMethodID (class_ref, "getTransferListener", "()Lcom/example/androidtvlibrary/main/adapter/TransferListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransferListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_;
#pragma warning disable 0169
		static Delegate GetAddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_Handler ()
		{
			if (cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ == null)
				cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_);
			return cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_;
		}

		static void n_AddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddEventListener (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_;
		public unsafe void AddEventListener (global::Android.OS.Handler p0, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener p1)
		{
			if (id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ == IntPtr.Zero)
				id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_, __args);
		}

		static Delegate cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_Handler ()
		{
			if (cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ == null)
				cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_);
			return cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_;
		}

		static void n_RemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEventListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_;
		public unsafe void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener p0)
		{
			if (id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ == IntPtr.Zero)
				id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_ = JNIEnv.GetMethodID (class_ref, "removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_EventListener_, __args);
		}

	}
}
