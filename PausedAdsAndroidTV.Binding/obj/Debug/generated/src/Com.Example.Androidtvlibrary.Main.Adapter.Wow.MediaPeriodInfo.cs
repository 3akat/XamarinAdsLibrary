using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo", DoNotGenerateAcw=true)]
	public sealed partial class MediaPeriodInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='contentPositionUs']"
		[Register ("contentPositionUs")]
		public long ContentPositionUs {
			get {
				const string __id = "contentPositionUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "contentPositionUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='durationUs']"
		[Register ("durationUs")]
		public long DurationUs {
			get {
				const string __id = "durationUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "durationUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='endPositionUs']"
		[Register ("endPositionUs")]
		public long EndPositionUs {
			get {
				const string __id = "endPositionUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "endPositionUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='id']"
		[Register ("id")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId Id {
			get {
				const string __id = "id.Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='isFinal']"
		[Register ("isFinal")]
		public bool IsFinal {
			get {
				const string __id = "isFinal.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isFinal.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='isLastInTimelinePeriod']"
		[Register ("isLastInTimelinePeriod")]
		public bool IsLastInTimelinePeriod {
			get {
				const string __id = "isLastInTimelinePeriod.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isLastInTimelinePeriod.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/field[@name='startPositionUs']"
		[Register ("startPositionUs")]
		public long StartPositionUs {
			get {
				const string __id = "startPositionUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "startPositionUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo", typeof (MediaPeriodInfo));

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

		internal MediaPeriodInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/method[@name='copyWithContentPositionUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("copyWithContentPositionUs", "(J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo CopyWithContentPositionUs (long contentPositionUs)
		{
			const string __id = "copyWithContentPositionUs.(J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contentPositionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaPeriodInfo']/method[@name='copyWithStartPositionUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("copyWithStartPositionUs", "(J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo CopyWithStartPositionUs (long startPositionUs)
		{
			const string __id = "copyWithStartPositionUs.(J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriodInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (startPositionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaPeriodInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
