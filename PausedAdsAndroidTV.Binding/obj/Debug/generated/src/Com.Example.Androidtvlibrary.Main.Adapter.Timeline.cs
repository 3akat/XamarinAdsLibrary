using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Timeline", DoNotGenerateAcw=true)]
	public abstract partial class Timeline : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline Empty {
			get {
				const string __id = "EMPTY.Lcom/example/androidtvlibrary/main/adapter/Timeline;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Timeline$Period", DoNotGenerateAcw=true)]
		public sealed partial class Period : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/field[@name='id']"
			[Register ("id")]
			public global::Java.Lang.Object Id {
				get {
					const string __id = "id.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "id.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/field[@name='uid']"
			[Register ("uid")]
			public global::Java.Lang.Object Uid {
				get {
					const string __id = "uid.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "uid.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/field[@name='windowIndex']"
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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Timeline$Period", typeof (Period));

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

			internal Period (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/constructor[@name='Timeline.Period' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Period () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe int AdGroupCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdGroupCount' and count(parameter)=0]"
				[Register ("getAdGroupCount", "()I", "")]
				get {
					const string __id = "getAdGroupCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long AdResumePositionUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdResumePositionUs' and count(parameter)=0]"
				[Register ("getAdResumePositionUs", "()J", "")]
				get {
					const string __id = "getAdResumePositionUs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long DurationMs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getDurationMs' and count(parameter)=0]"
				[Register ("getDurationMs", "()J", "")]
				get {
					const string __id = "getDurationMs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long DurationUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getDurationUs' and count(parameter)=0]"
				[Register ("getDurationUs", "()J", "")]
				get {
					const string __id = "getDurationUs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long PositionInWindowMs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getPositionInWindowMs' and count(parameter)=0]"
				[Register ("getPositionInWindowMs", "()J", "")]
				get {
					const string __id = "getPositionInWindowMs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long PositionInWindowUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getPositionInWindowUs' and count(parameter)=0]"
				[Register ("getPositionInWindowUs", "()J", "")]
				get {
					const string __id = "getPositionInWindowUs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdCountInAdGroup' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getAdCountInAdGroup", "(I)I", "")]
			public unsafe int GetAdCountInAdGroup (int adGroupIndex)
			{
				const string __id = "getAdCountInAdGroup.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (adGroupIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdDurationUs' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("getAdDurationUs", "(II)J", "")]
			public unsafe long GetAdDurationUs (int adGroupIndex, int adIndexInAdGroup)
			{
				const string __id = "getAdDurationUs.(II)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (adGroupIndex);
					__args [1] = new JniArgumentValue (adIndexInAdGroup);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdGroupIndexAfterPositionUs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getAdGroupIndexAfterPositionUs", "(J)I", "")]
			public unsafe int GetAdGroupIndexAfterPositionUs (long positionUs)
			{
				const string __id = "getAdGroupIndexAfterPositionUs.(J)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (positionUs);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdGroupIndexForPositionUs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getAdGroupIndexForPositionUs", "(J)I", "")]
			public unsafe int GetAdGroupIndexForPositionUs (long positionUs)
			{
				const string __id = "getAdGroupIndexForPositionUs.(J)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (positionUs);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getAdGroupTimeUs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getAdGroupTimeUs", "(I)J", "")]
			public unsafe long GetAdGroupTimeUs (int adGroupIndex)
			{
				const string __id = "getAdGroupTimeUs.(I)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (adGroupIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getFirstAdIndexToPlay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getFirstAdIndexToPlay", "(I)I", "")]
			public unsafe int GetFirstAdIndexToPlay (int adGroupIndex)
			{
				const string __id = "getFirstAdIndexToPlay.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (adGroupIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='getNextAdIndexToPlay' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("getNextAdIndexToPlay", "(II)I", "")]
			public unsafe int GetNextAdIndexToPlay (int adGroupIndex, int lastPlayedAdIndex)
			{
				const string __id = "getNextAdIndexToPlay.(II)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (adGroupIndex);
					__args [1] = new JniArgumentValue (lastPlayedAdIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='hasPlayedAdGroup' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("hasPlayedAdGroup", "(I)Z", "")]
			public unsafe bool HasPlayedAdGroup (int adGroupIndex)
			{
				const string __id = "hasPlayedAdGroup.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (adGroupIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='isAdAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("isAdAvailable", "(II)Z", "")]
			public unsafe bool IsAdAvailable (int adGroupIndex, int adIndexInAdGroup)
			{
				const string __id = "isAdAvailable.(II)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (adGroupIndex);
					__args [1] = new JniArgumentValue (adIndexInAdGroup);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='set' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
			[Register ("set", "(Ljava/lang/Object;Ljava/lang/Object;IJJ)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period Set (global::Java.Lang.Object id, global::Java.Lang.Object uid, int windowIndex, long durationUs, long positionInWindowUs)
			{
				const string __id = "set.(Ljava/lang/Object;Ljava/lang/Object;IJJ)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
					__args [1] = new JniArgumentValue ((uid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uid).Handle);
					__args [2] = new JniArgumentValue (windowIndex);
					__args [3] = new JniArgumentValue (durationUs);
					__args [4] = new JniArgumentValue (positionInWindowUs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (id);
					global::System.GC.KeepAlive (uid);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Period']/method[@name='set' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='com.example.androidtvlibrary.main.adapter.AdPlaybackStateTest']]"
			[Register ("set", "(Ljava/lang/Object;Ljava/lang/Object;IJJLcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period Set (global::Java.Lang.Object id, global::Java.Lang.Object uid, int windowIndex, long durationUs, long positionInWindowUs, global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest adPlaybackState)
			{
				const string __id = "set.(Ljava/lang/Object;Ljava/lang/Object;IJJLcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue ((id == null) ? IntPtr.Zero : ((global::Java.Lang.Object) id).Handle);
					__args [1] = new JniArgumentValue ((uid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uid).Handle);
					__args [2] = new JniArgumentValue (windowIndex);
					__args [3] = new JniArgumentValue (durationUs);
					__args [4] = new JniArgumentValue (positionInWindowUs);
					__args [5] = new JniArgumentValue ((adPlaybackState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adPlaybackState).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (id);
					global::System.GC.KeepAlive (uid);
					global::System.GC.KeepAlive (adPlaybackState);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Timeline$Window", DoNotGenerateAcw=true)]
		public sealed partial class Window : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='firstPeriodIndex']"
			[Register ("firstPeriodIndex")]
			public int FirstPeriodIndex {
				get {
					const string __id = "firstPeriodIndex.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "firstPeriodIndex.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='isDynamic']"
			[Register ("isDynamic")]
			public bool IsDynamic {
				get {
					const string __id = "isDynamic.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isDynamic.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='isLive']"
			[Register ("isLive")]
			public bool IsLive {
				get {
					const string __id = "isLive.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isLive.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='isSeekable']"
			[Register ("isSeekable")]
			public bool IsSeekable {
				get {
					const string __id = "isSeekable.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isSeekable.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='lastPeriodIndex']"
			[Register ("lastPeriodIndex")]
			public int LastPeriodIndex {
				get {
					const string __id = "lastPeriodIndex.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "lastPeriodIndex.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='manifest']"
			[Register ("manifest")]
			public global::Java.Lang.Object Manifest {
				get {
					const string __id = "manifest.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "manifest.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='presentationStartTimeMs']"
			[Register ("presentationStartTimeMs")]
			public long PresentationStartTimeMs {
				get {
					const string __id = "presentationStartTimeMs.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "presentationStartTimeMs.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='SINGLE_WINDOW_UID']"
			[Register ("SINGLE_WINDOW_UID")]
			public static global::Java.Lang.Object SingleWindowUid {
				get {
					const string __id = "SINGLE_WINDOW_UID.Ljava/lang/Object;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='tag']"
			[Register ("tag")]
			public global::Java.Lang.Object Tag {
				get {
					const string __id = "tag.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "tag.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='uid']"
			[Register ("uid")]
			public global::Java.Lang.Object Uid {
				get {
					const string __id = "uid.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "uid.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/field[@name='windowStartTimeMs']"
			[Register ("windowStartTimeMs")]
			public long WindowStartTimeMs {
				get {
					const string __id = "windowStartTimeMs.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "windowStartTimeMs.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Timeline$Window", typeof (Window));

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

			internal Window (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/constructor[@name='Timeline.Window' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Window () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe long DefaultPositionMs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='getDefaultPositionMs' and count(parameter)=0]"
				[Register ("getDefaultPositionMs", "()J", "")]
				get {
					const string __id = "getDefaultPositionMs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long DefaultPositionUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='getDefaultPositionUs' and count(parameter)=0]"
				[Register ("getDefaultPositionUs", "()J", "")]
				get {
					const string __id = "getDefaultPositionUs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long DurationMs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='getDurationMs' and count(parameter)=0]"
				[Register ("getDurationMs", "()J", "")]
				get {
					const string __id = "getDurationMs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long DurationUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='getDurationUs' and count(parameter)=0]"
				[Register ("getDurationUs", "()J", "")]
				get {
					const string __id = "getDurationUs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long PositionInFirstPeriodMs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='getPositionInFirstPeriodMs' and count(parameter)=0]"
				[Register ("getPositionInFirstPeriodMs", "()J", "")]
				get {
					const string __id = "getPositionInFirstPeriodMs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long PositionInFirstPeriodUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='getPositionInFirstPeriodUs' and count(parameter)=0]"
				[Register ("getPositionInFirstPeriodUs", "()J", "")]
				get {
					const string __id = "getPositionInFirstPeriodUs.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline.Window']/method[@name='set' and count(parameter)=13 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='long'] and parameter[10][@type='long'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='long']]"
			[Register ("set", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;JJZZZJJIIJ)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window Set (global::Java.Lang.Object uid, global::Java.Lang.Object tag, global::Java.Lang.Object manifest, long presentationStartTimeMs, long windowStartTimeMs, bool isSeekable, bool isDynamic, bool isLive, long defaultPositionUs, long durationUs, int firstPeriodIndex, int lastPeriodIndex, long positionInFirstPeriodUs)
			{
				const string __id = "set.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;JJZZZJJIIJ)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [13];
					__args [0] = new JniArgumentValue ((uid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uid).Handle);
					__args [1] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
					__args [2] = new JniArgumentValue ((manifest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifest).Handle);
					__args [3] = new JniArgumentValue (presentationStartTimeMs);
					__args [4] = new JniArgumentValue (windowStartTimeMs);
					__args [5] = new JniArgumentValue (isSeekable);
					__args [6] = new JniArgumentValue (isDynamic);
					__args [7] = new JniArgumentValue (isLive);
					__args [8] = new JniArgumentValue (defaultPositionUs);
					__args [9] = new JniArgumentValue (durationUs);
					__args [10] = new JniArgumentValue (firstPeriodIndex);
					__args [11] = new JniArgumentValue (lastPeriodIndex);
					__args [12] = new JniArgumentValue (positionInFirstPeriodUs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (uid);
					global::System.GC.KeepAlive (tag);
					global::System.GC.KeepAlive (manifest);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Timeline", typeof (Timeline));

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

		protected Timeline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/constructor[@name='Timeline' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Timeline () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeriodCount;
		}
#pragma warning restore 0169

		public abstract int PeriodCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriodCount' and count(parameter)=0]"
			[Register ("getPeriodCount", "()I", "GetGetPeriodCountHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WindowCount;
		}
#pragma warning restore 0169

		public abstract int WindowCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getWindowCount' and count(parameter)=0]"
			[Register ("getWindowCount", "()I", "GetGetWindowCountHandler")]
			get; 
		}

		static Delegate cb_getFirstWindowIndex_Z;
#pragma warning disable 0169
		static Delegate GetGetFirstWindowIndex_ZHandler ()
		{
			if (cb_getFirstWindowIndex_Z == null)
				cb_getFirstWindowIndex_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_I) n_GetFirstWindowIndex_Z);
			return cb_getFirstWindowIndex_Z;
		}

		static int n_GetFirstWindowIndex_Z (IntPtr jnienv, IntPtr native__this, bool shuffleModeEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFirstWindowIndex (shuffleModeEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getFirstWindowIndex' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getFirstWindowIndex", "(Z)I", "GetGetFirstWindowIndex_ZHandler")]
		public virtual unsafe int GetFirstWindowIndex (bool shuffleModeEnabled)
		{
			const string __id = "getFirstWindowIndex.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
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

		static int n_GetIndexOfPeriod_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIndexOfPeriod (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getIndexOfPeriod' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getIndexOfPeriod", "(Ljava/lang/Object;)I", "GetGetIndexOfPeriod_Ljava_lang_Object_Handler")]
		public abstract int GetIndexOfPeriod (global::Java.Lang.Object p0);

		static Delegate cb_getLastWindowIndex_Z;
#pragma warning disable 0169
		static Delegate GetGetLastWindowIndex_ZHandler ()
		{
			if (cb_getLastWindowIndex_Z == null)
				cb_getLastWindowIndex_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_I) n_GetLastWindowIndex_Z);
			return cb_getLastWindowIndex_Z;
		}

		static int n_GetLastWindowIndex_Z (IntPtr jnienv, IntPtr native__this, bool shuffleModeEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLastWindowIndex (shuffleModeEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getLastWindowIndex' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getLastWindowIndex", "(Z)I", "GetGetLastWindowIndex_ZHandler")]
		public virtual unsafe int GetLastWindowIndex (bool shuffleModeEnabled)
		{
			const string __id = "getLastWindowIndex.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getNextPeriodIndex' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("getNextPeriodIndex", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;IZ)I", "")]
		public unsafe int GetNextPeriodIndex (int periodIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, int repeatMode, bool shuffleModeEnabled)
		{
			const string __id = "getNextPeriodIndex.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (periodIndex);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				__args [2] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [3] = new JniArgumentValue (repeatMode);
				__args [4] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (period);
				global::System.GC.KeepAlive (window);
			}
		}

		static Delegate cb_getNextWindowIndex_IIZ;
#pragma warning disable 0169
		static Delegate GetGetNextWindowIndex_IIZHandler ()
		{
			if (cb_getNextWindowIndex_IIZ == null)
				cb_getNextWindowIndex_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIZ_I) n_GetNextWindowIndex_IIZ);
			return cb_getNextWindowIndex_IIZ;
		}

		static int n_GetNextWindowIndex_IIZ (IntPtr jnienv, IntPtr native__this, int windowIndex, int repeatMode, bool shuffleModeEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetNextWindowIndex (windowIndex, repeatMode, shuffleModeEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getNextWindowIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getNextWindowIndex", "(IIZ)I", "GetGetNextWindowIndex_IIZHandler")]
		public virtual unsafe int GetNextWindowIndex (int windowIndex, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"RepeatModeOff", "RepeatModeOne", "RepeatModeAll"})]
		int repeatMode, bool shuffleModeEnabled)
		{
			const string __id = "getNextWindowIndex.(IIZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue (repeatMode);
				__args [2] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriod' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period']]"
		[Register ("getPeriod", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period GetPeriod (int periodIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period)
		{
			const string __id = "getPeriod.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (periodIndex);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (period);
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

		static IntPtr n_GetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPeriod (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriod' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='boolean']]"
		[Register ("getPeriod", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "GetGetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_ZHandler")]
		public abstract global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period GetPeriod (int p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period p1, bool p2);

		static Delegate cb_getPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_;
#pragma warning disable 0169
		static Delegate GetGetPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_Handler ()
		{
			if (cb_getPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_ == null)
				cb_getPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_);
			return cb_getPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_;
		}

		static IntPtr n_GetPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_ (IntPtr jnienv, IntPtr native__this, IntPtr native_periodUid, IntPtr native_period)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var periodUid = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_periodUid, JniHandleOwnership.DoNotTransfer);
			var period = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (native_period, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPeriodByUid (periodUid, period));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriodByUid' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period']]"
		[Register ("getPeriodByUid", "(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "GetGetPeriodByUid_Ljava_lang_Object_Lcom_example_androidtvlibrary_main_adapter_Timeline_Period_Handler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period GetPeriodByUid (global::Java.Lang.Object periodUid, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period)
		{
			const string __id = "getPeriodByUid.(Ljava/lang/Object;Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((periodUid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) periodUid).Handle);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (periodUid);
				global::System.GC.KeepAlive (period);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriodPosition' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("getPeriodPosition", "(Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;IJ)Landroid/util/Pair;", "")]
		public unsafe global::Android.Util.Pair GetPeriodPosition (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period, int windowIndex, long windowPositionUs)
		{
			const string __id = "getPeriodPosition.(Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;IJ)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				__args [2] = new JniArgumentValue (windowIndex);
				__args [3] = new JniArgumentValue (windowPositionUs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (window);
				global::System.GC.KeepAlive (period);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriodPosition' and count(parameter)=5 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("getPeriodPosition", "(Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;IJJ)Landroid/util/Pair;", "")]
		public unsafe global::Android.Util.Pair GetPeriodPosition (global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period, int windowIndex, long windowPositionUs, long defaultPositionProjectionUs)
		{
			const string __id = "getPeriodPosition.(Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;IJJ)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				__args [2] = new JniArgumentValue (windowIndex);
				__args [3] = new JniArgumentValue (windowPositionUs);
				__args [4] = new JniArgumentValue (defaultPositionProjectionUs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (window);
				global::System.GC.KeepAlive (period);
			}
		}

		static Delegate cb_getPreviousWindowIndex_IIZ;
#pragma warning disable 0169
		static Delegate GetGetPreviousWindowIndex_IIZHandler ()
		{
			if (cb_getPreviousWindowIndex_IIZ == null)
				cb_getPreviousWindowIndex_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIZ_I) n_GetPreviousWindowIndex_IIZ);
			return cb_getPreviousWindowIndex_IIZ;
		}

		static int n_GetPreviousWindowIndex_IIZ (IntPtr jnienv, IntPtr native__this, int windowIndex, int repeatMode, bool shuffleModeEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPreviousWindowIndex (windowIndex, repeatMode, shuffleModeEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPreviousWindowIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getPreviousWindowIndex", "(IIZ)I", "GetGetPreviousWindowIndex_IIZHandler")]
		public virtual unsafe int GetPreviousWindowIndex (int windowIndex, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.ITestPlayer", Fields = new string [] {"RepeatModeOff", "RepeatModeOne", "RepeatModeAll"})]
		int repeatMode, bool shuffleModeEnabled)
		{
			const string __id = "getPreviousWindowIndex.(IIZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue (repeatMode);
				__args [2] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
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

		static IntPtr n_GetUidOfPeriod_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUidOfPeriod (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getUidOfPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUidOfPeriod", "(I)Ljava/lang/Object;", "GetGetUidOfPeriod_IHandler")]
		public abstract global::Java.Lang.Object GetUidOfPeriod (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getWindow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window']]"
		[Register ("getWindow", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window GetWindow (int windowIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window)
		{
			const string __id = "getWindow.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getWindow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("getWindow", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window GetWindow (int windowIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, bool setTag)
		{
			const string __id = "getWindow.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (windowIndex);
				__args [1] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [2] = new JniArgumentValue (setTag);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (window);
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

		static IntPtr n_GetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_J (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetWindow (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getWindow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[3][@type='long']]"
		[Register ("getWindow", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "GetGetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_JHandler")]
		public abstract global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window GetWindow (int p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='isLastPeriod' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("isLastPeriod", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;IZ)Z", "")]
		public unsafe bool IsLastPeriod (int periodIndex, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period period, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window window, int repeatMode, bool shuffleModeEnabled)
		{
			const string __id = "isLastPeriod.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;IZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (periodIndex);
				__args [1] = new JniArgumentValue ((period == null) ? IntPtr.Zero : ((global::Java.Lang.Object) period).Handle);
				__args [2] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [3] = new JniArgumentValue (repeatMode);
				__args [4] = new JniArgumentValue (shuffleModeEnabled);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (period);
				global::System.GC.KeepAlive (window);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Timeline", DoNotGenerateAcw=true)]
	internal partial class TimelineInvoker : Timeline {
		public TimelineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Timeline", typeof (TimelineInvoker));

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

		public override unsafe int PeriodCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriodCount' and count(parameter)=0]"
			[Register ("getPeriodCount", "()I", "GetGetPeriodCountHandler")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getWindowCount' and count(parameter)=0]"
			[Register ("getWindowCount", "()I", "GetGetWindowCountHandler")]
			get {
				const string __id = "getWindowCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getIndexOfPeriod' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getIndexOfPeriod", "(Ljava/lang/Object;)I", "GetGetIndexOfPeriod_Ljava_lang_Object_Handler")]
		public override unsafe int GetIndexOfPeriod (global::Java.Lang.Object p0)
		{
			const string __id = "getIndexOfPeriod.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getPeriod' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Period'] and parameter[3][@type='boolean']]"
		[Register ("getPeriod", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;", "GetGetPeriod_ILcom_example_androidtvlibrary_main_adapter_Timeline_Period_ZHandler")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period GetPeriod (int p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period p1, bool p2)
		{
			const string __id = "getPeriod.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Period;Z)Lcom/example/androidtvlibrary/main/adapter/Timeline$Period;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Period> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getUidOfPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUidOfPeriod", "(I)Ljava/lang/Object;", "GetGetUidOfPeriod_IHandler")]
		public override unsafe global::Java.Lang.Object GetUidOfPeriod (int p0)
		{
			const string __id = "getUidOfPeriod.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Timeline']/method[@name='getWindow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Timeline.Window'] and parameter[3][@type='long']]"
		[Register ("getWindow", "(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;", "GetGetWindow_ILcom_example_androidtvlibrary_main_adapter_Timeline_Window_JHandler")]
		public override unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window GetWindow (int p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window p1, long p2)
		{
			const string __id = "getWindow.(ILcom/example/androidtvlibrary/main/adapter/Timeline$Window;J)Lcom/example/androidtvlibrary/main/adapter/Timeline$Window;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Timeline.Window> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
