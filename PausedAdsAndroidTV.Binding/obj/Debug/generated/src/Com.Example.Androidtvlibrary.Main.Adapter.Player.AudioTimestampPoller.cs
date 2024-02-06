using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioTimestampPoller", DoNotGenerateAcw=true)]
	public sealed partial class AudioTimestampPoller : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioTimestampPoller", typeof (AudioTimestampPoller));

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

		internal AudioTimestampPoller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/constructor[@name='AudioTimestampPoller' and count(parameter)=1 and parameter[1][@type='android.media.AudioTrack']]"
		[Register (".ctor", "(Landroid/media/AudioTrack;)V", "")]
		public unsafe AudioTimestampPoller (global::Android.Media.AudioTrack audioTrack) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/media/AudioTrack;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((audioTrack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioTrack).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (audioTrack);
			}
		}

		public unsafe bool HasAdvancingTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='hasAdvancingTimestamp' and count(parameter)=0]"
			[Register ("hasAdvancingTimestamp", "()Z", "")]
			get {
				const string __id = "hasAdvancingTimestamp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='hasTimestamp' and count(parameter)=0]"
			[Register ("hasTimestamp", "()Z", "")]
			get {
				const string __id = "hasTimestamp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long TimestampPositionFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='getTimestampPositionFrames' and count(parameter)=0]"
			[Register ("getTimestampPositionFrames", "()J", "")]
			get {
				const string __id = "getTimestampPositionFrames.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long TimestampSystemTimeUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='getTimestampSystemTimeUs' and count(parameter)=0]"
			[Register ("getTimestampSystemTimeUs", "()J", "")]
			get {
				const string __id = "getTimestampSystemTimeUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='acceptTimestamp' and count(parameter)=0]"
		[Register ("acceptTimestamp", "()V", "")]
		public unsafe void AcceptTimestamp ()
		{
			const string __id = "acceptTimestamp.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='maybePollTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("maybePollTimestamp", "(J)Z", "")]
		public unsafe bool MaybePollTimestamp (long systemTimeUs)
		{
			const string __id = "maybePollTimestamp.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (systemTimeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='rejectTimestamp' and count(parameter)=0]"
		[Register ("rejectTimestamp", "()V", "")]
		public unsafe void RejectTimestamp ()
		{
			const string __id = "rejectTimestamp.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioTimestampPoller']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
