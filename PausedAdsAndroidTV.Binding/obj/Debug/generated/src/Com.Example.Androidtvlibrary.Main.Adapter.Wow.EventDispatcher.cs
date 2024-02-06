using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EventDispatcher']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/EventDispatcher", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class EventDispatcher : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='EventDispatcher.Event']"
		[Register ("com/example/androidtvlibrary/main/adapter/wow/EventDispatcher$Event", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.EventDispatcher/IEventInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IEvent : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='EventDispatcher.Event']/method[@name='sendTo' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("sendTo", "(Ljava/lang/Object;)V", "GetSendTo_Ljava_lang_Object_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.EventDispatcher/IEventInvoker, PausedAdsAndroidTV.Binding")]
			void SendTo (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/EventDispatcher$Event", DoNotGenerateAcw=true)]
		internal partial class IEventInvoker : global::Java.Lang.Object, IEvent {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/EventDispatcher$Event", typeof (IEventInvoker));

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

			public static IEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEvent> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.EventDispatcher.Event'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_sendTo_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSendTo_Ljava_lang_Object_Handler ()
			{
				if (cb_sendTo_Ljava_lang_Object_ == null)
					cb_sendTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendTo_Ljava_lang_Object_);
				return cb_sendTo_Ljava_lang_Object_;
			}

			static void n_SendTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.EventDispatcher.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SendTo (p0);
			}
#pragma warning restore 0169

			IntPtr id_sendTo_Ljava_lang_Object_;
			public unsafe void SendTo (global::Java.Lang.Object p0)
			{
				if (id_sendTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_sendTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sendTo", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendTo_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/EventDispatcher", typeof (EventDispatcher));

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

		internal EventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EventDispatcher']/constructor[@name='EventDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventDispatcher () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EventDispatcher']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='T']]"
		[Register ("addListener", "(Landroid/os/Handler;Ljava/lang/Object;)V", "")]
		public unsafe void AddListener (global::Android.OS.Handler handler, global::Java.Lang.Object eventListener)
		{
			const string __id = "addListener.(Landroid/os/Handler;Ljava/lang/Object;)V";
			IntPtr native_eventListener = JNIEnv.ToLocalJniHandle (eventListener);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue (native_eventListener);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventListener);
				global::System.GC.KeepAlive (handler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EventDispatcher']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.EventDispatcher.Event&lt;T&gt;']]"
		[Register ("dispatch", "(Lcom/example/androidtvlibrary/main/adapter/wow/EventDispatcher$Event;)V", "")]
		public unsafe void Dispatch (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.EventDispatcher.IEvent e)
		{
			const string __id = "dispatch.(Lcom/example/androidtvlibrary/main/adapter/wow/EventDispatcher$Event;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='EventDispatcher']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("removeListener", "(Ljava/lang/Object;)V", "")]
		public unsafe void RemoveListener (global::Java.Lang.Object eventListener)
		{
			const string __id = "removeListener.(Ljava/lang/Object;)V";
			IntPtr native_eventListener = JNIEnv.ToLocalJniHandle (eventListener);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventListener);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventListener);
				global::System.GC.KeepAlive (eventListener);
			}
		}

	}
}
