using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultEbmlReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultEbmlReader", DoNotGenerateAcw=true)]
	public sealed partial class DefaultEbmlReader : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/DefaultEbmlReader", typeof (DefaultEbmlReader));

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

		internal DefaultEbmlReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultEbmlReader']/constructor[@name='DefaultEbmlReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultEbmlReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultEbmlReader']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.EbmlProcessor']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor;)V", "")]
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.IEbmlProcessor processor)
		{
			const string __id = "init.(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/EbmlProcessor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((processor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) processor).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (processor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultEbmlReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "")]
		public unsafe bool Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "read.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='DefaultEbmlReader']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
