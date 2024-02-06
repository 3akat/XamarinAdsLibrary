using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker", DoNotGenerateAcw=true)]
	public abstract partial class BinarySearchSeeker : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/field[@name='timestampSeeker']"
		[Register ("timestampSeeker")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.ITimestampSeeker TimestampSeeker {
			get {
				const string __id = "timestampSeeker.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.ITimestampSeeker> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timestampSeeker.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.DefaultSeekTimestampConverter']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$DefaultSeekTimestampConverter", DoNotGenerateAcw=true)]
		public sealed partial class DefaultSeekTimestampConverter : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$DefaultSeekTimestampConverter", typeof (DefaultSeekTimestampConverter));

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

			internal DefaultSeekTimestampConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.DefaultSeekTimestampConverter']/constructor[@name='BinarySearchSeeker.DefaultSeekTimestampConverter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DefaultSeekTimestampConverter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.DefaultSeekTimestampConverter']/method[@name='timeUsToTargetTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("timeUsToTargetTime", "(J)J", "")]
			public unsafe long TimeUsToTargetTime (long timeUs)
			{
				const string __id = "timeUsToTargetTime.(J)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (timeUs);
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.SeekOperationParams']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekOperationParams", DoNotGenerateAcw=true)]
		protected internal partial class SeekOperationParams : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekOperationParams", typeof (SeekOperationParams));

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

			protected SeekOperationParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.SeekOperationParams']/constructor[@name='BinarySearchSeeker.SeekOperationParams' and count(parameter)=7 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
			[Register (".ctor", "(JJJJJJJ)V", "")]
			protected unsafe SeekOperationParams (long seekTimeUs, long targetTimePosition, long floorTimePosition, long ceilingTimePosition, long floorBytePosition, long ceilingBytePosition, long approxBytesPerFrame) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJJJJJJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (seekTimeUs);
					__args [1] = new JniArgumentValue (targetTimePosition);
					__args [2] = new JniArgumentValue (floorTimePosition);
					__args [3] = new JniArgumentValue (ceilingTimePosition);
					__args [4] = new JniArgumentValue (floorBytePosition);
					__args [5] = new JniArgumentValue (ceilingBytePosition);
					__args [6] = new JniArgumentValue (approxBytesPerFrame);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.SeekOperationParams']/method[@name='calculateNextSearchBytePosition' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
			[Register ("calculateNextSearchBytePosition", "(JJJJJJ)J", "")]
			protected static unsafe long CalculateNextSearchBytePosition (long targetTimePosition, long floorTimePosition, long ceilingTimePosition, long floorBytePosition, long ceilingBytePosition, long approxBytesPerFrame)
			{
				const string __id = "calculateNextSearchBytePosition.(JJJJJJ)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (targetTimePosition);
					__args [1] = new JniArgumentValue (floorTimePosition);
					__args [2] = new JniArgumentValue (ceilingTimePosition);
					__args [3] = new JniArgumentValue (floorBytePosition);
					__args [4] = new JniArgumentValue (ceilingBytePosition);
					__args [5] = new JniArgumentValue (approxBytesPerFrame);
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='BinarySearchSeeker.SeekTimestampConverter']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekTimestampConverter", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker/ISeekTimestampConverterInvoker")]
		protected internal partial interface ISeekTimestampConverter : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='BinarySearchSeeker.SeekTimestampConverter']/method[@name='timeUsToTargetTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("timeUsToTargetTime", "(J)J", "GetTimeUsToTargetTime_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker/ISeekTimestampConverterInvoker, PausedAdsAndroidTV.Binding")]
			long TimeUsToTargetTime (long p0);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekTimestampConverter", DoNotGenerateAcw=true)]
		internal partial class ISeekTimestampConverterInvoker : global::Java.Lang.Object, ISeekTimestampConverter {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekTimestampConverter", typeof (ISeekTimestampConverterInvoker));

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

			public static ISeekTimestampConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISeekTimestampConverter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.BinarySearchSeeker.SeekTimestampConverter'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISeekTimestampConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_timeUsToTargetTime_J;
#pragma warning disable 0169
			static Delegate GetTimeUsToTargetTime_JHandler ()
			{
				if (cb_timeUsToTargetTime_J == null)
					cb_timeUsToTargetTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_TimeUsToTargetTime_J);
				return cb_timeUsToTargetTime_J;
			}

			static long n_TimeUsToTargetTime_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.ISeekTimestampConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TimeUsToTargetTime (p0);
			}
#pragma warning restore 0169

			IntPtr id_timeUsToTargetTime_J;
			public unsafe long TimeUsToTargetTime (long p0)
			{
				if (id_timeUsToTargetTime_J == IntPtr.Zero)
					id_timeUsToTargetTime_J = JNIEnv.GetMethodID (class_ref, "timeUsToTargetTime", "(J)J");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_timeUsToTargetTime_J, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult", DoNotGenerateAcw=true)]
		public sealed partial class TimestampSearchResult : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/field[@name='NO_TIMESTAMP_IN_RANGE_RESULT']"
			[Register ("NO_TIMESTAMP_IN_RANGE_RESULT")]
			public static global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult NoTimestampInRangeResult {
				get {
					const string __id = "NO_TIMESTAMP_IN_RANGE_RESULT.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/field[@name='TYPE_NO_TIMESTAMP']"
			[Register ("TYPE_NO_TIMESTAMP")]
			public const int TypeNoTimestamp = (int) -3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/field[@name='TYPE_POSITION_OVERESTIMATED']"
			[Register ("TYPE_POSITION_OVERESTIMATED")]
			public const int TypePositionOverestimated = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/field[@name='TYPE_POSITION_UNDERESTIMATED']"
			[Register ("TYPE_POSITION_UNDERESTIMATED")]
			public const int TypePositionUnderestimated = (int) -2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/field[@name='TYPE_TARGET_TIMESTAMP_FOUND']"
			[Register ("TYPE_TARGET_TIMESTAMP_FOUND")]
			public const int TypeTargetTimestampFound = (int) 0;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult", typeof (TimestampSearchResult));

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

			internal TimestampSearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/method[@name='overestimatedResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("overestimatedResult", "(JJ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;", "")]
			public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult OverestimatedResult (long newCeilingTimestamp, long newCeilingBytePosition)
			{
				const string __id = "overestimatedResult.(JJ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (newCeilingTimestamp);
					__args [1] = new JniArgumentValue (newCeilingBytePosition);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/method[@name='targetFoundResult' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("targetFoundResult", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;", "")]
			public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult TargetFoundResult (long resultBytePosition)
			{
				const string __id = "targetFoundResult.(J)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resultBytePosition);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker.TimestampSearchResult']/method[@name='underestimatedResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("underestimatedResult", "(JJ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;", "")]
			public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult UnderestimatedResult (long newFloorTimestamp, long newCeilingBytePosition)
			{
				const string __id = "underestimatedResult.(JJ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (newFloorTimestamp);
					__args [1] = new JniArgumentValue (newCeilingBytePosition);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='BinarySearchSeeker.TimestampSeeker']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker/ITimestampSeekerInvoker")]
		protected internal partial interface ITimestampSeeker : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='BinarySearchSeeker.TimestampSeeker']/method[@name='searchForTimestamp' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='long']]"
			[Register ("searchForTimestamp", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;J)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;", "GetSearchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker/ITimestampSeekerInvoker, PausedAdsAndroidTV.Binding")]
			global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult SearchForTimestamp (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0, long p1);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker", DoNotGenerateAcw=true)]
		internal partial class ITimestampSeekerInvoker : global::Java.Lang.Object, ITimestampSeeker {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker", typeof (ITimestampSeekerInvoker));

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

			public static ITimestampSeeker GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITimestampSeeker> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.BinarySearchSeeker.TimestampSeeker'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITimestampSeekerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J;
#pragma warning disable 0169
			static Delegate GetSearchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_JHandler ()
			{
				if (cb_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J == null)
					cb_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_SearchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J);
				return cb_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J;
			}

			static IntPtr n_SearchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.ITimestampSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SearchForTimestamp (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J;
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult SearchForTimestamp (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput p0, long p1)
			{
				if (id_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J == IntPtr.Zero)
					id_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J = JNIEnv.GetMethodID (class_ref, "searchForTimestamp", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;J)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSearchResult;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.TimestampSearchResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_searchForTimestamp_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker", typeof (BinarySearchSeeker));

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

		protected BinarySearchSeeker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/constructor[@name='BinarySearchSeeker' and count(parameter)=9 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.BinarySearchSeeker.SeekTimestampConverter'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.BinarySearchSeeker.TimestampSeeker'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='long'] and parameter[9][@type='int']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekTimestampConverter;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker;JJJJJJI)V", "")]
		protected unsafe BinarySearchSeeker (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.ISeekTimestampConverter seekTimestampConverter, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.ITimestampSeeker timestampSeeker, long durationUs, long floorTimePosition, long ceilingTimePosition, long floorBytePosition, long ceilingBytePosition, long approxBytesPerFrame, int minimumSearchRange) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekTimestampConverter;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$TimestampSeeker;JJJJJJI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((seekTimestampConverter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekTimestampConverter).Handle);
				__args [1] = new JniArgumentValue ((timestampSeeker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampSeeker).Handle);
				__args [2] = new JniArgumentValue (durationUs);
				__args [3] = new JniArgumentValue (floorTimePosition);
				__args [4] = new JniArgumentValue (ceilingTimePosition);
				__args [5] = new JniArgumentValue (floorBytePosition);
				__args [6] = new JniArgumentValue (ceilingBytePosition);
				__args [7] = new JniArgumentValue (approxBytesPerFrame);
				__args [8] = new JniArgumentValue (minimumSearchRange);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (seekTimestampConverter);
				global::System.GC.KeepAlive (timestampSeeker);
			}
		}

		public unsafe bool IsSeeking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='isSeeking' and count(parameter)=0]"
			[Register ("isSeeking", "()Z", "")]
			get {
				const string __id = "isSeeking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap SeekMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='getSeekMap' and count(parameter)=0]"
			[Register ("getSeekMap", "()Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap;", "")]
			get {
				const string __id = "getSeekMap.()Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createSeekParamsForTargetTimeUs_J;
#pragma warning disable 0169
		static Delegate GetCreateSeekParamsForTargetTimeUs_JHandler ()
		{
			if (cb_createSeekParamsForTargetTimeUs_J == null)
				cb_createSeekParamsForTargetTimeUs_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_CreateSeekParamsForTargetTimeUs_J);
			return cb_createSeekParamsForTargetTimeUs_J;
		}

		static IntPtr n_CreateSeekParamsForTargetTimeUs_J (IntPtr jnienv, IntPtr native__this, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateSeekParamsForTargetTimeUs (timeUs));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='createSeekParamsForTargetTimeUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("createSeekParamsForTargetTimeUs", "(J)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekOperationParams;", "GetCreateSeekParamsForTargetTimeUs_JHandler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.SeekOperationParams CreateSeekParamsForTargetTimeUs (long timeUs)
		{
			const string __id = "createSeekParamsForTargetTimeUs.(J)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker$SeekOperationParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker.SeekOperationParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_handlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
#pragma warning disable 0169
		static Delegate GetHandlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_Handler ()
		{
			if (cb_handlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ == null)
				cb_handlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_HandlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_);
			return cb_handlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
		}

		static int n_HandlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_seekPositionHolder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_input, JniHandleOwnership.DoNotTransfer);
			var seekPositionHolder = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder> (native_seekPositionHolder, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.HandlePendingSeek (input, seekPositionHolder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='handlePendingSeek' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.PositionHolder']]"
		[Register ("handlePendingSeek", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I", "GetHandlePendingSeek_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_Handler")]
		public virtual unsafe int HandlePendingSeek (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder seekPositionHolder)
		{
			const string __id = "handlePendingSeek.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((seekPositionHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekPositionHolder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (seekPositionHolder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='markSeekOperationFinished' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
		[Register ("markSeekOperationFinished", "(ZJ)V", "")]
		protected unsafe void MarkSeekOperationFinished (bool foundTargetFrame, long resultPosition)
		{
			const string __id = "markSeekOperationFinished.(ZJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (foundTargetFrame);
				__args [1] = new JniArgumentValue (resultPosition);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSeekOperationFinished_ZJ;
#pragma warning disable 0169
		static Delegate GetOnSeekOperationFinished_ZJHandler ()
		{
			if (cb_onSeekOperationFinished_ZJ == null)
				cb_onSeekOperationFinished_ZJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZJ_V) n_OnSeekOperationFinished_ZJ);
			return cb_onSeekOperationFinished_ZJ;
		}

		static void n_OnSeekOperationFinished_ZJ (IntPtr jnienv, IntPtr native__this, bool foundTargetFrame, long resultPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.BinarySearchSeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSeekOperationFinished (foundTargetFrame, resultPosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='onSeekOperationFinished' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
		[Register ("onSeekOperationFinished", "(ZJ)V", "GetOnSeekOperationFinished_ZJHandler")]
		protected virtual unsafe void OnSeekOperationFinished (bool foundTargetFrame, long resultPosition)
		{
			const string __id = "onSeekOperationFinished.(ZJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (foundTargetFrame);
				__args [1] = new JniArgumentValue (resultPosition);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='seekToPosition' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.PositionHolder']]"
		[Register ("seekToPosition", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;JLcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I", "")]
		protected unsafe int SeekToPosition (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, long position, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder seekPositionHolder)
		{
			const string __id = "seekToPosition.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;JLcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue (position);
				__args [2] = new JniArgumentValue ((seekPositionHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekPositionHolder).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (seekPositionHolder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='setSeekTargetUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setSeekTargetUs", "(J)V", "")]
		public unsafe void SetSeekTargetUs (long timeUs)
		{
			const string __id = "setSeekTargetUs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='BinarySearchSeeker']/method[@name='skipInputUntilPosition' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='long']]"
		[Register ("skipInputUntilPosition", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;J)Z", "")]
		protected unsafe bool SkipInputUntilPosition (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, long position)
		{
			const string __id = "skipInputUntilPosition.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker", DoNotGenerateAcw=true)]
	internal partial class BinarySearchSeekerInvoker : BinarySearchSeeker {
		public BinarySearchSeekerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/BinarySearchSeeker", typeof (BinarySearchSeekerInvoker));

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
