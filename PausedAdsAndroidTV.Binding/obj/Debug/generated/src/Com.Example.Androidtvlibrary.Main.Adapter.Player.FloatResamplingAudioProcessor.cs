using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FloatResamplingAudioProcessor']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/FloatResamplingAudioProcessor", DoNotGenerateAcw=true)]
	public sealed partial class FloatResamplingAudioProcessor : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseAudioProcessor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/FloatResamplingAudioProcessor", typeof (FloatResamplingAudioProcessor));

		internal static new IntPtr class_ref {
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

		internal FloatResamplingAudioProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FloatResamplingAudioProcessor']/constructor[@name='FloatResamplingAudioProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FloatResamplingAudioProcessor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FloatResamplingAudioProcessor']/method[@name='onConfigure' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor.AudioFormat']]"
		[Register ("onConfigure", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat OnConfigure (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat inputAudioFormat)
		{
			const string __id = "onConfigure.(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputAudioFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputAudioFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputAudioFormat);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FloatResamplingAudioProcessor']/method[@name='queueInput' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("queueInput", "(Ljava/nio/ByteBuffer;)V", "")]
		public override unsafe void QueueInput (global::Java.Nio.ByteBuffer inputBuffer)
		{
			const string __id = "queueInput.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputBuffer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (inputBuffer);
			}
		}

	}
}
