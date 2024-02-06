using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/AdaptiveTrackSelection", DoNotGenerateAcw=true)]
	public partial class AdaptiveTrackSelection : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.BaseTrackSelection {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/field[@name='DEFAULT_BANDWIDTH_FRACTION']"
		[Register ("DEFAULT_BANDWIDTH_FRACTION")]
		public const float DefaultBandwidthFraction = (float) 0.699999988;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/field[@name='DEFAULT_BUFFERED_FRACTION_TO_LIVE_EDGE_FOR_QUALITY_INCREASE']"
		[Register ("DEFAULT_BUFFERED_FRACTION_TO_LIVE_EDGE_FOR_QUALITY_INCREASE")]
		public const float DefaultBufferedFractionToLiveEdgeForQualityIncrease = (float) 0.75;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/field[@name='DEFAULT_MAX_DURATION_FOR_QUALITY_DECREASE_MS']"
		[Register ("DEFAULT_MAX_DURATION_FOR_QUALITY_DECREASE_MS")]
		public const int DefaultMaxDurationForQualityDecreaseMs = (int) 25000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/field[@name='DEFAULT_MIN_DURATION_FOR_QUALITY_INCREASE_MS']"
		[Register ("DEFAULT_MIN_DURATION_FOR_QUALITY_INCREASE_MS")]
		public const int DefaultMinDurationForQualityIncreaseMs = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/field[@name='DEFAULT_MIN_DURATION_TO_RETAIN_AFTER_DISCARD_MS']"
		[Register ("DEFAULT_MIN_DURATION_TO_RETAIN_AFTER_DISCARD_MS")]
		public const int DefaultMinDurationToRetainAfterDiscardMs = (int) 25000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/field[@name='DEFAULT_MIN_TIME_BETWEEN_BUFFER_REEVALUTATION_MS']"
		[Register ("DEFAULT_MIN_TIME_BETWEEN_BUFFER_REEVALUTATION_MS")]
		public const long DefaultMinTimeBetweenBufferReevalutationMs = (long) 2000;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/AdaptiveTrackSelection$Factory", DoNotGenerateAcw=true)]
		public partial class Factory : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactory {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/AdaptiveTrackSelection$Factory", typeof (Factory));

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

			protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/constructor[@name='AdaptiveTrackSelection.Factory' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Factory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/constructor[@name='AdaptiveTrackSelection.Factory' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe Factory (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bandwidthMeter);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/constructor[@name='AdaptiveTrackSelection.Factory' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;IIIF)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe Factory (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter, int minDurationForQualityIncreaseMs, int maxDurationForQualityDecreaseMs, int minDurationToRetainAfterDiscardMs, float bandwidthFraction) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;IIIF)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
					__args [1] = new JniArgumentValue (minDurationForQualityIncreaseMs);
					__args [2] = new JniArgumentValue (maxDurationForQualityDecreaseMs);
					__args [3] = new JniArgumentValue (minDurationToRetainAfterDiscardMs);
					__args [4] = new JniArgumentValue (bandwidthFraction);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bandwidthMeter);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/constructor[@name='AdaptiveTrackSelection.Factory' and count(parameter)=8 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='long'] and parameter[8][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;IIIFFJLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe Factory (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter, int minDurationForQualityIncreaseMs, int maxDurationForQualityDecreaseMs, int minDurationToRetainAfterDiscardMs, float bandwidthFraction, float bufferedFractionToLiveEdgeForQualityIncrease, long minTimeBetweenBufferReevaluationMs, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;IIIFFJLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
					__args [1] = new JniArgumentValue (minDurationForQualityIncreaseMs);
					__args [2] = new JniArgumentValue (maxDurationForQualityDecreaseMs);
					__args [3] = new JniArgumentValue (minDurationToRetainAfterDiscardMs);
					__args [4] = new JniArgumentValue (bandwidthFraction);
					__args [5] = new JniArgumentValue (bufferedFractionToLiveEdgeForQualityIncrease);
					__args [6] = new JniArgumentValue (minTimeBetweenBufferReevaluationMs);
					__args [7] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (bandwidthMeter);
					global::System.GC.KeepAlive (clock);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/constructor[@name='AdaptiveTrackSelection.Factory' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
			[Register (".ctor", "(IIIF)V", "")]
			public unsafe Factory (int minDurationForQualityIncreaseMs, int maxDurationForQualityDecreaseMs, int minDurationToRetainAfterDiscardMs, float bandwidthFraction) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIIF)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (minDurationForQualityIncreaseMs);
					__args [1] = new JniArgumentValue (maxDurationForQualityDecreaseMs);
					__args [2] = new JniArgumentValue (minDurationToRetainAfterDiscardMs);
					__args [3] = new JniArgumentValue (bandwidthFraction);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/constructor[@name='AdaptiveTrackSelection.Factory' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='long'] and parameter[7][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
			[Register (".ctor", "(IIIFFJLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V", "")]
			public unsafe Factory (int minDurationForQualityIncreaseMs, int maxDurationForQualityDecreaseMs, int minDurationToRetainAfterDiscardMs, float bandwidthFraction, float bufferedFractionToLiveEdgeForQualityIncrease, long minTimeBetweenBufferReevaluationMs, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIIFFJLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (minDurationForQualityIncreaseMs);
					__args [1] = new JniArgumentValue (maxDurationForQualityDecreaseMs);
					__args [2] = new JniArgumentValue (minDurationToRetainAfterDiscardMs);
					__args [3] = new JniArgumentValue (bandwidthFraction);
					__args [4] = new JniArgumentValue (bufferedFractionToLiveEdgeForQualityIncrease);
					__args [5] = new JniArgumentValue (minTimeBetweenBufferReevaluationMs);
					__args [6] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (clock);
				}
			}

			static Delegate cb_createAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayII;
#pragma warning disable 0169
			static Delegate GetCreateAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayIIHandler ()
			{
				if (cb_createAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayII == null)
					cb_createAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_L) n_CreateAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayII);
				return cb_createAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayII;
			}

			static IntPtr n_CreateAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_group, IntPtr native_bandwidthMeter, IntPtr native_tracks, int totalFixedTrackBandwidth)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var group = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup> (native_group, JniHandleOwnership.DoNotTransfer);
				var bandwidthMeter = (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (native_bandwidthMeter, JniHandleOwnership.DoNotTransfer);
				var tracks = (int[]) JNIEnv.GetArray (native_tracks, JniHandleOwnership.DoNotTransfer, typeof (int));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAdaptiveTrackSelection (group, bandwidthMeter, tracks, totalFixedTrackBandwidth));
				if (tracks != null)
					JNIEnv.CopyArray (tracks, native_tracks);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/method[@name='createAdaptiveTrackSelection' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
			[Register ("createAdaptiveTrackSelection", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;[II)Lcom/example/androidtvlibrary/main/adapter/wow/AdaptiveTrackSelection;", "GetCreateAdaptiveTrackSelection_Lcom_example_androidtvlibrary_main_adapter_TrackGroup_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_arrayIIHandler")]
			protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection CreateAdaptiveTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter, int[] tracks, int totalFixedTrackBandwidth)
			{
				const string __id = "createAdaptiveTrackSelection.(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;[II)Lcom/example/androidtvlibrary/main/adapter/wow/AdaptiveTrackSelection;";
				IntPtr native_tracks = JNIEnv.NewArray (tracks);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
					__args [1] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
					__args [2] = new JniArgumentValue (native_tracks);
					__args [3] = new JniArgumentValue (totalFixedTrackBandwidth);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (tracks != null) {
						JNIEnv.CopyArray (native_tracks, tracks);
						JNIEnv.DeleteLocalRef (native_tracks);
					}
					global::System.GC.KeepAlive (group);
					global::System.GC.KeepAlive (bandwidthMeter);
					global::System.GC.KeepAlive (tracks);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection.Factory']/method[@name='createTrackSelections' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackSelection.Definition[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
			[Register ("createTrackSelections", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] CreateTrackSelections (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition[] definitions, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter)
			{
				const string __id = "createTrackSelections.([Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;";
				IntPtr native_definitions = JNIEnv.NewArray (definitions);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_definitions);
					__args [1] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection));
				} finally {
					if (definitions != null) {
						JNIEnv.CopyArray (native_definitions, definitions);
						JNIEnv.DeleteLocalRef (native_definitions);
					}
					global::System.GC.KeepAlive (definitions);
					global::System.GC.KeepAlive (bandwidthMeter);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/AdaptiveTrackSelection", typeof (AdaptiveTrackSelection));

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

		protected AdaptiveTrackSelection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/constructor[@name='AdaptiveTrackSelection' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int[]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[ILcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V", "")]
		public unsafe AdaptiveTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, int[] tracks, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[ILcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tracks = JNIEnv.NewArray (tracks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (native_tracks);
				__args [2] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (tracks != null) {
					JNIEnv.CopyArray (native_tracks, tracks);
					JNIEnv.DeleteLocalRef (native_tracks);
				}
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (tracks);
				global::System.GC.KeepAlive (bandwidthMeter);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/constructor[@name='AdaptiveTrackSelection' and count(parameter)=11 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int[]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='long'] and parameter[11][@type='com.example.androidtvlibrary.main.adapter.wow.Clock']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[ILcom/example/androidtvlibrary/main/adapter/BandwidthMeter;JJJJFFJLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V", "")]
		public unsafe AdaptiveTrackSelection (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, int[] tracks, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter, long reservedBandwidth, long minDurationForQualityIncreaseMs, long maxDurationForQualityDecreaseMs, long minDurationToRetainAfterDiscardMs, float bandwidthFraction, float bufferedFractionToLiveEdgeForQualityIncrease, long minTimeBetweenBufferReevaluationMs, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IClock clock) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[ILcom/example/androidtvlibrary/main/adapter/BandwidthMeter;JJJJFFJLcom/example/androidtvlibrary/main/adapter/wow/Clock;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tracks = JNIEnv.NewArray (tracks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (native_tracks);
				__args [2] = new JniArgumentValue ((bandwidthMeter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bandwidthMeter).Handle);
				__args [3] = new JniArgumentValue (reservedBandwidth);
				__args [4] = new JniArgumentValue (minDurationForQualityIncreaseMs);
				__args [5] = new JniArgumentValue (maxDurationForQualityDecreaseMs);
				__args [6] = new JniArgumentValue (minDurationToRetainAfterDiscardMs);
				__args [7] = new JniArgumentValue (bandwidthFraction);
				__args [8] = new JniArgumentValue (bufferedFractionToLiveEdgeForQualityIncrease);
				__args [9] = new JniArgumentValue (minTimeBetweenBufferReevaluationMs);
				__args [10] = new JniArgumentValue ((clock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clock).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (tracks != null) {
					JNIEnv.CopyArray (native_tracks, tracks);
					JNIEnv.DeleteLocalRef (native_tracks);
				}
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (tracks);
				global::System.GC.KeepAlive (bandwidthMeter);
				global::System.GC.KeepAlive (clock);
			}
		}

		static Delegate cb_getMinDurationToRetainAfterDiscardUs;
#pragma warning disable 0169
		static Delegate GetGetMinDurationToRetainAfterDiscardUsHandler ()
		{
			if (cb_getMinDurationToRetainAfterDiscardUs == null)
				cb_getMinDurationToRetainAfterDiscardUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetMinDurationToRetainAfterDiscardUs);
			return cb_getMinDurationToRetainAfterDiscardUs;
		}

		static long n_GetMinDurationToRetainAfterDiscardUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDurationToRetainAfterDiscardUs;
		}
#pragma warning restore 0169

		protected virtual unsafe long MinDurationToRetainAfterDiscardUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='getMinDurationToRetainAfterDiscardUs' and count(parameter)=0]"
			[Register ("getMinDurationToRetainAfterDiscardUs", "()J", "GetGetMinDurationToRetainAfterDiscardUsHandler")]
			get {
				const string __id = "getMinDurationToRetainAfterDiscardUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedIndexHandler ()
		{
			if (cb_getSelectedIndex == null)
				cb_getSelectedIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedIndex);
			return cb_getSelectedIndex;
		}

		static int n_GetSelectedIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedIndex;
		}
#pragma warning restore 0169

		public override unsafe int SelectedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='getSelectedIndex' and count(parameter)=0]"
			[Register ("getSelectedIndex", "()I", "GetGetSelectedIndexHandler")]
			get {
				const string __id = "getSelectedIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectionData;
#pragma warning disable 0169
		static Delegate GetGetSelectionDataHandler ()
		{
			if (cb_getSelectionData == null)
				cb_getSelectionData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSelectionData);
			return cb_getSelectionData;
		}

		static IntPtr n_GetSelectionData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionData);
		}
#pragma warning restore 0169

		public override unsafe global::Java.Lang.Object SelectionData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='getSelectionData' and count(parameter)=0]"
			[Register ("getSelectionData", "()Ljava/lang/Object;", "GetGetSelectionDataHandler")]
			get {
				const string __id = "getSelectionData.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectionReason;
#pragma warning disable 0169
		static Delegate GetGetSelectionReasonHandler ()
		{
			if (cb_getSelectionReason == null)
				cb_getSelectionReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectionReason);
			return cb_getSelectionReason;
		}

		static int n_GetSelectionReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionReason;
		}
#pragma warning restore 0169

		public override unsafe int SelectionReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='getSelectionReason' and count(parameter)=0]"
			[Register ("getSelectionReason", "()I", "GetGetSelectionReasonHandler")]
			get {
				const string __id = "getSelectionReason.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_canSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJ;
#pragma warning disable 0169
		static Delegate GetCanSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJHandler ()
		{
			if (cb_canSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJ == null)
				cb_canSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIFJ_Z) n_CanSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJ);
			return cb_canSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJ;
		}

		static bool n_CanSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, int trackBitrate, float playbackSpeed, long effectiveBitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_format, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanSelectFormat (format, trackBitrate, playbackSpeed, effectiveBitrate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='canSelectFormat' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='long']]"
		[Register ("canSelectFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;IFJ)Z", "GetCanSelectFormat_Lcom_example_androidtvlibrary_main_adapter_Format_IFJHandler")]
		protected virtual unsafe bool CanSelectFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, int trackBitrate, float playbackSpeed, long effectiveBitrate)
		{
			const string __id = "canSelectFormat.(Lcom/example/androidtvlibrary/main/adapter/Format;IFJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (trackBitrate);
				__args [2] = new JniArgumentValue (playbackSpeed);
				__args [3] = new JniArgumentValue (effectiveBitrate);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_experimental_setBandwidthAllocationCheckpoints_arrayarrayJ;
#pragma warning disable 0169
		static Delegate GetExperimental_setBandwidthAllocationCheckpoints_arrayarrayJHandler ()
		{
			if (cb_experimental_setBandwidthAllocationCheckpoints_arrayarrayJ == null)
				cb_experimental_setBandwidthAllocationCheckpoints_arrayarrayJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Experimental_setBandwidthAllocationCheckpoints_arrayarrayJ);
			return cb_experimental_setBandwidthAllocationCheckpoints_arrayarrayJ;
		}

		static void n_Experimental_setBandwidthAllocationCheckpoints_arrayarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_allocationCheckpoints)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var allocationCheckpoints = (long[][]) JNIEnv.GetArray (native_allocationCheckpoints, JniHandleOwnership.DoNotTransfer, typeof (long[]));
			__this.Experimental_setBandwidthAllocationCheckpoints (allocationCheckpoints);
			if (allocationCheckpoints != null)
				JNIEnv.CopyArray (allocationCheckpoints, native_allocationCheckpoints);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='experimental_setBandwidthAllocationCheckpoints' and count(parameter)=1 and parameter[1][@type='long[][]']]"
		[Register ("experimental_setBandwidthAllocationCheckpoints", "([[J)V", "GetExperimental_setBandwidthAllocationCheckpoints_arrayarrayJHandler")]
		public virtual unsafe void Experimental_setBandwidthAllocationCheckpoints (long[][] allocationCheckpoints)
		{
			const string __id = "experimental_setBandwidthAllocationCheckpoints.([[J)V";
			IntPtr native_allocationCheckpoints = JNIEnv.NewArray (allocationCheckpoints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_allocationCheckpoints);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (allocationCheckpoints != null) {
					JNIEnv.CopyArray (native_allocationCheckpoints, allocationCheckpoints);
					JNIEnv.DeleteLocalRef (native_allocationCheckpoints);
				}
				global::System.GC.KeepAlive (allocationCheckpoints);
			}
		}

		static Delegate cb_shouldEvaluateQueueSize_J;
#pragma warning disable 0169
		static Delegate GetShouldEvaluateQueueSize_JHandler ()
		{
			if (cb_shouldEvaluateQueueSize_J == null)
				cb_shouldEvaluateQueueSize_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_Z) n_ShouldEvaluateQueueSize_J);
			return cb_shouldEvaluateQueueSize_J;
		}

		static bool n_ShouldEvaluateQueueSize_J (IntPtr jnienv, IntPtr native__this, long nowMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldEvaluateQueueSize (nowMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='shouldEvaluateQueueSize' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("shouldEvaluateQueueSize", "(J)Z", "GetShouldEvaluateQueueSize_JHandler")]
		protected virtual unsafe bool ShouldEvaluateQueueSize (long nowMs)
		{
			const string __id = "shouldEvaluateQueueSize.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nowMs);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
#pragma warning disable 0169
		static Delegate GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler ()
		{
			if (cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ == null)
				cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJJLL_V) n_UpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_);
			return cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
		}

		static void n_UpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ (IntPtr jnienv, IntPtr native__this, long playbackPositionUs, long bufferedDurationUs, long availableDurationUs, IntPtr native_queue, IntPtr native_mediaChunkIterators)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.AdaptiveTrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var queue = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.FromJniHandle (native_queue, JniHandleOwnership.DoNotTransfer);
			var mediaChunkIterators = (global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[]) JNIEnv.GetArray (native_mediaChunkIterators, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator));
			__this.UpdateSelectedTrack (playbackPositionUs, bufferedDurationUs, availableDurationUs, queue, mediaChunkIterators);
			if (mediaChunkIterators != null)
				JNIEnv.CopyArray (mediaChunkIterators, native_mediaChunkIterators);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='AdaptiveTrackSelection']/method[@name='updateSelectedTrack' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.MediaChunkIterator[]']]"
		[Register ("updateSelectedTrack", "(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V", "GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler")]
		public override unsafe void UpdateSelectedTrack (long playbackPositionUs, long bufferedDurationUs, long availableDurationUs, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> queue, global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[] mediaChunkIterators)
		{
			const string __id = "updateSelectedTrack.(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V";
			IntPtr native_queue = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.ToLocalJniHandle (queue);
			IntPtr native_mediaChunkIterators = JNIEnv.NewArray (mediaChunkIterators);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (playbackPositionUs);
				__args [1] = new JniArgumentValue (bufferedDurationUs);
				__args [2] = new JniArgumentValue (availableDurationUs);
				__args [3] = new JniArgumentValue (native_queue);
				__args [4] = new JniArgumentValue (native_mediaChunkIterators);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_queue);
				if (mediaChunkIterators != null) {
					JNIEnv.CopyArray (native_mediaChunkIterators, mediaChunkIterators);
					JNIEnv.DeleteLocalRef (native_mediaChunkIterators);
				}
				global::System.GC.KeepAlive (queue);
				global::System.GC.KeepAlive (mediaChunkIterators);
			}
		}

	}
}
