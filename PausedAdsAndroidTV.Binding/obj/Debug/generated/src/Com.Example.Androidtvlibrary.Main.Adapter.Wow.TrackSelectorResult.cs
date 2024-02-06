using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult", DoNotGenerateAcw=true)]
	public sealed partial class TrackSelectorResult : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/field[@name='info']"
		[Register ("info")]
		public global::Java.Lang.Object Info {
			get {
				const string __id = "info.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "info.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/field[@name='length']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/field[@name='rendererConfigurations']"
		[Register ("rendererConfigurations")]
		public IList<Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration> RendererConfigurations {
			get {
				const string __id = "rendererConfigurations.[Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rendererConfigurations.[Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/field[@name='selections']"
		[Register ("selections")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray Selections {
			get {
				const string __id = "selections.Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "selections.Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult", typeof (TrackSelectorResult));

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

		internal TrackSelectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/constructor[@name='TrackSelectorResult' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererConfiguration[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackSelection[]'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;Ljava/lang/Object;)V", "")]
		public unsafe TrackSelectorResult (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration[] rendererConfigurations, global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] selections, global::Java.Lang.Object info) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rendererConfigurations = JNIEnv.NewArray (rendererConfigurations);
			IntPtr native_selections = JNIEnv.NewArray (selections);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_rendererConfigurations);
				__args [1] = new JniArgumentValue (native_selections);
				__args [2] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rendererConfigurations != null) {
					JNIEnv.CopyArray (native_rendererConfigurations, rendererConfigurations);
					JNIEnv.DeleteLocalRef (native_rendererConfigurations);
				}
				if (selections != null) {
					JNIEnv.CopyArray (native_selections, selections);
					JNIEnv.DeleteLocalRef (native_selections);
				}
				global::System.GC.KeepAlive (rendererConfigurations);
				global::System.GC.KeepAlive (selections);
				global::System.GC.KeepAlive (info);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/method[@name='isEquivalent' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelectorResult']]"
		[Register ("isEquivalent", "(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;)Z", "")]
		public unsafe bool IsEquivalent (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult other)
		{
			const string __id = "isEquivalent.(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/method[@name='isEquivalent' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.TrackSelectorResult'] and parameter[2][@type='int']]"
		[Register ("isEquivalent", "(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;I)Z", "")]
		public unsafe bool IsEquivalent (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectorResult other, int index)
		{
			const string __id = "isEquivalent.(Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectorResult;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				__args [1] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectorResult']/method[@name='isRendererEnabled' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isRendererEnabled", "(I)Z", "")]
		public unsafe bool IsRendererEnabled (int index)
		{
			const string __id = "isRendererEnabled.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
