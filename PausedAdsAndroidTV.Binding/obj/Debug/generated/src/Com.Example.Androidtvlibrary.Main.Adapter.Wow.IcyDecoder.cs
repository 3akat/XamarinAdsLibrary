using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='IcyDecoder']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/IcyDecoder", DoNotGenerateAcw=true)]
	public sealed partial class IcyDecoder : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/IcyDecoder", typeof (IcyDecoder));

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

		internal IcyDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='IcyDecoder']/constructor[@name='IcyDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IcyDecoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='IcyDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.mp3.MetadataInputBuffer']]"
		[Register ("decode", "(Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataInputBuffer;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata Decode (global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MetadataInputBuffer inputBuffer)
		{
			const string __id = "decode.(Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataInputBuffer;)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputBuffer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputBuffer);
			}
		}

	}
}
