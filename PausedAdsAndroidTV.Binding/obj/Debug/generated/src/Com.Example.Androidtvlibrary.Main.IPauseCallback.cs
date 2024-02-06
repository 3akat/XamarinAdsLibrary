using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main']/interface[@name='PauseCallback']"
	[Register ("com/example/androidtvlibrary/main/PauseCallback", "", "Com.Example.Androidtvlibrary.Main.IPauseCallbackInvoker")]
	public partial interface IPauseCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main']/interface[@name='PauseCallback']/method[@name='onPauseCall' and count(parameter)=0]"
		[Register ("onPauseCall", "()V", "GetOnPauseCallHandler:Com.Example.Androidtvlibrary.Main.IPauseCallbackInvoker, PausedAdsAndroidTV.Binding")]
		void OnPauseCall ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/PauseCallback", DoNotGenerateAcw=true)]
	internal partial class IPauseCallbackInvoker : global::Java.Lang.Object, IPauseCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/PauseCallback", typeof (IPauseCallbackInvoker));

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

		public static IPauseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPauseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.PauseCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPauseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPauseCall;
#pragma warning disable 0169
		static Delegate GetOnPauseCallHandler ()
		{
			if (cb_onPauseCall == null)
				cb_onPauseCall = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPauseCall);
			return cb_onPauseCall;
		}

		static void n_OnPauseCall (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.IPauseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPauseCall ();
		}
#pragma warning restore 0169

		IntPtr id_onPauseCall;
		public unsafe void OnPauseCall ()
		{
			if (id_onPauseCall == IntPtr.Zero)
				id_onPauseCall = JNIEnv.GetMethodID (class_ref, "onPauseCall", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPauseCall);
		}

	}
}
