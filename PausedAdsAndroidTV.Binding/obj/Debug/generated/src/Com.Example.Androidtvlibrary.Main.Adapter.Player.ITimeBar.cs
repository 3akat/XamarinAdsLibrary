using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar.OnScrubListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListenerInvoker")]
	public partial interface ITimeBarOnScrubListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar.OnScrubListener']/method[@name='onScrubMove' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.TimeBar'] and parameter[2][@type='long']]"
		[Register ("onScrubMove", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar;J)V", "GetOnScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnScrubMove (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar.OnScrubListener']/method[@name='onScrubStart' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.TimeBar'] and parameter[2][@type='long']]"
		[Register ("onScrubStart", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar;J)V", "GetOnScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnScrubStart (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar.OnScrubListener']/method[@name='onScrubStop' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.TimeBar'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("onScrubStop", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar;JZ)V", "GetOnScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListenerInvoker, PausedAdsAndroidTV.Binding")]
		void OnScrubStop (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener", DoNotGenerateAcw=true)]
	internal partial class ITimeBarOnScrubListenerInvoker : global::Java.Lang.Object, ITimeBarOnScrubListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener", typeof (ITimeBarOnScrubListenerInvoker));

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

		public static ITimeBarOnScrubListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITimeBarOnScrubListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.TimeBar.OnScrubListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITimeBarOnScrubListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J;
#pragma warning disable 0169
		static Delegate GetOnScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JHandler ()
		{
			if (cb_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J == null)
				cb_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_OnScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J);
			return cb_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J;
		}

		static void n_OnScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrubMove (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J;
		public unsafe void OnScrubMove (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1)
		{
			if (id_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J == IntPtr.Zero)
				id_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J = JNIEnv.GetMethodID (class_ref, "onScrubMove", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrubMove_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J, __args);
		}

		static Delegate cb_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J;
#pragma warning disable 0169
		static Delegate GetOnScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JHandler ()
		{
			if (cb_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J == null)
				cb_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_OnScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J);
			return cb_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J;
		}

		static void n_OnScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrubStart (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J;
		public unsafe void OnScrubStart (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1)
		{
			if (id_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J == IntPtr.Zero)
				id_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J = JNIEnv.GetMethodID (class_ref, "onScrubStart", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrubStart_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_J, __args);
		}

		static Delegate cb_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ;
#pragma warning disable 0169
		static Delegate GetOnScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZHandler ()
		{
			if (cb_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ == null)
				cb_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJZ_V) n_OnScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ);
			return cb_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ;
		}

		static void n_OnScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrubStop (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ;
		public unsafe void OnScrubStop (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1, bool p2)
		{
			if (id_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ == IntPtr.Zero)
				id_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ = JNIEnv.GetMethodID (class_ref, "onScrubStop", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar;JZ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrubStop_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_JZ, __args);
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.player.TimeBar.OnScrubListener.onScrubMove
	public partial class ScrubMoveEventArgs : global::System.EventArgs {
		public ScrubMoveEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar P0 {
			get { return p0; }
		}

		long p1;

		public long P1 {
			get { return p1; }
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.player.TimeBar.OnScrubListener.onScrubStart
	public partial class ScrubStartEventArgs : global::System.EventArgs {
		public ScrubStartEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar P0 {
			get { return p0; }
		}

		long p1;

		public long P1 {
			get { return p1; }
		}

	}

	// event args for com.example.androidtvlibrary.main.adapter.player.TimeBar.OnScrubListener.onScrubStop
	public partial class ScrubStopEventArgs : global::System.EventArgs {
		public ScrubStopEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0;

		public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar P0 {
			get { return p0; }
		}

		long p1;

		public long P1 {
			get { return p1; }
		}

		bool p2;

		public bool P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/TimeBar_OnScrubListenerImplementor")]
	internal sealed partial class ITimeBarOnScrubListenerImplementor : global::Java.Lang.Object, ITimeBarOnScrubListener {

		object sender;

		public ITimeBarOnScrubListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/TimeBar_OnScrubListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ScrubMoveEventArgs> OnScrubMoveHandler;
		#pragma warning restore 0649

		public void OnScrubMove (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1)
		{
			var __h = OnScrubMoveHandler;
			if (__h != null)
				__h (sender, new ScrubMoveEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<ScrubStartEventArgs> OnScrubStartHandler;
		#pragma warning restore 0649

		public void OnScrubStart (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1)
		{
			var __h = OnScrubStartHandler;
			if (__h != null)
				__h (sender, new ScrubStartEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<ScrubStopEventArgs> OnScrubStopHandler;
		#pragma warning restore 0649

		public void OnScrubStop (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar p0, long p1, bool p2)
		{
			var __h = OnScrubStopHandler;
			if (__h != null)
				__h (sender, new ScrubStopEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ITimeBarOnScrubListenerImplementor value)
		{
			return value.OnScrubMoveHandler == null && value.OnScrubStartHandler == null && value.OnScrubStopHandler == null;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/TimeBar", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker")]
	public partial interface ITimeBar : IJavaObject, IJavaPeerable {
		long PreferredUpdateDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='getPreferredUpdateDelay' and count(parameter)=0]"
			[Register ("getPreferredUpdateDelay", "()J", "GetGetPreferredUpdateDelayHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.TimeBar.OnScrubListener']]"
		[Register ("addListener", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener;)V", "GetAddListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void AddListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.TimeBar.OnScrubListener']]"
		[Register ("removeListener", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener;)V", "GetRemoveListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setAdGroupTimesMs' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='boolean[]'] and parameter[3][@type='int']]"
		[Register ("setAdGroupTimesMs", "([J[ZI)V", "GetSetAdGroupTimesMs_arrayJarrayZIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetAdGroupTimesMs (long[] p0, bool[] p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setBufferedPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setBufferedPosition", "(J)V", "GetSetBufferedPosition_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetBufferedPosition (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)V", "GetSetDuration_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetDuration (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setKeyCountIncrement' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKeyCountIncrement", "(I)V", "GetSetKeyCountIncrement_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetKeyCountIncrement (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setKeyTimeIncrement' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setKeyTimeIncrement", "(J)V", "GetSetKeyTimeIncrement_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetKeyTimeIncrement (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='TimeBar']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setPosition", "(J)V", "GetSetPosition_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarInvoker, PausedAdsAndroidTV.Binding")]
		void SetPosition (long p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/TimeBar", DoNotGenerateAcw=true)]
	internal partial class ITimeBarInvoker : global::Java.Lang.Object, ITimeBar {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/TimeBar", typeof (ITimeBarInvoker));

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

		public static ITimeBar GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITimeBar> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.TimeBar'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITimeBarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPreferredUpdateDelay;
#pragma warning disable 0169
		static Delegate GetGetPreferredUpdateDelayHandler ()
		{
			if (cb_getPreferredUpdateDelay == null)
				cb_getPreferredUpdateDelay = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPreferredUpdateDelay);
			return cb_getPreferredUpdateDelay;
		}

		static long n_GetPreferredUpdateDelay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredUpdateDelay;
		}
#pragma warning restore 0169

		IntPtr id_getPreferredUpdateDelay;
		public unsafe long PreferredUpdateDelay {
			get {
				if (id_getPreferredUpdateDelay == IntPtr.Zero)
					id_getPreferredUpdateDelay = JNIEnv.GetMethodID (class_ref, "getPreferredUpdateDelay", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredUpdateDelay);
			}
		}

		static Delegate cb_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_Handler ()
		{
			if (cb_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ == null)
				cb_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_);
			return cb_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_;
		}

		static void n_AddListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_;
		public unsafe void AddListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener p0)
		{
			if (id_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ == IntPtr.Zero)
				id_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_, __args);
		}

		static Delegate cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_Handler ()
		{
			if (cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ == null)
				cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_);
			return cb_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_;
		}

		static void n_RemoveListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_;
		public unsafe void RemoveListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBarOnScrubListener p0)
		{
			if (id_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ == IntPtr.Zero)
				id_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/example/androidtvlibrary/main/adapter/player/TimeBar$OnScrubListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_example_androidtvlibrary_main_adapter_player_TimeBar_OnScrubListener_, __args);
		}

		static Delegate cb_setAdGroupTimesMs_arrayJarrayZI;
#pragma warning disable 0169
		static Delegate GetSetAdGroupTimesMs_arrayJarrayZIHandler ()
		{
			if (cb_setAdGroupTimesMs_arrayJarrayZI == null)
				cb_setAdGroupTimesMs_arrayJarrayZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_SetAdGroupTimesMs_arrayJarrayZI);
			return cb_setAdGroupTimesMs_arrayJarrayZI;
		}

		static void n_SetAdGroupTimesMs_arrayJarrayZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (long[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (long));
			var p1 = (bool[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.SetAdGroupTimesMs (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_setAdGroupTimesMs_arrayJarrayZI;
		public unsafe void SetAdGroupTimesMs (long[] p0, bool[] p1, int p2)
		{
			if (id_setAdGroupTimesMs_arrayJarrayZI == IntPtr.Zero)
				id_setAdGroupTimesMs_arrayJarrayZI = JNIEnv.GetMethodID (class_ref, "setAdGroupTimesMs", "([J[ZI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdGroupTimesMs_arrayJarrayZI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setBufferedPosition_J;
#pragma warning disable 0169
		static Delegate GetSetBufferedPosition_JHandler ()
		{
			if (cb_setBufferedPosition_J == null)
				cb_setBufferedPosition_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetBufferedPosition_J);
			return cb_setBufferedPosition_J;
		}

		static void n_SetBufferedPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBufferedPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBufferedPosition_J;
		public unsafe void SetBufferedPosition (long p0)
		{
			if (id_setBufferedPosition_J == IntPtr.Zero)
				id_setBufferedPosition_J = JNIEnv.GetMethodID (class_ref, "setBufferedPosition", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBufferedPosition_J, __args);
		}

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static void n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDuration_J;
		public unsafe void SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_J, __args);
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setEnabled_Z;
		public unsafe void SetEnabled (bool p0)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabled_Z, __args);
		}

		static Delegate cb_setKeyCountIncrement_I;
#pragma warning disable 0169
		static Delegate GetSetKeyCountIncrement_IHandler ()
		{
			if (cb_setKeyCountIncrement_I == null)
				cb_setKeyCountIncrement_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetKeyCountIncrement_I);
			return cb_setKeyCountIncrement_I;
		}

		static void n_SetKeyCountIncrement_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeyCountIncrement (p0);
		}
#pragma warning restore 0169

		IntPtr id_setKeyCountIncrement_I;
		public unsafe void SetKeyCountIncrement (int p0)
		{
			if (id_setKeyCountIncrement_I == IntPtr.Zero)
				id_setKeyCountIncrement_I = JNIEnv.GetMethodID (class_ref, "setKeyCountIncrement", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeyCountIncrement_I, __args);
		}

		static Delegate cb_setKeyTimeIncrement_J;
#pragma warning disable 0169
		static Delegate GetSetKeyTimeIncrement_JHandler ()
		{
			if (cb_setKeyTimeIncrement_J == null)
				cb_setKeyTimeIncrement_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetKeyTimeIncrement_J);
			return cb_setKeyTimeIncrement_J;
		}

		static void n_SetKeyTimeIncrement_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeyTimeIncrement (p0);
		}
#pragma warning restore 0169

		IntPtr id_setKeyTimeIncrement_J;
		public unsafe void SetKeyTimeIncrement (long p0)
		{
			if (id_setKeyTimeIncrement_J == IntPtr.Zero)
				id_setKeyTimeIncrement_J = JNIEnv.GetMethodID (class_ref, "setKeyTimeIncrement", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeyTimeIncrement_J, __args);
		}

		static Delegate cb_setPosition_J;
#pragma warning disable 0169
		static Delegate GetSetPosition_JHandler ()
		{
			if (cb_setPosition_J == null)
				cb_setPosition_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetPosition_J);
			return cb_setPosition_J;
		}

		static void n_SetPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.ITimeBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPosition_J;
		public unsafe void SetPosition (long p0)
		{
			if (id_setPosition_J == IntPtr.Zero)
				id_setPosition_J = JNIEnv.GetMethodID (class_ref, "setPosition", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_J, __args);
		}

	}
}
