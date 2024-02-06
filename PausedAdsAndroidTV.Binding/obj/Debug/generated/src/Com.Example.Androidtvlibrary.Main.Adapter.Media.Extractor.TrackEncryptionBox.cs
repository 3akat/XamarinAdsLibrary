using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox", DoNotGenerateAcw=true)]
	public sealed partial class TrackEncryptionBox : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']/field[@name='cryptoData']"
		[Register ("cryptoData")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData CryptoData {
			get {
				const string __id = "cryptoData.Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cryptoData.Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']/field[@name='defaultInitializationVector']"
		[Register ("defaultInitializationVector")]
		public IList<byte> DefaultInitializationVector {
			get {
				const string __id = "defaultInitializationVector.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "defaultInitializationVector.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']/field[@name='isEncrypted']"
		[Register ("isEncrypted")]
		public bool IsEncrypted {
			get {
				const string __id = "isEncrypted.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isEncrypted.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']/field[@name='perSampleIvSize']"
		[Register ("perSampleIvSize")]
		public int PerSampleIvSize {
			get {
				const string __id = "perSampleIvSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "perSampleIvSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']/field[@name='schemeType']"
		[Register ("schemeType")]
		public string SchemeType {
			get {
				const string __id = "schemeType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "schemeType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox", typeof (TrackEncryptionBox));

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

		internal TrackEncryptionBox (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackEncryptionBox']/constructor[@name='TrackEncryptionBox' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
		[Register (".ctor", "(ZLjava/lang/String;I[BII[B)V", "")]
		public unsafe TrackEncryptionBox (bool isEncrypted, string schemeType, int perSampleIvSize, byte[] keyId, int defaultEncryptedBlocks, int defaultClearBlocks, byte[] defaultInitializationVector) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/lang/String;I[BII[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_schemeType = JNIEnv.NewString (schemeType);
			IntPtr native_keyId = JNIEnv.NewArray (keyId);
			IntPtr native_defaultInitializationVector = JNIEnv.NewArray (defaultInitializationVector);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (isEncrypted);
				__args [1] = new JniArgumentValue (native_schemeType);
				__args [2] = new JniArgumentValue (perSampleIvSize);
				__args [3] = new JniArgumentValue (native_keyId);
				__args [4] = new JniArgumentValue (defaultEncryptedBlocks);
				__args [5] = new JniArgumentValue (defaultClearBlocks);
				__args [6] = new JniArgumentValue (native_defaultInitializationVector);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_schemeType);
				if (keyId != null) {
					JNIEnv.CopyArray (native_keyId, keyId);
					JNIEnv.DeleteLocalRef (native_keyId);
				}
				if (defaultInitializationVector != null) {
					JNIEnv.CopyArray (native_defaultInitializationVector, defaultInitializationVector);
					JNIEnv.DeleteLocalRef (native_defaultInitializationVector);
				}
				global::System.GC.KeepAlive (keyId);
				global::System.GC.KeepAlive (defaultInitializationVector);
			}
		}

	}
}
