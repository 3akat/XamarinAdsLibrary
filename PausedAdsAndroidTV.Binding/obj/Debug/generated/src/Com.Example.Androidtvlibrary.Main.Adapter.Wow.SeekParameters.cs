using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/SeekParameters", DoNotGenerateAcw=true)]
	public sealed partial class SeekParameters : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='CLOSEST_SYNC']"
		[Register ("CLOSEST_SYNC")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters ClosestSync {
			get {
				const string __id = "CLOSEST_SYNC.Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters Default {
			get {
				const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='EXACT']"
		[Register ("EXACT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters Exact {
			get {
				const string __id = "EXACT.Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='NEXT_SYNC']"
		[Register ("NEXT_SYNC")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters NextSync {
			get {
				const string __id = "NEXT_SYNC.Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='PREVIOUS_SYNC']"
		[Register ("PREVIOUS_SYNC")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters PreviousSync {
			get {
				const string __id = "PREVIOUS_SYNC.Lcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='toleranceAfterUs']"
		[Register ("toleranceAfterUs")]
		public long ToleranceAfterUs {
			get {
				const string __id = "toleranceAfterUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "toleranceAfterUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/field[@name='toleranceBeforeUs']"
		[Register ("toleranceBeforeUs")]
		public long ToleranceBeforeUs {
			get {
				const string __id = "toleranceBeforeUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "toleranceBeforeUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/SeekParameters", typeof (SeekParameters));

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

		internal SeekParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='SeekParameters']/constructor[@name='SeekParameters' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe SeekParameters (long toleranceBeforeUs, long toleranceAfterUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (toleranceBeforeUs);
				__args [1] = new JniArgumentValue (toleranceAfterUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
