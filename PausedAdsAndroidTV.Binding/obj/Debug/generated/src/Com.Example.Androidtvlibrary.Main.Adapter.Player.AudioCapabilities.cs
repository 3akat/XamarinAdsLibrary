using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioCapabilities']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioCapabilities", DoNotGenerateAcw=true)]
	public sealed partial class AudioCapabilities : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioCapabilities']/field[@name='DEFAULT_AUDIO_CAPABILITIES']"
		[Register ("DEFAULT_AUDIO_CAPABILITIES")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities DefaultAudioCapabilities {
			get {
				const string __id = "DEFAULT_AUDIO_CAPABILITIES.Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioCapabilities", typeof (AudioCapabilities));

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

		internal AudioCapabilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioCapabilities']/constructor[@name='AudioCapabilities' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([II)V", "")]
		public unsafe AudioCapabilities (int[] supportedEncodings, int maxChannelCount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_supportedEncodings = JNIEnv.NewArray (supportedEncodings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_supportedEncodings);
				__args [1] = new JniArgumentValue (maxChannelCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (supportedEncodings != null) {
					JNIEnv.CopyArray (native_supportedEncodings, supportedEncodings);
					JNIEnv.DeleteLocalRef (native_supportedEncodings);
				}
				global::System.GC.KeepAlive (supportedEncodings);
			}
		}

		public unsafe int MaxChannelCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioCapabilities']/method[@name='getMaxChannelCount' and count(parameter)=0]"
			[Register ("getMaxChannelCount", "()I", "")]
			get {
				const string __id = "getMaxChannelCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioCapabilities']/method[@name='getCapabilities' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCapabilities", "(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities GetCapabilities (global::Android.Content.Context context)
		{
			const string __id = "getCapabilities.(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioCapabilities']/method[@name='supportsEncoding' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("supportsEncoding", "(I)Z", "")]
		public unsafe bool SupportsEncoding (int encoding)
		{
			const string __id = "supportsEncoding.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (encoding);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
