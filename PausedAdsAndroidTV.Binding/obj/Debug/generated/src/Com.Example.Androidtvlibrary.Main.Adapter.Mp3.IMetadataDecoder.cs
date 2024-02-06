using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='MetadataDecoder']"
	[Register ("com/example/androidtvlibrary/main/adapter/mp3/MetadataDecoder", "", "Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoderInvoker")]
	public partial interface IMetadataDecoder : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='MetadataDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.mp3.MetadataInputBuffer']]"
		[Register ("decode", "(Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataInputBuffer;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "GetDecode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoderInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata Decode (global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MetadataInputBuffer p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/MetadataDecoder", DoNotGenerateAcw=true)]
	internal partial class IMetadataDecoderInvoker : global::Java.Lang.Object, IMetadataDecoder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/MetadataDecoder", typeof (IMetadataDecoderInvoker));

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

		public static IMetadataDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.mp3.MetadataDecoder'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_Handler ()
		{
			if (cb_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_ == null)
				cb_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_);
			return cb_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_;
		}

		static IntPtr n_Decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MetadataInputBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata Decode (global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MetadataInputBuffer p0)
		{
			if (id_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_ == IntPtr.Zero)
				id_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataInputBuffer;)Lcom/example/androidtvlibrary/main/adapter/Metadata;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Lcom_example_androidtvlibrary_main_adapter_mp3_MetadataInputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
