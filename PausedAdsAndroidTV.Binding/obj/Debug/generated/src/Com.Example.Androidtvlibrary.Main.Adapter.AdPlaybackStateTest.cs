using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest", DoNotGenerateAcw=true)]
	public sealed partial class AdPlaybackStateTest : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='adGroupCount']"
		[Register ("adGroupCount")]
		public int AdGroupCount {
			get {
				const string __id = "adGroupCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "adGroupCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='adGroups']"
		[Register ("adGroups")]
		public IList<Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup> AdGroups {
			get {
				const string __id = "adGroups.[Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "adGroups.[Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='adGroupTimesUs']"
		[Register ("adGroupTimesUs")]
		public IList<long> AdGroupTimesUs {
			get {
				const string __id = "adGroupTimesUs.[J";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "adGroupTimesUs.[J";

				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='adResumePositionUs']"
		[Register ("adResumePositionUs")]
		public long AdResumePositionUs {
			get {
				const string __id = "adResumePositionUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "adResumePositionUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='AD_STATE_AVAILABLE']"
		[Register ("AD_STATE_AVAILABLE")]
		public const int AdStateAvailable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='AD_STATE_ERROR']"
		[Register ("AD_STATE_ERROR")]
		public const int AdStateError = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='AD_STATE_PLAYED']"
		[Register ("AD_STATE_PLAYED")]
		public const int AdStatePlayed = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='AD_STATE_SKIPPED']"
		[Register ("AD_STATE_SKIPPED")]
		public const int AdStateSkipped = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='AD_STATE_UNAVAILABLE']"
		[Register ("AD_STATE_UNAVAILABLE")]
		public const int AdStateUnavailable = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='contentDurationUs']"
		[Register ("contentDurationUs")]
		public long ContentDurationUs {
			get {
				const string __id = "contentDurationUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "contentDurationUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest None {
			get {
				const string __id = "NONE.Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup", DoNotGenerateAcw=true)]
		public sealed partial class AdGroup : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/field[@name='count']"
			[Register ("count")]
			public int Count {
				get {
					const string __id = "count.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "count.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/field[@name='durationsUs']"
			[Register ("durationsUs")]
			public IList<long> DurationsUs {
				get {
					const string __id = "durationsUs.[J";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<long>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "durationsUs.[J";

					IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/field[@name='states']"
			[Register ("states")]
			public IList<int> States {
				get {
					const string __id = "states.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "states.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/field[@name='uris']"
			[Register ("uris")]
			public IList<Android.Net.Uri> Uris {
				get {
					const string __id = "uris.[Landroid/net/Uri;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Android.Net.Uri>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "uris.[Landroid/net/Uri;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Net.Uri>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup", typeof (AdGroup));

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

			internal AdGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/constructor[@name='AdPlaybackStateTest.AdGroup' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AdGroup () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe int FirstAdIndexToPlay {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='getFirstAdIndexToPlay' and count(parameter)=0]"
				[Register ("getFirstAdIndexToPlay", "()I", "")]
				get {
					const string __id = "getFirstAdIndexToPlay.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool HasUnplayedAds {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='hasUnplayedAds' and count(parameter)=0]"
				[Register ("hasUnplayedAds", "()Z", "")]
				get {
					const string __id = "hasUnplayedAds.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='getNextAdIndexToPlay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getNextAdIndexToPlay", "(I)I", "")]
			public unsafe int GetNextAdIndexToPlay (int lastPlayedAdIndex)
			{
				const string __id = "getNextAdIndexToPlay.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (lastPlayedAdIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='withAdCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("withAdCount", "(I)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup WithAdCount (int count)
			{
				const string __id = "withAdCount.(I)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (count);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='withAdDurationsUs' and count(parameter)=1 and parameter[1][@type='long[]']]"
			[Register ("withAdDurationsUs", "([J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup WithAdDurationsUs (long[] durationsUs)
			{
				const string __id = "withAdDurationsUs.([J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";
				IntPtr native_durationsUs = JNIEnv.NewArray (durationsUs);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_durationsUs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (durationsUs != null) {
						JNIEnv.CopyArray (native_durationsUs, durationsUs);
						JNIEnv.DeleteLocalRef (native_durationsUs);
					}
					global::System.GC.KeepAlive (durationsUs);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='withAdState' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("withAdState", "(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup WithAdState (int state, int index)
			{
				const string __id = "withAdState.(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (state);
					__args [1] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='withAdUri' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
			[Register ("withAdUri", "(Landroid/net/Uri;I)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup WithAdUri (global::Android.Net.Uri uri, int index)
			{
				const string __id = "withAdUri.(Landroid/net/Uri;I)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					__args [1] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (uri);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest.AdGroup']/method[@name='withAllAdsSkipped' and count(parameter)=0]"
			[Register ("withAllAdsSkipped", "()Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup WithAllAdsSkipped ()
			{
				const string __id = "withAllAdsSkipped.()Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdGroup;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.AdGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='AdPlaybackStateTest.AdState']"
		[Register ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdState", "", "Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest/IAdStateInvoker")]
		public partial interface IAdState : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdState", DoNotGenerateAcw=true)]
		internal partial class IAdStateInvoker : global::Java.Lang.Object, IAdState {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest$AdState", typeof (IAdStateInvoker));

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

			public static IAdState GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAdState> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.AdPlaybackStateTest.AdState'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAdStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.IAdState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.IAdState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.IAdState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest.IAdState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/AdPlaybackStateTest", typeof (AdPlaybackStateTest));

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

		internal AdPlaybackStateTest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/constructor[@name='AdPlaybackStateTest' and count(parameter)=1 and parameter[1][@type='long...']]"
		[Register (".ctor", "([J)V", "")]
		public unsafe AdPlaybackStateTest (params long[] adGroupTimesUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_adGroupTimesUs = JNIEnv.NewArray (adGroupTimesUs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adGroupTimesUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (adGroupTimesUs != null) {
					JNIEnv.CopyArray (native_adGroupTimesUs, adGroupTimesUs);
					JNIEnv.DeleteLocalRef (native_adGroupTimesUs);
				}
				global::System.GC.KeepAlive (adGroupTimesUs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkArgument", "(Z)V", "")]
		public static unsafe void CheckArgument (bool expression)
		{
			const string __id = "checkArgument.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expression);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='getAdGroupIndexAfterPositionUs' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("getAdGroupIndexAfterPositionUs", "(JJ)I", "")]
		public unsafe int GetAdGroupIndexAfterPositionUs (long positionUs, long periodDurationUs)
		{
			const string __id = "getAdGroupIndexAfterPositionUs.(JJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (periodDurationUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='getAdGroupIndexForPositionUs' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("getAdGroupIndexForPositionUs", "(JJ)I", "")]
		public unsafe int GetAdGroupIndexForPositionUs (long positionUs, long periodDurationUs)
		{
			const string __id = "getAdGroupIndexForPositionUs.(JJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue (periodDurationUs);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='isAdInErrorState' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("isAdInErrorState", "(II)Z", "")]
		public unsafe bool IsAdInErrorState (int adGroupIndex, int adIndexInAdGroup)
		{
			const string __id = "isAdInErrorState.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adIndexInAdGroup);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='nullSafeArrayCopy' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("nullSafeArrayCopy", "([Ljava/lang/Object;I)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NullSafeArrayCopy (global::Java.Lang.Object[] input, int length)
		{
			const string __id = "nullSafeArrayCopy.([Ljava/lang/Object;I)[Ljava/lang/Object;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withAdCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("withAdCount", "(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithAdCount (int adGroupIndex, int adCount)
		{
			const string __id = "withAdCount.(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adCount);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withAdDurationsUs' and count(parameter)=1 and parameter[1][@type='long[][]']]"
		[Register ("withAdDurationsUs", "([[J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithAdDurationsUs (long[][] adDurationUs)
		{
			const string __id = "withAdDurationsUs.([[J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			IntPtr native_adDurationUs = JNIEnv.NewArray (adDurationUs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adDurationUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (adDurationUs != null) {
					JNIEnv.CopyArray (native_adDurationUs, adDurationUs);
					JNIEnv.DeleteLocalRef (native_adDurationUs);
				}
				global::System.GC.KeepAlive (adDurationUs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withAdLoadError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("withAdLoadError", "(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithAdLoadError (int adGroupIndex, int adIndexInAdGroup)
		{
			const string __id = "withAdLoadError.(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adIndexInAdGroup);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withAdResumePositionUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("withAdResumePositionUs", "(J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithAdResumePositionUs (long adResumePositionUs)
		{
			const string __id = "withAdResumePositionUs.(J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (adResumePositionUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withAdUri' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.net.Uri']]"
		[Register ("withAdUri", "(IILandroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithAdUri (int adGroupIndex, int adIndexInAdGroup, global::Android.Net.Uri uri)
		{
			const string __id = "withAdUri.(IILandroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adIndexInAdGroup);
				__args [2] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withContentDurationUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("withContentDurationUs", "(J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithContentDurationUs (long contentDurationUs)
		{
			const string __id = "withContentDurationUs.(J)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contentDurationUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withPlayedAd' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("withPlayedAd", "(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithPlayedAd (int adGroupIndex, int adIndexInAdGroup)
		{
			const string __id = "withPlayedAd.(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adIndexInAdGroup);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withSkippedAd' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("withSkippedAd", "(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithSkippedAd (int adGroupIndex, int adIndexInAdGroup)
		{
			const string __id = "withSkippedAd.(II)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (adGroupIndex);
				__args [1] = new JniArgumentValue (adIndexInAdGroup);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='AdPlaybackStateTest']/method[@name='withSkippedAdGroup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSkippedAdGroup", "(I)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest WithSkippedAdGroup (int adGroupIndex)
		{
			const string __id = "withSkippedAdGroup.(I)Lcom/example/androidtvlibrary/main/adapter/AdPlaybackStateTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (adGroupIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.AdPlaybackStateTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
