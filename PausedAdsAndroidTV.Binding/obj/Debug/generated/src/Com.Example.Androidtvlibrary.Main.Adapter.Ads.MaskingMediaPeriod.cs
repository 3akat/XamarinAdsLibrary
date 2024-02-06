using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod", DoNotGenerateAcw=true)]
	public sealed partial class MaskingMediaPeriod : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/field[@name='id']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/field[@name='mediaSource']"
		[Register ("mediaSource")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource MediaSource {
			get {
				const string __id = "mediaSource.Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mediaSource.Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/interface[@name='MaskingMediaPeriod.PrepareErrorListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod$PrepareErrorListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod/IPrepareErrorListenerInvoker")]
		public partial interface IPrepareErrorListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/interface[@name='MaskingMediaPeriod.PrepareErrorListener']/method[@name='onPrepareError' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[2][@type='java.io.IOException']]"
			[Register ("onPrepareError", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Ljava/io/IOException;)V", "GetOnPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod/IPrepareErrorListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnPrepareError (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Java.IO.IOException p1);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod$PrepareErrorListener", DoNotGenerateAcw=true)]
		internal partial class IPrepareErrorListenerInvoker : global::Java.Lang.Object, IPrepareErrorListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod$PrepareErrorListener", typeof (IPrepareErrorListenerInvoker));

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

			public static IPrepareErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPrepareErrorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.ads.MaskingMediaPeriod.PrepareErrorListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPrepareErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_;
#pragma warning disable 0169
			static Delegate GetOnPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_Handler ()
			{
				if (cb_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_ == null)
					cb_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_);
				return cb_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_;
			}

			static void n_OnPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepareError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_;
			public unsafe void OnPrepareError (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Java.IO.IOException p1)
			{
				if (id_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_ == IntPtr.Zero)
					id_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onPrepareError", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Ljava/io/IOException;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareError_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Ljava_io_IOException_, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.ads.MaskingMediaPeriod.PrepareErrorListener.onPrepareError
		public partial class PrepareErrorEventArgs : global::System.EventArgs {
			public PrepareErrorEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Java.IO.IOException p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0;

			public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId P0 {
				get { return p0; }
			}

			global::Java.IO.IOException p1;

			public global::Java.IO.IOException P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod_PrepareErrorListenerImplementor")]
		internal sealed partial class IPrepareErrorListenerImplementor : global::Java.Lang.Object, IPrepareErrorListener {

			object sender;

			public IPrepareErrorListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod_PrepareErrorListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<PrepareErrorEventArgs> Handler;
			#pragma warning restore 0649

			public void OnPrepareError (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p0, global::Java.IO.IOException p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PrepareErrorEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IPrepareErrorListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod", typeof (MaskingMediaPeriod));

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

		internal MaskingMediaPeriod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/constructor[@name='MaskingMediaPeriod' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)V", "")]
		public unsafe MaskingMediaPeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSource mediaSource, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId id, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator allocator, long preparePositionUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((mediaSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaSource).Handle);
				__args [1] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				__args [2] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				__args [3] = new JniArgumentValue (preparePositionUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaSource);
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (allocator);
			}
		}

		public unsafe long BufferedPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='getBufferedPositionUs' and count(parameter)=0]"
			[Register ("getBufferedPositionUs", "()J", "")]
			get {
				const string __id = "getBufferedPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "")]
			get {
				const string __id = "isLoading.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long NextLoadPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='getNextLoadPositionUs' and count(parameter)=0]"
			[Register ("getNextLoadPositionUs", "()J", "")]
			get {
				const string __id = "getNextLoadPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long PreparePositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='getPreparePositionUs' and count(parameter)=0]"
			[Register ("getPreparePositionUs", "()J", "")]
			get {
				const string __id = "getPreparePositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray TrackGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='getTrackGroups' and count(parameter)=0]"
			[Register ("getTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "")]
			get {
				const string __id = "getTrackGroups.()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='continueLoading' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("continueLoading", "(J)Z", "")]
		public unsafe bool ContinueLoading (long positionUs)
		{
			const string __id = "continueLoading.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='createPeriod' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId']]"
		[Register ("createPeriod", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)V", "")]
		public unsafe void CreatePeriod (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId id)
		{
			const string __id = "createPeriod.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='discardBuffer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("discardBuffer", "(JZ)V", "")]
		public unsafe void DiscardBuffer (long positionUs, bool toKeyframe)
		{
			const string __id = "discardBuffer.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (toKeyframe);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='getAdjustedSeekPositionUs' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.SeekParameters']]"
		[Register ("getAdjustedSeekPositionUs", "(JLcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;)J", "")]
		public unsafe long GetAdjustedSeekPositionUs (long positionUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters seekParameters)
		{
			const string __id = "getAdjustedSeekPositionUs.(JLcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue ((seekParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekParameters).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (seekParameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='maybeThrowPrepareError' and count(parameter)=0]"
		[Register ("maybeThrowPrepareError", "()V", "")]
		public unsafe void MaybeThrowPrepareError ()
		{
			const string __id = "maybeThrowPrepareError.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='onContinueLoadingRequested' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("onContinueLoadingRequested", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "")]
		public unsafe void OnContinueLoadingRequested (global::Java.Lang.Object source)
		{
			const string __id = "onContinueLoadingRequested.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod']]"
		[Register ("onPrepared", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V", "")]
		public unsafe void OnPrepared (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriod mediaPeriod)
		{
			const string __id = "onPrepared.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaPeriod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriod).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaPeriod);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='overridePreparePositionUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("overridePreparePositionUs", "(J)V", "")]
		public unsafe void OverridePreparePositionUs (long preparePositionUs)
		{
			const string __id = "overridePreparePositionUs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (preparePositionUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='prepare' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaPeriod.Callback'] and parameter[2][@type='long']]"
		[Register ("prepare", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback;J)V", "")]
		public unsafe void Prepare (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaPeriodCallback @callback, long preparePositionUs)
		{
			const string __id = "prepare.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaPeriod$Callback;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [1] = new JniArgumentValue (preparePositionUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='readDiscontinuity' and count(parameter)=0]"
		[Register ("readDiscontinuity", "()J", "")]
		public unsafe long ReadDiscontinuity ()
		{
			const string __id = "readDiscontinuity.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='reevaluateBuffer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("reevaluateBuffer", "(J)V", "")]
		public unsafe void ReevaluateBuffer (long positionUs)
		{
			const string __id = "reevaluateBuffer.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='releasePeriod' and count(parameter)=0]"
		[Register ("releasePeriod", "()V", "")]
		public unsafe void ReleasePeriod ()
		{
			const string __id = "releasePeriod.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='seekToUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekToUs", "(J)J", "")]
		public unsafe long SeekToUs (long positionUs)
		{
			const string __id = "seekToUs.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (positionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='selectTracks' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackSelection[]'] and parameter[2][@type='boolean[]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.SampleStream[]'] and parameter[4][@type='boolean[]'] and parameter[5][@type='long']]"
		[Register ("selectTracks", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection;[Z[Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;[ZJ)J", "")]
		public unsafe long SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] selections, bool[] mayRetainStreamFlags, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream[] streams, bool[] streamResetFlags, long positionUs)
		{
			const string __id = "selectTracks.([Lcom/example/androidtvlibrary/main/adapter/TrackSelection;[Z[Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;[ZJ)J";
			IntPtr native_selections = JNIEnv.NewArray (selections);
			IntPtr native_mayRetainStreamFlags = JNIEnv.NewArray (mayRetainStreamFlags);
			IntPtr native_streams = JNIEnv.NewArray (streams);
			IntPtr native_streamResetFlags = JNIEnv.NewArray (streamResetFlags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_selections);
				__args [1] = new JniArgumentValue (native_mayRetainStreamFlags);
				__args [2] = new JniArgumentValue (native_streams);
				__args [3] = new JniArgumentValue (native_streamResetFlags);
				__args [4] = new JniArgumentValue (positionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				if (selections != null) {
					JNIEnv.CopyArray (native_selections, selections);
					JNIEnv.DeleteLocalRef (native_selections);
				}
				if (mayRetainStreamFlags != null) {
					JNIEnv.CopyArray (native_mayRetainStreamFlags, mayRetainStreamFlags);
					JNIEnv.DeleteLocalRef (native_mayRetainStreamFlags);
				}
				if (streams != null) {
					JNIEnv.CopyArray (native_streams, streams);
					JNIEnv.DeleteLocalRef (native_streams);
				}
				if (streamResetFlags != null) {
					JNIEnv.CopyArray (native_streamResetFlags, streamResetFlags);
					JNIEnv.DeleteLocalRef (native_streamResetFlags);
				}
				global::System.GC.KeepAlive (selections);
				global::System.GC.KeepAlive (mayRetainStreamFlags);
				global::System.GC.KeepAlive (streams);
				global::System.GC.KeepAlive (streamResetFlags);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='MaskingMediaPeriod']/method[@name='setPrepareErrorListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.ads.MaskingMediaPeriod.PrepareErrorListener']]"
		[Register ("setPrepareErrorListener", "(Lcom/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod$PrepareErrorListener;)V", "")]
		public unsafe void SetPrepareErrorListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListener listener)
		{
			const string __id = "setPrepareErrorListener.(Lcom/example/androidtvlibrary/main/adapter/ads/MaskingMediaPeriod$PrepareErrorListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.PrepareErrorEventArgs> PrepareError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListenerImplementor>(
				ref weak_implementor_SetPrepareErrorListener,
				__CreateIPrepareErrorListenerImplementor,
				SetPrepareErrorListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListenerImplementor>(
				ref weak_implementor_SetPrepareErrorListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListenerImplementor.__IsEmpty,
				__v => SetPrepareErrorListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetPrepareErrorListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListenerImplementor __CreateIPrepareErrorListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.MaskingMediaPeriod.IPrepareErrorListenerImplementor (this);
		}

		#endregion

	}
}
