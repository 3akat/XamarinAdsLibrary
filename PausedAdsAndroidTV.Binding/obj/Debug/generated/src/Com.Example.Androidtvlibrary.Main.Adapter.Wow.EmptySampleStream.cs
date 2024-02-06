using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EmptySampleStream']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/EmptySampleStream", DoNotGenerateAcw=true)]
	public sealed partial class EmptySampleStream : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/EmptySampleStream", typeof (EmptySampleStream));

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

		internal EmptySampleStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EmptySampleStream']/constructor[@name='EmptySampleStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EmptySampleStream () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EmptySampleStream']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "")]
			get {
				const string __id = "isReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EmptySampleStream']/method[@name='maybeThrowError' and count(parameter)=0]"
		[Register ("maybeThrowError", "()V", "")]
		public unsafe void MaybeThrowError ()
		{
			const string __id = "maybeThrowError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EmptySampleStream']/method[@name='readData' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.FormatHolder'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DecoderInputBuffer'] and parameter[3][@type='boolean']]"
		[Register ("readData", "(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;Z)I", "")]
		public unsafe int ReadData (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder formatHolder, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer buffer, bool formatRequired)
		{
			const string __id = "readData.(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((formatHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatHolder).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [2] = new JniArgumentValue (formatRequired);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (formatHolder);
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EmptySampleStream']/method[@name='skipData' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skipData", "(J)I", "")]
		public unsafe int SkipData (long positionUs)
		{
			const string __id = "skipData.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
