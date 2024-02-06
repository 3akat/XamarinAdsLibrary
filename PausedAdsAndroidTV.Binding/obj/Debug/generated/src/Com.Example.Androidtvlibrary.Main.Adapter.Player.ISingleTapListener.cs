using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='SingleTapListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/SingleTapListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerInvoker")]
	public partial interface ISingleTapListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='SingleTapListener']/method[@name='onSingleTapUp' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerInvoker, PausedAdsAndroidTV.Binding")]
		bool OnSingleTapUp (global::Android.Views.MotionEvent p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/SingleTapListener", DoNotGenerateAcw=true)]
	internal partial class ISingleTapListenerInvoker : global::Java.Lang.Object, ISingleTapListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/SingleTapListener", typeof (ISingleTapListenerInvoker));

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

		public static ISingleTapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingleTapListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.SingleTapListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingleTapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onSingleTapUp_Landroid_view_MotionEvent_ == null)
				cb_onSingleTapUp_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_OnSingleTapUp_Landroid_view_MotionEvent_);
			return cb_onSingleTapUp_Landroid_view_MotionEvent_;
		}

		static bool n_OnSingleTapUp_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapUp (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_;
		public unsafe bool OnSingleTapUp (global::Android.Views.MotionEvent p0)
		{
			if (id_onSingleTapUp_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onSingleTapUp_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSingleTapUp_Landroid_view_MotionEvent_, __args);
			return __ret;
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.player.SingleTapListener.onSingleTapUp
	public partial class SingleTapEventArgs : global::System.EventArgs {
		bool handled;

		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		public SingleTapEventArgs (bool handled, global::Android.Views.MotionEvent p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		global::Android.Views.MotionEvent p0;

		public global::Android.Views.MotionEvent P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/SingleTapListenerImplementor")]
	internal sealed partial class ISingleTapListenerImplementor : global::Java.Lang.Object, ISingleTapListener {

		object sender;

		public ISingleTapListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/SingleTapListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<SingleTapEventArgs> Handler;
		#pragma warning restore 0649

		public bool OnSingleTapUp (global::Android.Views.MotionEvent p0)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new SingleTapEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (ISingleTapListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
