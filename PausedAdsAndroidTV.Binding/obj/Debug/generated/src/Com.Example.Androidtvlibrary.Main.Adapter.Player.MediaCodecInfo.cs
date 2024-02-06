using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecInfo", DoNotGenerateAcw=true)]
	public sealed partial class MediaCodecInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='adaptive']"
		[Register ("adaptive")]
		public bool Adaptive {
			get {
				const string __id = "adaptive.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "adaptive.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='capabilities']"
		[Register ("capabilities")]
		public global::Android.Media.MediaCodecInfo.CodecCapabilities Capabilities {
			get {
				const string __id = "capabilities.Landroid/media/MediaCodecInfo$CodecCapabilities;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodecInfo.CodecCapabilities> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "capabilities.Landroid/media/MediaCodecInfo$CodecCapabilities;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='codecMimeType']"
		[Register ("codecMimeType")]
		public string CodecMimeType {
			get {
				const string __id = "codecMimeType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "codecMimeType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='hardwareAccelerated']"
		[Register ("hardwareAccelerated")]
		public bool HardwareAccelerated {
			get {
				const string __id = "hardwareAccelerated.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "hardwareAccelerated.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='MAX_SUPPORTED_INSTANCES_UNKNOWN']"
		[Register ("MAX_SUPPORTED_INSTANCES_UNKNOWN")]
		public const int MaxSupportedInstancesUnknown = (int) -1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='mimeType']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='passthrough']"
		[Register ("passthrough")]
		public bool Passthrough {
			get {
				const string __id = "passthrough.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "passthrough.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='secure']"
		[Register ("secure")]
		public bool Secure {
			get {
				const string __id = "secure.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "secure.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='softwareOnly']"
		[Register ("softwareOnly")]
		public bool SoftwareOnly {
			get {
				const string __id = "softwareOnly.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "softwareOnly.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MediaCodecInfo";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='tunneling']"
		[Register ("tunneling")]
		public bool Tunneling {
			get {
				const string __id = "tunneling.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "tunneling.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/field[@name='vendor']"
		[Register ("vendor")]
		public bool Vendor {
			get {
				const string __id = "vendor.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "vendor.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecInfo", typeof (MediaCodecInfo));

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

		internal MediaCodecInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsHdr10PlusOutOfBandMetadataSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isHdr10PlusOutOfBandMetadataSupported' and count(parameter)=0]"
			[Register ("isHdr10PlusOutOfBandMetadataSupported", "()Z", "")]
			get {
				const string __id = "isHdr10PlusOutOfBandMetadataSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int MaxSupportedInstances {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='getMaxSupportedInstances' and count(parameter)=0]"
			[Register ("getMaxSupportedInstances", "()I", "")]
			get {
				const string __id = "getMaxSupportedInstances.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='alignVideoSizeV21' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("alignVideoSizeV21", "(II)Landroid/graphics/Point;", "")]
		public unsafe global::Android.Graphics.Point AlignVideoSizeV21 (int width, int height)
		{
			const string __id = "alignVideoSizeV21.(II)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='getProfileLevels' and count(parameter)=0]"
		[Register ("getProfileLevels", "()[Landroid/media/MediaCodecInfo$CodecProfileLevel;", "")]
		public unsafe global::Android.Media.MediaCodecInfo.CodecProfileLevel[] GetProfileLevels ()
		{
			const string __id = "getProfileLevels.()[Landroid/media/MediaCodecInfo$CodecProfileLevel;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Android.Media.MediaCodecInfo.CodecProfileLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.Media.MediaCodecInfo.CodecProfileLevel));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isAudioChannelCountSupportedV21' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAudioChannelCountSupportedV21", "(I)Z", "")]
		public unsafe bool IsAudioChannelCountSupportedV21 (int channelCount)
		{
			const string __id = "isAudioChannelCountSupportedV21.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channelCount);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isAudioSampleRateSupportedV21' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAudioSampleRateSupportedV21", "(I)Z", "")]
		public unsafe bool IsAudioSampleRateSupportedV21 (int sampleRate)
		{
			const string __id = "isAudioSampleRateSupportedV21.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sampleRate);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isCodecSupported' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("isCodecSupported", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Z", "")]
		public unsafe bool IsCodecSupported (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "isCodecSupported.(Lcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isFormatSupported' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("isFormatSupported", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Z", "")]
		public unsafe bool IsFormatSupported (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "isFormatSupported.(Lcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isSeamlessAdaptationSupported' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("isSeamlessAdaptationSupported", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Z", "")]
		public unsafe bool IsSeamlessAdaptationSupported (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "isSeamlessAdaptationSupported.(Lcom/example/androidtvlibrary/main/adapter/Format;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isSeamlessAdaptationSupported' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='boolean']]"
		[Register ("isSeamlessAdaptationSupported", "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Z", "")]
		public unsafe bool IsSeamlessAdaptationSupported (global::Com.Example.Androidtvlibrary.Main.Adapter.Format oldFormat, global::Com.Example.Androidtvlibrary.Main.Adapter.Format newFormat, bool isNewFormatComplete)
		{
			const string __id = "isSeamlessAdaptationSupported.(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/Format;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((oldFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldFormat).Handle);
				__args [1] = new JniArgumentValue ((newFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newFormat).Handle);
				__args [2] = new JniArgumentValue (isNewFormatComplete);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (oldFormat);
				global::System.GC.KeepAlive (newFormat);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='isVideoSizeAndRateSupportedV21' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("isVideoSizeAndRateSupportedV21", "(IID)Z", "")]
		public unsafe bool IsVideoSizeAndRateSupportedV21 (int width, int height, double frameRate)
		{
			const string __id = "isVideoSizeAndRateSupportedV21.(IID)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (frameRate);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='newInstance' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.media.MediaCodecInfo.CodecCapabilities'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean']]"
		[Register ("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/media/MediaCodecInfo$CodecCapabilities;ZZZZZ)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo NewInstance (string name, string mimeType, string codecMimeType, global::Android.Media.MediaCodecInfo.CodecCapabilities capabilities, bool hardwareAccelerated, bool softwareOnly, bool vendor, bool forceDisableAdaptive, bool forceSecure)
		{
			const string __id = "newInstance.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/media/MediaCodecInfo$CodecCapabilities;ZZZZZ)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			IntPtr native_codecMimeType = JNIEnv.NewString (codecMimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_mimeType);
				__args [2] = new JniArgumentValue (native_codecMimeType);
				__args [3] = new JniArgumentValue ((capabilities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) capabilities).Handle);
				__args [4] = new JniArgumentValue (hardwareAccelerated);
				__args [5] = new JniArgumentValue (softwareOnly);
				__args [6] = new JniArgumentValue (vendor);
				__args [7] = new JniArgumentValue (forceDisableAdaptive);
				__args [8] = new JniArgumentValue (forceSecure);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_mimeType);
				JNIEnv.DeleteLocalRef (native_codecMimeType);
				global::System.GC.KeepAlive (capabilities);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecInfo']/method[@name='newPassthroughInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newPassthroughInstance", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo NewPassthroughInstance (string name)
		{
			const string __id = "newPassthroughInstance.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
