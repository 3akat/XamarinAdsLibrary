using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']"
	[Register ("com/example/androidtvlibrary/main/adapter/Loadable", "", "Com.Example.Androidtvlibrary.Main.Adapter.ILoadableInvoker")]
	public partial interface ILoadable : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']/method[@name='cancelLoad' and count(parameter)=0]"
		[Register ("cancelLoad", "()V", "GetCancelLoadHandler:Com.Example.Androidtvlibrary.Main.Adapter.ILoadableInvoker, PausedAdsAndroidTV.Binding")]
		void CancelLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Loadable']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler:Com.Example.Androidtvlibrary.Main.Adapter.ILoadableInvoker, PausedAdsAndroidTV.Binding")]
		void Load ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Loadable", DoNotGenerateAcw=true)]
	internal partial class ILoadableInvoker : global::Java.Lang.Object, ILoadable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Loadable", typeof (ILoadableInvoker));

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

		public static ILoadable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Loadable'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelLoad;
#pragma warning disable 0169
		static Delegate GetCancelLoadHandler ()
		{
			if (cb_cancelLoad == null)
				cb_cancelLoad = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelLoad);
			return cb_cancelLoad;
		}

		static void n_CancelLoad (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ILoadable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelLoad ();
		}
#pragma warning restore 0169

		IntPtr id_cancelLoad;
		public unsafe void CancelLoad ()
		{
			if (id_cancelLoad == IntPtr.Zero)
				id_cancelLoad = JNIEnv.GetMethodID (class_ref, "cancelLoad", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelLoad);
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ILoadable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		IntPtr id_load;
		public unsafe void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load);
		}

	}
}
