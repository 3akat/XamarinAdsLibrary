using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor.ElementType']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor$ElementType", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorElementTypeInvoker")]
	public partial interface IEbmlProcessorElementType : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor$ElementType", DoNotGenerateAcw=true)]
	internal partial class IEbmlProcessorElementTypeInvoker : global::Java.Lang.Object, IEbmlProcessorElementType {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor$ElementType", typeof (IEbmlProcessorElementTypeInvoker));

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

		public static IEbmlProcessorElementType GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEbmlProcessorElementType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.EbmlProcessor.ElementType'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEbmlProcessorElementTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorElementType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorElementType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorElementType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorElementType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor", DoNotGenerateAcw=true)]
	public abstract class EbmlProcessor : Java.Lang.Object {
		internal EbmlProcessor ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/field[@name='ELEMENT_TYPE_BINARY']"
		[Register ("ELEMENT_TYPE_BINARY")]
		public const int ElementTypeBinary = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/field[@name='ELEMENT_TYPE_FLOAT']"
		[Register ("ELEMENT_TYPE_FLOAT")]
		public const int ElementTypeFloat = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/field[@name='ELEMENT_TYPE_MASTER']"
		[Register ("ELEMENT_TYPE_MASTER")]
		public const int ElementTypeMaster = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/field[@name='ELEMENT_TYPE_STRING']"
		[Register ("ELEMENT_TYPE_STRING")]
		public const int ElementTypeString = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/field[@name='ELEMENT_TYPE_UNKNOWN']"
		[Register ("ELEMENT_TYPE_UNKNOWN")]
		public const int ElementTypeUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/field[@name='ELEMENT_TYPE_UNSIGNED_INT']"
		[Register ("ELEMENT_TYPE_UNSIGNED_INT")]
		public const int ElementTypeUnsignedInt = (int) 2;

	}

	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'EbmlProcessor' type. This type will be removed in a future release.", error: true)]
	public abstract class EbmlProcessorConsts : EbmlProcessor {
		private EbmlProcessorConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker")]
	public partial interface IEbmlProcessor : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='binaryElement' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("binaryElement", "(IILcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)V", "GetBinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void BinaryElement (int p0, int p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='endMasterElement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("endMasterElement", "(I)V", "GetEndMasterElement_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void EndMasterElement (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='floatElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("floatElement", "(ID)V", "GetFloatElement_IDHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void FloatElement (int p0, double p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='getElementType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getElementType", "(I)I", "GetGetElementType_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		int GetElementType (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='integerElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("integerElement", "(IJ)V", "GetIntegerElement_IJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void IntegerElement (int p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='isLevel1Element' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLevel1Element", "(I)Z", "GetIsLevel1Element_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		bool IsLevel1Element (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='startMasterElement' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("startMasterElement", "(IJJ)V", "GetStartMasterElement_IJJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void StartMasterElement (int p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='EbmlProcessor']/method[@name='stringElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("stringElement", "(ILjava/lang/String;)V", "GetStringElement_ILjava_lang_String_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessorInvoker, PausedAdsAndroidTV.Binding")]
		void StringElement (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor", DoNotGenerateAcw=true)]
	internal partial class IEbmlProcessorInvoker : global::Java.Lang.Object, IEbmlProcessor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor", typeof (IEbmlProcessorInvoker));

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

		public static IEbmlProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEbmlProcessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.EbmlProcessor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEbmlProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
#pragma warning disable 0169
		static Delegate GetBinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler ()
		{
			if (cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == null)
				cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_BinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_);
			return cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		}

		static void n_BinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.BinaryElement (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		public unsafe void BinaryElement (int p0, int p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p2)
		{
			if (id_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == IntPtr.Zero)
				id_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "binaryElement", "(IILcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_, __args);
		}

		static Delegate cb_endMasterElement_I;
#pragma warning disable 0169
		static Delegate GetEndMasterElement_IHandler ()
		{
			if (cb_endMasterElement_I == null)
				cb_endMasterElement_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_EndMasterElement_I);
			return cb_endMasterElement_I;
		}

		static void n_EndMasterElement_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndMasterElement (p0);
		}
#pragma warning restore 0169

		IntPtr id_endMasterElement_I;
		public unsafe void EndMasterElement (int p0)
		{
			if (id_endMasterElement_I == IntPtr.Zero)
				id_endMasterElement_I = JNIEnv.GetMethodID (class_ref, "endMasterElement", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endMasterElement_I, __args);
		}

		static Delegate cb_floatElement_ID;
#pragma warning disable 0169
		static Delegate GetFloatElement_IDHandler ()
		{
			if (cb_floatElement_ID == null)
				cb_floatElement_ID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPID_V) n_FloatElement_ID);
			return cb_floatElement_ID;
		}

		static void n_FloatElement_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FloatElement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_floatElement_ID;
		public unsafe void FloatElement (int p0, double p1)
		{
			if (id_floatElement_ID == IntPtr.Zero)
				id_floatElement_ID = JNIEnv.GetMethodID (class_ref, "floatElement", "(ID)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_floatElement_ID, __args);
		}

		static Delegate cb_getElementType_I;
#pragma warning disable 0169
		static Delegate GetGetElementType_IHandler ()
		{
			if (cb_getElementType_I == null)
				cb_getElementType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetElementType_I);
			return cb_getElementType_I;
		}

		static int n_GetElementType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetElementType (p0);
		}
#pragma warning restore 0169

		IntPtr id_getElementType_I;
		public unsafe int GetElementType (int p0)
		{
			if (id_getElementType_I == IntPtr.Zero)
				id_getElementType_I = JNIEnv.GetMethodID (class_ref, "getElementType", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getElementType_I, __args);
		}

		static Delegate cb_integerElement_IJ;
#pragma warning disable 0169
		static Delegate GetIntegerElement_IJHandler ()
		{
			if (cb_integerElement_IJ == null)
				cb_integerElement_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_V) n_IntegerElement_IJ);
			return cb_integerElement_IJ;
		}

		static void n_IntegerElement_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IntegerElement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_integerElement_IJ;
		public unsafe void IntegerElement (int p0, long p1)
		{
			if (id_integerElement_IJ == IntPtr.Zero)
				id_integerElement_IJ = JNIEnv.GetMethodID (class_ref, "integerElement", "(IJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_integerElement_IJ, __args);
		}

		static Delegate cb_isLevel1Element_I;
#pragma warning disable 0169
		static Delegate GetIsLevel1Element_IHandler ()
		{
			if (cb_isLevel1Element_I == null)
				cb_isLevel1Element_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsLevel1Element_I);
			return cb_isLevel1Element_I;
		}

		static bool n_IsLevel1Element_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLevel1Element (p0);
		}
#pragma warning restore 0169

		IntPtr id_isLevel1Element_I;
		public unsafe bool IsLevel1Element (int p0)
		{
			if (id_isLevel1Element_I == IntPtr.Zero)
				id_isLevel1Element_I = JNIEnv.GetMethodID (class_ref, "isLevel1Element", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLevel1Element_I, __args);
		}

		static Delegate cb_startMasterElement_IJJ;
#pragma warning disable 0169
		static Delegate GetStartMasterElement_IJJHandler ()
		{
			if (cb_startMasterElement_IJJ == null)
				cb_startMasterElement_IJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJJ_V) n_StartMasterElement_IJJ);
			return cb_startMasterElement_IJJ;
		}

		static void n_StartMasterElement_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartMasterElement (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_startMasterElement_IJJ;
		public unsafe void StartMasterElement (int p0, long p1, long p2)
		{
			if (id_startMasterElement_IJJ == IntPtr.Zero)
				id_startMasterElement_IJJ = JNIEnv.GetMethodID (class_ref, "startMasterElement", "(IJJ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startMasterElement_IJJ, __args);
		}

		static Delegate cb_stringElement_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStringElement_ILjava_lang_String_Handler ()
		{
			if (cb_stringElement_ILjava_lang_String_ == null)
				cb_stringElement_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_StringElement_ILjava_lang_String_);
			return cb_stringElement_ILjava_lang_String_;
		}

		static void n_StringElement_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StringElement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_stringElement_ILjava_lang_String_;
		public unsafe void StringElement (int p0, string p1)
		{
			if (id_stringElement_ILjava_lang_String_ == IntPtr.Zero)
				id_stringElement_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stringElement", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stringElement_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
