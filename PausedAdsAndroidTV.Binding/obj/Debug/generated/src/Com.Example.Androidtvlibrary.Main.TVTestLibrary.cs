using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main']/class[@name='TVTestLibrary']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/TVTestLibrary", DoNotGenerateAcw=true)]
	public partial class TVTestLibrary : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/TVTestLibrary", typeof (TVTestLibrary));

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

		protected TVTestLibrary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main']/class[@name='TVTestLibrary']/constructor[@name='TVTestLibrary' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TVTestLibrary () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getInstance;
#pragma warning disable 0169
		static Delegate GetGetInstanceHandler ()
		{
			if (cb_getInstance == null)
				cb_getInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInstance);
			return cb_getInstance;
		}

		static IntPtr n_GetInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.TVTestLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instance);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.TVTestLibrary Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main']/class[@name='TVTestLibrary']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/example/androidtvlibrary/main/TVTestLibrary;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/example/androidtvlibrary/main/TVTestLibrary;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.TVTestLibrary> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_adAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_Z;
#pragma warning disable 0169
		static Delegate GetAdAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_ZHandler ()
		{
			if (cb_adAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_Z == null)
				cb_adAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLZ_V) n_AdAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_Z);
			return cb_adAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_Z;
		}

		static void n_AdAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_pauseCallback, IntPtr native_resumeCallback, bool skipped)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.TVTestLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var pauseCallback = (global::Com.Example.Androidtvlibrary.Main.IPauseCallback)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.IPauseCallback> (native_pauseCallback, JniHandleOwnership.DoNotTransfer);
			var resumeCallback = (global::Com.Example.Androidtvlibrary.Main.IResumeCallback)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.IResumeCallback> (native_resumeCallback, JniHandleOwnership.DoNotTransfer);
			__this.AdAdsLoader (context, pauseCallback, resumeCallback, skipped);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main']/class[@name='TVTestLibrary']/method[@name='adAdsLoader' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.PauseCallback'] and parameter[3][@type='com.example.androidtvlibrary.main.ResumeCallback'] and parameter[4][@type='boolean']]"
		[Register ("adAdsLoader", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/PauseCallback;Lcom/example/androidtvlibrary/main/ResumeCallback;Z)V", "GetAdAdsLoader_Landroid_content_Context_Lcom_example_androidtvlibrary_main_PauseCallback_Lcom_example_androidtvlibrary_main_ResumeCallback_ZHandler")]
		public virtual unsafe void AdAdsLoader (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.IPauseCallback pauseCallback, global::Com.Example.Androidtvlibrary.Main.IResumeCallback resumeCallback, bool skipped)
		{
			const string __id = "adAdsLoader.(Landroid/content/Context;Lcom/example/androidtvlibrary/main/PauseCallback;Lcom/example/androidtvlibrary/main/ResumeCallback;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((pauseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pauseCallback).Handle);
				__args [2] = new JniArgumentValue ((resumeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resumeCallback).Handle);
				__args [3] = new JniArgumentValue (skipped);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (pauseCallback);
				global::System.GC.KeepAlive (resumeCallback);
			}
		}

		static Delegate cb_closeAdsManager;
#pragma warning disable 0169
		static Delegate GetCloseAdsManagerHandler ()
		{
			if (cb_closeAdsManager == null)
				cb_closeAdsManager = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseAdsManager);
			return cb_closeAdsManager;
		}

		static void n_CloseAdsManager (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.TVTestLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAdsManager ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main']/class[@name='TVTestLibrary']/method[@name='closeAdsManager' and count(parameter)=0]"
		[Register ("closeAdsManager", "()V", "GetCloseAdsManagerHandler")]
		public virtual unsafe void CloseAdsManager ()
		{
			const string __id = "closeAdsManager.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startAdsLoader_Landroid_content_Context_Z;
#pragma warning disable 0169
		static Delegate GetStartAdsLoader_Landroid_content_Context_ZHandler ()
		{
			if (cb_startAdsLoader_Landroid_content_Context_Z == null)
				cb_startAdsLoader_Landroid_content_Context_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_StartAdsLoader_Landroid_content_Context_Z);
			return cb_startAdsLoader_Landroid_content_Context_Z;
		}

		static void n_StartAdsLoader_Landroid_content_Context_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_context, bool skipped)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.TVTestLibrary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.StartAdsLoader (context, skipped);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main']/class[@name='TVTestLibrary']/method[@name='startAdsLoader' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("startAdsLoader", "(Landroid/content/Context;Z)V", "GetStartAdsLoader_Landroid_content_Context_ZHandler")]
		public virtual unsafe void StartAdsLoader (global::Android.Content.Context context, bool skipped)
		{
			const string __id = "startAdsLoader.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (skipped);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
