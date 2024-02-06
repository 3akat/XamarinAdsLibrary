using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/ChapterTocFrame", DoNotGenerateAcw=true)]
	public sealed partial class ChapterTocFrame : global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Frame {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/field[@name='children']"
		[Register ("children")]
		public IList<string> Children {
			get {
				const string __id = "children.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "children.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/field[@name='elementId']"
		[Register ("elementId")]
		public string ElementId {
			get {
				const string __id = "elementId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "elementId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/field[@name='ID']"
		[Register ("ID")]
		public const string Id = (string) "CTOC";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/field[@name='isOrdered']"
		[Register ("isOrdered")]
		public bool IsOrdered {
			get {
				const string __id = "isOrdered.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isOrdered.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/field[@name='isRoot']"
		[Register ("isRoot")]
		public bool IsRoot {
			get {
				const string __id = "isRoot.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isRoot.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/ChapterTocFrame", typeof (ChapterTocFrame));

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

		internal ChapterTocFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/constructor[@name='ChapterTocFrame' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.mp3.Id3Frame[]']]"
		[Register (".ctor", "(Ljava/lang/String;ZZ[Ljava/lang/String;[Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Frame;)V", "")]
		public unsafe ChapterTocFrame (string elementId, bool isRoot, bool isOrdered, string[] children, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Frame[] subFrames) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ZZ[Ljava/lang/String;[Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Frame;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_elementId = JNIEnv.NewString (elementId);
			IntPtr native_children = JNIEnv.NewArray (children);
			IntPtr native_subFrames = JNIEnv.NewArray (subFrames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_elementId);
				__args [1] = new JniArgumentValue (isRoot);
				__args [2] = new JniArgumentValue (isOrdered);
				__args [3] = new JniArgumentValue (native_children);
				__args [4] = new JniArgumentValue (native_subFrames);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_elementId);
				if (children != null) {
					JNIEnv.CopyArray (native_children, children);
					JNIEnv.DeleteLocalRef (native_children);
				}
				if (subFrames != null) {
					JNIEnv.CopyArray (native_subFrames, subFrames);
					JNIEnv.DeleteLocalRef (native_subFrames);
				}
				global::System.GC.KeepAlive (children);
				global::System.GC.KeepAlive (subFrames);
			}
		}

		public unsafe int SubFrameCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/method[@name='getSubFrameCount' and count(parameter)=0]"
			[Register ("getSubFrameCount", "()I", "")]
			get {
				const string __id = "getSubFrameCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/method[@name='getSubFrame' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSubFrame", "(I)Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Frame;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Frame GetSubFrame (int index)
		{
			const string __id = "getSubFrame.(I)Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Frame;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Frame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='ChapterTocFrame']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
