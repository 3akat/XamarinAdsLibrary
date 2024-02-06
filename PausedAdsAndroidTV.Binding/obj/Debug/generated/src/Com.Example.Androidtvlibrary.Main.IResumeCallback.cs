using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main']/interface[@name='ResumeCallback']"
	[Register ("com/example/androidtvlibrary/main/ResumeCallback", "", "Com.Example.Androidtvlibrary.Main.IResumeCallbackInvoker")]
	public partial interface IResumeCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main']/interface[@name='ResumeCallback']/method[@name='onResumeCall' and count(parameter)=0]"
		[Register ("onResumeCall", "()V", "GetOnResumeCallHandler:Com.Example.Androidtvlibrary.Main.IResumeCallbackInvoker, PausedAdsAndroidTV.Binding")]
		void OnResumeCall ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/ResumeCallback", DoNotGenerateAcw=true)]
	internal partial class IResumeCallbackInvoker : global::Java.Lang.Object, IResumeCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/ResumeCallback", typeof (IResumeCallbackInvoker));

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

		public static IResumeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResumeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.ResumeCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResumeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResumeCall;
#pragma warning disable 0169
		static Delegate GetOnResumeCallHandler ()
		{
			if (cb_onResumeCall == null)
				cb_onResumeCall = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnResumeCall);
			return cb_onResumeCall;
		}

		static void n_OnResumeCall (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.IResumeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResumeCall ();
		}
#pragma warning restore 0169

		IntPtr id_onResumeCall;
		public unsafe void OnResumeCall ()
		{
			if (id_onResumeCall == IntPtr.Zero)
				id_onResumeCall = JNIEnv.GetMethodID (class_ref, "onResumeCall", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResumeCall);
		}

	}
}
