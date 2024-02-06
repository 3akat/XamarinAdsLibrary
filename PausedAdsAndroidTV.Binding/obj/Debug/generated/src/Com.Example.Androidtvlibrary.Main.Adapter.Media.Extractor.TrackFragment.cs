using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TrackFragment", DoNotGenerateAcw=true)]
	public sealed partial class TrackFragment : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='atomPosition']"
		[Register ("atomPosition")]
		public long AtomPosition {
			get {
				const string __id = "atomPosition.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "atomPosition.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='auxiliaryDataPosition']"
		[Register ("auxiliaryDataPosition")]
		public long AuxiliaryDataPosition {
			get {
				const string __id = "auxiliaryDataPosition.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "auxiliaryDataPosition.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='dataPosition']"
		[Register ("dataPosition")]
		public long DataPosition {
			get {
				const string __id = "dataPosition.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "dataPosition.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='definesEncryptionData']"
		[Register ("definesEncryptionData")]
		public bool DefinesEncryptionData {
			get {
				const string __id = "definesEncryptionData.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "definesEncryptionData.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='header']"
		[Register ("header")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultSampleValues Header {
			get {
				const string __id = "header.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/DefaultSampleValues;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultSampleValues> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "header.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/DefaultSampleValues;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='nextFragmentDecodeTime']"
		[Register ("nextFragmentDecodeTime")]
		public long NextFragmentDecodeTime {
			get {
				const string __id = "nextFragmentDecodeTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "nextFragmentDecodeTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleCompositionTimeOffsetUsTable']"
		[Register ("sampleCompositionTimeOffsetUsTable")]
		public IList<int> SampleCompositionTimeOffsetUsTable {
			get {
				const string __id = "sampleCompositionTimeOffsetUsTable.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleCompositionTimeOffsetUsTable.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleCount']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleDecodingTimeUsTable']"
		[Register ("sampleDecodingTimeUsTable")]
		public IList<long> SampleDecodingTimeUsTable {
			get {
				const string __id = "sampleDecodingTimeUsTable.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleDecodingTimeUsTable.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleEncryptionData']"
		[Register ("sampleEncryptionData")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray SampleEncryptionData {
			get {
				const string __id = "sampleEncryptionData.Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleEncryptionData.Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleEncryptionDataLength']"
		[Register ("sampleEncryptionDataLength")]
		public int SampleEncryptionDataLength {
			get {
				const string __id = "sampleEncryptionDataLength.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sampleEncryptionDataLength.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleEncryptionDataNeedsFill']"
		[Register ("sampleEncryptionDataNeedsFill")]
		public bool SampleEncryptionDataNeedsFill {
			get {
				const string __id = "sampleEncryptionDataNeedsFill.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "sampleEncryptionDataNeedsFill.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleIsSyncFrameTable']"
		[Register ("sampleIsSyncFrameTable")]
		public IList<bool> SampleIsSyncFrameTable {
			get {
				const string __id = "sampleIsSyncFrameTable.[Z";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<bool>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleIsSyncFrameTable.[Z";

				IntPtr native_value = global::Android.Runtime.JavaArray<bool>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='sampleSizeTable']"
		[Register ("sampleSizeTable")]
		public IList<int> SampleSizeTable {
			get {
				const string __id = "sampleSizeTable.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sampleSizeTable.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='trackEncryptionBox']"
		[Register ("trackEncryptionBox")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TrackEncryptionBox TrackEncryptionBox {
			get {
				const string __id = "trackEncryptionBox.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TrackEncryptionBox> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackEncryptionBox.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TrackEncryptionBox;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='trunCount']"
		[Register ("trunCount")]
		public int TrunCount {
			get {
				const string __id = "trunCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "trunCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='trunDataPosition']"
		[Register ("trunDataPosition")]
		public IList<long> TrunDataPosition {
			get {
				const string __id = "trunDataPosition.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trunDataPosition.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/field[@name='trunLength']"
		[Register ("trunLength")]
		public IList<int> TrunLength {
			get {
				const string __id = "trunLength.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trunLength.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TrackFragment", typeof (TrackFragment));

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

		internal TrackFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/constructor[@name='TrackFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrackFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='fillEncryptionData' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("fillEncryptionData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)V", "")]
		public unsafe void FillEncryptionData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "fillEncryptionData.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='fillEncryptionData' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("fillEncryptionData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "")]
		public unsafe void FillEncryptionData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray source)
		{
			const string __id = "fillEncryptionData.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='getSamplePresentationTimeUs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSamplePresentationTimeUs", "(I)J", "")]
		public unsafe long GetSamplePresentationTimeUs (int index)
		{
			const string __id = "getSamplePresentationTimeUs.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='initEncryptionData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initEncryptionData", "(I)V", "")]
		public unsafe void InitEncryptionData (int length)
		{
			const string __id = "initEncryptionData.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='initTables' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initTables", "(II)V", "")]
		public unsafe void InitTables (int trunCount, int sampleCount)
		{
			const string __id = "initTables.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (trunCount);
				__args [1] = new JniArgumentValue (sampleCount);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackFragment']/method[@name='sampleHasSubsampleEncryptionTable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sampleHasSubsampleEncryptionTable", "(I)Z", "")]
		public unsafe bool SampleHasSubsampleEncryptionTable (int index)
		{
			const string __id = "sampleHasSubsampleEncryptionTable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
