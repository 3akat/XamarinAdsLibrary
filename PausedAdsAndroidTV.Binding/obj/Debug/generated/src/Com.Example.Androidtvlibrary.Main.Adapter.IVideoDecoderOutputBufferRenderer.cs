using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='VideoDecoderOutputBufferRenderer']"
	[Register ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer", "", "Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRendererInvoker")]
	public partial interface IVideoDecoderOutputBufferRenderer : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='VideoDecoderOutputBufferRenderer']/method[@name='setOutputBuffer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBuffer']]"
		[Register ("setOutputBuffer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer;)V", "GetSetOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRendererInvoker, PausedAdsAndroidTV.Binding")]
		void SetOutputBuffer (global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer", DoNotGenerateAcw=true)]
	internal partial class IVideoDecoderOutputBufferRendererInvoker : global::Java.Lang.Object, IVideoDecoderOutputBufferRenderer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer", typeof (IVideoDecoderOutputBufferRendererInvoker));

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

		public static IVideoDecoderOutputBufferRenderer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoDecoderOutputBufferRenderer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBufferRenderer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoDecoderOutputBufferRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_;
#pragma warning disable 0169
		static Delegate GetSetOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_Handler ()
		{
			if (cb_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ == null)
				cb_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_);
			return cb_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_;
		}

		static void n_SetOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOutputBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_;
		public unsafe void SetOutputBuffer (global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer p0)
		{
			if (id_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ == IntPtr.Zero)
				id_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ = JNIEnv.GetMethodID (class_ref, "setOutputBuffer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_, __args);
		}

	}
}
