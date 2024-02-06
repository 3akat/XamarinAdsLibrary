using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters", DoNotGenerateAcw=true)]
	public partial class TrackSelectionParameters : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		[Obsolete ("deprecated")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters Default {
			get {
				const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='DEFAULT_WITHOUT_CONTEXT']"
		[Register ("DEFAULT_WITHOUT_CONTEXT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters DefaultWithoutContext {
			get {
				const string __id = "DEFAULT_WITHOUT_CONTEXT.Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='disabledTextTrackSelectionFlags']"
		[Register ("disabledTextTrackSelectionFlags")]
		public int DisabledTextTrackSelectionFlags {
			get {
				const string __id = "disabledTextTrackSelectionFlags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "disabledTextTrackSelectionFlags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='preferredAudioLanguage']"
		[Register ("preferredAudioLanguage")]
		public string PreferredAudioLanguage {
			get {
				const string __id = "preferredAudioLanguage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "preferredAudioLanguage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='preferredTextLanguage']"
		[Register ("preferredTextLanguage")]
		public string PreferredTextLanguage {
			get {
				const string __id = "preferredTextLanguage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "preferredTextLanguage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='preferredTextRoleFlags']"
		[Register ("preferredTextRoleFlags")]
		public int PreferredTextRoleFlags {
			get {
				const string __id = "preferredTextRoleFlags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "preferredTextRoleFlags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/field[@name='selectUndeterminedTextLanguage']"
		[Register ("selectUndeterminedTextLanguage")]
		public bool SelectUndeterminedTextLanguage {
			get {
				const string __id = "selectUndeterminedTextLanguage.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "selectUndeterminedTextLanguage.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/constructor[@name='TrackSelectionParameters.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			[Obsolete (@"deprecated")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/constructor[@name='TrackSelectionParameters.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters;", "GetBuildHandler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters Build ()
			{
				const string __id = "build.()Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDisabledTextTrackSelectionFlags_I;
#pragma warning disable 0169
			static Delegate GetSetDisabledTextTrackSelectionFlags_IHandler ()
			{
				if (cb_setDisabledTextTrackSelectionFlags_I == null)
					cb_setDisabledTextTrackSelectionFlags_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDisabledTextTrackSelectionFlags_I);
				return cb_setDisabledTextTrackSelectionFlags_I;
			}

			static IntPtr n_SetDisabledTextTrackSelectionFlags_I (IntPtr jnienv, IntPtr native__this, int disabledTextTrackSelectionFlags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDisabledTextTrackSelectionFlags (disabledTextTrackSelectionFlags));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='setDisabledTextTrackSelectionFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisabledTextTrackSelectionFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetSetDisabledTextTrackSelectionFlags_IHandler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder SetDisabledTextTrackSelectionFlags (int disabledTextTrackSelectionFlags)
			{
				const string __id = "setDisabledTextTrackSelectionFlags.(I)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (disabledTextTrackSelectionFlags);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPreferredAudioLanguage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPreferredAudioLanguage_Ljava_lang_String_Handler ()
			{
				if (cb_setPreferredAudioLanguage_Ljava_lang_String_ == null)
					cb_setPreferredAudioLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPreferredAudioLanguage_Ljava_lang_String_);
				return cb_setPreferredAudioLanguage_Ljava_lang_String_;
			}

			static IntPtr n_SetPreferredAudioLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_preferredAudioLanguage)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var preferredAudioLanguage = JNIEnv.GetString (native_preferredAudioLanguage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPreferredAudioLanguage (preferredAudioLanguage));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='setPreferredAudioLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPreferredAudioLanguage", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetSetPreferredAudioLanguage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder SetPreferredAudioLanguage (string preferredAudioLanguage)
			{
				const string __id = "setPreferredAudioLanguage.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
				IntPtr native_preferredAudioLanguage = JNIEnv.NewString (preferredAudioLanguage);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_preferredAudioLanguage);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_preferredAudioLanguage);
				}
			}

			static Delegate cb_setPreferredTextLanguage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPreferredTextLanguage_Ljava_lang_String_Handler ()
			{
				if (cb_setPreferredTextLanguage_Ljava_lang_String_ == null)
					cb_setPreferredTextLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPreferredTextLanguage_Ljava_lang_String_);
				return cb_setPreferredTextLanguage_Ljava_lang_String_;
			}

			static IntPtr n_SetPreferredTextLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_preferredTextLanguage)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var preferredTextLanguage = JNIEnv.GetString (native_preferredTextLanguage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPreferredTextLanguage (preferredTextLanguage));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='setPreferredTextLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPreferredTextLanguage", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetSetPreferredTextLanguage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder SetPreferredTextLanguage (string preferredTextLanguage)
			{
				const string __id = "setPreferredTextLanguage.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
				IntPtr native_preferredTextLanguage = JNIEnv.NewString (preferredTextLanguage);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_preferredTextLanguage);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_preferredTextLanguage);
				}
			}

			static Delegate cb_setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetSetPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_Handler ()
			{
				if (cb_setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_ == null)
					cb_setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_);
				return cb_setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_;
			}

			static IntPtr n_SetPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings", "(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetSetPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings_Landroid_content_Context_Handler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder SetPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings (global::Android.Content.Context context)
			{
				const string __id = "setPreferredTextLanguageAndRoleFlagsToCaptioningManagerSettings.(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_setPreferredTextRoleFlags_I;
#pragma warning disable 0169
			static Delegate GetSetPreferredTextRoleFlags_IHandler ()
			{
				if (cb_setPreferredTextRoleFlags_I == null)
					cb_setPreferredTextRoleFlags_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetPreferredTextRoleFlags_I);
				return cb_setPreferredTextRoleFlags_I;
			}

			static IntPtr n_SetPreferredTextRoleFlags_I (IntPtr jnienv, IntPtr native__this, int preferredTextRoleFlags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPreferredTextRoleFlags (preferredTextRoleFlags));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='setPreferredTextRoleFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreferredTextRoleFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetSetPreferredTextRoleFlags_IHandler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder SetPreferredTextRoleFlags (int preferredTextRoleFlags)
			{
				const string __id = "setPreferredTextRoleFlags.(I)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (preferredTextRoleFlags);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSelectUndeterminedTextLanguage_Z;
#pragma warning disable 0169
			static Delegate GetSetSelectUndeterminedTextLanguage_ZHandler ()
			{
				if (cb_setSelectUndeterminedTextLanguage_Z == null)
					cb_setSelectUndeterminedTextLanguage_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetSelectUndeterminedTextLanguage_Z);
				return cb_setSelectUndeterminedTextLanguage_Z;
			}

			static IntPtr n_SetSelectUndeterminedTextLanguage_Z (IntPtr jnienv, IntPtr native__this, bool selectUndeterminedTextLanguage)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSelectUndeterminedTextLanguage (selectUndeterminedTextLanguage));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters.Builder']/method[@name='setSelectUndeterminedTextLanguage' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSelectUndeterminedTextLanguage", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetSetSelectUndeterminedTextLanguage_ZHandler")]
			public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder SetSelectUndeterminedTextLanguage (bool selectUndeterminedTextLanguage)
			{
				const string __id = "setSelectUndeterminedTextLanguage.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (selectUndeterminedTextLanguage);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters", typeof (TrackSelectionParameters));

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

		protected TrackSelectionParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_buildUpon;
#pragma warning disable 0169
		static Delegate GetBuildUponHandler ()
		{
			if (cb_buildUpon == null)
				cb_buildUpon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BuildUpon);
			return cb_buildUpon;
		}

		static IntPtr n_BuildUpon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildUpon ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/method[@name='buildUpon' and count(parameter)=0]"
		[Register ("buildUpon", "()Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;", "GetBuildUponHandler")]
		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder BuildUpon ()
		{
			const string __id = "buildUpon.()Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/method[@name='getDefaults' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDefaults", "(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters GetDefaults (global::Android.Content.Context context)
		{
			const string __id = "getDefaults.(Landroid/content/Context;)Lcom/example/androidtvlibrary/main/adapter/wow/TrackSelectionParameters;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.TrackSelectionParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='TrackSelectionParameters']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

	}
}
