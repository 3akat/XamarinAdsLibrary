using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Drmsession {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='WidevineUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/drmsession/WidevineUtil", DoNotGenerateAcw=true)]
	public sealed partial class WidevineUtil : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='WidevineUtil']/field[@name='PROPERTY_LICENSE_DURATION_REMAINING']"
		[Register ("PROPERTY_LICENSE_DURATION_REMAINING")]
		public const string PropertyLicenseDurationRemaining = (string) "LicenseDurationRemaining";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='WidevineUtil']/field[@name='PROPERTY_PLAYBACK_DURATION_REMAINING']"
		[Register ("PROPERTY_PLAYBACK_DURATION_REMAINING")]
		public const string PropertyPlaybackDurationRemaining = (string) "PlaybackDurationRemaining";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/drmsession/WidevineUtil", typeof (WidevineUtil));

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

		internal WidevineUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.drmsession']/class[@name='WidevineUtil']/method[@name='getLicenseDurationRemainingSec' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DrmSession&lt;?&gt;']]"
		[Register ("getLicenseDurationRemainingSec", "(Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair GetLicenseDurationRemainingSec (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IDrmSession drmSession)
		{
			const string __id = "getLicenseDurationRemainingSec.(Lcom/example/androidtvlibrary/main/adapter/wow/DrmSession;)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drmSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSession).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drmSession);
			}
		}

	}
}
