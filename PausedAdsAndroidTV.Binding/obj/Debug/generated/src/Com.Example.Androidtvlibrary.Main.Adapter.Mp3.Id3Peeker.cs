using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Peeker']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/Id3Peeker", DoNotGenerateAcw=true)]
	public sealed partial class Id3Peeker : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/Id3Peeker", typeof (Id3Peeker));

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

		internal Id3Peeker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Peeker']/constructor[@name='Id3Peeker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Id3Peeker () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Peeker']/method[@name='peekId3Data' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.mp3.Id3Decoder.FramePredicate']]"
		[Register ("peekId3Data", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata PeekId3Data (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder.IFramePredicate id3FramePredicate)
		{
			const string __id = "peekId3Data.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate;)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((id3FramePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id3FramePredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (id3FramePredicate);
			}
		}

	}
}
