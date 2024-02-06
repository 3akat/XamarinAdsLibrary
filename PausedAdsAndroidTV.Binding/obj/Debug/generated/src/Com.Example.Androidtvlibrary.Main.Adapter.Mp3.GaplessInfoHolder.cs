using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/GaplessInfoHolder", DoNotGenerateAcw=true)]
	public sealed partial class GaplessInfoHolder : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']/field[@name='encoderDelay']"
		[Register ("encoderDelay")]
		public int EncoderDelay {
			get {
				const string __id = "encoderDelay.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encoderDelay.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']/field[@name='encoderPadding']"
		[Register ("encoderPadding")]
		public int EncoderPadding {
			get {
				const string __id = "encoderPadding.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encoderPadding.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/GaplessInfoHolder", typeof (GaplessInfoHolder));

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

		internal GaplessInfoHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']/constructor[@name='GaplessInfoHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GaplessInfoHolder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool HasGaplessInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']/method[@name='hasGaplessInfo' and count(parameter)=0]"
			[Register ("hasGaplessInfo", "()Z", "")]
			get {
				const string __id = "hasGaplessInfo.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']/method[@name='setFromMetadata' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("setFromMetadata", "(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Z", "")]
		public unsafe bool SetFromMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata)
		{
			const string __id = "setFromMetadata.(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='GaplessInfoHolder']/method[@name='setFromXingHeaderValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFromXingHeaderValue", "(I)Z", "")]
		public unsafe bool SetFromXingHeaderValue (int value)
		{
			const string __id = "setFromXingHeaderValue.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
