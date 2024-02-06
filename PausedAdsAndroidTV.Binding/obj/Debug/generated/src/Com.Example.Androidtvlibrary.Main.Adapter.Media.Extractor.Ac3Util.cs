using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util", DoNotGenerateAcw=true)]
	public sealed partial class Ac3Util : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/field[@name='TRUEHD_RECHUNK_SAMPLE_COUNT']"
		[Register ("TRUEHD_RECHUNK_SAMPLE_COUNT")]
		public const int TruehdRechunkSampleCount = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/field[@name='TRUEHD_SYNCFRAME_PREFIX_LENGTH']"
		[Register ("TRUEHD_SYNCFRAME_PREFIX_LENGTH")]
		public const int TruehdSyncframePrefixLength = (int) 10;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo", DoNotGenerateAcw=true)]
		public sealed partial class SyncFrameInfo : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='channelCount']"
			[Register ("channelCount")]
			public int ChannelCount {
				get {
					const string __id = "channelCount.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "channelCount.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='frameSize']"
			[Register ("frameSize")]
			public int FrameSize {
				get {
					const string __id = "frameSize.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "frameSize.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='mimeType']"
			[Register ("mimeType")]
			public string MimeType {
				get {
					const string __id = "mimeType.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mimeType.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='sampleCount']"
			[Register ("sampleCount")]
			public int SampleCount {
				get {
					const string __id = "sampleCount.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sampleCount.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='sampleRate']"
			[Register ("sampleRate")]
			public int SampleRate {
				get {
					const string __id = "sampleRate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sampleRate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='streamType']"
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

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='STREAM_TYPE_TYPE0']"
			[Register ("STREAM_TYPE_TYPE0")]
			public const int StreamTypeType0 = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='STREAM_TYPE_TYPE1']"
			[Register ("STREAM_TYPE_TYPE1")]
			public const int StreamTypeType1 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='STREAM_TYPE_TYPE2']"
			[Register ("STREAM_TYPE_TYPE2")]
			public const int StreamTypeType2 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util.SyncFrameInfo']/field[@name='STREAM_TYPE_UNDEFINED']"
			[Register ("STREAM_TYPE_UNDEFINED")]
			public const int StreamTypeUndefined = (int) -1;

			// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='Ac3Util.SyncFrameInfo.StreamType']"
			[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo$StreamType", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util/SyncFrameInfo/IStreamTypeInvoker")]
			public partial interface IStreamType : global::Java.Lang.Annotation.IAnnotation {
			}

			[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo$StreamType", DoNotGenerateAcw=true)]
			internal partial class IStreamTypeInvoker : global::Java.Lang.Object, IStreamType {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo$StreamType", typeof (IStreamTypeInvoker));

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

				public static IStreamType GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IStreamType> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.Ac3Util.SyncFrameInfo.StreamType'.");
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IStreamTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util.SyncFrameInfo.IStreamType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util.SyncFrameInfo.IStreamType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util.SyncFrameInfo.IStreamType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util.SyncFrameInfo.IStreamType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo", typeof (SyncFrameInfo));

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

			internal SyncFrameInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util", typeof (Ac3Util));

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

		internal Ac3Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='findTrueHdSyncframeOffset' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("findTrueHdSyncframeOffset", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int FindTrueHdSyncframeOffset (global::Java.Nio.ByteBuffer buffer)
		{
			const string __id = "findTrueHdSyncframeOffset.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseAc3AnnexFFormat' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("parseAc3AnnexFFormat", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format ParseAc3AnnexFFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, string trackId, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "parseAc3AnnexFFormat.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_trackId = JNIEnv.NewString (trackId);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (native_trackId);
				__args [2] = new JniArgumentValue (native_language);
				__args [3] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_trackId);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseAc3SyncframeAudioSampleCount' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseAc3SyncframeAudioSampleCount", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ParseAc3SyncframeAudioSampleCount (global::Java.Nio.ByteBuffer buffer)
		{
			const string __id = "parseAc3SyncframeAudioSampleCount.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseAc3SyncframeInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableBitArray']]"
		[Register ("parseAc3SyncframeInfo", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util.SyncFrameInfo ParseAc3SyncframeInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableBitArray data)
		{
			const string __id = "parseAc3SyncframeInfo.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableBitArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Ac3Util$SyncFrameInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Ac3Util.SyncFrameInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseAc3SyncframeSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseAc3SyncframeSize", "([B)I", "")]
		public static unsafe int ParseAc3SyncframeSize (byte[] data)
		{
			const string __id = "parseAc3SyncframeSize.([B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseEAc3AnnexFFormat' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("parseEAc3AnnexFFormat", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format ParseEAc3AnnexFFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, string trackId, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "parseEAc3AnnexFFormat.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_trackId = JNIEnv.NewString (trackId);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (native_trackId);
				__args [2] = new JniArgumentValue (native_language);
				__args [3] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_trackId);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseTrueHdSyncframeAudioSampleCount' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseTrueHdSyncframeAudioSampleCount", "([B)I", "")]
		public static unsafe int ParseTrueHdSyncframeAudioSampleCount (byte[] syncframe)
		{
			const string __id = "parseTrueHdSyncframeAudioSampleCount.([B)I";
			IntPtr native_syncframe = JNIEnv.NewArray (syncframe);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_syncframe);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (syncframe != null) {
					JNIEnv.CopyArray (native_syncframe, syncframe);
					JNIEnv.DeleteLocalRef (native_syncframe);
				}
				global::System.GC.KeepAlive (syncframe);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Ac3Util']/method[@name='parseTrueHdSyncframeAudioSampleCount' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("parseTrueHdSyncframeAudioSampleCount", "(Ljava/nio/ByteBuffer;I)I", "")]
		public static unsafe int ParseTrueHdSyncframeAudioSampleCount (global::Java.Nio.ByteBuffer buffer, int offset)
		{
			const string __id = "parseTrueHdSyncframeAudioSampleCount.(Ljava/nio/ByteBuffer;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

	}
}
