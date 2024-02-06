using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='ProjectionRenderer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/ProjectionRenderer", DoNotGenerateAcw=true)]
	public sealed partial class ProjectionRenderer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/ProjectionRenderer", typeof (ProjectionRenderer));

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

		internal ProjectionRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='ProjectionRenderer']/constructor[@name='ProjectionRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProjectionRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='ProjectionRenderer']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.Projection']]"
		[Register ("isSupported", "(Lcom/example/androidtvlibrary/main/adapter/player/Projection;)Z", "")]
		public static unsafe bool IsSupported (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection projection)
		{
			const string __id = "isSupported.(Lcom/example/androidtvlibrary/main/adapter/player/Projection;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((projection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) projection).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (projection);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='ProjectionRenderer']/method[@name='setProjection' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.Projection']]"
		[Register ("setProjection", "(Lcom/example/androidtvlibrary/main/adapter/player/Projection;)V", "")]
		public unsafe void SetProjection (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection projection)
		{
			const string __id = "setProjection.(Lcom/example/androidtvlibrary/main/adapter/player/Projection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((projection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) projection).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (projection);
			}
		}

	}
}
