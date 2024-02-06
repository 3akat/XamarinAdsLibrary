using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultTsPayloadReaderFactory", DoNotGenerateAcw=true)]
	public sealed partial class DefaultTsPayloadReaderFactory : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFactory {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_ALLOW_NON_IDR_KEYFRAMES']"
		[Register ("FLAG_ALLOW_NON_IDR_KEYFRAMES")]
		public const int FlagAllowNonIdrKeyframes = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_DETECT_ACCESS_UNITS']"
		[Register ("FLAG_DETECT_ACCESS_UNITS")]
		public const int FlagDetectAccessUnits = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_ENABLE_HDMV_DTS_AUDIO_STREAMS']"
		[Register ("FLAG_ENABLE_HDMV_DTS_AUDIO_STREAMS")]
		public const int FlagEnableHdmvDtsAudioStreams = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_IGNORE_AAC_STREAM']"
		[Register ("FLAG_IGNORE_AAC_STREAM")]
		public const int FlagIgnoreAacStream = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_IGNORE_H264_STREAM']"
		[Register ("FLAG_IGNORE_H264_STREAM")]
		public const int FlagIgnoreH264Stream = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_IGNORE_SPLICE_INFO_STREAM']"
		[Register ("FLAG_IGNORE_SPLICE_INFO_STREAM")]
		public const int FlagIgnoreSpliceInfoStream = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/field[@name='FLAG_OVERRIDE_CAPTION_DESCRIPTORS']"
		[Register ("FLAG_OVERRIDE_CAPTION_DESCRIPTORS")]
		public const int FlagOverrideCaptionDescriptors = (int) 32;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='DefaultTsPayloadReaderFactory.Flags']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultTsPayloadReaderFactory$Flags", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory/IFlagsInvoker")]
		public partial interface IFlags : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultTsPayloadReaderFactory$Flags", DoNotGenerateAcw=true)]
		internal partial class IFlagsInvoker : global::Java.Lang.Object, IFlags {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultTsPayloadReaderFactory$Flags", typeof (IFlagsInvoker));

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
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.DefaultTsPayloadReaderFactory.Flags'.");
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultTsPayloadReaderFactory", typeof (DefaultTsPayloadReaderFactory));

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

		internal DefaultTsPayloadReaderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/constructor[@name='DefaultTsPayloadReaderFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultTsPayloadReaderFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/constructor[@name='DefaultTsPayloadReaderFactory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DefaultTsPayloadReaderFactory ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory", Fields = new string [] {"FlagAllowNonIdrKeyframes", "FlagIgnoreAacStream", "FlagIgnoreH264Stream", "FlagDetectAccessUnits", "FlagIgnoreSpliceInfoStream", "FlagOverrideCaptionDescriptors", "FlagEnableHdmvDtsAudioStreams"})]
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/constructor[@name='DefaultTsPayloadReaderFactory' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.Format&gt;']]"
		[Register (".ctor", "(ILjava/util/List;)V", "")]
		public unsafe DefaultTsPayloadReaderFactory ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory", Fields = new string [] {"FlagAllowNonIdrKeyframes", "FlagIgnoreAacStream", "FlagIgnoreH264Stream", "FlagDetectAccessUnits", "FlagIgnoreSpliceInfoStream", "FlagOverrideCaptionDescriptors", "FlagEnableHdmvDtsAudioStreams"})]
		int flags, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> closedCaptionFormats) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_closedCaptionFormats = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format>.ToLocalJniHandle (closedCaptionFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (flags);
				__args [1] = new JniArgumentValue (native_closedCaptionFormats);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_closedCaptionFormats);
				global::System.GC.KeepAlive (closedCaptionFormats);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/method[@name='createInitialPayloadReaders' and count(parameter)=0]"
		[Register ("createInitialPayloadReaders", "()Landroid/util/SparseArray;", "")]
		public unsafe global::Android.Util.SparseArray CreateInitialPayloadReaders ()
		{
			const string __id = "createInitialPayloadReaders.()Landroid/util/SparseArray;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultTsPayloadReaderFactory']/method[@name='createPayloadReader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.EsInfo']]"
		[Register ("createPayloadReader", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader CreatePayloadReader (int streamType, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderEsInfo esInfo)
		{
			const string __id = "createPayloadReader.(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamType);
				__args [1] = new JniArgumentValue ((esInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) esInfo).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (esInfo);
			}
		}

	}
}
