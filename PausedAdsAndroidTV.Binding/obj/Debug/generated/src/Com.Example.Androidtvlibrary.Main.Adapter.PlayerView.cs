using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/PlayerView", DoNotGenerateAcw=true)]
	public partial class PlayerView : global::Android.Widget.FrameLayout, global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/field[@name='SAMPLE_VAST_TAG_URL']"
		[Register ("SAMPLE_VAST_TAG_URL")]
		public static string SampleVastTagUrl {
			get {
				const string __id = "SAMPLE_VAST_TAG_URL.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "SAMPLE_VAST_TAG_URL.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/field[@name='SAMPLE_VIDEO_URL']"
		[Register ("SAMPLE_VIDEO_URL")]
		public static string SampleVideoUrl {
			get {
				const string __id = "SAMPLE_VIDEO_URL.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "SAMPLE_VIDEO_URL.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/field[@name='SHOW_BUFFERING_ALWAYS']"
		[Register ("SHOW_BUFFERING_ALWAYS")]
		public const int ShowBufferingAlways = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/field[@name='SHOW_BUFFERING_NEVER']"
		[Register ("SHOW_BUFFERING_NEVER")]
		public const int ShowBufferingNever = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/field[@name='SHOW_BUFFERING_WHEN_PLAYING']"
		[Register ("SHOW_BUFFERING_WHEN_PLAYING")]
		public const int ShowBufferingWhenPlaying = (int) 1;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.OnActionListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/PlayerView$OnActionListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IOnActionListenerInvoker")]
		public partial interface IOnActionListener : global::Android.OS.IParcelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.OnActionListener']/method[@name='onContentComplete' and count(parameter)=0]"
			[Register ("onContentComplete", "()V", "GetOnContentCompleteHandler:Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IOnActionListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnContentComplete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.OnActionListener']/method[@name='onContentPause' and count(parameter)=0]"
			[Register ("onContentPause", "()V", "GetOnContentPauseHandler:Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IOnActionListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnContentPause ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.OnActionListener']/method[@name='onContentResume' and count(parameter)=0]"
			[Register ("onContentResume", "()V", "GetOnContentResumeHandler:Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IOnActionListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnContentResume ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/PlayerView$OnActionListener", DoNotGenerateAcw=true)]
		internal partial class IOnActionListenerInvoker : global::Java.Lang.Object, IOnActionListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/PlayerView$OnActionListener", typeof (IOnActionListenerInvoker));

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

			public static IOnActionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnActionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.PlayerView.OnActionListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnActionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onContentComplete;
#pragma warning disable 0169
			static Delegate GetOnContentCompleteHandler ()
			{
				if (cb_onContentComplete == null)
					cb_onContentComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnContentComplete);
				return cb_onContentComplete;
			}

			static void n_OnContentComplete (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnContentComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onContentComplete;
			public unsafe void OnContentComplete ()
			{
				if (id_onContentComplete == IntPtr.Zero)
					id_onContentComplete = JNIEnv.GetMethodID (class_ref, "onContentComplete", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContentComplete);
			}

			static Delegate cb_onContentPause;
#pragma warning disable 0169
			static Delegate GetOnContentPauseHandler ()
			{
				if (cb_onContentPause == null)
					cb_onContentPause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnContentPause);
				return cb_onContentPause;
			}

			static void n_OnContentPause (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnContentPause ();
			}
#pragma warning restore 0169

			IntPtr id_onContentPause;
			public unsafe void OnContentPause ()
			{
				if (id_onContentPause == IntPtr.Zero)
					id_onContentPause = JNIEnv.GetMethodID (class_ref, "onContentPause", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContentPause);
			}

			static Delegate cb_onContentResume;
#pragma warning disable 0169
			static Delegate GetOnContentResumeHandler ()
			{
				if (cb_onContentResume == null)
					cb_onContentResume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnContentResume);
				return cb_onContentResume;
			}

			static void n_OnContentResume (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnContentResume ();
			}
#pragma warning restore 0169

			IntPtr id_onContentResume;
			public unsafe void OnContentResume ()
			{
				if (id_onContentResume == IntPtr.Zero)
					id_onContentResume = JNIEnv.GetMethodID (class_ref, "onContentResume", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContentResume);
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			IntPtr id_describeContents;
			public unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
				var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
				__this.WriteToParcel (dest, flags);
			}
#pragma warning restore 0169

			IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.OnScipListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/PlayerView$OnScipListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IOnScipListenerInvoker")]
		public partial interface IOnScipListener : global::Android.OS.IParcelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.OnScipListener']/method[@name='onAdsSkip' and count(parameter)=0]"
			[Register ("onAdsSkip", "()V", "GetOnAdsSkipHandler:Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IOnScipListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnAdsSkip ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/PlayerView$OnScipListener", DoNotGenerateAcw=true)]
		internal partial class IOnScipListenerInvoker : global::Java.Lang.Object, IOnScipListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/PlayerView$OnScipListener", typeof (IOnScipListenerInvoker));

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

			public static IOnScipListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScipListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.PlayerView.OnScipListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScipListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAdsSkip;
#pragma warning disable 0169
			static Delegate GetOnAdsSkipHandler ()
			{
				if (cb_onAdsSkip == null)
					cb_onAdsSkip = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAdsSkip);
				return cb_onAdsSkip;
			}

			static void n_OnAdsSkip (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnScipListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAdsSkip ();
			}
#pragma warning restore 0169

			IntPtr id_onAdsSkip;
			public unsafe void OnAdsSkip ()
			{
				if (id_onAdsSkip == IntPtr.Zero)
					id_onAdsSkip = JNIEnv.GetMethodID (class_ref, "onAdsSkip", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdsSkip);
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnScipListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			IntPtr id_describeContents;
			public unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnScipListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
				var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
				__this.WriteToParcel (dest, flags);
			}
#pragma warning restore 0169

			IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.PlayerViewCallback']"
		[Register ("com/example/androidtvlibrary/main/adapter/PlayerView$PlayerViewCallback", "", "Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IPlayerViewCallbackInvoker")]
		public partial interface IPlayerViewCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.PlayerViewCallback']/method[@name='onTouchPlayerView' and count(parameter)=0]"
			[Register ("onTouchPlayerView", "()V", "GetOnTouchPlayerViewHandler:Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IPlayerViewCallbackInvoker, PausedAdsAndroidTV.Binding")]
			void OnTouchPlayerView ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/PlayerView$PlayerViewCallback", DoNotGenerateAcw=true)]
		internal partial class IPlayerViewCallbackInvoker : global::Java.Lang.Object, IPlayerViewCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/PlayerView$PlayerViewCallback", typeof (IPlayerViewCallbackInvoker));

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

			public static IPlayerViewCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPlayerViewCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.PlayerView.PlayerViewCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPlayerViewCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTouchPlayerView;
#pragma warning disable 0169
			static Delegate GetOnTouchPlayerViewHandler ()
			{
				if (cb_onTouchPlayerView == null)
					cb_onTouchPlayerView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTouchPlayerView);
				return cb_onTouchPlayerView;
			}

			static void n_OnTouchPlayerView (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IPlayerViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTouchPlayerView ();
			}
#pragma warning restore 0169

			IntPtr id_onTouchPlayerView;
			public unsafe void OnTouchPlayerView ()
			{
				if (id_onTouchPlayerView == IntPtr.Zero)
					id_onTouchPlayerView = JNIEnv.GetMethodID (class_ref, "onTouchPlayerView", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouchPlayerView);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='PlayerView.ShowBuffering']"
		[Register ("com/example/androidtvlibrary/main/adapter/PlayerView$ShowBuffering", "", "Com.Example.Androidtvlibrary.Main.Adapter.PlayerView/IShowBufferingInvoker")]
		public partial interface IShowBuffering : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/PlayerView$ShowBuffering", DoNotGenerateAcw=true)]
		internal partial class IShowBufferingInvoker : global::Java.Lang.Object, IShowBuffering {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/PlayerView$ShowBuffering", typeof (IShowBufferingInvoker));

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

			public static IShowBuffering GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IShowBuffering> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.PlayerView.ShowBuffering'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IShowBufferingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IShowBuffering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IShowBuffering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IShowBuffering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IShowBuffering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/PlayerView", typeof (PlayerView));

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

		protected PlayerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/constructor[@name='PlayerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PlayerView (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/constructor[@name='PlayerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PlayerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/constructor[@name='PlayerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PlayerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getAdViewGroup;
#pragma warning disable 0169
		static Delegate GetGetAdViewGroupHandler ()
		{
			if (cb_getAdViewGroup == null)
				cb_getAdViewGroup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdViewGroup);
			return cb_getAdViewGroup;
		}

		static IntPtr n_GetAdViewGroup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdViewGroup);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.ViewGroup AdViewGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getAdViewGroup' and count(parameter)=0]"
			[Register ("getAdViewGroup", "()Landroid/view/ViewGroup;", "GetGetAdViewGroupHandler")]
			get {
				const string __id = "getAdViewGroup.()Landroid/view/ViewGroup;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerAutoShow;
#pragma warning disable 0169
		static Delegate GetGetControllerAutoShowHandler ()
		{
			if (cb_getControllerAutoShow == null)
				cb_getControllerAutoShow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetControllerAutoShow);
			return cb_getControllerAutoShow;
		}

		static bool n_GetControllerAutoShow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerAutoShow;
		}
#pragma warning restore 0169

		static Delegate cb_setControllerAutoShow_Z;
#pragma warning disable 0169
		static Delegate GetSetControllerAutoShow_ZHandler ()
		{
			if (cb_setControllerAutoShow_Z == null)
				cb_setControllerAutoShow_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetControllerAutoShow_Z);
			return cb_setControllerAutoShow_Z;
		}

		static void n_SetControllerAutoShow_Z (IntPtr jnienv, IntPtr native__this, bool controllerAutoShow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ControllerAutoShow = controllerAutoShow;
		}
#pragma warning restore 0169

		public virtual unsafe bool ControllerAutoShow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getControllerAutoShow' and count(parameter)=0]"
			[Register ("getControllerAutoShow", "()Z", "GetGetControllerAutoShowHandler")]
			get {
				const string __id = "getControllerAutoShow.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setControllerAutoShow' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setControllerAutoShow", "(Z)V", "GetSetControllerAutoShow_ZHandler")]
			set {
				const string __id = "setControllerAutoShow.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerHideOnTouch;
#pragma warning disable 0169
		static Delegate GetGetControllerHideOnTouchHandler ()
		{
			if (cb_getControllerHideOnTouch == null)
				cb_getControllerHideOnTouch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetControllerHideOnTouch);
			return cb_getControllerHideOnTouch;
		}

		static bool n_GetControllerHideOnTouch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerHideOnTouch;
		}
#pragma warning restore 0169

		static Delegate cb_setControllerHideOnTouch_Z;
#pragma warning disable 0169
		static Delegate GetSetControllerHideOnTouch_ZHandler ()
		{
			if (cb_setControllerHideOnTouch_Z == null)
				cb_setControllerHideOnTouch_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetControllerHideOnTouch_Z);
			return cb_setControllerHideOnTouch_Z;
		}

		static void n_SetControllerHideOnTouch_Z (IntPtr jnienv, IntPtr native__this, bool controllerHideOnTouch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ControllerHideOnTouch = controllerHideOnTouch;
		}
#pragma warning restore 0169

		public virtual unsafe bool ControllerHideOnTouch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getControllerHideOnTouch' and count(parameter)=0]"
			[Register ("getControllerHideOnTouch", "()Z", "GetGetControllerHideOnTouchHandler")]
			get {
				const string __id = "getControllerHideOnTouch.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setControllerHideOnTouch' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setControllerHideOnTouch", "(Z)V", "GetSetControllerHideOnTouch_ZHandler")]
			set {
				const string __id = "setControllerHideOnTouch.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerShowTimeoutMs;
#pragma warning disable 0169
		static Delegate GetGetControllerShowTimeoutMsHandler ()
		{
			if (cb_getControllerShowTimeoutMs == null)
				cb_getControllerShowTimeoutMs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetControllerShowTimeoutMs);
			return cb_getControllerShowTimeoutMs;
		}

		static int n_GetControllerShowTimeoutMs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControllerShowTimeoutMs;
		}
#pragma warning restore 0169

		static Delegate cb_setControllerShowTimeoutMs_I;
#pragma warning disable 0169
		static Delegate GetSetControllerShowTimeoutMs_IHandler ()
		{
			if (cb_setControllerShowTimeoutMs_I == null)
				cb_setControllerShowTimeoutMs_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetControllerShowTimeoutMs_I);
			return cb_setControllerShowTimeoutMs_I;
		}

		static void n_SetControllerShowTimeoutMs_I (IntPtr jnienv, IntPtr native__this, int controllerShowTimeoutMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ControllerShowTimeoutMs = controllerShowTimeoutMs;
		}
#pragma warning restore 0169

		public virtual unsafe int ControllerShowTimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getControllerShowTimeoutMs' and count(parameter)=0]"
			[Register ("getControllerShowTimeoutMs", "()I", "GetGetControllerShowTimeoutMsHandler")]
			get {
				const string __id = "getControllerShowTimeoutMs.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setControllerShowTimeoutMs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setControllerShowTimeoutMs", "(I)V", "GetSetControllerShowTimeoutMs_IHandler")]
			set {
				const string __id = "setControllerShowTimeoutMs.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultArtwork;
#pragma warning disable 0169
		static Delegate GetGetDefaultArtworkHandler ()
		{
			if (cb_getDefaultArtwork == null)
				cb_getDefaultArtwork = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultArtwork);
			return cb_getDefaultArtwork;
		}

		static IntPtr n_GetDefaultArtwork (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultArtwork);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultArtwork_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDefaultArtwork_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDefaultArtwork_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDefaultArtwork_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDefaultArtwork_Landroid_graphics_drawable_Drawable_);
			return cb_setDefaultArtwork_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDefaultArtwork_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultArtwork)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var defaultArtwork = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_defaultArtwork, JniHandleOwnership.DoNotTransfer);
			__this.DefaultArtwork = defaultArtwork;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable DefaultArtwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getDefaultArtwork' and count(parameter)=0]"
			[Register ("getDefaultArtwork", "()Landroid/graphics/drawable/Drawable;", "GetGetDefaultArtworkHandler")]
			get {
				const string __id = "getDefaultArtwork.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setDefaultArtwork' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDefaultArtwork", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDefaultArtwork_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setDefaultArtwork.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isControllerVisible;
#pragma warning disable 0169
		static Delegate GetIsControllerVisibleHandler ()
		{
			if (cb_isControllerVisible == null)
				cb_isControllerVisible = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsControllerVisible);
			return cb_isControllerVisible;
		}

		static bool n_IsControllerVisible (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsControllerVisible;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsControllerVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='isControllerVisible' and count(parameter)=0]"
			[Register ("isControllerVisible", "()Z", "GetIsControllerVisibleHandler")]
			get {
				const string __id = "isControllerVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOverlayFrameLayout;
#pragma warning disable 0169
		static Delegate GetGetOverlayFrameLayoutHandler ()
		{
			if (cb_getOverlayFrameLayout == null)
				cb_getOverlayFrameLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOverlayFrameLayout);
			return cb_getOverlayFrameLayout;
		}

		static IntPtr n_GetOverlayFrameLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OverlayFrameLayout);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.FrameLayout OverlayFrameLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getOverlayFrameLayout' and count(parameter)=0]"
			[Register ("getOverlayFrameLayout", "()Landroid/widget/FrameLayout;", "GetGetOverlayFrameLayoutHandler")]
			get {
				const string __id = "getOverlayFrameLayout.()Landroid/widget/FrameLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlayer;
#pragma warning disable 0169
		static Delegate GetGetPlayerHandler ()
		{
			if (cb_getPlayer == null)
				cb_getPlayer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlayer);
			return cb_getPlayer;
		}

		static IntPtr n_GetPlayer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Player);
		}
#pragma warning restore 0169

		static Delegate cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_;
#pragma warning disable 0169
		static Delegate GetSetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Handler ()
		{
			if (cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ == null)
				cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_);
			return cb_setPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_;
		}

		static void n_SetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_player)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			__this.Player = player;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer Player {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getPlayer' and count(parameter)=0]"
			[Register ("getPlayer", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer;", "GetGetPlayerHandler")]
			get {
				const string __id = "getPlayer.()Lcom/example/androidtvlibrary/main/adapter/TestPlayer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setPlayer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer']]"
			[Register ("setPlayer", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;)V", "GetSetPlayer_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Handler")]
			set {
				const string __id = "setPlayer.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getResizeMode;
#pragma warning disable 0169
		static Delegate GetGetResizeModeHandler ()
		{
			if (cb_getResizeMode == null)
				cb_getResizeMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetResizeMode);
			return cb_getResizeMode;
		}

		static int n_GetResizeMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResizeMode;
		}
#pragma warning restore 0169

		static Delegate cb_setResizeMode_I;
#pragma warning disable 0169
		static Delegate GetSetResizeMode_IHandler ()
		{
			if (cb_setResizeMode_I == null)
				cb_setResizeMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetResizeMode_I);
			return cb_setResizeMode_I;
		}

		static void n_SetResizeMode_I (IntPtr jnienv, IntPtr native__this, int resizeMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResizeMode = resizeMode;
		}
#pragma warning restore 0169

		public virtual unsafe int ResizeMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getResizeMode' and count(parameter)=0]"
			[Register ("getResizeMode", "()I", "GetGetResizeModeHandler")]
			get {
				const string __id = "getResizeMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setResizeMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResizeMode", "(I)V", "GetSetResizeMode_IHandler")]
			set {
				const string __id = "setResizeMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUseArtwork;
#pragma warning disable 0169
		static Delegate GetGetUseArtworkHandler ()
		{
			if (cb_getUseArtwork == null)
				cb_getUseArtwork = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetUseArtwork);
			return cb_getUseArtwork;
		}

		static bool n_GetUseArtwork (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseArtwork;
		}
#pragma warning restore 0169

		static Delegate cb_setUseArtwork_Z;
#pragma warning disable 0169
		static Delegate GetSetUseArtwork_ZHandler ()
		{
			if (cb_setUseArtwork_Z == null)
				cb_setUseArtwork_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseArtwork_Z);
			return cb_setUseArtwork_Z;
		}

		static void n_SetUseArtwork_Z (IntPtr jnienv, IntPtr native__this, bool useArtwork)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseArtwork = useArtwork;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseArtwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getUseArtwork' and count(parameter)=0]"
			[Register ("getUseArtwork", "()Z", "GetGetUseArtworkHandler")]
			get {
				const string __id = "getUseArtwork.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setUseArtwork' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseArtwork", "(Z)V", "GetSetUseArtwork_ZHandler")]
			set {
				const string __id = "setUseArtwork.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUseController;
#pragma warning disable 0169
		static Delegate GetGetUseControllerHandler ()
		{
			if (cb_getUseController == null)
				cb_getUseController = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetUseController);
			return cb_getUseController;
		}

		static bool n_GetUseController (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseController;
		}
#pragma warning restore 0169

		static Delegate cb_setUseController_Z;
#pragma warning disable 0169
		static Delegate GetSetUseController_ZHandler ()
		{
			if (cb_setUseController_Z == null)
				cb_setUseController_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseController_Z);
			return cb_setUseController_Z;
		}

		static void n_SetUseController_Z (IntPtr jnienv, IntPtr native__this, bool useController)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseController = useController;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getUseController' and count(parameter)=0]"
			[Register ("getUseController", "()Z", "GetGetUseControllerHandler")]
			get {
				const string __id = "getUseController.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setUseController' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseController", "(Z)V", "GetSetUseController_ZHandler")]
			set {
				const string __id = "setUseController.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoSurfaceView;
#pragma warning disable 0169
		static Delegate GetGetVideoSurfaceViewHandler ()
		{
			if (cb_getVideoSurfaceView == null)
				cb_getVideoSurfaceView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoSurfaceView);
			return cb_getVideoSurfaceView;
		}

		static IntPtr n_GetVideoSurfaceView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoSurfaceView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View VideoSurfaceView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getVideoSurfaceView' and count(parameter)=0]"
			[Register ("getVideoSurfaceView", "()Landroid/view/View;", "GetGetVideoSurfaceViewHandler")]
			get {
				const string __id = "getVideoSurfaceView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_adAdsLoader_Z;
#pragma warning disable 0169
		static Delegate GetAdAdsLoader_ZHandler ()
		{
			if (cb_adAdsLoader_Z == null)
				cb_adAdsLoader_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_AdAdsLoader_Z);
			return cb_adAdsLoader_Z;
		}

		static void n_AdAdsLoader_Z (IntPtr jnienv, IntPtr native__this, bool skipped)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdAdsLoader (skipped);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='adAdsLoader' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("adAdsLoader", "(Z)V", "GetAdAdsLoader_ZHandler")]
		public virtual unsafe void AdAdsLoader (bool skipped)
		{
			const string __id = "adAdsLoader.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skipped);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_;
#pragma warning disable 0169
		static Delegate GetAddOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_Handler ()
		{
			if (cb_addOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_ == null)
				cb_addOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_);
			return cb_addOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_;
		}

		static void n_AddOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onActionListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onActionListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener> (native_onActionListener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnActionListener (onActionListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='addOnActionListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.PlayerView.OnActionListener']]"
		[Register ("addOnActionListener", "(Lcom/example/androidtvlibrary/main/adapter/PlayerView$OnActionListener;)V", "GetAddOnActionListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnActionListener_Handler")]
		public virtual unsafe void AddOnActionListener (global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnActionListener onActionListener)
		{
			const string __id = "addOnActionListener.(Lcom/example/androidtvlibrary/main/adapter/PlayerView$OnActionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onActionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onActionListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onActionListener);
			}
		}

		static Delegate cb_addOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_;
#pragma warning disable 0169
		static Delegate GetAddOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_Handler ()
		{
			if (cb_addOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_ == null)
				cb_addOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_);
			return cb_addOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_;
		}

		static void n_AddOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScipListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onScipListener = (global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnScipListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnScipListener> (native_onScipListener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnSkipListener (onScipListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='addOnSkipListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.PlayerView.OnScipListener']]"
		[Register ("addOnSkipListener", "(Lcom/example/androidtvlibrary/main/adapter/PlayerView$OnScipListener;)V", "GetAddOnSkipListener_Lcom_example_androidtvlibrary_main_adapter_PlayerView_OnScipListener_Handler")]
		public virtual unsafe void AddOnSkipListener (global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IOnScipListener onScipListener)
		{
			const string __id = "addOnSkipListener.(Lcom/example/androidtvlibrary/main/adapter/PlayerView$OnScipListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onScipListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onScipListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onScipListener);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAdsManager ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='closeAdsManager' and count(parameter)=0]"
		[Register ("closeAdsManager", "()V", "GetCloseAdsManagerHandler")]
		public virtual unsafe void CloseAdsManager ()
		{
			const string __id = "closeAdsManager.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dispatchMediaKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchMediaKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchMediaKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchMediaKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DispatchMediaKeyEvent_Landroid_view_KeyEvent_);
			return cb_dispatchMediaKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchMediaKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchMediaKeyEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='dispatchMediaKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchMediaKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchMediaKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool DispatchMediaKeyEvent (global::Android.Views.KeyEvent e)
		{
			const string __id = "dispatchMediaKeyEvent.(Landroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_getAdOverlayViews;
#pragma warning disable 0169
		static Delegate GetGetAdOverlayViewsHandler ()
		{
			if (cb_getAdOverlayViews == null)
				cb_getAdOverlayViews = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdOverlayViews);
			return cb_getAdOverlayViews;
		}

		static IntPtr n_GetAdOverlayViews (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAdOverlayViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='getAdOverlayViews' and count(parameter)=0]"
		[Register ("getAdOverlayViews", "()[Landroid/view/View;", "GetGetAdOverlayViewsHandler")]
		public virtual unsafe global::Android.Views.View[] GetAdOverlayViews ()
		{
			const string __id = "getAdOverlayViews.()[Landroid/view/View;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Android.Views.View[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.Views.View));
			} finally {
			}
		}

		static Delegate cb_hideController;
#pragma warning disable 0169
		static Delegate GetHideControllerHandler ()
		{
			if (cb_hideController == null)
				cb_hideController = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_HideController);
			return cb_hideController;
		}

		static void n_HideController (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideController ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='hideController' and count(parameter)=0]"
		[Register ("hideController", "()V", "GetHideControllerHandler")]
		public virtual unsafe void HideController ()
		{
			const string __id = "hideController.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_Handler ()
		{
			if (cb_onContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_ == null)
				cb_onContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFLL_V) n_OnContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_);
			return cb_onContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_;
		}

		static void n_OnContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, float contentAspectRatio, IntPtr native_contentFrame, IntPtr native_contentView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentFrame = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout> (native_contentFrame, JniHandleOwnership.DoNotTransfer);
			var contentView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_contentView, JniHandleOwnership.DoNotTransfer);
			__this.OnContentAspectRatioChanged (contentAspectRatio, contentFrame, contentView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='onContentAspectRatioChanged' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.AspectRatioFrameLayout'] and parameter[3][@type='android.view.View']]"
		[Register ("onContentAspectRatioChanged", "(FLcom/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout;Landroid/view/View;)V", "GetOnContentAspectRatioChanged_FLcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_Landroid_view_View_Handler")]
		protected virtual unsafe void OnContentAspectRatioChanged (float contentAspectRatio, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout contentFrame, global::Android.Views.View contentView)
		{
			const string __id = "onContentAspectRatioChanged.(FLcom/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout;Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (contentAspectRatio);
				__args [1] = new JniArgumentValue ((contentFrame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentFrame).Handle);
				__args [2] = new JniArgumentValue ((contentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (contentFrame);
				global::System.GC.KeepAlive (contentView);
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_;
#pragma warning disable 0169
		static Delegate GetSetAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_Handler ()
		{
			if (cb_setAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_ == null)
				cb_setAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_);
			return cb_setAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_;
		}

		static void n_SetAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetAspectRatioListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setAspectRatioListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AspectRatioFrameLayout.AspectRatioListener']]"
		[Register ("setAspectRatioListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener;)V", "GetSetAspectRatioListener_Lcom_example_androidtvlibrary_main_adapter_player_AspectRatioFrameLayout_AspectRatioListener_Handler")]
		public virtual unsafe void SetAspectRatioListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener listener)
		{
			const string __id = "setAspectRatioListener.(Lcom/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_;
#pragma warning disable 0169
		static Delegate GetSetControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_Handler ()
		{
			if (cb_setControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_ == null)
				cb_setControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_);
			return cb_setControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_;
		}

		static void n_SetControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controlDispatcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var controlDispatcher = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (native_controlDispatcher, JniHandleOwnership.DoNotTransfer);
			__this.SetControlDispatcher (controlDispatcher);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setControlDispatcher' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.ControlDispatcher']]"
		[Register ("setControlDispatcher", "(Lcom/example/androidtvlibrary/main/adapter/player/ControlDispatcher;)V", "GetSetControlDispatcher_Lcom_example_androidtvlibrary_main_adapter_player_ControlDispatcher_Handler")]
		public virtual unsafe void SetControlDispatcher (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher controlDispatcher)
		{
			const string __id = "setControlDispatcher.(Lcom/example/androidtvlibrary/main/adapter/player/ControlDispatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controlDispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controlDispatcher).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (controlDispatcher);
			}
		}

		static Delegate cb_setControllerHideDuringAds_Z;
#pragma warning disable 0169
		static Delegate GetSetControllerHideDuringAds_ZHandler ()
		{
			if (cb_setControllerHideDuringAds_Z == null)
				cb_setControllerHideDuringAds_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetControllerHideDuringAds_Z);
			return cb_setControllerHideDuringAds_Z;
		}

		static void n_SetControllerHideDuringAds_Z (IntPtr jnienv, IntPtr native__this, bool controllerHideDuringAds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerHideDuringAds (controllerHideDuringAds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setControllerHideDuringAds' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setControllerHideDuringAds", "(Z)V", "GetSetControllerHideDuringAds_ZHandler")]
		public virtual unsafe void SetControllerHideDuringAds (bool controllerHideDuringAds)
		{
			const string __id = "setControllerHideDuringAds.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (controllerHideDuringAds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_;
#pragma warning disable 0169
		static Delegate GetSetControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_Handler ()
		{
			if (cb_setControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ == null)
				cb_setControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_);
			return cb_setControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_;
		}

		static void n_SetControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerVisibilityListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setControllerVisibilityListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.PlayerControlView.VisibilityListener']]"
		[Register ("setControllerVisibilityListener", "(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener;)V", "GetSetControllerVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_Handler")]
		public virtual unsafe void SetControllerVisibilityListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener listener)
		{
			const string __id = "setControllerVisibilityListener.(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setCustomErrorMessage_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetCustomErrorMessage_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setCustomErrorMessage_Ljava_lang_CharSequence_ == null)
				cb_setCustomErrorMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCustomErrorMessage_Ljava_lang_CharSequence_);
			return cb_setCustomErrorMessage_Ljava_lang_CharSequence_;
		}

		static void n_SetCustomErrorMessage_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomErrorMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setCustomErrorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setCustomErrorMessage", "(Ljava/lang/CharSequence;)V", "GetSetCustomErrorMessage_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetCustomErrorMessage (global::Java.Lang.ICharSequence message)
		{
			const string __id = "setCustomErrorMessage.(Ljava/lang/CharSequence;)V";
			IntPtr native_message = CharSequence.ToLocalJniHandle (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (message);
			}
		}

		public void SetCustomErrorMessage (string message)
		{
			var jls_message = message == null ? null : new global::Java.Lang.String (message);
			SetCustomErrorMessage (jls_message);
			jls_message?.Dispose ();
		}

		static Delegate cb_setDefaultArtwork_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDefaultArtwork_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setDefaultArtwork_Landroid_graphics_Bitmap_ == null)
				cb_setDefaultArtwork_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDefaultArtwork_Landroid_graphics_Bitmap_);
			return cb_setDefaultArtwork_Landroid_graphics_Bitmap_;
		}

		[Obsolete]
		static void n_SetDefaultArtwork_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultArtwork)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var defaultArtwork = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_defaultArtwork, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultArtwork (defaultArtwork);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setDefaultArtwork' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Obsolete (@"deprecated")]
		[Register ("setDefaultArtwork", "(Landroid/graphics/Bitmap;)V", "GetSetDefaultArtwork_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetDefaultArtwork (global::Android.Graphics.Bitmap defaultArtwork)
		{
			const string __id = "setDefaultArtwork.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultArtwork == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultArtwork).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (defaultArtwork);
			}
		}

		static Delegate cb_setExtraAdGroupMarkers_arrayJarrayZ;
#pragma warning disable 0169
		static Delegate GetSetExtraAdGroupMarkers_arrayJarrayZHandler ()
		{
			if (cb_setExtraAdGroupMarkers_arrayJarrayZ == null)
				cb_setExtraAdGroupMarkers_arrayJarrayZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetExtraAdGroupMarkers_arrayJarrayZ);
			return cb_setExtraAdGroupMarkers_arrayJarrayZ;
		}

		static void n_SetExtraAdGroupMarkers_arrayJarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_extraAdGroupTimesMs, IntPtr native_extraPlayedAdGroups)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var extraAdGroupTimesMs = (long[]) JNIEnv.GetArray (native_extraAdGroupTimesMs, JniHandleOwnership.DoNotTransfer, typeof (long));
			var extraPlayedAdGroups = (bool[]) JNIEnv.GetArray (native_extraPlayedAdGroups, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.SetExtraAdGroupMarkers (extraAdGroupTimesMs, extraPlayedAdGroups);
			if (extraAdGroupTimesMs != null)
				JNIEnv.CopyArray (extraAdGroupTimesMs, native_extraAdGroupTimesMs);
			if (extraPlayedAdGroups != null)
				JNIEnv.CopyArray (extraPlayedAdGroups, native_extraPlayedAdGroups);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setExtraAdGroupMarkers' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='boolean[]']]"
		[Register ("setExtraAdGroupMarkers", "([J[Z)V", "GetSetExtraAdGroupMarkers_arrayJarrayZHandler")]
		public virtual unsafe void SetExtraAdGroupMarkers (long[] extraAdGroupTimesMs, bool[] extraPlayedAdGroups)
		{
			const string __id = "setExtraAdGroupMarkers.([J[Z)V";
			IntPtr native_extraAdGroupTimesMs = JNIEnv.NewArray (extraAdGroupTimesMs);
			IntPtr native_extraPlayedAdGroups = JNIEnv.NewArray (extraPlayedAdGroups);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_extraAdGroupTimesMs);
				__args [1] = new JniArgumentValue (native_extraPlayedAdGroups);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (extraAdGroupTimesMs != null) {
					JNIEnv.CopyArray (native_extraAdGroupTimesMs, extraAdGroupTimesMs);
					JNIEnv.DeleteLocalRef (native_extraAdGroupTimesMs);
				}
				if (extraPlayedAdGroups != null) {
					JNIEnv.CopyArray (native_extraPlayedAdGroups, extraPlayedAdGroups);
					JNIEnv.DeleteLocalRef (native_extraPlayedAdGroups);
				}
				global::System.GC.KeepAlive (extraAdGroupTimesMs);
				global::System.GC.KeepAlive (extraPlayedAdGroups);
			}
		}

		static Delegate cb_setFastForwardIncrementMs_I;
#pragma warning disable 0169
		static Delegate GetSetFastForwardIncrementMs_IHandler ()
		{
			if (cb_setFastForwardIncrementMs_I == null)
				cb_setFastForwardIncrementMs_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetFastForwardIncrementMs_I);
			return cb_setFastForwardIncrementMs_I;
		}

		static void n_SetFastForwardIncrementMs_I (IntPtr jnienv, IntPtr native__this, int fastForwardMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFastForwardIncrementMs (fastForwardMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setFastForwardIncrementMs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFastForwardIncrementMs", "(I)V", "GetSetFastForwardIncrementMs_IHandler")]
		public virtual unsafe void SetFastForwardIncrementMs (int fastForwardMs)
		{
			const string __id = "setFastForwardIncrementMs.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fastForwardMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setKeepContentOnPlayerReset_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepContentOnPlayerReset_ZHandler ()
		{
			if (cb_setKeepContentOnPlayerReset_Z == null)
				cb_setKeepContentOnPlayerReset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetKeepContentOnPlayerReset_Z);
			return cb_setKeepContentOnPlayerReset_Z;
		}

		static void n_SetKeepContentOnPlayerReset_Z (IntPtr jnienv, IntPtr native__this, bool keepContentOnPlayerReset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepContentOnPlayerReset (keepContentOnPlayerReset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setKeepContentOnPlayerReset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKeepContentOnPlayerReset", "(Z)V", "GetSetKeepContentOnPlayerReset_ZHandler")]
		public virtual unsafe void SetKeepContentOnPlayerReset (bool keepContentOnPlayerReset)
		{
			const string __id = "setKeepContentOnPlayerReset.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keepContentOnPlayerReset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_Handler ()
		{
			if (cb_setOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_ == null)
				cb_setOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_);
			return cb_setOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_;
		}

		static void n_SetOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onTouchCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onTouchCallback = (global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IPlayerViewCallback)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IPlayerViewCallback> (native_onTouchCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTouchCallback (onTouchCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setOnTouchCallback' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.PlayerView.PlayerViewCallback']]"
		[Register ("setOnTouchCallback", "(Lcom/example/androidtvlibrary/main/adapter/PlayerView$PlayerViewCallback;)V", "GetSetOnTouchCallback_Lcom_example_androidtvlibrary_main_adapter_PlayerView_PlayerViewCallback_Handler")]
		public virtual unsafe void SetOnTouchCallback (global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView.IPlayerViewCallback onTouchCallback)
		{
			const string __id = "setOnTouchCallback.(Lcom/example/androidtvlibrary/main/adapter/PlayerView$PlayerViewCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onTouchCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onTouchCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onTouchCallback);
			}
		}

		static Delegate cb_setPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_;
#pragma warning disable 0169
		static Delegate GetSetPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_Handler ()
		{
			if (cb_setPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_ == null)
				cb_setPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_);
			return cb_setPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_;
		}

		static void n_SetPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_playbackPreparer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var playbackPreparer = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparer> (native_playbackPreparer, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaybackPreparer (playbackPreparer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setPlaybackPreparer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.PlaybackPreparer']]"
		[Register ("setPlaybackPreparer", "(Lcom/example/androidtvlibrary/main/adapter/player/PlaybackPreparer;)V", "GetSetPlaybackPreparer_Lcom_example_androidtvlibrary_main_adapter_player_PlaybackPreparer_Handler")]
		public virtual unsafe void SetPlaybackPreparer (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparer playbackPreparer)
		{
			const string __id = "setPlaybackPreparer.(Lcom/example/androidtvlibrary/main/adapter/player/PlaybackPreparer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((playbackPreparer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackPreparer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (playbackPreparer);
			}
		}

		static Delegate cb_setPlayerData;
#pragma warning disable 0169
		static Delegate GetSetPlayerDataHandler ()
		{
			if (cb_setPlayerData == null)
				cb_setPlayerData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetPlayerData);
			return cb_setPlayerData;
		}

		static void n_SetPlayerData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayerData ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setPlayerData' and count(parameter)=0]"
		[Register ("setPlayerData", "()V", "GetSetPlayerDataHandler")]
		public virtual unsafe void SetPlayerData ()
		{
			const string __id = "setPlayerData.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setRepeatToggleModes_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatToggleModes_IHandler ()
		{
			if (cb_setRepeatToggleModes_I == null)
				cb_setRepeatToggleModes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRepeatToggleModes_I);
			return cb_setRepeatToggleModes_I;
		}

		static void n_SetRepeatToggleModes_I (IntPtr jnienv, IntPtr native__this, int repeatToggleModes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeatToggleModes (repeatToggleModes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setRepeatToggleModes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeatToggleModes", "(I)V", "GetSetRepeatToggleModes_IHandler")]
		public virtual unsafe void SetRepeatToggleModes ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.RepeatModeUtil", Fields = new string [] {"RepeatToggleModeNone", "RepeatToggleModeOne", "RepeatToggleModeAll"})]
		int repeatToggleModes)
		{
			const string __id = "setRepeatToggleModes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (repeatToggleModes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRewindIncrementMs_I;
#pragma warning disable 0169
		static Delegate GetSetRewindIncrementMs_IHandler ()
		{
			if (cb_setRewindIncrementMs_I == null)
				cb_setRewindIncrementMs_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRewindIncrementMs_I);
			return cb_setRewindIncrementMs_I;
		}

		static void n_SetRewindIncrementMs_I (IntPtr jnienv, IntPtr native__this, int rewindMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRewindIncrementMs (rewindMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setRewindIncrementMs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRewindIncrementMs", "(I)V", "GetSetRewindIncrementMs_IHandler")]
		public virtual unsafe void SetRewindIncrementMs (int rewindMs)
		{
			const string __id = "setRewindIncrementMs.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rewindMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowBuffering_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetShowBuffering_ZHandler ()
		{
			if (cb_setShowBuffering_Z == null)
				cb_setShowBuffering_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowBuffering_Z);
			return cb_setShowBuffering_Z;
		}

		[Obsolete]
		static void n_SetShowBuffering_Z (IntPtr jnienv, IntPtr native__this, bool showBuffering)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBuffering (showBuffering);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setShowBuffering' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setShowBuffering", "(Z)V", "GetSetShowBuffering_ZHandler")]
		public virtual unsafe void SetShowBuffering (bool showBuffering)
		{
			const string __id = "setShowBuffering.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showBuffering);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowBuffering_I;
#pragma warning disable 0169
		static Delegate GetSetShowBuffering_IHandler ()
		{
			if (cb_setShowBuffering_I == null)
				cb_setShowBuffering_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShowBuffering_I);
			return cb_setShowBuffering_I;
		}

		static void n_SetShowBuffering_I (IntPtr jnienv, IntPtr native__this, int showBuffering)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBuffering (showBuffering);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setShowBuffering' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShowBuffering", "(I)V", "GetSetShowBuffering_IHandler")]
		public virtual unsafe void SetShowBuffering ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.PlayerView", Fields = new string [] {"ShowBufferingNever", "ShowBufferingWhenPlaying", "ShowBufferingAlways"})]
		int showBuffering)
		{
			const string __id = "setShowBuffering.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showBuffering);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowMultiWindowTimeBar_Z;
#pragma warning disable 0169
		static Delegate GetSetShowMultiWindowTimeBar_ZHandler ()
		{
			if (cb_setShowMultiWindowTimeBar_Z == null)
				cb_setShowMultiWindowTimeBar_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowMultiWindowTimeBar_Z);
			return cb_setShowMultiWindowTimeBar_Z;
		}

		static void n_SetShowMultiWindowTimeBar_Z (IntPtr jnienv, IntPtr native__this, bool showMultiWindowTimeBar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowMultiWindowTimeBar (showMultiWindowTimeBar);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setShowMultiWindowTimeBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowMultiWindowTimeBar", "(Z)V", "GetSetShowMultiWindowTimeBar_ZHandler")]
		public virtual unsafe void SetShowMultiWindowTimeBar (bool showMultiWindowTimeBar)
		{
			const string __id = "setShowMultiWindowTimeBar.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showMultiWindowTimeBar);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowShuffleButton_Z;
#pragma warning disable 0169
		static Delegate GetSetShowShuffleButton_ZHandler ()
		{
			if (cb_setShowShuffleButton_Z == null)
				cb_setShowShuffleButton_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowShuffleButton_Z);
			return cb_setShowShuffleButton_Z;
		}

		static void n_SetShowShuffleButton_Z (IntPtr jnienv, IntPtr native__this, bool showShuffleButton)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowShuffleButton (showShuffleButton);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setShowShuffleButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowShuffleButton", "(Z)V", "GetSetShowShuffleButton_ZHandler")]
		public virtual unsafe void SetShowShuffleButton (bool showShuffleButton)
		{
			const string __id = "setShowShuffleButton.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showShuffleButton);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShutterBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetShutterBackgroundColor_IHandler ()
		{
			if (cb_setShutterBackgroundColor_I == null)
				cb_setShutterBackgroundColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShutterBackgroundColor_I);
			return cb_setShutterBackgroundColor_I;
		}

		static void n_SetShutterBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShutterBackgroundColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setShutterBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShutterBackgroundColor", "(I)V", "GetSetShutterBackgroundColor_IHandler")]
		public virtual unsafe void SetShutterBackgroundColor (int color)
		{
			const string __id = "setShutterBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUseSensorRotation_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSensorRotation_ZHandler ()
		{
			if (cb_setUseSensorRotation_Z == null)
				cb_setUseSensorRotation_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseSensorRotation_Z);
			return cb_setUseSensorRotation_Z;
		}

		static void n_SetUseSensorRotation_Z (IntPtr jnienv, IntPtr native__this, bool useSensorRotation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseSensorRotation (useSensorRotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='setUseSensorRotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseSensorRotation", "(Z)V", "GetSetUseSensorRotation_ZHandler")]
		public virtual unsafe void SetUseSensorRotation (bool useSensorRotation)
		{
			const string __id = "setUseSensorRotation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (useSensorRotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showController;
#pragma warning disable 0169
		static Delegate GetShowControllerHandler ()
		{
			if (cb_showController == null)
				cb_showController = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ShowController);
			return cb_showController;
		}

		static void n_ShowController (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowController ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='showController' and count(parameter)=0]"
		[Register ("showController", "()V", "GetShowControllerHandler")]
		public virtual unsafe void ShowController ()
		{
			const string __id = "showController.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='PlayerView']/method[@name='switchTargetView' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.PlayerView'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.PlayerView']]"
		[Register ("switchTargetView", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Lcom/example/androidtvlibrary/main/adapter/PlayerView;Lcom/example/androidtvlibrary/main/adapter/PlayerView;)V", "")]
		public static unsafe void SwitchTargetView (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player, global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView oldPlayerView, global::Com.Example.Androidtvlibrary.Main.Adapter.PlayerView newPlayerView)
		{
			const string __id = "switchTargetView.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Lcom/example/androidtvlibrary/main/adapter/PlayerView;Lcom/example/androidtvlibrary/main/adapter/PlayerView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				__args [1] = new JniArgumentValue ((oldPlayerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldPlayerView).Handle);
				__args [2] = new JniArgumentValue ((newPlayerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newPlayerView).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (player);
				global::System.GC.KeepAlive (oldPlayerView);
				global::System.GC.KeepAlive (newPlayerView);
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.AspectRatioEventArgs> AspectRatio {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor>(
				ref weak_implementor_SetAspectRatioListener,
				__CreateIAspectRatioListenerImplementor,
				SetAspectRatioListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor>(
				ref weak_implementor_SetAspectRatioListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor.__IsEmpty,
				__v => SetAspectRatioListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetAspectRatioListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor __CreateIAspectRatioListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.VisibilityEventArgs> ControllerVisibility {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor>(
				ref weak_implementor_SetControllerVisibilityListener,
				__CreateIVisibilityListenerImplementor,
				SetControllerVisibilityListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor>(
				ref weak_implementor_SetControllerVisibilityListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor.__IsEmpty,
				__v => SetControllerVisibilityListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetControllerVisibilityListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor __CreateIVisibilityListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor (this);
		}

		#endregion

	}
}
