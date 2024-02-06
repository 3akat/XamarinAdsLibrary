using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/VarintReader", DoNotGenerateAcw=true)]
	public sealed partial class VarintReader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/VarintReader", typeof (VarintReader));

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

		internal VarintReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']/constructor[@name='VarintReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VarintReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe int LastLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']/method[@name='getLastLength' and count(parameter)=0]"
			[Register ("getLastLength", "()I", "")]
			get {
				const string __id = "getLastLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']/method[@name='assembleVarint' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("assembleVarint", "([BIZ)J", "")]
		public static unsafe long AssembleVarint (byte[] varintBytes, int varintLength, bool removeLengthMask)
		{
			const string __id = "assembleVarint.([BIZ)J";
			IntPtr native_varintBytes = JNIEnv.NewArray (varintBytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_varintBytes);
				__args [1] = new JniArgumentValue (varintLength);
				__args [2] = new JniArgumentValue (removeLengthMask);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (varintBytes != null) {
					JNIEnv.CopyArray (native_varintBytes, varintBytes);
					JNIEnv.DeleteLocalRef (native_varintBytes);
				}
				global::System.GC.KeepAlive (varintBytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']/method[@name='parseUnsignedVarintLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("parseUnsignedVarintLength", "(I)I", "")]
		public static unsafe int ParseUnsignedVarintLength (int firstByte)
		{
			const string __id = "parseUnsignedVarintLength.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (firstByte);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']/method[@name='readUnsignedVarint' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("readUnsignedVarint", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;ZZI)J", "")]
		public unsafe long ReadUnsignedVarint (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, bool allowEndOfInput, bool removeLengthMask, int maximumAllowedLength)
		{
			const string __id = "readUnsignedVarint.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;ZZI)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue (allowEndOfInput);
				__args [2] = new JniArgumentValue (removeLengthMask);
				__args [3] = new JniArgumentValue (maximumAllowedLength);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VarintReader']/method[@name='reset' and count(parameter)=0]"
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
