using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelectionArray']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TrackSelectionArray", DoNotGenerateAcw=true)]
	public sealed partial class TrackSelectionArray : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelectionArray']/field[@name='length']"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TrackSelectionArray", typeof (TrackSelectionArray));

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

		internal TrackSelectionArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelectionArray']/constructor[@name='TrackSelectionArray' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackSelection...']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection;)V", "")]
		public unsafe TrackSelectionArray (params global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] trackSelections) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_trackSelections = JNIEnv.NewArray (trackSelections);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_trackSelections);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (trackSelections != null) {
					JNIEnv.CopyArray (native_trackSelections, trackSelections);
					JNIEnv.DeleteLocalRef (native_trackSelections);
				}
				global::System.GC.KeepAlive (trackSelections);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelectionArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/example/androidtvlibrary/main/adapter/TrackSelection;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection Get (int index)
		{
			const string __id = "get.(I)Lcom/example/androidtvlibrary/main/adapter/TrackSelection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelectionArray']/method[@name='getAll' and count(parameter)=0]"
		[Register ("getAll", "()[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] GetAll ()
		{
			const string __id = "getAll.()[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection));
			} finally {
			}
		}

	}
}
