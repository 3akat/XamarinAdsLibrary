using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='TimeSignalCommand']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/comand/TimeSignalCommand", DoNotGenerateAcw=true)]
	public sealed partial class TimeSignalCommand : global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.SpliceCommand {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='TimeSignalCommand']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='TimeSignalCommand']/field[@name='playbackPositionUs']"
		[Register ("playbackPositionUs")]
		public long PlaybackPositionUs {
			get {
				const string __id = "playbackPositionUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "playbackPositionUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='TimeSignalCommand']/field[@name='ptsTime']"
		[Register ("ptsTime")]
		public long PtsTime {
			get {
				const string __id = "ptsTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ptsTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/comand/TimeSignalCommand", typeof (TimeSignalCommand));

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

		internal TimeSignalCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='TimeSignalCommand']/method[@name='parseFromSection' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='long'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster']]"
		[Register ("parseFromSection", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;JLcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;)Lcom/example/androidtvlibrary/main/adapter/player/comand/TimeSignalCommand;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.TimeSignalCommand ParseFromSection (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray sectionData, long ptsAdjustment, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster)
		{
			const string __id = "parseFromSection.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;JLcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;)Lcom/example/androidtvlibrary/main/adapter/player/comand/TimeSignalCommand;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sectionData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sectionData).Handle);
				__args [1] = new JniArgumentValue (ptsAdjustment);
				__args [2] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Comand.TimeSignalCommand> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (sectionData);
				global::System.GC.KeepAlive (timestampAdjuster);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player.comand']/class[@name='TimeSignalCommand']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
