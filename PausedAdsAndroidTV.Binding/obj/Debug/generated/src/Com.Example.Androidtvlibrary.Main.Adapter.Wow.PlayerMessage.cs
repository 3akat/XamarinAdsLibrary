using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage", DoNotGenerateAcw=true)]
	public sealed partial class PlayerMessage : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='PlayerMessage.Sender']"
		[Register ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Sender", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage/ISenderInvoker")]
		public partial interface ISender : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='PlayerMessage.Sender']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlayerMessage']]"
			[Register ("sendMessage", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;)V", "GetSendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage/ISenderInvoker, PausedAdsAndroidTV.Binding")]
			void SendMessage (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Sender", DoNotGenerateAcw=true)]
		internal partial class ISenderInvoker : global::Java.Lang.Object, ISender {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Sender", typeof (ISenderInvoker));

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

			public static ISender GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISender> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.PlayerMessage.Sender'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_;
#pragma warning disable 0169
			static Delegate GetSendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_Handler ()
			{
				if (cb_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_ == null)
					cb_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_);
				return cb_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_;
			}

			static void n_SendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ISender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SendMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_;
			public unsafe void SendMessage (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage p0)
			{
				if (id_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_ == IntPtr.Zero)
					id_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_example_androidtvlibrary_main_adapter_wow_PlayerMessage_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='PlayerMessage.Target']"
		[Register ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage/ITargetInvoker")]
		public partial interface ITarget : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='PlayerMessage.Target']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
			[Register ("handleMessage", "(ILjava/lang/Object;)V", "GetHandleMessage_ILjava_lang_Object_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage/ITargetInvoker, PausedAdsAndroidTV.Binding")]
			void HandleMessage (int p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target", DoNotGenerateAcw=true)]
		internal partial class ITargetInvoker : global::Java.Lang.Object, ITarget {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target", typeof (ITargetInvoker));

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

			public static ITarget GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITarget> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.PlayerMessage.Target'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITargetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_handleMessage_ILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetHandleMessage_ILjava_lang_Object_Handler ()
			{
				if (cb_handleMessage_ILjava_lang_Object_ == null)
					cb_handleMessage_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_HandleMessage_ILjava_lang_Object_);
				return cb_handleMessage_ILjava_lang_Object_;
			}

			static void n_HandleMessage_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.HandleMessage (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_handleMessage_ILjava_lang_Object_;
			public unsafe void HandleMessage (int p0, global::Java.Lang.Object p1)
			{
				if (id_handleMessage_ILjava_lang_Object_ == IntPtr.Zero)
					id_handleMessage_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(ILjava/lang/Object;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleMessage_ILjava_lang_Object_, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/PlayerMessage", typeof (PlayerMessage));

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

		internal PlayerMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/constructor[@name='PlayerMessage' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.PlayerMessage.Sender'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.PlayerMessage.Target'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Timeline'] and parameter[4][@type='int'] and parameter[5][@type='android.os.Handler']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Sender;Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target;Lcom/example/androidtvlibrary/main/adapter/Timeline;ILandroid/os/Handler;)V", "")]
		public unsafe PlayerMessage (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ISender sender, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget target, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline, int defaultWindowIndex, global::Android.OS.Handler defaultHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Sender;Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target;Lcom/example/androidtvlibrary/main/adapter/Timeline;ILandroid/os/Handler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((sender == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sender).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				__args [3] = new JniArgumentValue (defaultWindowIndex);
				__args [4] = new JniArgumentValue ((defaultHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sender);
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (timeline);
				global::System.GC.KeepAlive (defaultHandler);
			}
		}

		public unsafe bool DeleteAfterDelivery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getDeleteAfterDelivery' and count(parameter)=0]"
			[Register ("getDeleteAfterDelivery", "()Z", "")]
			get {
				const string __id = "getDeleteAfterDelivery.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "")]
			get {
				const string __id = "getHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object Payload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getPayload' and count(parameter)=0]"
			[Register ("getPayload", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getPayload.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long PositionMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getPositionMs' and count(parameter)=0]"
			[Register ("getPositionMs", "()J", "")]
			get {
				const string __id = "getPositionMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target;", "")]
			get {
				const string __id = "getTarget.()Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage$Target;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline Timeline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getTimeline' and count(parameter)=0]"
			[Register ("getTimeline", "()Lcom/example/androidtvlibrary/main/adapter/Timeline;", "")]
			get {
				const string __id = "getTimeline.()Lcom/example/androidtvlibrary/main/adapter/Timeline;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int WindowIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='getWindowIndex' and count(parameter)=0]"
			[Register ("getWindowIndex", "()I", "")]
			get {
				const string __id = "getWindowIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='blockUntilDelivered' and count(parameter)=0]"
		[Register ("blockUntilDelivered", "()Z", "")]
		public unsafe bool BlockUntilDelivered ()
		{
			const string __id = "blockUntilDelivered.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage Cancel ()
		{
			const string __id = "cancel.()Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='markAsProcessed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("markAsProcessed", "(Z)V", "")]
		public unsafe void MarkAsProcessed (bool isDelivered)
		{
			const string __id = "markAsProcessed.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isDelivered);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage Send ()
		{
			const string __id = "send.()Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='setDeleteAfterDelivery' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDeleteAfterDelivery", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage SetDeleteAfterDelivery (bool deleteAfterDelivery)
		{
			const string __id = "setDeleteAfterDelivery.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (deleteAfterDelivery);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setHandler", "(Landroid/os/Handler;)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage SetHandler (global::Android.OS.Handler handler)
		{
			const string __id = "setHandler.(Landroid/os/Handler;)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setPayload", "(Ljava/lang/Object;)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage SetPayload (global::Java.Lang.Object payload)
		{
			const string __id = "setPayload.(Ljava/lang/Object;)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((payload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) payload).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (payload);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='setPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("setPosition", "(IJ)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage SetPosition (int windowIndex, long positionMs)
		{
			const string __id = "setPosition.(IJ)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue (positionMs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setPosition", "(J)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage SetPosition (long positionMs)
		{
			const string __id = "setPosition.(J)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionMs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='PlayerMessage']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setType", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage SetType (int messageType)
		{
			const string __id = "setType.(I)Lcom/example/androidtvlibrary/main/adapter/wow/PlayerMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (messageType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
