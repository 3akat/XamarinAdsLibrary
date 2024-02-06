using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MetadataRenderer", DoNotGenerateAcw=true)]
	public sealed partial class MetadataRenderer : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.BaseRenderer, global::Android.OS.Handler.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MetadataRenderer", typeof (MetadataRenderer));

		internal static new IntPtr class_ref {
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

		internal MetadataRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/constructor[@name='MetadataRenderer' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput'] and parameter[2][@type='android.os.Looper']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Landroid/os/Looper;)V", "")]
		public unsafe MetadataRenderer (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput output, global::Android.OS.Looper outputLooper) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Landroid/os/Looper;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [1] = new JniArgumentValue ((outputLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputLooper).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (outputLooper);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/constructor[@name='MetadataRenderer' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput'] and parameter[2][@type='android.os.Looper'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.MetadataDecoderFactory']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory;)V", "")]
		public unsafe MetadataRenderer (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput output, global::Android.OS.Looper outputLooper, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactory decoderFactory) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [1] = new JniArgumentValue ((outputLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputLooper).Handle);
				__args [2] = new JniArgumentValue ((decoderFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decoderFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (outputLooper);
				global::System.GC.KeepAlive (decoderFactory);
			}
		}

		public override unsafe bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "")]
			get {
				const string __id = "isEnded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "")]
			get {
				const string __id = "isReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "")]
		public unsafe bool HandleMessage (global::Android.OS.Message msg)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/method[@name='render' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("render", "(JJ)V", "")]
		public override unsafe void Render (long positionUs, long elapsedRealtimeUs)
		{
			const string __id = "render.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (elapsedRealtimeUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MetadataRenderer']/method[@name='supportsFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I", "")]
		public override unsafe int SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "supportsFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

	}
}
