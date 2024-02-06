using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/CryptoInfo", DoNotGenerateAcw=true)]
	public sealed partial class CryptoInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='clearBlocks']"
		[Register ("clearBlocks")]
		public int ClearBlocks {
			get {
				const string __id = "clearBlocks.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "clearBlocks.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='encryptedBlocks']"
		[Register ("encryptedBlocks")]
		public int EncryptedBlocks {
			get {
				const string __id = "encryptedBlocks.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encryptedBlocks.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='iv']"
		[Register ("iv")]
		public IList<byte> Iv {
			get {
				const string __id = "iv.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "iv.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='key']"
		[Register ("key")]
		public IList<byte> Key {
			get {
				const string __id = "key.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "key.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='mode']"
		[Register ("mode")]
		public int Mode {
			get {
				const string __id = "mode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='numBytesOfClearData']"
		[Register ("numBytesOfClearData")]
		public IList<int> NumBytesOfClearData {
			get {
				const string __id = "numBytesOfClearData.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "numBytesOfClearData.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='numBytesOfEncryptedData']"
		[Register ("numBytesOfEncryptedData")]
		public IList<int> NumBytesOfEncryptedData {
			get {
				const string __id = "numBytesOfEncryptedData.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "numBytesOfEncryptedData.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/field[@name='numSubSamples']"
		[Register ("numSubSamples")]
		public int NumSubSamples {
			get {
				const string __id = "numSubSamples.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "numSubSamples.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/CryptoInfo", typeof (CryptoInfo));

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

		internal CryptoInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/constructor[@name='CryptoInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CryptoInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Android.Media.MediaCodec.CryptoInfo FrameworkCryptoInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/method[@name='getFrameworkCryptoInfo' and count(parameter)=0]"
			[Register ("getFrameworkCryptoInfo", "()Landroid/media/MediaCodec$CryptoInfo;", "")]
			get {
				const string __id = "getFrameworkCryptoInfo.()Landroid/media/MediaCodec$CryptoInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.CryptoInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::Android.Media.MediaCodec.CryptoInfo FrameworkCryptoInfoV16 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/method[@name='getFrameworkCryptoInfoV16' and count(parameter)=0]"
			[Register ("getFrameworkCryptoInfoV16", "()Landroid/media/MediaCodec$CryptoInfo;", "")]
			get {
				const string __id = "getFrameworkCryptoInfoV16.()Landroid/media/MediaCodec$CryptoInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.CryptoInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='CryptoInfo']/method[@name='set' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("set", "(I[I[I[B[BIII)V", "")]
		public unsafe void Set (int numSubSamples, int[] numBytesOfClearData, int[] numBytesOfEncryptedData, byte[] key, byte[] iv, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"CryptoModeUnencrypted", "CryptoModeAesCtr", "CryptoModeAesCbc"})]
		int mode, int encryptedBlocks, int clearBlocks)
		{
			const string __id = "set.(I[I[I[B[BIII)V";
			IntPtr native_numBytesOfClearData = JNIEnv.NewArray (numBytesOfClearData);
			IntPtr native_numBytesOfEncryptedData = JNIEnv.NewArray (numBytesOfEncryptedData);
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_iv = JNIEnv.NewArray (iv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (numSubSamples);
				__args [1] = new JniArgumentValue (native_numBytesOfClearData);
				__args [2] = new JniArgumentValue (native_numBytesOfEncryptedData);
				__args [3] = new JniArgumentValue (native_key);
				__args [4] = new JniArgumentValue (native_iv);
				__args [5] = new JniArgumentValue (mode);
				__args [6] = new JniArgumentValue (encryptedBlocks);
				__args [7] = new JniArgumentValue (clearBlocks);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (numBytesOfClearData != null) {
					JNIEnv.CopyArray (native_numBytesOfClearData, numBytesOfClearData);
					JNIEnv.DeleteLocalRef (native_numBytesOfClearData);
				}
				if (numBytesOfEncryptedData != null) {
					JNIEnv.CopyArray (native_numBytesOfEncryptedData, numBytesOfEncryptedData);
					JNIEnv.DeleteLocalRef (native_numBytesOfEncryptedData);
				}
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (iv != null) {
					JNIEnv.CopyArray (native_iv, iv);
					JNIEnv.DeleteLocalRef (native_iv);
				}
				global::System.GC.KeepAlive (numBytesOfClearData);
				global::System.GC.KeepAlive (numBytesOfEncryptedData);
				global::System.GC.KeepAlive (key);
				global::System.GC.KeepAlive (iv);
			}
		}

	}
}
