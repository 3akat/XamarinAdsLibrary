using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlReader']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlReader", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReaderInvoker")]
	public partial interface IEbmlReader : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlReader']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.EbmlProcessor']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor;)V", "GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReaderInvoker, PausedAdsAndroidTV.Binding")]
		bool Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlReader']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlReader", DoNotGenerateAcw=true)]
	internal partial class IEbmlReaderInvoker : global::Java.Lang.Object, IEbmlReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlReader", typeof (IEbmlReaderInvoker));

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

		public static IEbmlReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEbmlReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.EbmlReader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEbmlReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_Handler ()
		{
			if (cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_ == null)
				cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_);
			return cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_;
		}

		static void n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_;
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor p0)
		{
			if (id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_ == IntPtr.Zero)
				id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_EbmlProcessor_, __args);
		}

		static Delegate cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler ()
		{
			if (cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == null)
				cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_);
			return cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		}

		static bool n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Read (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		public unsafe bool Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0)
		{
			if (id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == IntPtr.Zero)
				id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_, __args);
			return __ret;
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

	}
}
