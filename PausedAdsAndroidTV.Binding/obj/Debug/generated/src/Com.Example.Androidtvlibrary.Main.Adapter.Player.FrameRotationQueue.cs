using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameRotationQueue']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/FrameRotationQueue", DoNotGenerateAcw=true)]
	public sealed partial class FrameRotationQueue : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/FrameRotationQueue", typeof (FrameRotationQueue));

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

		internal FrameRotationQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameRotationQueue']/constructor[@name='FrameRotationQueue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FrameRotationQueue () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameRotationQueue']/method[@name='computeRecenterMatrix' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("computeRecenterMatrix", "([F[F)V", "")]
		public static unsafe void ComputeRecenterMatrix (float[] recenterMatrix, float[] rotationMatrix)
		{
			const string __id = "computeRecenterMatrix.([F[F)V";
			IntPtr native_recenterMatrix = JNIEnv.NewArray (recenterMatrix);
			IntPtr native_rotationMatrix = JNIEnv.NewArray (rotationMatrix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_recenterMatrix);
				__args [1] = new JniArgumentValue (native_rotationMatrix);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (recenterMatrix != null) {
					JNIEnv.CopyArray (native_recenterMatrix, recenterMatrix);
					JNIEnv.DeleteLocalRef (native_recenterMatrix);
				}
				if (rotationMatrix != null) {
					JNIEnv.CopyArray (native_rotationMatrix, rotationMatrix);
					JNIEnv.DeleteLocalRef (native_rotationMatrix);
				}
				global::System.GC.KeepAlive (recenterMatrix);
				global::System.GC.KeepAlive (rotationMatrix);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameRotationQueue']/method[@name='pollRotationMatrix' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='long']]"
		[Register ("pollRotationMatrix", "([FJ)Z", "")]
		public unsafe bool PollRotationMatrix (float[] matrix, long timestampUs)
		{
			const string __id = "pollRotationMatrix.([FJ)Z";
			IntPtr native_matrix = JNIEnv.NewArray (matrix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_matrix);
				__args [1] = new JniArgumentValue (timestampUs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (matrix != null) {
					JNIEnv.CopyArray (native_matrix, matrix);
					JNIEnv.DeleteLocalRef (native_matrix);
				}
				global::System.GC.KeepAlive (matrix);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameRotationQueue']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameRotationQueue']/method[@name='setRotation' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float[]']]"
		[Register ("setRotation", "(J[F)V", "")]
		public unsafe void SetRotation (long timestampUs, float[] angleAxis)
		{
			const string __id = "setRotation.(J[F)V";
			IntPtr native_angleAxis = JNIEnv.NewArray (angleAxis);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timestampUs);
				__args [1] = new JniArgumentValue (native_angleAxis);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (angleAxis != null) {
					JNIEnv.CopyArray (native_angleAxis, angleAxis);
					JNIEnv.DeleteLocalRef (native_angleAxis);
				}
				global::System.GC.KeepAlive (angleAxis);
			}
		}

	}
}
