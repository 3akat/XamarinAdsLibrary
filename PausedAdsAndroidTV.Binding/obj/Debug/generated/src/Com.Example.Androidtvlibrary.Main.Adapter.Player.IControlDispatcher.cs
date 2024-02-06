using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='ControlDispatcher']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/ControlDispatcher", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcherInvoker")]
	public partial interface IControlDispatcher : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='ControlDispatcher']/method[@name='dispatchSeekTo' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("dispatchSeekTo", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;IJ)Z", "GetDispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcherInvoker, PausedAdsAndroidTV.Binding")]
		bool DispatchSeekTo (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, int p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='ControlDispatcher']/method[@name='dispatchSetPlayWhenReady' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='boolean']]"
		[Register ("dispatchSetPlayWhenReady", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z", "GetDispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcherInvoker, PausedAdsAndroidTV.Binding")]
		bool DispatchSetPlayWhenReady (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='ControlDispatcher']/method[@name='dispatchSetRepeatMode' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='int']]"
		[Register ("dispatchSetRepeatMode", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;I)Z", "GetDispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcherInvoker, PausedAdsAndroidTV.Binding")]
		bool DispatchSetRepeatMode (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"RepeatModeOff", "RepeatModeOne", "RepeatModeAll"})]
		int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='ControlDispatcher']/method[@name='dispatchSetShuffleModeEnabled' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='boolean']]"
		[Register ("dispatchSetShuffleModeEnabled", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z", "GetDispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcherInvoker, PausedAdsAndroidTV.Binding")]
		bool DispatchSetShuffleModeEnabled (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='ControlDispatcher']/method[@name='dispatchStop' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='boolean']]"
		[Register ("dispatchStop", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z", "GetDispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcherInvoker, PausedAdsAndroidTV.Binding")]
		bool DispatchStop (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/ControlDispatcher", DoNotGenerateAcw=true)]
	internal partial class IControlDispatcherInvoker : global::Java.Lang.Object, IControlDispatcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/ControlDispatcher", typeof (IControlDispatcherInvoker));

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

		public static IControlDispatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControlDispatcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.ControlDispatcher'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControlDispatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ;
#pragma warning disable 0169
		static Delegate GetDispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJHandler ()
		{
			if (cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ == null)
				cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJ_Z) n_DispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ);
			return cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ;
		}

		static bool n_DispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSeekTo (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ;
		public unsafe bool DispatchSeekTo (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, int p1, long p2)
		{
			if (id_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ == IntPtr.Zero)
				id_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ = JNIEnv.GetMethodID (class_ref, "dispatchSeekTo", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;IJ)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ, __args);
			return __ret;
		}

		static Delegate cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
#pragma warning disable 0169
		static Delegate GetDispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler ()
		{
			if (cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == null)
				cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_DispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z);
			return cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		}

		static bool n_DispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSetPlayWhenReady (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		public unsafe bool DispatchSetPlayWhenReady (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, bool p1)
		{
			if (id_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == IntPtr.Zero)
				id_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNIEnv.GetMethodID (class_ref, "dispatchSetPlayWhenReady", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z, __args);
			return __ret;
		}

		static Delegate cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I;
#pragma warning disable 0169
		static Delegate GetDispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IHandler ()
		{
			if (cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I == null)
				cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_DispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I);
			return cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I;
		}

		static bool n_DispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSetRepeatMode (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I;
		public unsafe bool DispatchSetRepeatMode (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"RepeatModeOff", "RepeatModeOne", "RepeatModeAll"})]
		int p1)
		{
			if (id_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I == IntPtr.Zero)
				id_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I = JNIEnv.GetMethodID (class_ref, "dispatchSetRepeatMode", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;I)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I, __args);
			return __ret;
		}

		static Delegate cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
#pragma warning disable 0169
		static Delegate GetDispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler ()
		{
			if (cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == null)
				cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_DispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z);
			return cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		}

		static bool n_DispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSetShuffleModeEnabled (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		public unsafe bool DispatchSetShuffleModeEnabled (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, bool p1)
		{
			if (id_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == IntPtr.Zero)
				id_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNIEnv.GetMethodID (class_ref, "dispatchSetShuffleModeEnabled", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z, __args);
			return __ret;
		}

		static Delegate cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
#pragma warning disable 0169
		static Delegate GetDispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler ()
		{
			if (cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == null)
				cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_DispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z);
			return cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		}

		static bool n_DispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchStop (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		public unsafe bool DispatchStop (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer p0, bool p1)
		{
			if (id_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == IntPtr.Zero)
				id_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNIEnv.GetMethodID (class_ref, "dispatchStop", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z, __args);
			return __ret;
		}

	}
}
