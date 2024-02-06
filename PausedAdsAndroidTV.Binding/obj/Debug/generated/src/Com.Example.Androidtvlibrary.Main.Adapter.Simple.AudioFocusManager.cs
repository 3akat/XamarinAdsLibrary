using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Simple {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager", DoNotGenerateAcw=true)]
	public sealed partial class AudioFocusManager : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/field[@name='PLAYER_COMMAND_DO_NOT_PLAY']"
		[Register ("PLAYER_COMMAND_DO_NOT_PLAY")]
		public const int PlayerCommandDoNotPlay = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/field[@name='PLAYER_COMMAND_PLAY_WHEN_READY']"
		[Register ("PLAYER_COMMAND_PLAY_WHEN_READY")]
		public const int PlayerCommandPlayWhenReady = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/field[@name='PLAYER_COMMAND_WAIT_FOR_CALLBACK']"
		[Register ("PLAYER_COMMAND_WAIT_FOR_CALLBACK")]
		public const int PlayerCommandWaitForCallback = (int) 0;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='AudioFocusManager.PlayerCommand']"
		[Register ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerCommand", "", "Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager/IPlayerCommandInvoker")]
		public partial interface IPlayerCommand : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerCommand", DoNotGenerateAcw=true)]
		internal partial class IPlayerCommandInvoker : global::Java.Lang.Object, IPlayerCommand {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerCommand", typeof (IPlayerCommandInvoker));

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

			public static IPlayerCommand GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPlayerCommand> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.simple.AudioFocusManager.PlayerCommand'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPlayerCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='AudioFocusManager.PlayerControl']"
		[Register ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerControl", "", "Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager/IPlayerControlInvoker")]
		public partial interface IPlayerControl : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='AudioFocusManager.PlayerControl']/method[@name='executePlayerCommand' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("executePlayerCommand", "(I)V", "GetExecutePlayerCommand_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager/IPlayerControlInvoker, PausedAdsAndroidTV.Binding")]
			void ExecutePlayerCommand (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/interface[@name='AudioFocusManager.PlayerControl']/method[@name='setVolumeMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setVolumeMultiplier", "(F)V", "GetSetVolumeMultiplier_FHandler:Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager/IPlayerControlInvoker, PausedAdsAndroidTV.Binding")]
			void SetVolumeMultiplier (float p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerControl", DoNotGenerateAcw=true)]
		internal partial class IPlayerControlInvoker : global::Java.Lang.Object, IPlayerControl {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerControl", typeof (IPlayerControlInvoker));

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

			public static IPlayerControl GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPlayerControl> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.simple.AudioFocusManager.PlayerControl'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPlayerControlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_executePlayerCommand_I;
#pragma warning disable 0169
			static Delegate GetExecutePlayerCommand_IHandler ()
			{
				if (cb_executePlayerCommand_I == null)
					cb_executePlayerCommand_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ExecutePlayerCommand_I);
				return cb_executePlayerCommand_I;
			}

			static void n_ExecutePlayerCommand_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ExecutePlayerCommand (p0);
			}
#pragma warning restore 0169

			IntPtr id_executePlayerCommand_I;
			public unsafe void ExecutePlayerCommand (int p0)
			{
				if (id_executePlayerCommand_I == IntPtr.Zero)
					id_executePlayerCommand_I = JNIEnv.GetMethodID (class_ref, "executePlayerCommand", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_executePlayerCommand_I, __args);
			}

			static Delegate cb_setVolumeMultiplier_F;
#pragma warning disable 0169
			static Delegate GetSetVolumeMultiplier_FHandler ()
			{
				if (cb_setVolumeMultiplier_F == null)
					cb_setVolumeMultiplier_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetVolumeMultiplier_F);
				return cb_setVolumeMultiplier_F;
			}

			static void n_SetVolumeMultiplier_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetVolumeMultiplier (p0);
			}
#pragma warning restore 0169

			IntPtr id_setVolumeMultiplier_F;
			public unsafe void SetVolumeMultiplier (float p0)
			{
				if (id_setVolumeMultiplier_F == IntPtr.Zero)
					id_setVolumeMultiplier_F = JNIEnv.GetMethodID (class_ref, "setVolumeMultiplier", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolumeMultiplier_F, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/simple/AudioFocusManager", typeof (AudioFocusManager));

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

		internal AudioFocusManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/constructor[@name='AudioFocusManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.simple.AudioFocusManager.PlayerControl']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerControl;)V", "")]
		public unsafe AudioFocusManager (global::Android.Content.Context context, global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.Simple.AudioFocusManager.IPlayerControl playerControl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/simple/AudioFocusManager$PlayerControl;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [2] = new JniArgumentValue ((playerControl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playerControl).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (playerControl);
			}
		}

		public unsafe float VolumeMultiplier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/method[@name='getVolumeMultiplier' and count(parameter)=0]"
			[Register ("getVolumeMultiplier", "()F", "")]
			get {
				const string __id = "getVolumeMultiplier.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/method[@name='setAudioAttributes' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioAttributes']]"
		[Register ("setAudioAttributes", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;)V", "")]
		public unsafe void SetAudioAttributes (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes audioAttributes)
		{
			const string __id = "setAudioAttributes.(Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((audioAttributes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioAttributes).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (audioAttributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.simple']/class[@name='AudioFocusManager']/method[@name='updateAudioFocus' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("updateAudioFocus", "(ZI)I", "")]
		public unsafe int UpdateAudioFocus (bool playWhenReady, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"StateIdle", "StateBuffering", "StateReady", "StateEnded"})]
		int playbackState)
		{
			const string __id = "updateAudioFocus.(ZI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (playWhenReady);
				__args [1] = new JniArgumentValue (playbackState);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
