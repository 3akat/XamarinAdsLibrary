using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='UserDataReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/UserDataReader", DoNotGenerateAcw=true)]
	public sealed partial class UserDataReader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/UserDataReader", typeof (UserDataReader));

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

		internal UserDataReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='UserDataReader']/constructor[@name='UserDataReader' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.Format&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe UserDataReader (global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> closedCaptionFormats) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_closedCaptionFormats = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format>.ToLocalJniHandle (closedCaptionFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_closedCaptionFormats);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_closedCaptionFormats);
				global::System.GC.KeepAlive (closedCaptionFormats);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='UserDataReader']/method[@name='consume' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("consume", "(JLcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V", "")]
		public unsafe void Consume (long pesTimeUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray userDataPayload)
		{
			const string __id = "consume.(JLcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pesTimeUs);
				__args [1] = new JniArgumentValue ((userDataPayload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userDataPayload).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (userDataPayload);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='UserDataReader']/method[@name='createTracks' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TsPayloadReader.TrackIdGenerator']]"
		[Register ("createTracks", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V", "")]
		public unsafe void CreateTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput extractorOutput, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator idGenerator)
		{
			const string __id = "createTracks.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((extractorOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extractorOutput).Handle);
				__args [1] = new JniArgumentValue ((idGenerator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) idGenerator).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (extractorOutput);
				global::System.GC.KeepAlive (idGenerator);
			}
		}

	}
}
