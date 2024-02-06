using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Track", DoNotGenerateAcw=true)]
	public sealed partial class Track : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='durationUs']"
		[Register ("durationUs")]
		public long DurationUs {
			get {
				const string __id = "durationUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "durationUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='editListDurations']"
		[Register ("editListDurations")]
		public IList<long> EditListDurations {
			get {
				const string __id = "editListDurations.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "editListDurations.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='editListMediaTimes']"
		[Register ("editListMediaTimes")]
		public IList<long> EditListMediaTimes {
			get {
				const string __id = "editListMediaTimes.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "editListMediaTimes.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='format']"
		[Register ("format")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Format Format {
			get {
				const string __id = "format.Lcom/example/androidtvlibrary/main/adapter/Format;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "format.Lcom/example/androidtvlibrary/main/adapter/Format;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='id']"
		[Register ("id")]
		public int Id {
			get {
				const string __id = "id.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "id.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='movieTimescale']"
		[Register ("movieTimescale")]
		public long MovieTimescale {
			get {
				const string __id = "movieTimescale.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "movieTimescale.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='nalUnitLengthFieldLength']"
		[Register ("nalUnitLengthFieldLength")]
		public int NalUnitLengthFieldLength {
			get {
				const string __id = "nalUnitLengthFieldLength.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "nalUnitLengthFieldLength.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='sampleTransformation']"
		[Register ("sampleTransformation")]
		public int SampleTransformation {
			get {
				const string __id = "sampleTransformation.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sampleTransformation.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='timescale']"
		[Register ("timescale")]
		public long Timescale {
			get {
				const string __id = "timescale.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timescale.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='TRANSFORMATION_CEA608_CDAT']"
		[Register ("TRANSFORMATION_CEA608_CDAT")]
		public const int TransformationCea608Cdat = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='TRANSFORMATION_NONE']"
		[Register ("TRANSFORMATION_NONE")]
		public const int TransformationNone = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/field[@name='type']"
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='Track.Transformation']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Track$Transformation", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track/ITransformationInvoker")]
		public partial interface ITransformation : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Track$Transformation", DoNotGenerateAcw=true)]
		internal partial class ITransformationInvoker : global::Java.Lang.Object, ITransformation {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Track$Transformation", typeof (ITransformationInvoker));

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

			public static ITransformation GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITransformation> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.Track.Transformation'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITransformationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track.ITransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track.ITransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track.ITransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track.ITransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Track", typeof (Track));

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

		internal Track (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/constructor[@name='Track' and count(parameter)=11 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[7][@type='int'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TrackEncryptionBox[]'] and parameter[9][@type='int'] and parameter[10][@type='long[]'] and parameter[11][@type='long[]']]"
		[Register (".ctor", "(IIJJJLcom/example/androidtvlibrary/main/adapter/Format;I[Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox;I[J[J)V", "")]
		public unsafe Track (int id, int type, long timescale, long movieTimescale, long durationUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track", Fields = new string [] {"TransformationNone", "TransformationCea608Cdat"})]
		int sampleTransformation, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TrackEncryptionBox[] sampleDescriptionEncryptionBoxes, int nalUnitLengthFieldLength, long[] editListDurations, long[] editListMediaTimes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIJJJLcom/example/androidtvlibrary/main/adapter/Format;I[Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox;I[J[J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sampleDescriptionEncryptionBoxes = JNIEnv.NewArray (sampleDescriptionEncryptionBoxes);
			IntPtr native_editListDurations = JNIEnv.NewArray (editListDurations);
			IntPtr native_editListMediaTimes = JNIEnv.NewArray (editListMediaTimes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (type);
				__args [2] = new JniArgumentValue (timescale);
				__args [3] = new JniArgumentValue (movieTimescale);
				__args [4] = new JniArgumentValue (durationUs);
				__args [5] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [6] = new JniArgumentValue (sampleTransformation);
				__args [7] = new JniArgumentValue (native_sampleDescriptionEncryptionBoxes);
				__args [8] = new JniArgumentValue (nalUnitLengthFieldLength);
				__args [9] = new JniArgumentValue (native_editListDurations);
				__args [10] = new JniArgumentValue (native_editListMediaTimes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (sampleDescriptionEncryptionBoxes != null) {
					JNIEnv.CopyArray (native_sampleDescriptionEncryptionBoxes, sampleDescriptionEncryptionBoxes);
					JNIEnv.DeleteLocalRef (native_sampleDescriptionEncryptionBoxes);
				}
				if (editListDurations != null) {
					JNIEnv.CopyArray (native_editListDurations, editListDurations);
					JNIEnv.DeleteLocalRef (native_editListDurations);
				}
				if (editListMediaTimes != null) {
					JNIEnv.CopyArray (native_editListMediaTimes, editListMediaTimes);
					JNIEnv.DeleteLocalRef (native_editListMediaTimes);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (sampleDescriptionEncryptionBoxes);
				global::System.GC.KeepAlive (editListDurations);
				global::System.GC.KeepAlive (editListMediaTimes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/method[@name='copyWithFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("copyWithFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track CopyWithFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "copyWithFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Track']/method[@name='getSampleDescriptionEncryptionBox' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSampleDescriptionEncryptionBox", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TrackEncryptionBox GetSampleDescriptionEncryptionBox (int sampleDescriptionIndex)
		{
			const string __id = "getSampleDescriptionEncryptionBox.(I)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sampleDescriptionIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TrackEncryptionBox> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
