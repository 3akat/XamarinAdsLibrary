using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TrackGroupArray", DoNotGenerateAcw=true)]
	public sealed partial class TrackGroupArray : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray Empty {
			get {
				const string __id = "EMPTY.Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/field[@name='length']"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TrackGroupArray", typeof (TrackGroupArray));

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

		internal TrackGroupArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/constructor[@name='TrackGroupArray' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup...']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/TrackGroup;)V", "")]
		public unsafe TrackGroupArray (params global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup[] trackGroups) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/TrackGroup;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_trackGroups = JNIEnv.NewArray (trackGroups);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_trackGroups);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (trackGroups != null) {
					JNIEnv.CopyArray (native_trackGroups, trackGroups);
					JNIEnv.DeleteLocalRef (native_trackGroups);
				}
				global::System.GC.KeepAlive (trackGroups);
			}
		}

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/example/androidtvlibrary/main/adapter/TrackGroup;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup Get (int index)
		{
			const string __id = "get.(I)Lcom/example/androidtvlibrary/main/adapter/TrackGroup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup']]"
		[Register ("indexOf", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;)I", "")]
		public unsafe int IndexOf (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group)
		{
			const string __id = "indexOf.(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (group);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackGroupArray']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
}
