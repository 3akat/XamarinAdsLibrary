using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer", DoNotGenerateAcw=true)]
	public partial class VideoDecoderOutputBuffer : global::Com.Example.Androidtvlibrary.Main.Adapter.OutputBuffer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='colorspace']"
		[Register ("colorspace")]
		public int Colorspace {
			get {
				const string __id = "colorspace.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "colorspace.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='COLORSPACE_BT2020']"
		[Register ("COLORSPACE_BT2020")]
		public const int ColorspaceBt2020 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='COLORSPACE_BT601']"
		[Register ("COLORSPACE_BT601")]
		public const int ColorspaceBt601 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='COLORSPACE_BT709']"
		[Register ("COLORSPACE_BT709")]
		public const int ColorspaceBt709 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='COLORSPACE_UNKNOWN']"
		[Register ("COLORSPACE_UNKNOWN")]
		public const int ColorspaceUnknown = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='data']"
		[Register ("data")]
		public global::Java.Nio.ByteBuffer Data {
			get {
				const string __id = "data.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "data.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='decoderPrivate']"
		[Register ("decoderPrivate")]
		public int DecoderPrivate {
			get {
				const string __id = "decoderPrivate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "decoderPrivate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='mode']"
		[Register ("mode")]
		public int Mode {
			get {
				const string __id = "mode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='supplementalData']"
		[Register ("supplementalData")]
		public global::Java.Nio.ByteBuffer SupplementalData {
			get {
				const string __id = "supplementalData.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "supplementalData.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				const string __id = "width.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "width.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='yuvPlanes']"
		[Register ("yuvPlanes")]
		public IList<Java.Nio.ByteBuffer> YuvPlanes {
			get {
				const string __id = "yuvPlanes.[Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Java.Nio.ByteBuffer>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "yuvPlanes.[Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/field[@name='yuvStrides']"
		[Register ("yuvStrides")]
		public IList<int> YuvStrides {
			get {
				const string __id = "yuvStrides.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "yuvStrides.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='VideoDecoderOutputBuffer.Owner']"
		[Register ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer$Owner", "", "Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer/IOwnerInvoker")]
		public partial interface IOwner : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='VideoDecoderOutputBuffer.Owner']/method[@name='releaseOutputBuffer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBuffer']]"
			[Register ("releaseOutputBuffer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer;)V", "GetReleaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer/IOwnerInvoker, PausedAdsAndroidTV.Binding")]
			void ReleaseOutputBuffer (global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer$Owner", DoNotGenerateAcw=true)]
		internal partial class IOwnerInvoker : global::Java.Lang.Object, IOwner {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer$Owner", typeof (IOwnerInvoker));

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

			public static IOwner GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOwner> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBuffer.Owner'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOwnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_;
#pragma warning disable 0169
			static Delegate GetReleaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_Handler ()
			{
				if (cb_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ == null)
					cb_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_);
				return cb_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_;
			}

			static void n_ReleaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer.IOwner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ReleaseOutputBuffer (p0);
			}
#pragma warning restore 0169

			IntPtr id_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_;
			public unsafe void ReleaseOutputBuffer (global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer p0)
			{
				if (id_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ == IntPtr.Zero)
					id_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_ = JNIEnv.GetMethodID (class_ref, "releaseOutputBuffer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseOutputBuffer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBuffer_, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer", typeof (VideoDecoderOutputBuffer));

		internal static new IntPtr class_ref {
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

		protected VideoDecoderOutputBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/constructor[@name='VideoDecoderOutputBuffer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBuffer.Owner']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer$Owner;)V", "")]
		public unsafe VideoDecoderOutputBuffer (global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer.IOwner owner) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBuffer$Owner;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((owner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) owner).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (owner);
			}
		}

		static Delegate cb_init_JILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetInit_JILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_init_JILjava_nio_ByteBuffer_ == null)
				cb_init_JILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJIL_V) n_Init_JILjava_nio_ByteBuffer_);
			return cb_init_JILjava_nio_ByteBuffer_;
		}

		static void n_Init_JILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, long timeUs, int mode, IntPtr native_supplementalData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var supplementalData = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_supplementalData, JniHandleOwnership.DoNotTransfer);
			__this.Init (timeUs, mode, supplementalData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/method[@name='init' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("init", "(JILjava/nio/ByteBuffer;)V", "GetInit_JILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Init (long timeUs, int mode, global::Java.Nio.ByteBuffer supplementalData)
		{
			const string __id = "init.(JILjava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (timeUs);
				__args [1] = new JniArgumentValue (mode);
				__args [2] = new JniArgumentValue ((supplementalData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplementalData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (supplementalData);
			}
		}

		static Delegate cb_initForPrivateFrame_II;
#pragma warning disable 0169
		static Delegate GetInitForPrivateFrame_IIHandler ()
		{
			if (cb_initForPrivateFrame_II == null)
				cb_initForPrivateFrame_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_InitForPrivateFrame_II);
			return cb_initForPrivateFrame_II;
		}

		static void n_InitForPrivateFrame_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitForPrivateFrame (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/method[@name='initForPrivateFrame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initForPrivateFrame", "(II)V", "GetInitForPrivateFrame_IIHandler")]
		public virtual unsafe void InitForPrivateFrame (int width, int height)
		{
			const string __id = "initForPrivateFrame.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initForYuvFrame_IIIII;
#pragma warning disable 0169
		static Delegate GetInitForYuvFrame_IIIIIHandler ()
		{
			if (cb_initForYuvFrame_IIIII == null)
				cb_initForYuvFrame_IIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIII_Z) n_InitForYuvFrame_IIIII);
			return cb_initForYuvFrame_IIIII;
		}

		static bool n_InitForYuvFrame_IIIII (IntPtr jnienv, IntPtr native__this, int width, int height, int yStride, int uvStride, int colorspace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitForYuvFrame (width, height, yStride, uvStride, colorspace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/method[@name='initForYuvFrame' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("initForYuvFrame", "(IIIII)Z", "GetInitForYuvFrame_IIIIIHandler")]
		public virtual unsafe bool InitForYuvFrame (int width, int height, int yStride, int uvStride, int colorspace)
		{
			const string __id = "initForYuvFrame.(IIIII)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (yStride);
				__args [3] = new JniArgumentValue (uvStride);
				__args [4] = new JniArgumentValue (colorspace);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.VideoDecoderOutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='VideoDecoderOutputBuffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
