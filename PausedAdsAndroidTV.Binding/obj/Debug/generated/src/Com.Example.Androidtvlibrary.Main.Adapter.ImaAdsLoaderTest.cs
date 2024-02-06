using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest", DoNotGenerateAcw=true)]
	public sealed partial class ImaAdsLoaderTest : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTest, global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayerEventListener {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/field[@name='TYPE_DASH']"
		[Register ("TYPE_DASH")]
		public const int TypeDash = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/field[@name='TYPE_HLS']"
		[Register ("TYPE_HLS")]
		public const int TypeHls = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/field[@name='TYPE_OTHER']"
		[Register ("TYPE_OTHER")]
		public const int TypeOther = (int) 4;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/field[@name='DEFAULT_AD_PRELOAD_TIMEOUT_MS']"
			[Register ("DEFAULT_AD_PRELOAD_TIMEOUT_MS")]
			public const long DefaultAdPreloadTimeoutMs = (long) 10000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/field[@name='MILLIS_PER_SECOND']"
			[Register ("MILLIS_PER_SECOND")]
			public const long MillisPerSecond = (long) 1000;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/constructor[@name='ImaAdsLoaderTest.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='buildForAdTag' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("buildForAdTag", "(Landroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest BuildForAdTag (global::Android.Net.Uri adTagUri)
			{
				const string __id = "buildForAdTag.(Landroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((adTagUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adTagUri).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (adTagUri);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='buildForAdsResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("buildForAdsResponse", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest BuildForAdsResponse (string adsResponse)
			{
				const string __id = "buildForAdsResponse.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest;";
				IntPtr native_adsResponse = JNIEnv.NewString (adsResponse);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_adsResponse);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_adsResponse);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='setAdPreloadTimeoutMs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAdPreloadTimeoutMs", "(J)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder SetAdPreloadTimeoutMs (long adPreloadTimeoutMs)
			{
				const string __id = "setAdPreloadTimeoutMs.(J)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (adPreloadTimeoutMs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='setFocusSkipButtonWhenAvailable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFocusSkipButtonWhenAvailable", "(Z)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder SetFocusSkipButtonWhenAvailable (bool focusSkipButtonWhenAvailable)
			{
				const string __id = "setFocusSkipButtonWhenAvailable.(Z)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (focusSkipButtonWhenAvailable);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='setMaxMediaBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxMediaBitrate", "(I)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder SetMaxMediaBitrate (int bitrate)
			{
				const string __id = "setMaxMediaBitrate.(I)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bitrate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='setMediaLoadTimeoutMs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMediaLoadTimeoutMs", "(I)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder SetMediaLoadTimeoutMs (int mediaLoadTimeoutMs)
			{
				const string __id = "setMediaLoadTimeoutMs.(I)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (mediaLoadTimeoutMs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='setPlayAdBeforeStartPosition' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPlayAdBeforeStartPosition", "(Z)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder SetPlayAdBeforeStartPosition (bool playAdBeforeStartPosition)
			{
				const string __id = "setPlayAdBeforeStartPosition.(Z)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (playAdBeforeStartPosition);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest.Builder']/method[@name='setVastLoadTimeoutMs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVastLoadTimeoutMs", "(I)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder SetVastLoadTimeoutMs (int vastLoadTimeoutMs)
			{
				const string __id = "setVastLoadTimeoutMs.(I)Lcom/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (vastLoadTimeoutMs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ImaAdsLoaderTest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/ImaAdsLoaderTest", typeof (ImaAdsLoaderTest));

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

		internal ImaAdsLoaderTest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/constructor[@name='ImaAdsLoaderTest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public unsafe ImaAdsLoaderTest (global::Android.Content.Context context, global::Android.Net.Uri adTagUri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/net/Uri;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((adTagUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adTagUri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (adTagUri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkState", "(Z)V", "")]
		public static unsafe void CheckState (bool expression)
		{
			const string __id = "checkState.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expression);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='createHandler' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Android.OS.Looper looper, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "createHandler.(Landroid/os/Looper;Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (looper);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='handlePrepareError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.io.IOException']]"
		[Register ("handlePrepareError", "(IILjava/io/IOException;)V", "")]
		public unsafe void HandlePrepareError (int adGroupIndex, int adIndexInAdGroup, global::Java.IO.IOException exception)
		{
			const string __id = "handlePrepareError.(IILjava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adIndexInAdGroup);
				__args [2] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='linearSearch' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("linearSearch", "([JJ)I", "")]
		public static unsafe int LinearSearch (long[] array, long value)
		{
			const string __id = "linearSearch.([JJ)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='msToUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("msToUs", "(J)J", "")]
		public static unsafe long MsToUs (long timeMs)
		{
			const string __id = "msToUs.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeMs);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='onPlayerStateChanged' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("onPlayerStateChanged", "(ZI)V", "")]
		public unsafe void OnPlayerStateChanged (bool playWhenReady, int playbackState)
		{
			const string __id = "onPlayerStateChanged.(ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (playWhenReady);
				__args [1] = new JniArgumentValue (playbackState);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='onPositionDiscontinuity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPositionDiscontinuity", "(I)V", "")]
		public unsafe void OnPositionDiscontinuity (int reason)
		{
			const string __id = "onPositionDiscontinuity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (reason);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='onTimelineChanged' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline'] and parameter[2][@type='int']]"
		[Register ("onTimelineChanged", "(Lcom/example/androidtvlibrary/main/adapter/Timeline;I)V", "")]
		public unsafe void OnTimelineChanged (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"TimelineChangeReasonPrepared", "TimelineChangeReasonReset", "TimelineChangeReasonDynamic"})]
		int reason)
		{
			const string __id = "onTimelineChanged.(Lcom/example/androidtvlibrary/main/adapter/Timeline;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				__args [1] = new JniArgumentValue (reason);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timeline);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='requestAds' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("requestAds", "(Landroid/view/ViewGroup;)V", "")]
		public unsafe void RequestAds (global::Android.Views.ViewGroup adViewGroup)
		{
			const string __id = "requestAds.(Landroid/view/ViewGroup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adViewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adViewGroup).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adViewGroup);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='setPlayer' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TestPlayer']]"
		[Register ("setPlayer", "(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;)V", "")]
		public unsafe void SetPlayer (global::Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer player)
		{
			const string __id = "setPlayer.(Lcom/example/androidtvlibrary/main/adapter/TestPlayer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((player == null) ? IntPtr.Zero : ((global::Java.Lang.Object) player).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (player);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='setSupportedContentTypes' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setSupportedContentTypes", "([I)V", "")]
		public unsafe void SetSupportedContentTypes (params int[] contentTypes)
		{
			const string __id = "setSupportedContentTypes.([I)V";
			IntPtr native_contentTypes = JNIEnv.NewArray (contentTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_contentTypes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (contentTypes != null) {
					JNIEnv.CopyArray (native_contentTypes, contentTypes);
					JNIEnv.DeleteLocalRef (native_contentTypes);
				}
				global::System.GC.KeepAlive (contentTypes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='start' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.AdsLoaderTest.EventListener'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.AdsLoaderTest.AdViewProvider']]"
		[Register ("start", "(Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener;Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider;)V", "")]
		public unsafe void Start (global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestEventListener eventListener, global::Com.Example.Androidtvlibrary.Main.Adapter.IAdsLoaderTestAdViewProvider adViewProvider)
		{
			const string __id = "start.(Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$EventListener;Lcom/example/androidtvlibrary/main/adapter/AdsLoaderTest$AdViewProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [1] = new JniArgumentValue ((adViewProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adViewProvider).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventListener);
				global::System.GC.KeepAlive (adViewProvider);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='ImaAdsLoaderTest']/method[@name='usToMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("usToMs", "(J)J", "")]
		public static unsafe long UsToMs (long timeUs)
		{
			const string __id = "usToMs.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
