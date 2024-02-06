using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='CameraMotionListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/CameraMotionListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListenerInvoker")]
	public partial interface ICameraMotionListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='CameraMotionListener']/method[@name='onCameraMotion' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float[]']]"
		[Register ("onCameraMotion", "(J[F)V", "GetOnCameraMotion_JarrayFHandler:Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnCameraMotion (long p0, float[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='CameraMotionListener']/method[@name='onCameraMotionReset' and count(parameter)=0]"
		[Register ("onCameraMotionReset", "()V", "GetOnCameraMotionResetHandler:Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnCameraMotionReset ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/CameraMotionListener", DoNotGenerateAcw=true)]
	internal partial class ICameraMotionListenerInvoker : global::Java.Lang.Object, ICameraMotionListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/CameraMotionListener", typeof (ICameraMotionListenerInvoker));

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

		public static ICameraMotionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraMotionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.CameraMotionListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraMotionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCameraMotion_JarrayF;
#pragma warning disable 0169
		static Delegate GetOnCameraMotion_JarrayFHandler ()
		{
			if (cb_onCameraMotion_JarrayF == null)
				cb_onCameraMotion_JarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_V) n_OnCameraMotion_JarrayF);
			return cb_onCameraMotion_JarrayF;
		}

		static void n_OnCameraMotion_JarrayF (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.OnCameraMotion (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onCameraMotion_JarrayF;
		public unsafe void OnCameraMotion (long p0, float[] p1)
		{
			if (id_onCameraMotion_JarrayF == IntPtr.Zero)
				id_onCameraMotion_JarrayF = JNIEnv.GetMethodID (class_ref, "onCameraMotion", "(J[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraMotion_JarrayF, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onCameraMotionReset;
#pragma warning disable 0169
		static Delegate GetOnCameraMotionResetHandler ()
		{
			if (cb_onCameraMotionReset == null)
				cb_onCameraMotionReset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCameraMotionReset);
			return cb_onCameraMotionReset;
		}

		static void n_OnCameraMotionReset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraMotionReset ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraMotionReset;
		public unsafe void OnCameraMotionReset ()
		{
			if (id_onCameraMotionReset == IntPtr.Zero)
				id_onCameraMotionReset = JNIEnv.GetMethodID (class_ref, "onCameraMotionReset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraMotionReset);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.CameraMotionListener.onCameraMotion
	public partial class CameraMotionEventArgs : global::System.EventArgs {
		public CameraMotionEventArgs (long p0, float[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		long p0;

		public long P0 {
			get { return p0; }
		}

		float[] p1;

		public float[] P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/CameraMotionListenerImplementor")]
	internal sealed partial class ICameraMotionListenerImplementor : global::Java.Lang.Object, ICameraMotionListener {

		object sender;

		public ICameraMotionListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/CameraMotionListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<CameraMotionEventArgs> OnCameraMotionHandler;
		#pragma warning restore 0649

		public void OnCameraMotion (long p0, float[] p1)
		{
			var __h = OnCameraMotionHandler;
			if (__h != null)
				__h (sender, new CameraMotionEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler OnCameraMotionResetHandler;
		#pragma warning restore 0649

		public void OnCameraMotionReset ()
		{
			var __h = OnCameraMotionResetHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICameraMotionListenerImplementor value)
		{
			return value.OnCameraMotionHandler == null && value.OnCameraMotionResetHandler == null;
		}

	}
}
