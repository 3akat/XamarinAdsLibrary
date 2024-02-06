using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TrackSelection$Definition", DoNotGenerateAcw=true)]
	public sealed partial class TrackSelectionDefinition : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']/field[@name='data']"
		[Register ("data")]
		public global::Java.Lang.Object Data {
			get {
				const string __id = "data.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "data.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']/field[@name='group']"
		[Register ("group")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup Group {
			get {
				const string __id = "group.Lcom/example/androidtvlibrary/main/adapter/TrackGroup;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "group.Lcom/example/androidtvlibrary/main/adapter/TrackGroup;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']/field[@name='reason']"
		[Register ("reason")]
		public int Reason {
			get {
				const string __id = "reason.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "reason.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']/field[@name='tracks']"
		[Register ("tracks")]
		public IList<int> Tracks {
			get {
				const string __id = "tracks.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tracks.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TrackSelection$Definition", typeof (TrackSelectionDefinition));

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

		internal TrackSelectionDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']/constructor[@name='TrackSelection.Definition' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int...']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[I)V", "")]
		public unsafe TrackSelectionDefinition (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, params int[] tracks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tracks = JNIEnv.NewArray (tracks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (native_tracks);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (tracks != null) {
					JNIEnv.CopyArray (native_tracks, tracks);
					JNIEnv.DeleteLocalRef (native_tracks);
				}
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (tracks);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='TrackSelection.Definition']/constructor[@name='TrackSelection.Definition' and count(parameter)=4 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackGroup'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[IILjava/lang/Object;)V", "")]
		public unsafe TrackSelectionDefinition (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup group, int[] tracks, int reason, global::Java.Lang.Object data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/TrackGroup;[IILjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tracks = JNIEnv.NewArray (tracks);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue (native_tracks);
				__args [2] = new JniArgumentValue (reason);
				__args [3] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (tracks != null) {
					JNIEnv.CopyArray (native_tracks, tracks);
					JNIEnv.DeleteLocalRef (native_tracks);
				}
				global::System.GC.KeepAlive (group);
				global::System.GC.KeepAlive (tracks);
				global::System.GC.KeepAlive (data);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection.Factory']"
	[Register ("com/example/androidtvlibrary/main/adapter/TrackSelection$Factory", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactoryInvoker")]
	public partial interface ITrackSelectionFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection.Factory']/method[@name='createTrackSelections' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.TrackSelection.Definition[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.BandwidthMeter']]"
		[Register ("createTrackSelections", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;", "GetCreateTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] CreateTrackSelections (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TrackSelection$Factory", DoNotGenerateAcw=true)]
	internal partial class ITrackSelectionFactoryInvoker : global::Java.Lang.Object, ITrackSelectionFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TrackSelection$Factory", typeof (ITrackSelectionFactoryInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrackSelectionFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackSelectionFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TrackSelection.Factory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackSelectionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_;
#pragma warning disable 0169
		static Delegate GetCreateTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_Handler ()
		{
			if (cb_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_ == null)
				cb_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_);
			return cb_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_;
		}

		static IntPtr n_CreateTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition));
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.CreateTrackSelections (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[] CreateTrackSelections (global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.IBandwidthMeter p1)
		{
			if (id_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_ == IntPtr.Zero)
				id_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_ = JNIEnv.GetMethodID (class_ref, "createTrackSelections", "([Lcom/example/androidtvlibrary/main/adapter/TrackSelection$Definition;Lcom/example/androidtvlibrary/main/adapter/BandwidthMeter;)[Lcom/example/androidtvlibrary/main/adapter/TrackSelection;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTrackSelections_arrayLcom_example_androidtvlibrary_main_adapter_TrackSelection_Definition_Lcom_example_androidtvlibrary_main_adapter_BandwidthMeter_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection.Type']"
	[Register ("com/example/androidtvlibrary/main/adapter/TrackSelection$Type", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionTypeInvoker")]
	public partial interface ITrackSelectionType : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TrackSelection$Type", DoNotGenerateAcw=true)]
	internal partial class ITrackSelectionTypeInvoker : global::Java.Lang.Object, ITrackSelectionType {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TrackSelection$Type", typeof (ITrackSelectionTypeInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrackSelectionType GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackSelectionType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TrackSelection.Type'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackSelectionTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

	[Register ("com/example/androidtvlibrary/main/adapter/TrackSelection", DoNotGenerateAcw=true)]
	public abstract class TrackSelection : Java.Lang.Object {
		internal TrackSelection ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/field[@name='SELECTION_REASON_UNKNOWN']"
		[Register ("SELECTION_REASON_UNKNOWN")]
		public const int SelectionReasonUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/field[@name='TYPE_CUSTOM_BASE']"
		[Register ("TYPE_CUSTOM_BASE")]
		public const int TypeCustomBase = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/field[@name='TYPE_UNSET']"
		[Register ("TYPE_UNSET")]
		public const int TypeUnset = (int) 0;

	}

	[Register ("com/example/androidtvlibrary/main/adapter/TrackSelection", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TrackSelection' type. This type will be removed in a future release.", error: true)]
	public abstract class TrackSelectionConsts : TrackSelection {
		private TrackSelectionConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']"
	[Register ("com/example/androidtvlibrary/main/adapter/TrackSelection", "", "Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker")]
	public partial interface ITrackSelection : IJavaObject, IJavaPeerable {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Format SelectedFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getSelectedFormat' and count(parameter)=0]"
			[Register ("getSelectedFormat", "()Lcom/example/androidtvlibrary/main/adapter/Format;", "GetGetSelectedFormatHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int SelectedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getSelectedIndex' and count(parameter)=0]"
			[Register ("getSelectedIndex", "()I", "GetGetSelectedIndexHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int SelectedIndexInTrackGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getSelectedIndexInTrackGroup' and count(parameter)=0]"
			[Register ("getSelectedIndexInTrackGroup", "()I", "GetGetSelectedIndexInTrackGroupHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Java.Lang.Object SelectionData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getSelectionData' and count(parameter)=0]"
			[Register ("getSelectionData", "()Ljava/lang/Object;", "GetGetSelectionDataHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int SelectionReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getSelectionReason' and count(parameter)=0]"
			[Register ("getSelectionReason", "()I", "GetGetSelectionReasonHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup TrackGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getTrackGroup' and count(parameter)=0]"
			[Register ("getTrackGroup", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroup;", "GetGetTrackGroupHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='blacklist' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("blacklist", "(IJ)Z", "GetBlacklist_IJHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		bool Blacklist (int p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		void Enable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='evaluateQueueSize' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;']]"
		[Register ("evaluateQueueSize", "(JLjava/util/List;)I", "GetEvaluateQueueSize_JLjava_util_List_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		int EvaluateQueueSize (long p0, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFormat", "(I)Lcom/example/androidtvlibrary/main/adapter/Format;", "GetGetFormat_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Format GetFormat (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='getIndexInTrackGroup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexInTrackGroup", "(I)I", "GetGetIndexInTrackGroup_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		int GetIndexInTrackGroup (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("indexOf", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I", "GetIndexOf_Lcom_example_androidtvlibrary_main_adapter_Format_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		int IndexOf (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("indexOf", "(I)I", "GetIndexOf_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		int IndexOf (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		int Length ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='onPlaybackSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onPlaybackSpeed", "(F)V", "GetOnPlaybackSpeed_FHandler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		void OnPlaybackSpeed (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='TrackSelection']/method[@name='updateSelectedTrack' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.MediaChunk&gt;'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.MediaChunkIterator[]']]"
		[Register ("updateSelectedTrack", "(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V", "GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler:Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelectionInvoker, PausedAdsAndroidTV.Binding")]
		void UpdateSelectedTrack (long p0, long p1, long p2, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> p3, global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[] p4);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/TrackSelection", DoNotGenerateAcw=true)]
	internal partial class ITrackSelectionInvoker : global::Java.Lang.Object, ITrackSelection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/TrackSelection", typeof (ITrackSelectionInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrackSelection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackSelection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.TrackSelection'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackSelectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSelectedFormat;
#pragma warning disable 0169
		static Delegate GetGetSelectedFormatHandler ()
		{
			if (cb_getSelectedFormat == null)
				cb_getSelectedFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSelectedFormat);
			return cb_getSelectedFormat;
		}

		static IntPtr n_GetSelectedFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedFormat);
		}
#pragma warning restore 0169

		IntPtr id_getSelectedFormat;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format SelectedFormat {
			get {
				if (id_getSelectedFormat == IntPtr.Zero)
					id_getSelectedFormat = JNIEnv.GetMethodID (class_ref, "getSelectedFormat", "()Lcom/example/androidtvlibrary/main/adapter/Format;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSelectedIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedIndexHandler ()
		{
			if (cb_getSelectedIndex == null)
				cb_getSelectedIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedIndex);
			return cb_getSelectedIndex;
		}

		static int n_GetSelectedIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedIndex;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedIndex;
		public unsafe int SelectedIndex {
			get {
				if (id_getSelectedIndex == IntPtr.Zero)
					id_getSelectedIndex = JNIEnv.GetMethodID (class_ref, "getSelectedIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedIndex);
			}
		}

		static Delegate cb_getSelectedIndexInTrackGroup;
#pragma warning disable 0169
		static Delegate GetGetSelectedIndexInTrackGroupHandler ()
		{
			if (cb_getSelectedIndexInTrackGroup == null)
				cb_getSelectedIndexInTrackGroup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedIndexInTrackGroup);
			return cb_getSelectedIndexInTrackGroup;
		}

		static int n_GetSelectedIndexInTrackGroup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedIndexInTrackGroup;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedIndexInTrackGroup;
		public unsafe int SelectedIndexInTrackGroup {
			get {
				if (id_getSelectedIndexInTrackGroup == IntPtr.Zero)
					id_getSelectedIndexInTrackGroup = JNIEnv.GetMethodID (class_ref, "getSelectedIndexInTrackGroup", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedIndexInTrackGroup);
			}
		}

		static Delegate cb_getSelectionData;
#pragma warning disable 0169
		static Delegate GetGetSelectionDataHandler ()
		{
			if (cb_getSelectionData == null)
				cb_getSelectionData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSelectionData);
			return cb_getSelectionData;
		}

		static IntPtr n_GetSelectionData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionData);
		}
#pragma warning restore 0169

		IntPtr id_getSelectionData;
		public unsafe global::Java.Lang.Object SelectionData {
			get {
				if (id_getSelectionData == IntPtr.Zero)
					id_getSelectionData = JNIEnv.GetMethodID (class_ref, "getSelectionData", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectionData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSelectionReason;
#pragma warning disable 0169
		static Delegate GetGetSelectionReasonHandler ()
		{
			if (cb_getSelectionReason == null)
				cb_getSelectionReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectionReason);
			return cb_getSelectionReason;
		}

		static int n_GetSelectionReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionReason;
		}
#pragma warning restore 0169

		IntPtr id_getSelectionReason;
		public unsafe int SelectionReason {
			get {
				if (id_getSelectionReason == IntPtr.Zero)
					id_getSelectionReason = JNIEnv.GetMethodID (class_ref, "getSelectionReason", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectionReason);
			}
		}

		static Delegate cb_getTrackGroup;
#pragma warning disable 0169
		static Delegate GetGetTrackGroupHandler ()
		{
			if (cb_getTrackGroup == null)
				cb_getTrackGroup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackGroup);
			return cb_getTrackGroup;
		}

		static IntPtr n_GetTrackGroup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackGroup);
		}
#pragma warning restore 0169

		IntPtr id_getTrackGroup;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup TrackGroup {
			get {
				if (id_getTrackGroup == IntPtr.Zero)
					id_getTrackGroup = JNIEnv.GetMethodID (class_ref, "getTrackGroup", "()Lcom/example/androidtvlibrary/main/adapter/TrackGroup;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackGroup), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
			}
		}

		static Delegate cb_blacklist_IJ;
#pragma warning disable 0169
		static Delegate GetBlacklist_IJHandler ()
		{
			if (cb_blacklist_IJ == null)
				cb_blacklist_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_Z) n_Blacklist_IJ);
			return cb_blacklist_IJ;
		}

		static bool n_Blacklist_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Blacklist (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_blacklist_IJ;
		public unsafe bool Blacklist (int p0, long p1)
		{
			if (id_blacklist_IJ == IntPtr.Zero)
				id_blacklist_IJ = JNIEnv.GetMethodID (class_ref, "blacklist", "(IJ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_blacklist_IJ, __args);
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		IntPtr id_disable;
		public unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		IntPtr id_enable;
		public unsafe void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable);
		}

		static Delegate cb_evaluateQueueSize_JLjava_util_List_;
#pragma warning disable 0169
		static Delegate GetEvaluateQueueSize_JLjava_util_List_Handler ()
		{
			if (cb_evaluateQueueSize_JLjava_util_List_ == null)
				cb_evaluateQueueSize_JLjava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_I) n_EvaluateQueueSize_JLjava_util_List_);
			return cb_evaluateQueueSize_JLjava_util_List_;
		}

		static int n_EvaluateQueueSize_JLjava_util_List_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EvaluateQueueSize (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_evaluateQueueSize_JLjava_util_List_;
		public unsafe int EvaluateQueueSize (long p0, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> p1)
		{
			if (id_evaluateQueueSize_JLjava_util_List_ == IntPtr.Zero)
				id_evaluateQueueSize_JLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "evaluateQueueSize", "(JLjava/util/List;)I");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_evaluateQueueSize_JLjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getFormat_I;
#pragma warning disable 0169
		static Delegate GetGetFormat_IHandler ()
		{
			if (cb_getFormat_I == null)
				cb_getFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetFormat_I);
			return cb_getFormat_I;
		}

		static IntPtr n_GetFormat_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFormat (p0));
		}
#pragma warning restore 0169

		IntPtr id_getFormat_I;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Format GetFormat (int p0)
		{
			if (id_getFormat_I == IntPtr.Zero)
				id_getFormat_I = JNIEnv.GetMethodID (class_ref, "getFormat", "(I)Lcom/example/androidtvlibrary/main/adapter/Format;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getIndexInTrackGroup_I;
#pragma warning disable 0169
		static Delegate GetGetIndexInTrackGroup_IHandler ()
		{
			if (cb_getIndexInTrackGroup_I == null)
				cb_getIndexInTrackGroup_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetIndexInTrackGroup_I);
			return cb_getIndexInTrackGroup_I;
		}

		static int n_GetIndexInTrackGroup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexInTrackGroup (p0);
		}
#pragma warning restore 0169

		IntPtr id_getIndexInTrackGroup_I;
		public unsafe int GetIndexInTrackGroup (int p0)
		{
			if (id_getIndexInTrackGroup_I == IntPtr.Zero)
				id_getIndexInTrackGroup_I = JNIEnv.GetMethodID (class_ref, "getIndexInTrackGroup", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexInTrackGroup_I, __args);
		}

		static Delegate cb_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IndexOf_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static int n_IndexOf_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_;
		public unsafe int IndexOf (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
		{
			if (id_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_ == IntPtr.Zero)
				id_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lcom/example/androidtvlibrary/main/adapter/Format;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Lcom_example_androidtvlibrary_main_adapter_Format_, __args);
			return __ret;
		}

		static Delegate cb_indexOf_I;
#pragma warning disable 0169
		static Delegate GetIndexOf_IHandler ()
		{
			if (cb_indexOf_I == null)
				cb_indexOf_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_IndexOf_I);
			return cb_indexOf_I;
		}

		static int n_IndexOf_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOf (p0);
		}
#pragma warning restore 0169

		IntPtr id_indexOf_I;
		public unsafe int IndexOf (int p0)
		{
			if (id_indexOf_I == IntPtr.Zero)
				id_indexOf_I = JNIEnv.GetMethodID (class_ref, "indexOf", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_I, __args);
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		IntPtr id_length;
		public unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
		}

		static Delegate cb_onPlaybackSpeed_F;
#pragma warning disable 0169
		static Delegate GetOnPlaybackSpeed_FHandler ()
		{
			if (cb_onPlaybackSpeed_F == null)
				cb_onPlaybackSpeed_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_OnPlaybackSpeed_F);
			return cb_onPlaybackSpeed_F;
		}

		static void n_OnPlaybackSpeed_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaybackSpeed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPlaybackSpeed_F;
		public unsafe void OnPlaybackSpeed (float p0)
		{
			if (id_onPlaybackSpeed_F == IntPtr.Zero)
				id_onPlaybackSpeed_F = JNIEnv.GetMethodID (class_ref, "onPlaybackSpeed", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaybackSpeed_F, __args);
		}

		static Delegate cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
#pragma warning disable 0169
		static Delegate GetUpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_Handler ()
		{
			if (cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ == null)
				cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJJLL_V) n_UpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_);
			return cb_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
		}

		static void n_UpdateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, long p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.ITrackSelection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator));
			__this.UpdateSelectedTrack (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_;
		public unsafe void UpdateSelectedTrack (long p0, long p1, long p2, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk> p3, global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator[] p4)
		{
			if (id_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ == IntPtr.Zero)
				id_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_ = JNIEnv.GetMethodID (class_ref, "updateSelectedTrack", "(JJJLjava/util/List;[Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;)V");
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.MediaChunk>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSelectedTrack_JJJLjava_util_List_arrayLcom_example_androidtvlibrary_main_adapter_MediaChunkIterator_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
