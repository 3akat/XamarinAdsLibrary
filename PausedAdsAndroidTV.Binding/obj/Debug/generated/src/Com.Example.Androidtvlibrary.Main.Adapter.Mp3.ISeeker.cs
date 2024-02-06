using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Seeker.UnseekableSeeker']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/Seeker$UnseekableSeeker", DoNotGenerateAcw=true)]
	public partial class SeekerUnseekableSeeker : global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapUnseekable, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/Seeker$UnseekableSeeker", typeof (SeekerUnseekableSeeker));

		internal static new IntPtr class_ref {
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

		protected SeekerUnseekableSeeker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Seeker.UnseekableSeeker']/constructor[@name='Seeker.UnseekableSeeker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SeekerUnseekableSeeker () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDataEndPosition;
#pragma warning disable 0169
		static Delegate GetGetDataEndPositionHandler ()
		{
			if (cb_getDataEndPosition == null)
				cb_getDataEndPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDataEndPosition);
			return cb_getDataEndPosition;
		}

		static long n_GetDataEndPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.SeekerUnseekableSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataEndPosition;
		}
#pragma warning restore 0169

		public virtual unsafe long DataEndPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Seeker.UnseekableSeeker']/method[@name='getDataEndPosition' and count(parameter)=0]"
			[Register ("getDataEndPosition", "()J", "GetGetDataEndPositionHandler")]
			get {
				const string __id = "getDataEndPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTimeUs_J;
#pragma warning disable 0169
		static Delegate GetGetTimeUs_JHandler ()
		{
			if (cb_getTimeUs_J == null)
				cb_getTimeUs_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_GetTimeUs_J);
			return cb_getTimeUs_J;
		}

		static long n_GetTimeUs_J (IntPtr jnienv, IntPtr native__this, long position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.SeekerUnseekableSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTimeUs (position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Seeker.UnseekableSeeker']/method[@name='getTimeUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimeUs", "(J)J", "GetGetTimeUs_JHandler")]
		public virtual unsafe long GetTimeUs (long position)
		{
			const string __id = "getTimeUs.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='Seeker']"
	[Register ("com/example/androidtvlibrary/main/adapter/mp3/Seeker", "", "Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeekerInvoker")]
	public partial interface ISeeker : global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap {
		long DataEndPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='Seeker']/method[@name='getDataEndPosition' and count(parameter)=0]"
			[Register ("getDataEndPosition", "()J", "GetGetDataEndPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeekerInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='Seeker']/method[@name='getTimeUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimeUs", "(J)J", "GetGetTimeUs_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeekerInvoker, PausedAdsAndroidTV.Binding")]
		long GetTimeUs (long p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/Seeker", DoNotGenerateAcw=true)]
	internal partial class ISeekerInvoker : global::Java.Lang.Object, ISeeker {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/Seeker", typeof (ISeekerInvoker));

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

		public static ISeeker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISeeker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.mp3.Seeker'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISeekerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDataEndPosition;
#pragma warning disable 0169
		static Delegate GetGetDataEndPositionHandler ()
		{
			if (cb_getDataEndPosition == null)
				cb_getDataEndPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDataEndPosition);
			return cb_getDataEndPosition;
		}

		static long n_GetDataEndPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataEndPosition;
		}
#pragma warning restore 0169

		IntPtr id_getDataEndPosition;
		public unsafe long DataEndPosition {
			get {
				if (id_getDataEndPosition == IntPtr.Zero)
					id_getDataEndPosition = JNIEnv.GetMethodID (class_ref, "getDataEndPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDataEndPosition);
			}
		}

		static Delegate cb_getTimeUs_J;
#pragma warning disable 0169
		static Delegate GetGetTimeUs_JHandler ()
		{
			if (cb_getTimeUs_J == null)
				cb_getTimeUs_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_GetTimeUs_J);
			return cb_getTimeUs_J;
		}

		static long n_GetTimeUs_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTimeUs (p0);
		}
#pragma warning restore 0169

		IntPtr id_getTimeUs_J;
		public unsafe long GetTimeUs (long p0)
		{
			if (id_getTimeUs_J == IntPtr.Zero)
				id_getTimeUs_J = JNIEnv.GetMethodID (class_ref, "getTimeUs", "(J)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeUs_J, __args);
		}

		static Delegate cb_getDurationUs;
#pragma warning disable 0169
		static Delegate GetGetDurationUsHandler ()
		{
			if (cb_getDurationUs == null)
				cb_getDurationUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDurationUs);
			return cb_getDurationUs;
		}

		static long n_GetDurationUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationUs;
		}
#pragma warning restore 0169

		IntPtr id_getDurationUs;
		public unsafe long DurationUs {
			get {
				if (id_getDurationUs == IntPtr.Zero)
					id_getDurationUs = JNIEnv.GetMethodID (class_ref, "getDurationUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDurationUs);
			}
		}

		static Delegate cb_isSeekable;
#pragma warning disable 0169
		static Delegate GetIsSeekableHandler ()
		{
			if (cb_isSeekable == null)
				cb_isSeekable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSeekable);
			return cb_isSeekable;
		}

		static bool n_IsSeekable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSeekable;
		}
#pragma warning restore 0169

		IntPtr id_isSeekable;
		public unsafe bool IsSeekable {
			get {
				if (id_isSeekable == IntPtr.Zero)
					id_isSeekable = JNIEnv.GetMethodID (class_ref, "isSeekable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSeekable);
			}
		}

		static Delegate cb_getSeekPoints_J;
#pragma warning disable 0169
		static Delegate GetGetSeekPoints_JHandler ()
		{
			if (cb_getSeekPoints_J == null)
				cb_getSeekPoints_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_GetSeekPoints_J);
			return cb_getSeekPoints_J;
		}

		static IntPtr n_GetSeekPoints_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeekPoints (p0));
		}
#pragma warning restore 0169

		IntPtr id_getSeekPoints_J;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints GetSeekPoints (long p0)
		{
			if (id_getSeekPoints_J == IntPtr.Zero)
				id_getSeekPoints_J = JNIEnv.GetMethodID (class_ref, "getSeekPoints", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeekPoints_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
