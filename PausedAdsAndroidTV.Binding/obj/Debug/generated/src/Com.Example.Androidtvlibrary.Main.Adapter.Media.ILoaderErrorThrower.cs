using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='LoaderErrorThrower.Dummy']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/LoaderErrorThrower$Dummy", DoNotGenerateAcw=true)]
	public sealed partial class LoaderErrorThrowerDummy : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrower {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/LoaderErrorThrower$Dummy", typeof (LoaderErrorThrowerDummy));

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

		internal LoaderErrorThrowerDummy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='LoaderErrorThrower.Dummy']/constructor[@name='LoaderErrorThrower.Dummy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoaderErrorThrowerDummy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='LoaderErrorThrower.Dummy']/method[@name='maybeThrowError' and count(parameter)=0]"
		[Register ("maybeThrowError", "()V", "")]
		public unsafe void MaybeThrowError ()
		{
			const string __id = "maybeThrowError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='LoaderErrorThrower.Dummy']/method[@name='maybeThrowError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maybeThrowError", "(I)V", "")]
		public unsafe void MaybeThrowError (int minRetryCount)
		{
			const string __id = "maybeThrowError.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minRetryCount);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoaderErrorThrower']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/LoaderErrorThrower", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrowerInvoker")]
	public partial interface ILoaderErrorThrower : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoaderErrorThrower']/method[@name='maybeThrowError' and count(parameter)=0]"
		[Register ("maybeThrowError", "()V", "GetMaybeThrowErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrowerInvoker, PausedAdsAndroidTV.Binding")]
		void MaybeThrowError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='LoaderErrorThrower']/method[@name='maybeThrowError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maybeThrowError", "(I)V", "GetMaybeThrowError_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrowerInvoker, PausedAdsAndroidTV.Binding")]
		void MaybeThrowError (int p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/LoaderErrorThrower", DoNotGenerateAcw=true)]
	internal partial class ILoaderErrorThrowerInvoker : global::Java.Lang.Object, ILoaderErrorThrower {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/LoaderErrorThrower", typeof (ILoaderErrorThrowerInvoker));

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

		public static ILoaderErrorThrower GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoaderErrorThrower> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.LoaderErrorThrower'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoaderErrorThrowerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_maybeThrowError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowErrorHandler ()
		{
			if (cb_maybeThrowError == null)
				cb_maybeThrowError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowError);
			return cb_maybeThrowError;
		}

		static void n_MaybeThrowError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrower> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowError ();
		}
#pragma warning restore 0169

		IntPtr id_maybeThrowError;
		public unsafe void MaybeThrowError ()
		{
			if (id_maybeThrowError == IntPtr.Zero)
				id_maybeThrowError = JNIEnv.GetMethodID (class_ref, "maybeThrowError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_maybeThrowError);
		}

		static Delegate cb_maybeThrowError_I;
#pragma warning disable 0169
		static Delegate GetMaybeThrowError_IHandler ()
		{
			if (cb_maybeThrowError_I == null)
				cb_maybeThrowError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_MaybeThrowError_I);
			return cb_maybeThrowError_I;
		}

		static void n_MaybeThrowError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrower> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowError (p0);
		}
#pragma warning restore 0169

		IntPtr id_maybeThrowError_I;
		public unsafe void MaybeThrowError (int p0)
		{
			if (id_maybeThrowError_I == IntPtr.Zero)
				id_maybeThrowError_I = JNIEnv.GetMethodID (class_ref, "maybeThrowError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_maybeThrowError_I, __args);
		}

	}
}
