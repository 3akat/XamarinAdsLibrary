using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SampleStream']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/SampleStream", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStreamInvoker")]
	public partial interface ISampleStream : IJavaObject, IJavaPeerable {
		bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SampleStream']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStreamInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SampleStream']/method[@name='maybeThrowError' and count(parameter)=0]"
		[Register ("maybeThrowError", "()V", "GetMaybeThrowErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStreamInvoker, PausedAdsAndroidTV.Binding")]
		void MaybeThrowError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SampleStream']/method[@name='readData' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.FormatHolder'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DecoderInputBuffer'] and parameter[3][@type='boolean']]"
		[Register ("readData", "(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;Z)I", "GetReadData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStreamInvoker, PausedAdsAndroidTV.Binding")]
		int ReadData (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='SampleStream']/method[@name='skipData' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skipData", "(J)I", "GetSkipData_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStreamInvoker, PausedAdsAndroidTV.Binding")]
		int SkipData (long p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/SampleStream", DoNotGenerateAcw=true)]
	internal partial class ISampleStreamInvoker : global::Java.Lang.Object, ISampleStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/SampleStream", typeof (ISampleStreamInvoker));

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

		public static ISampleStream GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISampleStream> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.SampleStream'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISampleStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		IntPtr id_isReady;
		public unsafe bool IsReady {
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReady);
			}
		}

		static Delegate cb_maybeThrowError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowErrorHandler ()
		{
			if (cb_maybeThrowError == null)
				cb_maybeThrowError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowError);
			return cb_maybeThrowError;
		}

		static void n_MaybeThrowError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowError ();
		}
#pragma warning restore 0169

		IntPtr id_maybeThrowError;
		public unsafe void MaybeThrowError ()
		{
			if (id_maybeThrowError == IntPtr.Zero)
				id_maybeThrowError = JNIEnv.GetMethodID (class_ref, "maybeThrowError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_maybeThrowError);
		}

		static Delegate cb_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z;
#pragma warning disable 0169
		static Delegate GetReadData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZHandler ()
		{
			if (cb_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z == null)
				cb_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_I) n_ReadData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z);
			return cb_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z;
		}

		static int n_ReadData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadData (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z;
		public unsafe int ReadData (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer p1, bool p2)
		{
			if (id_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z == IntPtr.Zero)
				id_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z = JNIEnv.GetMethodID (class_ref, "readData", "(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;Z)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readData_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_Z, __args);
			return __ret;
		}

		static Delegate cb_skipData_J;
#pragma warning disable 0169
		static Delegate GetSkipData_JHandler ()
		{
			if (cb_skipData_J == null)
				cb_skipData_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_I) n_SkipData_J);
			return cb_skipData_J;
		}

		static int n_SkipData_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipData (p0);
		}
#pragma warning restore 0169

		IntPtr id_skipData_J;
		public unsafe int SkipData (long p0)
		{
			if (id_skipData_J == IntPtr.Zero)
				id_skipData_J = JNIEnv.GetMethodID (class_ref, "skipData", "(J)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skipData_J, __args);
		}

	}
}
