using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/ParsableByteArray", DoNotGenerateAcw=true)]
	public sealed partial class ParsableByteArray : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				const string __id = "data.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "data.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/ParsableByteArray", typeof (ParsableByteArray));

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

		internal ParsableByteArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParsableByteArray () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ParsableByteArray (byte[] data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe ParsableByteArray (byte[] data, int limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ParsableByteArray (int limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "")]
			get {
				const string __id = "getPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPosition", "(I)V", "")]
			set {
				const string __id = "setPosition.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='bytesLeft' and count(parameter)=0]"
		[Register ("bytesLeft", "()I", "")]
		public unsafe int BytesLeft ()
		{
			const string __id = "bytesLeft.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='capacity' and count(parameter)=0]"
		[Register ("capacity", "()I", "")]
		public unsafe int Capacity ()
		{
			const string __id = "capacity.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='limit' and count(parameter)=0]"
		[Register ("limit", "()I", "")]
		public unsafe int Limit ()
		{
			const string __id = "limit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='peekChar' and count(parameter)=0]"
		[Register ("peekChar", "()C", "")]
		public unsafe char PeekChar ()
		{
			const string __id = "peekChar.()C";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractCharMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='peekUnsignedByte' and count(parameter)=0]"
		[Register ("peekUnsignedByte", "()I", "")]
		public unsafe int PeekUnsignedByte ()
		{
			const string __id = "peekUnsignedByte.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readBytes", "([BII)V", "")]
		public unsafe void ReadBytes (byte[] buffer, int offset, int length)
		{
			const string __id = "readBytes.([BII)V";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readBytes' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableBitArray'] and parameter[2][@type='int']]"
		[Register ("readBytes", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;I)V", "")]
		public unsafe void ReadBytes (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableBitArray bitArray, int length)
		{
			const string __id = "readBytes.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitArray).Handle);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readBytes' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("readBytes", "(Ljava/nio/ByteBuffer;I)V", "")]
		public unsafe void ReadBytes (global::Java.Nio.ByteBuffer buffer, int length)
		{
			const string __id = "readBytes.(Ljava/nio/ByteBuffer;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readDouble' and count(parameter)=0]"
		[Register ("readDouble", "()D", "")]
		public unsafe double ReadDouble ()
		{
			const string __id = "readDouble.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readFloat' and count(parameter)=0]"
		[Register ("readFloat", "()F", "")]
		public unsafe float ReadFloat ()
		{
			const string __id = "readFloat.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "")]
		public unsafe int ReadInt ()
		{
			const string __id = "readInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readInt24' and count(parameter)=0]"
		[Register ("readInt24", "()I", "")]
		public unsafe int ReadInt24 ()
		{
			const string __id = "readInt24.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLine' and count(parameter)=0]"
		[Register ("readLine", "()Ljava/lang/String;", "")]
		public unsafe string ReadLine ()
		{
			const string __id = "readLine.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianInt' and count(parameter)=0]"
		[Register ("readLittleEndianInt", "()I", "")]
		public unsafe int ReadLittleEndianInt ()
		{
			const string __id = "readLittleEndianInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianInt24' and count(parameter)=0]"
		[Register ("readLittleEndianInt24", "()I", "")]
		public unsafe int ReadLittleEndianInt24 ()
		{
			const string __id = "readLittleEndianInt24.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianLong' and count(parameter)=0]"
		[Register ("readLittleEndianLong", "()J", "")]
		public unsafe long ReadLittleEndianLong ()
		{
			const string __id = "readLittleEndianLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianShort' and count(parameter)=0]"
		[Register ("readLittleEndianShort", "()S", "")]
		public unsafe short ReadLittleEndianShort ()
		{
			const string __id = "readLittleEndianShort.()S";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt16Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedInt' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedInt", "()J", "")]
		public unsafe long ReadLittleEndianUnsignedInt ()
		{
			const string __id = "readLittleEndianUnsignedInt.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedInt24' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedInt24", "()I", "")]
		public unsafe int ReadLittleEndianUnsignedInt24 ()
		{
			const string __id = "readLittleEndianUnsignedInt24.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedIntToInt' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedIntToInt", "()I", "")]
		public unsafe int ReadLittleEndianUnsignedIntToInt ()
		{
			const string __id = "readLittleEndianUnsignedIntToInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedShort' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedShort", "()I", "")]
		public unsafe int ReadLittleEndianUnsignedShort ()
		{
			const string __id = "readLittleEndianUnsignedShort.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readLong' and count(parameter)=0]"
		[Register ("readLong", "()J", "")]
		public unsafe long ReadLong ()
		{
			const string __id = "readLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readNullTerminatedString' and count(parameter)=0]"
		[Register ("readNullTerminatedString", "()Ljava/lang/String;", "")]
		public unsafe string ReadNullTerminatedString ()
		{
			const string __id = "readNullTerminatedString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readNullTerminatedString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readNullTerminatedString", "(I)Ljava/lang/String;", "")]
		public unsafe string ReadNullTerminatedString (int length)
		{
			const string __id = "readNullTerminatedString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()S", "")]
		public unsafe short ReadShort ()
		{
			const string __id = "readShort.()S";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt16Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readString", "(I)Ljava/lang/String;", "")]
		public unsafe string ReadString (int length)
		{
			const string __id = "readString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(ILjava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe string ReadString (int length, global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "readString.(ILjava/nio/charset/Charset;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (length);
				__args [1] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (charset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readSynchSafeInt' and count(parameter)=0]"
		[Register ("readSynchSafeInt", "()I", "")]
		public unsafe int ReadSynchSafeInt ()
		{
			const string __id = "readSynchSafeInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedByte' and count(parameter)=0]"
		[Register ("readUnsignedByte", "()I", "")]
		public unsafe int ReadUnsignedByte ()
		{
			const string __id = "readUnsignedByte.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedFixedPoint1616' and count(parameter)=0]"
		[Register ("readUnsignedFixedPoint1616", "()I", "")]
		public unsafe int ReadUnsignedFixedPoint1616 ()
		{
			const string __id = "readUnsignedFixedPoint1616.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedInt' and count(parameter)=0]"
		[Register ("readUnsignedInt", "()J", "")]
		public unsafe long ReadUnsignedInt ()
		{
			const string __id = "readUnsignedInt.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedInt24' and count(parameter)=0]"
		[Register ("readUnsignedInt24", "()I", "")]
		public unsafe int ReadUnsignedInt24 ()
		{
			const string __id = "readUnsignedInt24.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedIntToInt' and count(parameter)=0]"
		[Register ("readUnsignedIntToInt", "()I", "")]
		public unsafe int ReadUnsignedIntToInt ()
		{
			const string __id = "readUnsignedIntToInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedLongToLong' and count(parameter)=0]"
		[Register ("readUnsignedLongToLong", "()J", "")]
		public unsafe long ReadUnsignedLongToLong ()
		{
			const string __id = "readUnsignedLongToLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUnsignedShort' and count(parameter)=0]"
		[Register ("readUnsignedShort", "()I", "")]
		public unsafe int ReadUnsignedShort ()
		{
			const string __id = "readUnsignedShort.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='readUtf8EncodedLong' and count(parameter)=0]"
		[Register ("readUtf8EncodedLong", "()J", "")]
		public unsafe long ReadUtf8EncodedLong ()
		{
			const string __id = "readUtf8EncodedLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reset", "([B)V", "")]
		public unsafe void Reset (byte[] data)
		{
			const string __id = "reset.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='reset' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("reset", "([BI)V", "")]
		public unsafe void Reset (byte[] data, int limit)
		{
			const string __id = "reset.([BI)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)V", "")]
		public unsafe void Reset (int limit)
		{
			const string __id = "reset.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLimit", "(I)V", "")]
		public unsafe void SetLimit (int limit)
		{
			const string __id = "setLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ParsableByteArray']/method[@name='skipBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipBytes", "(I)V", "")]
		public unsafe void SkipBytes (int bytes)
		{
			const string __id = "skipBytes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bytes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
