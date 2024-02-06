using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DataSpecTest", DoNotGenerateAcw=true)]
	public sealed partial class DataSpecTest : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='absoluteStreamPosition']"
		[Register ("absoluteStreamPosition")]
		public long AbsoluteStreamPosition {
			get {
				const string __id = "absoluteStreamPosition.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "absoluteStreamPosition.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='flags']"
		[Register ("flags")]
		public int Flags {
			get {
				const string __id = "flags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "flags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='FLAG_ALLOW_CACHE_FRAGMENTATION']"
		[Register ("FLAG_ALLOW_CACHE_FRAGMENTATION")]
		public const int FlagAllowCacheFragmentation = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='FLAG_ALLOW_GZIP']"
		[Register ("FLAG_ALLOW_GZIP")]
		public const int FlagAllowGzip = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='FLAG_DONT_CACHE_IF_LENGTH_UNKNOWN']"
		[Register ("FLAG_DONT_CACHE_IF_LENGTH_UNKNOWN")]
		public const int FlagDontCacheIfLengthUnknown = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='httpBody']"
		[Register ("httpBody")]
		public IList<byte> HttpBody {
			get {
				const string __id = "httpBody.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "httpBody.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='httpMethod']"
		[Register ("httpMethod")]
		public int HttpMethod {
			get {
				const string __id = "httpMethod.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "httpMethod.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='httpRequestHeaders']"
		[Register ("httpRequestHeaders")]
		public global::System.Collections.IDictionary HttpRequestHeaders {
			get {
				const string __id = "httpRequestHeaders.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "httpRequestHeaders.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='HTTP_METHOD_GET']"
		[Register ("HTTP_METHOD_GET")]
		public const int HttpMethodGet = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='HTTP_METHOD_HEAD']"
		[Register ("HTTP_METHOD_HEAD")]
		public const int HttpMethodHead = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='HTTP_METHOD_POST']"
		[Register ("HTTP_METHOD_POST")]
		public const int HttpMethodPost = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='key']"
		[Register ("key")]
		public string Key {
			get {
				const string __id = "key.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "key.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='length']"
		[Register ("length")]
		public long Length {
			get {
				const string __id = "length.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "length.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='position']"
		[Register ("position")]
		public long Position {
			get {
				const string __id = "position.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "position.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/field[@name='uri']"
		[Register ("uri")]
		public global::Android.Net.Uri Uri {
			get {
				const string __id = "uri.Landroid/net/Uri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Landroid/net/Uri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSpecTest.Flags']"
		[Register ("com/example/androidtvlibrary/main/adapter/DataSpecTest$Flags", "", "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest/IFlagsInvoker")]
		public partial interface IFlags : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DataSpecTest$Flags", DoNotGenerateAcw=true)]
		internal partial class IFlagsInvoker : global::Java.Lang.Object, IFlags {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DataSpecTest$Flags", typeof (IFlagsInvoker));

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
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.DataSpecTest.Flags'.");
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='DataSpecTest.HttpMethod']"
		[Register ("com/example/androidtvlibrary/main/adapter/DataSpecTest$HttpMethod", "", "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest/IHttpMethodInvoker")]
		public partial interface IHttpMethod : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DataSpecTest$HttpMethod", DoNotGenerateAcw=true)]
		internal partial class IHttpMethodInvoker : global::Java.Lang.Object, IHttpMethod {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DataSpecTest$HttpMethod", typeof (IHttpMethodInvoker));

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

			public static IHttpMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IHttpMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.DataSpecTest.HttpMethod'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IHttpMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IHttpMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IHttpMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IHttpMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest.IHttpMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DataSpecTest", typeof (DataSpecTest));

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

		internal DataSpecTest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/net/Uri;)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=7 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='byte[]'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Landroid/net/Uri;[BJJJLjava/lang/String;I)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, byte[] postBody, long absoluteStreamPosition, long position, long length, string key, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;[BJJJLjava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_postBody = JNIEnv.NewArray (postBody);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_postBody);
				__args [2] = new JniArgumentValue (absoluteStreamPosition);
				__args [3] = new JniArgumentValue (position);
				__args [4] = new JniArgumentValue (length);
				__args [5] = new JniArgumentValue (native_key);
				__args [6] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (postBody != null) {
					JNIEnv.CopyArray (native_postBody, postBody);
					JNIEnv.DeleteLocalRef (native_postBody);
				}
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (postBody);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/net/Uri;I)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=8 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Landroid/net/Uri;I[BJJJLjava/lang/String;I)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"HttpMethodGet", "HttpMethodPost", "HttpMethodHead"})]
		int httpMethod, byte[] httpBody, long absoluteStreamPosition, long position, long length, string key, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;I[BJJJLjava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpBody = JNIEnv.NewArray (httpBody);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (httpMethod);
				__args [2] = new JniArgumentValue (native_httpBody);
				__args [3] = new JniArgumentValue (absoluteStreamPosition);
				__args [4] = new JniArgumentValue (position);
				__args [5] = new JniArgumentValue (length);
				__args [6] = new JniArgumentValue (native_key);
				__args [7] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (httpBody != null) {
					JNIEnv.CopyArray (native_httpBody, httpBody);
					JNIEnv.DeleteLocalRef (native_httpBody);
				}
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (httpBody);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=9 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int'] and parameter[9][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Landroid/net/Uri;I[BJJJLjava/lang/String;ILjava/util/Map;)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"HttpMethodGet", "HttpMethodPost", "HttpMethodHead"})]
		int httpMethod, byte[] httpBody, long absoluteStreamPosition, long position, long length, string key, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags, global::System.Collections.Generic.IDictionary<string, string> httpRequestHeaders) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;I[BJJJLjava/lang/String;ILjava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpBody = JNIEnv.NewArray (httpBody);
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_httpRequestHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (httpRequestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (httpMethod);
				__args [2] = new JniArgumentValue (native_httpBody);
				__args [3] = new JniArgumentValue (absoluteStreamPosition);
				__args [4] = new JniArgumentValue (position);
				__args [5] = new JniArgumentValue (length);
				__args [6] = new JniArgumentValue (native_key);
				__args [7] = new JniArgumentValue (flags);
				__args [8] = new JniArgumentValue (native_httpRequestHeaders);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (httpBody != null) {
					JNIEnv.CopyArray (native_httpBody, httpBody);
					JNIEnv.DeleteLocalRef (native_httpBody);
				}
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_httpRequestHeaders);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (httpBody);
				global::System.GC.KeepAlive (httpRequestHeaders);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/net/Uri;JJLjava/lang/String;)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, long absoluteStreamPosition, long length, string key) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;JJLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (absoluteStreamPosition);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (native_key);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/net/Uri;JJLjava/lang/String;I)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, long absoluteStreamPosition, long length, string key, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;JJLjava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (absoluteStreamPosition);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (native_key);
				__args [4] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=6 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Landroid/net/Uri;JJLjava/lang/String;ILjava/util/Map;)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, long absoluteStreamPosition, long length, string key, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags, global::System.Collections.Generic.IDictionary<string, string> httpRequestHeaders) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;JJLjava/lang/String;ILjava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_httpRequestHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (httpRequestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (absoluteStreamPosition);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (native_key);
				__args [4] = new JniArgumentValue (flags);
				__args [5] = new JniArgumentValue (native_httpRequestHeaders);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_httpRequestHeaders);
				global::System.GC.KeepAlive (uri);
				global::System.GC.KeepAlive (httpRequestHeaders);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/constructor[@name='DataSpecTest' and count(parameter)=6 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Landroid/net/Uri;JJJLjava/lang/String;I)V", "")]
		public unsafe DataSpecTest (global::Android.Net.Uri uri, long absoluteStreamPosition, long position, long length, string key, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/net/Uri;JJJLjava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (absoluteStreamPosition);
				__args [2] = new JniArgumentValue (position);
				__args [3] = new JniArgumentValue (length);
				__args [4] = new JniArgumentValue (native_key);
				__args [5] = new JniArgumentValue (flags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (uri);
			}
		}

		public unsafe string HttpMethodString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='getHttpMethodString' and count(parameter)=0]"
			[Register ("getHttpMethodString", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getHttpMethodString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='getStringForHttpMethod' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStringForHttpMethod", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetStringForHttpMethod ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"HttpMethodGet", "HttpMethodPost", "HttpMethodHead"})]
		int httpMethod)
		{
			const string __id = "getStringForHttpMethod.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (httpMethod);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='isFlagSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isFlagSet", "(I)Z", "")]
		public unsafe bool IsFlagSet ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest", Fields = new string [] {"FlagAllowGzip", "FlagDontCacheIfLengthUnknown", "FlagAllowCacheFragmentation"})]
		int flag)
		{
			const string __id = "isFlagSet.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='subrange' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("subrange", "(J)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest Subrange (long offset)
		{
			const string __id = "subrange.(J)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='subrange' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("subrange", "(JJ)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest Subrange (long offset, long length)
		{
			const string __id = "subrange.(JJ)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='withAdditionalHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("withAdditionalHeaders", "(Ljava/util/Map;)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest WithAdditionalHeaders (global::System.Collections.Generic.IDictionary<string, string> requestHeaders)
		{
			const string __id = "withAdditionalHeaders.(Ljava/util/Map;)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";
			IntPtr native_requestHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestHeaders);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
				global::System.GC.KeepAlive (requestHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='withRequestHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("withRequestHeaders", "(Ljava/util/Map;)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest WithRequestHeaders (global::System.Collections.Generic.IDictionary<string, string> requestHeaders)
		{
			const string __id = "withRequestHeaders.(Ljava/util/Map;)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";
			IntPtr native_requestHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestHeaders);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
				global::System.GC.KeepAlive (requestHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DataSpecTest']/method[@name='withUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("withUri", "(Landroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest WithUri (global::Android.Net.Uri uri)
		{
			const string __id = "withUri.(Landroid/net/Uri;)Lcom/example/androidtvlibrary/main/adapter/DataSpecTest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpecTest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

	}
}
