using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='ElementaryStreamReader']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/ElementaryStreamReader", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReaderInvoker")]
	public partial interface IElementaryStreamReader : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='ElementaryStreamReader']/method[@name='consume' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "GetConsume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='ElementaryStreamReader']/method[@name='createTracks' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.TrackIdGenerator']]"
		[Register ("createTracks", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V", "GetCreateTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReaderInvoker, PausedAdsAndroidTV.Binding")]
		void CreateTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='ElementaryStreamReader']/method[@name='packetFinished' and count(parameter)=0]"
		[Register ("packetFinished", "()V", "GetPacketFinishedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReaderInvoker, PausedAdsAndroidTV.Binding")]
		void PacketFinished ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='ElementaryStreamReader']/method[@name='packetStarted' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("packetStarted", "(JI)V", "GetPacketStarted_JIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReaderInvoker, PausedAdsAndroidTV.Binding")]
		void PacketStarted (long p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader", Fields = new string [] {"FlagPayloadUnitStartIndicator", "FlagRandomAccessIndicator", "FlagDataAlignmentIndicator"})]
		int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='ElementaryStreamReader']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "GetSeekHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Seek ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/ElementaryStreamReader", DoNotGenerateAcw=true)]
	internal partial class IElementaryStreamReaderInvoker : global::Java.Lang.Object, IElementaryStreamReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/ElementaryStreamReader", typeof (IElementaryStreamReaderInvoker));

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

		public static IElementaryStreamReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IElementaryStreamReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.ElementaryStreamReader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IElementaryStreamReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_;
#pragma warning disable 0169
		static Delegate GetCreateTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_Handler ()
		{
			if (cb_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ == null)
				cb_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CreateTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_);
			return cb_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_;
		}

		static void n_CreateTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateTracks (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_;
		public unsafe void CreateTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator p1)
		{
			if (id_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ == IntPtr.Zero)
				id_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_ = JNIEnv.GetMethodID (class_ref, "createTracks", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createTracks_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_, __args);
		}

		static Delegate cb_packetFinished;
#pragma warning disable 0169
		static Delegate GetPacketFinishedHandler ()
		{
			if (cb_packetFinished == null)
				cb_packetFinished = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PacketFinished);
			return cb_packetFinished;
		}

		static void n_PacketFinished (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PacketFinished ();
		}
#pragma warning restore 0169

		IntPtr id_packetFinished;
		public unsafe void PacketFinished ()
		{
			if (id_packetFinished == IntPtr.Zero)
				id_packetFinished = JNIEnv.GetMethodID (class_ref, "packetFinished", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_packetFinished);
		}

		static Delegate cb_packetStarted_JI;
#pragma warning disable 0169
		static Delegate GetPacketStarted_JIHandler ()
		{
			if (cb_packetStarted_JI == null)
				cb_packetStarted_JI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJI_V) n_PacketStarted_JI);
			return cb_packetStarted_JI;
		}

		static void n_PacketStarted_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PacketStarted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_packetStarted_JI;
		public unsafe void PacketStarted (long p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader", Fields = new string [] {"FlagPayloadUnitStartIndicator", "FlagRandomAccessIndicator", "FlagDataAlignmentIndicator"})]
		int p1)
		{
			if (id_packetStarted_JI == IntPtr.Zero)
				id_packetStarted_JI = JNIEnv.GetMethodID (class_ref, "packetStarted", "(JI)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_packetStarted_JI, __args);
		}

		static Delegate cb_seek;
#pragma warning disable 0169
		static Delegate GetSeekHandler ()
		{
			if (cb_seek == null)
				cb_seek = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Seek);
			return cb_seek;
		}

		static void n_Seek (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IElementaryStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek ();
		}
#pragma warning restore 0169

		IntPtr id_seek;
		public unsafe void Seek ()
		{
			if (id_seek == IntPtr.Zero)
				id_seek = JNIEnv.GetMethodID (class_ref, "seek", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek);
		}

	}
}
