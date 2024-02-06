using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/SphericalGLSurfaceView", DoNotGenerateAcw=true)]
	public sealed partial class SphericalGLSurfaceView : global::Android.Opengl.GLSurfaceView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/SphericalGLSurfaceView", typeof (SphericalGLSurfaceView));

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

		internal SphericalGLSurfaceView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']/constructor[@name='SphericalGLSurfaceView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SphericalGLSurfaceView (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']/constructor[@name='SphericalGLSurfaceView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SphericalGLSurfaceView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attributeSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attributeSet).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attributeSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']/method[@name='setDefaultStereoMode' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']/method[@name='setSingleTapListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.SingleTapListener']]"
		[Register ("setSingleTapListener", "(Lcom/example/androidtvlibrary/main/adapter/player/SingleTapListener;)V", "")]
		public unsafe void SetSingleTapListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListener listener)
		{
			const string __id = "setSingleTapListener.(Lcom/example/androidtvlibrary/main/adapter/player/SingleTapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']/method[@name='setUseSensorRotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseSensorRotation", "(Z)V", "")]
		public unsafe void SetUseSensorRotation (bool useSensorRotation)
		{
			const string __id = "setUseSensorRotation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (useSensorRotation);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='SphericalGLSurfaceView']/method[@name='setVideoComponent' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.VideoComponent']]"
		[Register ("setVideoComponent", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent;)V", "")]
		public unsafe void SetVideoComponent (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent newVideoComponent)
		{
			const string __id = "setVideoComponent.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newVideoComponent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newVideoComponent).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newVideoComponent);
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.SingleTapEventArgs> SingleTap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerImplementor>(
				ref weak_implementor_SetSingleTapListener,
				__CreateISingleTapListenerImplementor,
				SetSingleTapListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerImplementor>(
				ref weak_implementor_SetSingleTapListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerImplementor.__IsEmpty,
				__v => SetSingleTapListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetSingleTapListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerImplementor __CreateISingleTapListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ISingleTapListenerImplementor (this);
		}

		#endregion

	}
}
