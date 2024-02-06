using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeekMap']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/ConstantBitrateSeekMap", DoNotGenerateAcw=true)]
	public partial class ConstantBitrateSeekMap : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/ConstantBitrateSeekMap", typeof (ConstantBitrateSeekMap));

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

		protected ConstantBitrateSeekMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeekMap']/constructor[@name='ConstantBitrateSeekMap' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(JJII)V", "")]
		public unsafe ConstantBitrateSeekMap (long inputLength, long firstFrameBytePosition, int bitrate, int frameSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (inputLength);
				__args [1] = new JniArgumentValue (firstFrameBytePosition);
				__args [2] = new JniArgumentValue (bitrate);
				__args [3] = new JniArgumentValue (frameSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDurationUs;
#pragma warning disable 0169
		static Delegate GetGetDurationUsHandler ()
		{
			if (cb_getDurationUs == null)
				cb_getDurationUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDurationUs);
			return cb_getDurationUs;
		}

		static long n_GetDurationUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ConstantBitrateSeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationUs;
		}
#pragma warning restore 0169

		public virtual unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeekMap']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "GetGetDurationUsHandler")]
			get {
				const string __id = "getDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSeekable;
#pragma warning disable 0169
		static Delegate GetIsSeekableHandler ()
		{
			if (cb_isSeekable == null)
				cb_isSeekable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSeekable);
			return cb_isSeekable;
		}

		static bool n_IsSeekable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ConstantBitrateSeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSeekable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeekMap']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "GetIsSeekableHandler")]
			get {
				const string __id = "isSeekable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSeekPoints_J;
#pragma warning disable 0169
		static Delegate GetGetSeekPoints_JHandler ()
		{
			if (cb_getSeekPoints_J == null)
				cb_getSeekPoints_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_GetSeekPoints_J);
			return cb_getSeekPoints_J;
		}

		static IntPtr n_GetSeekPoints_J (IntPtr jnienv, IntPtr native__this, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ConstantBitrateSeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeekPoints (timeUs));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeekMap']/method[@name='getSeekPoints' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getSeekPoints", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;", "GetGetSeekPoints_JHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints GetSeekPoints (long timeUs)
		{
			const string __id = "getSeekPoints.(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTimeUsAtPosition_J;
#pragma warning disable 0169
		static Delegate GetGetTimeUsAtPosition_JHandler ()
		{
			if (cb_getTimeUsAtPosition_J == null)
				cb_getTimeUsAtPosition_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_GetTimeUsAtPosition_J);
			return cb_getTimeUsAtPosition_J;
		}

		static long n_GetTimeUsAtPosition_J (IntPtr jnienv, IntPtr native__this, long position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ConstantBitrateSeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTimeUsAtPosition (position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ConstantBitrateSeekMap']/method[@name='getTimeUsAtPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimeUsAtPosition", "(J)J", "GetGetTimeUsAtPosition_JHandler")]
		public virtual unsafe long GetTimeUsAtPosition (long position)
		{
			const string __id = "getTimeUsAtPosition.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
