using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DummyTrackOutput']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/DummyTrackOutput", DoNotGenerateAcw=true)]
	public sealed partial class DummyTrackOutput : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/DummyTrackOutput", typeof (DummyTrackOutput));

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

		internal DummyTrackOutput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DummyTrackOutput']/constructor[@name='DummyTrackOutput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DummyTrackOutput () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DummyTrackOutput']/method[@name='format' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("format", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V", "")]
		public unsafe void Format (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "format.(Lcom/example/androidtvlibrary/main/adapter/Format;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DummyTrackOutput']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I", "")]
		public unsafe int SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, int length, bool allowEndOfInput)
		{
			const string __id = "sampleData.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue (length);
				__args [2] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DummyTrackOutput']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V", "")]
		public unsafe void SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, int length)
		{
			const string __id = "sampleData.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DummyTrackOutput']/method[@name='sampleMetadata' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput.CryptoData']]"
		[Register ("sampleMetadata", "(JIIILcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;)V", "")]
		public unsafe void SampleMetadata (long timeUs, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"BufferFlagKeyFrame", "BufferFlagEndOfStream", "BufferFlagHasSupplementalData", "BufferFlagLastSample", "BufferFlagEncrypted", "BufferFlagDecodeOnly"})]
		int flags, int size, int offset, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData cryptoData)
		{
			const string __id = "sampleMetadata.(JIIILcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (timeUs);
				__args [1] = new JniArgumentValue (flags);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue (offset);
				__args [4] = new JniArgumentValue ((cryptoData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cryptoData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cryptoData);
			}
		}

	}
}
