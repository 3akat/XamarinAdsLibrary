using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink", DoNotGenerateAcw=true)]
	public sealed partial class DefaultAudioSink : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSink {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/field[@name='enablePreV21AudioSessionWorkaround']"
		[Register ("enablePreV21AudioSessionWorkaround")]
		public static bool EnablePreV21AudioSessionWorkaround {
			get {
				const string __id = "enablePreV21AudioSessionWorkaround.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "enablePreV21AudioSessionWorkaround.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/field[@name='failOnSpuriousAudioTimestamp']"
		[Register ("failOnSpuriousAudioTimestamp")]
		public static bool FailOnSpuriousAudioTimestamp {
			get {
				const string __id = "failOnSpuriousAudioTimestamp.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "failOnSpuriousAudioTimestamp.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.player.AudioSink

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AudioSink']/field[@name='CURRENT_POSITION_NOT_SET']"
			[Register ("CURRENT_POSITION_NOT_SET")]
			public const long CurrentPositionNotSet = (long) -9223372036854775808;

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='DefaultAudioSink.AudioProcessorChain']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$AudioProcessorChain", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink/IAudioProcessorChainInvoker")]
		public partial interface IAudioProcessorChain : IJavaObject, IJavaPeerable {
			long SkippedOutputFrameCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='DefaultAudioSink.AudioProcessorChain']/method[@name='getSkippedOutputFrameCount' and count(parameter)=0]"
				[Register ("getSkippedOutputFrameCount", "()J", "GetGetSkippedOutputFrameCountHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink/IAudioProcessorChainInvoker, PausedAdsAndroidTV.Binding")]
				get; 
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='DefaultAudioSink.AudioProcessorChain']/method[@name='applyPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("applyPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "GetApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink/IAudioProcessorChainInvoker, PausedAdsAndroidTV.Binding")]
			global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters ApplyPlaybackParameters (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='DefaultAudioSink.AudioProcessorChain']/method[@name='getAudioProcessors' and count(parameter)=0]"
			[Register ("getAudioProcessors", "()[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;", "GetGetAudioProcessorsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink/IAudioProcessorChainInvoker, PausedAdsAndroidTV.Binding")]
			global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] GetAudioProcessors ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='DefaultAudioSink.AudioProcessorChain']/method[@name='getMediaDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getMediaDuration", "(J)J", "GetGetMediaDuration_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink/IAudioProcessorChainInvoker, PausedAdsAndroidTV.Binding")]
			long GetMediaDuration (long p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$AudioProcessorChain", DoNotGenerateAcw=true)]
		internal partial class IAudioProcessorChainInvoker : global::Java.Lang.Object, IAudioProcessorChain {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$AudioProcessorChain", typeof (IAudioProcessorChainInvoker));

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

			public static IAudioProcessorChain GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAudioProcessorChain> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.DefaultAudioSink.AudioProcessorChain'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAudioProcessorChainInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getSkippedOutputFrameCount;
#pragma warning disable 0169
			static Delegate GetGetSkippedOutputFrameCountHandler ()
			{
				if (cb_getSkippedOutputFrameCount == null)
					cb_getSkippedOutputFrameCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSkippedOutputFrameCount);
				return cb_getSkippedOutputFrameCount;
			}

			static long n_GetSkippedOutputFrameCount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.IAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SkippedOutputFrameCount;
			}
#pragma warning restore 0169

			IntPtr id_getSkippedOutputFrameCount;
			public unsafe long SkippedOutputFrameCount {
				get {
					if (id_getSkippedOutputFrameCount == IntPtr.Zero)
						id_getSkippedOutputFrameCount = JNIEnv.GetMethodID (class_ref, "getSkippedOutputFrameCount", "()J");
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSkippedOutputFrameCount);
				}
			}

			static Delegate cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
#pragma warning disable 0169
			static Delegate GetApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler ()
			{
				if (cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == null)
					cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_);
				return cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
			}

			static IntPtr n_ApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.IAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplyPlaybackParameters (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters ApplyPlaybackParameters (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters p0)
			{
				if (id_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == IntPtr.Zero)
					id_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNIEnv.GetMethodID (class_ref, "applyPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_getAudioProcessors;
#pragma warning disable 0169
			static Delegate GetGetAudioProcessorsHandler ()
			{
				if (cb_getAudioProcessors == null)
					cb_getAudioProcessors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioProcessors);
				return cb_getAudioProcessors;
			}

			static IntPtr n_GetAudioProcessors (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.IAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetAudioProcessors ());
			}
#pragma warning restore 0169

			IntPtr id_getAudioProcessors;
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] GetAudioProcessors ()
			{
				if (id_getAudioProcessors == IntPtr.Zero)
					id_getAudioProcessors = JNIEnv.GetMethodID (class_ref, "getAudioProcessors", "()[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;");
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioProcessors), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor));
			}

			static Delegate cb_getMediaDuration_J;
#pragma warning disable 0169
			static Delegate GetGetMediaDuration_JHandler ()
			{
				if (cb_getMediaDuration_J == null)
					cb_getMediaDuration_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_GetMediaDuration_J);
				return cb_getMediaDuration_J;
			}

			static long n_GetMediaDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.IAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetMediaDuration (p0);
			}
#pragma warning restore 0169

			IntPtr id_getMediaDuration_J;
			public unsafe long GetMediaDuration (long p0)
			{
				if (id_getMediaDuration_J == IntPtr.Zero)
					id_getMediaDuration_J = JNIEnv.GetMethodID (class_ref, "getMediaDuration", "(J)J");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMediaDuration_J, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$DefaultAudioProcessorChain", DoNotGenerateAcw=true)]
		public partial class DefaultAudioProcessorChain : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.IAudioProcessorChain {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$DefaultAudioProcessorChain", typeof (DefaultAudioProcessorChain));

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

			protected DefaultAudioProcessorChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']/constructor[@name='DefaultAudioSink.DefaultAudioProcessorChain' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor...']]"
			[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;)V", "")]
			public unsafe DefaultAudioProcessorChain (params global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] audioProcessors) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_audioProcessors = JNIEnv.NewArray (audioProcessors);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_audioProcessors);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (audioProcessors != null) {
						JNIEnv.CopyArray (native_audioProcessors, audioProcessors);
						JNIEnv.DeleteLocalRef (native_audioProcessors);
					}
					global::System.GC.KeepAlive (audioProcessors);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']/constructor[@name='DefaultAudioSink.DefaultAudioProcessorChain' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.SilenceSkippingAudioProcessor'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.player.SonicAudioProcessor']]"
			[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;Lcom/example/androidtvlibrary/main/adapter/player/SilenceSkippingAudioProcessor;Lcom/example/androidtvlibrary/main/adapter/player/SonicAudioProcessor;)V", "")]
			public unsafe DefaultAudioProcessorChain (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] audioProcessors, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.SilenceSkippingAudioProcessor silenceSkippingAudioProcessor, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.SonicAudioProcessor sonicAudioProcessor) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;Lcom/example/androidtvlibrary/main/adapter/player/SilenceSkippingAudioProcessor;Lcom/example/androidtvlibrary/main/adapter/player/SonicAudioProcessor;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_audioProcessors = JNIEnv.NewArray (audioProcessors);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_audioProcessors);
					__args [1] = new JniArgumentValue ((silenceSkippingAudioProcessor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) silenceSkippingAudioProcessor).Handle);
					__args [2] = new JniArgumentValue ((sonicAudioProcessor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sonicAudioProcessor).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (audioProcessors != null) {
						JNIEnv.CopyArray (native_audioProcessors, audioProcessors);
						JNIEnv.DeleteLocalRef (native_audioProcessors);
					}
					global::System.GC.KeepAlive (audioProcessors);
					global::System.GC.KeepAlive (silenceSkippingAudioProcessor);
					global::System.GC.KeepAlive (sonicAudioProcessor);
				}
			}

			static Delegate cb_getSkippedOutputFrameCount;
#pragma warning disable 0169
			static Delegate GetGetSkippedOutputFrameCountHandler ()
			{
				if (cb_getSkippedOutputFrameCount == null)
					cb_getSkippedOutputFrameCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSkippedOutputFrameCount);
				return cb_getSkippedOutputFrameCount;
			}

			static long n_GetSkippedOutputFrameCount (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.DefaultAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SkippedOutputFrameCount;
			}
#pragma warning restore 0169

			public virtual unsafe long SkippedOutputFrameCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']/method[@name='getSkippedOutputFrameCount' and count(parameter)=0]"
				[Register ("getSkippedOutputFrameCount", "()J", "GetGetSkippedOutputFrameCountHandler")]
				get {
					const string __id = "getSkippedOutputFrameCount.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
#pragma warning disable 0169
			static Delegate GetApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler ()
			{
				if (cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ == null)
					cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_);
				return cb_applyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_;
			}

			static IntPtr n_ApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_playbackParameters)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.DefaultAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var playbackParameters = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (native_playbackParameters, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplyPlaybackParameters (playbackParameters));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']/method[@name='applyPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("applyPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "GetApplyPlaybackParameters_Lcom_example_androidtvlibrary_main_adapter_wow_PlaybackParameters_Handler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters ApplyPlaybackParameters (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters playbackParameters)
			{
				const string __id = "applyPlaybackParameters.(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((playbackParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackParameters).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (playbackParameters);
				}
			}

			static Delegate cb_getAudioProcessors;
#pragma warning disable 0169
			static Delegate GetGetAudioProcessorsHandler ()
			{
				if (cb_getAudioProcessors == null)
					cb_getAudioProcessors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioProcessors);
				return cb_getAudioProcessors;
			}

			static IntPtr n_GetAudioProcessors (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.DefaultAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetAudioProcessors ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']/method[@name='getAudioProcessors' and count(parameter)=0]"
			[Register ("getAudioProcessors", "()[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;", "GetGetAudioProcessorsHandler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] GetAudioProcessors ()
			{
				const string __id = "getAudioProcessors.()[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor));
				} finally {
				}
			}

			static Delegate cb_getMediaDuration_J;
#pragma warning disable 0169
			static Delegate GetGetMediaDuration_JHandler ()
			{
				if (cb_getMediaDuration_J == null)
					cb_getMediaDuration_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_GetMediaDuration_J);
				return cb_getMediaDuration_J;
			}

			static long n_GetMediaDuration_J (IntPtr jnienv, IntPtr native__this, long playoutDuration)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.DefaultAudioProcessorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetMediaDuration (playoutDuration);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.DefaultAudioProcessorChain']/method[@name='getMediaDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getMediaDuration", "(J)J", "GetGetMediaDuration_JHandler")]
			public virtual unsafe long GetMediaDuration (long playoutDuration)
			{
				const string __id = "getMediaDuration.(J)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (playoutDuration);
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink.InvalidAudioTrackTimestampException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$InvalidAudioTrackTimestampException", DoNotGenerateAcw=true)]
		public sealed partial class InvalidAudioTrackTimestampException : global::Java.Lang.RuntimeException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$InvalidAudioTrackTimestampException", typeof (InvalidAudioTrackTimestampException));

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

			internal InvalidAudioTrackTimestampException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultAudioSink", typeof (DefaultAudioSink));

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

		internal DefaultAudioSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/constructor[@name='DefaultAudioSink' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioCapabilities'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor[]']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;)V", "")]
		public unsafe DefaultAudioSink (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities audioCapabilities, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] audioProcessors) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_audioProcessors = JNIEnv.NewArray (audioProcessors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((audioCapabilities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioCapabilities).Handle);
				__args [1] = new JniArgumentValue (native_audioProcessors);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (audioProcessors != null) {
					JNIEnv.CopyArray (native_audioProcessors, audioProcessors);
					JNIEnv.DeleteLocalRef (native_audioProcessors);
				}
				global::System.GC.KeepAlive (audioCapabilities);
				global::System.GC.KeepAlive (audioProcessors);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/constructor[@name='DefaultAudioSink' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioCapabilities'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.AudioProcessor[]'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;Z)V", "")]
		public unsafe DefaultAudioSink (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities audioCapabilities, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioProcessor[] audioProcessors, bool enableFloatOutput) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;[Lcom/example/androidtvlibrary/main/adapter/player/AudioProcessor;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_audioProcessors = JNIEnv.NewArray (audioProcessors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((audioCapabilities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioCapabilities).Handle);
				__args [1] = new JniArgumentValue (native_audioProcessors);
				__args [2] = new JniArgumentValue (enableFloatOutput);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (audioProcessors != null) {
					JNIEnv.CopyArray (native_audioProcessors, audioProcessors);
					JNIEnv.DeleteLocalRef (native_audioProcessors);
				}
				global::System.GC.KeepAlive (audioCapabilities);
				global::System.GC.KeepAlive (audioProcessors);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/constructor[@name='DefaultAudioSink' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioCapabilities'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.DefaultAudioSink.AudioProcessorChain'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;Lcom/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$AudioProcessorChain;Z)V", "")]
		public unsafe DefaultAudioSink (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioCapabilities audioCapabilities, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultAudioSink.IAudioProcessorChain audioProcessorChain, bool enableFloatOutput) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/player/AudioCapabilities;Lcom/example/androidtvlibrary/main/adapter/player/DefaultAudioSink$AudioProcessorChain;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((audioCapabilities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioCapabilities).Handle);
				__args [1] = new JniArgumentValue ((audioProcessorChain == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioProcessorChain).Handle);
				__args [2] = new JniArgumentValue (enableFloatOutput);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (audioCapabilities);
				global::System.GC.KeepAlive (audioProcessorChain);
			}
		}

		public unsafe bool HasPendingData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='hasPendingData' and count(parameter)=0]"
			[Register ("hasPendingData", "()Z", "")]
			get {
				const string __id = "hasPendingData.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "")]
			get {
				const string __id = "isEnded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters PlaybackParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='getPlaybackParameters' and count(parameter)=0]"
			[Register ("getPlaybackParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;", "")]
			get {
				const string __id = "getPlaybackParameters.()Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlaybackParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='setPlaybackParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlaybackParameters']]"
			[Register ("setPlaybackParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V", "")]
			set {
				const string __id = "setPlaybackParameters.(Lcom/example/androidtvlibrary/main/adapter/wow/PlaybackParameters;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='configure' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int[]'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("configure", "(IIII[III)V", "")]
		public unsafe void Configure ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int inputEncoding, int inputChannelCount, int inputSampleRate, int specifiedBufferSize, int[] outputChannels, int trimStartFrames, int trimEndFrames)
		{
			const string __id = "configure.(IIII[III)V";
			IntPtr native_outputChannels = JNIEnv.NewArray (outputChannels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (inputEncoding);
				__args [1] = new JniArgumentValue (inputChannelCount);
				__args [2] = new JniArgumentValue (inputSampleRate);
				__args [3] = new JniArgumentValue (specifiedBufferSize);
				__args [4] = new JniArgumentValue (native_outputChannels);
				__args [5] = new JniArgumentValue (trimStartFrames);
				__args [6] = new JniArgumentValue (trimEndFrames);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (outputChannels != null) {
					JNIEnv.CopyArray (native_outputChannels, outputChannels);
					JNIEnv.DeleteLocalRef (native_outputChannels);
				}
				global::System.GC.KeepAlive (outputChannels);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='disableTunneling' and count(parameter)=0]"
		[Register ("disableTunneling", "()V", "")]
		public unsafe void DisableTunneling ()
		{
			const string __id = "disableTunneling.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='enableTunnelingV21' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableTunnelingV21", "(I)V", "")]
		public unsafe void EnableTunnelingV21 (int tunnelingAudioSessionId)
		{
			const string __id = "enableTunnelingV21.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tunnelingAudioSessionId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='getCurrentPositionUs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getCurrentPositionUs", "(Z)J", "")]
		public unsafe long GetCurrentPositionUs (bool sourceEnded)
		{
			const string __id = "getCurrentPositionUs.(Z)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sourceEnded);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='handleBuffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long']]"
		[Register ("handleBuffer", "(Ljava/nio/ByteBuffer;J)Z", "")]
		public unsafe bool HandleBuffer (global::Java.Nio.ByteBuffer buffer, long presentationTimeUs)
		{
			const string __id = "handleBuffer.(Ljava/nio/ByteBuffer;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (presentationTimeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='handleDiscontinuity' and count(parameter)=0]"
		[Register ("handleDiscontinuity", "()V", "")]
		public unsafe void HandleDiscontinuity ()
		{
			const string __id = "handleDiscontinuity.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "")]
		public unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()V", "")]
		public unsafe void Play ()
		{
			const string __id = "play.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='playToEndOfStream' and count(parameter)=0]"
		[Register ("playToEndOfStream", "()V", "")]
		public unsafe void PlayToEndOfStream ()
		{
			const string __id = "playToEndOfStream.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='setAudioAttributes' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioAttributes']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='setAudioSessionId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioSessionId", "(I)V", "")]
		public unsafe void SetAudioSessionId (int audioSessionId)
		{
			const string __id = "setAudioSessionId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (audioSessionId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='setAuxEffectInfo' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AuxEffectInfo']]"
		[Register ("setAuxEffectInfo", "(Lcom/example/androidtvlibrary/main/adapter/player/AuxEffectInfo;)V", "")]
		public unsafe void SetAuxEffectInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AuxEffectInfo auxEffectInfo)
		{
			const string __id = "setAuxEffectInfo.(Lcom/example/androidtvlibrary/main/adapter/player/AuxEffectInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((auxEffectInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) auxEffectInfo).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (auxEffectInfo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AudioSink.Listener']]"
		[Register ("setListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AudioSink$Listener;)V", "")]
		public unsafe void SetListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener listener)
		{
			const string __id = "setListener.(Lcom/example/androidtvlibrary/main/adapter/player/AudioSink$Listener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='setVolume' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVolume", "(F)V", "")]
		public unsafe void SetVolume (float volume)
		{
			const string __id = "setVolume.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (volume);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultAudioSink']/method[@name='supportsOutput' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("supportsOutput", "(II)Z", "")]
		public unsafe bool SupportsOutput (int channelCount, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int encoding)
		{
			const string __id = "supportsOutput.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (channelCount);
				__args [1] = new JniArgumentValue (encoding);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListener"

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListenerImplementor __CreateIAudioSinkListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IAudioSinkListenerImplementor (this);
		}

		#endregion

	}
}
