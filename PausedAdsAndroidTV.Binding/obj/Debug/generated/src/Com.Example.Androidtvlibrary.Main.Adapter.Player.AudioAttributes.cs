using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioAttributes", DoNotGenerateAcw=true)]
	public sealed partial class AudioAttributes : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']/field[@name='allowedCapturePolicy']"
		[Register ("allowedCapturePolicy")]
		public int AllowedCapturePolicy {
			get {
				const string __id = "allowedCapturePolicy.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "allowedCapturePolicy.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']/field[@name='contentType']"
		[Register ("contentType")]
		public int ContentType {
			get {
				const string __id = "contentType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "contentType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes Default {
			get {
				const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']/field[@name='flags']"
		[Register ("flags")]
		public int Flags {
			get {
				const string __id = "flags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "flags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']/field[@name='usage']"
		[Register ("usage")]
		public int Usage {
			get {
				const string __id = "usage.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "usage.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']/constructor[@name='AudioAttributes.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes Build ()
			{
				const string __id = "build.()Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']/method[@name='setAllowedCapturePolicy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAllowedCapturePolicy", "(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder SetAllowedCapturePolicy (int allowedCapturePolicy)
			{
				const string __id = "setAllowedCapturePolicy.(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowedCapturePolicy);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setContentType", "(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder SetContentType (int contentType)
			{
				const string __id = "setContentType.(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (contentType);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder SetFlags (int flags)
			{
				const string __id = "setFlags.(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (flags);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes.Builder']/method[@name='setUsage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUsage", "(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder SetUsage (int usage)
			{
				const string __id = "setUsage.(I)Lcom/example/androidtvlibrary/main/adapter/player/AudioAttributes$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (usage);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioAttributes.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AudioAttributes", typeof (AudioAttributes));

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

		internal AudioAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.Media.AudioAttributes AudioAttributesV21 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AudioAttributes']/method[@name='getAudioAttributesV21' and count(parameter)=0]"
			[Register ("getAudioAttributesV21", "()Landroid/media/AudioAttributes;", "")]
			get {
				const string __id = "getAudioAttributesV21.()Landroid/media/AudioAttributes;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.AudioAttributes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
