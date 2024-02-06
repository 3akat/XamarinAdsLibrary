using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil", DoNotGenerateAcw=true)]
	public sealed partial class VorbisUtil : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.CommentHeader']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$CommentHeader", DoNotGenerateAcw=true)]
		public sealed partial class CommentHeader : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.CommentHeader']/field[@name='comments']"
			[Register ("comments")]
			public IList<string> Comments {
				get {
					const string __id = "comments.[Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "comments.[Ljava/lang/String;";

					IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.CommentHeader']/field[@name='length']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.CommentHeader']/field[@name='vendor']"
			[Register ("vendor")]
			public string Vendor {
				get {
					const string __id = "vendor.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "vendor.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$CommentHeader", typeof (CommentHeader));

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

			internal CommentHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.CommentHeader']/constructor[@name='VorbisUtil.CommentHeader' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;[Ljava/lang/String;I)V", "")]
			public unsafe CommentHeader (string vendor, string[] comments, int length) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;[Ljava/lang/String;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_vendor = JNIEnv.NewString (vendor);
				IntPtr native_comments = JNIEnv.NewArray (comments);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_vendor);
					__args [1] = new JniArgumentValue (native_comments);
					__args [2] = new JniArgumentValue (length);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_vendor);
					if (comments != null) {
						JNIEnv.CopyArray (native_comments, comments);
						JNIEnv.DeleteLocalRef (native_comments);
					}
					global::System.GC.KeepAlive (comments);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.Mode']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.Mode']/field[@name='blockFlag']"
			[Register ("blockFlag")]
			public bool BlockFlag {
				get {
					const string __id = "blockFlag.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "blockFlag.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.Mode']/field[@name='mapping']"
			[Register ("mapping")]
			public int Mapping {
				get {
					const string __id = "mapping.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "mapping.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.Mode']/field[@name='transformType']"
			[Register ("transformType")]
			public int TransformType {
				get {
					const string __id = "transformType.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "transformType.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.Mode']/field[@name='windowType']"
			[Register ("windowType")]
			public int WindowType {
				get {
					const string __id = "windowType.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "windowType.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$Mode", typeof (Mode));

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

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.Mode']/constructor[@name='VorbisUtil.Mode' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(ZIII)V", "")]
			public unsafe Mode (bool blockFlag, int windowType, int transformType, int mapping) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ZIII)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (blockFlag);
					__args [1] = new JniArgumentValue (windowType);
					__args [2] = new JniArgumentValue (transformType);
					__args [3] = new JniArgumentValue (mapping);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$VorbisIdHeader", DoNotGenerateAcw=true)]
		public sealed partial class VorbisIdHeader : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='bitrateMax']"
			[Register ("bitrateMax")]
			public int BitrateMax {
				get {
					const string __id = "bitrateMax.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "bitrateMax.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='bitrateMin']"
			[Register ("bitrateMin")]
			public int BitrateMin {
				get {
					const string __id = "bitrateMin.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "bitrateMin.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='bitrateNominal']"
			[Register ("bitrateNominal")]
			public int BitrateNominal {
				get {
					const string __id = "bitrateNominal.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "bitrateNominal.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='blockSize0']"
			[Register ("blockSize0")]
			public int BlockSize0 {
				get {
					const string __id = "blockSize0.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "blockSize0.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='blockSize1']"
			[Register ("blockSize1")]
			public int BlockSize1 {
				get {
					const string __id = "blockSize1.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "blockSize1.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='channels']"
			[Register ("channels")]
			public int Channels {
				get {
					const string __id = "channels.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "channels.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='data']"
			[Register ("data")]
			public IList<byte> Data {
				get {
					const string __id = "data.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "data.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='framingFlag']"
			[Register ("framingFlag")]
			public bool FramingFlag {
				get {
					const string __id = "framingFlag.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "framingFlag.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='sampleRate']"
			[Register ("sampleRate")]
			public long SampleRate {
				get {
					const string __id = "sampleRate.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sampleRate.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/field[@name='version']"
			[Register ("version")]
			public long Version {
				get {
					const string __id = "version.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "version.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$VorbisIdHeader", typeof (VorbisIdHeader));

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

			internal VorbisIdHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/constructor[@name='VorbisUtil.VorbisIdHeader' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='boolean'] and parameter[10][@type='byte[]']]"
			[Register (".ctor", "(JIJIIIIIZ[B)V", "")]
			public unsafe VorbisIdHeader (long version, int channels, long sampleRate, int bitrateMax, int bitrateNominal, int bitrateMin, int blockSize0, int blockSize1, bool framingFlag, byte[] data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JIJIIIIIZ[B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [10];
					__args [0] = new JniArgumentValue (version);
					__args [1] = new JniArgumentValue (channels);
					__args [2] = new JniArgumentValue (sampleRate);
					__args [3] = new JniArgumentValue (bitrateMax);
					__args [4] = new JniArgumentValue (bitrateNominal);
					__args [5] = new JniArgumentValue (bitrateMin);
					__args [6] = new JniArgumentValue (blockSize0);
					__args [7] = new JniArgumentValue (blockSize1);
					__args [8] = new JniArgumentValue (framingFlag);
					__args [9] = new JniArgumentValue (native_data);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			public unsafe int ApproximateBitrate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil.VorbisIdHeader']/method[@name='getApproximateBitrate' and count(parameter)=0]"
				[Register ("getApproximateBitrate", "()I", "")]
				get {
					const string __id = "getApproximateBitrate.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil", typeof (VorbisUtil));

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

		internal VorbisUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']/method[@name='iLog' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iLog", "(I)I", "")]
		public static unsafe int ILog (int x)
		{
			const string __id = "iLog.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']/method[@name='readVorbisCommentHeader' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("readVorbisCommentHeader", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$CommentHeader;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.CommentHeader ReadVorbisCommentHeader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray headerData)
		{
			const string __id = "readVorbisCommentHeader.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$CommentHeader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((headerData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headerData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.CommentHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (headerData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']/method[@name='readVorbisCommentHeader' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("readVorbisCommentHeader", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;ZZ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$CommentHeader;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.CommentHeader ReadVorbisCommentHeader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray headerData, bool hasMetadataHeader, bool hasFramingBit)
		{
			const string __id = "readVorbisCommentHeader.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;ZZ)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$CommentHeader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((headerData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headerData).Handle);
				__args [1] = new JniArgumentValue (hasMetadataHeader);
				__args [2] = new JniArgumentValue (hasFramingBit);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.CommentHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (headerData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']/method[@name='readVorbisIdentificationHeader' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("readVorbisIdentificationHeader", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$VorbisIdHeader;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.VorbisIdHeader ReadVorbisIdentificationHeader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray headerData)
		{
			const string __id = "readVorbisIdentificationHeader.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$VorbisIdHeader;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((headerData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headerData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.VorbisIdHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (headerData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']/method[@name='readVorbisModes' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("readVorbisModes", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)[Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$Mode;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.Mode[] ReadVorbisModes (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray headerData, int channels)
		{
			const string __id = "readVorbisModes.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)[Lcom/example/androidtvlibrary/main/adapter/Media/extractor/VorbisUtil$Mode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((headerData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headerData).Handle);
				__args [1] = new JniArgumentValue (channels);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.Mode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.VorbisUtil.Mode));
			} finally {
				global::System.GC.KeepAlive (headerData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='VorbisUtil']/method[@name='verifyVorbisHeaderCapturePattern' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[3][@type='boolean']]"
		[Register ("verifyVorbisHeaderCapturePattern", "(ILcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Z)Z", "")]
		public static unsafe bool VerifyVorbisHeaderCapturePattern (int headerType, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray header, bool quiet)
		{
			const string __id = "verifyVorbisHeaderCapturePattern.(ILcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (headerType);
				__args [1] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				__args [2] = new JniArgumentValue (quiet);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (header);
			}
		}

	}
}
