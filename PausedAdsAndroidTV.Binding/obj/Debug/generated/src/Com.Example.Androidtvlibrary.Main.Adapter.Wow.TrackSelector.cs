using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector", DoNotGenerateAcw=true)]
	public abstract partial class TrackSelector : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='TrackSelector.InvalidationListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector$InvalidationListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector/IInvalidationListenerInvoker")]
		public partial interface IInvalidationListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='TrackSelector.InvalidationListener']/method[@name='onTrackSelectionsInvalidated' and count(parameter)=0]"
			[Register ("onTrackSelectionsInvalidated", "()V", "GetOnTrackSelectionsInvalidatedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector/IInvalidationListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnTrackSelectionsInvalidated ();

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector$InvalidationListener", DoNotGenerateAcw=true)]
		internal partial class IInvalidationListenerInvoker : global::Java.Lang.Object, IInvalidationListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector$InvalidationListener", typeof (IInvalidationListenerInvoker));

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

			public static IInvalidationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInvalidationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.TrackSelector.InvalidationListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInvalidationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTrackSelectionsInvalidated;
#pragma warning disable 0169
			static Delegate GetOnTrackSelectionsInvalidatedHandler ()
			{
				if (cb_onTrackSelectionsInvalidated == null)
					cb_onTrackSelectionsInvalidated = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTrackSelectionsInvalidated);
				return cb_onTrackSelectionsInvalidated;
			}

			static void n_OnTrackSelectionsInvalidated (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector.IInvalidationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTrackSelectionsInvalidated ();
			}
#pragma warning restore 0169

			IntPtr id_onTrackSelectionsInvalidated;
			public unsafe void OnTrackSelectionsInvalidated ()
			{
				if (id_onTrackSelectionsInvalidated == IntPtr.Zero)
					id_onTrackSelectionsInvalidated = JNIEnv.GetMethodID (class_ref, "onTrackSelectionsInvalidated", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTrackSelectionsInvalidated);
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/wow/TrackSelector_InvalidationListenerImplementor")]
		internal sealed partial class IInvalidationListenerImplementor : global::Java.Lang.Object, IInvalidationListener {

			object sender;

			public IInvalidationListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/wow/TrackSelector_InvalidationListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler Handler;
			#pragma warning restore 0649

			public void OnTrackSelectionsInvalidated ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IInvalidationListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector", typeof (TrackSelector));

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

		protected TrackSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/constructor[@name='TrackSelector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrackSelector () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		protected unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter BandwidthMeter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='getBandwidthMeter' and count(parameter)=0]"
			[Register ("getBandwidthMeter", "()Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;", "")]
			get {
				const string __id = "getBandwidthMeter.()Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='init' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelector.InvalidationListener'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelector$InvalidationListener;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V", "")]
		public unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector.IInvalidationListener listener, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter)
		{
			const string __id = "init.(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelector$InvalidationListener;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
				global::System.GC.KeepAlive (bandwidthMeter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "")]
		protected unsafe void Invalidate ()
		{
			const string __id = "invalidate.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSelectionActivated_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSelectionActivated_Ljava_lang_Object_Handler ()
		{
			if (cb_onSelectionActivated_Ljava_lang_Object_ == null)
				cb_onSelectionActivated_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSelectionActivated_Ljava_lang_Object_);
			return cb_onSelectionActivated_Ljava_lang_Object_;
		}

		static void n_OnSelectionActivated_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectionActivated (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='onSelectionActivated' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSelectionActivated", "(Ljava/lang/Object;)V", "GetOnSelectionActivated_Ljava_lang_Object_Handler")]
		public abstract void OnSelectionActivated (global::Java.Lang.Object p0);

		static Delegate cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
#pragma warning disable 0169
		static Delegate GetSelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler ()
		{
			if (cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_ == null)
				cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_SelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_);
			return cb_selectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_;
		}

		static IntPtr n_SelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities));
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectTracks (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='selectTracks' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererCapabilities[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("selectTracks", "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;", "GetSelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler")]
		public abstract global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p2, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline p3);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector", DoNotGenerateAcw=true)]
	internal partial class TrackSelectorInvoker : TrackSelector {
		public TrackSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/TrackSelector", typeof (TrackSelectorInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='onSelectionActivated' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSelectionActivated", "(Ljava/lang/Object;)V", "GetOnSelectionActivated_Ljava_lang_Object_Handler")]
		public override unsafe void OnSelectionActivated (global::Java.Lang.Object p0)
		{
			const string __id = "onSelectionActivated.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelector']/method[@name='selectTracks' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererCapabilities[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("selectTracks", "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;", "GetSelectTracks_arrayLcom_example_androidtvlibrary_main_adapter_wow_RendererCapabilities_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_wow_MediaSource_MediaPeriodId_Lcom_example_androidtvlibrary_main_adapter_Timeline_Handler")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId p2, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline p3)
		{
			const string __id = "selectTracks.([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

	}
}
