using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster", DoNotGenerateAcw=true)]
	public sealed partial class TimestampAdjuster : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/field[@name='DO_NOT_OFFSET']"
		[Register ("DO_NOT_OFFSET")]
		public const long DoNotOffset = (long) 9223372036854775807;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster", typeof (TimestampAdjuster));

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

		internal TimestampAdjuster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/constructor[@name='TimestampAdjuster' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe TimestampAdjuster (long firstSampleTimestampUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (firstSampleTimestampUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe long FirstSampleTimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='getFirstSampleTimestampUs' and count(parameter)=0]"
			[Register ("getFirstSampleTimestampUs", "()J", "")]
			get {
				const string __id = "getFirstSampleTimestampUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='setFirstSampleTimestampUs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setFirstSampleTimestampUs", "(J)V", "")]
			set {
				const string __id = "setFirstSampleTimestampUs.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe long LastAdjustedTimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='getLastAdjustedTimestampUs' and count(parameter)=0]"
			[Register ("getLastAdjustedTimestampUs", "()J", "")]
			get {
				const string __id = "getLastAdjustedTimestampUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long TimestampOffsetUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='getTimestampOffsetUs' and count(parameter)=0]"
			[Register ("getTimestampOffsetUs", "()J", "")]
			get {
				const string __id = "getTimestampOffsetUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='adjustSampleTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("adjustSampleTimestamp", "(J)J", "")]
		public unsafe long AdjustSampleTimestamp (long timeUs)
		{
			const string __id = "adjustSampleTimestamp.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='adjustTsTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("adjustTsTimestamp", "(J)J", "")]
		public unsafe long AdjustTsTimestamp (long pts90Khz)
		{
			const string __id = "adjustTsTimestamp.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pts90Khz);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='ptsToUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ptsToUs", "(J)J", "")]
		public static unsafe long PtsToUs (long pts)
		{
			const string __id = "ptsToUs.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pts);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='usToPts' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("usToPts", "(J)J", "")]
		public static unsafe long UsToPts (long us)
		{
			const string __id = "usToPts.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (us);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TimestampAdjuster']/method[@name='waitUntilInitialized' and count(parameter)=0]"
		[Register ("waitUntilInitialized", "()V", "")]
		public unsafe void WaitUntilInitialized ()
		{
			const string __id = "waitUntilInitialized.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
