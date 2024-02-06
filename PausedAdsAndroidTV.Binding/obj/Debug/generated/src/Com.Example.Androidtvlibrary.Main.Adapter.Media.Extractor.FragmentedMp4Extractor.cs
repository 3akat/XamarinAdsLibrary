using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FragmentedMp4Extractor", DoNotGenerateAcw=true)]
	public partial class FragmentedMp4Extractor : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1 {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory Factory {
			get {
				const string __id = "FACTORY.Lcom/example/androidtvlibrary/main/adapter/mp3/ExtractorsFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/field[@name='FLAG_ENABLE_EMSG_TRACK']"
		[Register ("FLAG_ENABLE_EMSG_TRACK")]
		public const int FlagEnableEmsgTrack = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/field[@name='FLAG_WORKAROUND_EVERY_VIDEO_FRAME_IS_SYNC_FRAME']"
		[Register ("FLAG_WORKAROUND_EVERY_VIDEO_FRAME_IS_SYNC_FRAME")]
		public const int FlagWorkaroundEveryVideoFrameIsSyncFrame = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/field[@name='FLAG_WORKAROUND_IGNORE_EDIT_LISTS']"
		[Register ("FLAG_WORKAROUND_IGNORE_EDIT_LISTS")]
		public const int FlagWorkaroundIgnoreEditLists = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/field[@name='FLAG_WORKAROUND_IGNORE_TFDT_BOX']"
		[Register ("FLAG_WORKAROUND_IGNORE_TFDT_BOX")]
		public const int FlagWorkaroundIgnoreTfdtBox = (int) 2;

		public static class InterfaceConsts {
			// The following are fields from: com.example.androidtvlibrary.main.adapter.Media.Extractor

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_CONTINUE']"
			[Register ("RESULT_CONTINUE")]
			public const int ResultContinue = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_END_OF_INPUT']"
			[Register ("RESULT_END_OF_INPUT")]
			public const int ResultEndOfInput = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='Extractor']/field[@name='RESULT_SEEK']"
			[Register ("RESULT_SEEK")]
			public const int ResultSeek = (int) 1;

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/interface[@name='FragmentedMp4Extractor.Flags']"
		[Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FragmentedMp4Extractor$Flags", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor/IFlagsInvoker")]
		public partial interface IFlags : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FragmentedMp4Extractor$Flags", DoNotGenerateAcw=true)]
		internal partial class IFlagsInvoker : global::Java.Lang.Object, IFlags {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FragmentedMp4Extractor$Flags", typeof (IFlagsInvoker));

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

			public static IFlags GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFlags> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.extractor.FragmentedMp4Extractor.Flags'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFlagsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FragmentedMp4Extractor", typeof (FragmentedMp4Extractor));

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

		protected FragmentedMp4Extractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/constructor[@name='FragmentedMp4Extractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FragmentedMp4Extractor () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/constructor[@name='FragmentedMp4Extractor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe FragmentedMp4Extractor ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor", Fields = new string [] {"FlagWorkaroundEveryVideoFrameIsSyncFrame", "FlagWorkaroundIgnoreTfdtBox", "FlagEnableEmsgTrack", "FlagWorkaroundIgnoreEditLists"})][global::Android.Runtime.IntDef (Flag = true, Type = "", Fields = new string [] {""})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/constructor[@name='FragmentedMp4Extractor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster']]"
		[Register (".ctor", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;)V", "")]
		public unsafe FragmentedMp4Extractor ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor", Fields = new string [] {"FlagWorkaroundEveryVideoFrameIsSyncFrame", "FlagWorkaroundIgnoreTfdtBox", "FlagEnableEmsgTrack", "FlagWorkaroundIgnoreEditLists"})][global::Android.Runtime.IntDef (Flag = true, Type = "", Fields = new string [] {""})]
		int flags, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (flags);
				__args [1] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timestampAdjuster);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/constructor[@name='FragmentedMp4Extractor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.Track']]"
		[Register (".ctor", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;)V", "")]
		public unsafe FragmentedMp4Extractor ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor", Fields = new string [] {"FlagWorkaroundEveryVideoFrameIsSyncFrame", "FlagWorkaroundIgnoreTfdtBox", "FlagEnableEmsgTrack", "FlagWorkaroundIgnoreEditLists"})][global::Android.Runtime.IntDef (Flag = true, Type = "", Fields = new string [] {""})]
		int flags, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track sideloadedTrack) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (flags);
				__args [1] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				__args [2] = new JniArgumentValue ((sideloadedTrack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sideloadedTrack).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (timestampAdjuster);
				global::System.GC.KeepAlive (sideloadedTrack);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/constructor[@name='FragmentedMp4Extractor' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.Track'] and parameter[4][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.Format&gt;']]"
		[Register (".ctor", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;Ljava/util/List;)V", "")]
		public unsafe FragmentedMp4Extractor ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor", Fields = new string [] {"FlagWorkaroundEveryVideoFrameIsSyncFrame", "FlagWorkaroundIgnoreTfdtBox", "FlagEnableEmsgTrack", "FlagWorkaroundIgnoreEditLists"})][global::Android.Runtime.IntDef (Flag = true, Type = "", Fields = new string [] {""})]
		int flags, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track sideloadedTrack, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> closedCaptionFormats) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_closedCaptionFormats = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format>.ToLocalJniHandle (closedCaptionFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (flags);
				__args [1] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				__args [2] = new JniArgumentValue ((sideloadedTrack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sideloadedTrack).Handle);
				__args [3] = new JniArgumentValue (native_closedCaptionFormats);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_closedCaptionFormats);
				global::System.GC.KeepAlive (timestampAdjuster);
				global::System.GC.KeepAlive (sideloadedTrack);
				global::System.GC.KeepAlive (closedCaptionFormats);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/constructor[@name='FragmentedMp4Extractor' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.TimestampAdjuster'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.Track'] and parameter[4][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.Format&gt;'] and parameter[5][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput']]"
		[Register (".ctor", "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;Ljava/util/List;Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V", "")]
		public unsafe FragmentedMp4Extractor ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor", Fields = new string [] {"FlagWorkaroundEveryVideoFrameIsSyncFrame", "FlagWorkaroundIgnoreTfdtBox", "FlagEnableEmsgTrack", "FlagWorkaroundIgnoreEditLists"})][global::Android.Runtime.IntDef (Flag = true, Type = "", Fields = new string [] {""})]
		int flags, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TimestampAdjuster timestampAdjuster, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track sideloadedTrack, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> closedCaptionFormats, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput additionalEmsgTrackOutput) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/example/androidtvlibrary/main/adapter/Media/extractor/TimestampAdjuster;Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;Ljava/util/List;Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_closedCaptionFormats = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Format>.ToLocalJniHandle (closedCaptionFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (flags);
				__args [1] = new JniArgumentValue ((timestampAdjuster == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timestampAdjuster).Handle);
				__args [2] = new JniArgumentValue ((sideloadedTrack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sideloadedTrack).Handle);
				__args [3] = new JniArgumentValue (native_closedCaptionFormats);
				__args [4] = new JniArgumentValue ((additionalEmsgTrackOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalEmsgTrackOutput).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_closedCaptionFormats);
				global::System.GC.KeepAlive (timestampAdjuster);
				global::System.GC.KeepAlive (sideloadedTrack);
				global::System.GC.KeepAlive (closedCaptionFormats);
				global::System.GC.KeepAlive (additionalEmsgTrackOutput);
			}
		}

		static Delegate cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Handler ()
		{
			if (cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ == null)
				cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_);
			return cb_init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_;
		}

		static void n_Init_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_output)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var output = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (native_output, JniHandleOwnership.DoNotTransfer);
			__this.Init (output);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput']]"
		[Register ("init", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V", "GetInit_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorOutput_Handler")]
		public virtual unsafe void Init (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput output)
		{
			const string __id = "init.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorOutput;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (output);
			}
		}

		static Delegate cb_modifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_;
#pragma warning disable 0169
		static Delegate GetModifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_Handler ()
		{
			if (cb_modifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_ == null)
				cb_modifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ModifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_);
			return cb_modifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_;
		}

		static IntPtr n_ModifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var track = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track> (native_track, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ModifyTrack (track));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/method[@name='modifyTrack' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.extractor.Track']]"
		[Register ("modifyTrack", "(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;", "GetModifyTrack_Lcom_example_androidtvlibrary_main_adapter_Media_extractor_Track_Handler")]
		protected virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track ModifyTrack (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track track)
		{
			const string __id = "modifyTrack.(Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;)Lcom/example/androidtvlibrary/main/adapter/Media/extractor/Track;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Track> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (track);
			}
		}

		static Delegate cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_Handler ()
		{
			if (cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ == null)
				cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_);
			return cb_read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_;
		}

		static int n_Read_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_seekPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_input, JniHandleOwnership.DoNotTransfer);
			var seekPosition = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder> (native_seekPosition, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (input, seekPosition);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.PositionHolder']]"
		[Register ("read", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I", "GetRead_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Lcom_example_androidtvlibrary_main_adapter_Media_PositionHolder_Handler")]
		public virtual unsafe int Read (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.PositionHolder seekPosition)
		{
			const string __id = "read.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;Lcom/example/androidtvlibrary/main/adapter/Media/PositionHolder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((seekPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekPosition).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (seekPosition);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_seek_JJ;
#pragma warning disable 0169
		static Delegate GetSeek_JJHandler ()
		{
			if (cb_seek_JJ == null)
				cb_seek_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_Seek_JJ);
			return cb_seek_JJ;
		}

		static void n_Seek_JJ (IntPtr jnienv, IntPtr native__this, long position, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek (position, timeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/method[@name='seek' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("seek", "(JJ)V", "GetSeek_JJHandler")]
		public virtual unsafe void Seek (long position, long timeUs)
		{
			const string __id = "seek.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (timeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
#pragma warning disable 0169
		static Delegate GetSniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler ()
		{
			if (cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ == null)
				cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_);
			return cb_sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_;
		}

		static bool n_Sniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_input, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Sniff (input);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FragmentedMp4Extractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput']]"
		[Register ("sniff", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z", "GetSniff_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_Handler")]
		public virtual unsafe bool Sniff (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input)
		{
			const string __id = "sniff.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

	}
}
