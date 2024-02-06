using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/HandlerWrapper", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker")]
	public partial interface IHandlerWrapper : IJavaObject, IJavaPeerable {
		global::Android.OS.Looper Looper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='getLooper' and count(parameter)=0]"
			[Register ("getLooper", "()Landroid/os/Looper;", "GetGetLooperHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='obtainMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("obtainMessage", "(I)Landroid/os/Message;", "GetObtainMessage_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		global::Android.OS.Message ObtainMessage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='obtainMessage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("obtainMessage", "(III)Landroid/os/Message;", "GetObtainMessage_IIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		global::Android.OS.Message ObtainMessage (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='obtainMessage' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object']]"
		[Register ("obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;", "GetObtainMessage_IIILjava_lang_Object_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		global::Android.OS.Message ObtainMessage (int p0, int p1, int p2, global::Java.Lang.Object p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='obtainMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;", "GetObtainMessage_ILjava_lang_Object_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		global::Android.OS.Message ObtainMessage (int p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("post", "(Ljava/lang/Runnable;)Z", "GetPost_Ljava_lang_Runnable_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		bool Post (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='postDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("postDelayed", "(Ljava/lang/Runnable;J)Z", "GetPostDelayed_Ljava_lang_Runnable_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		bool PostDelayed (global::Java.Lang.IRunnable p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='removeCallbacksAndMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeCallbacksAndMessages", "(Ljava/lang/Object;)V", "GetRemoveCallbacksAndMessages_Ljava_lang_Object_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveCallbacksAndMessages (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='removeMessages' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeMessages", "(I)V", "GetRemoveMessages_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveMessages (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='sendEmptyMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendEmptyMessage", "(I)Z", "GetSendEmptyMessage_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		bool SendEmptyMessage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='HandlerWrapper']/method[@name='sendEmptyMessageAtTime' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("sendEmptyMessageAtTime", "(IJ)Z", "GetSendEmptyMessageAtTime_IJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapperInvoker, PausedAdsAndroidTV.Binding")]
		bool SendEmptyMessageAtTime (int p0, long p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/HandlerWrapper", DoNotGenerateAcw=true)]
	internal partial class IHandlerWrapperInvoker : global::Java.Lang.Object, IHandlerWrapper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/HandlerWrapper", typeof (IHandlerWrapperInvoker));

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

		public static IHandlerWrapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHandlerWrapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.HandlerWrapper'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHandlerWrapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLooper;
#pragma warning disable 0169
		static Delegate GetGetLooperHandler ()
		{
			if (cb_getLooper == null)
				cb_getLooper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLooper);
			return cb_getLooper;
		}

		static IntPtr n_GetLooper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Looper);
		}
#pragma warning restore 0169

		IntPtr id_getLooper;
		public unsafe global::Android.OS.Looper Looper {
			get {
				if (id_getLooper == IntPtr.Zero)
					id_getLooper = JNIEnv.GetMethodID (class_ref, "getLooper", "()Landroid/os/Looper;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLooper), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_obtainMessage_I;
#pragma warning disable 0169
		static Delegate GetObtainMessage_IHandler ()
		{
			if (cb_obtainMessage_I == null)
				cb_obtainMessage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ObtainMessage_I);
			return cb_obtainMessage_I;
		}

		static IntPtr n_ObtainMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainMessage (p0));
		}
#pragma warning restore 0169

		IntPtr id_obtainMessage_I;
		public unsafe global::Android.OS.Message ObtainMessage (int p0)
		{
			if (id_obtainMessage_I == IntPtr.Zero)
				id_obtainMessage_I = JNIEnv.GetMethodID (class_ref, "obtainMessage", "(I)Landroid/os/Message;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.OS.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainMessage_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_obtainMessage_III;
#pragma warning disable 0169
		static Delegate GetObtainMessage_IIIHandler ()
		{
			if (cb_obtainMessage_III == null)
				cb_obtainMessage_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_L) n_ObtainMessage_III);
			return cb_obtainMessage_III;
		}

		static IntPtr n_ObtainMessage_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainMessage (p0, p1, p2));
		}
#pragma warning restore 0169

		IntPtr id_obtainMessage_III;
		public unsafe global::Android.OS.Message ObtainMessage (int p0, int p1, int p2)
		{
			if (id_obtainMessage_III == IntPtr.Zero)
				id_obtainMessage_III = JNIEnv.GetMethodID (class_ref, "obtainMessage", "(III)Landroid/os/Message;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return global::Java.Lang.Object.GetObject<global::Android.OS.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainMessage_III, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_obtainMessage_IIILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetObtainMessage_IIILjava_lang_Object_Handler ()
		{
			if (cb_obtainMessage_IIILjava_lang_Object_ == null)
				cb_obtainMessage_IIILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_L) n_ObtainMessage_IIILjava_lang_Object_);
			return cb_obtainMessage_IIILjava_lang_Object_;
		}

		static IntPtr n_ObtainMessage_IIILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObtainMessage (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_obtainMessage_IIILjava_lang_Object_;
		public unsafe global::Android.OS.Message ObtainMessage (int p0, int p1, int p2, global::Java.Lang.Object p3)
		{
			if (id_obtainMessage_IIILjava_lang_Object_ == IntPtr.Zero)
				id_obtainMessage_IIILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainMessage_IIILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_obtainMessage_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetObtainMessage_ILjava_lang_Object_Handler ()
		{
			if (cb_obtainMessage_ILjava_lang_Object_ == null)
				cb_obtainMessage_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_ObtainMessage_ILjava_lang_Object_);
			return cb_obtainMessage_ILjava_lang_Object_;
		}

		static IntPtr n_ObtainMessage_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObtainMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_obtainMessage_ILjava_lang_Object_;
		public unsafe global::Android.OS.Message ObtainMessage (int p0, global::Java.Lang.Object p1)
		{
			if (id_obtainMessage_ILjava_lang_Object_ == IntPtr.Zero)
				id_obtainMessage_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainMessage_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_post_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_Runnable_Handler ()
		{
			if (cb_post_Ljava_lang_Runnable_ == null)
				cb_post_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Post_Ljava_lang_Runnable_);
			return cb_post_Ljava_lang_Runnable_;
		}

		static bool n_Post_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Post (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_post_Ljava_lang_Runnable_;
		public unsafe bool Post (global::Java.Lang.IRunnable p0)
		{
			if (id_post_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_post_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/Runnable;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_Runnable_, __args);
			return __ret;
		}

		static Delegate cb_postDelayed_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetPostDelayed_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_postDelayed_Ljava_lang_Runnable_J == null)
				cb_postDelayed_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_Z) n_PostDelayed_Ljava_lang_Runnable_J);
			return cb_postDelayed_Ljava_lang_Runnable_J;
		}

		static bool n_PostDelayed_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PostDelayed (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_postDelayed_Ljava_lang_Runnable_J;
		public unsafe bool PostDelayed (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_postDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_postDelayed_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_postDelayed_Ljava_lang_Runnable_J, __args);
			return __ret;
		}

		static Delegate cb_removeCallbacksAndMessages_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveCallbacksAndMessages_Ljava_lang_Object_Handler ()
		{
			if (cb_removeCallbacksAndMessages_Ljava_lang_Object_ == null)
				cb_removeCallbacksAndMessages_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveCallbacksAndMessages_Ljava_lang_Object_);
			return cb_removeCallbacksAndMessages_Ljava_lang_Object_;
		}

		static void n_RemoveCallbacksAndMessages_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallbacksAndMessages (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCallbacksAndMessages_Ljava_lang_Object_;
		public unsafe void RemoveCallbacksAndMessages (global::Java.Lang.Object p0)
		{
			if (id_removeCallbacksAndMessages_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeCallbacksAndMessages_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallbacksAndMessages_Ljava_lang_Object_, __args);
		}

		static Delegate cb_removeMessages_I;
#pragma warning disable 0169
		static Delegate GetRemoveMessages_IHandler ()
		{
			if (cb_removeMessages_I == null)
				cb_removeMessages_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_RemoveMessages_I);
			return cb_removeMessages_I;
		}

		static void n_RemoveMessages_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessages (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeMessages_I;
		public unsafe void RemoveMessages (int p0)
		{
			if (id_removeMessages_I == IntPtr.Zero)
				id_removeMessages_I = JNIEnv.GetMethodID (class_ref, "removeMessages", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMessages_I, __args);
		}

		static Delegate cb_sendEmptyMessage_I;
#pragma warning disable 0169
		static Delegate GetSendEmptyMessage_IHandler ()
		{
			if (cb_sendEmptyMessage_I == null)
				cb_sendEmptyMessage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SendEmptyMessage_I);
			return cb_sendEmptyMessage_I;
		}

		static bool n_SendEmptyMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendEmptyMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendEmptyMessage_I;
		public unsafe bool SendEmptyMessage (int p0)
		{
			if (id_sendEmptyMessage_I == IntPtr.Zero)
				id_sendEmptyMessage_I = JNIEnv.GetMethodID (class_ref, "sendEmptyMessage", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendEmptyMessage_I, __args);
		}

		static Delegate cb_sendEmptyMessageAtTime_IJ;
#pragma warning disable 0169
		static Delegate GetSendEmptyMessageAtTime_IJHandler ()
		{
			if (cb_sendEmptyMessageAtTime_IJ == null)
				cb_sendEmptyMessageAtTime_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_Z) n_SendEmptyMessageAtTime_IJ);
			return cb_sendEmptyMessageAtTime_IJ;
		}

		static bool n_SendEmptyMessageAtTime_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IHandlerWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendEmptyMessageAtTime (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendEmptyMessageAtTime_IJ;
		public unsafe bool SendEmptyMessageAtTime (int p0, long p1)
		{
			if (id_sendEmptyMessageAtTime_IJ == IntPtr.Zero)
				id_sendEmptyMessageAtTime_IJ = JNIEnv.GetMethodID (class_ref, "sendEmptyMessageAtTime", "(IJ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendEmptyMessageAtTime_IJ, __args);
		}

	}
}
