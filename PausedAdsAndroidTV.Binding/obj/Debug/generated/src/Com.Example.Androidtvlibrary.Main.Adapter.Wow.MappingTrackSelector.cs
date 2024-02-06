using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector", DoNotGenerateAcw=true)]
	public abstract partial class MappingTrackSelector : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelector {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo", DoNotGenerateAcw=true)]
		public sealed partial class MappedTrackInfo : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/field[@name='length']"
			[Register ("length")]
			[Obsolete ("deprecated")]
			public int Length {
				get {
					const string __id = "length.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "length.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/field[@name='RENDERER_SUPPORT_EXCEEDS_CAPABILITIES_TRACKS']"
			[Register ("RENDERER_SUPPORT_EXCEEDS_CAPABILITIES_TRACKS")]
			public const int RendererSupportExceedsCapabilitiesTracks = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/field[@name='RENDERER_SUPPORT_NO_TRACKS']"
			[Register ("RENDERER_SUPPORT_NO_TRACKS")]
			public const int RendererSupportNoTracks = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/field[@name='RENDERER_SUPPORT_PLAYABLE_TRACKS']"
			[Register ("RENDERER_SUPPORT_PLAYABLE_TRACKS")]
			public const int RendererSupportPlayableTracks = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/field[@name='RENDERER_SUPPORT_UNSUPPORTED_TRACKS']"
			[Register ("RENDERER_SUPPORT_UNSUPPORTED_TRACKS")]
			public const int RendererSupportUnsupportedTracks = (int) 1;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo", typeof (MappedTrackInfo));

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

			internal MappedTrackInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe int RendererCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getRendererCount' and count(parameter)=0]"
				[Register ("getRendererCount", "()I", "")]
				get {
					const string __id = "getRendererCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			[Obsolete (@"deprecated")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray UnassociatedTrackGroups {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getUnassociatedTrackGroups' and count(parameter)=0]"
				[Register ("getUnassociatedTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "")]
				get {
					const string __id = "getUnassociatedTrackGroups.()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray UnmappedTrackGroups {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getUnmappedTrackGroups' and count(parameter)=0]"
				[Register ("getUnmappedTrackGroups", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "")]
				get {
					const string __id = "getUnmappedTrackGroups.()Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getAdaptiveSupport' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("getAdaptiveSupport", "(IIZ)I", "")]
			public unsafe int GetAdaptiveSupport (int rendererIndex, int groupIndex, bool includeCapabilitiesExceededTracks)
			{
				const string __id = "getAdaptiveSupport.(IIZ)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue (groupIndex);
					__args [2] = new JniArgumentValue (includeCapabilitiesExceededTracks);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getAdaptiveSupport' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
			[Register ("getAdaptiveSupport", "(II[I)I", "")]
			public unsafe int GetAdaptiveSupport (int rendererIndex, int groupIndex, int[] trackIndices)
			{
				const string __id = "getAdaptiveSupport.(II[I)I";
				IntPtr native_trackIndices = JNIEnv.NewArray (trackIndices);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue (groupIndex);
					__args [2] = new JniArgumentValue (native_trackIndices);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					if (trackIndices != null) {
						JNIEnv.CopyArray (native_trackIndices, trackIndices);
						JNIEnv.DeleteLocalRef (native_trackIndices);
					}
					global::System.GC.KeepAlive (trackIndices);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getRendererSupport' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRendererSupport", "(I)I", "")]
			public unsafe int GetRendererSupport (int rendererIndex)
			{
				const string __id = "getRendererSupport.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rendererIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getRendererType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRendererType", "(I)I", "")]
			public unsafe int GetRendererType (int rendererIndex)
			{
				const string __id = "getRendererType.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rendererIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getTrackFormatSupport' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Obsolete (@"deprecated")]
			[Register ("getTrackFormatSupport", "(III)I", "")]
			public unsafe int GetTrackFormatSupport (int rendererIndex, int groupIndex, int trackIndex)
			{
				const string __id = "getTrackFormatSupport.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue (groupIndex);
					__args [2] = new JniArgumentValue (trackIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getTrackGroups' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getTrackGroups", "(I)Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray GetTrackGroups (int rendererIndex)
			{
				const string __id = "getTrackGroups.(I)Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rendererIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getTrackSupport' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("getTrackSupport", "(III)I", "")]
			public unsafe int GetTrackSupport (int rendererIndex, int groupIndex, int trackIndex)
			{
				const string __id = "getTrackSupport.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue (groupIndex);
					__args [2] = new JniArgumentValue (trackIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getTrackTypeRendererSupport' and count(parameter)=1 and parameter[1][@type='int']]"
			[Obsolete (@"deprecated")]
			[Register ("getTrackTypeRendererSupport", "(I)I", "")]
			public unsafe int GetTrackTypeRendererSupport (int trackType)
			{
				const string __id = "getTrackTypeRendererSupport.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (trackType);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector.MappedTrackInfo']/method[@name='getTypeSupport' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getTypeSupport", "(I)I", "")]
			public unsafe int GetTypeSupport (int trackType)
			{
				const string __id = "getTypeSupport.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (trackType);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector", typeof (MappingTrackSelector));

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

		protected MappingTrackSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']/constructor[@name='MappingTrackSelector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MappingTrackSelector () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo CurrentMappedTrackInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']/method[@name='getCurrentMappedTrackInfo' and count(parameter)=0]"
			[Register ("getCurrentMappedTrackInfo", "()Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;", "")]
			get {
				const string __id = "getCurrentMappedTrackInfo.()Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']/method[@name='onSelectionActivated' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSelectionActivated", "(Ljava/lang/Object;)V", "")]
		public override sealed unsafe void OnSelectionActivated (global::Java.Lang.Object info)
		{
			const string __id = "onSelectionActivated.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (info);
			}
		}

		static Delegate cb_selectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayI;
#pragma warning disable 0169
		static Delegate GetSelectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayIHandler ()
		{
			if (cb_selectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayI == null)
				cb_selectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_SelectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayI);
			return cb_selectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayI;
		}

		static IntPtr n_SelectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[][][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[][]));
			var p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectTracks (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']/method[@name='selectTracks' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MappingTrackSelector.MappedTrackInfo'] and parameter[2][@type='int[][][]'] and parameter[3][@type='int[]']]"
		[Register ("selectTracks", "(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[I)Landroid/util/Pair;", "GetSelectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayIHandler")]
		protected abstract global::Android.Util.Pair SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo p0, int[][][] p1, int[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']/method[@name='selectTracks' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererCapabilities[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.MediaSource.MediaPeriodId'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.Timeline']]"
		[Register ("selectTracks", "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;", "")]
		public override sealed unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities[] rendererCapabilities, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray trackGroups, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId periodId, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline timeline)
		{
			const string __id = "selectTracks.([Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId;Lcom/example/androidtvlibrary/main/adapter/Timeline;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;";
			IntPtr native_rendererCapabilities = JNIEnv.NewArray (rendererCapabilities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_rendererCapabilities);
				__args [1] = new JniArgumentValue ((trackGroups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackGroups).Handle);
				__args [2] = new JniArgumentValue ((periodId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) periodId).Handle);
				__args [3] = new JniArgumentValue ((timeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeline).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (rendererCapabilities != null) {
					JNIEnv.CopyArray (native_rendererCapabilities, rendererCapabilities);
					JNIEnv.DeleteLocalRef (native_rendererCapabilities);
				}
				global::System.GC.KeepAlive (rendererCapabilities);
				global::System.GC.KeepAlive (trackGroups);
				global::System.GC.KeepAlive (periodId);
				global::System.GC.KeepAlive (timeline);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector", DoNotGenerateAcw=true)]
	internal partial class MappingTrackSelectorInvoker : MappingTrackSelector {
		public MappingTrackSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector", typeof (MappingTrackSelectorInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='MappingTrackSelector']/method[@name='selectTracks' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MappingTrackSelector.MappedTrackInfo'] and parameter[2][@type='int[][][]'] and parameter[3][@type='int[]']]"
		[Register ("selectTracks", "(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[I)Landroid/util/Pair;", "GetSelectTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayIHandler")]
		protected override unsafe global::Android.Util.Pair SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo p0, int[][][] p1, int[] p2)
		{
			const string __id = "selectTracks.(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[I)Landroid/util/Pair;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
