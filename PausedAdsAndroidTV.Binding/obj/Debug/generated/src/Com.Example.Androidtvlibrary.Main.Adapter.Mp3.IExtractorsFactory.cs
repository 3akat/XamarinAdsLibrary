using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='ExtractorsFactory']"
	[Register ("com/example/androidtvlibrary/main/adapter/mp3/ExtractorsFactory", "", "Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactoryInvoker")]
	public partial interface IExtractorsFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='ExtractorsFactory']/method[@name='createExtractors' and count(parameter)=0]"
		[Register ("createExtractors", "()[Lcom/example/androidtvlibrary/main/adapter/Media/Extractor;", "GetCreateExtractorsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1[] CreateExtractors ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/ExtractorsFactory", DoNotGenerateAcw=true)]
	internal partial class IExtractorsFactoryInvoker : global::Java.Lang.Object, IExtractorsFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/ExtractorsFactory", typeof (IExtractorsFactoryInvoker));

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

		public static IExtractorsFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExtractorsFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.mp3.ExtractorsFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExtractorsFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createExtractors;
#pragma warning disable 0169
		static Delegate GetCreateExtractorsHandler ()
		{
			if (cb_createExtractors == null)
				cb_createExtractors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateExtractors);
			return cb_createExtractors;
		}

		static IntPtr n_CreateExtractors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.CreateExtractors ());
		}
#pragma warning restore 0169

		IntPtr id_createExtractors;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1[] CreateExtractors ()
		{
			if (id_createExtractors == IntPtr.Zero)
				id_createExtractors = JNIEnv.GetMethodID (class_ref, "createExtractors", "()[Lcom/example/androidtvlibrary/main/adapter/Media/Extractor;");
			return (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createExtractors), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1));
		}

	}
}
