using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$AudioComponent", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker")]
	public partial interface ITestPlayerAudioComponent : IJavaObject, IJavaPeerable {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes AudioAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='getAudioAttributes' and count(parameter)=0]"
			[Register ("getAudioAttributes", "()Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;", "GetGetAudioAttributesHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='setAudioAttributes' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioAttributes']]"
			[Register ("setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;)V", "GetSetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		int AudioSessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='getAudioSessionId' and count(parameter)=0]"
			[Register ("getAudioSessionId", "()I", "GetGetAudioSessionIdHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		float Volume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='getVolume' and count(parameter)=0]"
			[Register ("getVolume", "()F", "GetGetVolumeHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='setVolume' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setVolume", "(F)V", "GetSetVolume_FHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='addAudioListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioListener']]"
		[Register ("addAudioListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioListener;)V", "GetAddAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
		void AddAudioListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='clearAuxEffectInfo' and count(parameter)=0]"
		[Register ("clearAuxEffectInfo", "()V", "GetClearAuxEffectInfoHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearAuxEffectInfo ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='removeAudioListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioListener']]"
		[Register ("removeAudioListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioListener;)V", "GetRemoveAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveAudioListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='setAudioAttributes' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioAttributes'] and parameter[2][@type='boolean']]"
		[Register ("setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;Z)V", "GetSetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetAudioAttributes (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.AudioComponent']/method[@name='setAuxEffectInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AuxEffectInfo']]"
		[Register ("setAuxEffectInfo", "(Lcom/example/androidtvlibrary/main/adapter/player/AuxEffectInfo;)V", "GetSetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetAuxEffectInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$AudioComponent", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerAudioComponentInvoker : global::Java.Lang.Object, ITestPlayerAudioComponent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$AudioComponent", typeof (ITestPlayerAudioComponentInvoker));

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

		public static ITestPlayerAudioComponent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerAudioComponent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.AudioComponent'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerAudioComponentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAudioAttributes;
#pragma warning disable 0169
		static Delegate GetGetAudioAttributesHandler ()
		{
			if (cb_getAudioAttributes == null)
				cb_getAudioAttributes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioAttributes);
			return cb_getAudioAttributes;
		}

		static IntPtr n_GetAudioAttributes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioAttributes);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Handler ()
		{
			if (cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ == null)
				cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_);
			return cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_;
		}

		[Obsolete]
		static void n_SetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioAttributes = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAudioAttributes;
		IntPtr id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes AudioAttributes {
			get {
				if (id_getAudioAttributes == IntPtr.Zero)
					id_getAudioAttributes = JNIEnv.GetMethodID (class_ref, "getAudioAttributes", "()Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioAttributes), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ == IntPtr.Zero)
					id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ = JNIEnv.GetMethodID (class_ref, "setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_, __args);
			}
		}

		static Delegate cb_getAudioSessionId;
#pragma warning disable 0169
		static Delegate GetGetAudioSessionIdHandler ()
		{
			if (cb_getAudioSessionId == null)
				cb_getAudioSessionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioSessionId);
			return cb_getAudioSessionId;
		}

		static int n_GetAudioSessionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSessionId;
		}
#pragma warning restore 0169

		IntPtr id_getAudioSessionId;
		public unsafe int AudioSessionId {
			get {
				if (id_getAudioSessionId == IntPtr.Zero)
					id_getAudioSessionId = JNIEnv.GetMethodID (class_ref, "getAudioSessionId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAudioSessionId);
			}
		}

		static Delegate cb_getVolume;
#pragma warning disable 0169
		static Delegate GetGetVolumeHandler ()
		{
			if (cb_getVolume == null)
				cb_getVolume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetVolume);
			return cb_getVolume;
		}

		static float n_GetVolume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Volume;
		}
#pragma warning restore 0169

		static Delegate cb_setVolume_F;
#pragma warning disable 0169
		static Delegate GetSetVolume_FHandler ()
		{
			if (cb_setVolume_F == null)
				cb_setVolume_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetVolume_F);
			return cb_setVolume_F;
		}

		static void n_SetVolume_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Volume = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVolume;
		IntPtr id_setVolume_F;
		public unsafe float Volume {
			get {
				if (id_getVolume == IntPtr.Zero)
					id_getVolume = JNIEnv.GetMethodID (class_ref, "getVolume", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getVolume);
			}
			set {
				if (id_setVolume_F == IntPtr.Zero)
					id_setVolume_F = JNIEnv.GetMethodID (class_ref, "setVolume", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_F, __args);
			}
		}

		static Delegate cb_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_;
#pragma warning disable 0169
		static Delegate GetAddAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_Handler ()
		{
			if (cb_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ == null)
				cb_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_);
			return cb_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_;
		}

		static void n_AddAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAudioListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_;
		public unsafe void AddAudioListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener p0)
		{
			if (id_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ == IntPtr.Zero)
				id_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ = JNIEnv.GetMethodID (class_ref, "addAudioListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_, __args);
		}

		static Delegate cb_clearAuxEffectInfo;
#pragma warning disable 0169
		static Delegate GetClearAuxEffectInfoHandler ()
		{
			if (cb_clearAuxEffectInfo == null)
				cb_clearAuxEffectInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearAuxEffectInfo);
			return cb_clearAuxEffectInfo;
		}

		static void n_ClearAuxEffectInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAuxEffectInfo ();
		}
#pragma warning restore 0169

		IntPtr id_clearAuxEffectInfo;
		public unsafe void ClearAuxEffectInfo ()
		{
			if (id_clearAuxEffectInfo == IntPtr.Zero)
				id_clearAuxEffectInfo = JNIEnv.GetMethodID (class_ref, "clearAuxEffectInfo", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAuxEffectInfo);
		}

		static Delegate cb_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_;
#pragma warning disable 0169
		static Delegate GetRemoveAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_Handler ()
		{
			if (cb_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ == null)
				cb_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_);
			return cb_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_;
		}

		static void n_RemoveAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAudioListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_;
		public unsafe void RemoveAudioListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioListener p0)
		{
			if (id_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ == IntPtr.Zero)
				id_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_ = JNIEnv.GetMethodID (class_ref, "removeAudioListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAudioListener_Lcom_example_androidtvlibrary_main_adapter_player_AudioListener_, __args);
		}

		static Delegate cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z;
#pragma warning disable 0169
		static Delegate GetSetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_ZHandler ()
		{
			if (cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z == null)
				cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_SetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z);
			return cb_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z;
		}

		static void n_SetAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioAttributes (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z;
		public unsafe void SetAudioAttributes (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes p0, bool p1)
		{
			if (id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z == IntPtr.Zero)
				id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z = JNIEnv.GetMethodID (class_ref, "setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioAttributes_Lcom_example_androidtvlibrary_main_adapter_player_AudioAttributes_Z, __args);
		}

		static Delegate cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_;
#pragma warning disable 0169
		static Delegate GetSetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_Handler ()
		{
			if (cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ == null)
				cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_);
			return cb_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_;
		}

		static void n_SetAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAuxEffectInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_;
		public unsafe void SetAuxEffectInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo p0)
		{
			if (id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ == IntPtr.Zero)
				id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_ = JNIEnv.GetMethodID (class_ref, "setAuxEffectInfo", "(Lcom/example/androidtvlibrary/main/adapter/player/AuxEffectInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuxEffectInfo_Lcom_example_androidtvlibrary_main_adapter_player_AuxEffectInfo_, __args);
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TestPlayer.DefaultEventListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$DefaultEventListener", DoNotGenerateAcw=true)]
	public abstract partial class TestPlayerDefaultEventListener : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$DefaultEventListener", typeof (TestPlayerDefaultEventListener));

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

		protected TestPlayerDefaultEventListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TestPlayer.DefaultEventListener']/constructor[@name='TestPlayer.DefaultEventListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestPlayerDefaultEventListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_I;
#pragma warning disable 0169
		static Delegate GetOnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_IHandler ()
		{
			if (cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_I == null)
				cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_I);
			return cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_I;
		}

		static void n_OnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_I (IntPtr jnienv, IntPtr native__this, IntPtr native_timeline, int reason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TestPlayerDefaultEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeline = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_timeline, JniHandleOwnership.DoNotTransfer);
			__this.OnTimelineChanged (timeline, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TestPlayer.DefaultEventListener']/method[@name='onTimelineChanged' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline'] and parameter[2][@type='int']]"
		[Register ("onTimelineChanged", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;I)V", "GetOnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_IHandler")]
		public virtual unsafe void OnTimelineChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline, int reason)
		{
			const string __id = "onTimelineChanged.(Lcom/example/androidtvlibrary/main/adapter/Timeline;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				__args [1] = new JniArgumentValue (reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
			}
		}

		static Delegate cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetOnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_Handler ()
		{
			if (cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_ == null)
				cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_);
			return cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_;
		}

		[Obsolete]
		static void n_OnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timeline, IntPtr native_manifest)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TestPlayerDefaultEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeline = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_timeline, JniHandleOwnership.DoNotTransfer);
			var manifest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_manifest, JniHandleOwnership.DoNotTransfer);
			__this.OnTimelineChanged (timeline, manifest);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TestPlayer.DefaultEventListener']/method[@name='onTimelineChanged' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("onTimelineChanged", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;Ljava/lang/Object;)V", "GetOnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnTimelineChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline, global::Java.Lang.Object manifest)
		{
			const string __id = "onTimelineChanged.(Lcom/example/androidtvlibrary/main/adapter/Timeline;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				__args [1] = new JniArgumentValue ((manifest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifest).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
				global::System.GC.KeepAlive (manifest);
			}
		}

		static Delegate cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_IHandler ()
		{
			if (cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_I == null)
				cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_OnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_I);
			return cb_onTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_I;
		}

		static void n_OnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_timeline, IntPtr native_manifest, int reason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TestPlayerDefaultEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeline = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_timeline, JniHandleOwnership.DoNotTransfer);
			var manifest = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_manifest, JniHandleOwnership.DoNotTransfer);
			__this.OnTimelineChanged (timeline, manifest, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TestPlayer.DefaultEventListener']/method[@name='onTimelineChanged' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("onTimelineChanged", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;Ljava/lang/Object;I)V", "GetOnTimelineChanged_Lcom_example_androidtvlibrary_main_adapter_Timeline_Ljava_lang_Object_IHandler")]
		public virtual unsafe void OnTimelineChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline, global::Java.Lang.Object manifest, int reason)
		{
			const string __id = "onTimelineChanged.(Lcom/example/androidtvlibrary/main/adapter/Timeline;Ljava/lang/Object;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				__args [1] = new JniArgumentValue ((manifest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifest).Handle);
				__args [2] = new JniArgumentValue (reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
				global::System.GC.KeepAlive (manifest);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$DefaultEventListener", DoNotGenerateAcw=true)]
	internal partial class TestPlayerDefaultEventListenerInvoker : TestPlayerDefaultEventListener {
		public TestPlayerDefaultEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$DefaultEventListener", typeof (TestPlayerDefaultEventListenerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.DiscontinuityReason']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$DiscontinuityReason", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerDiscontinuityReasonInvoker")]
	public partial interface ITestPlayerDiscontinuityReason : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$DiscontinuityReason", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerDiscontinuityReasonInvoker : global::Java.Lang.Object, ITestPlayerDiscontinuityReason {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$DiscontinuityReason", typeof (ITestPlayerDiscontinuityReasonInvoker));

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

		public static ITestPlayerDiscontinuityReason GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerDiscontinuityReason> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.DiscontinuityReason'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerDiscontinuityReasonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerDiscontinuityReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerDiscontinuityReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerDiscontinuityReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerDiscontinuityReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.EventListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$EventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListenerInvoker")]
	public partial interface ITestPlayerEventListener : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$EventListener", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerEventListenerInvoker : global::Java.Lang.Object, ITestPlayerEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$EventListener", typeof (ITestPlayerEventListenerInvoker));

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

		public static ITestPlayerEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.EventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/TestPlayer_EventListenerImplementor")]
	internal sealed partial class ITestPlayerEventListenerImplementor : global::Java.Lang.Object, ITestPlayerEventListener {
		public ITestPlayerEventListenerImplementor () : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/TestPlayer_EventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}

		internal static bool __IsEmpty (ITestPlayerEventListenerImplementor value)
		{
			return true;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.MetadataComponent']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$MetadataComponent", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponentInvoker")]
	public partial interface ITestPlayerMetadataComponent : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.MetadataComponent']/method[@name='addMetadataOutput' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput']]"
		[Register ("addMetadataOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;)V", "GetAddMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponentInvoker, PausedAdsAndroidTV.Binding")]
		void AddMetadataOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.MetadataComponent']/method[@name='removeMetadataOutput' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput']]"
		[Register ("removeMetadataOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;)V", "GetRemoveMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponentInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveMetadataOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$MetadataComponent", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerMetadataComponentInvoker : global::Java.Lang.Object, ITestPlayerMetadataComponent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$MetadataComponent", typeof (ITestPlayerMetadataComponentInvoker));

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

		public static ITestPlayerMetadataComponent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerMetadataComponent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataComponent'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerMetadataComponentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_;
#pragma warning disable 0169
		static Delegate GetAddMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Handler ()
		{
			if (cb_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ == null)
				cb_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_);
			return cb_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_;
		}

		static void n_AddMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMetadataOutput (p0);
		}
#pragma warning restore 0169

		IntPtr id_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_;
		public unsafe void AddMetadataOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput p0)
		{
			if (id_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ == IntPtr.Zero)
				id_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ = JNIEnv.GetMethodID (class_ref, "addMetadataOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_, __args);
		}

		static Delegate cb_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_;
#pragma warning disable 0169
		static Delegate GetRemoveMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_Handler ()
		{
			if (cb_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ == null)
				cb_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_);
			return cb_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_;
		}

		static void n_RemoveMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMetadataOutput (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_;
		public unsafe void RemoveMetadataOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput p0)
		{
			if (id_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ == IntPtr.Zero)
				id_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_ = JNIEnv.GetMethodID (class_ref, "removeMetadataOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMetadataOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_MetadataOutput_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.MetadataOutput']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutputInvoker")]
	public partial interface ITestPlayerMetadataOutput : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.MetadataOutput']/method[@name='onMetadata' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("onMetadata", "(Lcom/example/androidtvlibrary/main/adapter/Metadata;)V", "GetOnMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutputInvoker, PausedAdsAndroidTV.Binding")]
		void OnMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerMetadataOutputInvoker : global::Java.Lang.Object, ITestPlayerMetadataOutput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$MetadataOutput", typeof (ITestPlayerMetadataOutputInvoker));

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

		public static ITestPlayerMetadataOutput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerMetadataOutput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.MetadataOutput'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerMetadataOutputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_;
#pragma warning disable 0169
		static Delegate GetOnMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_Handler ()
		{
			if (cb_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_ == null)
				cb_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_);
			return cb_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_;
		}

		static void n_OnMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMetadata (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_;
		public unsafe void OnMetadata (global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata p0)
		{
			if (id_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_ == IntPtr.Zero)
				id_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_ = JNIEnv.GetMethodID (class_ref, "onMetadata", "(Lcom/example/androidtvlibrary/main/adapter/Metadata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMetadata_Lcom_example_androidtvlibrary_main_adapter_Metadata_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.PlaybackSuppressionReason']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$PlaybackSuppressionReason", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerPlaybackSuppressionReasonInvoker")]
	public partial interface ITestPlayerPlaybackSuppressionReason : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$PlaybackSuppressionReason", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerPlaybackSuppressionReasonInvoker : global::Java.Lang.Object, ITestPlayerPlaybackSuppressionReason {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$PlaybackSuppressionReason", typeof (ITestPlayerPlaybackSuppressionReasonInvoker));

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

		public static ITestPlayerPlaybackSuppressionReason GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerPlaybackSuppressionReason> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.PlaybackSuppressionReason'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerPlaybackSuppressionReasonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerPlaybackSuppressionReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerPlaybackSuppressionReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerPlaybackSuppressionReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerPlaybackSuppressionReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.RepeatMode']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$RepeatMode", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerRepeatModeInvoker")]
	public partial interface ITestPlayerRepeatMode : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$RepeatMode", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerRepeatModeInvoker : global::Java.Lang.Object, ITestPlayerRepeatMode {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$RepeatMode", typeof (ITestPlayerRepeatModeInvoker));

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

		public static ITestPlayerRepeatMode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerRepeatMode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.RepeatMode'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerRepeatModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerRepeatMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerRepeatMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerRepeatMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerRepeatMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.State']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$State", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerStateInvoker")]
	public partial interface ITestPlayerState : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$State", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerStateInvoker : global::Java.Lang.Object, ITestPlayerState {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$State", typeof (ITestPlayerStateInvoker));

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

		public static ITestPlayerState GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerState> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.State'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.TextComponent']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$TextComponent", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponentInvoker")]
	public partial interface ITestPlayerTextComponent : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.TextComponent']/method[@name='addTextOutput' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.TextOutput']]"
		[Register ("addTextOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;)V", "GetAddTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponentInvoker, PausedAdsAndroidTV.Binding")]
		void AddTextOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.TextComponent']/method[@name='removeTextOutput' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.TextOutput']]"
		[Register ("removeTextOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;)V", "GetRemoveTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponentInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveTextOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$TextComponent", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerTextComponentInvoker : global::Java.Lang.Object, ITestPlayerTextComponent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$TextComponent", typeof (ITestPlayerTextComponentInvoker));

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

		public static ITestPlayerTextComponent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerTextComponent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.TextComponent'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerTextComponentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_;
#pragma warning disable 0169
		static Delegate GetAddTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Handler ()
		{
			if (cb_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ == null)
				cb_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_);
			return cb_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_;
		}

		static void n_AddTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTextOutput (p0);
		}
#pragma warning restore 0169

		IntPtr id_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_;
		public unsafe void AddTextOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput p0)
		{
			if (id_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ == IntPtr.Zero)
				id_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ = JNIEnv.GetMethodID (class_ref, "addTextOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_, __args);
		}

		static Delegate cb_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_;
#pragma warning disable 0169
		static Delegate GetRemoveTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_Handler ()
		{
			if (cb_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ == null)
				cb_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_);
			return cb_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_;
		}

		static void n_RemoveTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTextOutput (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_;
		public unsafe void RemoveTextOutput (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutput p0)
		{
			if (id_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ == IntPtr.Zero)
				id_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_ = JNIEnv.GetMethodID (class_ref, "removeTextOutput", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeTextOutput_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_TextOutput_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.TextOutput']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextOutputInvoker")]
	public partial interface ITestPlayerTextOutput : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerTextOutputInvoker : global::Java.Lang.Object, ITestPlayerTextOutput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$TextOutput", typeof (ITestPlayerTextOutputInvoker));

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

		public static ITestPlayerTextOutput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerTextOutput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.TextOutput'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerTextOutputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.TimelineChangeReason']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$TimelineChangeReason", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTimelineChangeReasonInvoker")]
	public partial interface ITestPlayerTimelineChangeReason : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$TimelineChangeReason", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerTimelineChangeReasonInvoker : global::Java.Lang.Object, ITestPlayerTimelineChangeReason {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$TimelineChangeReason", typeof (ITestPlayerTimelineChangeReasonInvoker));

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

		public static ITestPlayerTimelineChangeReason GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerTimelineChangeReason> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.TimelineChangeReason'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerTimelineChangeReasonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTimelineChangeReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTimelineChangeReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTimelineChangeReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTimelineChangeReason> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker")]
	public partial interface ITestPlayerVideoComponent : IJavaObject, IJavaPeerable {
		int VideoScalingMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='getVideoScalingMode' and count(parameter)=0]"
			[Register ("getVideoScalingMode", "()I", "GetGetVideoScalingModeHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoScalingMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoScalingMode", "(I)V", "GetSetVideoScalingMode_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='addVideoListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoListener']]"
		[Register ("addVideoListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoListener;)V", "GetAddVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void AddVideoListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearCameraMotionListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.CameraMotionListener']]"
		[Register ("clearCameraMotionListener", "(Lcom/example/androidtvlibrary/main/adapter/CameraMotionListener;)V", "GetClearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearCameraMotionListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoDecoderOutputBufferRenderer' and count(parameter)=0]"
		[Register ("clearVideoDecoderOutputBufferRenderer", "()V", "GetClearVideoDecoderOutputBufferRendererHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoDecoderOutputBufferRenderer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoDecoderOutputBufferRenderer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBufferRenderer']]"
		[Register ("clearVideoDecoderOutputBufferRenderer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer;)V", "GetClearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoDecoderOutputBufferRenderer (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoFrameMetadataListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoFrameMetadataListener']]"
		[Register ("clearVideoFrameMetadataListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener;)V", "GetClearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoFrameMetadataListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoSurface' and count(parameter)=0]"
		[Register ("clearVideoSurface", "()V", "GetClearVideoSurfaceHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoSurface ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("clearVideoSurface", "(Landroid/view/Surface;)V", "GetClearVideoSurface_Landroid_view_Surface_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoSurface (global::Android.Views.Surface p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoSurfaceHolder' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("clearVideoSurfaceHolder", "(Landroid/view/SurfaceHolder;)V", "GetClearVideoSurfaceHolder_Landroid_view_SurfaceHolder_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoSurfaceHolder (global::Android.Views.ISurfaceHolder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoSurfaceView' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceView']]"
		[Register ("clearVideoSurfaceView", "(Landroid/view/SurfaceView;)V", "GetClearVideoSurfaceView_Landroid_view_SurfaceView_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoSurfaceView (global::Android.Views.SurfaceView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='clearVideoTextureView' and count(parameter)=1 and parameter[1][@type='android.view.TextureView']]"
		[Register ("clearVideoTextureView", "(Landroid/view/TextureView;)V", "GetClearVideoTextureView_Landroid_view_TextureView_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void ClearVideoTextureView (global::Android.Views.TextureView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='removeVideoListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoListener']]"
		[Register ("removeVideoListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoListener;)V", "GetRemoveVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveVideoListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setCameraMotionListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.CameraMotionListener']]"
		[Register ("setCameraMotionListener", "(Lcom/example/androidtvlibrary/main/adapter/CameraMotionListener;)V", "GetSetCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetCameraMotionListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoDecoderOutputBufferRenderer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoDecoderOutputBufferRenderer']]"
		[Register ("setVideoDecoderOutputBufferRenderer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer;)V", "GetSetVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetVideoDecoderOutputBufferRenderer (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoFrameMetadataListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.VideoFrameMetadataListener']]"
		[Register ("setVideoFrameMetadataListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener;)V", "GetSetVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetVideoFrameMetadataListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("setVideoSurface", "(Landroid/view/Surface;)V", "GetSetVideoSurface_Landroid_view_Surface_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetVideoSurface (global::Android.Views.Surface p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoSurfaceHolder' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setVideoSurfaceHolder", "(Landroid/view/SurfaceHolder;)V", "GetSetVideoSurfaceHolder_Landroid_view_SurfaceHolder_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetVideoSurfaceHolder (global::Android.Views.ISurfaceHolder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoSurfaceView' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceView']]"
		[Register ("setVideoSurfaceView", "(Landroid/view/SurfaceView;)V", "GetSetVideoSurfaceView_Landroid_view_SurfaceView_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetVideoSurfaceView (global::Android.Views.SurfaceView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoComponent']/method[@name='setVideoTextureView' and count(parameter)=1 and parameter[1][@type='android.view.TextureView']]"
		[Register ("setVideoTextureView", "(Landroid/view/TextureView;)V", "GetSetVideoTextureView_Landroid_view_TextureView_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponentInvoker, PausedAdsAndroidTV.Binding")]
		void SetVideoTextureView (global::Android.Views.TextureView p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerVideoComponentInvoker : global::Java.Lang.Object, ITestPlayerVideoComponent {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent", typeof (ITestPlayerVideoComponentInvoker));

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

		public static ITestPlayerVideoComponent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerVideoComponent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.VideoComponent'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerVideoComponentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getVideoScalingMode;
#pragma warning disable 0169
		static Delegate GetGetVideoScalingModeHandler ()
		{
			if (cb_getVideoScalingMode == null)
				cb_getVideoScalingMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoScalingMode);
			return cb_getVideoScalingMode;
		}

		static int n_GetVideoScalingMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoScalingMode;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoScalingMode_I;
#pragma warning disable 0169
		static Delegate GetSetVideoScalingMode_IHandler ()
		{
			if (cb_setVideoScalingMode_I == null)
				cb_setVideoScalingMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoScalingMode_I);
			return cb_setVideoScalingMode_I;
		}

		static void n_SetVideoScalingMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoScalingMode = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVideoScalingMode;
		IntPtr id_setVideoScalingMode_I;
		public unsafe int VideoScalingMode {
			get {
				if (id_getVideoScalingMode == IntPtr.Zero)
					id_getVideoScalingMode = JNIEnv.GetMethodID (class_ref, "getVideoScalingMode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoScalingMode);
			}
			set {
				if (id_setVideoScalingMode_I == IntPtr.Zero)
					id_setVideoScalingMode_I = JNIEnv.GetMethodID (class_ref, "setVideoScalingMode", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoScalingMode_I, __args);
			}
		}

		static Delegate cb_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_;
#pragma warning disable 0169
		static Delegate GetAddVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_Handler ()
		{
			if (cb_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ == null)
				cb_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_);
			return cb_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_;
		}

		static void n_AddVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddVideoListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_;
		public unsafe void AddVideoListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener p0)
		{
			if (id_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ == IntPtr.Zero)
				id_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ = JNIEnv.GetMethodID (class_ref, "addVideoListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_, __args);
		}

		static Delegate cb_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_;
#pragma warning disable 0169
		static Delegate GetClearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_Handler ()
		{
			if (cb_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ == null)
				cb_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_);
			return cb_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_;
		}

		static void n_ClearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearCameraMotionListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_;
		public unsafe void ClearCameraMotionListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener p0)
		{
			if (id_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ == IntPtr.Zero)
				id_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ = JNIEnv.GetMethodID (class_ref, "clearCameraMotionListener", "(Lcom/example/androidtvlibrary/main/adapter/CameraMotionListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_, __args);
		}

		static Delegate cb_clearVideoDecoderOutputBufferRenderer;
#pragma warning disable 0169
		static Delegate GetClearVideoDecoderOutputBufferRendererHandler ()
		{
			if (cb_clearVideoDecoderOutputBufferRenderer == null)
				cb_clearVideoDecoderOutputBufferRenderer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearVideoDecoderOutputBufferRenderer);
			return cb_clearVideoDecoderOutputBufferRenderer;
		}

		static void n_ClearVideoDecoderOutputBufferRenderer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoDecoderOutputBufferRenderer ();
		}
#pragma warning restore 0169

		IntPtr id_clearVideoDecoderOutputBufferRenderer;
		public unsafe void ClearVideoDecoderOutputBufferRenderer ()
		{
			if (id_clearVideoDecoderOutputBufferRenderer == IntPtr.Zero)
				id_clearVideoDecoderOutputBufferRenderer = JNIEnv.GetMethodID (class_ref, "clearVideoDecoderOutputBufferRenderer", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoDecoderOutputBufferRenderer);
		}

		static Delegate cb_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_;
#pragma warning disable 0169
		static Delegate GetClearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_Handler ()
		{
			if (cb_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ == null)
				cb_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_);
			return cb_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_;
		}

		static void n_ClearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoDecoderOutputBufferRenderer (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_;
		public unsafe void ClearVideoDecoderOutputBufferRenderer (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer p0)
		{
			if (id_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ == IntPtr.Zero)
				id_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ = JNIEnv.GetMethodID (class_ref, "clearVideoDecoderOutputBufferRenderer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_, __args);
		}

		static Delegate cb_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_;
#pragma warning disable 0169
		static Delegate GetClearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_Handler ()
		{
			if (cb_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ == null)
				cb_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_);
			return cb_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_;
		}

		static void n_ClearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoFrameMetadataListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_;
		public unsafe void ClearVideoFrameMetadataListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener p0)
		{
			if (id_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ == IntPtr.Zero)
				id_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ = JNIEnv.GetMethodID (class_ref, "clearVideoFrameMetadataListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_, __args);
		}

		static Delegate cb_clearVideoSurface;
#pragma warning disable 0169
		static Delegate GetClearVideoSurfaceHandler ()
		{
			if (cb_clearVideoSurface == null)
				cb_clearVideoSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearVideoSurface);
			return cb_clearVideoSurface;
		}

		static void n_ClearVideoSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoSurface ();
		}
#pragma warning restore 0169

		IntPtr id_clearVideoSurface;
		public unsafe void ClearVideoSurface ()
		{
			if (id_clearVideoSurface == IntPtr.Zero)
				id_clearVideoSurface = JNIEnv.GetMethodID (class_ref, "clearVideoSurface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoSurface);
		}

		static Delegate cb_clearVideoSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetClearVideoSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_clearVideoSurface_Landroid_view_Surface_ == null)
				cb_clearVideoSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearVideoSurface_Landroid_view_Surface_);
			return cb_clearVideoSurface_Landroid_view_Surface_;
		}

		static void n_ClearVideoSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearVideoSurface_Landroid_view_Surface_;
		public unsafe void ClearVideoSurface (global::Android.Views.Surface p0)
		{
			if (id_clearVideoSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_clearVideoSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "clearVideoSurface", "(Landroid/view/Surface;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoSurface_Landroid_view_Surface_, __args);
		}

		static Delegate cb_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetClearVideoSurfaceHolder_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_ == null)
				cb_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearVideoSurfaceHolder_Landroid_view_SurfaceHolder_);
			return cb_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_;
		}

		static void n_ClearVideoSurfaceHolder_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoSurfaceHolder (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_;
		public unsafe void ClearVideoSurfaceHolder (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "clearVideoSurfaceHolder", "(Landroid/view/SurfaceHolder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoSurfaceHolder_Landroid_view_SurfaceHolder_, __args);
		}

		static Delegate cb_clearVideoSurfaceView_Landroid_view_SurfaceView_;
#pragma warning disable 0169
		static Delegate GetClearVideoSurfaceView_Landroid_view_SurfaceView_Handler ()
		{
			if (cb_clearVideoSurfaceView_Landroid_view_SurfaceView_ == null)
				cb_clearVideoSurfaceView_Landroid_view_SurfaceView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearVideoSurfaceView_Landroid_view_SurfaceView_);
			return cb_clearVideoSurfaceView_Landroid_view_SurfaceView_;
		}

		static void n_ClearVideoSurfaceView_Landroid_view_SurfaceView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoSurfaceView (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearVideoSurfaceView_Landroid_view_SurfaceView_;
		public unsafe void ClearVideoSurfaceView (global::Android.Views.SurfaceView p0)
		{
			if (id_clearVideoSurfaceView_Landroid_view_SurfaceView_ == IntPtr.Zero)
				id_clearVideoSurfaceView_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "clearVideoSurfaceView", "(Landroid/view/SurfaceView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoSurfaceView_Landroid_view_SurfaceView_, __args);
		}

		static Delegate cb_clearVideoTextureView_Landroid_view_TextureView_;
#pragma warning disable 0169
		static Delegate GetClearVideoTextureView_Landroid_view_TextureView_Handler ()
		{
			if (cb_clearVideoTextureView_Landroid_view_TextureView_ == null)
				cb_clearVideoTextureView_Landroid_view_TextureView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearVideoTextureView_Landroid_view_TextureView_);
			return cb_clearVideoTextureView_Landroid_view_TextureView_;
		}

		static void n_ClearVideoTextureView_Landroid_view_TextureView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearVideoTextureView (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearVideoTextureView_Landroid_view_TextureView_;
		public unsafe void ClearVideoTextureView (global::Android.Views.TextureView p0)
		{
			if (id_clearVideoTextureView_Landroid_view_TextureView_ == IntPtr.Zero)
				id_clearVideoTextureView_Landroid_view_TextureView_ = JNIEnv.GetMethodID (class_ref, "clearVideoTextureView", "(Landroid/view/TextureView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearVideoTextureView_Landroid_view_TextureView_, __args);
		}

		static Delegate cb_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_;
#pragma warning disable 0169
		static Delegate GetRemoveVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_Handler ()
		{
			if (cb_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ == null)
				cb_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_);
			return cb_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_;
		}

		static void n_RemoveVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveVideoListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_;
		public unsafe void RemoveVideoListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoListener p0)
		{
			if (id_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ == IntPtr.Zero)
				id_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_ = JNIEnv.GetMethodID (class_ref, "removeVideoListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeVideoListener_Lcom_example_androidtvlibrary_main_adapter_VideoListener_, __args);
		}

		static Delegate cb_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_;
#pragma warning disable 0169
		static Delegate GetSetCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_Handler ()
		{
			if (cb_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ == null)
				cb_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_);
			return cb_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_;
		}

		static void n_SetCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraMotionListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_;
		public unsafe void SetCameraMotionListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ICameraMotionListener p0)
		{
			if (id_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ == IntPtr.Zero)
				id_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_ = JNIEnv.GetMethodID (class_ref, "setCameraMotionListener", "(Lcom/example/androidtvlibrary/main/adapter/CameraMotionListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCameraMotionListener_Lcom_example_androidtvlibrary_main_adapter_CameraMotionListener_, __args);
		}

		static Delegate cb_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_;
#pragma warning disable 0169
		static Delegate GetSetVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_Handler ()
		{
			if (cb_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ == null)
				cb_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_);
			return cb_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_;
		}

		static void n_SetVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoDecoderOutputBufferRenderer (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_;
		public unsafe void SetVideoDecoderOutputBufferRenderer (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoDecoderOutputBufferRenderer p0)
		{
			if (id_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ == IntPtr.Zero)
				id_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_ = JNIEnv.GetMethodID (class_ref, "setVideoDecoderOutputBufferRenderer", "(Lcom/example/androidtvlibrary/main/adapter/VideoDecoderOutputBufferRenderer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoDecoderOutputBufferRenderer_Lcom_example_androidtvlibrary_main_adapter_VideoDecoderOutputBufferRenderer_, __args);
		}

		static Delegate cb_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_;
#pragma warning disable 0169
		static Delegate GetSetVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_Handler ()
		{
			if (cb_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ == null)
				cb_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_);
			return cb_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_;
		}

		static void n_SetVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoFrameMetadataListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_;
		public unsafe void SetVideoFrameMetadataListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IVideoFrameMetadataListener p0)
		{
			if (id_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ == IntPtr.Zero)
				id_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_ = JNIEnv.GetMethodID (class_ref, "setVideoFrameMetadataListener", "(Lcom/example/androidtvlibrary/main/adapter/VideoFrameMetadataListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoFrameMetadataListener_Lcom_example_androidtvlibrary_main_adapter_VideoFrameMetadataListener_, __args);
		}

		static Delegate cb_setVideoSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetSetVideoSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_setVideoSurface_Landroid_view_Surface_ == null)
				cb_setVideoSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoSurface_Landroid_view_Surface_);
			return cb_setVideoSurface_Landroid_view_Surface_;
		}

		static void n_SetVideoSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoSurface_Landroid_view_Surface_;
		public unsafe void SetVideoSurface (global::Android.Views.Surface p0)
		{
			if (id_setVideoSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_setVideoSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "setVideoSurface", "(Landroid/view/Surface;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoSurface_Landroid_view_Surface_, __args);
		}

		static Delegate cb_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSetVideoSurfaceHolder_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_ == null)
				cb_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoSurfaceHolder_Landroid_view_SurfaceHolder_);
			return cb_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_;
		}

		static void n_SetVideoSurfaceHolder_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoSurfaceHolder (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_;
		public unsafe void SetVideoSurfaceHolder (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "setVideoSurfaceHolder", "(Landroid/view/SurfaceHolder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoSurfaceHolder_Landroid_view_SurfaceHolder_, __args);
		}

		static Delegate cb_setVideoSurfaceView_Landroid_view_SurfaceView_;
#pragma warning disable 0169
		static Delegate GetSetVideoSurfaceView_Landroid_view_SurfaceView_Handler ()
		{
			if (cb_setVideoSurfaceView_Landroid_view_SurfaceView_ == null)
				cb_setVideoSurfaceView_Landroid_view_SurfaceView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoSurfaceView_Landroid_view_SurfaceView_);
			return cb_setVideoSurfaceView_Landroid_view_SurfaceView_;
		}

		static void n_SetVideoSurfaceView_Landroid_view_SurfaceView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoSurfaceView (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoSurfaceView_Landroid_view_SurfaceView_;
		public unsafe void SetVideoSurfaceView (global::Android.Views.SurfaceView p0)
		{
			if (id_setVideoSurfaceView_Landroid_view_SurfaceView_ == IntPtr.Zero)
				id_setVideoSurfaceView_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "setVideoSurfaceView", "(Landroid/view/SurfaceView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoSurfaceView_Landroid_view_SurfaceView_, __args);
		}

		static Delegate cb_setVideoTextureView_Landroid_view_TextureView_;
#pragma warning disable 0169
		static Delegate GetSetVideoTextureView_Landroid_view_TextureView_Handler ()
		{
			if (cb_setVideoTextureView_Landroid_view_TextureView_ == null)
				cb_setVideoTextureView_Landroid_view_TextureView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoTextureView_Landroid_view_TextureView_);
			return cb_setVideoTextureView_Landroid_view_TextureView_;
		}

		static void n_SetVideoTextureView_Landroid_view_TextureView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoTextureView (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoTextureView_Landroid_view_TextureView_;
		public unsafe void SetVideoTextureView (global::Android.Views.TextureView p0)
		{
			if (id_setVideoTextureView_Landroid_view_TextureView_ == IntPtr.Zero)
				id_setVideoTextureView_Landroid_view_TextureView_ = JNIEnv.GetMethodID (class_ref, "setVideoTextureView", "(Landroid/view/TextureView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoTextureView_Landroid_view_TextureView_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer.VideoScalingMode']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$VideoScalingMode", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoScalingModeInvoker")]
	public partial interface ITestPlayerVideoScalingMode : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer$VideoScalingMode", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerVideoScalingModeInvoker : global::Java.Lang.Object, ITestPlayerVideoScalingMode {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer$VideoScalingMode", typeof (ITestPlayerVideoScalingModeInvoker));

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

		public static ITestPlayerVideoScalingMode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayerVideoScalingMode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer.VideoScalingMode'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerVideoScalingModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoScalingMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoScalingMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoScalingMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoScalingMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer", DoNotGenerateAcw=true)]
	public abstract class TestPlayer : Java.Lang.Object {
		internal TestPlayer ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='DISCONTINUITY_REASON_AD_INSERTION']"
		[Register ("DISCONTINUITY_REASON_AD_INSERTION")]
		public const int DiscontinuityReasonAdInsertion = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='DISCONTINUITY_REASON_INTERNAL']"
		[Register ("DISCONTINUITY_REASON_INTERNAL")]
		public const int DiscontinuityReasonInternal = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='DISCONTINUITY_REASON_PERIOD_TRANSITION']"
		[Register ("DISCONTINUITY_REASON_PERIOD_TRANSITION")]
		public const int DiscontinuityReasonPeriodTransition = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='DISCONTINUITY_REASON_SEEK']"
		[Register ("DISCONTINUITY_REASON_SEEK")]
		public const int DiscontinuityReasonSeek = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='DISCONTINUITY_REASON_SEEK_ADJUSTMENT']"
		[Register ("DISCONTINUITY_REASON_SEEK_ADJUSTMENT")]
		public const int DiscontinuityReasonSeekAdjustment = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='PLAYBACK_SUPPRESSION_REASON_NONE']"
		[Register ("PLAYBACK_SUPPRESSION_REASON_NONE")]
		public const int PlaybackSuppressionReasonNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='PLAYBACK_SUPPRESSION_REASON_TRANSIENT_AUDIO_FOCUS_LOSS']"
		[Register ("PLAYBACK_SUPPRESSION_REASON_TRANSIENT_AUDIO_FOCUS_LOSS")]
		public const int PlaybackSuppressionReasonTransientAudioFocusLoss = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='REPEAT_MODE_ALL']"
		[Register ("REPEAT_MODE_ALL")]
		public const int RepeatModeAll = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='REPEAT_MODE_OFF']"
		[Register ("REPEAT_MODE_OFF")]
		public const int RepeatModeOff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='REPEAT_MODE_ONE']"
		[Register ("REPEAT_MODE_ONE")]
		public const int RepeatModeOne = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='STATE_BUFFERING']"
		[Register ("STATE_BUFFERING")]
		public const int StateBuffering = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='STATE_ENDED']"
		[Register ("STATE_ENDED")]
		public const int StateEnded = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='STATE_IDLE']"
		[Register ("STATE_IDLE")]
		public const int StateIdle = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='STATE_READY']"
		[Register ("STATE_READY")]
		public const int StateReady = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='TIMELINE_CHANGE_REASON_DYNAMIC']"
		[Register ("TIMELINE_CHANGE_REASON_DYNAMIC")]
		public const int TimelineChangeReasonDynamic = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='TIMELINE_CHANGE_REASON_PREPARED']"
		[Register ("TIMELINE_CHANGE_REASON_PREPARED")]
		public const int TimelineChangeReasonPrepared = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='TIMELINE_CHANGE_REASON_RESET']"
		[Register ("TIMELINE_CHANGE_REASON_RESET")]
		public const int TimelineChangeReasonReset = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='VIDEO_SCALING_MODE_DEFAULT']"
		[Register ("VIDEO_SCALING_MODE_DEFAULT")]
		public const int VideoScalingModeDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='VIDEO_SCALING_MODE_SCALE_TO_FIT']"
		[Register ("VIDEO_SCALING_MODE_SCALE_TO_FIT")]
		public const int VideoScalingModeScaleToFit = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/field[@name='VIDEO_SCALING_MODE_SCALE_TO_FIT_WITH_CROPPING']"
		[Register ("VIDEO_SCALING_MODE_SCALE_TO_FIT_WITH_CROPPING")]
		public const int VideoScalingModeScaleToFitWithCropping = (int) 2;

	}

	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TestPlayer' type. This type will be removed in a future release.", error: true)]
	public abstract class TestPlayerConsts : TestPlayer {
		private TestPlayerConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']"
	[Register ("com/example/androidtvlibrary/main/adapter/TestPlayer", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker")]
	public partial interface ITestPlayer : IJavaObject, IJavaPeerable {
		global::Android.OS.Looper ApplicationLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getApplicationLooper' and count(parameter)=0]"
			[Register ("getApplicationLooper", "()Landroid/os/Looper;", "GetGetApplicationLooperHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent AudioComponent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getAudioComponent' and count(parameter)=0]"
			[Register ("getAudioComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$AudioComponent;", "GetGetAudioComponentHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int BufferedPercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getBufferedPercentage' and count(parameter)=0]"
			[Register ("getBufferedPercentage", "()I", "GetGetBufferedPercentageHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long BufferedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getBufferedPosition' and count(parameter)=0]"
			[Register ("getBufferedPosition", "()J", "GetGetBufferedPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long ContentBufferedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getContentBufferedPosition' and count(parameter)=0]"
			[Register ("getContentBufferedPosition", "()J", "GetGetContentBufferedPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long ContentDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getContentDuration' and count(parameter)=0]"
			[Register ("getContentDuration", "()J", "GetGetContentDurationHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long ContentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getContentPosition' and count(parameter)=0]"
			[Register ("getContentPosition", "()J", "GetGetContentPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int CurrentAdGroupIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentAdGroupIndex' and count(parameter)=0]"
			[Register ("getCurrentAdGroupIndex", "()I", "GetGetCurrentAdGroupIndexHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int CurrentAdIndexInAdGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentAdIndexInAdGroup' and count(parameter)=0]"
			[Register ("getCurrentAdIndexInAdGroup", "()I", "GetGetCurrentAdIndexInAdGroupHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Java.Lang.Object CurrentManifest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentManifest' and count(parameter)=0]"
			[Register ("getCurrentManifest", "()Ljava/lang/Object;", "GetGetCurrentManifestHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int CurrentPeriodIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentPeriodIndex' and count(parameter)=0]"
			[Register ("getCurrentPeriodIndex", "()I", "GetGetCurrentPeriodIndexHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Java.Lang.Object CurrentTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentTag' and count(parameter)=0]"
			[Register ("getCurrentTag", "()Ljava/lang/Object;", "GetGetCurrentTagHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline CurrentTimeline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentTimeline' and count(parameter)=0]"
			[Register ("getCurrentTimeline", "()Lcom/example/androidtvlibrary/main/adapter/Timeline;", "GetGetCurrentTimelineHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray CurrentTrackGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentTrackGroups' and count(parameter)=0]"
			[Register ("getCurrentTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "GetGetCurrentTrackGroupsHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray CurrentTrackSelections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentTrackSelections' and count(parameter)=0]"
			[Register ("getCurrentTrackSelections", "()Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;", "GetGetCurrentTrackSelectionsHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int CurrentWindowIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getCurrentWindowIndex' and count(parameter)=0]"
			[Register ("getCurrentWindowIndex", "()I", "GetGetCurrentWindowIndexHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool HasPrevious {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='hasPrevious' and count(parameter)=0]"
			[Register ("hasPrevious", "()Z", "GetHasPreviousHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsCurrentWindowDynamic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='isCurrentWindowDynamic' and count(parameter)=0]"
			[Register ("isCurrentWindowDynamic", "()Z", "GetIsCurrentWindowDynamicHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsCurrentWindowLive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='isCurrentWindowLive' and count(parameter)=0]"
			[Register ("isCurrentWindowLive", "()Z", "GetIsCurrentWindowLiveHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsCurrentWindowSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='isCurrentWindowSeekable' and count(parameter)=0]"
			[Register ("isCurrentWindowSeekable", "()Z", "GetIsCurrentWindowSeekableHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsPlayingAd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='isPlayingAd' and count(parameter)=0]"
			[Register ("isPlayingAd", "()Z", "GetIsPlayingAdHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent MetadataComponent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getMetadataComponent' and count(parameter)=0]"
			[Register ("getMetadataComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataComponent;", "GetGetMetadataComponentHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int NextWindowIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getNextWindowIndex' and count(parameter)=0]"
			[Register ("getNextWindowIndex", "()I", "GetGetNextWindowIndexHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool PlayWhenReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getPlayWhenReady' and count(parameter)=0]"
			[Register ("getPlayWhenReady", "()Z", "GetGetPlayWhenReadyHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='setPlayWhenReady' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPlayWhenReady", "(Z)V", "GetSetPlayWhenReady_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		global::Java.Lang.Exception PlaybackError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getPlaybackError' and count(parameter)=0]"
			[Register ("getPlaybackError", "()Ljava/lang/Exception;", "GetGetPlaybackErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getPlaybackParameters' and count(parameter)=0]"
			[Register ("getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "GetGetPlaybackParametersHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='setPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V", "GetSetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		int PlaybackState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getPlaybackState' and count(parameter)=0]"
			[Register ("getPlaybackState", "()I", "GetGetPlaybackStateHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int PlaybackSuppressionReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getPlaybackSuppressionReason' and count(parameter)=0]"
			[Register ("getPlaybackSuppressionReason", "()I", "GetGetPlaybackSuppressionReasonHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int PreviousWindowIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getPreviousWindowIndex' and count(parameter)=0]"
			[Register ("getPreviousWindowIndex", "()I", "GetGetPreviousWindowIndexHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int RendererCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getRendererCount' and count(parameter)=0]"
			[Register ("getRendererCount", "()I", "GetGetRendererCountHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int RepeatMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getRepeatMode' and count(parameter)=0]"
			[Register ("getRepeatMode", "()I", "GetGetRepeatModeHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='setRepeatMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRepeatMode", "(I)V", "GetSetRepeatMode_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		bool ShuffleModeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getShuffleModeEnabled' and count(parameter)=0]"
			[Register ("getShuffleModeEnabled", "()Z", "GetGetShuffleModeEnabledHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='setShuffleModeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShuffleModeEnabled", "(Z)V", "GetSetShuffleModeEnabled_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			set; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent TextComponent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getTextComponent' and count(parameter)=0]"
			[Register ("getTextComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextComponent;", "GetGetTextComponentHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long TotalBufferedDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getTotalBufferedDuration' and count(parameter)=0]"
			[Register ("getTotalBufferedDuration", "()J", "GetGetTotalBufferedDurationHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent VideoComponent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getVideoComponent' and count(parameter)=0]"
			[Register ("getVideoComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent;", "GetGetVideoComponentHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.EventListener']]"
		[Register ("addListener", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$EventListener;)V", "GetAddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void AddListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='getRendererType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRendererType", "(I)I", "GetGetRendererType_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		int GetRendererType (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()V", "GetNextHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Next ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='previous' and count(parameter)=0]"
		[Register ("previous", "()V", "GetPreviousHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Previous ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer.EventListener']]"
		[Register ("removeListener", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$EventListener;)V", "GetRemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='seekTo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("seekTo", "(IJ)V", "GetSeekTo_IJHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void SeekTo (int p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void SeekTo (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='seekToDefaultPosition' and count(parameter)=0]"
		[Register ("seekToDefaultPosition", "()V", "GetSeekToDefaultPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void SeekToDefaultPosition ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='seekToDefaultPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekToDefaultPosition", "(I)V", "GetSeekToDefaultPosition_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void SeekToDefaultPosition (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Stop ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TestPlayer']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stop", "(Z)V", "GetStop_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerInvoker, PausedAdsAndroidTV.Binding")]
		void Stop (bool p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TestPlayer", DoNotGenerateAcw=true)]
	internal partial class ITestPlayerInvoker : global::Java.Lang.Object, ITestPlayer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TestPlayer", typeof (ITestPlayerInvoker));

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

		public static ITestPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TestPlayer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getApplicationLooper;
#pragma warning disable 0169
		static Delegate GetGetApplicationLooperHandler ()
		{
			if (cb_getApplicationLooper == null)
				cb_getApplicationLooper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApplicationLooper);
			return cb_getApplicationLooper;
		}

		static IntPtr n_GetApplicationLooper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationLooper);
		}
#pragma warning restore 0169

		IntPtr id_getApplicationLooper;
		public unsafe global::Android.OS.Looper ApplicationLooper {
			get {
				if (id_getApplicationLooper == IntPtr.Zero)
					id_getApplicationLooper = JNIEnv.GetMethodID (class_ref, "getApplicationLooper", "()Landroid/os/Looper;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationLooper), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAudioComponent;
#pragma warning disable 0169
		static Delegate GetGetAudioComponentHandler ()
		{
			if (cb_getAudioComponent == null)
				cb_getAudioComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioComponent);
			return cb_getAudioComponent;
		}

		static IntPtr n_GetAudioComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioComponent);
		}
#pragma warning restore 0169

		IntPtr id_getAudioComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent AudioComponent {
			get {
				if (id_getAudioComponent == IntPtr.Zero)
					id_getAudioComponent = JNIEnv.GetMethodID (class_ref, "getAudioComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$AudioComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerAudioComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBufferedPercentage;
#pragma warning disable 0169
		static Delegate GetGetBufferedPercentageHandler ()
		{
			if (cb_getBufferedPercentage == null)
				cb_getBufferedPercentage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBufferedPercentage);
			return cb_getBufferedPercentage;
		}

		static int n_GetBufferedPercentage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPercentage;
		}
#pragma warning restore 0169

		IntPtr id_getBufferedPercentage;
		public unsafe int BufferedPercentage {
			get {
				if (id_getBufferedPercentage == IntPtr.Zero)
					id_getBufferedPercentage = JNIEnv.GetMethodID (class_ref, "getBufferedPercentage", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPercentage);
			}
		}

		static Delegate cb_getBufferedPosition;
#pragma warning disable 0169
		static Delegate GetGetBufferedPositionHandler ()
		{
			if (cb_getBufferedPosition == null)
				cb_getBufferedPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBufferedPosition);
			return cb_getBufferedPosition;
		}

		static long n_GetBufferedPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPosition;
		}
#pragma warning restore 0169

		IntPtr id_getBufferedPosition;
		public unsafe long BufferedPosition {
			get {
				if (id_getBufferedPosition == IntPtr.Zero)
					id_getBufferedPosition = JNIEnv.GetMethodID (class_ref, "getBufferedPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPosition);
			}
		}

		static Delegate cb_getContentBufferedPosition;
#pragma warning disable 0169
		static Delegate GetGetContentBufferedPositionHandler ()
		{
			if (cb_getContentBufferedPosition == null)
				cb_getContentBufferedPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetContentBufferedPosition);
			return cb_getContentBufferedPosition;
		}

		static long n_GetContentBufferedPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentBufferedPosition;
		}
#pragma warning restore 0169

		IntPtr id_getContentBufferedPosition;
		public unsafe long ContentBufferedPosition {
			get {
				if (id_getContentBufferedPosition == IntPtr.Zero)
					id_getContentBufferedPosition = JNIEnv.GetMethodID (class_ref, "getContentBufferedPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentBufferedPosition);
			}
		}

		static Delegate cb_getContentDuration;
#pragma warning disable 0169
		static Delegate GetGetContentDurationHandler ()
		{
			if (cb_getContentDuration == null)
				cb_getContentDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetContentDuration);
			return cb_getContentDuration;
		}

		static long n_GetContentDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentDuration;
		}
#pragma warning restore 0169

		IntPtr id_getContentDuration;
		public unsafe long ContentDuration {
			get {
				if (id_getContentDuration == IntPtr.Zero)
					id_getContentDuration = JNIEnv.GetMethodID (class_ref, "getContentDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentDuration);
			}
		}

		static Delegate cb_getContentPosition;
#pragma warning disable 0169
		static Delegate GetGetContentPositionHandler ()
		{
			if (cb_getContentPosition == null)
				cb_getContentPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetContentPosition);
			return cb_getContentPosition;
		}

		static long n_GetContentPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getContentPosition;
		public unsafe long ContentPosition {
			get {
				if (id_getContentPosition == IntPtr.Zero)
					id_getContentPosition = JNIEnv.GetMethodID (class_ref, "getContentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentPosition);
			}
		}

		static Delegate cb_getCurrentAdGroupIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentAdGroupIndexHandler ()
		{
			if (cb_getCurrentAdGroupIndex == null)
				cb_getCurrentAdGroupIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentAdGroupIndex);
			return cb_getCurrentAdGroupIndex;
		}

		static int n_GetCurrentAdGroupIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentAdGroupIndex;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAdGroupIndex;
		public unsafe int CurrentAdGroupIndex {
			get {
				if (id_getCurrentAdGroupIndex == IntPtr.Zero)
					id_getCurrentAdGroupIndex = JNIEnv.GetMethodID (class_ref, "getCurrentAdGroupIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAdGroupIndex);
			}
		}

		static Delegate cb_getCurrentAdIndexInAdGroup;
#pragma warning disable 0169
		static Delegate GetGetCurrentAdIndexInAdGroupHandler ()
		{
			if (cb_getCurrentAdIndexInAdGroup == null)
				cb_getCurrentAdIndexInAdGroup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentAdIndexInAdGroup);
			return cb_getCurrentAdIndexInAdGroup;
		}

		static int n_GetCurrentAdIndexInAdGroup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentAdIndexInAdGroup;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentAdIndexInAdGroup;
		public unsafe int CurrentAdIndexInAdGroup {
			get {
				if (id_getCurrentAdIndexInAdGroup == IntPtr.Zero)
					id_getCurrentAdIndexInAdGroup = JNIEnv.GetMethodID (class_ref, "getCurrentAdIndexInAdGroup", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentAdIndexInAdGroup);
			}
		}

		static Delegate cb_getCurrentManifest;
#pragma warning disable 0169
		static Delegate GetGetCurrentManifestHandler ()
		{
			if (cb_getCurrentManifest == null)
				cb_getCurrentManifest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentManifest);
			return cb_getCurrentManifest;
		}

		static IntPtr n_GetCurrentManifest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentManifest);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentManifest;
		public unsafe global::Java.Lang.Object CurrentManifest {
			get {
				if (id_getCurrentManifest == IntPtr.Zero)
					id_getCurrentManifest = JNIEnv.GetMethodID (class_ref, "getCurrentManifest", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentManifest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentPeriodIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentPeriodIndexHandler ()
		{
			if (cb_getCurrentPeriodIndex == null)
				cb_getCurrentPeriodIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentPeriodIndex);
			return cb_getCurrentPeriodIndex;
		}

		static int n_GetCurrentPeriodIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPeriodIndex;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPeriodIndex;
		public unsafe int CurrentPeriodIndex {
			get {
				if (id_getCurrentPeriodIndex == IntPtr.Zero)
					id_getCurrentPeriodIndex = JNIEnv.GetMethodID (class_ref, "getCurrentPeriodIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPeriodIndex);
			}
		}

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static long n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPosition;
		public unsafe long CurrentPosition {
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
			}
		}

		static Delegate cb_getCurrentTag;
#pragma warning disable 0169
		static Delegate GetGetCurrentTagHandler ()
		{
			if (cb_getCurrentTag == null)
				cb_getCurrentTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTag);
			return cb_getCurrentTag;
		}

		static IntPtr n_GetCurrentTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTag);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTag;
		public unsafe global::Java.Lang.Object CurrentTag {
			get {
				if (id_getCurrentTag == IntPtr.Zero)
					id_getCurrentTag = JNIEnv.GetMethodID (class_ref, "getCurrentTag", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentTimeline;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimelineHandler ()
		{
			if (cb_getCurrentTimeline == null)
				cb_getCurrentTimeline = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTimeline);
			return cb_getCurrentTimeline;
		}

		static IntPtr n_GetCurrentTimeline (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTimeline);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTimeline;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline CurrentTimeline {
			get {
				if (id_getCurrentTimeline == IntPtr.Zero)
					id_getCurrentTimeline = JNIEnv.GetMethodID (class_ref, "getCurrentTimeline", "()Lcom/example/androidtvlibrary/main/adapter/Timeline;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTimeline), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentTrackGroups;
#pragma warning disable 0169
		static Delegate GetGetCurrentTrackGroupsHandler ()
		{
			if (cb_getCurrentTrackGroups == null)
				cb_getCurrentTrackGroups = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTrackGroups);
			return cb_getCurrentTrackGroups;
		}

		static IntPtr n_GetCurrentTrackGroups (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTrackGroups);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTrackGroups;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray CurrentTrackGroups {
			get {
				if (id_getCurrentTrackGroups == IntPtr.Zero)
					id_getCurrentTrackGroups = JNIEnv.GetMethodID (class_ref, "getCurrentTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTrackGroups), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentTrackSelections;
#pragma warning disable 0169
		static Delegate GetGetCurrentTrackSelectionsHandler ()
		{
			if (cb_getCurrentTrackSelections == null)
				cb_getCurrentTrackSelections = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrentTrackSelections);
			return cb_getCurrentTrackSelections;
		}

		static IntPtr n_GetCurrentTrackSelections (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTrackSelections);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTrackSelections;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray CurrentTrackSelections {
			get {
				if (id_getCurrentTrackSelections == IntPtr.Zero)
					id_getCurrentTrackSelections = JNIEnv.GetMethodID (class_ref, "getCurrentTrackSelections", "()Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTrackSelections), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentWindowIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentWindowIndexHandler ()
		{
			if (cb_getCurrentWindowIndex == null)
				cb_getCurrentWindowIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentWindowIndex);
			return cb_getCurrentWindowIndex;
		}

		static int n_GetCurrentWindowIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentWindowIndex;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentWindowIndex;
		public unsafe int CurrentWindowIndex {
			get {
				if (id_getCurrentWindowIndex == IntPtr.Zero)
					id_getCurrentWindowIndex = JNIEnv.GetMethodID (class_ref, "getCurrentWindowIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentWindowIndex);
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public unsafe long Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		IntPtr id_hasNext;
		public unsafe bool HasNext {
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
			}
		}

		static Delegate cb_hasPrevious;
#pragma warning disable 0169
		static Delegate GetHasPreviousHandler ()
		{
			if (cb_hasPrevious == null)
				cb_hasPrevious = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasPrevious);
			return cb_hasPrevious;
		}

		static bool n_HasPrevious (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrevious;
		}
#pragma warning restore 0169

		IntPtr id_hasPrevious;
		public unsafe bool HasPrevious {
			get {
				if (id_hasPrevious == IntPtr.Zero)
					id_hasPrevious = JNIEnv.GetMethodID (class_ref, "hasPrevious", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPrevious);
			}
		}

		static Delegate cb_isCurrentWindowDynamic;
#pragma warning disable 0169
		static Delegate GetIsCurrentWindowDynamicHandler ()
		{
			if (cb_isCurrentWindowDynamic == null)
				cb_isCurrentWindowDynamic = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentWindowDynamic);
			return cb_isCurrentWindowDynamic;
		}

		static bool n_IsCurrentWindowDynamic (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentWindowDynamic;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentWindowDynamic;
		public unsafe bool IsCurrentWindowDynamic {
			get {
				if (id_isCurrentWindowDynamic == IntPtr.Zero)
					id_isCurrentWindowDynamic = JNIEnv.GetMethodID (class_ref, "isCurrentWindowDynamic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentWindowDynamic);
			}
		}

		static Delegate cb_isCurrentWindowLive;
#pragma warning disable 0169
		static Delegate GetIsCurrentWindowLiveHandler ()
		{
			if (cb_isCurrentWindowLive == null)
				cb_isCurrentWindowLive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentWindowLive);
			return cb_isCurrentWindowLive;
		}

		static bool n_IsCurrentWindowLive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentWindowLive;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentWindowLive;
		public unsafe bool IsCurrentWindowLive {
			get {
				if (id_isCurrentWindowLive == IntPtr.Zero)
					id_isCurrentWindowLive = JNIEnv.GetMethodID (class_ref, "isCurrentWindowLive", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentWindowLive);
			}
		}

		static Delegate cb_isCurrentWindowSeekable;
#pragma warning disable 0169
		static Delegate GetIsCurrentWindowSeekableHandler ()
		{
			if (cb_isCurrentWindowSeekable == null)
				cb_isCurrentWindowSeekable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentWindowSeekable);
			return cb_isCurrentWindowSeekable;
		}

		static bool n_IsCurrentWindowSeekable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentWindowSeekable;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentWindowSeekable;
		public unsafe bool IsCurrentWindowSeekable {
			get {
				if (id_isCurrentWindowSeekable == IntPtr.Zero)
					id_isCurrentWindowSeekable = JNIEnv.GetMethodID (class_ref, "isCurrentWindowSeekable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentWindowSeekable);
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		IntPtr id_isLoading;
		public unsafe bool IsLoading {
			get {
				if (id_isLoading == IntPtr.Zero)
					id_isLoading = JNIEnv.GetMethodID (class_ref, "isLoading", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoading);
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		IntPtr id_isPlaying;
		public unsafe bool IsPlaying {
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
			}
		}

		static Delegate cb_isPlayingAd;
#pragma warning disable 0169
		static Delegate GetIsPlayingAdHandler ()
		{
			if (cb_isPlayingAd == null)
				cb_isPlayingAd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPlayingAd);
			return cb_isPlayingAd;
		}

		static bool n_IsPlayingAd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlayingAd;
		}
#pragma warning restore 0169

		IntPtr id_isPlayingAd;
		public unsafe bool IsPlayingAd {
			get {
				if (id_isPlayingAd == IntPtr.Zero)
					id_isPlayingAd = JNIEnv.GetMethodID (class_ref, "isPlayingAd", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlayingAd);
			}
		}

		static Delegate cb_getMetadataComponent;
#pragma warning disable 0169
		static Delegate GetGetMetadataComponentHandler ()
		{
			if (cb_getMetadataComponent == null)
				cb_getMetadataComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMetadataComponent);
			return cb_getMetadataComponent;
		}

		static IntPtr n_GetMetadataComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MetadataComponent);
		}
#pragma warning restore 0169

		IntPtr id_getMetadataComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent MetadataComponent {
			get {
				if (id_getMetadataComponent == IntPtr.Zero)
					id_getMetadataComponent = JNIEnv.GetMethodID (class_ref, "getMetadataComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$MetadataComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerMetadataComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadataComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNextWindowIndex;
#pragma warning disable 0169
		static Delegate GetGetNextWindowIndexHandler ()
		{
			if (cb_getNextWindowIndex == null)
				cb_getNextWindowIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNextWindowIndex);
			return cb_getNextWindowIndex;
		}

		static int n_GetNextWindowIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextWindowIndex;
		}
#pragma warning restore 0169

		IntPtr id_getNextWindowIndex;
		public unsafe int NextWindowIndex {
			get {
				if (id_getNextWindowIndex == IntPtr.Zero)
					id_getNextWindowIndex = JNIEnv.GetMethodID (class_ref, "getNextWindowIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNextWindowIndex);
			}
		}

		static Delegate cb_getPlayWhenReady;
#pragma warning disable 0169
		static Delegate GetGetPlayWhenReadyHandler ()
		{
			if (cb_getPlayWhenReady == null)
				cb_getPlayWhenReady = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetPlayWhenReady);
			return cb_getPlayWhenReady;
		}

		static bool n_GetPlayWhenReady (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayWhenReady;
		}
#pragma warning restore 0169

		static Delegate cb_setPlayWhenReady_Z;
#pragma warning disable 0169
		static Delegate GetSetPlayWhenReady_ZHandler ()
		{
			if (cb_setPlayWhenReady_Z == null)
				cb_setPlayWhenReady_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPlayWhenReady_Z);
			return cb_setPlayWhenReady_Z;
		}

		static void n_SetPlayWhenReady_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayWhenReady = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlayWhenReady;
		IntPtr id_setPlayWhenReady_Z;
		public unsafe bool PlayWhenReady {
			get {
				if (id_getPlayWhenReady == IntPtr.Zero)
					id_getPlayWhenReady = JNIEnv.GetMethodID (class_ref, "getPlayWhenReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getPlayWhenReady);
			}
			set {
				if (id_setPlayWhenReady_Z == IntPtr.Zero)
					id_setPlayWhenReady_Z = JNIEnv.GetMethodID (class_ref, "setPlayWhenReady", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayWhenReady_Z, __args);
			}
		}

		static Delegate cb_getPlaybackError;
#pragma warning disable 0169
		static Delegate GetGetPlaybackErrorHandler ()
		{
			if (cb_getPlaybackError == null)
				cb_getPlaybackError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlaybackError);
			return cb_getPlaybackError;
		}

		static IntPtr n_GetPlaybackError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaybackError);
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackError;
		public unsafe global::Java.Lang.Exception PlaybackError {
			get {
				if (id_getPlaybackError == IntPtr.Zero)
					id_getPlaybackError = JNIEnv.GetMethodID (class_ref, "getPlaybackError", "()Ljava/lang/Exception;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlaybackParameters;
#pragma warning disable 0169
		static Delegate GetGetPlaybackParametersHandler ()
		{
			if (cb_getPlaybackParameters == null)
				cb_getPlaybackParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlaybackParameters);
			return cb_getPlaybackParameters;
		}

		static IntPtr n_GetPlaybackParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaybackParameters);
		}
#pragma warning restore 0169

		static Delegate cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
#pragma warning disable 0169
		static Delegate GetSetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler ()
		{
			if (cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == null)
				cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_);
			return cb_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
		}

		static void n_SetPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlaybackParameters = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackParameters;
		IntPtr id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			get {
				if (id_getPlaybackParameters == IntPtr.Zero)
					id_getPlaybackParameters = JNIEnv.GetMethodID (class_ref, "getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackParameters), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == IntPtr.Zero)
					id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNIEnv.GetMethodID (class_ref, "setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_, __args);
			}
		}

		static Delegate cb_getPlaybackState;
#pragma warning disable 0169
		static Delegate GetGetPlaybackStateHandler ()
		{
			if (cb_getPlaybackState == null)
				cb_getPlaybackState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPlaybackState);
			return cb_getPlaybackState;
		}

		static int n_GetPlaybackState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlaybackState;
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackState;
		public unsafe int PlaybackState {
			get {
				if (id_getPlaybackState == IntPtr.Zero)
					id_getPlaybackState = JNIEnv.GetMethodID (class_ref, "getPlaybackState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackState);
			}
		}

		static Delegate cb_getPlaybackSuppressionReason;
#pragma warning disable 0169
		static Delegate GetGetPlaybackSuppressionReasonHandler ()
		{
			if (cb_getPlaybackSuppressionReason == null)
				cb_getPlaybackSuppressionReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPlaybackSuppressionReason);
			return cb_getPlaybackSuppressionReason;
		}

		static int n_GetPlaybackSuppressionReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlaybackSuppressionReason;
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackSuppressionReason;
		public unsafe int PlaybackSuppressionReason {
			get {
				if (id_getPlaybackSuppressionReason == IntPtr.Zero)
					id_getPlaybackSuppressionReason = JNIEnv.GetMethodID (class_ref, "getPlaybackSuppressionReason", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackSuppressionReason);
			}
		}

		static Delegate cb_getPreviousWindowIndex;
#pragma warning disable 0169
		static Delegate GetGetPreviousWindowIndexHandler ()
		{
			if (cb_getPreviousWindowIndex == null)
				cb_getPreviousWindowIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPreviousWindowIndex);
			return cb_getPreviousWindowIndex;
		}

		static int n_GetPreviousWindowIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousWindowIndex;
		}
#pragma warning restore 0169

		IntPtr id_getPreviousWindowIndex;
		public unsafe int PreviousWindowIndex {
			get {
				if (id_getPreviousWindowIndex == IntPtr.Zero)
					id_getPreviousWindowIndex = JNIEnv.GetMethodID (class_ref, "getPreviousWindowIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreviousWindowIndex);
			}
		}

		static Delegate cb_getRendererCount;
#pragma warning disable 0169
		static Delegate GetGetRendererCountHandler ()
		{
			if (cb_getRendererCount == null)
				cb_getRendererCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRendererCount);
			return cb_getRendererCount;
		}

		static int n_GetRendererCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RendererCount;
		}
#pragma warning restore 0169

		IntPtr id_getRendererCount;
		public unsafe int RendererCount {
			get {
				if (id_getRendererCount == IntPtr.Zero)
					id_getRendererCount = JNIEnv.GetMethodID (class_ref, "getRendererCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRendererCount);
			}
		}

		static Delegate cb_getRepeatMode;
#pragma warning disable 0169
		static Delegate GetGetRepeatModeHandler ()
		{
			if (cb_getRepeatMode == null)
				cb_getRepeatMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRepeatMode);
			return cb_getRepeatMode;
		}

		static int n_GetRepeatMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatMode;
		}
#pragma warning restore 0169

		static Delegate cb_setRepeatMode_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatMode_IHandler ()
		{
			if (cb_setRepeatMode_I == null)
				cb_setRepeatMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRepeatMode_I);
			return cb_setRepeatMode_I;
		}

		static void n_SetRepeatMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RepeatMode = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRepeatMode;
		IntPtr id_setRepeatMode_I;
		public unsafe int RepeatMode {
			get {
				if (id_getRepeatMode == IntPtr.Zero)
					id_getRepeatMode = JNIEnv.GetMethodID (class_ref, "getRepeatMode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRepeatMode);
			}
			set {
				if (id_setRepeatMode_I == IntPtr.Zero)
					id_setRepeatMode_I = JNIEnv.GetMethodID (class_ref, "setRepeatMode", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRepeatMode_I, __args);
			}
		}

		static Delegate cb_getShuffleModeEnabled;
#pragma warning disable 0169
		static Delegate GetGetShuffleModeEnabledHandler ()
		{
			if (cb_getShuffleModeEnabled == null)
				cb_getShuffleModeEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetShuffleModeEnabled);
			return cb_getShuffleModeEnabled;
		}

		static bool n_GetShuffleModeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShuffleModeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setShuffleModeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetShuffleModeEnabled_ZHandler ()
		{
			if (cb_setShuffleModeEnabled_Z == null)
				cb_setShuffleModeEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShuffleModeEnabled_Z);
			return cb_setShuffleModeEnabled_Z;
		}

		static void n_SetShuffleModeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShuffleModeEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_getShuffleModeEnabled;
		IntPtr id_setShuffleModeEnabled_Z;
		public unsafe bool ShuffleModeEnabled {
			get {
				if (id_getShuffleModeEnabled == IntPtr.Zero)
					id_getShuffleModeEnabled = JNIEnv.GetMethodID (class_ref, "getShuffleModeEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getShuffleModeEnabled);
			}
			set {
				if (id_setShuffleModeEnabled_Z == IntPtr.Zero)
					id_setShuffleModeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setShuffleModeEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShuffleModeEnabled_Z, __args);
			}
		}

		static Delegate cb_getTextComponent;
#pragma warning disable 0169
		static Delegate GetGetTextComponentHandler ()
		{
			if (cb_getTextComponent == null)
				cb_getTextComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTextComponent);
			return cb_getTextComponent;
		}

		static IntPtr n_GetTextComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextComponent);
		}
#pragma warning restore 0169

		IntPtr id_getTextComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent TextComponent {
			get {
				if (id_getTextComponent == IntPtr.Zero)
					id_getTextComponent = JNIEnv.GetMethodID (class_ref, "getTextComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$TextComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerTextComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTotalBufferedDuration;
#pragma warning disable 0169
		static Delegate GetGetTotalBufferedDurationHandler ()
		{
			if (cb_getTotalBufferedDuration == null)
				cb_getTotalBufferedDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTotalBufferedDuration);
			return cb_getTotalBufferedDuration;
		}

		static long n_GetTotalBufferedDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalBufferedDuration;
		}
#pragma warning restore 0169

		IntPtr id_getTotalBufferedDuration;
		public unsafe long TotalBufferedDuration {
			get {
				if (id_getTotalBufferedDuration == IntPtr.Zero)
					id_getTotalBufferedDuration = JNIEnv.GetMethodID (class_ref, "getTotalBufferedDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTotalBufferedDuration);
			}
		}

		static Delegate cb_getVideoComponent;
#pragma warning disable 0169
		static Delegate GetGetVideoComponentHandler ()
		{
			if (cb_getVideoComponent == null)
				cb_getVideoComponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoComponent);
			return cb_getVideoComponent;
		}

		static IntPtr n_GetVideoComponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoComponent);
		}
#pragma warning restore 0169

		IntPtr id_getVideoComponent;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent VideoComponent {
			get {
				if (id_getVideoComponent == IntPtr.Zero)
					id_getVideoComponent = JNIEnv.GetMethodID (class_ref, "getVideoComponent", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer$VideoComponent;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerVideoComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoComponent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_Handler ()
		{
			if (cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == null)
				cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_);
			return cb_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		}

		static void n_AddListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		public unsafe void AddListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener p0)
		{
			if (id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == IntPtr.Zero)
				id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_, __args);
		}

		static Delegate cb_getRendererType_I;
#pragma warning disable 0169
		static Delegate GetGetRendererType_IHandler ()
		{
			if (cb_getRendererType_I == null)
				cb_getRendererType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRendererType_I);
			return cb_getRendererType_I;
		}

		static int n_GetRendererType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRendererType (p0);
		}
#pragma warning restore 0169

		IntPtr id_getRendererType_I;
		public unsafe int GetRendererType (int p0)
		{
			if (id_getRendererType_I == IntPtr.Zero)
				id_getRendererType_I = JNIEnv.GetMethodID (class_ref, "getRendererType", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRendererType_I, __args);
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Next);
			return cb_next;
		}

		static void n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next ();
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe void Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_next);
		}

		static Delegate cb_previous;
#pragma warning disable 0169
		static Delegate GetPreviousHandler ()
		{
			if (cb_previous == null)
				cb_previous = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Previous);
			return cb_previous;
		}

		static void n_Previous (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Previous ();
		}
#pragma warning restore 0169

		IntPtr id_previous;
		public unsafe void Previous ()
		{
			if (id_previous == IntPtr.Zero)
				id_previous = JNIEnv.GetMethodID (class_ref, "previous", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_previous);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_Handler ()
		{
			if (cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == null)
				cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_);
			return cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		}

		static void n_RemoveListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_;
		public unsafe void RemoveListener (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener p0)
		{
			if (id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ == IntPtr.Zero)
				id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer$EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_EventListener_, __args);
		}

		static Delegate cb_seekTo_IJ;
#pragma warning disable 0169
		static Delegate GetSeekTo_IJHandler ()
		{
			if (cb_seekTo_IJ == null)
				cb_seekTo_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_V) n_SeekTo_IJ);
			return cb_seekTo_IJ;
		}

		static void n_SeekTo_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_IJ;
		public unsafe void SeekTo (int p0, long p1)
		{
			if (id_seekTo_IJ == IntPtr.Zero)
				id_seekTo_IJ = JNIEnv.GetMethodID (class_ref, "seekTo", "(IJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_IJ, __args);
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static void n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_J;
		public unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
		}

		static Delegate cb_seekToDefaultPosition;
#pragma warning disable 0169
		static Delegate GetSeekToDefaultPositionHandler ()
		{
			if (cb_seekToDefaultPosition == null)
				cb_seekToDefaultPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SeekToDefaultPosition);
			return cb_seekToDefaultPosition;
		}

		static void n_SeekToDefaultPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekToDefaultPosition ();
		}
#pragma warning restore 0169

		IntPtr id_seekToDefaultPosition;
		public unsafe void SeekToDefaultPosition ()
		{
			if (id_seekToDefaultPosition == IntPtr.Zero)
				id_seekToDefaultPosition = JNIEnv.GetMethodID (class_ref, "seekToDefaultPosition", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekToDefaultPosition);
		}

		static Delegate cb_seekToDefaultPosition_I;
#pragma warning disable 0169
		static Delegate GetSeekToDefaultPosition_IHandler ()
		{
			if (cb_seekToDefaultPosition_I == null)
				cb_seekToDefaultPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SeekToDefaultPosition_I);
			return cb_seekToDefaultPosition_I;
		}

		static void n_SeekToDefaultPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekToDefaultPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekToDefaultPosition_I;
		public unsafe void SeekToDefaultPosition (int p0)
		{
			if (id_seekToDefaultPosition_I == IntPtr.Zero)
				id_seekToDefaultPosition_I = JNIEnv.GetMethodID (class_ref, "seekToDefaultPosition", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekToDefaultPosition_I, __args);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

		static Delegate cb_stop_Z;
#pragma warning disable 0169
		static Delegate GetStop_ZHandler ()
		{
			if (cb_stop_Z == null)
				cb_stop_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Stop_Z);
			return cb_stop_Z;
		}

		static void n_Stop_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop (p0);
		}
#pragma warning restore 0169

		IntPtr id_stop_Z;
		public unsafe void Stop (bool p0)
		{
			if (id_stop_Z == IntPtr.Zero)
				id_stop_Z = JNIEnv.GetMethodID (class_ref, "stop", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop_Z, __args);
		}

	}
}
