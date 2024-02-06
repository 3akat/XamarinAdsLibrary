using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/BaseAudioProcessor", DoNotGenerateAcw=true)]
	public abstract partial class BaseAudioProcessor : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/field[@name='inputAudioFormat']"
		[Register ("inputAudioFormat")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat InputAudioFormat {
			get {
				const string __id = "inputAudioFormat.Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inputAudioFormat.Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/field[@name='outputAudioFormat']"
		[Register ("outputAudioFormat")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat OutputAudioFormat {
			get {
				const string __id = "outputAudioFormat.Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outputAudioFormat.Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.player.AudioProcessor


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/field[@name='EMPTY_BUFFER']"
			[Register ("EMPTY_BUFFER")]
			public static global::Java.Nio.ByteBuffer EmptyBuffer {
				get {
					const string __id = "EMPTY_BUFFER.Ljava/nio/ByteBuffer;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/BaseAudioProcessor", typeof (BaseAudioProcessor));

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

		protected BaseAudioProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/constructor[@name='BaseAudioProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseAudioProcessor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		protected unsafe bool HasPendingOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='hasPendingOutput' and count(parameter)=0]"
			[Register ("hasPendingOutput", "()Z", "")]
			get {
				const string __id = "hasPendingOutput.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")]
			get {
				const string __id = "isActive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnded;
#pragma warning disable 0169
		static Delegate GetIsEndedHandler ()
		{
			if (cb_isEnded == null)
				cb_isEnded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnded);
			return cb_isEnded;
		}

		static bool n_IsEnded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnded;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler")]
			get {
				const string __id = "isEnded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutput);
			return cb_getOutput;
		}

		static IntPtr n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Output);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/nio/ByteBuffer;", "GetGetOutputHandler")]
			get {
				const string __id = "getOutput.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor.AudioFormat']]"
		[Register ("configure", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat Configure (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat inputAudioFormat)
		{
			const string __id = "configure.(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputAudioFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputAudioFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputAudioFormat);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_;
#pragma warning disable 0169
		static Delegate GetOnConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_Handler ()
		{
			if (cb_onConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ == null)
				cb_onConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_);
			return cb_onConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_;
		}

		static IntPtr n_OnConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputAudioFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputAudioFormat = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (native_inputAudioFormat, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnConfigure (inputAudioFormat));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='onConfigure' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor.AudioFormat']]"
		[Register ("onConfigure", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;", "GetOnConfigure_Lcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_AudioFormat_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat OnConfigure (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat inputAudioFormat)
		{
			const string __id = "onConfigure.(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputAudioFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputAudioFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputAudioFormat);
			}
		}

		static Delegate cb_onFlush;
#pragma warning disable 0169
		static Delegate GetOnFlushHandler ()
		{
			if (cb_onFlush == null)
				cb_onFlush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnFlush);
			return cb_onFlush;
		}

		static void n_OnFlush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFlush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='onFlush' and count(parameter)=0]"
		[Register ("onFlush", "()V", "GetOnFlushHandler")]
		protected virtual unsafe void OnFlush ()
		{
			const string __id = "onFlush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onQueueEndOfStream;
#pragma warning disable 0169
		static Delegate GetOnQueueEndOfStreamHandler ()
		{
			if (cb_onQueueEndOfStream == null)
				cb_onQueueEndOfStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnQueueEndOfStream);
			return cb_onQueueEndOfStream;
		}

		static void n_OnQueueEndOfStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnQueueEndOfStream ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='onQueueEndOfStream' and count(parameter)=0]"
		[Register ("onQueueEndOfStream", "()V", "GetOnQueueEndOfStreamHandler")]
		protected virtual unsafe void OnQueueEndOfStream ()
		{
			const string __id = "onQueueEndOfStream.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onReset;
#pragma warning disable 0169
		static Delegate GetOnResetHandler ()
		{
			if (cb_onReset == null)
				cb_onReset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReset);
			return cb_onReset;
		}

		static void n_OnReset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='onReset' and count(parameter)=0]"
		[Register ("onReset", "()V", "GetOnResetHandler")]
		protected virtual unsafe void OnReset ()
		{
			const string __id = "onReset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='queueEndOfStream' and count(parameter)=0]"
		[Register ("queueEndOfStream", "()V", "")]
		public unsafe void QueueEndOfStream ()
		{
			const string __id = "queueEndOfStream.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='replaceOutputBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("replaceOutputBuffer", "(I)Ljava/nio/ByteBuffer;", "")]
		protected unsafe global::Java.Nio.ByteBuffer ReplaceOutputBuffer (int count)
		{
			const string __id = "replaceOutputBuffer.(I)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='BaseAudioProcessor']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_queueInput_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetQueueInput_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_queueInput_Ljava_nio_ByteBuffer_ == null)
				cb_queueInput_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_QueueInput_Ljava_nio_ByteBuffer_);
			return cb_queueInput_Ljava_nio_ByteBuffer_;
		}

		static void n_QueueInput_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueueInput (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='queueInput' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("queueInput", "(Ljava/nio/ByteBuffer;)V", "GetQueueInput_Ljava_nio_ByteBuffer_Handler")]
		public abstract void QueueInput (global::Java.Nio.ByteBuffer p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/BaseAudioProcessor", DoNotGenerateAcw=true)]
	internal partial class BaseAudioProcessorInvoker : BaseAudioProcessor {
		public BaseAudioProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/BaseAudioProcessor", typeof (BaseAudioProcessorInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioProcessor']/method[@name='queueInput' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("queueInput", "(Ljava/nio/ByteBuffer;)V", "GetQueueInput_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe void QueueInput (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "queueInput.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
