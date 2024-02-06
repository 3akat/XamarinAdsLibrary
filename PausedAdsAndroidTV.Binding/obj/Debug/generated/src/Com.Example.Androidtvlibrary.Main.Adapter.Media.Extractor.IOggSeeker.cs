using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='OggSeeker']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/OggSeeker", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeekerInvoker")]
	public partial interface IOggSeeker : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='OggSeeker']/method[@name='createSeekMap' and count(parameter)=0]"
		[Register ("createSeekMap", "()Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap;", "GetCreateSeekMapHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeekerInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap CreateSeekMap ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='OggSeeker']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)J", "GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeekerInvoker, PausedAdsAndroidTV.Binding")]
		long Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='OggSeeker']/method[@name='startSeek' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("startSeek", "(J)V", "GetStartSeek_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeekerInvoker, PausedAdsAndroidTV.Binding")]
		void StartSeek (long p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/OggSeeker", DoNotGenerateAcw=true)]
	internal partial class IOggSeekerInvoker : global::Java.Lang.Object, IOggSeeker {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/OggSeeker", typeof (IOggSeekerInvoker));

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

		public static IOggSeeker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOggSeeker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.OggSeeker'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOggSeekerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createSeekMap;
#pragma warning disable 0169
		static Delegate GetCreateSeekMapHandler ()
		{
			if (cb_createSeekMap == null)
				cb_createSeekMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateSeekMap);
			return cb_createSeekMap;
		}

		static IntPtr n_CreateSeekMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateSeekMap ());
		}
#pragma warning restore 0169

		IntPtr id_createSeekMap;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap CreateSeekMap ()
		{
			if (id_createSeekMap == IntPtr.Zero)
				id_createSeekMap = JNIEnv.GetMethodID (class_ref, "createSeekMap", "()Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap;");
			return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSeekMap), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler ()
		{
			if (cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == null)
				cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_);
			return cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		}

		static long n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Read (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		public unsafe long Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0)
		{
			if (id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == IntPtr.Zero)
				id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_, __args);
			return __ret;
		}

		static Delegate cb_startSeek_J;
#pragma warning disable 0169
		static Delegate GetStartSeek_JHandler ()
		{
			if (cb_startSeek_J == null)
				cb_startSeek_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_StartSeek_J);
			return cb_startSeek_J;
		}

		static void n_StartSeek_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IOggSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSeek (p0);
		}
#pragma warning restore 0169

		IntPtr id_startSeek_J;
		public unsafe void StartSeek (long p0)
		{
			if (id_startSeek_J == IntPtr.Zero)
				id_startSeek_J = JNIEnv.GetMethodID (class_ref, "startSeek", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startSeek_J, __args);
		}

	}
}
