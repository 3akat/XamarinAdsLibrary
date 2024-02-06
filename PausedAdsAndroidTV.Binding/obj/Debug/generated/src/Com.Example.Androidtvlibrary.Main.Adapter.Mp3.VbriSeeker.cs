using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/VbriSeeker", DoNotGenerateAcw=true)]
	public sealed partial class VbriSeeker : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/VbriSeeker", typeof (VbriSeeker));

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

		internal VbriSeeker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe long DataEndPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']/method[@name='getDataEndPosition' and count(parameter)=0]"
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

		public unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "")]
			get {
				const string __id = "getDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "")]
			get {
				const string __id = "isSeekable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']/method[@name='create' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.mp3.MpegAudioHeader'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("create", "(JJLcom/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader;Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Lcom/example/androidtvlibrary/main/adapter/mp3/VbriSeeker;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.VbriSeeker Create (long inputLength, long position, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MpegAudioHeader mpegAudioHeader, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray frame)
		{
			const string __id = "create.(JJLcom/example/androidtvlibrary/main/adapter/mp3/MpegAudioHeader;Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Lcom/example/androidtvlibrary/main/adapter/mp3/VbriSeeker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (inputLength);
				__args [1] = new JniArgumentValue (position);
				__args [2] = new JniArgumentValue ((mpegAudioHeader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpegAudioHeader).Handle);
				__args [3] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.VbriSeeker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mpegAudioHeader);
				global::System.GC.KeepAlive (frame);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']/method[@name='getSeekPoints' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getSeekPoints", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints GetSeekPoints (long timeUs)
		{
			const string __id = "getSeekPoints.(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='VbriSeeker']/method[@name='getTimeUs' and count(parameter)=1 and parameter[1][@type='long']]"
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
