using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SinglePeriodTimeline", DoNotGenerateAcw=true)]
	public sealed partial class SinglePeriodTimeline : global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SinglePeriodTimeline", typeof (SinglePeriodTimeline));

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

		internal SinglePeriodTimeline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/constructor[@name='SinglePeriodTimeline' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(JZZZ)V", "")]
		public unsafe SinglePeriodTimeline (long durationUs, bool isSeekable, bool isDynamic, bool isLive) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (durationUs);
				__args [1] = new JniArgumentValue (isSeekable);
				__args [2] = new JniArgumentValue (isDynamic);
				__args [3] = new JniArgumentValue (isLive);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/constructor[@name='SinglePeriodTimeline' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='java.lang.Object']]"
		[Register (".ctor", "(JZZZLjava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe SinglePeriodTimeline (long durationUs, bool isSeekable, bool isDynamic, bool isLive, global::Java.Lang.Object manifest, global::Java.Lang.Object tag) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZZZLjava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (durationUs);
				__args [1] = new JniArgumentValue (isSeekable);
				__args [2] = new JniArgumentValue (isDynamic);
				__args [3] = new JniArgumentValue (isLive);
				__args [4] = new JniArgumentValue ((manifest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifest).Handle);
				__args [5] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manifest);
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/constructor[@name='SinglePeriodTimeline' and count(parameter)=9 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='java.lang.Object'] and parameter[9][@type='java.lang.Object']]"
		[Register (".ctor", "(JJJJZZZLjava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe SinglePeriodTimeline (long periodDurationUs, long windowDurationUs, long windowPositionInPeriodUs, long windowDefaultStartPositionUs, bool isSeekable, bool isDynamic, bool isLive, global::Java.Lang.Object manifest, global::Java.Lang.Object tag) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJJJZZZLjava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (periodDurationUs);
				__args [1] = new JniArgumentValue (windowDurationUs);
				__args [2] = new JniArgumentValue (windowPositionInPeriodUs);
				__args [3] = new JniArgumentValue (windowDefaultStartPositionUs);
				__args [4] = new JniArgumentValue (isSeekable);
				__args [5] = new JniArgumentValue (isDynamic);
				__args [6] = new JniArgumentValue (isLive);
				__args [7] = new JniArgumentValue ((manifest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifest).Handle);
				__args [8] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manifest);
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/constructor[@name='SinglePeriodTimeline' and count(parameter)=11 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='java.lang.Object'] and parameter[11][@type='java.lang.Object']]"
		[Register (".ctor", "(JJJJJJZZZLjava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe SinglePeriodTimeline (long presentationStartTimeMs, long windowStartTimeMs, long periodDurationUs, long windowDurationUs, long windowPositionInPeriodUs, long windowDefaultStartPositionUs, bool isSeekable, bool isDynamic, bool isLive, global::Java.Lang.Object manifest, global::Java.Lang.Object tag) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJJJJJZZZLjava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (presentationStartTimeMs);
				__args [1] = new JniArgumentValue (windowStartTimeMs);
				__args [2] = new JniArgumentValue (periodDurationUs);
				__args [3] = new JniArgumentValue (windowDurationUs);
				__args [4] = new JniArgumentValue (windowPositionInPeriodUs);
				__args [5] = new JniArgumentValue (windowDefaultStartPositionUs);
				__args [6] = new JniArgumentValue (isSeekable);
				__args [7] = new JniArgumentValue (isDynamic);
				__args [8] = new JniArgumentValue (isLive);
				__args [9] = new JniArgumentValue ((manifest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifest).Handle);
				__args [10] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manifest);
				global::System.GC.KeepAlive (tag);
			}
		}

		public override unsafe int PeriodCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/method[@name='getPeriodCount' and count(parameter)=0]"
			[Register ("getPeriodCount", "()I", "")]
			get {
				const string __id = "getPeriodCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int WindowCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/method[@name='getWindowCount' and count(parameter)=0]"
			[Register ("getWindowCount", "()I", "")]
			get {
				const string __id = "getWindowCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/method[@name='getIndexOfPeriod' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getIndexOfPeriod", "(Ljava/lang/Object;)I", "")]
		public override unsafe int GetIndexOfPeriod (global::Java.Lang.Object uid)
		{
			const string __id = "getIndexOfPeriod.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uid).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/method[@name='getPeriod' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='boolean']]"
		[Register ("getPeriod", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period GetPeriod (int periodIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period, bool setIds)
		{
			const string __id = "getPeriod.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (periodIndex);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				__args [2] = new JniArgumentValue (setIds);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (period);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/method[@name='getUidOfPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUidOfPeriod", "(I)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object GetUidOfPeriod (int periodIndex)
		{
			const string __id = "getUidOfPeriod.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (periodIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SinglePeriodTimeline']/method[@name='getWindow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[3][@type='long']]"
		[Register ("getWindow", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window GetWindow (int windowIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, long defaultPositionProjectionUs)
		{
			const string __id = "getWindow.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [2] = new JniArgumentValue (defaultPositionProjectionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

	}
}
