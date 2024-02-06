using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecUtil", DoNotGenerateAcw=true)]
	public sealed partial class MediaCodecUtil : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil.DecoderQueryException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecUtil$DecoderQueryException", DoNotGenerateAcw=true)]
		public partial class DecoderQueryException : global::Java.Lang.Exception {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecUtil$DecoderQueryException", typeof (DecoderQueryException));

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

			protected DecoderQueryException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecUtil", typeof (MediaCodecUtil));

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

		internal MediaCodecUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo PassthroughDecoderInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='getPassthroughDecoderInfo' and count(parameter)=0]"
			[Register ("getPassthroughDecoderInfo", "()Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;", "")]
			get {
				const string __id = "getPassthroughDecoderInfo.()Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='getCodecProfileAndLevel' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("getCodecProfileAndLevel", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair GetCodecProfileAndLevel (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "getCodecProfileAndLevel.(Lcom/example/androidtvlibrary/main/adapter/Format;)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='getDecoderInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("getDecoderInfo", "(Ljava/lang/String;ZZ)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo GetDecoderInfo (string mimeType, bool secure, bool tunneling)
		{
			const string __id = "getDecoderInfo.(Ljava/lang/String;ZZ)Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;";
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mimeType);
				__args [1] = new JniArgumentValue (secure);
				__args [2] = new JniArgumentValue (tunneling);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='getDecoderInfos' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("getDecoderInfos", "(Ljava/lang/String;ZZ)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfos (string mimeType, bool secure, bool tunneling)
		{
			const string __id = "getDecoderInfos.(Ljava/lang/String;ZZ)Ljava/util/List;";
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mimeType);
				__args [1] = new JniArgumentValue (secure);
				__args [2] = new JniArgumentValue (tunneling);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='getDecoderInfosSortedByFormatSupport' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.player.MediaCodecInfo&gt;'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("getDecoderInfosSortedByFormatSupport", "(Ljava/util/List;Lcom/example/androidtvlibrary/main/adapter/Format;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfosSortedByFormatSupport (global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> decoderInfos, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "getDecoderInfosSortedByFormatSupport.(Ljava/util/List;Lcom/example/androidtvlibrary/main/adapter/Format;)Ljava/util/List;";
			IntPtr native_decoderInfos = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.ToLocalJniHandle (decoderInfos);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_decoderInfos);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_decoderInfos);
				global::System.GC.KeepAlive (decoderInfos);
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='maxH264DecodableFrameSize' and count(parameter)=0]"
		[Register ("maxH264DecodableFrameSize", "()I", "")]
		public static unsafe int MaxH264DecodableFrameSize ()
		{
			const string __id = "maxH264DecodableFrameSize.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaCodecUtil']/method[@name='warmDecoderInfoCache' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("warmDecoderInfoCache", "(Ljava/lang/String;ZZ)V", "")]
		public static unsafe void WarmDecoderInfoCache (string mimeType, bool secure, bool tunneling)
		{
			const string __id = "warmDecoderInfoCache.(Ljava/lang/String;ZZ)V";
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_mimeType);
				__args [1] = new JniArgumentValue (secure);
				__args [2] = new JniArgumentValue (tunneling);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

	}
}
