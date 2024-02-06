using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher", DoNotGenerateAcw=true)]
	public sealed partial class MediaSourceEventListenerEventDispatcher : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/field[@name='mediaPeriodId']"
		[Register ("mediaPeriodId")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId MediaPeriodId {
			get {
				const string __id = "mediaPeriodId.Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mediaPeriodId.Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/field[@name='windowIndex']"
		[Register ("windowIndex")]
		public int WindowIndex {
			get {
				const string __id = "windowIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "windowIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher", typeof (MediaSourceEventListenerEventDispatcher));

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

		internal MediaSourceEventListenerEventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/constructor[@name='MediaSourceEventListener.EventDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaSourceEventListenerEventDispatcher () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener']]"
		[Register ("addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V", "")]
		public unsafe void AddEventListener (global::Android.OS.Handler handler, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener eventListener)
		{
			const string __id = "addEventListener.(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='downstreamFormatChanged' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.MediaLoadData']]"
		[Register ("downstreamFormatChanged", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V", "")]
		public unsafe void DownstreamFormatChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData mediaLoadData)
		{
			const string __id = "downstreamFormatChanged.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaLoadData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaLoadData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaLoadData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='downstreamFormatChanged' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='long']]"
		[Register ("downstreamFormatChanged", "(ILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;J)V", "")]
		public unsafe void DownstreamFormatChanged (int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long mediaTimeUs)
		{
			const string __id = "downstreamFormatChanged.(ILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (trackType);
				__args [1] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [2] = new JniArgumentValue (trackSelectionReason);
				__args [3] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [4] = new JniArgumentValue (mediaTimeUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadCanceled' and count(parameter)=13 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.Object'] and parameter[9][@type='long'] and parameter[10][@type='long'] and parameter[11][@type='long'] and parameter[12][@type='long'] and parameter[13][@type='long']]"
		[Register ("loadCanceled", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJJJ)V", "")]
		public unsafe void LoadCanceled (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, int dataType, int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long mediaStartTimeUs, long mediaEndTimeUs, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded)
		{
			const string __id = "loadCanceled.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJJJ)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [13];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (dataType);
				__args [4] = new JniArgumentValue (trackType);
				__args [5] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [6] = new JniArgumentValue (trackSelectionReason);
				__args [7] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [8] = new JniArgumentValue (mediaStartTimeUs);
				__args [9] = new JniArgumentValue (mediaEndTimeUs);
				__args [10] = new JniArgumentValue (elapsedRealtimeMs);
				__args [11] = new JniArgumentValue (loadDurationMs);
				__args [12] = new JniArgumentValue (bytesLoaded);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadCanceled' and count(parameter)=7 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
		[Register ("loadCanceled", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IJJJ)V", "")]
		public unsafe void LoadCanceled (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, int dataType, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded)
		{
			const string __id = "loadCanceled.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IJJJ)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (dataType);
				__args [4] = new JniArgumentValue (elapsedRealtimeMs);
				__args [5] = new JniArgumentValue (loadDurationMs);
				__args [6] = new JniArgumentValue (bytesLoaded);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadCanceled' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.LoadEventInfo'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.MediaLoadData']]"
		[Register ("loadCanceled", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V", "")]
		public unsafe void LoadCanceled (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerLoadEventInfo loadEventInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData mediaLoadData)
		{
			const string __id = "loadCanceled.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((loadEventInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadEventInfo).Handle);
				__args [1] = new JniArgumentValue ((mediaLoadData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaLoadData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (loadEventInfo);
				global::System.GC.KeepAlive (mediaLoadData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadCompleted' and count(parameter)=13 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.Object'] and parameter[9][@type='long'] and parameter[10][@type='long'] and parameter[11][@type='long'] and parameter[12][@type='long'] and parameter[13][@type='long']]"
		[Register ("loadCompleted", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJJJ)V", "")]
		public unsafe void LoadCompleted (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, int dataType, int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long mediaStartTimeUs, long mediaEndTimeUs, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded)
		{
			const string __id = "loadCompleted.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJJJ)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [13];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (dataType);
				__args [4] = new JniArgumentValue (trackType);
				__args [5] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [6] = new JniArgumentValue (trackSelectionReason);
				__args [7] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [8] = new JniArgumentValue (mediaStartTimeUs);
				__args [9] = new JniArgumentValue (mediaEndTimeUs);
				__args [10] = new JniArgumentValue (elapsedRealtimeMs);
				__args [11] = new JniArgumentValue (loadDurationMs);
				__args [12] = new JniArgumentValue (bytesLoaded);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadCompleted' and count(parameter)=7 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
		[Register ("loadCompleted", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IJJJ)V", "")]
		public unsafe void LoadCompleted (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, int dataType, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded)
		{
			const string __id = "loadCompleted.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IJJJ)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (dataType);
				__args [4] = new JniArgumentValue (elapsedRealtimeMs);
				__args [5] = new JniArgumentValue (loadDurationMs);
				__args [6] = new JniArgumentValue (bytesLoaded);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadCompleted' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.LoadEventInfo'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.MediaLoadData']]"
		[Register ("loadCompleted", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V", "")]
		public unsafe void LoadCompleted (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerLoadEventInfo loadEventInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData mediaLoadData)
		{
			const string __id = "loadCompleted.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((loadEventInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadEventInfo).Handle);
				__args [1] = new JniArgumentValue ((mediaLoadData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaLoadData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (loadEventInfo);
				global::System.GC.KeepAlive (mediaLoadData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadError' and count(parameter)=15 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.Object'] and parameter[9][@type='long'] and parameter[10][@type='long'] and parameter[11][@type='long'] and parameter[12][@type='long'] and parameter[13][@type='long'] and parameter[14][@type='java.io.IOException'] and parameter[15][@type='boolean']]"
		[Register ("loadError", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJJJLjava/io/IOException;Z)V", "")]
		public unsafe void LoadError (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, int dataType, int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long mediaStartTimeUs, long mediaEndTimeUs, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded, global::Java.IO.IOException error, bool wasCanceled)
		{
			const string __id = "loadError.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJJJLjava/io/IOException;Z)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [15];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (dataType);
				__args [4] = new JniArgumentValue (trackType);
				__args [5] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [6] = new JniArgumentValue (trackSelectionReason);
				__args [7] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [8] = new JniArgumentValue (mediaStartTimeUs);
				__args [9] = new JniArgumentValue (mediaEndTimeUs);
				__args [10] = new JniArgumentValue (elapsedRealtimeMs);
				__args [11] = new JniArgumentValue (loadDurationMs);
				__args [12] = new JniArgumentValue (bytesLoaded);
				__args [13] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				__args [14] = new JniArgumentValue (wasCanceled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
				global::System.GC.KeepAlive (error);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadError' and count(parameter)=9 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='java.io.IOException'] and parameter[9][@type='boolean']]"
		[Register ("loadError", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IJJJLjava/io/IOException;Z)V", "")]
		public unsafe void LoadError (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, int dataType, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded, global::Java.IO.IOException error, bool wasCanceled)
		{
			const string __id = "loadError.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;IJJJLjava/io/IOException;Z)V";
			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (dataType);
				__args [4] = new JniArgumentValue (elapsedRealtimeMs);
				__args [5] = new JniArgumentValue (loadDurationMs);
				__args [6] = new JniArgumentValue (bytesLoaded);
				__args [7] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				__args [8] = new JniArgumentValue (wasCanceled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
				global::System.GC.KeepAlive (error);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadError' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.LoadEventInfo'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.MediaLoadData'] and parameter[3][@type='java.io.IOException'] and parameter[4][@type='boolean']]"
		[Register ("loadError", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;Ljava/io/IOException;Z)V", "")]
		public unsafe void LoadError (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerLoadEventInfo loadEventInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData mediaLoadData, global::Java.IO.IOException error, bool wasCanceled)
		{
			const string __id = "loadError.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;Ljava/io/IOException;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((loadEventInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadEventInfo).Handle);
				__args [1] = new JniArgumentValue ((mediaLoadData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaLoadData).Handle);
				__args [2] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				__args [3] = new JniArgumentValue (wasCanceled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (loadEventInfo);
				global::System.GC.KeepAlive (mediaLoadData);
				global::System.GC.KeepAlive (error);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadStarted' and count(parameter)=9 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.Object'] and parameter[7][@type='long'] and parameter[8][@type='long'] and parameter[9][@type='long']]"
		[Register ("loadStarted", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJ)V", "")]
		public unsafe void LoadStarted (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, int dataType, int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long mediaStartTimeUs, long mediaEndTimeUs, long elapsedRealtimeMs)
		{
			const string __id = "loadStarted.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue (dataType);
				__args [2] = new JniArgumentValue (trackType);
				__args [3] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [4] = new JniArgumentValue (trackSelectionReason);
				__args [5] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [6] = new JniArgumentValue (mediaStartTimeUs);
				__args [7] = new JniArgumentValue (mediaEndTimeUs);
				__args [8] = new JniArgumentValue (elapsedRealtimeMs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadStarted' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("loadStarted", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;IJ)V", "")]
		public unsafe void LoadStarted (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, int dataType, long elapsedRealtimeMs)
		{
			const string __id = "loadStarted.(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue (dataType);
				__args [2] = new JniArgumentValue (elapsedRealtimeMs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='loadStarted' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.LoadEventInfo'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.MediaLoadData']]"
		[Register ("loadStarted", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V", "")]
		public unsafe void LoadStarted (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerLoadEventInfo loadEventInfo, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData mediaLoadData)
		{
			const string __id = "loadStarted.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((loadEventInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadEventInfo).Handle);
				__args [1] = new JniArgumentValue ((mediaLoadData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaLoadData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (loadEventInfo);
				global::System.GC.KeepAlive (mediaLoadData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='mediaPeriodCreated' and count(parameter)=0]"
		[Register ("mediaPeriodCreated", "()V", "")]
		public unsafe void MediaPeriodCreated ()
		{
			const string __id = "mediaPeriodCreated.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='mediaPeriodReleased' and count(parameter)=0]"
		[Register ("mediaPeriodReleased", "()V", "")]
		public unsafe void MediaPeriodReleased ()
		{
			const string __id = "mediaPeriodReleased.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='readingStarted' and count(parameter)=0]"
		[Register ("readingStarted", "()V", "")]
		public unsafe void ReadingStarted ()
		{
			const string __id = "readingStarted.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener']]"
		[Register ("removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V", "")]
		public unsafe void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListener eventListener)
		{
			const string __id = "removeEventListener.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='upstreamDiscarded' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener.MediaLoadData']]"
		[Register ("upstreamDiscarded", "(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V", "")]
		public unsafe void UpstreamDiscarded (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData mediaLoadData)
		{
			const string __id = "upstreamDiscarded.(Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaLoadData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaLoadData).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaLoadData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='upstreamDiscarded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("upstreamDiscarded", "(IJJ)V", "")]
		public unsafe void UpstreamDiscarded (int trackType, long mediaStartTimeUs, long mediaEndTimeUs)
		{
			const string __id = "upstreamDiscarded.(IJJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (trackType);
				__args [1] = new JniArgumentValue (mediaStartTimeUs);
				__args [2] = new JniArgumentValue (mediaEndTimeUs);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.EventDispatcher']/method[@name='withParameters' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[3][@type='long']]"
		[Register ("withParameters", "(ILcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher WithParameters (int windowIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId mediaPeriodId, long mediaTimeOffsetMs)
		{
			const string __id = "withParameters.(ILcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;J)Lcom/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue ((mediaPeriodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaPeriodId).Handle);
				__args [2] = new JniArgumentValue (mediaTimeOffsetMs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mediaPeriodId);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo", DoNotGenerateAcw=true)]
	public sealed partial class MediaSourceEventListenerLoadEventInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/field[@name='bytesLoaded']"
		[Register ("bytesLoaded")]
		public long BytesLoaded {
			get {
				const string __id = "bytesLoaded.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bytesLoaded.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/field[@name='dataSpec']"
		[Register ("dataSpec")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest DataSpec {
			get {
				const string __id = "dataSpec.Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dataSpec.Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/field[@name='elapsedRealtimeMs']"
		[Register ("elapsedRealtimeMs")]
		public long ElapsedRealtimeMs {
			get {
				const string __id = "elapsedRealtimeMs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "elapsedRealtimeMs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/field[@name='loadDurationMs']"
		[Register ("loadDurationMs")]
		public long LoadDurationMs {
			get {
				const string __id = "loadDurationMs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "loadDurationMs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/field[@name='responseHeaders']"
		[Register ("responseHeaders")]
		public global::System.Collections.IDictionary ResponseHeaders {
			get {
				const string __id = "responseHeaders.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "responseHeaders.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/field[@name='uri']"
		[Register ("uri")]
		public global::Android.Net.Uri Uri {
			get {
				const string __id = "uri.Landroid/net/Uri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Landroid/net/Uri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo", typeof (MediaSourceEventListenerLoadEventInfo));

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

		internal MediaSourceEventListenerLoadEventInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.LoadEventInfo']/constructor[@name='MediaSourceEventListener.LoadEventInfo' and count(parameter)=6 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;JJJ)V", "")]
		public unsafe MediaSourceEventListenerLoadEventInfo (global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, global::Android.Net.Uri uri, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> responseHeaders, long elapsedRealtimeMs, long loadDurationMs, long bytesLoaded) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Landroid/net/Uri;Ljava/util/Map;JJJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_responseHeaders = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (responseHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_responseHeaders);
				__args [3] = new JniArgumentValue (elapsedRealtimeMs);
				__args [4] = new JniArgumentValue (loadDurationMs);
				__args [5] = new JniArgumentValue (bytesLoaded);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_responseHeaders);
				global::System.GC.KeepAlive (dataSpec);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (responseHeaders);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData", DoNotGenerateAcw=true)]
	public sealed partial class MediaSourceEventListenerMediaLoadData : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='dataType']"
		[Register ("dataType")]
		public int DataType {
			get {
				const string __id = "dataType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "dataType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='mediaEndTimeMs']"
		[Register ("mediaEndTimeMs")]
		public long MediaEndTimeMs {
			get {
				const string __id = "mediaEndTimeMs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mediaEndTimeMs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='mediaStartTimeMs']"
		[Register ("mediaStartTimeMs")]
		public long MediaStartTimeMs {
			get {
				const string __id = "mediaStartTimeMs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mediaStartTimeMs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='trackFormat']"
		[Register ("trackFormat")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Format TrackFormat {
			get {
				const string __id = "trackFormat.Lcom/example/androidtvlibrary/main/adapter/Format;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackFormat.Lcom/example/androidtvlibrary/main/adapter/Format;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='trackSelectionData']"
		[Register ("trackSelectionData")]
		public global::Java.Lang.Object TrackSelectionData {
			get {
				const string __id = "trackSelectionData.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackSelectionData.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='trackSelectionReason']"
		[Register ("trackSelectionReason")]
		public int TrackSelectionReason {
			get {
				const string __id = "trackSelectionReason.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "trackSelectionReason.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/field[@name='trackType']"
		[Register ("trackType")]
		public int TrackType {
			get {
				const string __id = "trackType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "trackType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData", typeof (MediaSourceEventListenerMediaLoadData));

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

		internal MediaSourceEventListenerMediaLoadData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MediaSourceEventListener.MediaLoadData']/constructor[@name='MediaSourceEventListener.MediaLoadData' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
		[Register (".ctor", "(IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJ)V", "")]
		public unsafe MediaSourceEventListenerMediaLoadData (int dataType, int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.Format trackFormat, int trackSelectionReason, global::Java.Lang.Object trackSelectionData, long mediaStartTimeMs, long mediaEndTimeMs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILcom/example/androidtvlibrary/main/adapter/Format;ILjava/lang/Object;JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (dataType);
				__args [1] = new JniArgumentValue (trackType);
				__args [2] = new JniArgumentValue ((trackFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackFormat).Handle);
				__args [3] = new JniArgumentValue (trackSelectionReason);
				__args [4] = new JniArgumentValue ((trackSelectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionData).Handle);
				__args [5] = new JniArgumentValue (mediaStartTimeMs);
				__args [6] = new JniArgumentValue (mediaEndTimeMs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (trackFormat);
				global::System.GC.KeepAlive (trackSelectionData);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='MediaSourceEventListener']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaSourceEventListenerInvoker")]
	public partial interface IMediaSourceEventListener : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener", DoNotGenerateAcw=true)]
	internal partial class IMediaSourceEventListenerInvoker : global::Java.Lang.Object, IMediaSourceEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener", typeof (IMediaSourceEventListenerInvoker));

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

		public static IMediaSourceEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaSourceEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.MediaSourceEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaSourceEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListenerImplementor")]
	internal sealed partial class IMediaSourceEventListenerImplementor : global::Java.Lang.Object, IMediaSourceEventListener {
		public IMediaSourceEventListenerImplementor () : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}

		internal static bool __IsEmpty (IMediaSourceEventListenerImplementor value)
		{
			return true;
		}

	}
}
