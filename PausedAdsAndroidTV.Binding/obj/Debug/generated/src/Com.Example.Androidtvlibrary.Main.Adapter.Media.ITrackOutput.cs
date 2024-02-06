using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='TrackOutput.CryptoData']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData", DoNotGenerateAcw=true)]
	public sealed partial class TrackOutputCryptoData : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='TrackOutput.CryptoData']/field[@name='clearBlocks']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='TrackOutput.CryptoData']/field[@name='cryptoMode']"
		[Register ("cryptoMode")]
		public int CryptoMode {
			get {
				const string __id = "cryptoMode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cryptoMode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='TrackOutput.CryptoData']/field[@name='encryptedBlocks']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='TrackOutput.CryptoData']/field[@name='encryptionKey']"
		[Register ("encryptionKey")]
		public IList<byte> EncryptionKey {
			get {
				const string __id = "encryptionKey.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "encryptionKey.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData", typeof (TrackOutputCryptoData));

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

		internal TrackOutputCryptoData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='TrackOutput.CryptoData']/constructor[@name='TrackOutput.CryptoData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(I[BII)V", "")]
		public unsafe TrackOutputCryptoData (int cryptoMode, byte[] encryptionKey, int encryptedBlocks, int clearBlocks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[BII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_encryptionKey = JNIEnv.NewArray (encryptionKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (cryptoMode);
				__args [1] = new JniArgumentValue (native_encryptionKey);
				__args [2] = new JniArgumentValue (encryptedBlocks);
				__args [3] = new JniArgumentValue (clearBlocks);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (encryptionKey != null) {
					JNIEnv.CopyArray (native_encryptionKey, encryptionKey);
					JNIEnv.DeleteLocalRef (native_encryptionKey);
				}
				global::System.GC.KeepAlive (encryptionKey);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='TrackOutput']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/TrackOutput", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutputInvoker")]
	public partial interface ITrackOutput : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='TrackOutput']/method[@name='format' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("format", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V", "GetFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutputInvoker, PausedAdsAndroidTV.Binding")]
		void Format (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='TrackOutput']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I", "GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutputInvoker, PausedAdsAndroidTV.Binding")]
		int SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0, int p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='TrackOutput']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V", "GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutputInvoker, PausedAdsAndroidTV.Binding")]
		void SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='TrackOutput']/method[@name='sampleMetadata' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput.CryptoData']]"
		[Register ("sampleMetadata", "(JIIILcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;)V", "GetSampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutputInvoker, PausedAdsAndroidTV.Binding")]
		void SampleMetadata (long p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"BufferFlagKeyFrame", "BufferFlagEndOfStream", "BufferFlagHasSupplementalData", "BufferFlagLastSample", "BufferFlagEncrypted", "BufferFlagDecodeOnly"})]
		int p1, int p2, int p3, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData p4);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/TrackOutput", DoNotGenerateAcw=true)]
	internal partial class ITrackOutputInvoker : global::Java.Lang.Object, ITrackOutput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/TrackOutput", typeof (ITrackOutputInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrackOutput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackOutput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.TrackOutput'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackOutputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_format_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_format_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_format_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Format_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_format_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static void n_Format_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Format (p0);
		}
#pragma warning restore 0169

		IntPtr id_format_Lcom_example_androidtvlibrary_main_adapter_Format_;
		public unsafe void Format (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
		{
			if (id_format_Lcom_example_androidtvlibrary_main_adapter_Format_ == IntPtr.Zero)
				id_format_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNIEnv.GetMethodID (class_ref, "format", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_format_Lcom_example_androidtvlibrary_main_adapter_Format_, __args);
		}

		static Delegate cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZHandler ()
		{
			if (cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ == null)
				cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZ_I) n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ);
			return cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ;
		}

		static int n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SampleData (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ;
		public unsafe int SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0, int p1, bool p2)
		{
			if (id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ == IntPtr.Zero)
				id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ, __args);
			return __ret;
		}

		static Delegate cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler ()
		{
			if (cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I == null)
				cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I);
			return cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
		}

		static void n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SampleData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
		public unsafe void SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0, int p1)
		{
			if (id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I == IntPtr.Zero)
				id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I, __args);
		}

		static Delegate cb_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_;
#pragma warning disable 0169
		static Delegate GetSampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_Handler ()
		{
			if (cb_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_ == null)
				cb_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJIIIL_V) n_SampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_);
			return cb_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_;
		}

		static void n_SampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_ (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SampleMetadata (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_;
		public unsafe void SampleMetadata (long p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"BufferFlagKeyFrame", "BufferFlagEndOfStream", "BufferFlagHasSupplementalData", "BufferFlagLastSample", "BufferFlagEncrypted", "BufferFlagDecodeOnly"})]
		int p1, int p2, int p3, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData p4)
		{
			if (id_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_ == IntPtr.Zero)
				id_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_ = JNIEnv.GetMethodID (class_ref, "sampleMetadata", "(JIIILcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleMetadata_JIIILcom_example_androidtvlibrary_main_adapter_Media_TrackOutput_CryptoData_, __args);
		}

	}
}
