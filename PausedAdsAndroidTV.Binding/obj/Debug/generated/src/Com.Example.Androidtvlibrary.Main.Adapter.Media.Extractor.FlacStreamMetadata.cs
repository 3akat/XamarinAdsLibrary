using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata", DoNotGenerateAcw=true)]
	public sealed partial class FlacStreamMetadata : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='bitsPerSample']"
		[Register ("bitsPerSample")]
		public int BitsPerSample {
			get {
				const string __id = "bitsPerSample.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bitsPerSample.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='bitsPerSampleLookupKey']"
		[Register ("bitsPerSampleLookupKey")]
		public int BitsPerSampleLookupKey {
			get {
				const string __id = "bitsPerSampleLookupKey.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bitsPerSampleLookupKey.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='channels']"
		[Register ("channels")]
		public int Channels {
			get {
				const string __id = "channels.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "channels.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='maxBlockSizeSamples']"
		[Register ("maxBlockSizeSamples")]
		public int MaxBlockSizeSamples {
			get {
				const string __id = "maxBlockSizeSamples.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxBlockSizeSamples.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='maxFrameSize']"
		[Register ("maxFrameSize")]
		public int MaxFrameSize {
			get {
				const string __id = "maxFrameSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxFrameSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='minBlockSizeSamples']"
		[Register ("minBlockSizeSamples")]
		public int MinBlockSizeSamples {
			get {
				const string __id = "minBlockSizeSamples.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minBlockSizeSamples.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='minFrameSize']"
		[Register ("minFrameSize")]
		public int MinFrameSize {
			get {
				const string __id = "minFrameSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minFrameSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='NOT_IN_LOOKUP_TABLE']"
		[Register ("NOT_IN_LOOKUP_TABLE")]
		public const int NotInLookupTable = (int) -1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='sampleRate']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='sampleRateLookupKey']"
		[Register ("sampleRateLookupKey")]
		public int SampleRateLookupKey {
			get {
				const string __id = "sampleRateLookupKey.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sampleRateLookupKey.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/field[@name='totalSamples']"
		[Register ("totalSamples")]
		public long TotalSamples {
			get {
				const string __id = "totalSamples.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "totalSamples.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata.SeekTable']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata$SeekTable", DoNotGenerateAcw=true)]
		public partial class SeekTable : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata.SeekTable']/field[@name='pointOffsets']"
			[Register ("pointOffsets")]
			public IList<long> PointOffsets {
				get {
					const string __id = "pointOffsets.[J";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pointOffsets.[J";

					IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata.SeekTable']/field[@name='pointSampleNumbers']"
			[Register ("pointSampleNumbers")]
			public IList<long> PointSampleNumbers {
				get {
					const string __id = "pointSampleNumbers.[J";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pointSampleNumbers.[J";

					IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata$SeekTable", typeof (SeekTable));

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

			protected SeekTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata.SeekTable']/constructor[@name='FlacStreamMetadata.SeekTable' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long[]']]"
			[Register (".ctor", "([J[J)V", "")]
			public unsafe SeekTable (long[] pointSampleNumbers, long[] pointOffsets) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([J[J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_pointSampleNumbers = JNIEnv.NewArray (pointSampleNumbers);
				IntPtr native_pointOffsets = JNIEnv.NewArray (pointOffsets);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_pointSampleNumbers);
					__args [1] = new JniArgumentValue (native_pointOffsets);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (pointSampleNumbers != null) {
						JNIEnv.CopyArray (native_pointSampleNumbers, pointSampleNumbers);
						JNIEnv.DeleteLocalRef (native_pointSampleNumbers);
					}
					if (pointOffsets != null) {
						JNIEnv.CopyArray (native_pointOffsets, pointOffsets);
						JNIEnv.DeleteLocalRef (native_pointOffsets);
					}
					global::System.GC.KeepAlive (pointSampleNumbers);
					global::System.GC.KeepAlive (pointOffsets);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata", typeof (FlacStreamMetadata));

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

		internal FlacStreamMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/constructor[@name='FlacStreamMetadata' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe FlacStreamMetadata (byte[] data, int offset) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/constructor[@name='FlacStreamMetadata' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='long'] and parameter[9][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[10][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.Media.extractor.PictureFrame&gt;']]"
		[Register (".ctor", "(IIIIIIIJLjava/util/ArrayList;Ljava/util/ArrayList;)V", "")]
		public unsafe FlacStreamMetadata (int minBlockSizeSamples, int maxBlockSizeSamples, int minFrameSize, int maxFrameSize, int sampleRate, int channels, int bitsPerSample, long totalSamples, global::System.Collections.Generic.IList<string> vorbisComments, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.PictureFrame> pictureFrames) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIIIIIJLjava/util/ArrayList;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vorbisComments = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (vorbisComments);
			IntPtr native_pictureFrames = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.PictureFrame>.ToLocalJniHandle (pictureFrames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (minBlockSizeSamples);
				__args [1] = new JniArgumentValue (maxBlockSizeSamples);
				__args [2] = new JniArgumentValue (minFrameSize);
				__args [3] = new JniArgumentValue (maxFrameSize);
				__args [4] = new JniArgumentValue (sampleRate);
				__args [5] = new JniArgumentValue (channels);
				__args [6] = new JniArgumentValue (bitsPerSample);
				__args [7] = new JniArgumentValue (totalSamples);
				__args [8] = new JniArgumentValue (native_vorbisComments);
				__args [9] = new JniArgumentValue (native_pictureFrames);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_vorbisComments);
				JNIEnv.DeleteLocalRef (native_pictureFrames);
				global::System.GC.KeepAlive (vorbisComments);
				global::System.GC.KeepAlive (pictureFrames);
			}
		}

		public unsafe long ApproxBytesPerFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getApproxBytesPerFrame' and count(parameter)=0]"
			[Register ("getApproxBytesPerFrame", "()J", "")]
			get {
				const string __id = "getApproxBytesPerFrame.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int BitRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getBitRate' and count(parameter)=0]"
			[Register ("getBitRate", "()I", "")]
			get {
				const string __id = "getBitRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "")]
			get {
				const string __id = "getDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int MaxDecodedFrameSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getMaxDecodedFrameSize' and count(parameter)=0]"
			[Register ("getMaxDecodedFrameSize", "()I", "")]
			get {
				const string __id = "getMaxDecodedFrameSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='copyWithPictureFrames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.Media.extractor.PictureFrame&gt;']]"
		[Register ("copyWithPictureFrames", "(Ljava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata CopyWithPictureFrames (global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.PictureFrame> pictureFrames)
		{
			const string __id = "copyWithPictureFrames.(Ljava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;";
			IntPtr native_pictureFrames = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.PictureFrame>.ToLocalJniHandle (pictureFrames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pictureFrames);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pictureFrames);
				global::System.GC.KeepAlive (pictureFrames);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='copyWithSeekTable' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.FlacStreamMetadata.SeekTable']]"
		[Register ("copyWithSeekTable", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata$SeekTable;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata CopyWithSeekTable (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata.SeekTable seekTable)
		{
			const string __id = "copyWithSeekTable.(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata$SeekTable;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((seekTable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekTable).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (seekTable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='copyWithVorbisComments' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("copyWithVorbisComments", "(Ljava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata CopyWithVorbisComments (global::System.Collections.Generic.IList<string> vorbisComments)
		{
			const string __id = "copyWithVorbisComments.(Ljava/util/List;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;";
			IntPtr native_vorbisComments = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (vorbisComments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_vorbisComments);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_vorbisComments);
				global::System.GC.KeepAlive (vorbisComments);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getFormat' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("getFormat", "([BLcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format GetFormat (byte[] streamMarkerAndInfoBlock, global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata id3Metadata)
		{
			const string __id = "getFormat.([BLcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			IntPtr native_streamMarkerAndInfoBlock = JNIEnv.NewArray (streamMarkerAndInfoBlock);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_streamMarkerAndInfoBlock);
				__args [1] = new JniArgumentValue ((id3Metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id3Metadata).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (streamMarkerAndInfoBlock != null) {
					JNIEnv.CopyArray (native_streamMarkerAndInfoBlock, streamMarkerAndInfoBlock);
					JNIEnv.DeleteLocalRef (native_streamMarkerAndInfoBlock);
				}
				global::System.GC.KeepAlive (streamMarkerAndInfoBlock);
				global::System.GC.KeepAlive (id3Metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getMetadataCopyWithAppendedEntriesFrom' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("getMetadataCopyWithAppendedEntriesFrom", "(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata GetMetadataCopyWithAppendedEntriesFrom (global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata other)
		{
			const string __id = "getMetadataCopyWithAppendedEntriesFrom.(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacStreamMetadata']/method[@name='getSampleNumber' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getSampleNumber", "(J)J", "")]
		public unsafe long GetSampleNumber (long timeUs)
		{
			const string __id = "getSampleNumber.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
