using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand", DoNotGenerateAcw=true)]
	public sealed partial class SpliceInsertCommand : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.SpliceCommand {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='autoReturn']"
		[Register ("autoReturn")]
		public bool AutoReturn {
			get {
				const string __id = "autoReturn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "autoReturn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='availNum']"
		[Register ("availNum")]
		public int AvailNum {
			get {
				const string __id = "availNum.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "availNum.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='availsExpected']"
		[Register ("availsExpected")]
		public int AvailsExpected {
			get {
				const string __id = "availsExpected.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "availsExpected.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='breakDurationUs']"
		[Register ("breakDurationUs")]
		public long BreakDurationUs {
			get {
				const string __id = "breakDurationUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "breakDurationUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='componentSpliceList']"
		[Register ("componentSpliceList")]
		public global::System.Collections.IList ComponentSpliceList {
			get {
				const string __id = "componentSpliceList.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "componentSpliceList.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='outOfNetworkIndicator']"
		[Register ("outOfNetworkIndicator")]
		public bool OutOfNetworkIndicator {
			get {
				const string __id = "outOfNetworkIndicator.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "outOfNetworkIndicator.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='programSpliceFlag']"
		[Register ("programSpliceFlag")]
		public bool ProgramSpliceFlag {
			get {
				const string __id = "programSpliceFlag.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "programSpliceFlag.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='programSplicePlaybackPositionUs']"
		[Register ("programSplicePlaybackPositionUs")]
		public long ProgramSplicePlaybackPositionUs {
			get {
				const string __id = "programSplicePlaybackPositionUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "programSplicePlaybackPositionUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='programSplicePts']"
		[Register ("programSplicePts")]
		public long ProgramSplicePts {
			get {
				const string __id = "programSplicePts.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "programSplicePts.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='spliceEventCancelIndicator']"
		[Register ("spliceEventCancelIndicator")]
		public bool SpliceEventCancelIndicator {
			get {
				const string __id = "spliceEventCancelIndicator.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "spliceEventCancelIndicator.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='spliceEventId']"
		[Register ("spliceEventId")]
		public long SpliceEventId {
			get {
				const string __id = "spliceEventId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "spliceEventId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='spliceImmediateFlag']"
		[Register ("spliceImmediateFlag")]
		public bool SpliceImmediateFlag {
			get {
				const string __id = "spliceImmediateFlag.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "spliceImmediateFlag.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/field[@name='uniqueProgramId']"
		[Register ("uniqueProgramId")]
		public int UniqueProgramId {
			get {
				const string __id = "uniqueProgramId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "uniqueProgramId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand.ComponentSplice']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand$ComponentSplice", DoNotGenerateAcw=true)]
		public sealed partial class ComponentSplice : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand.ComponentSplice']/field[@name='componentSplicePlaybackPositionUs']"
			[Register ("componentSplicePlaybackPositionUs")]
			public long ComponentSplicePlaybackPositionUs {
				get {
					const string __id = "componentSplicePlaybackPositionUs.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "componentSplicePlaybackPositionUs.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand.ComponentSplice']/field[@name='componentSplicePts']"
			[Register ("componentSplicePts")]
			public long ComponentSplicePts {
				get {
					const string __id = "componentSplicePts.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "componentSplicePts.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand.ComponentSplice']/field[@name='componentTag']"
			[Register ("componentTag")]
			public int ComponentTag {
				get {
					const string __id = "componentTag.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "componentTag.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand$ComponentSplice", typeof (ComponentSplice));

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

			internal ComponentSplice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand.ComponentSplice']/method[@name='createFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("createFromParcel", "(Landroid/os/Parcel;)Lcom/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand$ComponentSplice;", "")]
			public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.SpliceInsertCommand.ComponentSplice CreateFromParcel (global::Android.OS.Parcel @in)
			{
				const string __id = "createFromParcel.(Landroid/os/Parcel;)Lcom/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand$ComponentSplice;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.SpliceInsertCommand.ComponentSplice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (@in);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand.ComponentSplice']/method[@name='writeToParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;)V", "")]
			public unsafe void WriteToParcel (global::Android.OS.Parcel dest)
			{
				const string __id = "writeToParcel.(Landroid/os/Parcel;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (dest);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand", typeof (SpliceInsertCommand));

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

		internal SpliceInsertCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/method[@name='parseFromSection' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster']]"
		[Register ("parseFromSection", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;JLcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;)Lcom/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.SpliceInsertCommand ParseFromSection (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray sectionData, long ptsAdjustment, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster)
		{
			const string __id = "parseFromSection.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;JLcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;)Lcom/example/androidtvlibrary/main/adapter/player/comand/SpliceInsertCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sectionData).Handle);
				__args [1] = new JniArgumentValue (ptsAdjustment);
				__args [2] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.SpliceInsertCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (sectionData);
				global::System.GC.KeepAlive (timestampAdjuster);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='SpliceInsertCommand']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
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
}
