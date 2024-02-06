using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory", DoNotGenerateAcw=true)]
	public partial class DefaultRenderersFactory : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IRenderersFactory {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/field[@name='DEFAULT_ALLOWED_VIDEO_JOINING_TIME_MS']"
		[Register ("DEFAULT_ALLOWED_VIDEO_JOINING_TIME_MS")]
		public const long DefaultAllowedVideoJoiningTimeMs = (long) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/field[@name='EXTENSION_RENDERER_MODE_OFF']"
		[Register ("EXTENSION_RENDERER_MODE_OFF")]
		public const int ExtensionRendererModeOff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/field[@name='EXTENSION_RENDERER_MODE_ON']"
		[Register ("EXTENSION_RENDERER_MODE_ON")]
		public const int ExtensionRendererModeOn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/field[@name='EXTENSION_RENDERER_MODE_PREFER']"
		[Register ("EXTENSION_RENDERER_MODE_PREFER")]
		public const int ExtensionRendererModePrefer = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/field[@name='MAX_DROPPED_VIDEO_FRAME_COUNT_TO_NOTIFY']"
		[Register ("MAX_DROPPED_VIDEO_FRAME_COUNT_TO_NOTIFY")]
		protected const int MaxDroppedVideoFrameCountToNotify = (int) 50;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='DefaultRenderersFactory.ExtensionRendererMode']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory$ExtensionRendererMode", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory/IExtensionRendererModeInvoker")]
		public partial interface IExtensionRendererMode : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory$ExtensionRendererMode", DoNotGenerateAcw=true)]
		internal partial class IExtensionRendererModeInvoker : global::Java.Lang.Object, IExtensionRendererMode {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory$ExtensionRendererMode", typeof (IExtensionRendererModeInvoker));

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

			public static IExtensionRendererMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IExtensionRendererMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.DefaultRenderersFactory.ExtensionRendererMode'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IExtensionRendererModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory.IExtensionRendererMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory.IExtensionRendererMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe bool Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory.IExtensionRendererMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe int GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory.IExtensionRendererMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory", typeof (DefaultRenderersFactory));

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

		protected DefaultRenderersFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/constructor[@name='DefaultRenderersFactory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DefaultRenderersFactory (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/constructor[@name='DefaultRenderersFactory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultRenderersFactory (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/constructor[@name='DefaultRenderersFactory' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;I)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultRenderersFactory (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [2] = new JniArgumentValue (extensionRendererMode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/constructor[@name='DefaultRenderersFactory' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;IJ)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultRenderersFactory (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, long allowedVideoJoiningTimeMs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [2] = new JniArgumentValue (extensionRendererMode);
				__args [3] = new JniArgumentValue (allowedVideoJoiningTimeMs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/constructor[@name='DefaultRenderersFactory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultRenderersFactory (global::Android.Content.Context context, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (extensionRendererMode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/constructor[@name='DefaultRenderersFactory' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Landroid/content/Context;IJ)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultRenderersFactory (global::Android.Content.Context context, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, long allowedVideoJoiningTimeMs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (extensionRendererMode);
				__args [2] = new JniArgumentValue (allowedVideoJoiningTimeMs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_buildAudioProcessors;
#pragma warning disable 0169
		static Delegate GetBuildAudioProcessorsHandler ()
		{
			if (cb_buildAudioProcessors == null)
				cb_buildAudioProcessors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BuildAudioProcessors);
			return cb_buildAudioProcessors;
		}

		static IntPtr n_BuildAudioProcessors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BuildAudioProcessors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildAudioProcessors' and count(parameter)=0]"
		[Register ("buildAudioProcessors", "()[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;", "GetBuildAudioProcessorsHandler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] BuildAudioProcessors ()
		{
			const string __id = "buildAudioProcessors.()[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor));
			} finally {
			}
		}

		static Delegate cb_buildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_Handler ()
		{
			if (cb_buildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_ == null)
				cb_buildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILLZZLLLL_V) n_BuildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_);
			return cb_buildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_;
		}

		static void n_BuildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int extensionRendererMode, IntPtr native_mediaCodecSelector, IntPtr native_drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, IntPtr native_audioProcessors, IntPtr native_eventHandler, IntPtr native_eventListener, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			var drmSessionManager = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_drmSessionManager, JniHandleOwnership.DoNotTransfer);
			var audioProcessors = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[]) JNIEnv.GetArray (native_audioProcessors, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor));
			var eventHandler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_eventHandler, JniHandleOwnership.DoNotTransfer);
			var eventListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener> (native_eventListener, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.BuildAudioRenderers (context, extensionRendererMode, mediaCodecSelector, drmSessionManager, playClearSamplesWithoutKeys, enableDecoderFallback, audioProcessors, eventHandler, eventListener, @out);
			if (audioProcessors != null)
				JNIEnv.CopyArray (audioProcessors, native_audioProcessors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildAudioRenderers' and count(parameter)=10 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor[]'] and parameter[8][@type='android.os.Handler'] and parameter[9][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[10][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.wow.Renderer&gt;']]"
		[Register ("buildAudioRenderers", "(Landroid/content/Context;ILcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZ[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Ljava/util/ArrayList;)V", "GetBuildAudioRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZarrayLcom_example_androidtvlibrary_main_adapter_player_AudioProcessor_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Ljava_util_ArrayList_Handler")]
		protected virtual unsafe void BuildAudioRenderers (global::Android.Content.Context context, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] audioProcessors, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener eventListener, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> @out)
		{
			const string __id = "buildAudioRenderers.(Landroid/content/Context;ILcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZ[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Ljava/util/ArrayList;)V";
			IntPtr native_audioProcessors = JNIEnv.NewArray (audioProcessors);
			IntPtr native__out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (extensionRendererMode);
				__args [2] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [3] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [4] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [5] = new JniArgumentValue (enableDecoderFallback);
				__args [6] = new JniArgumentValue (native_audioProcessors);
				__args [7] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [8] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [9] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (audioProcessors != null) {
					JNIEnv.CopyArray (native_audioProcessors, audioProcessors);
					JNIEnv.DeleteLocalRef (native_audioProcessors);
				}
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (audioProcessors);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_buildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_Handler ()
		{
			if (cb_buildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_ == null)
				cb_buildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_BuildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_);
			return cb_buildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_;
		}

		static void n_BuildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int extensionRendererMode, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.BuildCameraMotionRenderers (context, extensionRendererMode, @out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildCameraMotionRenderers' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.wow.Renderer&gt;']]"
		[Register ("buildCameraMotionRenderers", "(Landroid/content/Context;ILjava/util/ArrayList;)V", "GetBuildCameraMotionRenderers_Landroid_content_Context_ILjava_util_ArrayList_Handler")]
		protected virtual unsafe void BuildCameraMotionRenderers (global::Android.Content.Context context, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> @out)
		{
			const string __id = "buildCameraMotionRenderers.(Landroid/content/Context;ILjava/util/ArrayList;)V";
			IntPtr native__out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (extensionRendererMode);
				__args [2] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_buildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_Handler ()
		{
			if (cb_buildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_ == null)
				cb_buildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLIL_V) n_BuildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_);
			return cb_buildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_;
		}

		static void n_BuildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_output, IntPtr native_outputLooper, int extensionRendererMode, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var output = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput> (native_output, JniHandleOwnership.DoNotTransfer);
			var outputLooper = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_outputLooper, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.BuildMetadataRenderers (context, output, outputLooper, extensionRendererMode, @out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildMetadataRenderers' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput'] and parameter[3][@type='android.os.Looper'] and parameter[4][@type='int'] and parameter[5][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.wow.Renderer&gt;']]"
		[Register ("buildMetadataRenderers", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Landroid/os/Looper;ILjava/util/ArrayList;)V", "GetBuildMetadataRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Landroid_os_Looper_ILjava_util_ArrayList_Handler")]
		protected virtual unsafe void BuildMetadataRenderers (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput output, global::Android.OS.Looper outputLooper, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> @out)
		{
			const string __id = "buildMetadataRenderers.(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Landroid/os/Looper;ILjava/util/ArrayList;)V";
			IntPtr native__out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [2] = new JniArgumentValue ((outputLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputLooper).Handle);
				__args [3] = new JniArgumentValue (extensionRendererMode);
				__args [4] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (outputLooper);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_buildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_Handler ()
		{
			if (cb_buildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_ == null)
				cb_buildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_V) n_BuildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_);
			return cb_buildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_;
		}

		static void n_BuildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_eventHandler, int extensionRendererMode, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var eventHandler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_eventHandler, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.BuildMiscellaneousRenderers (context, eventHandler, extensionRendererMode, @out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildMiscellaneousRenderers' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='int'] and parameter[4][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.wow.Renderer&gt;']]"
		[Register ("buildMiscellaneousRenderers", "(Landroid/content/Context;Landroid/os/Handler;ILjava/util/ArrayList;)V", "GetBuildMiscellaneousRenderers_Landroid_content_Context_Landroid_os_Handler_ILjava_util_ArrayList_Handler")]
		protected virtual unsafe void BuildMiscellaneousRenderers (global::Android.Content.Context context, global::Android.OS.Handler eventHandler, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> @out)
		{
			const string __id = "buildMiscellaneousRenderers.(Landroid/content/Context;Landroid/os/Handler;ILjava/util/ArrayList;)V";
			IntPtr native__out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [2] = new JniArgumentValue (extensionRendererMode);
				__args [3] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_buildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_Handler ()
		{
			if (cb_buildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_ == null)
				cb_buildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLIL_V) n_BuildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_);
			return cb_buildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_;
		}

		static void n_BuildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_output, IntPtr native_outputLooper, int extensionRendererMode, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var output = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput> (native_output, JniHandleOwnership.DoNotTransfer);
			var outputLooper = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_outputLooper, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.BuildTextRenderers (context, output, outputLooper, extensionRendererMode, @out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildTextRenderers' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.TextOutput'] and parameter[3][@type='android.os.Looper'] and parameter[4][@type='int'] and parameter[5][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.wow.Renderer&gt;']]"
		[Register ("buildTextRenderers", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;Landroid/os/Looper;ILjava/util/ArrayList;)V", "GetBuildTextRenderers_Landroid_content_Context_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Landroid_os_Looper_ILjava_util_ArrayList_Handler")]
		protected virtual unsafe void BuildTextRenderers (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput output, global::Android.OS.Looper outputLooper, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> @out)
		{
			const string __id = "buildTextRenderers.(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;Landroid/os/Looper;ILjava/util/ArrayList;)V";
			IntPtr native__out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [2] = new JniArgumentValue ((outputLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputLooper).Handle);
				__args [3] = new JniArgumentValue (extensionRendererMode);
				__args [4] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (outputLooper);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_buildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_Handler ()
		{
			if (cb_buildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_ == null)
				cb_buildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILLZZLLJL_V) n_BuildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_);
			return cb_buildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_;
		}

		static void n_BuildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int extensionRendererMode, IntPtr native_mediaCodecSelector, IntPtr native_drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, IntPtr native_eventHandler, IntPtr native_eventListener, long allowedVideoJoiningTimeMs, IntPtr native__out)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			var drmSessionManager = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_drmSessionManager, JniHandleOwnership.DoNotTransfer);
			var eventHandler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_eventHandler, JniHandleOwnership.DoNotTransfer);
			var eventListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener> (native_eventListener, JniHandleOwnership.DoNotTransfer);
			var @out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.BuildVideoRenderers (context, extensionRendererMode, mediaCodecSelector, drmSessionManager, playClearSamplesWithoutKeys, enableDecoderFallback, eventHandler, eventListener, allowedVideoJoiningTimeMs, @out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='buildVideoRenderers' and count(parameter)=10 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='android.os.Handler'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[9][@type='long'] and parameter[10][@type='java.util.ArrayList&lt;com.example.androidtvlibrary.main.adapter.wow.Renderer&gt;']]"
		[Register ("buildVideoRenderers", "(Landroid/content/Context;ILcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;JLjava/util/ArrayList;)V", "GetBuildVideoRenderers_Landroid_content_Context_ILcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ZZLandroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_JLjava_util_ArrayList_Handler")]
		protected virtual unsafe void BuildVideoRenderers (global::Android.Content.Context context, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager, bool playClearSamplesWithoutKeys, bool enableDecoderFallback, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener eventListener, long allowedVideoJoiningTimeMs, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> @out)
		{
			const string __id = "buildVideoRenderers.(Landroid/content/Context;ILcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;ZZLandroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;JLjava/util/ArrayList;)V";
			IntPtr native__out = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer>.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (extensionRendererMode);
				__args [2] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				__args [3] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				__args [4] = new JniArgumentValue (playClearSamplesWithoutKeys);
				__args [5] = new JniArgumentValue (enableDecoderFallback);
				__args [6] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [7] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [8] = new JniArgumentValue (allowedVideoJoiningTimeMs);
				__args [9] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mediaCodecSelector);
				global::System.GC.KeepAlive (drmSessionManager);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (@out);
			}
		}

		static Delegate cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
#pragma warning disable 0169
		static Delegate GetCreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Handler ()
		{
			if (cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ == null)
				cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_L) n_CreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_);
			return cb_createRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_;
		}

		static IntPtr n_CreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventHandler, IntPtr native_videoRendererEventListener, IntPtr native_audioRendererEventListener, IntPtr native_textRendererOutput, IntPtr native_metadataRendererOutput, IntPtr native_drmSessionManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventHandler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_eventHandler, JniHandleOwnership.DoNotTransfer);
			var videoRendererEventListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener> (native_videoRendererEventListener, JniHandleOwnership.DoNotTransfer);
			var audioRendererEventListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener> (native_audioRendererEventListener, JniHandleOwnership.DoNotTransfer);
			var textRendererOutput = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput> (native_textRendererOutput, JniHandleOwnership.DoNotTransfer);
			var metadataRendererOutput = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput> (native_metadataRendererOutput, JniHandleOwnership.DoNotTransfer);
			var drmSessionManager = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager> (native_drmSessionManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.CreateRenderers (eventHandler, videoRendererEventListener, audioRendererEventListener, textRendererOutput, metadataRendererOutput, drmSessionManager));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='createRenderers' and count(parameter)=6 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.VideoRendererEventListener'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.AudioRendererEventListener'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.TextOutput'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;com.example.androidtvlibrary.main.adapter.player.FrameworkMediaCrypto&gt;']]"
		[Register ("createRenderers", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)[Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;", "GetCreateRenderers_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_player_VideoRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioRendererEventListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Lcom_example_androidtvlibrary_main_adapter_Media_DrmSessionManager_Handler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] CreateRenderers (global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IVideoRendererEventListener videoRendererEventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioRendererEventListener audioRendererEventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput textRendererOutput, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput metadataRendererOutput, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager)
		{
			const string __id = "createRenderers.(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)[Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [1] = new JniArgumentValue ((videoRendererEventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoRendererEventListener).Handle);
				__args [2] = new JniArgumentValue ((audioRendererEventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioRendererEventListener).Handle);
				__args [3] = new JniArgumentValue ((textRendererOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textRendererOutput).Handle);
				__args [4] = new JniArgumentValue ((metadataRendererOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadataRendererOutput).Handle);
				__args [5] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer));
			} finally {
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (videoRendererEventListener);
				global::System.GC.KeepAlive (audioRendererEventListener);
				global::System.GC.KeepAlive (textRendererOutput);
				global::System.GC.KeepAlive (metadataRendererOutput);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		static Delegate cb_setAllowedVideoJoiningTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetAllowedVideoJoiningTimeMs_JHandler ()
		{
			if (cb_setAllowedVideoJoiningTimeMs_J == null)
				cb_setAllowedVideoJoiningTimeMs_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetAllowedVideoJoiningTimeMs_J);
			return cb_setAllowedVideoJoiningTimeMs_J;
		}

		static IntPtr n_SetAllowedVideoJoiningTimeMs_J (IntPtr jnienv, IntPtr native__this, long allowedVideoJoiningTimeMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAllowedVideoJoiningTimeMs (allowedVideoJoiningTimeMs));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='setAllowedVideoJoiningTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAllowedVideoJoiningTimeMs", "(J)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;", "GetSetAllowedVideoJoiningTimeMs_JHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory SetAllowedVideoJoiningTimeMs (long allowedVideoJoiningTimeMs)
		{
			const string __id = "setAllowedVideoJoiningTimeMs.(J)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allowedVideoJoiningTimeMs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableDecoderFallback_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableDecoderFallback_ZHandler ()
		{
			if (cb_setEnableDecoderFallback_Z == null)
				cb_setEnableDecoderFallback_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetEnableDecoderFallback_Z);
			return cb_setEnableDecoderFallback_Z;
		}

		static IntPtr n_SetEnableDecoderFallback_Z (IntPtr jnienv, IntPtr native__this, bool enableDecoderFallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableDecoderFallback (enableDecoderFallback));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='setEnableDecoderFallback' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableDecoderFallback", "(Z)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;", "GetSetEnableDecoderFallback_ZHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory SetEnableDecoderFallback (bool enableDecoderFallback)
		{
			const string __id = "setEnableDecoderFallback.(Z)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableDecoderFallback);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setExtensionRendererMode_I;
#pragma warning disable 0169
		static Delegate GetSetExtensionRendererMode_IHandler ()
		{
			if (cb_setExtensionRendererMode_I == null)
				cb_setExtensionRendererMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetExtensionRendererMode_I);
			return cb_setExtensionRendererMode_I;
		}

		static IntPtr n_SetExtensionRendererMode_I (IntPtr jnienv, IntPtr native__this, int extensionRendererMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetExtensionRendererMode (extensionRendererMode));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='setExtensionRendererMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExtensionRendererMode", "(I)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;", "GetSetExtensionRendererMode_IHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory SetExtensionRendererMode ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory", Fields = new string [] {"ExtensionRendererModeOff", "ExtensionRendererModeOn", "ExtensionRendererModePrefer"})]
		int extensionRendererMode)
		{
			const string __id = "setExtensionRendererMode.(I)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (extensionRendererMode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_;
#pragma warning disable 0169
		static Delegate GetSetMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Handler ()
		{
			if (cb_setMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_ == null)
				cb_setMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_);
			return cb_setMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_;
		}

		static IntPtr n_SetMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaCodecSelector)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaCodecSelector = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (native_mediaCodecSelector, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMediaCodecSelector (mediaCodecSelector));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='setMediaCodecSelector' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector']]"
		[Register ("setMediaCodecSelector", "(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;", "GetSetMediaCodecSelector_Lcom_example_androidtvlibrary_main_adapter_player_MediaCodecSelector_Handler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory SetMediaCodecSelector (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector mediaCodecSelector)
		{
			const string __id = "setMediaCodecSelector.(Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaCodecSelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodecSelector).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mediaCodecSelector);
			}
		}

		static Delegate cb_setPlayClearSamplesWithoutKeys_Z;
#pragma warning disable 0169
		static Delegate GetSetPlayClearSamplesWithoutKeys_ZHandler ()
		{
			if (cb_setPlayClearSamplesWithoutKeys_Z == null)
				cb_setPlayClearSamplesWithoutKeys_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetPlayClearSamplesWithoutKeys_Z);
			return cb_setPlayClearSamplesWithoutKeys_Z;
		}

		static IntPtr n_SetPlayClearSamplesWithoutKeys_Z (IntPtr jnienv, IntPtr native__this, bool playClearSamplesWithoutKeys)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPlayClearSamplesWithoutKeys (playClearSamplesWithoutKeys));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultRenderersFactory']/method[@name='setPlayClearSamplesWithoutKeys' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPlayClearSamplesWithoutKeys", "(Z)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;", "GetSetPlayClearSamplesWithoutKeys_ZHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory SetPlayClearSamplesWithoutKeys (bool playClearSamplesWithoutKeys)
		{
			const string __id = "setPlayClearSamplesWithoutKeys.(Z)Lcom/example/androidtvlibrary/main/adapter/player/DefaultRenderersFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (playClearSamplesWithoutKeys);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultRenderersFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
