using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Simple {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioBecomingNoisyManager']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager", DoNotGenerateAcw=true)]
	public sealed partial class AudioBecomingNoisyManager : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='AudioBecomingNoisyManager.EventListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager$EventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioBecomingNoisyManager/IEventListenerInvoker")]
		public partial interface IEventListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='AudioBecomingNoisyManager.EventListener']/method[@name='onAudioBecomingNoisy' and count(parameter)=0]"
			[Register ("onAudioBecomingNoisy", "()V", "GetOnAudioBecomingNoisyHandler:Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioBecomingNoisyManager/IEventListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnAudioBecomingNoisy ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager$EventListener", DoNotGenerateAcw=true)]
		internal partial class IEventListenerInvoker : global::Java.Lang.Object, IEventListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager$EventListener", typeof (IEventListenerInvoker));

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

			public static IEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.simple.AudioBecomingNoisyManager.EventListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAudioBecomingNoisy;
#pragma warning disable 0169
			static Delegate GetOnAudioBecomingNoisyHandler ()
			{
				if (cb_onAudioBecomingNoisy == null)
					cb_onAudioBecomingNoisy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAudioBecomingNoisy);
				return cb_onAudioBecomingNoisy;
			}

			static void n_OnAudioBecomingNoisy (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioBecomingNoisyManager.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAudioBecomingNoisy ();
			}
#pragma warning restore 0169

			IntPtr id_onAudioBecomingNoisy;
			public unsafe void OnAudioBecomingNoisy ()
			{
				if (id_onAudioBecomingNoisy == IntPtr.Zero)
					id_onAudioBecomingNoisy = JNIEnv.GetMethodID (class_ref, "onAudioBecomingNoisy", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioBecomingNoisy);
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager_EventListenerImplementor")]
		internal sealed partial class IEventListenerImplementor : global::Java.Lang.Object, IEventListener {

			object sender;

			public IEventListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager_EventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler Handler;
			#pragma warning restore 0649

			public void OnAudioBecomingNoisy ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IEventListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager", typeof (AudioBecomingNoisyManager));

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

		internal AudioBecomingNoisyManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioBecomingNoisyManager']/constructor[@name='AudioBecomingNoisyManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.simple.AudioBecomingNoisyManager.EventListener']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager$EventListener;)V", "")]
		public unsafe AudioBecomingNoisyManager (global::Android.Content.Context context, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioBecomingNoisyManager.IEventListener listener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/simple/AudioBecomingNoisyManager$EventListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioBecomingNoisyManager']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "")]
		public unsafe void SetEnabled (bool enabled)
		{
			const string __id = "setEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
