using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeeker']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/ConstantBitrateSeeker", DoNotGenerateAcw=true)]
	public sealed partial class ConstantBitrateSeeker : global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ConstantBitrateSeekMap, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/ConstantBitrateSeeker", typeof (ConstantBitrateSeeker));

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

		internal ConstantBitrateSeeker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeeker']/constructor[@name='ConstantBitrateSeeker' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.mp3.MpegAudioHeader']]"
		[Register (".ctor", "(JJLcom/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader;)V", "")]
		public unsafe ConstantBitrateSeeker (long inputLength, long firstFramePosition, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MpegAudioHeader mpegAudioHeader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJLcom/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (inputLength);
				__args [1] = new JniArgumentValue (firstFramePosition);
				__args [2] = new JniArgumentValue ((mpegAudioHeader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpegAudioHeader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mpegAudioHeader);
			}
		}

		public unsafe long DataEndPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeeker']/method[@name='getDataEndPosition' and count(parameter)=0]"
			[Register ("getDataEndPosition", "()J", "")]
			get {
				const string __id = "getDataEndPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeeker']/method[@name='getTimeUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimeUs", "(J)J", "")]
		public unsafe long GetTimeUs (long position)
		{
			const string __id = "getTimeUs.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
