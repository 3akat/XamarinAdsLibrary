using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/ForwardingTimeline", DoNotGenerateAcw=true)]
	public abstract partial class ForwardingTimeline : global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/field[@name='timeline']"
		[Register ("timeline")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline Timeline {
			get {
				const string __id = "timeline.Lcom/example/androidtvlibrary/main/adapter/Timeline;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timeline.Lcom/example/androidtvlibrary/main/adapter/Timeline;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/ForwardingTimeline", typeof (ForwardingTimeline));

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

		protected ForwardingTimeline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/constructor[@name='ForwardingTimeline' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;)V", "")]
		public unsafe ForwardingTimeline (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Timeline;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
			}
		}

		static Delegate cb_getPeriodCount;
#pragma warning disable 0169
		static Delegate GetGetPeriodCountHandler ()
		{
			if (cb_getPeriodCount == null)
				cb_getPeriodCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPeriodCount);
			return cb_getPeriodCount;
		}

		static int n_GetPeriodCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeriodCount;
		}
#pragma warning restore 0169

		public override unsafe int PeriodCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/method[@name='getPeriodCount' and count(parameter)=0]"
			[Register ("getPeriodCount", "()I", "GetGetPeriodCountHandler")]
			get {
				const string __id = "getPeriodCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWindowCount;
#pragma warning disable 0169
		static Delegate GetGetWindowCountHandler ()
		{
			if (cb_getWindowCount == null)
				cb_getWindowCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWindowCount);
			return cb_getWindowCount;
		}

		static int n_GetWindowCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WindowCount;
		}
#pragma warning restore 0169

		public override unsafe int WindowCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/method[@name='getWindowCount' and count(parameter)=0]"
			[Register ("getWindowCount", "()I", "GetGetWindowCountHandler")]
			get {
				const string __id = "getWindowCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndexOfPeriod_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetIndexOfPeriod_Ljava_lang_Object_Handler ()
		{
			if (cb_getIndexOfPeriod_Ljava_lang_Object_ == null)
				cb_getIndexOfPeriod_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetIndexOfPeriod_Ljava_lang_Object_);
			return cb_getIndexOfPeriod_Ljava_lang_Object_;
		}

		static int n_GetIndexOfPeriod_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uid = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_uid, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIndexOfPeriod (uid);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/method[@name='getIndexOfPeriod' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getIndexOfPeriod", "(Ljava/lang/Object;)I", "GetGetIndexOfPeriod_Ljava_lang_Object_Handler")]
		public override unsafe int GetIndexOfPeriod (global::Java.Lang.Object uid)
		{
			const string __id = "getIndexOfPeriod.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uid).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uid);
			}
		}

		static Delegate cb_getPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z;
#pragma warning disable 0169
		static Delegate GetGetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_ZHandler ()
		{
			if (cb_getPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z == null)
				cb_getPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILZ_L) n_GetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z);
			return cb_getPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z;
		}

		static IntPtr n_GetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z (IntPtr jnienv, IntPtr native__this, int periodIndex, IntPtr native_period, bool setIds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var period = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (native_period, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPeriod (periodIndex, period, setIds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/method[@name='getPeriod' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='boolean']]"
		[Register ("getPeriod", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "GetGetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_ZHandler")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period GetPeriod (int periodIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period, bool setIds)
		{
			const string __id = "getPeriod.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (periodIndex);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				__args [2] = new JniArgumentValue (setIds);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (period);
			}
		}

		static Delegate cb_getUidOfPeriod_I;
#pragma warning disable 0169
		static Delegate GetGetUidOfPeriod_IHandler ()
		{
			if (cb_getUidOfPeriod_I == null)
				cb_getUidOfPeriod_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetUidOfPeriod_I);
			return cb_getUidOfPeriod_I;
		}

		static IntPtr n_GetUidOfPeriod_I (IntPtr jnienv, IntPtr native__this, int periodIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUidOfPeriod (periodIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/method[@name='getUidOfPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUidOfPeriod", "(I)Ljava/lang/Object;", "GetGetUidOfPeriod_IHandler")]
		public override unsafe global::Java.Lang.Object GetUidOfPeriod (int periodIndex)
		{
			const string __id = "getUidOfPeriod.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (periodIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J;
#pragma warning disable 0169
		static Delegate GetGetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_JHandler ()
		{
			if (cb_getWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J == null)
				cb_getWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILJ_L) n_GetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J);
			return cb_getWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J;
		}

		static IntPtr n_GetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J (IntPtr jnienv, IntPtr native__this, int windowIndex, IntPtr native_window, long defaultPositionProjectionUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Ads.ForwardingTimeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var window = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (native_window, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetWindow (windowIndex, window, defaultPositionProjectionUs));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.ads']/class[@name='ForwardingTimeline']/method[@name='getWindow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[3][@type='long']]"
		[Register ("getWindow", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "GetGetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_JHandler")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window GetWindow (int windowIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, long defaultPositionProjectionUs)
		{
			const string __id = "getWindow.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [2] = new JniArgumentValue (defaultPositionProjectionUs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ads/ForwardingTimeline", DoNotGenerateAcw=true)]
	internal partial class ForwardingTimelineInvoker : ForwardingTimeline {
		public ForwardingTimelineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ads/ForwardingTimeline", typeof (ForwardingTimelineInvoker));

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

	}
}
