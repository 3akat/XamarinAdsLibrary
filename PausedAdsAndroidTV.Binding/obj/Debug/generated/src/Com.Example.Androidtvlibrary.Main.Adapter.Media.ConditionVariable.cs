using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/ConditionVariable", DoNotGenerateAcw=true)]
	public sealed partial class ConditionVariable : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/ConditionVariable", typeof (ConditionVariable));

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

		internal ConditionVariable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/constructor[@name='ConditionVariable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConditionVariable () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/constructor[@name='ConditionVariable' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)V", "")]
		public unsafe ConditionVariable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (clock);
			}
		}

		public unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "")]
			get {
				const string __id = "isOpen.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/method[@name='block' and count(parameter)=0]"
		[Register ("block", "()V", "")]
		public unsafe void Block ()
		{
			const string __id = "block.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/method[@name='block' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("block", "(J)Z", "")]
		public unsafe bool Block (long timeoutMs)
		{
			const string __id = "block.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeoutMs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "")]
		public unsafe bool Close ()
		{
			const string __id = "close.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ConditionVariable']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "")]
		public unsafe bool Open ()
		{
			const string __id = "open.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
