using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader", DoNotGenerateAcw=true)]
	public sealed partial class FlacFrameReader : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader.SampleNumberHolder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader$SampleNumberHolder", DoNotGenerateAcw=true)]
		public sealed partial class SampleNumberHolder : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader.SampleNumberHolder']/field[@name='sampleNumber']"
			[Register ("sampleNumber")]
			public long SampleNumber {
				get {
					const string __id = "sampleNumber.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sampleNumber.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader$SampleNumberHolder", typeof (SampleNumberHolder));

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

			internal SampleNumberHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader.SampleNumberHolder']/constructor[@name='FlacFrameReader.SampleNumberHolder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SampleNumberHolder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader", typeof (FlacFrameReader));

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

		internal FlacFrameReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader']/method[@name='checkAndReadFrameHeader' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.FlacStreamMetadata'] and parameter[3][@type='int'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.FlacFrameReader.SampleNumberHolder']]"
		[Register ("checkAndReadFrameHeader", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;ILcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader$SampleNumberHolder;)Z", "")]
		public static unsafe bool CheckAndReadFrameHeader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata flacStreamMetadata, int frameStartMarker, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacFrameReader.SampleNumberHolder sampleNumberHolder)
		{
			const string __id = "checkAndReadFrameHeader.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;ILcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader$SampleNumberHolder;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue ((flacStreamMetadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flacStreamMetadata).Handle);
				__args [2] = new JniArgumentValue (frameStartMarker);
				__args [3] = new JniArgumentValue ((sampleNumberHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampleNumberHolder).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (flacStreamMetadata);
				global::System.GC.KeepAlive (sampleNumberHolder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader']/method[@name='checkFrameHeaderFromPeek' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.FlacStreamMetadata'] and parameter[3][@type='int'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.FlacFrameReader.SampleNumberHolder']]"
		[Register ("checkFrameHeaderFromPeek", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;ILcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader$SampleNumberHolder;)Z", "")]
		public static unsafe bool CheckFrameHeaderFromPeek (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata flacStreamMetadata, int frameStartMarker, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacFrameReader.SampleNumberHolder sampleNumberHolder)
		{
			const string __id = "checkFrameHeaderFromPeek.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;ILcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacFrameReader$SampleNumberHolder;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((flacStreamMetadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flacStreamMetadata).Handle);
				__args [2] = new JniArgumentValue (frameStartMarker);
				__args [3] = new JniArgumentValue ((sampleNumberHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampleNumberHolder).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (flacStreamMetadata);
				global::System.GC.KeepAlive (sampleNumberHolder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader']/method[@name='getFirstSampleNumber' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.FlacStreamMetadata']]"
		[Register ("getFirstSampleNumber", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;)J", "")]
		public static unsafe long GetFirstSampleNumber (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FlacStreamMetadata flacStreamMetadata)
		{
			const string __id = "getFirstSampleNumber.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FlacStreamMetadata;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((flacStreamMetadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flacStreamMetadata).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (flacStreamMetadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacFrameReader']/method[@name='readFrameBlockSizeSamplesFromKey' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("readFrameBlockSizeSamplesFromKey", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)I", "")]
		public static unsafe int ReadFrameBlockSizeSamplesFromKey (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, int blockSizeKey)
		{
			const string __id = "readFrameBlockSizeSamplesFromKey.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (blockSizeKey);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
