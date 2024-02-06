using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/SceneRenderer", DoNotGenerateAcw=true)]
	public sealed partial class SceneRenderer : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener, global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/SceneRenderer", typeof (SceneRenderer));

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

		internal SceneRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/constructor[@name='SceneRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SceneRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='drawFrame' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='boolean']]"
		[Register ("drawFrame", "([FZ)V", "")]
		public unsafe void DrawFrame (float[] viewProjectionMatrix, bool rightEye)
		{
			const string __id = "drawFrame.([FZ)V";
			IntPtr native_viewProjectionMatrix = JNIEnv.NewArray (viewProjectionMatrix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_viewProjectionMatrix);
				__args [1] = new JniArgumentValue (rightEye);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (viewProjectionMatrix != null) {
					JNIEnv.CopyArray (native_viewProjectionMatrix, viewProjectionMatrix);
					JNIEnv.DeleteLocalRef (native_viewProjectionMatrix);
				}
				global::System.GC.KeepAlive (viewProjectionMatrix);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()Landroid/graphics/SurfaceTexture;", "")]
		public unsafe global::Android.Graphics.SurfaceTexture Init ()
		{
			const string __id = "init.()Landroid/graphics/SurfaceTexture;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='onCameraMotion' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float[]']]"
		[Register ("onCameraMotion", "(J[F)V", "")]
		public unsafe void OnCameraMotion (long timeUs, float[] rotation)
		{
			const string __id = "onCameraMotion.(J[F)V";
			IntPtr native_rotation = JNIEnv.NewArray (rotation);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeUs);
				__args [1] = new JniArgumentValue (native_rotation);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (rotation != null) {
					JNIEnv.CopyArray (native_rotation, rotation);
					JNIEnv.DeleteLocalRef (native_rotation);
				}
				global::System.GC.KeepAlive (rotation);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='onCameraMotionReset' and count(parameter)=0]"
		[Register ("onCameraMotionReset", "()V", "")]
		public unsafe void OnCameraMotionReset ()
		{
			const string __id = "onCameraMotionReset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='onVideoFrameAboutToBeRendered' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='android.media.MediaFormat']]"
		[Register ("onVideoFrameAboutToBeRendered", "(JJLcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaFormat;)V", "")]
		public unsafe void OnVideoFrameAboutToBeRendered (long presentationTimeUs, long releaseTimeNs, global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Android.Media.MediaFormat mediaFormat)
		{
			const string __id = "onVideoFrameAboutToBeRendered.(JJLcom/example/androidtvlibrary/main/adapter/Format;Landroid/media/MediaFormat;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (presentationTimeUs);
				__args [1] = new JniArgumentValue (releaseTimeNs);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [3] = new JniArgumentValue ((mediaFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaFormat).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (mediaFormat);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='setDefaultStereoMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultStereoMode", "(I)V", "")]
		public unsafe void SetDefaultStereoMode ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", ""})]
		int stereoMode)
		{
			const string __id = "setDefaultStereoMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stereoMode);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SceneRenderer']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public unsafe void Shutdown ()
		{
			const string __id = "shutdown.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
