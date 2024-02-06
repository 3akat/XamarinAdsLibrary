using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.SeekPoints']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints", DoNotGenerateAcw=true)]
	public sealed partial class SeekMapSeekPoints : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.SeekPoints']/field[@name='first']"
		[Register ("first")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint First {
			get {
				const string __id = "first.Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "first.Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.SeekPoints']/field[@name='second']"
		[Register ("second")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint Second {
			get {
				const string __id = "second.Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "second.Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints", typeof (SeekMapSeekPoints));

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

		internal SeekMapSeekPoints (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.SeekPoints']/constructor[@name='SeekMap.SeekPoints' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.SeekPoint']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;)V", "")]
		public unsafe SeekMapSeekPoints (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint point) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((point == null) ? IntPtr.Zero : ((global::Java.Lang.Object) point).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (point);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.SeekPoints']/constructor[@name='SeekMap.SeekPoints' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.SeekPoint'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.SeekPoint']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;)V", "")]
		public unsafe SeekMapSeekPoints (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint first, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekPoint second) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;Lcom/example/androidtvlibrary/main/adapter/Media/SeekPoint;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (first);
				global::System.GC.KeepAlive (second);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.Unseekable']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SeekMap$Unseekable", DoNotGenerateAcw=true)]
	public partial class SeekMapUnseekable : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SeekMap$Unseekable", typeof (SeekMapUnseekable));

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

		protected SeekMapUnseekable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.Unseekable']/constructor[@name='SeekMap.Unseekable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe SeekMapUnseekable (long durationUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (durationUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.Unseekable']/constructor[@name='SeekMap.Unseekable' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe SeekMapUnseekable (long durationUs, long startPosition) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationUs);
				__args [1] = new JniArgumentValue (startPosition);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapUnseekable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationUs;
		}
#pragma warning restore 0169

		public virtual unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.Unseekable']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "GetGetDurationUsHandler")]
			get {
				const string __id = "getDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapUnseekable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSeekable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.Unseekable']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "GetIsSeekableHandler")]
			get {
				const string __id = "isSeekable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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

		static IntPtr n_GetSeekPoints_J (IntPtr jnienv, IntPtr native__this, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapUnseekable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeekPoints (timeUs));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SeekMap.Unseekable']/method[@name='getSeekPoints' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getSeekPoints", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;", "GetGetSeekPoints_JHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints GetSeekPoints (long timeUs)
		{
			const string __id = "getSeekPoints.(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='SeekMap']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/SeekMap", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMapInvoker")]
	public partial interface ISeekMap : IJavaObject, IJavaPeerable {
		long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='SeekMap']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "GetGetDurationUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMapInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='SeekMap']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "GetIsSeekableHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMapInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='SeekMap']/method[@name='getSeekPoints' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getSeekPoints", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints;", "GetGetSeekPoints_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMapInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints GetSeekPoints (long p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SeekMap", DoNotGenerateAcw=true)]
	internal partial class ISeekMapInvoker : global::Java.Lang.Object, ISeekMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SeekMap", typeof (ISeekMapInvoker));

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

		public static ISeekMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISeekMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.SeekMap'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISeekMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
