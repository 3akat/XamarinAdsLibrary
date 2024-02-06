using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/ErrorStateDrmSession", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.example.androidtvlibrary.main.adapter.wow.ExoMediaCrypto"})]
	public sealed partial class ErrorStateDrmSession : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession {
		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.wow.DrmSession

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_ERROR']"
			[Register ("STATE_ERROR")]
			public const int StateError = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_OPENED']"
			[Register ("STATE_OPENED")]
			public const int StateOpened = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_OPENED_WITH_KEYS']"
			[Register ("STATE_OPENED_WITH_KEYS")]
			public const int StateOpenedWithKeys = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_OPENING']"
			[Register ("STATE_OPENING")]
			public const int StateOpening = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='DrmSession']/field[@name='STATE_RELEASED']"
			[Register ("STATE_RELEASED")]
			public const int StateReleased = (int) 0;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/ErrorStateDrmSession", typeof (ErrorStateDrmSession));

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

		internal ErrorStateDrmSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/constructor[@name='ErrorStateDrmSession' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DrmSession.DrmSessionException']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;)V", "")]
		public unsafe ErrorStateDrmSession (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException error) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (error);
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;", "")]
			get {
				const string __id = "getError.()Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object MediaCrypto {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='getMediaCrypto' and count(parameter)=0]"
			[Register ("getMediaCrypto", "()Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;", "")]
			get {
				const string __id = "getMediaCrypto.()Lcom/example/androidtvlibrary/main/adapter/wow/ExoMediaCrypto;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "")]
			get {
				const string __id = "getState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "")]
		public unsafe void Acquire ()
		{
			const string __id = "acquire.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='getOfflineLicenseKeySetId' and count(parameter)=0]"
		[Register ("getOfflineLicenseKeySetId", "()[B", "")]
		public unsafe byte[] GetOfflineLicenseKeySetId ()
		{
			const string __id = "getOfflineLicenseKeySetId.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='playClearSamplesWithoutKeys' and count(parameter)=0]"
		[Register ("playClearSamplesWithoutKeys", "()Z", "")]
		public unsafe bool PlayClearSamplesWithoutKeys ()
		{
			const string __id = "playClearSamplesWithoutKeys.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='queryKeyStatus' and count(parameter)=0]"
		[Register ("queryKeyStatus", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, string> QueryKeyStatus ()
		{
			const string __id = "queryKeyStatus.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='ErrorStateDrmSession']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
