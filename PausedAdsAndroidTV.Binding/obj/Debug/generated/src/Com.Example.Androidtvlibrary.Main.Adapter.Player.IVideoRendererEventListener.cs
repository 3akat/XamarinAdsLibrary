using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener$EventDispatcher", DoNotGenerateAcw=true)]
	public sealed partial class VideoRendererEventListenerEventDispatcher : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener$EventDispatcher", typeof (VideoRendererEventListenerEventDispatcher));

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

		internal VideoRendererEventListenerEventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/constructor[@name='VideoRendererEventListener.EventDispatcher' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener']]"
		[Register (".ctor", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;)V", "")]
		public unsafe VideoRendererEventListenerEventDispatcher (global::Android.OS.Handler handler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener listener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='decoderInitialized' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("decoderInitialized", "(Ljava/lang/String;JJ)V", "")]
		public unsafe void DecoderInitialized (string decoderName, long initializedTimestampMs, long initializationDurationMs)
		{
			const string __id = "decoderInitialized.(Ljava/lang/String;JJ)V";
			IntPtr native_decoderName = JNIEnv.NewString (decoderName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_decoderName);
				__args [1] = new JniArgumentValue (initializedTimestampMs);
				__args [2] = new JniArgumentValue (initializationDurationMs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_decoderName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='disabled' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.DecoderCounters']]"
		[Register ("disabled", "(Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;)V", "")]
		public unsafe void Disabled (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DecoderCounters counters)
		{
			const string __id = "disabled.(Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((counters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) counters).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (counters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='droppedFrames' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("droppedFrames", "(IJ)V", "")]
		public unsafe void DroppedFrames (int droppedFrameCount, long elapsedMs)
		{
			const string __id = "droppedFrames.(IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (droppedFrameCount);
				__args [1] = new JniArgumentValue (elapsedMs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='enabled' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.DecoderCounters']]"
		[Register ("enabled", "(Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;)V", "")]
		public unsafe void Enabled (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DecoderCounters decoderCounters)
		{
			const string __id = "enabled.(Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((decoderCounters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decoderCounters).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (decoderCounters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='inputFormatChanged' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("inputFormatChanged", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V", "")]
		public unsafe void InputFormatChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "inputFormatChanged.(Lcom/example/androidtvlibrary/main/adapter/Format;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='renderedFirstFrame' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("renderedFirstFrame", "(Landroid/view/Surface;)V", "")]
		public unsafe void RenderedFirstFrame (global::Android.Views.Surface surface)
		{
			const string __id = "renderedFirstFrame.(Landroid/view/Surface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surface);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='VideoRendererEventListener.EventDispatcher']/method[@name='videoSizeChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("videoSizeChanged", "(IIIF)V", "")]
		public unsafe void VideoSizeChanged (int width, int height, int unappliedRotationDegrees, float pixelWidthHeightRatio)
		{
			const string __id = "videoSizeChanged.(IIIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (unappliedRotationDegrees);
				__args [3] = new JniArgumentValue (pixelWidthHeightRatio);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='VideoRendererEventListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListenerInvoker")]
	public partial interface IVideoRendererEventListener : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener", DoNotGenerateAcw=true)]
	internal partial class IVideoRendererEventListenerInvoker : global::Java.Lang.Object, IVideoRendererEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener", typeof (IVideoRendererEventListenerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IVideoRendererEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoRendererEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoRendererEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListenerImplementor")]
	internal sealed partial class IVideoRendererEventListenerImplementor : global::Java.Lang.Object, IVideoRendererEventListener {
		public IVideoRendererEventListenerImplementor () : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}

		internal static bool __IsEmpty (IVideoRendererEventListenerImplementor value)
		{
			return true;
		}

	}
}
