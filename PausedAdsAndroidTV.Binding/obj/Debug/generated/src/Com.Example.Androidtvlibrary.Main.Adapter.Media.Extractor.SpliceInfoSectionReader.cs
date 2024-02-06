using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SpliceInfoSectionReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/SpliceInfoSectionReader", DoNotGenerateAcw=true)]
	public sealed partial class SpliceInfoSectionReader : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/SpliceInfoSectionReader", typeof (SpliceInfoSectionReader));

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

		internal SpliceInfoSectionReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SpliceInfoSectionReader']/constructor[@name='SpliceInfoSectionReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpliceInfoSectionReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SpliceInfoSectionReader']/method[@name='consume' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "")]
		public unsafe void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray sectionData)
		{
			const string __id = "consume.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sectionData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sectionData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SpliceInfoSectionReader']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.TrackIdGenerator']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V", "")]
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput extractorOutput, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator idGenerator)
		{
			const string __id = "init.(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				__args [1] = new JniArgumentValue ((extractorOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extractorOutput).Handle);
				__args [2] = new JniArgumentValue ((idGenerator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idGenerator).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timestampAdjuster);
				global::System.GC.KeepAlive (extractorOutput);
				global::System.GC.KeepAlive (idGenerator);
			}
		}

	}
}
