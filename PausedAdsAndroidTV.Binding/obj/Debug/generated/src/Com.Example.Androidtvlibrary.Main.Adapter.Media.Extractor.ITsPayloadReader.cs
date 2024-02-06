using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.DvbSubtitleInfo']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$DvbSubtitleInfo", DoNotGenerateAcw=true)]
	public sealed partial class TsPayloadReaderDvbSubtitleInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.DvbSubtitleInfo']/field[@name='initializationData']"
		[Register ("initializationData")]
		public IList<byte> InitializationData {
			get {
				const string __id = "initializationData.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "initializationData.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.DvbSubtitleInfo']/field[@name='language']"
		[Register ("language")]
		public string Language {
			get {
				const string __id = "language.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "language.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.DvbSubtitleInfo']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				const string __id = "type.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "type.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$DvbSubtitleInfo", typeof (TsPayloadReaderDvbSubtitleInfo));

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

		internal TsPayloadReaderDvbSubtitleInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.DvbSubtitleInfo']/constructor[@name='TsPayloadReader.DvbSubtitleInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;I[B)V", "")]
		public unsafe TsPayloadReaderDvbSubtitleInfo (string language, int type, byte[] initializationData) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_language = JNIEnv.NewString (language);
			IntPtr native_initializationData = JNIEnv.NewArray (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_language);
				__args [1] = new JniArgumentValue (type);
				__args [2] = new JniArgumentValue (native_initializationData);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
				if (initializationData != null) {
					JNIEnv.CopyArray (native_initializationData, initializationData);
					JNIEnv.DeleteLocalRef (native_initializationData);
				}
				global::System.GC.KeepAlive (initializationData);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.EsInfo']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo", DoNotGenerateAcw=true)]
	public sealed partial class TsPayloadReaderEsInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.EsInfo']/field[@name='descriptorBytes']"
		[Register ("descriptorBytes")]
		public IList<byte> DescriptorBytes {
			get {
				const string __id = "descriptorBytes.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "descriptorBytes.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.EsInfo']/field[@name='dvbSubtitleInfos']"
		[Register ("dvbSubtitleInfos")]
		public global::System.Collections.IList DvbSubtitleInfos {
			get {
				const string __id = "dvbSubtitleInfos.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dvbSubtitleInfos.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.EsInfo']/field[@name='language']"
		[Register ("language")]
		public string Language {
			get {
				const string __id = "language.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "language.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.EsInfo']/field[@name='streamType']"
		[Register ("streamType")]
		public int StreamType {
			get {
				const string __id = "streamType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "streamType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo", typeof (TsPayloadReaderEsInfo));

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

		internal TsPayloadReaderEsInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.EsInfo']/constructor[@name='TsPayloadReader.EsInfo' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.DvbSubtitleInfo&gt;'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/util/List;[B)V", "")]
		public unsafe TsPayloadReaderEsInfo (int streamType, string language, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderDvbSubtitleInfo> dvbSubtitleInfos, byte[] descriptorBytes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/util/List;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_language = JNIEnv.NewString (language);
			IntPtr native_dvbSubtitleInfos = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderDvbSubtitleInfo>.ToLocalJniHandle (dvbSubtitleInfos);
			IntPtr native_descriptorBytes = JNIEnv.NewArray (descriptorBytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (streamType);
				__args [1] = new JniArgumentValue (native_language);
				__args [2] = new JniArgumentValue (native_dvbSubtitleInfos);
				__args [3] = new JniArgumentValue (native_descriptorBytes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
				JNIEnv.DeleteLocalRef (native_dvbSubtitleInfos);
				if (descriptorBytes != null) {
					JNIEnv.CopyArray (native_descriptorBytes, descriptorBytes);
					JNIEnv.DeleteLocalRef (native_descriptorBytes);
				}
				global::System.GC.KeepAlive (dvbSubtitleInfos);
				global::System.GC.KeepAlive (descriptorBytes);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader.Factory']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$Factory", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFactoryInvoker")]
	public partial interface ITsPayloadReaderFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader.Factory']/method[@name='createInitialPayloadReaders' and count(parameter)=0]"
		[Register ("createInitialPayloadReaders", "()Landroid/util/SparseArray;", "GetCreateInitialPayloadReadersHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Android.Util.SparseArray CreateInitialPayloadReaders ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader.Factory']/method[@name='createPayloadReader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.EsInfo']]"
		[Register ("createPayloadReader", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader;", "GetCreatePayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader CreatePayloadReader (int p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderEsInfo p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$Factory", DoNotGenerateAcw=true)]
	internal partial class ITsPayloadReaderFactoryInvoker : global::Java.Lang.Object, ITsPayloadReaderFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$Factory", typeof (ITsPayloadReaderFactoryInvoker));

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

		public static ITsPayloadReaderFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITsPayloadReaderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.Factory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITsPayloadReaderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createInitialPayloadReaders;
#pragma warning disable 0169
		static Delegate GetCreateInitialPayloadReadersHandler ()
		{
			if (cb_createInitialPayloadReaders == null)
				cb_createInitialPayloadReaders = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateInitialPayloadReaders);
			return cb_createInitialPayloadReaders;
		}

		static IntPtr n_CreateInitialPayloadReaders (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateInitialPayloadReaders ());
		}
#pragma warning restore 0169

		IntPtr id_createInitialPayloadReaders;
		public unsafe global::Android.Util.SparseArray CreateInitialPayloadReaders ()
		{
			if (id_createInitialPayloadReaders == IntPtr.Zero)
				id_createInitialPayloadReaders = JNIEnv.GetMethodID (class_ref, "createInitialPayloadReaders", "()Landroid/util/SparseArray;");
			return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createInitialPayloadReaders), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_;
#pragma warning disable 0169
		static Delegate GetCreatePayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_Handler ()
		{
			if (cb_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_ == null)
				cb_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_CreatePayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_);
			return cb_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_;
		}

		static IntPtr n_CreatePayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderEsInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePayloadReader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader CreatePayloadReader (int p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderEsInfo p1)
		{
			if (id_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_ == IntPtr.Zero)
				id_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_ = JNIEnv.GetMethodID (class_ref, "createPayloadReader", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPayloadReader_ILcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_EsInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader.Flags']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$Flags", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFlagsInvoker")]
	public partial interface ITsPayloadReaderFlags : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$Flags", DoNotGenerateAcw=true)]
	internal partial class ITsPayloadReaderFlagsInvoker : global::Java.Lang.Object, ITsPayloadReaderFlags {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$Flags", typeof (ITsPayloadReaderFlagsInvoker));

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

		public static ITsPayloadReaderFlags GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITsPayloadReaderFlags> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.Flags'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITsPayloadReaderFlagsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.TrackIdGenerator']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator", DoNotGenerateAcw=true)]
	public sealed partial class TsPayloadReaderTrackIdGenerator : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator", typeof (TsPayloadReaderTrackIdGenerator));

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

		internal TsPayloadReaderTrackIdGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.TrackIdGenerator']/constructor[@name='TsPayloadReader.TrackIdGenerator' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe TsPayloadReaderTrackIdGenerator (int firstTrackId, int trackIdIncrement) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstTrackId);
				__args [1] = new JniArgumentValue (trackIdIncrement);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.TrackIdGenerator']/constructor[@name='TsPayloadReader.TrackIdGenerator' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe TsPayloadReaderTrackIdGenerator (int programNumber, int firstTrackId, int trackIdIncrement) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (programNumber);
				__args [1] = new JniArgumentValue (firstTrackId);
				__args [2] = new JniArgumentValue (trackIdIncrement);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string FormatId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.TrackIdGenerator']/method[@name='getFormatId' and count(parameter)=0]"
			[Register ("getFormatId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFormatId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.TrackIdGenerator']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()I", "")]
			get {
				const string __id = "getTrackId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TsPayloadReader.TrackIdGenerator']/method[@name='generateNewId' and count(parameter)=0]"
		[Register ("generateNewId", "()V", "")]
		public unsafe void GenerateNewId ()
		{
			const string __id = "generateNewId.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader", DoNotGenerateAcw=true)]
	public abstract class TsPayloadReader : Java.Lang.Object {
		internal TsPayloadReader ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']/field[@name='FLAG_DATA_ALIGNMENT_INDICATOR']"
		[Register ("FLAG_DATA_ALIGNMENT_INDICATOR")]
		public const int FlagDataAlignmentIndicator = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']/field[@name='FLAG_PAYLOAD_UNIT_START_INDICATOR']"
		[Register ("FLAG_PAYLOAD_UNIT_START_INDICATOR")]
		public const int FlagPayloadUnitStartIndicator = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']/field[@name='FLAG_RANDOM_ACCESS_INDICATOR']"
		[Register ("FLAG_RANDOM_ACCESS_INDICATOR")]
		public const int FlagRandomAccessIndicator = (int) 2;

	}

	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TsPayloadReader' type. This type will be removed in a future release.", error: true)]
	public abstract class TsPayloadReaderConsts : TsPayloadReader {
		private TsPayloadReaderConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderInvoker")]
	public partial interface ITsPayloadReader : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']/method[@name='consume' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V", "GetConsume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader", Fields = new string [] {"FlagPayloadUnitStartIndicator", "FlagRandomAccessIndicator", "FlagDataAlignmentIndicator"})]
		int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.TrackIdGenerator']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V", "GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TimestampAdjuster_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_TsPayloadReader_TrackIdGenerator_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='TsPayloadReader']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "GetSeekHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReaderInvoker, PausedAdsAndroidTV.Binding")]
		void Seek ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader", DoNotGenerateAcw=true)]
	internal partial class ITsPayloadReaderInvoker : global::Java.Lang.Object, ITsPayloadReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader", typeof (ITsPayloadReaderInvoker));

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

		public static ITsPayloadReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITsPayloadReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITsPayloadReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
#pragma warning disable 0169
		static Delegate GetConsume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler ()
		{
			if (cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I == null)
				cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_Consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I);
			return cb_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
		}

		static void n_Consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Consume (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
		public unsafe void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader", Fields = new string [] {"FlagPayloadUnitStartIndicator", "FlagRandomAccessIndicator", "FlagDataAlignmentIndicator"})]
		int p1)
		{
			if (id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I == IntPtr.Zero)
				id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I = JNIEnv.GetMethodID (class_ref, "consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consume_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
