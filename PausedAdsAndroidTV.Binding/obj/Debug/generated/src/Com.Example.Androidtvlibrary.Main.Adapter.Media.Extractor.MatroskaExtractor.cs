using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/MatroskaExtractor", DoNotGenerateAcw=true)]
	public partial class MatroskaExtractor : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1 {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory Factory {
			get {
				const string __id = "FACTORY.Lcom/example/androidtvlibrary/main/adapter/mp3/ExtractorsFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/field[@name='FLAG_DISABLE_SEEK_FOR_CUES']"
		[Register ("FLAG_DISABLE_SEEK_FOR_CUES")]
		public const int FlagDisableSeekForCues = (int) 1;

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.Media.Extractor

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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='MatroskaExtractor.Flags']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/MatroskaExtractor$Flags", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor/IFlagsInvoker")]
		public partial interface IFlags : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/MatroskaExtractor$Flags", DoNotGenerateAcw=true)]
		internal partial class IFlagsInvoker : global::Java.Lang.Object, IFlags {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/MatroskaExtractor$Flags", typeof (IFlagsInvoker));

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

			public static IFlags GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFlags> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.MatroskaExtractor.Flags'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFlagsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/MatroskaExtractor", typeof (MatroskaExtractor));

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

		protected MatroskaExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/constructor[@name='MatroskaExtractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MatroskaExtractor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/constructor[@name='MatroskaExtractor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MatroskaExtractor ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor", Fields = new string [] {"FlagDisableSeekForCues"})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
#pragma warning disable 0169
		static Delegate GetBinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler ()
		{
			if (cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == null)
				cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_BinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_);
			return cb_binaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		}

		static void n_BinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ (IntPtr jnienv, IntPtr native__this, int id, int contentSize, IntPtr native_input)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_input, JniHandleOwnership.DoNotTransfer);
			__this.BinaryElement (id, contentSize, input);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='binaryElement' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("binaryElement", "(IILcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)V", "GetBinaryElement_IILcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler")]
		protected virtual unsafe void BinaryElement (int id, int contentSize, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "binaryElement.(IILcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (contentSize);
				__args [2] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		static Delegate cb_endMasterElement_I;
#pragma warning disable 0169
		static Delegate GetEndMasterElement_IHandler ()
		{
			if (cb_endMasterElement_I == null)
				cb_endMasterElement_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_EndMasterElement_I);
			return cb_endMasterElement_I;
		}

		static void n_EndMasterElement_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndMasterElement (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='endMasterElement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("endMasterElement", "(I)V", "GetEndMasterElement_IHandler")]
		protected virtual unsafe void EndMasterElement (int id)
		{
			const string __id = "endMasterElement.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_floatElement_ID;
#pragma warning disable 0169
		static Delegate GetFloatElement_IDHandler ()
		{
			if (cb_floatElement_ID == null)
				cb_floatElement_ID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPID_V) n_FloatElement_ID);
			return cb_floatElement_ID;
		}

		static void n_FloatElement_ID (IntPtr jnienv, IntPtr native__this, int id, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FloatElement (id, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='floatElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("floatElement", "(ID)V", "GetFloatElement_IDHandler")]
		protected virtual unsafe void FloatElement (int id, double value)
		{
			const string __id = "floatElement.(ID)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getElementType_I;
#pragma warning disable 0169
		static Delegate GetGetElementType_IHandler ()
		{
			if (cb_getElementType_I == null)
				cb_getElementType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetElementType_I);
			return cb_getElementType_I;
		}

		static int n_GetElementType_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetElementType (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='getElementType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getElementType", "(I)I", "GetGetElementType_IHandler")]
		protected virtual unsafe int GetElementType (int id)
		{
			const string __id = "getElementType.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V", "")]
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput output)
		{
			const string __id = "init.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (output);
			}
		}

		static Delegate cb_integerElement_IJ;
#pragma warning disable 0169
		static Delegate GetIntegerElement_IJHandler ()
		{
			if (cb_integerElement_IJ == null)
				cb_integerElement_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_V) n_IntegerElement_IJ);
			return cb_integerElement_IJ;
		}

		static void n_IntegerElement_IJ (IntPtr jnienv, IntPtr native__this, int id, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IntegerElement (id, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='integerElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("integerElement", "(IJ)V", "GetIntegerElement_IJHandler")]
		protected virtual unsafe void IntegerElement (int id, long value)
		{
			const string __id = "integerElement.(IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isLevel1Element_I;
#pragma warning disable 0169
		static Delegate GetIsLevel1Element_IHandler ()
		{
			if (cb_isLevel1Element_I == null)
				cb_isLevel1Element_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsLevel1Element_I);
			return cb_isLevel1Element_I;
		}

		static bool n_IsLevel1Element_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLevel1Element (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='isLevel1Element' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLevel1Element", "(I)Z", "GetIsLevel1Element_IHandler")]
		protected virtual unsafe bool IsLevel1Element (int id)
		{
			const string __id = "isLevel1Element.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.PositionHolder']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I", "")]
		public unsafe int Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder seekPosition)
		{
			const string __id = "read.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((seekPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekPosition).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (seekPosition);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_seek_JJ;
#pragma warning disable 0169
		static Delegate GetSeek_JJHandler ()
		{
			if (cb_seek_JJ == null)
				cb_seek_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_Seek_JJ);
			return cb_seek_JJ;
		}

		static void n_Seek_JJ (IntPtr jnienv, IntPtr native__this, long position, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek (position, timeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='seek' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("seek", "(JJ)V", "GetSeek_JJHandler")]
		public virtual unsafe void Seek (long position, long timeUs)
		{
			const string __id = "seek.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (timeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("sniff", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "")]
		public unsafe bool Sniff (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "sniff.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		static Delegate cb_startMasterElement_IJJ;
#pragma warning disable 0169
		static Delegate GetStartMasterElement_IJJHandler ()
		{
			if (cb_startMasterElement_IJJ == null)
				cb_startMasterElement_IJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJJ_V) n_StartMasterElement_IJJ);
			return cb_startMasterElement_IJJ;
		}

		static void n_StartMasterElement_IJJ (IntPtr jnienv, IntPtr native__this, int id, long contentPosition, long contentSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartMasterElement (id, contentPosition, contentSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='startMasterElement' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("startMasterElement", "(IJJ)V", "GetStartMasterElement_IJJHandler")]
		protected virtual unsafe void StartMasterElement (int id, long contentPosition, long contentSize)
		{
			const string __id = "startMasterElement.(IJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (contentPosition);
				__args [2] = new JniArgumentValue (contentSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stringElement_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStringElement_ILjava_lang_String_Handler ()
		{
			if (cb_stringElement_ILjava_lang_String_ == null)
				cb_stringElement_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_StringElement_ILjava_lang_String_);
			return cb_stringElement_ILjava_lang_String_;
		}

		static void n_StringElement_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.StringElement (id, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='MatroskaExtractor']/method[@name='stringElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("stringElement", "(ILjava/lang/String;)V", "GetStringElement_ILjava_lang_String_Handler")]
		protected virtual unsafe void StringElement (int id, string value)
		{
			const string __id = "stringElement.(ILjava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
