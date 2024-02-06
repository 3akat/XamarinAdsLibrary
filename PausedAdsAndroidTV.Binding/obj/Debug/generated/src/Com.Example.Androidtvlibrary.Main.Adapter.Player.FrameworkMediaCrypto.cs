using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameworkMediaCrypto']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/FrameworkMediaCrypto", DoNotGenerateAcw=true)]
	public sealed partial class FrameworkMediaCrypto : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IExoMediaCrypto {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameworkMediaCrypto']/field[@name='forceAllowInsecureDecoderComponents']"
		[Register ("forceAllowInsecureDecoderComponents")]
		public bool ForceAllowInsecureDecoderComponents {
			get {
				const string __id = "forceAllowInsecureDecoderComponents.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "forceAllowInsecureDecoderComponents.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameworkMediaCrypto']/field[@name='sessionId']"
		[Register ("sessionId")]
		public IList<byte> SessionId {
			get {
				const string __id = "sessionId.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sessionId.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameworkMediaCrypto']/field[@name='uuid']"
		[Register ("uuid")]
		public global::Java.Util.UUID Uuid {
			get {
				const string __id = "uuid.Ljava/util/UUID;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uuid.Ljava/util/UUID;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameworkMediaCrypto']/field[@name='WORKAROUND_DEVICE_NEEDS_KEYS_TO_CONFIGURE_CODEC']"
		[Register ("WORKAROUND_DEVICE_NEEDS_KEYS_TO_CONFIGURE_CODEC")]
		public static bool WorkaroundDeviceNeedsKeysToConfigureCodec {
			get {
				const string __id = "WORKAROUND_DEVICE_NEEDS_KEYS_TO_CONFIGURE_CODEC.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/FrameworkMediaCrypto", typeof (FrameworkMediaCrypto));

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

		internal FrameworkMediaCrypto (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='FrameworkMediaCrypto']/constructor[@name='FrameworkMediaCrypto' and count(parameter)=3 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/UUID;[BZ)V", "")]
		public unsafe FrameworkMediaCrypto (global::Java.Util.UUID uuid, byte[] sessionId, bool forceAllowInsecureDecoderComponents) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/UUID;[BZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sessionId = JNIEnv.NewArray (sessionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				__args [1] = new JniArgumentValue (native_sessionId);
				__args [2] = new JniArgumentValue (forceAllowInsecureDecoderComponents);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (sessionId != null) {
					JNIEnv.CopyArray (native_sessionId, sessionId);
					JNIEnv.DeleteLocalRef (native_sessionId);
				}
				global::System.GC.KeepAlive (uuid);
				global::System.GC.KeepAlive (sessionId);
			}
		}

	}
}
