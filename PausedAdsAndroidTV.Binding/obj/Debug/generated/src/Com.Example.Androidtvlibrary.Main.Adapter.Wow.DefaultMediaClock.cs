using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock", DoNotGenerateAcw=true)]
	public sealed partial class DefaultMediaClock : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DefaultMediaClock.PlaybackParameterListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock$PlaybackParameterListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultMediaClock/IPlaybackParameterListenerInvoker")]
		public partial interface IPlaybackParameterListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DefaultMediaClock.PlaybackParameterListener']/method[@name='onPlaybackParametersChanged' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("onPlaybackParametersChanged", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V", "GetOnPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultMediaClock/IPlaybackParameterListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnPlaybackParametersChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock$PlaybackParameterListener", DoNotGenerateAcw=true)]
		internal partial class IPlaybackParameterListenerInvoker : global::Java.Lang.Object, IPlaybackParameterListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock$PlaybackParameterListener", typeof (IPlaybackParameterListenerInvoker));

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

			public static IPlaybackParameterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPlaybackParameterListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.DefaultMediaClock.PlaybackParameterListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPlaybackParameterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
#pragma warning disable 0169
			static Delegate GetOnPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler ()
			{
				if (cb_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == null)
					cb_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_);
				return cb_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
			}

			static void n_OnPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultMediaClock.IPlaybackParameterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPlaybackParametersChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
			public unsafe void OnPlaybackParametersChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0)
			{
				if (id_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == IntPtr.Zero)
					id_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNIEnv.GetMethodID (class_ref, "onPlaybackParametersChanged", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaybackParametersChanged_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.wow.DefaultMediaClock.PlaybackParameterListener.onPlaybackParametersChanged
		public partial class PlaybackParameterEventArgs : global::System.EventArgs {
			public PlaybackParameterEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0)
			{
				this.p0 = p0;
			}

			global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0;

			public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock_PlaybackParameterListenerImplementor")]
		internal sealed partial class IPlaybackParameterListenerImplementor : global::Java.Lang.Object, IPlaybackParameterListener {

			object sender;

			public IPlaybackParameterListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock_PlaybackParameterListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<PlaybackParameterEventArgs> Handler;
			#pragma warning restore 0649

			public void OnPlaybackParametersChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PlaybackParameterEventArgs (p0));
			}

			internal static bool __IsEmpty (IPlaybackParameterListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock", typeof (DefaultMediaClock));

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

		internal DefaultMediaClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/constructor[@name='DefaultMediaClock' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultMediaClock.PlaybackParameterListener'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock$PlaybackParameterListener;Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)V", "")]
		public unsafe DefaultMediaClock (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultMediaClock.IPlaybackParameterListener listener, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultMediaClock$PlaybackParameterListener;Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
				global::System.GC.KeepAlive (clock);
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='getPlaybackParameters' and count(parameter)=0]"
			[Register ("getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "")]
			get {
				const string __id = "getPlaybackParameters.()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='setPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V", "")]
			set {
				const string __id = "setPlaybackParameters.(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe long PositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='getPositionUs' and count(parameter)=0]"
			[Register ("getPositionUs", "()J", "")]
			get {
				const string __id = "getPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='onRendererDisabled' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer']]"
		[Register ("onRendererDisabled", "(Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;)V", "")]
		public unsafe void OnRendererDisabled (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer renderer)
		{
			const string __id = "onRendererDisabled.(Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((renderer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (renderer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='onRendererEnabled' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer']]"
		[Register ("onRendererEnabled", "(Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;)V", "")]
		public unsafe void OnRendererEnabled (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer renderer)
		{
			const string __id = "onRendererEnabled.(Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((renderer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (renderer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='resetPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("resetPosition", "(J)V", "")]
		public unsafe void ResetPosition (long positionUs)
		{
			const string __id = "resetPosition.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultMediaClock']/method[@name='syncAndGetPositionUs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("syncAndGetPositionUs", "(Z)J", "")]
		public unsafe long SyncAndGetPositionUs (bool isReadingAhead)
		{
			const string __id = "syncAndGetPositionUs.(Z)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isReadingAhead);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
