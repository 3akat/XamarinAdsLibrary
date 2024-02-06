using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter", DoNotGenerateAcw=true)]
	public sealed partial class DefaultBandwidthMeter : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter, global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_INITIAL_BITRATE_COUNTRY_GROUPS']"
		[Register ("DEFAULT_INITIAL_BITRATE_COUNTRY_GROUPS")]
		public static global::System.Collections.IDictionary DefaultInitialBitrateCountryGroups {
			get {
				const string __id = "DEFAULT_INITIAL_BITRATE_COUNTRY_GROUPS.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_INITIAL_BITRATE_ESTIMATE']"
		[Register ("DEFAULT_INITIAL_BITRATE_ESTIMATE")]
		public const long DefaultInitialBitrateEstimate = (long) 1000000;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_INITIAL_BITRATE_ESTIMATES_2G']"
		[Register ("DEFAULT_INITIAL_BITRATE_ESTIMATES_2G")]
		public static IList<long> DefaultInitialBitrateEstimates2g {
			get {
				const string __id = "DEFAULT_INITIAL_BITRATE_ESTIMATES_2G.[J";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_INITIAL_BITRATE_ESTIMATES_3G']"
		[Register ("DEFAULT_INITIAL_BITRATE_ESTIMATES_3G")]
		public static IList<long> DefaultInitialBitrateEstimates3g {
			get {
				const string __id = "DEFAULT_INITIAL_BITRATE_ESTIMATES_3G.[J";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_INITIAL_BITRATE_ESTIMATES_4G']"
		[Register ("DEFAULT_INITIAL_BITRATE_ESTIMATES_4G")]
		public static IList<long> DefaultInitialBitrateEstimates4g {
			get {
				const string __id = "DEFAULT_INITIAL_BITRATE_ESTIMATES_4G.[J";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_INITIAL_BITRATE_ESTIMATES_WIFI']"
		[Register ("DEFAULT_INITIAL_BITRATE_ESTIMATES_WIFI")]
		public static IList<long> DefaultInitialBitrateEstimatesWifi {
			get {
				const string __id = "DEFAULT_INITIAL_BITRATE_ESTIMATES_WIFI.[J";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/field[@name='DEFAULT_SLIDING_WINDOW_MAX_WEIGHT']"
		[Register ("DEFAULT_SLIDING_WINDOW_MAX_WEIGHT")]
		public const int DefaultSlidingWindowMaxWeight = (int) 2000;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/constructor[@name='DefaultBandwidthMeter.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter Build ()
			{
				const string __id = "build.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='setClock' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
			[Register ("setClock", "(Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder SetClock (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock)
			{
				const string __id = "setClock.(Lcom/example/androidtvlibrary/main/adapter/wow/Clock;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (clock);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='setInitialBitrateEstimate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("setInitialBitrateEstimate", "(IJ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder SetInitialBitrateEstimate (int networkType, long initialBitrateEstimate)
			{
				const string __id = "setInitialBitrateEstimate.(IJ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (networkType);
					__args [1] = new JniArgumentValue (initialBitrateEstimate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='setInitialBitrateEstimate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInitialBitrateEstimate", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder SetInitialBitrateEstimate (string countryCode)
			{
				const string __id = "setInitialBitrateEstimate.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;";
				IntPtr native_countryCode = JNIEnv.NewString (countryCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_countryCode);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_countryCode);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='setInitialBitrateEstimate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setInitialBitrateEstimate", "(J)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder SetInitialBitrateEstimate (long initialBitrateEstimate)
			{
				const string __id = "setInitialBitrateEstimate.(J)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (initialBitrateEstimate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='setResetOnNetworkTypeChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setResetOnNetworkTypeChange", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder SetResetOnNetworkTypeChange (bool resetOnNetworkTypeChange)
			{
				const string __id = "setResetOnNetworkTypeChange.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resetOnNetworkTypeChange);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter.Builder']/method[@name='setSlidingWindowMaxWeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSlidingWindowMaxWeight", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder SetSlidingWindowMaxWeight (int slidingWindowMaxWeight)
			{
				const string __id = "setSlidingWindowMaxWeight.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (slidingWindowMaxWeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter", typeof (DefaultBandwidthMeter));

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

		internal DefaultBandwidthMeter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/constructor[@name='DefaultBandwidthMeter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultBandwidthMeter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe long BitrateEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='getBitrateEstimate' and count(parameter)=0]"
			[Register ("getBitrateEstimate", "()J", "")]
			get {
				const string __id = "getBitrateEstimate.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener TransferListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='getTransferListener' and count(parameter)=0]"
			[Register ("getTransferListener", "()Lcom/example/androidtvlibrary/main/adapter/TransferListener;", "")]
			get {
				const string __id = "getTransferListener.()Lcom/example/androidtvlibrary/main/adapter/TransferListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITransferListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter.EventListener']]"
		[Register ("addEventListener", "(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V", "")]
		public unsafe void AddEventListener (global::Android.OS.Handler eventHandler, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener eventListener)
		{
			const string __id = "addEventListener.(Landroid/os/Handler;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				__args [1] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventHandler);
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='getSingletonInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSingletonInstance", "(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter GetSingletonInstance (global::Android.Content.Context context)
		{
			const string __id = "getSingletonInstance.(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultBandwidthMeter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultBandwidthMeter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='onBytesTransferred' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("onBytesTransferred", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;ZI)V", "")]
		public unsafe void OnBytesTransferred (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource source, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, bool isNetwork, int bytes)
		{
			const string __id = "onBytesTransferred.(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (isNetwork);
				__args [3] = new JniArgumentValue (bytes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='onTransferEnd' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean']]"
		[Register ("onTransferEnd", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V", "")]
		public unsafe void OnTransferEnd (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource source, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, bool isNetwork)
		{
			const string __id = "onTransferEnd.(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (isNetwork);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='onTransferInitializing' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean']]"
		[Register ("onTransferInitializing", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V", "")]
		public unsafe void OnTransferInitializing (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource source, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, bool isNetwork)
		{
			const string __id = "onTransferInitializing.(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (isNetwork);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='onTransferStart' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DataSpecTest'] and parameter[3][@type='boolean']]"
		[Register ("onTransferStart", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V", "")]
		public unsafe void OnTransferStart (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource source, global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest dataSpec, bool isNetwork)
		{
			const string __id = "onTransferStart.(Lcom/example/androidtvlibrary/main/adapter/DataSource;Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((dataSpec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSpec).Handle);
				__args [2] = new JniArgumentValue (isNetwork);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
				global::System.GC.KeepAlive (dataSpec);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter.EventListener']]"
		[Register ("removeEventListener", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V", "")]
		public unsafe void RemoveEventListener (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeterEventListener eventListener)
		{
			const string __id = "removeEventListener.(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter$EventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultBandwidthMeter']/method[@name='setNetworkTypeOverride' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNetworkTypeOverride", "(I)V", "")]
		public unsafe void SetNetworkTypeOverride ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"NetworkTypeUnknown", "NetworkTypeOffline", "NetworkTypeWifi", "NetworkType2g", "NetworkType3g", "NetworkType4g", "NetworkType5g", "NetworkTypeCellularUnknown", "NetworkTypeEthernet", "NetworkTypeOther"})]
		int networkType)
		{
			const string __id = "setNetworkTypeOverride.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (networkType);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
