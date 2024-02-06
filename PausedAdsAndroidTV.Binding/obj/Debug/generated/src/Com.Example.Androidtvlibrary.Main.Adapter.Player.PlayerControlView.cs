using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView", DoNotGenerateAcw=true)]
	public partial class PlayerControlView : global::Android.Widget.FrameLayout {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/field[@name='DEFAULT_FAST_FORWARD_MS']"
		[Register ("DEFAULT_FAST_FORWARD_MS")]
		public const int DefaultFastForwardMs = (int) 15000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/field[@name='DEFAULT_REPEAT_TOGGLE_MODES']"
		[Register ("DEFAULT_REPEAT_TOGGLE_MODES")]
		[global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Player.RepeatModeUtil", Fields = new string [] {"RepeatToggleModeNone", "RepeatToggleModeOne", "RepeatToggleModeAll"})]
		public const int DefaultRepeatToggleModes = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/field[@name='DEFAULT_REWIND_MS']"
		[Register ("DEFAULT_REWIND_MS")]
		public const int DefaultRewindMs = (int) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/field[@name='DEFAULT_SHOW_TIMEOUT_MS']"
		[Register ("DEFAULT_SHOW_TIMEOUT_MS")]
		public const int DefaultShowTimeoutMs = (int) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/field[@name='DEFAULT_TIME_BAR_MIN_UPDATE_INTERVAL_MS']"
		[Register ("DEFAULT_TIME_BAR_MIN_UPDATE_INTERVAL_MS")]
		public const int DefaultTimeBarMinUpdateIntervalMs = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/field[@name='MAX_WINDOWS_FOR_MULTI_WINDOW_TIME_BAR']"
		[Register ("MAX_WINDOWS_FOR_MULTI_WINDOW_TIME_BAR")]
		public const int MaxWindowsForMultiWindowTimeBar = (int) 100;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='PlayerControlView.ProgressUpdateListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView$ProgressUpdateListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView/IProgressUpdateListenerInvoker")]
		public partial interface IProgressUpdateListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='PlayerControlView.ProgressUpdateListener']/method[@name='onProgressUpdate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("onProgressUpdate", "(JJ)V", "GetOnProgressUpdate_JJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView/IProgressUpdateListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnProgressUpdate (long p0, long p1);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView$ProgressUpdateListener", DoNotGenerateAcw=true)]
		internal partial class IProgressUpdateListenerInvoker : global::Java.Lang.Object, IProgressUpdateListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView$ProgressUpdateListener", typeof (IProgressUpdateListenerInvoker));

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

			public static IProgressUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.PlayerControlView.ProgressUpdateListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProgressUpdate_JJ;
#pragma warning disable 0169
			static Delegate GetOnProgressUpdate_JJHandler ()
			{
				if (cb_onProgressUpdate_JJ == null)
					cb_onProgressUpdate_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_OnProgressUpdate_JJ);
				return cb_onProgressUpdate_JJ;
			}

			static void n_OnProgressUpdate_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressUpdate (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onProgressUpdate_JJ;
			public unsafe void OnProgressUpdate (long p0, long p1)
			{
				if (id_onProgressUpdate_JJ == IntPtr.Zero)
					id_onProgressUpdate_JJ = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(JJ)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressUpdate_JJ, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.player.PlayerControlView.ProgressUpdateListener.onProgressUpdate
		public partial class ProgressUpdateEventArgs : global::System.EventArgs {
			public ProgressUpdateEventArgs (long p0, long p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			long p0;

			public long P0 {
				get { return p0; }
			}

			long p1;

			public long P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/PlayerControlView_ProgressUpdateListenerImplementor")]
		internal sealed partial class IProgressUpdateListenerImplementor : global::Java.Lang.Object, IProgressUpdateListener {

			object sender;

			public IProgressUpdateListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/PlayerControlView_ProgressUpdateListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<ProgressUpdateEventArgs> Handler;
			#pragma warning restore 0649

			public void OnProgressUpdate (long p0, long p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ProgressUpdateEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IProgressUpdateListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='PlayerControlView.VisibilityListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView/IVisibilityListenerInvoker")]
		public partial interface IVisibilityListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='PlayerControlView.VisibilityListener']/method[@name='onVisibilityChange' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onVisibilityChange", "(I)V", "GetOnVisibilityChange_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView/IVisibilityListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnVisibilityChange (int p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener", DoNotGenerateAcw=true)]
		internal partial class IVisibilityListenerInvoker : global::Java.Lang.Object, IVisibilityListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener", typeof (IVisibilityListenerInvoker));

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

			public static IVisibilityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVisibilityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.PlayerControlView.VisibilityListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVisibilityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onVisibilityChange_I;
#pragma warning disable 0169
			static Delegate GetOnVisibilityChange_IHandler ()
			{
				if (cb_onVisibilityChange_I == null)
					cb_onVisibilityChange_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnVisibilityChange_I);
				return cb_onVisibilityChange_I;
			}

			static void n_OnVisibilityChange_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnVisibilityChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onVisibilityChange_I;
			public unsafe void OnVisibilityChange (int p0)
			{
				if (id_onVisibilityChange_I == IntPtr.Zero)
					id_onVisibilityChange_I = JNIEnv.GetMethodID (class_ref, "onVisibilityChange", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVisibilityChange_I, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.player.PlayerControlView.VisibilityListener.onVisibilityChange
		public partial class VisibilityEventArgs : global::System.EventArgs {
			public VisibilityEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;

			public int P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/PlayerControlView_VisibilityListenerImplementor")]
		internal sealed partial class IVisibilityListenerImplementor : global::Java.Lang.Object, IVisibilityListener {

			object sender;

			public IVisibilityListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/PlayerControlView_VisibilityListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<VisibilityEventArgs> Handler;
			#pragma warning restore 0649

			public void OnVisibilityChange (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VisibilityEventArgs (p0));
			}

			internal static bool __IsEmpty (IVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/PlayerControlView", typeof (PlayerControlView));

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

		protected PlayerControlView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/constructor[@name='PlayerControlView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PlayerControlView (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/constructor[@name='PlayerControlView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PlayerControlView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/constructor[@name='PlayerControlView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PlayerControlView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/constructor[@name='PlayerControlView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/util/AttributeSet;)V", "")]
		public unsafe PlayerControlView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, global::Android.Util.IAttributeSet playbackAttrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue ((playbackAttrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackAttrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
				global::System.GC.KeepAlive (playbackAttrs);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVisible;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			__this.Player = player;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer Player {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='getPlayer' and count(parameter)=0]"
			[Register ("getPlayer", "()Lcom/example/androidtvlibrary/main/adapter/TestPlayer;", "GetGetPlayerHandler")]
			get {
				const string __id = "getPlayer.()Lcom/example/androidtvlibrary/main/adapter/TestPlayer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setPlayer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer']]"
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

		static Delegate cb_getRepeatToggleModes;
#pragma warning disable 0169
		static Delegate GetGetRepeatToggleModesHandler ()
		{
			if (cb_getRepeatToggleModes == null)
				cb_getRepeatToggleModes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRepeatToggleModes);
			return cb_getRepeatToggleModes;
		}

		static int n_GetRepeatToggleModes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatToggleModes;
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RepeatToggleModes = repeatToggleModes;
		}
#pragma warning restore 0169

		public virtual unsafe int RepeatToggleModes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='getRepeatToggleModes' and count(parameter)=0]"
			[Register ("getRepeatToggleModes", "()I", "GetGetRepeatToggleModesHandler")]
			get {
				const string __id = "getRepeatToggleModes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setRepeatToggleModes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRepeatToggleModes", "(I)V", "GetSetRepeatToggleModes_IHandler")]
			set {
				const string __id = "setRepeatToggleModes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowShuffleButton;
#pragma warning disable 0169
		static Delegate GetGetShowShuffleButtonHandler ()
		{
			if (cb_getShowShuffleButton == null)
				cb_getShowShuffleButton = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetShowShuffleButton);
			return cb_getShowShuffleButton;
		}

		static bool n_GetShowShuffleButton (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowShuffleButton;
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowShuffleButton = showShuffleButton;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowShuffleButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='getShowShuffleButton' and count(parameter)=0]"
			[Register ("getShowShuffleButton", "()Z", "GetGetShowShuffleButtonHandler")]
			get {
				const string __id = "getShowShuffleButton.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setShowShuffleButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowShuffleButton", "(Z)V", "GetSetShowShuffleButton_ZHandler")]
			set {
				const string __id = "setShowShuffleButton.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowTimeoutMs;
#pragma warning disable 0169
		static Delegate GetGetShowTimeoutMsHandler ()
		{
			if (cb_getShowTimeoutMs == null)
				cb_getShowTimeoutMs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShowTimeoutMs);
			return cb_getShowTimeoutMs;
		}

		static int n_GetShowTimeoutMs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowTimeoutMs;
		}
#pragma warning restore 0169

		static Delegate cb_setShowTimeoutMs_I;
#pragma warning disable 0169
		static Delegate GetSetShowTimeoutMs_IHandler ()
		{
			if (cb_setShowTimeoutMs_I == null)
				cb_setShowTimeoutMs_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShowTimeoutMs_I);
			return cb_setShowTimeoutMs_I;
		}

		static void n_SetShowTimeoutMs_I (IntPtr jnienv, IntPtr native__this, int showTimeoutMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTimeoutMs = showTimeoutMs;
		}
#pragma warning restore 0169

		public virtual unsafe int ShowTimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='getShowTimeoutMs' and count(parameter)=0]"
			[Register ("getShowTimeoutMs", "()I", "GetGetShowTimeoutMsHandler")]
			get {
				const string __id = "getShowTimeoutMs.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setShowTimeoutMs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShowTimeoutMs", "(I)V", "GetSetShowTimeoutMs_IHandler")]
			set {
				const string __id = "setShowTimeoutMs.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowVrButton;
#pragma warning disable 0169
		static Delegate GetGetShowVrButtonHandler ()
		{
			if (cb_getShowVrButton == null)
				cb_getShowVrButton = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetShowVrButton);
			return cb_getShowVrButton;
		}

		static bool n_GetShowVrButton (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowVrButton;
		}
#pragma warning restore 0169

		static Delegate cb_setShowVrButton_Z;
#pragma warning disable 0169
		static Delegate GetSetShowVrButton_ZHandler ()
		{
			if (cb_setShowVrButton_Z == null)
				cb_setShowVrButton_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowVrButton_Z);
			return cb_setShowVrButton_Z;
		}

		static void n_SetShowVrButton_Z (IntPtr jnienv, IntPtr native__this, bool showVrButton)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVrButton = showVrButton;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowVrButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='getShowVrButton' and count(parameter)=0]"
			[Register ("getShowVrButton", "()Z", "GetGetShowVrButtonHandler")]
			get {
				const string __id = "getShowVrButton.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setShowVrButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowVrButton", "(Z)V", "GetSetShowVrButton_ZHandler")]
			set {
				const string __id = "setShowVrButton.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_;
#pragma warning disable 0169
		static Delegate GetAddVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_Handler ()
		{
			if (cb_addVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ == null)
				cb_addVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_);
			return cb_addVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_;
		}

		static void n_AddVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddVisibilityListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='addVisibilityListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.PlayerControlView.VisibilityListener']]"
		[Register ("addVisibilityListener", "(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener;)V", "GetAddVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_Handler")]
		public virtual unsafe void AddVisibilityListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener listener)
		{
			const string __id = "addVisibilityListener.(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchMediaKeyEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='dispatchMediaKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='dispatchTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", "")]
		public override sealed unsafe bool DispatchTouchEvent (global::Android.Views.MotionEvent ev)
		{
			const string __id = "dispatchTouchEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ev == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ev).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (ev);
			}
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public virtual unsafe void Hide ()
		{
			const string __id = "hide.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onAttachedToWindow;
#pragma warning disable 0169
		static Delegate GetOnAttachedToWindowHandler ()
		{
			if (cb_onAttachedToWindow == null)
				cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAttachedToWindow);
			return cb_onAttachedToWindow;
		}

		static void n_OnAttachedToWindow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttachedToWindow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='onAttachedToWindow' and count(parameter)=0]"
		[Register ("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler")]
		public virtual unsafe void OnAttachedToWindow ()
		{
			const string __id = "onAttachedToWindow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDetachedFromWindow;
#pragma warning disable 0169
		static Delegate GetOnDetachedFromWindowHandler ()
		{
			if (cb_onDetachedFromWindow == null)
				cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDetachedFromWindow);
			return cb_onDetachedFromWindow;
		}

		static void n_OnDetachedFromWindow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetachedFromWindow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public virtual unsafe void OnDetachedFromWindow ()
		{
			const string __id = "onDetachedFromWindow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_;
#pragma warning disable 0169
		static Delegate GetRemoveVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_Handler ()
		{
			if (cb_removeVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ == null)
				cb_removeVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_);
			return cb_removeVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_;
		}

		static void n_RemoveVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveVisibilityListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='removeVisibilityListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.PlayerControlView.VisibilityListener']]"
		[Register ("removeVisibilityListener", "(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener;)V", "GetRemoveVisibilityListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_VisibilityListener_Handler")]
		public virtual unsafe void RemoveVisibilityListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener listener)
		{
			const string __id = "removeVisibilityListener.(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$VisibilityListener;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var controlDispatcher = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (native_controlDispatcher, JniHandleOwnership.DoNotTransfer);
			__this.SetControlDispatcher (controlDispatcher);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setControlDispatcher' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.ControlDispatcher']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var extraAdGroupTimesMs = (long[]) JNIEnv.GetArray (native_extraAdGroupTimesMs, JniHandleOwnership.DoNotTransfer, typeof (long));
			var extraPlayedAdGroups = (bool[]) JNIEnv.GetArray (native_extraPlayedAdGroups, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.SetExtraAdGroupMarkers (extraAdGroupTimesMs, extraPlayedAdGroups);
			if (extraAdGroupTimesMs != null)
				JNIEnv.CopyArray (extraAdGroupTimesMs, native_extraAdGroupTimesMs);
			if (extraPlayedAdGroups != null)
				JNIEnv.CopyArray (extraPlayedAdGroups, native_extraPlayedAdGroups);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setExtraAdGroupMarkers' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='boolean[]']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFastForwardIncrementMs (fastForwardMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setFastForwardIncrementMs' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var playbackPreparer = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IPlaybackPreparer> (native_playbackPreparer, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaybackPreparer (playbackPreparer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setPlaybackPreparer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.PlaybackPreparer']]"
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

		static Delegate cb_setProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_Handler ()
		{
			if (cb_setProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_ == null)
				cb_setProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_);
			return cb_setProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_;
		}

		static void n_SetProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressUpdateListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setProgressUpdateListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.PlayerControlView.ProgressUpdateListener']]"
		[Register ("setProgressUpdateListener", "(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$ProgressUpdateListener;)V", "GetSetProgressUpdateListener_Lcom_example_androidtvlibrary_main_adapter_player_PlayerControlView_ProgressUpdateListener_Handler")]
		public virtual unsafe void SetProgressUpdateListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener listener)
		{
			const string __id = "setProgressUpdateListener.(Lcom/example/androidtvlibrary/main/adapter/player/PlayerControlView$ProgressUpdateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRewindIncrementMs (rewindMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setRewindIncrementMs' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowMultiWindowTimeBar (showMultiWindowTimeBar);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setShowMultiWindowTimeBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setTimeBarMinUpdateInterval_I;
#pragma warning disable 0169
		static Delegate GetSetTimeBarMinUpdateInterval_IHandler ()
		{
			if (cb_setTimeBarMinUpdateInterval_I == null)
				cb_setTimeBarMinUpdateInterval_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeBarMinUpdateInterval_I);
			return cb_setTimeBarMinUpdateInterval_I;
		}

		static void n_SetTimeBarMinUpdateInterval_I (IntPtr jnienv, IntPtr native__this, int minUpdateIntervalMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeBarMinUpdateInterval (minUpdateIntervalMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setTimeBarMinUpdateInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeBarMinUpdateInterval", "(I)V", "GetSetTimeBarMinUpdateInterval_IHandler")]
		public virtual unsafe void SetTimeBarMinUpdateInterval (int minUpdateIntervalMs)
		{
			const string __id = "setTimeBarMinUpdateInterval.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minUpdateIntervalMs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVrButtonListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetVrButtonListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setVrButtonListener_Landroid_view_View_OnClickListener_ == null)
				cb_setVrButtonListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVrButtonListener_Landroid_view_View_OnClickListener_);
			return cb_setVrButtonListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetVrButtonListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onClickListener = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetVrButtonListener (onClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='setVrButtonListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setVrButtonListener", "(Landroid/view/View$OnClickListener;)V", "GetSetVrButtonListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetVrButtonListener (global::Android.Views.View.IOnClickListener onClickListener)
		{
			const string __id = "setVrButtonListener.(Landroid/view/View$OnClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onClickListener);
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='PlayerControlView']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			const string __id = "show.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.VisibilityEventArgs> VisibilityEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor>(
				ref weak_implementor_AddVisibilityListener,
				__CreateIVisibilityListenerImplementor,
				AddVisibilityListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor>(
				ref weak_implementor_AddVisibilityListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor.__IsEmpty,
				__v => RemoveVisibilityListener (__v),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddVisibilityListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor __CreateIVisibilityListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IVisibilityListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.ProgressUpdateEventArgs> ProgressUpdate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListenerImplementor>(
				ref weak_implementor_SetProgressUpdateListener,
				__CreateIProgressUpdateListenerImplementor,
				SetProgressUpdateListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListenerImplementor>(
				ref weak_implementor_SetProgressUpdateListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListenerImplementor.__IsEmpty,
				__v => SetProgressUpdateListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetProgressUpdateListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListenerImplementor __CreateIProgressUpdateListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.PlayerControlView.IProgressUpdateListenerImplementor (this);
		}

		#endregion

	}
}
