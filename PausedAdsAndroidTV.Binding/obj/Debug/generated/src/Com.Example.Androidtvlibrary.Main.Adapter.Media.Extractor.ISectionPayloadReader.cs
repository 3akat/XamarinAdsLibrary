using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='SectionPayloadReader']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/SectionPayloadReader", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReaderInvoker")]
	public partial interface ISectionPayloadReader : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='SectionPayloadReader']/method[@name='consume' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "GetConsume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='SectionPayloadReader']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.TrackIdGenerator']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V", "GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/SectionPayloadReader", DoNotGenerateAcw=true)]
	internal partial class ISectionPayloadReaderInvoker : global::Java.Lang.Object, ISectionPayloadReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/SectionPayloadReader", typeof (ISectionPayloadReaderInvoker));

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

		public static ISectionPayloadReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISectionPayloadReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.SectionPayloadReader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISectionPayloadReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
#pragma warning disable 0169
		static Delegate GetConsume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler ()
		{
			if (cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ == null)
				cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_);
			return cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
		}

		static void n_Consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Consume (p0);
		}
#pragma warning restore 0169

		IntPtr id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
		public unsafe void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0)
		{
			if (id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ == IntPtr.Zero)
				id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ = JNIEnv.GetMethodID (class_ref, "consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_, __args);
		}

		static Delegate cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_Handler ()
		{
			if (cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ == null)
				cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_);
			return cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_;
		}

		static void n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_;
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator p2)
		{
			if (id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ == IntPtr.Zero)
				id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_, __args);
		}

	}
}
