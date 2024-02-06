using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/DefaultExtractorInput", DoNotGenerateAcw=true)]
	public sealed partial class DefaultExtractorInput : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/DefaultExtractorInput", typeof (DefaultExtractorInput));

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

		internal DefaultExtractorInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/constructor[@name='DefaultExtractorInput' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;JJ)V", "")]
		public unsafe DefaultExtractorInput (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource dataSource, long position, long length) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/DataSource;JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
				__args [1] = new JniArgumentValue (position);
				__args [2] = new JniArgumentValue (length);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSource);
			}
		}

		public unsafe long Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()J", "")]
			get {
				const string __id = "getLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long PeekPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='getPeekPosition' and count(parameter)=0]"
			[Register ("getPeekPosition", "()J", "")]
			get {
				const string __id = "getPeekPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()J", "")]
			get {
				const string __id = "getPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("advancePeekPosition", "(I)V", "")]
		public unsafe void AdvancePeekPosition (int length)
		{
			const string __id = "advancePeekPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("advancePeekPosition", "(IZ)Z", "")]
		public unsafe bool AdvancePeekPosition (int length, bool allowEndOfInput)
		{
			const string __id = "advancePeekPosition.(IZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (length);
				__args [1] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='peek' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("peek", "([BII)I", "")]
		public unsafe int Peek (byte[] target, int offset, int length)
		{
			const string __id = "peek.([BII)I";
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='peekFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("peekFully", "([BII)V", "")]
		public unsafe void PeekFully (byte[] target, int offset, int length)
		{
			const string __id = "peekFully.([BII)V";
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='peekFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("peekFully", "([BIIZ)Z", "")]
		public unsafe bool PeekFully (byte[] target, int offset, int length, bool allowEndOfInput)
		{
			const string __id = "peekFully.([BIIZ)Z";
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public unsafe int Read (byte[] target, int offset, int length)
		{
			const string __id = "read.([BII)I";
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='readFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readFully", "([BII)V", "")]
		public unsafe void ReadFully (byte[] target, int offset, int length)
		{
			const string __id = "readFully.([BII)V";
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("readFully", "([BIIZ)Z", "")]
		public unsafe bool ReadFully (byte[] target, int offset, int length, bool allowEndOfInput)
		{
			const string __id = "readFully.([BIIZ)Z";
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='resetPeekPosition' and count(parameter)=0]"
		[Register ("resetPeekPosition", "()V", "")]
		public unsafe void ResetPeekPosition ()
		{
			const string __id = "resetPeekPosition.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='setRetryPosition' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='E']]"
		[Register ("setRetryPosition", "(JLjava/lang/Throwable;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		public unsafe void SetRetryPosition (long position, global::Java.Lang.Object e)
		{
			const string __id = "setRetryPosition.(JLjava/lang/Throwable;)V";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (native_e);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
				global::System.GC.KeepAlive (e);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)I", "")]
		public unsafe int Skip (int length)
		{
			const string __id = "skip.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='skipFully' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipFully", "(I)V", "")]
		public unsafe void SkipFully (int length)
		{
			const string __id = "skipFully.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorInput']/method[@name='skipFully' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("skipFully", "(IZ)Z", "")]
		public unsafe bool SkipFully (int length, bool allowEndOfInput)
		{
			const string __id = "skipFully.(IZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (length);
				__args [1] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
