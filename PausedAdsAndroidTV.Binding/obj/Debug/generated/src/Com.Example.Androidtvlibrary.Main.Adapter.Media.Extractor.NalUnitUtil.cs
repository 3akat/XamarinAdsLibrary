using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil", DoNotGenerateAcw=true)]
	public sealed partial class NalUnitUtil : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/field[@name='ASPECT_RATIO_IDC_VALUES']"
		[Register ("ASPECT_RATIO_IDC_VALUES")]
		public static IList<float> AspectRatioIdcValues {
			get {
				const string __id = "ASPECT_RATIO_IDC_VALUES.[F";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/field[@name='EXTENDED_SAR']"
		[Register ("EXTENDED_SAR")]
		public const int ExtendedSar = (int) 255;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/field[@name='NAL_START_CODE']"
		[Register ("NAL_START_CODE")]
		public static IList<byte> NalStartCode {
			get {
				const string __id = "NAL_START_CODE.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.PpsData']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$PpsData", DoNotGenerateAcw=true)]
		public sealed partial class PpsData : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.PpsData']/field[@name='bottomFieldPicOrderInFramePresentFlag']"
			[Register ("bottomFieldPicOrderInFramePresentFlag")]
			public bool BottomFieldPicOrderInFramePresentFlag {
				get {
					const string __id = "bottomFieldPicOrderInFramePresentFlag.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "bottomFieldPicOrderInFramePresentFlag.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.PpsData']/field[@name='picParameterSetId']"
			[Register ("picParameterSetId")]
			public int PicParameterSetId {
				get {
					const string __id = "picParameterSetId.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "picParameterSetId.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.PpsData']/field[@name='seqParameterSetId']"
			[Register ("seqParameterSetId")]
			public int SeqParameterSetId {
				get {
					const string __id = "seqParameterSetId.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "seqParameterSetId.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$PpsData", typeof (PpsData));

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

			internal PpsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.PpsData']/constructor[@name='NalUnitUtil.PpsData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(IIZ)V", "")]
			public unsafe PpsData (int picParameterSetId, int seqParameterSetId, bool bottomFieldPicOrderInFramePresentFlag) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (picParameterSetId);
					__args [1] = new JniArgumentValue (seqParameterSetId);
					__args [2] = new JniArgumentValue (bottomFieldPicOrderInFramePresentFlag);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$SpsData", DoNotGenerateAcw=true)]
		public sealed partial class SpsData : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='constraintsFlagsAndReservedZero2Bits']"
			[Register ("constraintsFlagsAndReservedZero2Bits")]
			public int ConstraintsFlagsAndReservedZero2Bits {
				get {
					const string __id = "constraintsFlagsAndReservedZero2Bits.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "constraintsFlagsAndReservedZero2Bits.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='deltaPicOrderAlwaysZeroFlag']"
			[Register ("deltaPicOrderAlwaysZeroFlag")]
			public bool DeltaPicOrderAlwaysZeroFlag {
				get {
					const string __id = "deltaPicOrderAlwaysZeroFlag.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "deltaPicOrderAlwaysZeroFlag.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='frameMbsOnlyFlag']"
			[Register ("frameMbsOnlyFlag")]
			public bool FrameMbsOnlyFlag {
				get {
					const string __id = "frameMbsOnlyFlag.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "frameMbsOnlyFlag.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='frameNumLength']"
			[Register ("frameNumLength")]
			public int FrameNumLength {
				get {
					const string __id = "frameNumLength.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "frameNumLength.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					const string __id = "height.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "height.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='levelIdc']"
			[Register ("levelIdc")]
			public int LevelIdc {
				get {
					const string __id = "levelIdc.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "levelIdc.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='picOrderCntLsbLength']"
			[Register ("picOrderCntLsbLength")]
			public int PicOrderCntLsbLength {
				get {
					const string __id = "picOrderCntLsbLength.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "picOrderCntLsbLength.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='picOrderCountType']"
			[Register ("picOrderCountType")]
			public int PicOrderCountType {
				get {
					const string __id = "picOrderCountType.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "picOrderCountType.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='pixelWidthAspectRatio']"
			[Register ("pixelWidthAspectRatio")]
			public float PixelWidthAspectRatio {
				get {
					const string __id = "pixelWidthAspectRatio.F";

					var __v = _members.InstanceFields.GetSingleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "pixelWidthAspectRatio.F";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='profileIdc']"
			[Register ("profileIdc")]
			public int ProfileIdc {
				get {
					const string __id = "profileIdc.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "profileIdc.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='separateColorPlaneFlag']"
			[Register ("separateColorPlaneFlag")]
			public bool SeparateColorPlaneFlag {
				get {
					const string __id = "separateColorPlaneFlag.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "separateColorPlaneFlag.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='seqParameterSetId']"
			[Register ("seqParameterSetId")]
			public int SeqParameterSetId {
				get {
					const string __id = "seqParameterSetId.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "seqParameterSetId.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					const string __id = "width.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "width.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$SpsData", typeof (SpsData));

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

			internal SpsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil.SpsData']/constructor[@name='NalUnitUtil.SpsData' and count(parameter)=13 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='float'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='boolean']]"
			[Register (".ctor", "(IIIIIIFZZIIIZ)V", "")]
			public unsafe SpsData (int profileIdc, int constraintsFlagsAndReservedZero2Bits, int levelIdc, int seqParameterSetId, int width, int height, float pixelWidthAspectRatio, bool separateColorPlaneFlag, bool frameMbsOnlyFlag, int frameNumLength, int picOrderCountType, int picOrderCntLsbLength, bool deltaPicOrderAlwaysZeroFlag) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIIIIIFZZIIIZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [13];
					__args [0] = new JniArgumentValue (profileIdc);
					__args [1] = new JniArgumentValue (constraintsFlagsAndReservedZero2Bits);
					__args [2] = new JniArgumentValue (levelIdc);
					__args [3] = new JniArgumentValue (seqParameterSetId);
					__args [4] = new JniArgumentValue (width);
					__args [5] = new JniArgumentValue (height);
					__args [6] = new JniArgumentValue (pixelWidthAspectRatio);
					__args [7] = new JniArgumentValue (separateColorPlaneFlag);
					__args [8] = new JniArgumentValue (frameMbsOnlyFlag);
					__args [9] = new JniArgumentValue (frameNumLength);
					__args [10] = new JniArgumentValue (picOrderCountType);
					__args [11] = new JniArgumentValue (picOrderCntLsbLength);
					__args [12] = new JniArgumentValue (deltaPicOrderAlwaysZeroFlag);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil", typeof (NalUnitUtil));

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

		internal NalUnitUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='clearPrefixFlags' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("clearPrefixFlags", "([Z)V", "")]
		public static unsafe void ClearPrefixFlags (bool[] prefixFlags)
		{
			const string __id = "clearPrefixFlags.([Z)V";
			IntPtr native_prefixFlags = JNIEnv.NewArray (prefixFlags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefixFlags);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (prefixFlags != null) {
					JNIEnv.CopyArray (native_prefixFlags, prefixFlags);
					JNIEnv.DeleteLocalRef (native_prefixFlags);
				}
				global::System.GC.KeepAlive (prefixFlags);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='discardToSps' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("discardToSps", "(Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void DiscardToSps (global::Java.Nio.ByteBuffer data)
		{
			const string __id = "discardToSps.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='findNalUnit' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean[]']]"
		[Register ("findNalUnit", "([BII[Z)I", "")]
		public static unsafe int FindNalUnit (byte[] data, int startOffset, int endOffset, bool[] prefixFlags)
		{
			const string __id = "findNalUnit.([BII[Z)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_prefixFlags = JNIEnv.NewArray (prefixFlags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (startOffset);
				__args [2] = new JniArgumentValue (endOffset);
				__args [3] = new JniArgumentValue (native_prefixFlags);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (prefixFlags != null) {
					JNIEnv.CopyArray (native_prefixFlags, prefixFlags);
					JNIEnv.DeleteLocalRef (native_prefixFlags);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (prefixFlags);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='getH265NalUnitType' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getH265NalUnitType", "([BI)I", "")]
		public static unsafe int GetH265NalUnitType (byte[] data, int offset)
		{
			const string __id = "getH265NalUnitType.([BI)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='getNalUnitType' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getNalUnitType", "([BI)I", "")]
		public static unsafe int GetNalUnitType (byte[] data, int offset)
		{
			const string __id = "getNalUnitType.([BI)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='isNalUnitSei' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte']]"
		[Register ("isNalUnitSei", "(Ljava/lang/String;B)Z", "")]
		public static unsafe bool IsNalUnitSei (string mimeType, sbyte nalUnitHeaderFirstByte)
		{
			const string __id = "isNalUnitSei.(Ljava/lang/String;B)Z";
			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_mimeType);
				__args [1] = new JniArgumentValue (nalUnitHeaderFirstByte);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='parsePpsNalUnit' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("parsePpsNalUnit", "([BII)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$PpsData;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.NalUnitUtil.PpsData ParsePpsNalUnit (byte[] nalData, int nalOffset, int nalLimit)
		{
			const string __id = "parsePpsNalUnit.([BII)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$PpsData;";
			IntPtr native_nalData = JNIEnv.NewArray (nalData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_nalData);
				__args [1] = new JniArgumentValue (nalOffset);
				__args [2] = new JniArgumentValue (nalLimit);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.NalUnitUtil.PpsData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (nalData != null) {
					JNIEnv.CopyArray (native_nalData, nalData);
					JNIEnv.DeleteLocalRef (native_nalData);
				}
				global::System.GC.KeepAlive (nalData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='parseSpsNalUnit' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("parseSpsNalUnit", "([BII)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$SpsData;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.NalUnitUtil.SpsData ParseSpsNalUnit (byte[] nalData, int nalOffset, int nalLimit)
		{
			const string __id = "parseSpsNalUnit.([BII)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/NalUnitUtil$SpsData;";
			IntPtr native_nalData = JNIEnv.NewArray (nalData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_nalData);
				__args [1] = new JniArgumentValue (nalOffset);
				__args [2] = new JniArgumentValue (nalLimit);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.NalUnitUtil.SpsData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (nalData != null) {
					JNIEnv.CopyArray (native_nalData, nalData);
					JNIEnv.DeleteLocalRef (native_nalData);
				}
				global::System.GC.KeepAlive (nalData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='NalUnitUtil']/method[@name='unescapeStream' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("unescapeStream", "([BI)I", "")]
		public static unsafe int UnescapeStream (byte[] data, int limit)
		{
			const string __id = "unescapeStream.([BI)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (limit);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
