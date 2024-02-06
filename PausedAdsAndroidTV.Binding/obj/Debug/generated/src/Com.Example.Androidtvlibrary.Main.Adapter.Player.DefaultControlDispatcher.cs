using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DefaultControlDispatcher", DoNotGenerateAcw=true)]
	public partial class DefaultControlDispatcher : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IControlDispatcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DefaultControlDispatcher", typeof (DefaultControlDispatcher));

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

		protected DefaultControlDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']/constructor[@name='DefaultControlDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultControlDispatcher () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ;
#pragma warning disable 0169
		static Delegate GetDispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJHandler ()
		{
			if (cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ == null)
				cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIJ_Z) n_DispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ);
			return cb_dispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ;
		}

		static bool n_DispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_player, int windowIndex, long positionMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSeekTo (player, windowIndex, positionMs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']/method[@name='dispatchSeekTo' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("dispatchSeekTo", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;IJ)Z", "GetDispatchSeekTo_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IJHandler")]
		public virtual unsafe bool DispatchSeekTo (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player, int windowIndex, long positionMs)
		{
			const string __id = "dispatchSeekTo.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;IJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				__args [1] = new JniArgumentValue (windowIndex);
				__args [2] = new JniArgumentValue (positionMs);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (player);
			}
		}

		static Delegate cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
#pragma warning disable 0169
		static Delegate GetDispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler ()
		{
			if (cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == null)
				cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_DispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z);
			return cb_dispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		}

		static bool n_DispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_player, bool playWhenReady)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSetPlayWhenReady (player, playWhenReady);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']/method[@name='dispatchSetPlayWhenReady' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='boolean']]"
		[Register ("dispatchSetPlayWhenReady", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z", "GetDispatchSetPlayWhenReady_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler")]
		public virtual unsafe bool DispatchSetPlayWhenReady (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player, bool playWhenReady)
		{
			const string __id = "dispatchSetPlayWhenReady.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				__args [1] = new JniArgumentValue (playWhenReady);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (player);
			}
		}

		static Delegate cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I;
#pragma warning disable 0169
		static Delegate GetDispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IHandler ()
		{
			if (cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I == null)
				cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_DispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I);
			return cb_dispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I;
		}

		static bool n_DispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_player, int repeatMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSetRepeatMode (player, repeatMode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']/method[@name='dispatchSetRepeatMode' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='int']]"
		[Register ("dispatchSetRepeatMode", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;I)Z", "GetDispatchSetRepeatMode_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_IHandler")]
		public virtual unsafe bool DispatchSetRepeatMode (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"RepeatModeOff", "RepeatModeOne", "RepeatModeAll"})]
		int repeatMode)
		{
			const string __id = "dispatchSetRepeatMode.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				__args [1] = new JniArgumentValue (repeatMode);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (player);
			}
		}

		static Delegate cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
#pragma warning disable 0169
		static Delegate GetDispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler ()
		{
			if (cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == null)
				cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_DispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z);
			return cb_dispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		}

		static bool n_DispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_player, bool shuffleModeEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchSetShuffleModeEnabled (player, shuffleModeEnabled);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']/method[@name='dispatchSetShuffleModeEnabled' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='boolean']]"
		[Register ("dispatchSetShuffleModeEnabled", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z", "GetDispatchSetShuffleModeEnabled_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler")]
		public virtual unsafe bool DispatchSetShuffleModeEnabled (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player, bool shuffleModeEnabled)
		{
			const string __id = "dispatchSetShuffleModeEnabled.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				__args [1] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (player);
			}
		}

		static Delegate cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
#pragma warning disable 0169
		static Delegate GetDispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler ()
		{
			if (cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z == null)
				cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_DispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z);
			return cb_dispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z;
		}

		static bool n_DispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_player, bool reset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DefaultControlDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var player = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer> (native_player, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchStop (player, reset);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DefaultControlDispatcher']/method[@name='dispatchStop' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer'] and parameter[2][@type='boolean']]"
		[Register ("dispatchStop", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z", "GetDispatchStop_Lcom_example_androidtvlibrary_main_adapter_TestPlayer_ZHandler")]
		public virtual unsafe bool DispatchStop (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player, bool reset)
		{
			const string __id = "dispatchStop.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				__args [1] = new JniArgumentValue (reset);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (player);
			}
		}

	}
}
