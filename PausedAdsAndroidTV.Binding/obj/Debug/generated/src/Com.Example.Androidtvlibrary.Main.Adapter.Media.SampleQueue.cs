using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SampleQueue", DoNotGenerateAcw=true)]
	public partial class SampleQueue : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='SampleQueue.UpstreamFormatChangedListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/SampleQueue$UpstreamFormatChangedListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue/IUpstreamFormatChangedListenerInvoker")]
		public partial interface IUpstreamFormatChangedListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='SampleQueue.UpstreamFormatChangedListener']/method[@name='onUpstreamFormatChanged' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
			[Register ("onUpstreamFormatChanged", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V", "GetOnUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue/IUpstreamFormatChangedListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnUpstreamFormatChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SampleQueue$UpstreamFormatChangedListener", DoNotGenerateAcw=true)]
		internal partial class IUpstreamFormatChangedListenerInvoker : global::Java.Lang.Object, IUpstreamFormatChangedListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SampleQueue$UpstreamFormatChangedListener", typeof (IUpstreamFormatChangedListenerInvoker));

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

			public static IUpstreamFormatChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUpstreamFormatChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.SampleQueue.UpstreamFormatChangedListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUpstreamFormatChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
			static Delegate GetOnUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
			{
				if (cb_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
					cb_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_);
				return cb_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_;
			}

			static void n_OnUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpstreamFormatChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_;
			public unsafe void OnUpstreamFormatChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
			{
				if (id_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_ == IntPtr.Zero)
					id_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNIEnv.GetMethodID (class_ref, "onUpstreamFormatChanged", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpstreamFormatChanged_Lcom_example_androidtvlibrary_main_adapter_Format_, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.Media.SampleQueue.UpstreamFormatChangedListener.onUpstreamFormatChanged
		public partial class UpstreamFormatChangedEventArgs : global::System.EventArgs {
			public UpstreamFormatChangedEventArgs (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
			{
				this.p0 = p0;
			}

			global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0;

			public global::Com.Example.Androidtvlibrary.Main.Adapter.Format P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/Media/SampleQueue_UpstreamFormatChangedListenerImplementor")]
		internal sealed partial class IUpstreamFormatChangedListenerImplementor : global::Java.Lang.Object, IUpstreamFormatChangedListener {

			object sender;

			public IUpstreamFormatChangedListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/Media/SampleQueue_UpstreamFormatChangedListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<UpstreamFormatChangedEventArgs> Handler;
			#pragma warning restore 0649

			public void OnUpstreamFormatChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new UpstreamFormatChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IUpstreamFormatChangedListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SampleQueue", typeof (SampleQueue));

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

		protected SampleQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/constructor[@name='SampleQueue' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator'] and parameter[2][@type='android.os.Looper'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.DrmSessionManager&lt;?&gt;']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)V", "")]
		public unsafe SampleQueue (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator allocator, global::Android.OS.Looper playbackLooper, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IDrmSessionManager drmSessionManager) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;Landroid/os/Looper;Lcom/example/androidtvlibrary/main/adapter/Media/DrmSessionManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				__args [1] = new JniArgumentValue ((playbackLooper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) playbackLooper).Handle);
				__args [2] = new JniArgumentValue ((drmSessionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmSessionManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (allocator);
				global::System.GC.KeepAlive (playbackLooper);
				global::System.GC.KeepAlive (drmSessionManager);
			}
		}

		public unsafe int FirstIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getFirstIndex' and count(parameter)=0]"
			[Register ("getFirstIndex", "()I", "")]
			get {
				const string __id = "getFirstIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long FirstTimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getFirstTimestampUs' and count(parameter)=0]"
			[Register ("getFirstTimestampUs", "()J", "")]
			get {
				const string __id = "getFirstTimestampUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsLastSampleQueued {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='isLastSampleQueued' and count(parameter)=0]"
			[Register ("isLastSampleQueued", "()Z", "")]
			get {
				const string __id = "isLastSampleQueued.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long LargestQueuedTimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getLargestQueuedTimestampUs' and count(parameter)=0]"
			[Register ("getLargestQueuedTimestampUs", "()J", "")]
			get {
				const string __id = "getLargestQueuedTimestampUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ReadIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getReadIndex' and count(parameter)=0]"
			[Register ("getReadIndex", "()I", "")]
			get {
				const string __id = "getReadIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format UpstreamFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getUpstreamFormat' and count(parameter)=0]"
			[Register ("getUpstreamFormat", "()Lcom/example/androidtvlibrary/main/adapter/Format;", "")]
			get {
				const string __id = "getUpstreamFormat.()Lcom/example/androidtvlibrary/main/adapter/Format;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int WriteIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getWriteIndex' and count(parameter)=0]"
			[Register ("getWriteIndex", "()I", "")]
			get {
				const string __id = "getWriteIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='advanceTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("advanceTo", "(J)I", "")]
		public unsafe int AdvanceTo (long timeUs)
		{
			const string __id = "advanceTo.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='advanceToEnd' and count(parameter)=0]"
		[Register ("advanceToEnd", "()I", "")]
		public unsafe int AdvanceToEnd ()
		{
			const string __id = "advanceToEnd.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_discardSampleMetadataToRead;
#pragma warning disable 0169
		static Delegate GetDiscardSampleMetadataToReadHandler ()
		{
			if (cb_discardSampleMetadataToRead == null)
				cb_discardSampleMetadataToRead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_DiscardSampleMetadataToRead);
			return cb_discardSampleMetadataToRead;
		}

		static long n_DiscardSampleMetadataToRead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiscardSampleMetadataToRead ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='discardSampleMetadataToRead' and count(parameter)=0]"
		[Register ("discardSampleMetadataToRead", "()J", "GetDiscardSampleMetadataToReadHandler")]
		public virtual unsafe long DiscardSampleMetadataToRead ()
		{
			const string __id = "discardSampleMetadataToRead.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='discardTo' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("discardTo", "(JZZ)V", "")]
		public unsafe void DiscardTo (long timeUs, bool toKeyframe, bool stopAtReadPosition)
		{
			const string __id = "discardTo.(JZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (timeUs);
				__args [1] = new JniArgumentValue (toKeyframe);
				__args [2] = new JniArgumentValue (stopAtReadPosition);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='discardToEnd' and count(parameter)=0]"
		[Register ("discardToEnd", "()V", "")]
		public unsafe void DiscardToEnd ()
		{
			const string __id = "discardToEnd.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='discardToRead' and count(parameter)=0]"
		[Register ("discardToRead", "()V", "")]
		public unsafe void DiscardToRead ()
		{
			const string __id = "discardToRead.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='discardUpstreamSamples' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("discardUpstreamSamples", "(I)V", "")]
		public unsafe void DiscardUpstreamSamples (int discardFromIndex)
		{
			const string __id = "discardUpstreamSamples.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (discardFromIndex);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='format' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("format", "(Lcom/example/androidtvlibrary/main/adapter/Format;)V", "")]
		public unsafe void Format (global::Com.Example.Androidtvlibrary.Main.Adapter.Format unadjustedUpstreamFormat)
		{
			const string __id = "format.(Lcom/example/androidtvlibrary/main/adapter/Format;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unadjustedUpstreamFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unadjustedUpstreamFormat).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (unadjustedUpstreamFormat);
			}
		}

		static Delegate cb_getAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetGetAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_getAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_getAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_getAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static IntPtr n_GetAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAdjustedUpstreamFormat (format));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='getAdjustedUpstreamFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("getAdjustedUpstreamFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/Format;", "GetGetAdjustedUpstreamFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format GetAdjustedUpstreamFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format)
		{
			const string __id = "getAdjustedUpstreamFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/Format;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='invalidateUpstreamFormatAdjustment' and count(parameter)=0]"
		[Register ("invalidateUpstreamFormatAdjustment", "()V", "")]
		protected unsafe void InvalidateUpstreamFormatAdjustment ()
		{
			const string __id = "invalidateUpstreamFormatAdjustment.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isReady_Z;
#pragma warning disable 0169
		static Delegate GetIsReady_ZHandler ()
		{
			if (cb_isReady_Z == null)
				cb_isReady_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_IsReady_Z);
			return cb_isReady_Z;
		}

		static bool n_IsReady_Z (IntPtr jnienv, IntPtr native__this, bool loadingFinished)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady (loadingFinished);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='isReady' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isReady", "(Z)Z", "GetIsReady_ZHandler")]
		public virtual unsafe bool IsReady (bool loadingFinished)
		{
			const string __id = "isReady.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (loadingFinished);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_maybeThrowError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowErrorHandler ()
		{
			if (cb_maybeThrowError == null)
				cb_maybeThrowError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowError);
			return cb_maybeThrowError;
		}

		static void n_MaybeThrowError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='maybeThrowError' and count(parameter)=0]"
		[Register ("maybeThrowError", "()V", "GetMaybeThrowErrorHandler")]
		public virtual unsafe void MaybeThrowError ()
		{
			const string __id = "maybeThrowError.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='peekSourceId' and count(parameter)=0]"
		[Register ("peekSourceId", "()I", "")]
		public unsafe int PeekSourceId ()
		{
			const string __id = "peekSourceId.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_preRelease;
#pragma warning disable 0169
		static Delegate GetPreReleaseHandler ()
		{
			if (cb_preRelease == null)
				cb_preRelease = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PreRelease);
			return cb_preRelease;
		}

		static void n_PreRelease (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreRelease ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='preRelease' and count(parameter)=0]"
		[Register ("preRelease", "()V", "GetPreReleaseHandler")]
		public virtual unsafe void PreRelease ()
		{
			const string __id = "preRelease.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_read_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJ;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJHandler ()
		{
			if (cb_read_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJ == null)
				cb_read_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZZJ_I) n_Read_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJ);
			return cb_read_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJ;
		}

		static int n_Read_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJ (IntPtr jnienv, IntPtr native__this, IntPtr native_formatHolder, IntPtr native_buffer, bool formatRequired, bool loadingFinished, long decodeOnlyUntilUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var formatHolder = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder> (native_formatHolder, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (formatHolder, buffer, formatRequired, loadingFinished, decodeOnlyUntilUs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='read' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.FormatHolder'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DecoderInputBuffer'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='long']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;ZZJ)I", "GetRead_Lcom_example_androidtvlibrary_main_adapter_wow_FormatHolder_Lcom_example_androidtvlibrary_main_adapter_wow_DecoderInputBuffer_ZZJHandler")]
		public virtual unsafe int Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.FormatHolder formatHolder, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DecoderInputBuffer buffer, bool formatRequired, bool loadingFinished, long decodeOnlyUntilUs)
		{
			const string __id = "read.(Lcom/example/androidtvlibrary/main/adapter/wow/FormatHolder;Lcom/example/androidtvlibrary/main/adapter/wow/DecoderInputBuffer;ZZJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((formatHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatHolder).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [2] = new JniArgumentValue (formatRequired);
				__args [3] = new JniArgumentValue (loadingFinished);
				__args [4] = new JniArgumentValue (decodeOnlyUntilUs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (formatHolder);
				global::System.GC.KeepAlive (buffer);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset_Z;
#pragma warning disable 0169
		static Delegate GetReset_ZHandler ()
		{
			if (cb_reset_Z == null)
				cb_reset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Reset_Z);
			return cb_reset_Z;
		}

		static void n_Reset_Z (IntPtr jnienv, IntPtr native__this, bool resetUpstreamFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset (resetUpstreamFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reset", "(Z)V", "GetReset_ZHandler")]
		public virtual unsafe void Reset (bool resetUpstreamFormat)
		{
			const string __id = "reset.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resetUpstreamFormat);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I", "")]
		public unsafe int SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, int length, bool allowEndOfInput)
		{
			const string __id = "sampleData.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue (length);
				__args [2] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		static Delegate cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler ()
		{
			if (cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I == null)
				cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I);
			return cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
		}

		static void n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SampleData (data, length);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V", "GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler")]
		public virtual unsafe void SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, int length)
		{
			const string __id = "sampleData.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='sampleMetadata' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput.CryptoData']]"
		[Register ("sampleMetadata", "(JIIILcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;)V", "")]
		public unsafe void SampleMetadata (long timeUs, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"BufferFlagKeyFrame", "BufferFlagEndOfStream", "BufferFlagHasSupplementalData", "BufferFlagLastSample", "BufferFlagEncrypted", "BufferFlagDecodeOnly"})]
		int flags, int size, int offset, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData cryptoData)
		{
			const string __id = "sampleMetadata.(JIIILcom/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (timeUs);
				__args [1] = new JniArgumentValue (flags);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue (offset);
				__args [4] = new JniArgumentValue ((cryptoData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cryptoData).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cryptoData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekTo", "(I)Z", "")]
		public unsafe bool SeekTo (int sampleIndex)
		{
			const string __id = "seekTo.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sampleIndex);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='seekTo' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("seekTo", "(JZ)Z", "")]
		public unsafe bool SeekTo (long timeUs, bool allowTimeBeyondBuffer)
		{
			const string __id = "seekTo.(JZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeUs);
				__args [1] = new JniArgumentValue (allowTimeBeyondBuffer);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='setSampleOffsetUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setSampleOffsetUs", "(J)V", "")]
		public unsafe void SetSampleOffsetUs (long sampleOffsetUs)
		{
			const string __id = "setSampleOffsetUs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sampleOffsetUs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='setUpstreamFormatChangeListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.SampleQueue.UpstreamFormatChangedListener']]"
		[Register ("setUpstreamFormatChangeListener", "(Lcom/example/androidtvlibrary/main/adapter/Media/SampleQueue$UpstreamFormatChangedListener;)V", "")]
		public unsafe void SetUpstreamFormatChangeListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListener listener)
		{
			const string __id = "setUpstreamFormatChangeListener.(Lcom/example/androidtvlibrary/main/adapter/Media/SampleQueue$UpstreamFormatChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='sourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sourceId", "(I)V", "")]
		public unsafe void SourceId (int sourceId)
		{
			const string __id = "sourceId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sourceId);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleQueue']/method[@name='splice' and count(parameter)=0]"
		[Register ("splice", "()V", "")]
		public unsafe void Splice ()
		{
			const string __id = "splice.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.UpstreamFormatChangedEventArgs> UpstreamFormatChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListenerImplementor>(
				ref weak_implementor_SetUpstreamFormatChangeListener,
				__CreateIUpstreamFormatChangedListenerImplementor,
				SetUpstreamFormatChangeListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListenerImplementor>(
				ref weak_implementor_SetUpstreamFormatChangeListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListenerImplementor.__IsEmpty,
				__v => SetUpstreamFormatChangeListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetUpstreamFormatChangeListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListenerImplementor __CreateIUpstreamFormatChangedListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleQueue.IUpstreamFormatChangedListenerImplementor (this);
		}

		#endregion

	}
}
