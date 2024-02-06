using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Format", DoNotGenerateAcw=true)]
	public sealed partial class Format : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='accessibilityChannel']"
		[Register ("accessibilityChannel")]
		public int AccessibilityChannel {
			get {
				const string __id = "accessibilityChannel.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "accessibilityChannel.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='bitrate']"
		[Register ("bitrate")]
		public int Bitrate {
			get {
				const string __id = "bitrate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bitrate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='channelCount']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='codecs']"
		[Register ("codecs")]
		public string Codecs {
			get {
				const string __id = "codecs.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "codecs.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='colorInfo']"
		[Register ("colorInfo")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.ColorInfo ColorInfo {
			get {
				const string __id = "colorInfo.Lcom/example/androidtvlibrary/main/adapter/ColorInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ColorInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "colorInfo.Lcom/example/androidtvlibrary/main/adapter/ColorInfo;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='containerMimeType']"
		[Register ("containerMimeType")]
		public string ContainerMimeType {
			get {
				const string __id = "containerMimeType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "containerMimeType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='drmInitData']"
		[Register ("drmInitData")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData DrmInitData {
			get {
				const string __id = "drmInitData.Lcom/example/androidtvlibrary/main/adapter/DrmInitData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "drmInitData.Lcom/example/androidtvlibrary/main/adapter/DrmInitData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='encoderDelay']"
		[Register ("encoderDelay")]
		public int EncoderDelay {
			get {
				const string __id = "encoderDelay.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encoderDelay.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='encoderPadding']"
		[Register ("encoderPadding")]
		public int EncoderPadding {
			get {
				const string __id = "encoderPadding.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encoderPadding.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='exoMediaCryptoType']"
		[Register ("exoMediaCryptoType")]
		public global::Java.Lang.Class ExoMediaCryptoType {
			get {
				const string __id = "exoMediaCryptoType.Ljava/lang/Class;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exoMediaCryptoType.Ljava/lang/Class;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='frameRate']"
		[Register ("frameRate")]
		public float FrameRate {
			get {
				const string __id = "frameRate.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "frameRate.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				const string __id = "id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='initializationData']"
		[Register ("initializationData")]
		public global::System.Collections.IList InitializationData {
			get {
				const string __id = "initializationData.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "initializationData.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='label']"
		[Register ("label")]
		public string Label {
			get {
				const string __id = "label.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "label.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='language']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='maxInputSize']"
		[Register ("maxInputSize")]
		public int MaxInputSize {
			get {
				const string __id = "maxInputSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxInputSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='metadata']"
		[Register ("metadata")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata Metadata {
			get {
				const string __id = "metadata.Lcom/example/androidtvlibrary/main/adapter/Metadata;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "metadata.Lcom/example/androidtvlibrary/main/adapter/Metadata;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='NO_VALUE']"
		[Register ("NO_VALUE")]
		public const int NoValue = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='OFFSET_SAMPLE_RELATIVE']"
		[Register ("OFFSET_SAMPLE_RELATIVE")]
		public const long OffsetSampleRelative = (long) 9223372036854775807;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='pcmEncoding']"
		[Register ("pcmEncoding")]
		public int PcmEncoding {
			get {
				const string __id = "pcmEncoding.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pcmEncoding.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='pixelWidthHeightRatio']"
		[Register ("pixelWidthHeightRatio")]
		public float PixelWidthHeightRatio {
			get {
				const string __id = "pixelWidthHeightRatio.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "pixelWidthHeightRatio.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='projectionData']"
		[Register ("projectionData")]
		public IList<byte> ProjectionData {
			get {
				const string __id = "projectionData.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "projectionData.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='roleFlags']"
		[Register ("roleFlags")]
		public int RoleFlags {
			get {
				const string __id = "roleFlags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "roleFlags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='rotationDegrees']"
		[Register ("rotationDegrees")]
		public int RotationDegrees {
			get {
				const string __id = "rotationDegrees.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rotationDegrees.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='sampleMimeType']"
		[Register ("sampleMimeType")]
		public string SampleMimeType {
			get {
				const string __id = "sampleMimeType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleMimeType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='sampleRate']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='selectionFlags']"
		[Register ("selectionFlags")]
		public int SelectionFlags {
			get {
				const string __id = "selectionFlags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "selectionFlags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='stereoMode']"
		[Register ("stereoMode")]
		public int StereoMode {
			get {
				const string __id = "stereoMode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stereoMode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='subsampleOffsetUs']"
		[Register ("subsampleOffsetUs")]
		public long SubsampleOffsetUs {
			get {
				const string __id = "subsampleOffsetUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subsampleOffsetUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				const string __id = "width.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "width.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Format.ExoMediaCrypto']"
		[Register ("com/example/androidtvlibrary/main/adapter/Format$ExoMediaCrypto", "", "Com.Example.Androidtvlibrary.Main.Adapter.Format/IExoMediaCryptoInvoker")]
		public partial interface IExoMediaCrypto : IJavaObject, IJavaPeerable {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Format$ExoMediaCrypto", DoNotGenerateAcw=true)]
		internal partial class IExoMediaCryptoInvoker : global::Java.Lang.Object, IExoMediaCrypto {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Format$ExoMediaCrypto", typeof (IExoMediaCryptoInvoker));

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

			public static IExoMediaCrypto GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IExoMediaCrypto> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Format.ExoMediaCrypto'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IExoMediaCryptoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Format", typeof (Format));

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

		internal Format (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int PixelCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='getPixelCount' and count(parameter)=0]"
			[Register ("getPixelCount", "()I", "")]
			get {
				const string __id = "getPixelCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='areEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("areEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool AreEqual (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			const string __id = "areEqual.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o1).Handle);
				__args [1] = new JniArgumentValue ((o2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o2).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o1);
				global::System.GC.KeepAlive (o2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithAdjustments' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("copyWithAdjustments", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithAdjustments (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData, global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata)
		{
			const string __id = "copyWithAdjustments.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				__args [1] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drmInitData);
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("copyWithBitrate", "(I)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithBitrate (int bitrate)
		{
			const string __id = "copyWithBitrate.(I)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithContainerInfo' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.Metadata'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='java.lang.String']]"
		[Register ("copyWithContainerInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;IIIIILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithContainerInfo (string id, string label, string sampleMimeType, string codecs, global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata, int bitrate, int width, int height, int channelCount, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language)
		{
			const string __id = "copyWithContainerInfo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;IIIIILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_label = JNIEnv.NewString (label);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (native_sampleMimeType);
				__args [3] = new JniArgumentValue (native_codecs);
				__args [4] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				__args [5] = new JniArgumentValue (bitrate);
				__args [6] = new JniArgumentValue (width);
				__args [7] = new JniArgumentValue (height);
				__args [8] = new JniArgumentValue (channelCount);
				__args [9] = new JniArgumentValue (selectionFlags);
				__args [10] = new JniArgumentValue (native_language);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_label);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithDrmInitData' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("copyWithDrmInitData", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithDrmInitData (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "copyWithDrmInitData.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithExoMediaCryptoType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto&gt;']]"
		[Register ("copyWithExoMediaCryptoType", "(Ljava/lang/Class;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithExoMediaCryptoType (global::Java.Lang.Class exoMediaCryptoType)
		{
			const string __id = "copyWithExoMediaCryptoType.(Ljava/lang/Class;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exoMediaCryptoType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exoMediaCryptoType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (exoMediaCryptoType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithFrameRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("copyWithFrameRate", "(F)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithFrameRate (float frameRate)
		{
			const string __id = "copyWithFrameRate.(F)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (frameRate);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithGaplessInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("copyWithGaplessInfo", "(II)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithGaplessInfo (int encoderDelay, int encoderPadding)
		{
			const string __id = "copyWithGaplessInfo.(II)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (encoderDelay);
				__args [1] = new JniArgumentValue (encoderPadding);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("copyWithLabel", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithLabel (string label)
		{
			const string __id = "copyWithLabel.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithManifestFormatInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("copyWithManifestFormatInfo", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithManifestFormatInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Format manifestFormat)
		{
			const string __id = "copyWithManifestFormatInfo.(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((manifestFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifestFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (manifestFormat);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithMaxInputSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("copyWithMaxInputSize", "(I)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithMaxInputSize (int maxInputSize)
		{
			const string __id = "copyWithMaxInputSize.(I)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxInputSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithMetadata' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("copyWithMetadata", "(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata)
		{
			const string __id = "copyWithMetadata.(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithRotationDegrees' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("copyWithRotationDegrees", "(I)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithRotationDegrees (int rotationDegrees)
		{
			const string __id = "copyWithRotationDegrees.(I)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotationDegrees);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithSubsampleOffsetUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("copyWithSubsampleOffsetUs", "(J)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithSubsampleOffsetUs (long subsampleOffsetUs)
		{
			const string __id = "copyWithSubsampleOffsetUs.(J)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (subsampleOffsetUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='copyWithVideoSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("copyWithVideoSize", "(II)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CopyWithVideoSize (int width, int height)
		{
			const string __id = "copyWithVideoSize.(II)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createAudioContainerFormat' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='java.util.List&lt;byte[]&gt;'] and parameter[9][@type='int'] and parameter[10][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("createAudioContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/util/List;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateAudioContainerFormat (string id, string containerMimeType, string sampleMimeType, string codecs, int bitrate, int channelCount, int sampleRate, global::System.Collections.Generic.IList<byte[]> initializationData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language)
		{
			const string __id = "createAudioContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/util/List;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_containerMimeType);
				__args [2] = new JniArgumentValue (native_sampleMimeType);
				__args [3] = new JniArgumentValue (native_codecs);
				__args [4] = new JniArgumentValue (bitrate);
				__args [5] = new JniArgumentValue (channelCount);
				__args [6] = new JniArgumentValue (sampleRate);
				__args [7] = new JniArgumentValue (native_initializationData);
				__args [8] = new JniArgumentValue (selectionFlags);
				__args [9] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (initializationData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createAudioContainerFormat' and count(parameter)=13 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Metadata'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='java.util.List&lt;byte[]&gt;'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='java.lang.String']]"
		[Register ("createAudioContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;IIILjava/util/List;IILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateAudioContainerFormat (string id, string label, string containerMimeType, string sampleMimeType, string codecs, global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata, int bitrate, int channelCount, int sampleRate, global::System.Collections.Generic.IList<byte[]> initializationData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"RoleFlagMain", "RoleFlagAlternate", "RoleFlagSupplementary", "RoleFlagCommentary", "RoleFlagDub", "RoleFlagEmergency", "RoleFlagCaption", "RoleFlagSubtitle", "RoleFlagSign", "RoleFlagDescribesVideo", "RoleFlagDescribesMusicAndSound", "RoleFlagEnhancedDialogIntelligibility", "RoleFlagTranscribesDialog", "RoleFlagEasyToRead", "RoleFlagTrickPlay"})]
		int roleFlags, string language)
		{
			const string __id = "createAudioContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;IIILjava/util/List;IILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_label = JNIEnv.NewString (label);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [13];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (native_containerMimeType);
				__args [3] = new JniArgumentValue (native_sampleMimeType);
				__args [4] = new JniArgumentValue (native_codecs);
				__args [5] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				__args [6] = new JniArgumentValue (bitrate);
				__args [7] = new JniArgumentValue (channelCount);
				__args [8] = new JniArgumentValue (sampleRate);
				__args [9] = new JniArgumentValue (native_initializationData);
				__args [10] = new JniArgumentValue (selectionFlags);
				__args [11] = new JniArgumentValue (roleFlags);
				__args [12] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_label);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (metadata);
				global::System.GC.KeepAlive (initializationData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createAudioSampleFormat' and count(parameter)=15 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='java.util.List&lt;byte[]&gt;'] and parameter[12][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[13][@type='int'] and parameter[14][@type='java.lang.String'] and parameter[15][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("createAudioSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIIIILjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;ILjava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateAudioSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, int maxInputSize, int channelCount, int sampleRate, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", ""})]
		int pcmEncoding, int encoderDelay, int encoderPadding, global::System.Collections.Generic.IList<byte[]> initializationData, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata)
		{
			const string __id = "createAudioSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIIIILjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;ILjava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [15];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (maxInputSize);
				__args [5] = new JniArgumentValue (channelCount);
				__args [6] = new JniArgumentValue (sampleRate);
				__args [7] = new JniArgumentValue (pcmEncoding);
				__args [8] = new JniArgumentValue (encoderDelay);
				__args [9] = new JniArgumentValue (encoderPadding);
				__args [10] = new JniArgumentValue (native_initializationData);
				__args [11] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				__args [12] = new JniArgumentValue (selectionFlags);
				__args [13] = new JniArgumentValue (native_language);
				__args [14] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (drmInitData);
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createAudioSampleFormat' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.util.List&lt;byte[]&gt;'] and parameter[10][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[11][@type='int'] and parameter[12][@type='java.lang.String']]"
		[Register ("createAudioSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIILjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateAudioSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, int maxInputSize, int channelCount, int sampleRate, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", ""})]
		int pcmEncoding, global::System.Collections.Generic.IList<byte[]> initializationData, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language)
		{
			const string __id = "createAudioSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIILjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (maxInputSize);
				__args [5] = new JniArgumentValue (channelCount);
				__args [6] = new JniArgumentValue (sampleRate);
				__args [7] = new JniArgumentValue (pcmEncoding);
				__args [8] = new JniArgumentValue (native_initializationData);
				__args [9] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				__args [10] = new JniArgumentValue (selectionFlags);
				__args [11] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createAudioSampleFormat' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='java.util.List&lt;byte[]&gt;'] and parameter[9][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[10][@type='int'] and parameter[11][@type='java.lang.String']]"
		[Register ("createAudioSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIILjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateAudioSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, int maxInputSize, int channelCount, int sampleRate, global::System.Collections.Generic.IList<byte[]> initializationData, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language)
		{
			const string __id = "createAudioSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIILjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (maxInputSize);
				__args [5] = new JniArgumentValue (channelCount);
				__args [6] = new JniArgumentValue (sampleRate);
				__args [7] = new JniArgumentValue (native_initializationData);
				__args [8] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				__args [9] = new JniArgumentValue (selectionFlags);
				__args [10] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createContainerFormat' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("createContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateContainerFormat (string id, string containerMimeType, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language)
		{
			const string __id = "createContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_containerMimeType);
				__args [2] = new JniArgumentValue (native_sampleMimeType);
				__args [3] = new JniArgumentValue (native_codecs);
				__args [4] = new JniArgumentValue (bitrate);
				__args [5] = new JniArgumentValue (selectionFlags);
				__args [6] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createContainerFormat' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String']]"
		[Register ("createContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateContainerFormat (string id, string label, string containerMimeType, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"RoleFlagMain", "RoleFlagAlternate", "RoleFlagSupplementary", "RoleFlagCommentary", "RoleFlagDub", "RoleFlagEmergency", "RoleFlagCaption", "RoleFlagSubtitle", "RoleFlagSign", "RoleFlagDescribesVideo", "RoleFlagDescribesMusicAndSound", "RoleFlagEnhancedDialogIntelligibility", "RoleFlagTranscribesDialog", "RoleFlagEasyToRead", "RoleFlagTrickPlay"})]
		int roleFlags, string language)
		{
			const string __id = "createContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_label = JNIEnv.NewString (label);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (native_containerMimeType);
				__args [3] = new JniArgumentValue (native_sampleMimeType);
				__args [4] = new JniArgumentValue (native_codecs);
				__args [5] = new JniArgumentValue (bitrate);
				__args [6] = new JniArgumentValue (selectionFlags);
				__args [7] = new JniArgumentValue (roleFlags);
				__args [8] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_label);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createImageSampleFormat' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;byte[]&gt;'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createImageSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/util/List;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateImageSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, global::System.Collections.Generic.IList<byte[]> initializationData, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createImageSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/util/List;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (selectionFlags);
				__args [5] = new JniArgumentValue (native_initializationData);
				__args [6] = new JniArgumentValue (native_language);
				__args [7] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createSampleFormat' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createSampleFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("createSampleFormat", "(Ljava/lang/String;Ljava/lang/String;J)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateSampleFormat (string id, string sampleMimeType, long subsampleOffsetUs)
		{
			const string __id = "createSampleFormat.(Ljava/lang/String;Ljava/lang/String;J)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (subsampleOffsetUs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextContainerFormat' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String']]"
		[Register ("createTextContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextContainerFormat (string id, string label, string containerMimeType, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"RoleFlagMain", "RoleFlagAlternate", "RoleFlagSupplementary", "RoleFlagCommentary", "RoleFlagDub", "RoleFlagEmergency", "RoleFlagCaption", "RoleFlagSubtitle", "RoleFlagSign", "RoleFlagDescribesVideo", "RoleFlagDescribesMusicAndSound", "RoleFlagEnhancedDialogIntelligibility", "RoleFlagTranscribesDialog", "RoleFlagEasyToRead", "RoleFlagTrickPlay"})]
		int roleFlags, string language)
		{
			const string __id = "createTextContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_label = JNIEnv.NewString (label);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (native_containerMimeType);
				__args [3] = new JniArgumentValue (native_sampleMimeType);
				__args [4] = new JniArgumentValue (native_codecs);
				__args [5] = new JniArgumentValue (bitrate);
				__args [6] = new JniArgumentValue (selectionFlags);
				__args [7] = new JniArgumentValue (roleFlags);
				__args [8] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_label);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextContainerFormat' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='int']]"
		[Register ("createTextContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;I)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextContainerFormat (string id, string label, string containerMimeType, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"RoleFlagMain", "RoleFlagAlternate", "RoleFlagSupplementary", "RoleFlagCommentary", "RoleFlagDub", "RoleFlagEmergency", "RoleFlagCaption", "RoleFlagSubtitle", "RoleFlagSign", "RoleFlagDescribesVideo", "RoleFlagDescribesMusicAndSound", "RoleFlagEnhancedDialogIntelligibility", "RoleFlagTranscribesDialog", "RoleFlagEasyToRead", "RoleFlagTrickPlay"})]
		int roleFlags, string language, int accessibilityChannel)
		{
			const string __id = "createTextContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;I)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_label = JNIEnv.NewString (label);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (native_containerMimeType);
				__args [3] = new JniArgumentValue (native_sampleMimeType);
				__args [4] = new JniArgumentValue (native_codecs);
				__args [5] = new JniArgumentValue (bitrate);
				__args [6] = new JniArgumentValue (selectionFlags);
				__args [7] = new JniArgumentValue (roleFlags);
				__args [8] = new JniArgumentValue (native_language);
				__args [9] = new JniArgumentValue (accessibilityChannel);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_label);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextSampleFormat' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("createTextSampleFormat", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextSampleFormat (string id, string sampleMimeType, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language)
		{
			const string __id = "createTextSampleFormat.(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (selectionFlags);
				__args [3] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextSampleFormat' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createTextSampleFormat", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextSampleFormat (string id, string sampleMimeType, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createTextSampleFormat.(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (selectionFlags);
				__args [3] = new JniArgumentValue (native_language);
				__args [4] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextSampleFormat' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[8][@type='long']]"
		[Register ("createTextSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;J)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData, long subsampleOffsetUs)
		{
			const string __id = "createTextSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;J)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (selectionFlags);
				__args [5] = new JniArgumentValue (native_language);
				__args [6] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				__args [7] = new JniArgumentValue (subsampleOffsetUs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextSampleFormat' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createTextSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;ILcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language, int accessibilityChannel, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createTextSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;ILcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (selectionFlags);
				__args [5] = new JniArgumentValue (native_language);
				__args [6] = new JniArgumentValue (accessibilityChannel);
				__args [7] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createTextSampleFormat' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[9][@type='long'] and parameter[10][@type='java.util.List&lt;byte[]&gt;']]"
		[Register ("createTextSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;ILcom/example/androidtvlibrary/main/adapter/DrmInitData;JLjava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateTextSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, string language, int accessibilityChannel, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData, long subsampleOffsetUs, global::System.Collections.Generic.IList<byte[]> initializationData)
		{
			const string __id = "createTextSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/String;ILcom/example/androidtvlibrary/main/adapter/DrmInitData;JLjava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_language = JNIEnv.NewString (language);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (selectionFlags);
				__args [5] = new JniArgumentValue (native_language);
				__args [6] = new JniArgumentValue (accessibilityChannel);
				__args [7] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				__args [8] = new JniArgumentValue (subsampleOffsetUs);
				__args [9] = new JniArgumentValue (native_initializationData);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_language);
				JNIEnv.DeleteLocalRef (native_initializationData);
				global::System.GC.KeepAlive (drmInitData);
				global::System.GC.KeepAlive (initializationData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createVideoContainerFormat' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='float'] and parameter[9][@type='java.util.List&lt;byte[]&gt;'] and parameter[10][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("createVideoContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIFLjava/util/List;I)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateVideoContainerFormat (string id, string containerMimeType, string sampleMimeType, string codecs, int bitrate, int width, int height, float frameRate, global::System.Collections.Generic.IList<byte[]> initializationData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags)
		{
			const string __id = "createVideoContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIFLjava/util/List;I)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_containerMimeType);
				__args [2] = new JniArgumentValue (native_sampleMimeType);
				__args [3] = new JniArgumentValue (native_codecs);
				__args [4] = new JniArgumentValue (bitrate);
				__args [5] = new JniArgumentValue (width);
				__args [6] = new JniArgumentValue (height);
				__args [7] = new JniArgumentValue (frameRate);
				__args [8] = new JniArgumentValue (native_initializationData);
				__args [9] = new JniArgumentValue (selectionFlags);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				global::System.GC.KeepAlive (initializationData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createVideoContainerFormat' and count(parameter)=13 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Metadata'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='float'] and parameter[11][@type='java.util.List&lt;byte[]&gt;'] and parameter[12][@type='int'] and parameter[13][@type='int']]"
		[Register ("createVideoContainerFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;IIIFLjava/util/List;II)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateVideoContainerFormat (string id, string label, string containerMimeType, string sampleMimeType, string codecs, global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata metadata, int bitrate, int width, int height, float frameRate, global::System.Collections.Generic.IList<byte[]> initializationData, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"SelectionFlagDefault", "SelectionFlagForced", "SelectionFlagAutoselect"})]
		int selectionFlags, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"RoleFlagMain", "RoleFlagAlternate", "RoleFlagSupplementary", "RoleFlagCommentary", "RoleFlagDub", "RoleFlagEmergency", "RoleFlagCaption", "RoleFlagSubtitle", "RoleFlagSign", "RoleFlagDescribesVideo", "RoleFlagDescribesMusicAndSound", "RoleFlagEnhancedDialogIntelligibility", "RoleFlagTranscribesDialog", "RoleFlagEasyToRead", "RoleFlagTrickPlay"})]
		int roleFlags)
		{
			const string __id = "createVideoContainerFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/example/androidtvlibrary/main/adapter/Metadata;IIIFLjava/util/List;II)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_label = JNIEnv.NewString (label);
			IntPtr native_containerMimeType = JNIEnv.NewString (containerMimeType);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [13];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (native_containerMimeType);
				__args [3] = new JniArgumentValue (native_sampleMimeType);
				__args [4] = new JniArgumentValue (native_codecs);
				__args [5] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				__args [6] = new JniArgumentValue (bitrate);
				__args [7] = new JniArgumentValue (width);
				__args [8] = new JniArgumentValue (height);
				__args [9] = new JniArgumentValue (frameRate);
				__args [10] = new JniArgumentValue (native_initializationData);
				__args [11] = new JniArgumentValue (selectionFlags);
				__args [12] = new JniArgumentValue (roleFlags);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_label);
				JNIEnv.DeleteLocalRef (native_containerMimeType);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				global::System.GC.KeepAlive (metadata);
				global::System.GC.KeepAlive (initializationData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createVideoSampleFormat' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='float'] and parameter[9][@type='java.util.List&lt;byte[]&gt;'] and parameter[10][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createVideoSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIFLjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateVideoSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, int maxInputSize, int width, int height, float frameRate, global::System.Collections.Generic.IList<byte[]> initializationData, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createVideoSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIFLjava/util/List;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (maxInputSize);
				__args [5] = new JniArgumentValue (width);
				__args [6] = new JniArgumentValue (height);
				__args [7] = new JniArgumentValue (frameRate);
				__args [8] = new JniArgumentValue (native_initializationData);
				__args [9] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createVideoSampleFormat' and count(parameter)=15 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='float'] and parameter[9][@type='java.util.List&lt;byte[]&gt;'] and parameter[10][@type='int'] and parameter[11][@type='float'] and parameter[12][@type='byte[]'] and parameter[13][@type='int'] and parameter[14][@type='com.example.androidtvlibrary.main.adapter.ColorInfo'] and parameter[15][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createVideoSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIFLjava/util/List;IF[BILcom/example/androidtvlibrary/main/adapter/ColorInfo;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateVideoSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, int maxInputSize, int width, int height, float frameRate, global::System.Collections.Generic.IList<byte[]> initializationData, int rotationDegrees, float pixelWidthHeightRatio, byte[] projectionData, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", ""})]
		int stereoMode, global::Com.Example.Androidtvlibrary.Main.Adapter.ColorInfo colorInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createVideoSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIFLjava/util/List;IF[BILcom/example/androidtvlibrary/main/adapter/ColorInfo;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			IntPtr native_projectionData = JNIEnv.NewArray (projectionData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [15];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (maxInputSize);
				__args [5] = new JniArgumentValue (width);
				__args [6] = new JniArgumentValue (height);
				__args [7] = new JniArgumentValue (frameRate);
				__args [8] = new JniArgumentValue (native_initializationData);
				__args [9] = new JniArgumentValue (rotationDegrees);
				__args [10] = new JniArgumentValue (pixelWidthHeightRatio);
				__args [11] = new JniArgumentValue (native_projectionData);
				__args [12] = new JniArgumentValue (stereoMode);
				__args [13] = new JniArgumentValue ((colorInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorInfo).Handle);
				__args [14] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				if (projectionData != null) {
					JNIEnv.CopyArray (native_projectionData, projectionData);
					JNIEnv.DeleteLocalRef (native_projectionData);
				}
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (projectionData);
				global::System.GC.KeepAlive (colorInfo);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='createVideoSampleFormat' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='float'] and parameter[9][@type='java.util.List&lt;byte[]&gt;'] and parameter[10][@type='int'] and parameter[11][@type='float'] and parameter[12][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createVideoSampleFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIFLjava/util/List;IFLcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format CreateVideoSampleFormat (string id, string sampleMimeType, string codecs, int bitrate, int maxInputSize, int width, int height, float frameRate, global::System.Collections.Generic.IList<byte[]> initializationData, int rotationDegrees, float pixelWidthHeightRatio, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "createVideoSampleFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IIIIFLjava/util/List;IFLcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_sampleMimeType = JNIEnv.NewString (sampleMimeType);
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			IntPtr native_initializationData = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (initializationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_sampleMimeType);
				__args [2] = new JniArgumentValue (native_codecs);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (maxInputSize);
				__args [5] = new JniArgumentValue (width);
				__args [6] = new JniArgumentValue (height);
				__args [7] = new JniArgumentValue (frameRate);
				__args [8] = new JniArgumentValue (native_initializationData);
				__args [9] = new JniArgumentValue (rotationDegrees);
				__args [10] = new JniArgumentValue (pixelWidthHeightRatio);
				__args [11] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_sampleMimeType);
				JNIEnv.DeleteLocalRef (native_codecs);
				JNIEnv.DeleteLocalRef (native_initializationData);
				global::System.GC.KeepAlive (initializationData);
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='initializationDataEquals' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("initializationDataEquals", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Z", "")]
		public unsafe bool InitializationDataEquals (global::Com.Example.Androidtvlibrary.Main.Adapter.Format other)
		{
			const string __id = "initializationDataEquals.(Lcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='toLogString' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("toLogString", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Ljava/lang/String;", "")]
		public static unsafe string ToLogString (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "toLogString.(Lcom/example/androidtvlibrary/main/adapter/Format;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='writeBoolean' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='boolean']]"
		[Register ("writeBoolean", "(Landroid/os/Parcel;Z)V", "")]
		public static unsafe void WriteBoolean (global::Android.OS.Parcel parcel, bool value)
		{
			const string __id = "writeBoolean.(Landroid/os/Parcel;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (parcel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Format']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

	}
}
