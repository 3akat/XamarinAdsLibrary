using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FixedSampleSizeRechunker", DoNotGenerateAcw=true)]
	public sealed partial class FixedSampleSizeRechunker : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FixedSampleSizeRechunker$Results", DoNotGenerateAcw=true)]
		public sealed partial class Results : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']/field[@name='duration']"
			[Register ("duration")]
			public long Duration {
				get {
					const string __id = "duration.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "duration.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']/field[@name='flags']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']/field[@name='maximumSize']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']/field[@name='offsets']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']/field[@name='sizes']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker.Results']/field[@name='timestamps']"
			[Register ("timestamps")]
			public IList<long> Timestamps {
				get {
					const string __id = "timestamps.[J";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "timestamps.[J";

					IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FixedSampleSizeRechunker$Results", typeof (Results));

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

			internal Results (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FixedSampleSizeRechunker", typeof (FixedSampleSizeRechunker));

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

		internal FixedSampleSizeRechunker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FixedSampleSizeRechunker']/method[@name='rechunk' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long[]'] and parameter[3][@type='int[]'] and parameter[4][@type='long']]"
		[Register ("rechunk", "(I[J[IJ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FixedSampleSizeRechunker$Results;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FixedSampleSizeRechunker.Results Rechunk (int fixedSampleSize, long[] chunkOffsets, int[] chunkSampleCounts, long timestampDeltaInTimeUnits)
		{
			const string __id = "rechunk.(I[J[IJ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/FixedSampleSizeRechunker$Results;";
			IntPtr native_chunkOffsets = JNIEnv.NewArray (chunkOffsets);
			IntPtr native_chunkSampleCounts = JNIEnv.NewArray (chunkSampleCounts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (fixedSampleSize);
				__args [1] = new JniArgumentValue (native_chunkOffsets);
				__args [2] = new JniArgumentValue (native_chunkSampleCounts);
				__args [3] = new JniArgumentValue (timestampDeltaInTimeUnits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FixedSampleSizeRechunker.Results> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (chunkOffsets != null) {
					JNIEnv.CopyArray (native_chunkOffsets, chunkOffsets);
					JNIEnv.DeleteLocalRef (native_chunkOffsets);
				}
				if (chunkSampleCounts != null) {
					JNIEnv.CopyArray (native_chunkSampleCounts, chunkSampleCounts);
					JNIEnv.DeleteLocalRef (native_chunkSampleCounts);
				}
				global::System.GC.KeepAlive (chunkOffsets);
				global::System.GC.KeepAlive (chunkSampleCounts);
			}
		}

	}
}
