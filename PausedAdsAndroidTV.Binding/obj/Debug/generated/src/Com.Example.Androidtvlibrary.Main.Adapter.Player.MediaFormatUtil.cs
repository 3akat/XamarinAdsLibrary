using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaFormatUtil", DoNotGenerateAcw=true)]
	public sealed partial class MediaFormatUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaFormatUtil", typeof (MediaFormatUtil));

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

		internal MediaFormatUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']/method[@name='maybeSetByteBuffer' and count(parameter)=3 and parameter[1][@type='android.media.MediaFormat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("maybeSetByteBuffer", "(Landroid/media/MediaFormat;Ljava/lang/String;[B)V", "")]
		public static unsafe void MaybeSetByteBuffer (global::Android.Media.MediaFormat format, string key, byte[] value)
		{
			const string __id = "maybeSetByteBuffer.(Landroid/media/MediaFormat;Ljava/lang/String;[B)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']/method[@name='maybeSetColorInfo' and count(parameter)=2 and parameter[1][@type='android.media.MediaFormat'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.ColorInfo']]"
		[Register ("maybeSetColorInfo", "(Landroid/media/MediaFormat;Lcom/example/androidtvlibrary/main/adapter/ColorInfo;)V", "")]
		public static unsafe void MaybeSetColorInfo (global::Android.Media.MediaFormat format, global::Com.Example.Androidtvlibrary.Main.Adapter.ColorInfo colorInfo)
		{
			const string __id = "maybeSetColorInfo.(Landroid/media/MediaFormat;Lcom/example/androidtvlibrary/main/adapter/ColorInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue ((colorInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorInfo).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (colorInfo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']/method[@name='maybeSetFloat' and count(parameter)=3 and parameter[1][@type='android.media.MediaFormat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("maybeSetFloat", "(Landroid/media/MediaFormat;Ljava/lang/String;F)V", "")]
		public static unsafe void MaybeSetFloat (global::Android.Media.MediaFormat format, string key, float value)
		{
			const string __id = "maybeSetFloat.(Landroid/media/MediaFormat;Ljava/lang/String;F)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']/method[@name='maybeSetInteger' and count(parameter)=3 and parameter[1][@type='android.media.MediaFormat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("maybeSetInteger", "(Landroid/media/MediaFormat;Ljava/lang/String;I)V", "")]
		public static unsafe void MaybeSetInteger (global::Android.Media.MediaFormat format, string key, int value)
		{
			const string __id = "maybeSetInteger.(Landroid/media/MediaFormat;Ljava/lang/String;I)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']/method[@name='setCsdBuffers' and count(parameter)=2 and parameter[1][@type='android.media.MediaFormat'] and parameter[2][@type='java.util.List&lt;byte[]&gt;']]"
		[Register ("setCsdBuffers", "(Landroid/media/MediaFormat;Ljava/util/List;)V", "")]
		public static unsafe void SetCsdBuffers (global::Android.Media.MediaFormat format, global::System.Collections.Generic.IList<byte[]> csdBuffers)
		{
			const string __id = "setCsdBuffers.(Landroid/media/MediaFormat;Ljava/util/List;)V";
			IntPtr native_csdBuffers = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (csdBuffers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_csdBuffers);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_csdBuffers);
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (csdBuffers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='MediaFormatUtil']/method[@name='setString' and count(parameter)=3 and parameter[1][@type='android.media.MediaFormat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setString", "(Landroid/media/MediaFormat;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetString (global::Android.Media.MediaFormat format, string key, string value)
		{
			const string __id = "setString.(Landroid/media/MediaFormat;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (format);
			}
		}

	}
}
