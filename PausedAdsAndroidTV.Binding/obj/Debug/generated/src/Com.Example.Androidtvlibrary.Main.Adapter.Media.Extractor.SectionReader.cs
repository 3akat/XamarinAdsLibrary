using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SectionReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/SectionReader", DoNotGenerateAcw=true)]
	public sealed partial class SectionReader : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader {
		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/SectionReader", typeof (SectionReader));

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

		internal SectionReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SectionReader']/constructor[@name='SectionReader' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.SectionPayloadReader']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/SectionPayloadReader;)V", "")]
		public unsafe SectionReader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ISectionPayloadReader reader) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/SectionPayloadReader;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reader).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reader);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SectionReader']/method[@name='consume' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V", "")]
		public unsafe void Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.ITsPayloadReader", Fields = new string [] {"FlagPayloadUnitStartIndicator", "FlagRandomAccessIndicator", "FlagDataAlignmentIndicator"})]
		int flags)
		{
			const string __id = "consume.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SectionReader']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.TrackIdGenerator']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='SectionReader']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "")]
		public unsafe void Seek ()
		{
			const string __id = "seek.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
