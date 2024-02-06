using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='OrientationListener']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/OrientationListener", DoNotGenerateAcw=true)]
	public sealed partial class OrientationListener : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='OrientationListener.Listener']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/OrientationListener$Listener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.OrientationListener/IListenerInvoker")]
		public partial interface IListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='OrientationListener.Listener']/method[@name='onOrientationChange' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
			[Register ("onOrientationChange", "([FF)V", "GetOnOrientationChange_arrayFFHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.OrientationListener/IListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnOrientationChange (float[] p0, float p1);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/OrientationListener$Listener", DoNotGenerateAcw=true)]
		internal partial class IListenerInvoker : global::Java.Lang.Object, IListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/OrientationListener$Listener", typeof (IListenerInvoker));

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

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.OrientationListener.Listener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onOrientationChange_arrayFF;
#pragma warning disable 0169
			static Delegate GetOnOrientationChange_arrayFFHandler ()
			{
				if (cb_onOrientationChange_arrayFF == null)
					cb_onOrientationChange_arrayFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLF_V) n_OnOrientationChange_arrayFF);
				return cb_onOrientationChange_arrayFF;
			}

			static void n_OnOrientationChange_arrayFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.OrientationListener.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
				__this.OnOrientationChange (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onOrientationChange_arrayFF;
			public unsafe void OnOrientationChange (float[] p0, float p1)
			{
				if (id_onOrientationChange_arrayFF == IntPtr.Zero)
					id_onOrientationChange_arrayFF = JNIEnv.GetMethodID (class_ref, "onOrientationChange", "([FF)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOrientationChange_arrayFF, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.player.OrientationListener.Listener.onOrientationChange
		public partial class EventArgs : global::System.EventArgs {
			public EventArgs (float[] p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float[] p0;

			public float[] P0 {
				get { return p0; }
			}

			float p1;

			public float P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/OrientationListener_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/OrientationListener_ListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
			#pragma warning restore 0649

			public void OnOrientationChange (float[] p0, float p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/OrientationListener", typeof (OrientationListener));

		internal static IntPtr class_ref {
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

		internal OrientationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='OrientationListener']/constructor[@name='OrientationListener' and count(parameter)=2 and parameter[1][@type='android.view.Display'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.OrientationListener.Listener...']]"
		[Register (".ctor", "(Landroid/view/Display;[Lcom/example/androidtvlibrary/main/adapter/player/OrientationListener$Listener;)V", "")]
		public unsafe OrientationListener (global::Android.Views.Display display, params global::Com.Example.Androidtvlibrary.Main.Adapter.Player.OrientationListener.IListener[] listeners) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/Display;[Lcom/example/androidtvlibrary/main/adapter/player/OrientationListener$Listener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_listeners = JNIEnv.NewArray (listeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((display == null) ? IntPtr.Zero : ((global::Java.Lang.Object) display).Handle);
				__args [1] = new JniArgumentValue (native_listeners);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (listeners != null) {
					JNIEnv.CopyArray (native_listeners, listeners);
					JNIEnv.DeleteLocalRef (native_listeners);
				}
				global::System.GC.KeepAlive (display);
				global::System.GC.KeepAlive (listeners);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='OrientationListener']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "")]
		public unsafe void OnAccuracyChanged (global::Android.Hardware.Sensor sensor, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus accuracy)
		{
			const string __id = "onAccuracyChanged.(Landroid/hardware/Sensor;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sensor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sensor).Handle);
				__args [1] = new JniArgumentValue ((int) accuracy);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sensor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='OrientationListener']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "")]
		public unsafe void OnSensorChanged (global::Android.Hardware.SensorEvent e)
		{
			const string __id = "onSensorChanged.(Landroid/hardware/SensorEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

	}
}
