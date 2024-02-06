using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector", DoNotGenerateAcw=true)]
	public partial class DefaultTrackSelector : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.AudioTrackScore']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$AudioTrackScore", DoNotGenerateAcw=true)]
		protected internal sealed partial class AudioTrackScore : global::Java.Lang.Object, global::Java.Lang.IComparable {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.AudioTrackScore']/field[@name='isWithinConstraints']"
			[Register ("isWithinConstraints")]
			public bool IsWithinConstraints {
				get {
					const string __id = "isWithinConstraints.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isWithinConstraints.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$AudioTrackScore", typeof (AudioTrackScore));

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

			internal AudioTrackScore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.AudioTrackScore']/constructor[@name='DefaultTrackSelector.AudioTrackScore' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;I)V", "")]
			public unsafe AudioTrackScore (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters parameters, int formatSupport) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
					__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
					__args [2] = new JniArgumentValue (formatSupport);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (format);
					global::System.GC.KeepAlive (parameters);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.AudioTrackScore']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "")]
			public unsafe int CompareTo (global::Java.Lang.Object other)
			{
				const string __id = "compareTo.(Ljava/lang/Object;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (other);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters", DoNotGenerateAcw=true)]
		public sealed partial class Parameters : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowAudioMixedChannelCountAdaptiveness']"
			[Register ("allowAudioMixedChannelCountAdaptiveness")]
			public bool AllowAudioMixedChannelCountAdaptiveness {
				get {
					const string __id = "allowAudioMixedChannelCountAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowAudioMixedChannelCountAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowAudioMixedMimeTypeAdaptiveness']"
			[Register ("allowAudioMixedMimeTypeAdaptiveness")]
			public bool AllowAudioMixedMimeTypeAdaptiveness {
				get {
					const string __id = "allowAudioMixedMimeTypeAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowAudioMixedMimeTypeAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowAudioMixedSampleRateAdaptiveness']"
			[Register ("allowAudioMixedSampleRateAdaptiveness")]
			public bool AllowAudioMixedSampleRateAdaptiveness {
				get {
					const string __id = "allowAudioMixedSampleRateAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowAudioMixedSampleRateAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowMixedMimeAdaptiveness']"
			[Register ("allowMixedMimeAdaptiveness")]
			[Obsolete ("deprecated")]
			public bool AllowMixedMimeAdaptiveness {
				get {
					const string __id = "allowMixedMimeAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowMixedMimeAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowNonSeamlessAdaptiveness']"
			[Register ("allowNonSeamlessAdaptiveness")]
			[Obsolete ("deprecated")]
			public bool AllowNonSeamlessAdaptiveness {
				get {
					const string __id = "allowNonSeamlessAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowNonSeamlessAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowVideoMixedMimeTypeAdaptiveness']"
			[Register ("allowVideoMixedMimeTypeAdaptiveness")]
			public bool AllowVideoMixedMimeTypeAdaptiveness {
				get {
					const string __id = "allowVideoMixedMimeTypeAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowVideoMixedMimeTypeAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='allowVideoNonSeamlessAdaptiveness']"
			[Register ("allowVideoNonSeamlessAdaptiveness")]
			public bool AllowVideoNonSeamlessAdaptiveness {
				get {
					const string __id = "allowVideoNonSeamlessAdaptiveness.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "allowVideoNonSeamlessAdaptiveness.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			[Obsolete ("deprecated")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters Default {
				get {
					const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='DEFAULT_WITHOUT_CONTEXT']"
			[Register ("DEFAULT_WITHOUT_CONTEXT")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters DefaultWithoutContext {
				get {
					const string __id = "DEFAULT_WITHOUT_CONTEXT.Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='DEFAULT_WITHOUT_VIEWPORT']"
			[Register ("DEFAULT_WITHOUT_VIEWPORT")]
			[Obsolete ("deprecated")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters DefaultWithoutViewport {
				get {
					const string __id = "DEFAULT_WITHOUT_VIEWPORT.Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='exceedAudioConstraintsIfNecessary']"
			[Register ("exceedAudioConstraintsIfNecessary")]
			public bool ExceedAudioConstraintsIfNecessary {
				get {
					const string __id = "exceedAudioConstraintsIfNecessary.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "exceedAudioConstraintsIfNecessary.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='exceedRendererCapabilitiesIfNecessary']"
			[Register ("exceedRendererCapabilitiesIfNecessary")]
			public bool ExceedRendererCapabilitiesIfNecessary {
				get {
					const string __id = "exceedRendererCapabilitiesIfNecessary.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "exceedRendererCapabilitiesIfNecessary.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='exceedVideoConstraintsIfNecessary']"
			[Register ("exceedVideoConstraintsIfNecessary")]
			public bool ExceedVideoConstraintsIfNecessary {
				get {
					const string __id = "exceedVideoConstraintsIfNecessary.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "exceedVideoConstraintsIfNecessary.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='forceHighestSupportedBitrate']"
			[Register ("forceHighestSupportedBitrate")]
			public bool ForceHighestSupportedBitrate {
				get {
					const string __id = "forceHighestSupportedBitrate.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "forceHighestSupportedBitrate.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='forceLowestBitrate']"
			[Register ("forceLowestBitrate")]
			public bool ForceLowestBitrate {
				get {
					const string __id = "forceLowestBitrate.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "forceLowestBitrate.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='maxAudioBitrate']"
			[Register ("maxAudioBitrate")]
			public int MaxAudioBitrate {
				get {
					const string __id = "maxAudioBitrate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxAudioBitrate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='maxAudioChannelCount']"
			[Register ("maxAudioChannelCount")]
			public int MaxAudioChannelCount {
				get {
					const string __id = "maxAudioChannelCount.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxAudioChannelCount.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='maxVideoBitrate']"
			[Register ("maxVideoBitrate")]
			public int MaxVideoBitrate {
				get {
					const string __id = "maxVideoBitrate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxVideoBitrate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='maxVideoFrameRate']"
			[Register ("maxVideoFrameRate")]
			public int MaxVideoFrameRate {
				get {
					const string __id = "maxVideoFrameRate.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxVideoFrameRate.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='maxVideoHeight']"
			[Register ("maxVideoHeight")]
			public int MaxVideoHeight {
				get {
					const string __id = "maxVideoHeight.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxVideoHeight.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='maxVideoWidth']"
			[Register ("maxVideoWidth")]
			public int MaxVideoWidth {
				get {
					const string __id = "maxVideoWidth.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxVideoWidth.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='tunnelingAudioSessionId']"
			[Register ("tunnelingAudioSessionId")]
			public int TunnelingAudioSessionId {
				get {
					const string __id = "tunnelingAudioSessionId.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "tunnelingAudioSessionId.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='viewportHeight']"
			[Register ("viewportHeight")]
			public int ViewportHeight {
				get {
					const string __id = "viewportHeight.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "viewportHeight.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='viewportOrientationMayChange']"
			[Register ("viewportOrientationMayChange")]
			public bool ViewportOrientationMayChange {
				get {
					const string __id = "viewportOrientationMayChange.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "viewportOrientationMayChange.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/field[@name='viewportWidth']"
			[Register ("viewportWidth")]
			public int ViewportWidth {
				get {
					const string __id = "viewportWidth.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "viewportWidth.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters", typeof (Parameters));

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

			internal Parameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/method[@name='getDefaults' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("getDefaults", "(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;", "")]
			public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters GetDefaults (global::Android.Content.Context context)
			{
				const string __id = "getDefaults.(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/method[@name='getRendererDisabled' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRendererDisabled", "(I)Z", "")]
			public unsafe bool GetRendererDisabled (int rendererIndex)
			{
				const string __id = "getRendererDisabled.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rendererIndex);
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/method[@name='getSelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray']]"
			[Register ("getSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.SelectionOverride GetSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups)
			{
				const string __id = "getSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.SelectionOverride> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (groups);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.Parameters']/method[@name='hasSelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray']]"
			[Register ("hasSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Z", "")]
			public unsafe bool HasSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups)
			{
				const string __id = "hasSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (groups);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder", DoNotGenerateAcw=true)]
		public sealed partial class ParametersBuilder : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder", typeof (ParametersBuilder));

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

			internal ParametersBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/constructor[@name='DefaultTrackSelector.ParametersBuilder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ParametersBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/constructor[@name='DefaultTrackSelector.ParametersBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe ParametersBuilder (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='clearSelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray']]"
			[Register ("clearSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder ClearSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups)
			{
				const string __id = "clearSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (groups);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='clearSelectionOverrides' and count(parameter)=0]"
			[Register ("clearSelectionOverrides", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder ClearSelectionOverrides ()
			{
				const string __id = "clearSelectionOverrides.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='clearSelectionOverrides' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("clearSelectionOverrides", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder ClearSelectionOverrides (int rendererIndex)
			{
				const string __id = "clearSelectionOverrides.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rendererIndex);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='clearVideoSizeConstraints' and count(parameter)=0]"
			[Register ("clearVideoSizeConstraints", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder ClearVideoSizeConstraints ()
			{
				const string __id = "clearVideoSizeConstraints.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='clearViewportSizeConstraints' and count(parameter)=0]"
			[Register ("clearViewportSizeConstraints", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder ClearViewportSizeConstraints ()
			{
				const string __id = "clearViewportSizeConstraints.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowAudioMixedChannelCountAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowAudioMixedChannelCountAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowAudioMixedChannelCountAdaptiveness (bool allowAudioMixedChannelCountAdaptiveness)
			{
				const string __id = "setAllowAudioMixedChannelCountAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowAudioMixedChannelCountAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowAudioMixedMimeTypeAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowAudioMixedMimeTypeAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowAudioMixedMimeTypeAdaptiveness (bool allowAudioMixedMimeTypeAdaptiveness)
			{
				const string __id = "setAllowAudioMixedMimeTypeAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowAudioMixedMimeTypeAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowAudioMixedSampleRateAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowAudioMixedSampleRateAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowAudioMixedSampleRateAdaptiveness (bool allowAudioMixedSampleRateAdaptiveness)
			{
				const string __id = "setAllowAudioMixedSampleRateAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowAudioMixedSampleRateAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowMixedMimeAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Obsolete (@"deprecated")]
			[Register ("setAllowMixedMimeAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowMixedMimeAdaptiveness (bool allowMixedMimeAdaptiveness)
			{
				const string __id = "setAllowMixedMimeAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowMixedMimeAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowNonSeamlessAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Obsolete (@"deprecated")]
			[Register ("setAllowNonSeamlessAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowNonSeamlessAdaptiveness (bool allowNonSeamlessAdaptiveness)
			{
				const string __id = "setAllowNonSeamlessAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowNonSeamlessAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowVideoMixedMimeTypeAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowVideoMixedMimeTypeAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowVideoMixedMimeTypeAdaptiveness (bool allowVideoMixedMimeTypeAdaptiveness)
			{
				const string __id = "setAllowVideoMixedMimeTypeAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowVideoMixedMimeTypeAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setAllowVideoNonSeamlessAdaptiveness' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowVideoNonSeamlessAdaptiveness", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetAllowVideoNonSeamlessAdaptiveness (bool allowVideoNonSeamlessAdaptiveness)
			{
				const string __id = "setAllowVideoNonSeamlessAdaptiveness.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowVideoNonSeamlessAdaptiveness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setExceedAudioConstraintsIfNecessary' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExceedAudioConstraintsIfNecessary", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetExceedAudioConstraintsIfNecessary (bool exceedAudioConstraintsIfNecessary)
			{
				const string __id = "setExceedAudioConstraintsIfNecessary.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (exceedAudioConstraintsIfNecessary);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setExceedRendererCapabilitiesIfNecessary' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExceedRendererCapabilitiesIfNecessary", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetExceedRendererCapabilitiesIfNecessary (bool exceedRendererCapabilitiesIfNecessary)
			{
				const string __id = "setExceedRendererCapabilitiesIfNecessary.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (exceedRendererCapabilitiesIfNecessary);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setExceedVideoConstraintsIfNecessary' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExceedVideoConstraintsIfNecessary", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetExceedVideoConstraintsIfNecessary (bool exceedVideoConstraintsIfNecessary)
			{
				const string __id = "setExceedVideoConstraintsIfNecessary.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (exceedVideoConstraintsIfNecessary);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setForceHighestSupportedBitrate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForceHighestSupportedBitrate", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetForceHighestSupportedBitrate (bool forceHighestSupportedBitrate)
			{
				const string __id = "setForceHighestSupportedBitrate.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (forceHighestSupportedBitrate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setForceLowestBitrate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForceLowestBitrate", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetForceLowestBitrate (bool forceLowestBitrate)
			{
				const string __id = "setForceLowestBitrate.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (forceLowestBitrate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setMaxAudioBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxAudioBitrate", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetMaxAudioBitrate (int maxAudioBitrate)
			{
				const string __id = "setMaxAudioBitrate.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxAudioBitrate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setMaxAudioChannelCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxAudioChannelCount", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetMaxAudioChannelCount (int maxAudioChannelCount)
			{
				const string __id = "setMaxAudioChannelCount.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxAudioChannelCount);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setMaxVideoBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxVideoBitrate", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetMaxVideoBitrate (int maxVideoBitrate)
			{
				const string __id = "setMaxVideoBitrate.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxVideoBitrate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setMaxVideoFrameRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxVideoFrameRate", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetMaxVideoFrameRate (int maxVideoFrameRate)
			{
				const string __id = "setMaxVideoFrameRate.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxVideoFrameRate);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setMaxVideoSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setMaxVideoSize", "(II)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetMaxVideoSize (int maxVideoWidth, int maxVideoHeight)
			{
				const string __id = "setMaxVideoSize.(II)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (maxVideoWidth);
					__args [1] = new JniArgumentValue (maxVideoHeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setMaxVideoSizeSd' and count(parameter)=0]"
			[Register ("setMaxVideoSizeSd", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetMaxVideoSizeSd ()
			{
				const string __id = "setMaxVideoSizeSd.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setRendererDisabled' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("setRendererDisabled", "(IZ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetRendererDisabled (int rendererIndex, bool disabled)
			{
				const string __id = "setRendererDisabled.(IZ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue (disabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setSelectionOverride' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.SelectionOverride']]"
			[Register ("setSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.SelectionOverride @override)
			{
				const string __id = "setSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (rendererIndex);
					__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
					__args [2] = new JniArgumentValue ((@override == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @override).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (groups);
					global::System.GC.KeepAlive (@override);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setTunnelingAudioSessionId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTunnelingAudioSessionId", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetTunnelingAudioSessionId (int tunnelingAudioSessionId)
			{
				const string __id = "setTunnelingAudioSessionId.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (tunnelingAudioSessionId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setViewportSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("setViewportSize", "(IIZ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetViewportSize (int viewportWidth, int viewportHeight, bool viewportOrientationMayChange)
			{
				const string __id = "setViewportSize.(IIZ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (viewportWidth);
					__args [1] = new JniArgumentValue (viewportHeight);
					__args [2] = new JniArgumentValue (viewportOrientationMayChange);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.ParametersBuilder']/method[@name='setViewportSizeToPhysicalDisplaySize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
			[Register ("setViewportSizeToPhysicalDisplaySize", "(Landroid/content/Context;Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder SetViewportSizeToPhysicalDisplaySize (global::Android.Content.Context context, bool viewportOrientationMayChange)
			{
				const string __id = "setViewportSizeToPhysicalDisplaySize.(Landroid/content/Context;Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (viewportOrientationMayChange);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride", DoNotGenerateAcw=true)]
		public sealed partial class SelectionOverride : global::Java.Lang.Object, global::Android.OS.IParcelable {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/field[@name='data']"
			[Register ("data")]
			public int Data {
				get {
					const string __id = "data.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "data.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/field[@name='groupIndex']"
			[Register ("groupIndex")]
			public int GroupIndex {
				get {
					const string __id = "groupIndex.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "groupIndex.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/field[@name='length']"
			[Register ("length")]
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/field[@name='reason']"
			[Register ("reason")]
			public int Reason {
				get {
					const string __id = "reason.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "reason.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/field[@name='tracks']"
			[Register ("tracks")]
			public IList<int> Tracks {
				get {
					const string __id = "tracks.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "tracks.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride", typeof (SelectionOverride));

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

			internal SelectionOverride (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/constructor[@name='DefaultTrackSelector.SelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int...']]"
			[Register (".ctor", "(I[I)V", "")]
			public unsafe SelectionOverride (int groupIndex, params int[] tracks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I[I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_tracks = JNIEnv.NewArray (tracks);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (groupIndex);
					__args [1] = new JniArgumentValue (native_tracks);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (tracks != null) {
						JNIEnv.CopyArray (native_tracks, tracks);
						JNIEnv.DeleteLocalRef (native_tracks);
					}
					global::System.GC.KeepAlive (tracks);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/constructor[@name='DefaultTrackSelector.SelectionOverride' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(I[III)V", "")]
			public unsafe SelectionOverride (int groupIndex, int[] tracks, int reason, int data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I[III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_tracks = JNIEnv.NewArray (tracks);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (groupIndex);
					__args [1] = new JniArgumentValue (native_tracks);
					__args [2] = new JniArgumentValue (reason);
					__args [3] = new JniArgumentValue (data);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (tracks != null) {
						JNIEnv.CopyArray (native_tracks, tracks);
						JNIEnv.DeleteLocalRef (native_tracks);
					}
					global::System.GC.KeepAlive (tracks);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/method[@name='containsTrack' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("containsTrack", "(I)Z", "")]
			public unsafe bool ContainsTrack (int track)
			{
				const string __id = "containsTrack.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (track);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "")]
			public unsafe int DescribeContents ()
			{
				const string __id = "describeContents.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.SelectionOverride']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
			public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
			{
				const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
					__args [1] = new JniArgumentValue ((int) flags);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (dest);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.TextTrackScore']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$TextTrackScore", DoNotGenerateAcw=true)]
		protected internal sealed partial class TextTrackScore : global::Java.Lang.Object, global::Java.Lang.IComparable {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.TextTrackScore']/field[@name='isWithinConstraints']"
			[Register ("isWithinConstraints")]
			public bool IsWithinConstraints {
				get {
					const string __id = "isWithinConstraints.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isWithinConstraints.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$TextTrackScore", typeof (TextTrackScore));

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

			internal TextTrackScore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.TextTrackScore']/constructor[@name='DefaultTrackSelector.TextTrackScore' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;ILjava/lang/String;)V", "")]
			public unsafe TextTrackScore (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters parameters, int trackFormatSupport, string selectedAudioLanguage) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;ILjava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_selectedAudioLanguage = JNIEnv.NewString (selectedAudioLanguage);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
					__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
					__args [2] = new JniArgumentValue (trackFormatSupport);
					__args [3] = new JniArgumentValue (native_selectedAudioLanguage);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_selectedAudioLanguage);
					global::System.GC.KeepAlive (format);
					global::System.GC.KeepAlive (parameters);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector.TextTrackScore']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "")]
			public unsafe int CompareTo (global::Java.Lang.Object other)
			{
				const string __id = "compareTo.(Ljava/lang/Object;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (other);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector", typeof (DefaultTrackSelector));

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

		protected DefaultTrackSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/constructor[@name='DefaultTrackSelector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultTrackSelector () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/constructor[@name='DefaultTrackSelector' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DefaultTrackSelector (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/constructor[@name='DefaultTrackSelector' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackSelection.Factory']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Factory;)V", "")]
		public unsafe DefaultTrackSelector (global::Android.Content.Context context, global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactory trackSelectionFactory) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Factory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((trackSelectionFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (trackSelectionFactory);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/constructor[@name='DefaultTrackSelector' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultTrackSelector (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter bandwidthMeter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/constructor[@name='DefaultTrackSelector' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackSelection.Factory']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Factory;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultTrackSelector (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactory trackSelectionFactory) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Factory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trackSelectionFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (trackSelectionFactory);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/constructor[@name='DefaultTrackSelector' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackSelection.Factory']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Factory;)V", "")]
		public unsafe DefaultTrackSelector (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters parameters, global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactory trackSelectionFactory) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Factory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				__args [1] = new JniArgumentValue ((trackSelectionFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parameters);
				global::System.GC.KeepAlive (trackSelectionFactory);
			}
		}

		static Delegate cb_buildUponParameters;
#pragma warning disable 0169
		static Delegate GetBuildUponParametersHandler ()
		{
			if (cb_buildUponParameters == null)
				cb_buildUponParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BuildUponParameters);
			return cb_buildUponParameters;
		}

		static IntPtr n_BuildUponParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildUponParameters ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='buildUponParameters' and count(parameter)=0]"
		[Register ("buildUponParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;", "GetBuildUponParametersHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder BuildUponParameters ()
		{
			const string __id = "buildUponParameters.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='clearSelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray']]"
		[Obsolete (@"deprecated")]
		[Register ("clearSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)V", "")]
		public unsafe void ClearSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups)
		{
			const string __id = "clearSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (rendererIndex);
				__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (groups);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='clearSelectionOverrides' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearSelectionOverrides", "()V", "")]
		public unsafe void ClearSelectionOverrides ()
		{
			const string __id = "clearSelectionOverrides.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='clearSelectionOverrides' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("clearSelectionOverrides", "(I)V", "")]
		public unsafe void ClearSelectionOverrides (int rendererIndex)
		{
			const string __id = "clearSelectionOverrides.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rendererIndex);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_experimental_allowMultipleAdaptiveSelections;
#pragma warning disable 0169
		static Delegate GetExperimental_allowMultipleAdaptiveSelectionsHandler ()
		{
			if (cb_experimental_allowMultipleAdaptiveSelections == null)
				cb_experimental_allowMultipleAdaptiveSelections = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Experimental_allowMultipleAdaptiveSelections);
			return cb_experimental_allowMultipleAdaptiveSelections;
		}

		static void n_Experimental_allowMultipleAdaptiveSelections (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Experimental_allowMultipleAdaptiveSelections ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='experimental_allowMultipleAdaptiveSelections' and count(parameter)=0]"
		[Register ("experimental_allowMultipleAdaptiveSelections", "()V", "GetExperimental_allowMultipleAdaptiveSelectionsHandler")]
		public virtual unsafe void Experimental_allowMultipleAdaptiveSelections ()
		{
			const string __id = "experimental_allowMultipleAdaptiveSelections.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='getFormatLanguageScore' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getFormatLanguageScore", "(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/String;Z)I", "")]
		protected static unsafe int GetFormatLanguageScore (global::Com.Example.Androidtvlibrary.Main.Adapter.Format format, string language, bool allowUndeterminedFormatLanguage)
		{
			const string __id = "getFormatLanguageScore.(Lcom/example/androidtvlibrary/main/adapter/Format;Ljava/lang/String;Z)I";
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (native_language);
				__args [2] = new JniArgumentValue (allowUndeterminedFormatLanguage);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetParameters ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='getParameters' and count(parameter)=0]"
		[Register ("getParameters", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;", "GetGetParametersHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters GetParameters ()
		{
			const string __id = "getParameters.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='getRendererDisabled' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getRendererDisabled", "(I)Z", "")]
		public unsafe bool GetRendererDisabled (int rendererIndex)
		{
			const string __id = "getRendererDisabled.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rendererIndex);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='getSelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray']]"
		[Obsolete (@"deprecated")]
		[Register ("getSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.SelectionOverride GetSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups)
		{
			const string __id = "getSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (rendererIndex);
				__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.SelectionOverride> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (groups);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='hasSelectionOverride' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray']]"
		[Obsolete (@"deprecated")]
		[Register ("hasSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Z", "")]
		public unsafe bool HasSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups)
		{
			const string __id = "hasSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (rendererIndex);
				__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (groups);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='isSupported' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("isSupported", "(IZ)Z", "")]
		protected static unsafe bool IsSupported (int formatSupport, bool allowExceedsCapabilities)
		{
			const string __id = "isSupported.(IZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (formatSupport);
				__args [1] = new JniArgumentValue (allowExceedsCapabilities);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='normalizeUndeterminedLanguageToNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizeUndeterminedLanguageToNull", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string NormalizeUndeterminedLanguageToNull (string language)
		{
			const string __id = "normalizeUndeterminedLanguageToNull.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		static Delegate cb_selectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_;
#pragma warning disable 0169
		static Delegate GetSelectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Handler ()
		{
			if (cb_selectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ == null)
				cb_selectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_SelectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_);
			return cb_selectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_;
		}

		static IntPtr n_SelectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mappedTrackInfo, IntPtr native_rendererFormatSupports, IntPtr native_rendererMixedMimeTypeAdaptationSupports, IntPtr native__params)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mappedTrackInfo = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo> (native_mappedTrackInfo, JniHandleOwnership.DoNotTransfer);
			var rendererFormatSupports = (int[][][]) JNIEnv.GetArray (native_rendererFormatSupports, JniHandleOwnership.DoNotTransfer, typeof (int[][]));
			var rendererMixedMimeTypeAdaptationSupports = (int[]) JNIEnv.GetArray (native_rendererMixedMimeTypeAdaptationSupports, JniHandleOwnership.DoNotTransfer, typeof (int));
			var @params = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (native__params, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.SelectAllTracks (mappedTrackInfo, rendererFormatSupports, rendererMixedMimeTypeAdaptationSupports, @params));
			if (rendererFormatSupports != null)
				JNIEnv.CopyArray (rendererFormatSupports, native_rendererFormatSupports);
			if (rendererMixedMimeTypeAdaptationSupports != null)
				JNIEnv.CopyArray (rendererMixedMimeTypeAdaptationSupports, native_rendererMixedMimeTypeAdaptationSupports);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='selectAllTracks' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MappingTrackSelector.MappedTrackInfo'] and parameter[2][@type='int[][][]'] and parameter[3][@type='int[]'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters']]"
		[Register ("selectAllTracks", "(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[ILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;)[Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;", "GetSelectAllTracks_Lcom_example_androidtvlibrary_main_adapter_wow_MappingTrackSelector_MappedTrackInfo_arrayarrayarrayIarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition[] SelectAllTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo mappedTrackInfo, int[][][] rendererFormatSupports, int[] rendererMixedMimeTypeAdaptationSupports, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters @params)
		{
			const string __id = "selectAllTracks.(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[ILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;)[Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;";
			IntPtr native_rendererFormatSupports = JNIEnv.NewArray (rendererFormatSupports);
			IntPtr native_rendererMixedMimeTypeAdaptationSupports = JNIEnv.NewArray (rendererMixedMimeTypeAdaptationSupports);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((mappedTrackInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mappedTrackInfo).Handle);
				__args [1] = new JniArgumentValue (native_rendererFormatSupports);
				__args [2] = new JniArgumentValue (native_rendererMixedMimeTypeAdaptationSupports);
				__args [3] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition));
			} finally {
				if (rendererFormatSupports != null) {
					JNIEnv.CopyArray (native_rendererFormatSupports, rendererFormatSupports);
					JNIEnv.DeleteLocalRef (native_rendererFormatSupports);
				}
				if (rendererMixedMimeTypeAdaptationSupports != null) {
					JNIEnv.CopyArray (native_rendererMixedMimeTypeAdaptationSupports, rendererMixedMimeTypeAdaptationSupports);
					JNIEnv.DeleteLocalRef (native_rendererMixedMimeTypeAdaptationSupports);
				}
				global::System.GC.KeepAlive (mappedTrackInfo);
				global::System.GC.KeepAlive (rendererFormatSupports);
				global::System.GC.KeepAlive (rendererMixedMimeTypeAdaptationSupports);
				global::System.GC.KeepAlive (@params);
			}
		}

		static Delegate cb_selectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z;
#pragma warning disable 0169
		static Delegate GetSelectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ZHandler ()
		{
			if (cb_selectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z == null)
				cb_selectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLILZ_L) n_SelectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z);
			return cb_selectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z;
		}

		static IntPtr n_SelectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_groups, IntPtr native_formatSupports, int mixedMimeTypeAdaptationSupports, IntPtr native__params, bool enableAdaptiveTrackSelection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var groups = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_groups, JniHandleOwnership.DoNotTransfer);
			var formatSupports = (int[][]) JNIEnv.GetArray (native_formatSupports, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			var @params = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (native__params, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectAudioTrack (groups, formatSupports, mixedMimeTypeAdaptationSupports, @params, enableAdaptiveTrackSelection));
			if (formatSupports != null)
				JNIEnv.CopyArray (formatSupports, native_formatSupports);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='selectAudioTrack' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters'] and parameter[5][@type='boolean']]"
		[Register ("selectAudioTrack", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[IILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Z)Landroid/util/Pair;", "GetSelectAudioTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ZHandler")]
		protected virtual unsafe global::Android.Util.Pair SelectAudioTrack (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups, int[][] formatSupports, int mixedMimeTypeAdaptationSupports, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters @params, bool enableAdaptiveTrackSelection)
		{
			const string __id = "selectAudioTrack.(Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[IILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Z)Landroid/util/Pair;";
			IntPtr native_formatSupports = JNIEnv.NewArray (formatSupports);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				__args [1] = new JniArgumentValue (native_formatSupports);
				__args [2] = new JniArgumentValue (mixedMimeTypeAdaptationSupports);
				__args [3] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [4] = new JniArgumentValue (enableAdaptiveTrackSelection);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (formatSupports != null) {
					JNIEnv.CopyArray (native_formatSupports, formatSupports);
					JNIEnv.DeleteLocalRef (native_formatSupports);
				}
				global::System.GC.KeepAlive (groups);
				global::System.GC.KeepAlive (formatSupports);
				global::System.GC.KeepAlive (@params);
			}
		}

		static Delegate cb_selectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_;
#pragma warning disable 0169
		static Delegate GetSelectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Handler ()
		{
			if (cb_selectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ == null)
				cb_selectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_L) n_SelectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_);
			return cb_selectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_;
		}

		static IntPtr n_SelectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ (IntPtr jnienv, IntPtr native__this, int trackType, IntPtr native_groups, IntPtr native_formatSupport, IntPtr native__params)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var groups = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_groups, JniHandleOwnership.DoNotTransfer);
			var formatSupport = (int[][]) JNIEnv.GetArray (native_formatSupport, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			var @params = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (native__params, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectOtherTrack (trackType, groups, formatSupport, @params));
			if (formatSupport != null)
				JNIEnv.CopyArray (formatSupport, native_formatSupport);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='selectOtherTrack' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='int[][]'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters']]"
		[Register ("selectOtherTrack", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[ILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;)Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;", "GetSelectOtherTrack_ILcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition SelectOtherTrack (int trackType, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups, int[][] formatSupport, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters @params)
		{
			const string __id = "selectOtherTrack.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[ILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;)Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;";
			IntPtr native_formatSupport = JNIEnv.NewArray (formatSupport);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (trackType);
				__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				__args [2] = new JniArgumentValue (native_formatSupport);
				__args [3] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (formatSupport != null) {
					JNIEnv.CopyArray (native_formatSupport, formatSupport);
					JNIEnv.DeleteLocalRef (native_formatSupport);
				}
				global::System.GC.KeepAlive (groups);
				global::System.GC.KeepAlive (formatSupport);
				global::System.GC.KeepAlive (@params);
			}
		}

		static Delegate cb_selectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSelectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_Handler ()
		{
			if (cb_selectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_ == null)
				cb_selectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_SelectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_);
			return cb_selectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_;
		}

		static IntPtr n_SelectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groups, IntPtr native_formatSupport, IntPtr native__params, IntPtr native_selectedAudioLanguage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var groups = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_groups, JniHandleOwnership.DoNotTransfer);
			var formatSupport = (int[][]) JNIEnv.GetArray (native_formatSupport, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			var @params = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (native__params, JniHandleOwnership.DoNotTransfer);
			var selectedAudioLanguage = JNIEnv.GetString (native_selectedAudioLanguage, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectTextTrack (groups, formatSupport, @params, selectedAudioLanguage));
			if (formatSupport != null)
				JNIEnv.CopyArray (formatSupport, native_formatSupport);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='selectTextTrack' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[2][@type='int[][]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters'] and parameter[4][@type='java.lang.String']]"
		[Register ("selectTextTrack", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[ILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Ljava/lang/String;)Landroid/util/Pair;", "GetSelectTextTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Android.Util.Pair SelectTextTrack (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups, int[][] formatSupport, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters @params, string selectedAudioLanguage)
		{
			const string __id = "selectTextTrack.(Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[ILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Ljava/lang/String;)Landroid/util/Pair;";
			IntPtr native_formatSupport = JNIEnv.NewArray (formatSupport);
			IntPtr native_selectedAudioLanguage = JNIEnv.NewString (selectedAudioLanguage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				__args [1] = new JniArgumentValue (native_formatSupport);
				__args [2] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [3] = new JniArgumentValue (native_selectedAudioLanguage);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (formatSupport != null) {
					JNIEnv.CopyArray (native_formatSupport, formatSupport);
					JNIEnv.DeleteLocalRef (native_formatSupport);
				}
				JNIEnv.DeleteLocalRef (native_selectedAudioLanguage);
				global::System.GC.KeepAlive (groups);
				global::System.GC.KeepAlive (formatSupport);
				global::System.GC.KeepAlive (@params);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='selectTracks' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.MappingTrackSelector.MappedTrackInfo'] and parameter[2][@type='int[][][]'] and parameter[3][@type='int[]']]"
		[Register ("selectTracks", "(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[I)Landroid/util/Pair;", "")]
		protected override sealed unsafe global::Android.Util.Pair SelectTracks (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.MappingTrackSelector.MappedTrackInfo mappedTrackInfo, int[][][] rendererFormatSupports, int[] rendererMixedMimeTypeAdaptationSupports)
		{
			const string __id = "selectTracks.(Lcom/example/androidtvlibrary/main/adapter/wow/MappingTrackSelector$MappedTrackInfo;[[[I[I)Landroid/util/Pair;";
			IntPtr native_rendererFormatSupports = JNIEnv.NewArray (rendererFormatSupports);
			IntPtr native_rendererMixedMimeTypeAdaptationSupports = JNIEnv.NewArray (rendererMixedMimeTypeAdaptationSupports);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mappedTrackInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mappedTrackInfo).Handle);
				__args [1] = new JniArgumentValue (native_rendererFormatSupports);
				__args [2] = new JniArgumentValue (native_rendererMixedMimeTypeAdaptationSupports);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (rendererFormatSupports != null) {
					JNIEnv.CopyArray (native_rendererFormatSupports, rendererFormatSupports);
					JNIEnv.DeleteLocalRef (native_rendererFormatSupports);
				}
				if (rendererMixedMimeTypeAdaptationSupports != null) {
					JNIEnv.CopyArray (native_rendererMixedMimeTypeAdaptationSupports, rendererMixedMimeTypeAdaptationSupports);
					JNIEnv.DeleteLocalRef (native_rendererMixedMimeTypeAdaptationSupports);
				}
				global::System.GC.KeepAlive (mappedTrackInfo);
				global::System.GC.KeepAlive (rendererFormatSupports);
				global::System.GC.KeepAlive (rendererMixedMimeTypeAdaptationSupports);
			}
		}

		static Delegate cb_selectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z;
#pragma warning disable 0169
		static Delegate GetSelectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ZHandler ()
		{
			if (cb_selectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z == null)
				cb_selectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLILZ_L) n_SelectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z);
			return cb_selectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z;
		}

		static IntPtr n_SelectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_groups, IntPtr native_formatSupports, int mixedMimeTypeAdaptationSupports, IntPtr native__params, bool enableAdaptiveTrackSelection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var groups = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_groups, JniHandleOwnership.DoNotTransfer);
			var formatSupports = (int[][]) JNIEnv.GetArray (native_formatSupports, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			var @params = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (native__params, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectVideoTrack (groups, formatSupports, mixedMimeTypeAdaptationSupports, @params, enableAdaptiveTrackSelection));
			if (formatSupports != null)
				JNIEnv.CopyArray (formatSupports, native_formatSupports);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='selectVideoTrack' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters'] and parameter[5][@type='boolean']]"
		[Register ("selectVideoTrack", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[IILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Z)Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;", "GetSelectVideoTrack_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_arrayarrayIILcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ZHandler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition SelectVideoTrack (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups, int[][] formatSupports, int mixedMimeTypeAdaptationSupports, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters @params, bool enableAdaptiveTrackSelection)
		{
			const string __id = "selectVideoTrack.(Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;[[IILcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;Z)Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;";
			IntPtr native_formatSupports = JNIEnv.NewArray (formatSupports);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				__args [1] = new JniArgumentValue (native_formatSupports);
				__args [2] = new JniArgumentValue (mixedMimeTypeAdaptationSupports);
				__args [3] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [4] = new JniArgumentValue (enableAdaptiveTrackSelection);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (formatSupports != null) {
					JNIEnv.CopyArray (native_formatSupports, formatSupports);
					JNIEnv.DeleteLocalRef (native_formatSupports);
				}
				global::System.GC.KeepAlive (groups);
				global::System.GC.KeepAlive (formatSupports);
				global::System.GC.KeepAlive (@params);
			}
		}

		static Delegate cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_;
#pragma warning disable 0169
		static Delegate GetSetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Handler ()
		{
			if (cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ == null)
				cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_);
			return cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_;
		}

		static void n_SetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameters = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			__this.SetParameters (parameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.Parameters']]"
		[Register ("setParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;)V", "GetSetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_Parameters_Handler")]
		public virtual unsafe void SetParameters (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.Parameters parameters)
		{
			const string __id = "setParameters.(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$Parameters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parameters);
			}
		}

		static Delegate cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_;
#pragma warning disable 0169
		static Delegate GetSetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_Handler ()
		{
			if (cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_ == null)
				cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_);
			return cb_setParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_;
		}

		static void n_SetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parametersBuilder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parametersBuilder = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder> (native_parametersBuilder, JniHandleOwnership.DoNotTransfer);
			__this.SetParameters (parametersBuilder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.ParametersBuilder']]"
		[Register ("setParameters", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;)V", "GetSetParameters_Lcom_example_androidtvlibrary_main_adapter_wow_DefaultTrackSelector_ParametersBuilder_Handler")]
		public virtual unsafe void SetParameters (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.ParametersBuilder parametersBuilder)
		{
			const string __id = "setParameters.(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$ParametersBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parametersBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parametersBuilder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parametersBuilder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='setRendererDisabled' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setRendererDisabled", "(IZ)V", "")]
		public unsafe void SetRendererDisabled (int rendererIndex, bool disabled)
		{
			const string __id = "setRendererDisabled.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (rendererIndex);
				__args [1] = new JniArgumentValue (disabled);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='setSelectionOverride' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultTrackSelector.SelectionOverride']]"
		[Obsolete (@"deprecated")]
		[Register ("setSelectionOverride", "(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;)V", "")]
		public unsafe void SetSelectionOverride (int rendererIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray groups, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector.SelectionOverride @override)
		{
			const string __id = "setSelectionOverride.(ILcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/wow/DefaultTrackSelector$SelectionOverride;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (rendererIndex);
				__args [1] = new JniArgumentValue ((groups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groups).Handle);
				__args [2] = new JniArgumentValue ((@override == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @override).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (groups);
				global::System.GC.KeepAlive (@override);
			}
		}

		static Delegate cb_setTunnelingAudioSessionId_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetTunnelingAudioSessionId_IHandler ()
		{
			if (cb_setTunnelingAudioSessionId_I == null)
				cb_setTunnelingAudioSessionId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTunnelingAudioSessionId_I);
			return cb_setTunnelingAudioSessionId_I;
		}

		[Obsolete]
		static void n_SetTunnelingAudioSessionId_I (IntPtr jnienv, IntPtr native__this, int tunnelingAudioSessionId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTunnelingAudioSessionId (tunnelingAudioSessionId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultTrackSelector']/method[@name='setTunnelingAudioSessionId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setTunnelingAudioSessionId", "(I)V", "GetSetTunnelingAudioSessionId_IHandler")]
		public virtual unsafe void SetTunnelingAudioSessionId (int tunnelingAudioSessionId)
		{
			const string __id = "setTunnelingAudioSessionId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tunnelingAudioSessionId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
