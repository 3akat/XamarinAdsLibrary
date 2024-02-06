using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavSeekMap']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/WavSeekMap", DoNotGenerateAcw=true)]
	public sealed partial class WavSeekMap : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/WavSeekMap", typeof (WavSeekMap));

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

		internal WavSeekMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavSeekMap']/constructor[@name='WavSeekMap' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.WavHeader'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/WavHeader;IJJ)V", "")]
		public unsafe WavSeekMap (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.WavHeader wavHeader, int framesPerBlock, long dataStartPosition, long dataEndPosition) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/WavHeader;IJJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((wavHeader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wavHeader).Handle);
				__args [1] = new JniArgumentValue (framesPerBlock);
				__args [2] = new JniArgumentValue (dataStartPosition);
				__args [3] = new JniArgumentValue (dataEndPosition);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (wavHeader);
			}
		}

		public unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavSeekMap']/method[@name='getDurationUs' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavSeekMap']/method[@name='isSeekable' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavSeekMap']/method[@name='getSeekPoints' and count(parameter)=1 and parameter[1][@type='long']]"
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

	}
}
