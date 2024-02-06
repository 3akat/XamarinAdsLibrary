using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/SonicAudioProcessor", DoNotGenerateAcw=true)]
	public sealed partial class SonicAudioProcessor : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/field[@name='MAXIMUM_PITCH']"
		[Register ("MAXIMUM_PITCH")]
		public const float MaximumPitch = (float) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/field[@name='MAXIMUM_SPEED']"
		[Register ("MAXIMUM_SPEED")]
		public const float MaximumSpeed = (float) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/field[@name='MINIMUM_PITCH']"
		[Register ("MINIMUM_PITCH")]
		public const float MinimumPitch = (float) 0.100000001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/field[@name='MINIMUM_SPEED']"
		[Register ("MINIMUM_SPEED")]
		public const float MinimumSpeed = (float) 0.100000001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/field[@name='SAMPLE_RATE_NO_CHANGE']"
		[Register ("SAMPLE_RATE_NO_CHANGE")]
		public const int SampleRateNoChange = (int) -1;

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/SonicAudioProcessor", typeof (SonicAudioProcessor));

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

		internal SonicAudioProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/constructor[@name='SonicAudioProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SonicAudioProcessor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "")]
			get {
				const string __id = "isActive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "")]
			get {
				const string __id = "isEnded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Nio.ByteBuffer Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/nio/ByteBuffer;", "")]
			get {
				const string __id = "getOutput.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor.AudioFormat']]"
		[Register ("configure", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat Configure (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat inputAudioFormat)
		{
			const string __id = "configure.(Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;)Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputAudioFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputAudioFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputAudioFormat);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='queueEndOfStream' and count(parameter)=0]"
		[Register ("queueEndOfStream", "()V", "")]
		public unsafe void QueueEndOfStream ()
		{
			const string __id = "queueEndOfStream.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='queueInput' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("queueInput", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe void QueueInput (global::Java.Nio.ByteBuffer inputBuffer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='scaleDurationForSpeedup' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("scaleDurationForSpeedup", "(J)J", "")]
		public unsafe long ScaleDurationForSpeedup (long duration)
		{
			const string __id = "scaleDurationForSpeedup.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (duration);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='setOutputSampleRateHz' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOutputSampleRateHz", "(I)V", "")]
		public unsafe void SetOutputSampleRateHz (int sampleRateHz)
		{
			const string __id = "setOutputSampleRateHz.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sampleRateHz);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='setPitch' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPitch", "(F)F", "")]
		public unsafe float SetPitch (float pitch)
		{
			const string __id = "setPitch.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pitch);
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SonicAudioProcessor']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSpeed", "(F)F", "")]
		public unsafe float SetSpeed (float speed)
		{
			const string __id = "setSpeed.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (speed);
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
