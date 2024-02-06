using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/WavExtractor", DoNotGenerateAcw=true)]
	public sealed partial class WavExtractor : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1 {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory Factory {
			get {
				const string __id = "FACTORY.Lcom/example/androidtvlibrary/main/adapter/mp3/ExtractorsFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.Media.Extractor

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_CONTINUE']"
			[Register ("RESULT_CONTINUE")]
			public const int ResultContinue = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_END_OF_INPUT']"
			[Register ("RESULT_END_OF_INPUT")]
			public const int ResultEndOfInput = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_SEEK']"
			[Register ("RESULT_SEEK")]
			public const int ResultSeek = (int) 1;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/WavExtractor", typeof (WavExtractor));

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

		internal WavExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/constructor[@name='WavExtractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WavExtractor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V", "")]
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput output)
		{
			const string __id = "init.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (output);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.PositionHolder']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I", "")]
		public unsafe int Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder seekPosition)
		{
			const string __id = "read.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((seekPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekPosition).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (seekPosition);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/method[@name='seek' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("seek", "(JJ)V", "")]
		public unsafe void Seek (long position, long timeUs)
		{
			const string __id = "seek.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (timeUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavExtractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
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

	}
}
