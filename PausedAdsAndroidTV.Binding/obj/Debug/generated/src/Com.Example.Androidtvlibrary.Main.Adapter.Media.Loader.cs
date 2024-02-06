using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Loader", DoNotGenerateAcw=true)]
	public sealed partial class Loader : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ILoaderErrorThrower {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/field[@name='DONT_RETRY']"
		[Register ("DONT_RETRY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction DontRetry {
			get {
				const string __id = "DONT_RETRY.Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/field[@name='DONT_RETRY_FATAL']"
		[Register ("DONT_RETRY_FATAL")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction DontRetryFatal {
			get {
				const string __id = "DONT_RETRY_FATAL.Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/field[@name='RETRY']"
		[Register ("RETRY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction Retry {
			get {
				const string __id = "RETRY.Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/field[@name='RETRY_RESET_ERROR_COUNT']"
		[Register ("RETRY_RESET_ERROR_COUNT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction RetryResetErrorCount {
			get {
				const string __id = "RETRY_RESET_ERROR_COUNT.Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Callback']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$Callback", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ICallbackInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.Media.Loader.Loadable"})]
		public partial interface ICallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Callback']/method[@name='onLoadCanceled' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='boolean']]"
			[Register ("onLoadCanceled", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;JJZ)V", "GetOnLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ICallbackInvoker, PausedAdsAndroidTV.Binding")]
			void OnLoadCanceled (global::Java.Lang.Object p0, long p1, long p2, bool p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Callback']/method[@name='onLoadCompleted' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
			[Register ("onLoadCompleted", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;JJ)V", "GetOnLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ICallbackInvoker, PausedAdsAndroidTV.Binding")]
			void OnLoadCompleted (global::Java.Lang.Object p0, long p1, long p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Callback']/method[@name='onLoadError' and count(parameter)=5 and parameter[1][@type='T'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.io.IOException'] and parameter[5][@type='int']]"
			[Register ("onLoadError", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;JJLjava/io/IOException;I)Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;", "GetOnLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ICallbackInvoker, PausedAdsAndroidTV.Binding")]
			global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction OnLoadError (global::Java.Lang.Object p0, long p1, long p2, global::Java.IO.IOException p3, int p4);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Loader$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.Loader.Callback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ;
#pragma warning disable 0169
			static Delegate GetOnLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZHandler ()
			{
				if (cb_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ == null)
					cb_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJZ_V) n_OnLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ);
				return cb_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ;
			}

			static void n_OnLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, bool p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadCanceled (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ;
			public unsafe void OnLoadCanceled (global::Java.Lang.Object p0, long p1, long p2, bool p3)
			{
				if (id_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ == IntPtr.Zero)
					id_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ = JNIEnv.GetMethodID (class_ref, "onLoadCanceled", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;JJZ)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadCanceled_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJZ, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ;
#pragma warning disable 0169
			static Delegate GetOnLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJHandler ()
			{
				if (cb_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ == null)
					cb_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_V) n_OnLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ);
				return cb_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ;
			}

			static void n_OnLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadCompleted (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ;
			public unsafe void OnLoadCompleted (global::Java.Lang.Object p0, long p1, long p2)
			{
				if (id_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ == IntPtr.Zero)
					id_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ = JNIEnv.GetMethodID (class_ref, "onLoadCompleted", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;JJ)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadCompleted_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJ, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I;
#pragma warning disable 0169
			static Delegate GetOnLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_IHandler ()
			{
				if (cb_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I == null)
					cb_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJLI_L) n_OnLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I);
				return cb_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I;
			}

			static IntPtr n_OnLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, IntPtr native_p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p3 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p3, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnLoadError (p0, p1, p2, p3, p4));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I;
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction OnLoadError (global::Java.Lang.Object p0, long p1, long p2, global::Java.IO.IOException p3, int p4)
			{
				if (id_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I == IntPtr.Zero)
					id_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I = JNIEnv.GetMethodID (class_ref, "onLoadError", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;JJLjava/io/IOException;I)Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p3).Handle);
				__args [4] = new JValue (p4);
				var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onLoadError_Lcom_example_androidtvlibrary_main_adapter_Media_Loader_Loadable_JJLjava_io_IOException_I, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Loadable']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$Loadable", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ILoadableInvoker")]
		public partial interface ILoadable : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Loadable']/method[@name='cancelLoad' and count(parameter)=0]"
			[Register ("cancelLoad", "()V", "GetCancelLoadHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ILoadableInvoker, PausedAdsAndroidTV.Binding")]
			void CancelLoad ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.Loadable']/method[@name='load' and count(parameter)=0]"
			[Register ("load", "()V", "GetLoadHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/ILoadableInvoker, PausedAdsAndroidTV.Binding")]
			void Load ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$Loadable", DoNotGenerateAcw=true)]
		internal partial class ILoadableInvoker : global::Java.Lang.Object, ILoadable {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Loader$Loadable", typeof (ILoadableInvoker));

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
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.Loader.Loadable'.");
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.ILoadable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.ILoadable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader.LoadErrorAction']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction", DoNotGenerateAcw=true)]
		public sealed partial class LoadErrorAction : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction", typeof (LoadErrorAction));

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

			internal LoadErrorAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe bool IsRetry {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader.LoadErrorAction']/method[@name='isRetry' and count(parameter)=0]"
				[Register ("isRetry", "()Z", "")]
				get {
					const string __id = "isRetry.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.ReleaseCallback']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$ReleaseCallback", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/IReleaseCallbackInvoker")]
		public partial interface IReleaseCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Loader.ReleaseCallback']/method[@name='onLoaderReleased' and count(parameter)=0]"
			[Register ("onLoaderReleased", "()V", "GetOnLoaderReleasedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader/IReleaseCallbackInvoker, PausedAdsAndroidTV.Binding")]
			void OnLoaderReleased ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$ReleaseCallback", DoNotGenerateAcw=true)]
		internal partial class IReleaseCallbackInvoker : global::Java.Lang.Object, IReleaseCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Loader$ReleaseCallback", typeof (IReleaseCallbackInvoker));

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

			public static IReleaseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IReleaseCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.Loader.ReleaseCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IReleaseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onLoaderReleased;
#pragma warning disable 0169
			static Delegate GetOnLoaderReleasedHandler ()
			{
				if (cb_onLoaderReleased == null)
					cb_onLoaderReleased = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnLoaderReleased);
				return cb_onLoaderReleased;
			}

			static void n_OnLoaderReleased (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.IReleaseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLoaderReleased ();
			}
#pragma warning restore 0169

			IntPtr id_onLoaderReleased;
			public unsafe void OnLoaderReleased ()
			{
				if (id_onLoaderReleased == IntPtr.Zero)
					id_onLoaderReleased = JNIEnv.GetMethodID (class_ref, "onLoaderReleased", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoaderReleased);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader.UnexpectedLoaderException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/Loader$UnexpectedLoaderException", DoNotGenerateAcw=true)]
		public sealed partial class UnexpectedLoaderException : global::Java.IO.IOException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Loader$UnexpectedLoaderException", typeof (UnexpectedLoaderException));

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

			internal UnexpectedLoaderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader.UnexpectedLoaderException']/constructor[@name='Loader.UnexpectedLoaderException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
			public unsafe UnexpectedLoaderException (global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Throwable;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (cause);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/Loader", typeof (Loader));

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

		internal Loader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/constructor[@name='Loader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Loader (string threadName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_threadName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		public unsafe bool HasFatalError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='hasFatalError' and count(parameter)=0]"
			[Register ("hasFatalError", "()Z", "")]
			get {
				const string __id = "hasFatalError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "")]
			get {
				const string __id = "isLoading.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='cancelLoading' and count(parameter)=0]"
		[Register ("cancelLoading", "()V", "")]
		public unsafe void CancelLoading ()
		{
			const string __id = "cancelLoading.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='clearFatalError' and count(parameter)=0]"
		[Register ("clearFatalError", "()V", "")]
		public unsafe void ClearFatalError ()
		{
			const string __id = "clearFatalError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='createRetryAction' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
		[Register ("createRetryAction", "(ZJ)Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction CreateRetryAction (bool resetErrorCount, long retryDelayMillis)
		{
			const string __id = "createRetryAction.(ZJ)Lcom/example/androidtvlibrary/main/adapter/Media/Loader$LoadErrorAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resetErrorCount);
				__args [1] = new JniArgumentValue (retryDelayMillis);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.LoadErrorAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='maybeThrowError' and count(parameter)=0]"
		[Register ("maybeThrowError", "()V", "")]
		public unsafe void MaybeThrowError ()
		{
			const string __id = "maybeThrowError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='maybeThrowError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.Loader.ReleaseCallback']]"
		[Register ("release", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$ReleaseCallback;)V", "")]
		public unsafe void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.IReleaseCallback @callback)
		{
			const string __id = "release.(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$ReleaseCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='Loader']/method[@name='startLoading' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.Loader.Callback&lt;T&gt;'] and parameter[3][@type='int']]"
		[Register ("startLoading", "(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Callback;I)J", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.Media.Loader.Loadable"})]
		public unsafe long StartLoading (global::Java.Lang.Object loadable, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Loader.ICallback @callback, int defaultMinRetryCount)
		{
			const string __id = "startLoading.(Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Loadable;Lcom/example/androidtvlibrary/main/adapter/Media/Loader$Callback;I)J";
			IntPtr native_loadable = JNIEnv.ToLocalJniHandle (loadable);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_loadable);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue (defaultMinRetryCount);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_loadable);
				global::System.GC.KeepAlive (loadable);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
