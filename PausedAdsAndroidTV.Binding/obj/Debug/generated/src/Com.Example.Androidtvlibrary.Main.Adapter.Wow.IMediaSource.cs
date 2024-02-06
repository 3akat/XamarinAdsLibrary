using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId", DoNotGenerateAcw=true)]
	public sealed partial class MediaSourceMediaPeriodId : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/field[@name='adGroupIndex']"
		[Register ("adGroupIndex")]
		public int AdGroupIndex {
			get {
				const string __id = "adGroupIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "adGroupIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/field[@name='adIndexInAdGroup']"
		[Register ("adIndexInAdGroup")]
		public int AdIndexInAdGroup {
			get {
				const string __id = "adIndexInAdGroup.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "adIndexInAdGroup.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/field[@name='nextAdGroupIndex']"
		[Register ("nextAdGroupIndex")]
		public int NextAdGroupIndex {
			get {
				const string __id = "nextAdGroupIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "nextAdGroupIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/field[@name='periodUid']"
		[Register ("periodUid")]
		public global::Java.Lang.Object PeriodUid {
			get {
				const string __id = "periodUid.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "periodUid.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/field[@name='windowSequenceNumber']"
		[Register ("windowSequenceNumber")]
		public long WindowSequenceNumber {
			get {
				const string __id = "windowSequenceNumber.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "windowSequenceNumber.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId", typeof (MediaSourceMediaPeriodId));

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

		internal MediaSourceMediaPeriodId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/constructor[@name='MediaSource.MediaPeriodId' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe MediaSourceMediaPeriodId (global::Java.Lang.Object periodUid) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((periodUid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) periodUid).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (periodUid);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/constructor[@name='MediaSource.MediaPeriodId' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/lang/Object;IIJ)V", "")]
		public unsafe MediaSourceMediaPeriodId (global::Java.Lang.Object periodUid, int adGroupIndex, int adIndexInAdGroup, long windowSequenceNumber) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;IIJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((periodUid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) periodUid).Handle);
				__args [1] = new JniArgumentValue (adGroupIndex);
				__args [2] = new JniArgumentValue (adIndexInAdGroup);
				__args [3] = new JniArgumentValue (windowSequenceNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (periodUid);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/constructor[@name='MediaSource.MediaPeriodId' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/lang/Object;J)V", "")]
		public unsafe MediaSourceMediaPeriodId (global::Java.Lang.Object periodUid, long windowSequenceNumber) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((periodUid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) periodUid).Handle);
				__args [1] = new JniArgumentValue (windowSequenceNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (periodUid);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/constructor[@name='MediaSource.MediaPeriodId' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/Object;JI)V", "")]
		public unsafe MediaSourceMediaPeriodId (global::Java.Lang.Object periodUid, long windowSequenceNumber, int nextAdGroupIndex) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;JI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((periodUid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) periodUid).Handle);
				__args [1] = new JniArgumentValue (windowSequenceNumber);
				__args [2] = new JniArgumentValue (nextAdGroupIndex);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (periodUid);
			}
		}

		public unsafe bool IsAd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/method[@name='isAd' and count(parameter)=0]"
			[Register ("isAd", "()Z", "")]
			get {
				const string __id = "isAd.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSource.MediaPeriodId']/method[@name='copyWithPeriodUid' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("copyWithPeriodUid", "(Ljava/lang/Object;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId CopyWithPeriodUid (global::Java.Lang.Object newPeriodUid)
		{
			const string __id = "copyWithPeriodUid.(Ljava/lang/Object;)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newPeriodUid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newPeriodUid).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (newPeriodUid);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource.MediaSourceCaller']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCallerInvoker")]
	public partial interface IMediaSourceMediaSourceCaller : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource.MediaSourceCaller']/method[@name='onSourceInfoRefreshed' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("onSourceInfoRefreshed", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/Timeline;)V", "GetOnSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCallerInvoker, PausedAdsAndroidTV.Binding")]
		void OnSourceInfoRefreshed (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller", DoNotGenerateAcw=true)]
	internal partial class IMediaSourceMediaSourceCallerInvoker : global::Java.Lang.Object, IMediaSourceMediaSourceCaller {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller", typeof (IMediaSourceMediaSourceCallerInvoker));

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

		public static IMediaSourceMediaSourceCaller GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaSourceMediaSourceCaller> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaSourceMediaSourceCallerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
#pragma warning disable 0169
		static Delegate GetOnSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler ()
		{
			if (cb_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ == null)
				cb_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_);
			return cb_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
		}

		static void n_OnSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSourceInfoRefreshed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
		public unsafe void OnSourceInfoRefreshed (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline p1)
		{
			if (id_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ == IntPtr.Zero)
				id_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_ = JNIEnv.GetMethodID (class_ref, "onSourceInfoRefreshed", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/Timeline;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSourceInfoRefreshed_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_Lcom_example_androidtvlibrary_main_adapter_Timeline_, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSource", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker")]
	public partial interface IMediaSource : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener']]"
		[Register ("addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V", "GetAddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void AddEventListener (global::Android.OS.Handler p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='createPeriod' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[3][@type='long']]"
		[Register ("createPeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;", "GetCreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod CreatePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='disable' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller']]"
		[Register ("disable", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V", "GetDisable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void Disable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller']]"
		[Register ("enable", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V", "GetEnable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void Enable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='maybeThrowSourceInfoRefreshError' and count(parameter)=0]"
		[Register ("maybeThrowSourceInfoRefreshError", "()V", "GetMaybeThrowSourceInfoRefreshErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void MaybeThrowSourceInfoRefreshError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='prepareSource' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TransferListener']]"
		[Register ("prepareSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V", "GetPrepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void PrepareSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='releasePeriod' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("releasePeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "GetReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void ReleasePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='releaseSource' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaSourceCaller']]"
		[Register ("releaseSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V", "GetReleaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void ReleaseSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSource']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener']]"
		[Register ("removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V", "GetRemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceInvoker, PausedAdsAndroidTV.Binding")]
		void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSource", DoNotGenerateAcw=true)]
	internal partial class IMediaSourceInvoker : global::Java.Lang.Object, IMediaSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSource", typeof (IMediaSourceInvoker));

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

		public static IMediaSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.MediaSource'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_;
#pragma warning disable 0169
		static Delegate GetAddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_Handler ()
		{
			if (cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ == null)
				cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_);
			return cb_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_;
		}

		static void n_AddEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddEventListener (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_;
		public unsafe void AddEventListener (global::Android.OS.Handler p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener p1)
		{
			if (id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ == IntPtr.Zero)
				id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEventListener_Landroid_os_Handler_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_, __args);
		}

		static Delegate cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J;
#pragma warning disable 0169
		static Delegate GetCreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_JHandler ()
		{
			if (cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J == null)
				cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_L) n_CreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J);
			return cb_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J;
		}

		static IntPtr n_CreatePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeriod (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod CreatePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator p1, long p2)
		{
			if (id_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J == IntPtr.Zero)
				id_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J = JNIEnv.GetMethodID (class_ref, "createPeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_wow_Allocator_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
#pragma warning disable 0169
		static Delegate GetDisable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Handler ()
		{
			if (cb_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ == null)
				cb_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_);
			return cb_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
		}

		static void n_Disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0);
		}
#pragma warning restore 0169

		IntPtr id_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
		public unsafe void Disable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0)
		{
			if (id_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ == IntPtr.Zero)
				id_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ = JNIEnv.GetMethodID (class_ref, "disable", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_, __args);
		}

		static Delegate cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
#pragma warning disable 0169
		static Delegate GetEnable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Handler ()
		{
			if (cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ == null)
				cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_);
			return cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
		}

		static void n_Enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		IntPtr id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
		public unsafe void Enable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0)
		{
			if (id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ == IntPtr.Zero)
				id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ = JNIEnv.GetMethodID (class_ref, "enable", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_, __args);
		}

		static Delegate cb_maybeThrowSourceInfoRefreshError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowSourceInfoRefreshErrorHandler ()
		{
			if (cb_maybeThrowSourceInfoRefreshError == null)
				cb_maybeThrowSourceInfoRefreshError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowSourceInfoRefreshError);
			return cb_maybeThrowSourceInfoRefreshError;
		}

		static void n_MaybeThrowSourceInfoRefreshError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowSourceInfoRefreshError ();
		}
#pragma warning restore 0169

		IntPtr id_maybeThrowSourceInfoRefreshError;
		public unsafe void MaybeThrowSourceInfoRefreshError ()
		{
			if (id_maybeThrowSourceInfoRefreshError == IntPtr.Zero)
				id_maybeThrowSourceInfoRefreshError = JNIEnv.GetMethodID (class_ref, "maybeThrowSourceInfoRefreshError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_maybeThrowSourceInfoRefreshError);
		}

		static Delegate cb_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
#pragma warning disable 0169
		static Delegate GetPrepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_Handler ()
		{
			if (cb_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ == null)
				cb_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_);
			return cb_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
		}

		static void n_PrepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrepareSource (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_;
		public unsafe void PrepareSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener p1)
		{
			if (id_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ == IntPtr.Zero)
				id_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_ = JNIEnv.GetMethodID (class_ref, "prepareSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;Lcom/example/androidtvlibrary/main/adapter/TransferListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Lcom_example_androidtvlibrary_main_adapter_TransferListener_, __args);
		}

		static Delegate cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
#pragma warning disable 0169
		static Delegate GetReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_Handler ()
		{
			if (cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ == null)
				cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_);
			return cb_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
		}

		static void n_ReleasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleasePeriod (p0);
		}
#pragma warning restore 0169

		IntPtr id_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_;
		public unsafe void ReleasePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod p0)
		{
			if (id_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ == IntPtr.Zero)
				id_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_ = JNIEnv.GetMethodID (class_ref, "releasePeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releasePeriod_Lcom_example_androidtvlibrary_main_adapter_wow_MediaPeriod_, __args);
		}

		static Delegate cb_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
#pragma warning disable 0169
		static Delegate GetReleaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_Handler ()
		{
			if (cb_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ == null)
				cb_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_);
			return cb_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
		}

		static void n_ReleaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSource (p0);
		}
#pragma warning restore 0169

		IntPtr id_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_;
		public unsafe void ReleaseSource (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceMediaSourceCaller p0)
		{
			if (id_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ == IntPtr.Zero)
				id_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_ = JNIEnv.GetMethodID (class_ref, "releaseSource", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaSourceCaller;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseSource_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaSourceCaller_, __args);
		}

		static Delegate cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_Handler ()
		{
			if (cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ == null)
				cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_);
			return cb_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_;
		}

		static void n_RemoveEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEventListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_;
		public unsafe void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener p0)
		{
			if (id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ == IntPtr.Zero)
				id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_ = JNIEnv.GetMethodID (class_ref, "removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeEventListener_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSourceEventListener_, __args);
		}

	}
}
