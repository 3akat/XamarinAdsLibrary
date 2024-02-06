using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Sniffer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/Sniffer", DoNotGenerateAcw=true)]
	public sealed partial class Sniffer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/Sniffer", typeof (Sniffer));

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

		internal Sniffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Sniffer']/constructor[@name='Sniffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Sniffer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Sniffer']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("sniff", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "")]
		public unsafe bool Sniff (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "sniff.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Sniffer']/method[@name='sniffFragmented' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("sniffFragmented", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "")]
		public static unsafe bool SniffFragmented (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "sniffFragmented.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='Sniffer']/method[@name='sniffUnfragmented' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("sniffUnfragmented", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "")]
		public static unsafe bool SniffUnfragmented (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "sniffUnfragmented.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

	}
}
