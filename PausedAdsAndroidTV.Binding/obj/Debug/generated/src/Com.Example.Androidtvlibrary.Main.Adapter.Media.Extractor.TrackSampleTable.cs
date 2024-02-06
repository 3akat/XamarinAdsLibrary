using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TrackSampleTable", DoNotGenerateAcw=true)]
	public sealed partial class TrackSampleTable : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='durationUs']"
		[Register ("durationUs")]
		public long DurationUs {
			get {
				const string __id = "durationUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "durationUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='flags']"
		[Register ("flags")]
		public IList<int> Flags {
			get {
				const string __id = "flags.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "flags.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='maximumSize']"
		[Register ("maximumSize")]
		public int MaximumSize {
			get {
				const string __id = "maximumSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maximumSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='offsets']"
		[Register ("offsets")]
		public IList<long> Offsets {
			get {
				const string __id = "offsets.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "offsets.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='sampleCount']"
		[Register ("sampleCount")]
		public int SampleCount {
			get {
				const string __id = "sampleCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sampleCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='sizes']"
		[Register ("sizes")]
		public IList<int> Sizes {
			get {
				const string __id = "sizes.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sizes.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='timestampsUs']"
		[Register ("timestampsUs")]
		public IList<long> TimestampsUs {
			get {
				const string __id = "timestampsUs.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timestampsUs.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/field[@name='track']"
		[Register ("track")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track Track {
			get {
				const string __id = "track.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "track.Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TrackSampleTable", typeof (TrackSampleTable));

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

		internal TrackSampleTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/constructor[@name='TrackSampleTable' and count(parameter)=7 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.Track'] and parameter[2][@type='long[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='long[]'] and parameter[6][@type='int[]'] and parameter[7][@type='long']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;[J[II[J[IJ)V", "")]
		public unsafe TrackSampleTable (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track track, long[] offsets, int[] sizes, int maximumSize, long[] timestampsUs, int[] flags, long durationUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;[J[II[J[IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_offsets = JNIEnv.NewArray (offsets);
			IntPtr native_sizes = JNIEnv.NewArray (sizes);
			IntPtr native_timestampsUs = JNIEnv.NewArray (timestampsUs);
			IntPtr native_flags = JNIEnv.NewArray (flags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				__args [1] = new JniArgumentValue (native_offsets);
				__args [2] = new JniArgumentValue (native_sizes);
				__args [3] = new JniArgumentValue (maximumSize);
				__args [4] = new JniArgumentValue (native_timestampsUs);
				__args [5] = new JniArgumentValue (native_flags);
				__args [6] = new JniArgumentValue (durationUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (offsets != null) {
					JNIEnv.CopyArray (native_offsets, offsets);
					JNIEnv.DeleteLocalRef (native_offsets);
				}
				if (sizes != null) {
					JNIEnv.CopyArray (native_sizes, sizes);
					JNIEnv.DeleteLocalRef (native_sizes);
				}
				if (timestampsUs != null) {
					JNIEnv.CopyArray (native_timestampsUs, timestampsUs);
					JNIEnv.DeleteLocalRef (native_timestampsUs);
				}
				if (flags != null) {
					JNIEnv.CopyArray (native_flags, flags);
					JNIEnv.DeleteLocalRef (native_flags);
				}
				global::System.GC.KeepAlive (track);
				global::System.GC.KeepAlive (offsets);
				global::System.GC.KeepAlive (sizes);
				global::System.GC.KeepAlive (timestampsUs);
				global::System.GC.KeepAlive (flags);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/method[@name='getIndexOfEarlierOrEqualSynchronizationSample' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getIndexOfEarlierOrEqualSynchronizationSample", "(J)I", "")]
		public unsafe int GetIndexOfEarlierOrEqualSynchronizationSample (long timeUs)
		{
			const string __id = "getIndexOfEarlierOrEqualSynchronizationSample.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TrackSampleTable']/method[@name='getIndexOfLaterOrEqualSynchronizationSample' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getIndexOfLaterOrEqualSynchronizationSample", "(J)I", "")]
		public unsafe int GetIndexOfLaterOrEqualSynchronizationSample (long timeUs)
		{
			const string __id = "getIndexOfLaterOrEqualSynchronizationSample.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
