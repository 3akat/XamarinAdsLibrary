using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor.ReadResult']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/Extractor$ReadResult", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1ReadResultInvoker")]
	public partial interface Extractor1ReadResult : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Extractor$ReadResult", DoNotGenerateAcw=true)]
	internal partial class Extractor1ReadResultInvoker : global::Java.Lang.Object, Extractor1ReadResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Extractor$ReadResult", typeof (Extractor1ReadResultInvoker));

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

		public static Extractor1ReadResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<Extractor1ReadResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.Extractor.ReadResult'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public Extractor1ReadResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1ReadResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1ReadResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1ReadResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1ReadResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/Media/Extractor", DoNotGenerateAcw=true)]
	public abstract class xtractor1Consts : Java.Lang.Object {
		internal xtractor1Consts ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_CONTINUE']"
		[Register ("RESULT_CONTINUE")]
		public const int ResultContinue = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_END_OF_INPUT']"
		[Register ("RESULT_END_OF_INPUT")]
		public const int ResultEndOfInput = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_SEEK']"
		[Register ("RESULT_SEEK")]
		public const int ResultSeek = (int) 1;

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/Extractor", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1Invoker")]
	public partial interface Extractor1 : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V", "GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1Invoker, PausedAdsAndroidTV.Binding")]
		void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.PositionHolder']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I", "GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1Invoker, PausedAdsAndroidTV.Binding")]
		int Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1Invoker, PausedAdsAndroidTV.Binding")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/method[@name='seek' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("seek", "(JJ)V", "GetSeek_JJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1Invoker, PausedAdsAndroidTV.Binding")]
		void Seek (long p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("sniff", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "GetSniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1Invoker, PausedAdsAndroidTV.Binding")]
		bool Sniff (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Extractor", DoNotGenerateAcw=true)]
	internal partial class Extractor1Invoker : global::Java.Lang.Object, Extractor1 {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Extractor", typeof (Extractor1Invoker));

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

		public static Extractor1 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<Extractor1> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.Extractor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public Extractor1Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Handler ()
		{
			if (cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ == null)
				cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_);
			return cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_;
		}

		static void n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_;
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p0)
		{
			if (id_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ == IntPtr.Zero)
				id_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_, __args);
		}

		static Delegate cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_Handler ()
		{
			if (cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ == null)
				cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_);
			return cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
		}

		static int n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
		public unsafe int Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder p1)
		{
			if (id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ == IntPtr.Zero)
				id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_, __args);
			return __ret;
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_seek_JJ;
#pragma warning disable 0169
		static Delegate GetSeek_JJHandler ()
		{
			if (cb_seek_JJ == null)
				cb_seek_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_Seek_JJ);
			return cb_seek_JJ;
		}

		static void n_Seek_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_seek_JJ;
		public unsafe void Seek (long p0, long p1)
		{
			if (id_seek_JJ == IntPtr.Zero)
				id_seek_JJ = JNIEnv.GetMethodID (class_ref, "seek", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek_JJ, __args);
		}

		static Delegate cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
#pragma warning disable 0169
		static Delegate GetSniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler ()
		{
			if (cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == null)
				cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_);
			return cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		}

		static bool n_Sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Sniff (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		public unsafe bool Sniff (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0)
		{
			if (id_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == IntPtr.Zero)
				id_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "sniff", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_, __args);
			return __ret;
		}

	}
}
