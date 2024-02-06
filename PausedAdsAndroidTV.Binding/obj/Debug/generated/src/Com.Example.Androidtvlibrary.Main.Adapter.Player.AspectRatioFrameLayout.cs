using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout", DoNotGenerateAcw=true)]
	public sealed partial class AspectRatioFrameLayout : global::Android.Widget.FrameLayout {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/field[@name='RESIZE_MODE_FILL']"
		[Register ("RESIZE_MODE_FILL")]
		public const int ResizeModeFill = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/field[@name='RESIZE_MODE_FIT']"
		[Register ("RESIZE_MODE_FIT")]
		public const int ResizeModeFit = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/field[@name='RESIZE_MODE_FIXED_HEIGHT']"
		[Register ("RESIZE_MODE_FIXED_HEIGHT")]
		public const int ResizeModeFixedHeight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/field[@name='RESIZE_MODE_FIXED_WIDTH']"
		[Register ("RESIZE_MODE_FIXED_WIDTH")]
		public const int ResizeModeFixedWidth = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/field[@name='RESIZE_MODE_ZOOM']"
		[Register ("RESIZE_MODE_ZOOM")]
		public const int ResizeModeZoom = (int) 4;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AspectRatioFrameLayout.AspectRatioListener']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout/IAspectRatioListenerInvoker")]
		public partial interface IAspectRatioListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AspectRatioFrameLayout.AspectRatioListener']/method[@name='onAspectRatioUpdated' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
			[Register ("onAspectRatioUpdated", "(FFZ)V", "GetOnAspectRatioUpdated_FFZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout/IAspectRatioListenerInvoker, PausedAdsAndroidTV.Binding")]
			void OnAspectRatioUpdated (float p0, float p1, bool p2);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener", DoNotGenerateAcw=true)]
		internal partial class IAspectRatioListenerInvoker : global::Java.Lang.Object, IAspectRatioListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener", typeof (IAspectRatioListenerInvoker));

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

			public static IAspectRatioListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAspectRatioListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.AspectRatioFrameLayout.AspectRatioListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAspectRatioListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAspectRatioUpdated_FFZ;
#pragma warning disable 0169
			static Delegate GetOnAspectRatioUpdated_FFZHandler ()
			{
				if (cb_onAspectRatioUpdated_FFZ == null)
					cb_onAspectRatioUpdated_FFZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFZ_V) n_OnAspectRatioUpdated_FFZ);
				return cb_onAspectRatioUpdated_FFZ;
			}

			static void n_OnAspectRatioUpdated_FFZ (IntPtr jnienv, IntPtr native__this, float p0, float p1, bool p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAspectRatioUpdated (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onAspectRatioUpdated_FFZ;
			public unsafe void OnAspectRatioUpdated (float p0, float p1, bool p2)
			{
				if (id_onAspectRatioUpdated_FFZ == IntPtr.Zero)
					id_onAspectRatioUpdated_FFZ = JNIEnv.GetMethodID (class_ref, "onAspectRatioUpdated", "(FFZ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAspectRatioUpdated_FFZ, __args);
			}

		}

		// event args for com.example.androidtvlibrary.main.adapter.player.AspectRatioFrameLayout.AspectRatioListener.onAspectRatioUpdated
		public partial class AspectRatioEventArgs : global::System.EventArgs {
			public AspectRatioEventArgs (float p0, float p1, bool p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			float p0;

			public float P0 {
				get { return p0; }
			}

			float p1;

			public float P1 {
				get { return p1; }
			}

			bool p2;

			public bool P2 {
				get { return p2; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout_AspectRatioListenerImplementor")]
		internal sealed partial class IAspectRatioListenerImplementor : global::Java.Lang.Object, IAspectRatioListener {

			object sender;

			public IAspectRatioListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout_AspectRatioListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<AspectRatioEventArgs> Handler;
			#pragma warning restore 0649

			public void OnAspectRatioUpdated (float p0, float p1, bool p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AspectRatioEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IAspectRatioListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='AspectRatioFrameLayout.ResizeMode']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$ResizeMode", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout/IResizeModeInvoker")]
		public partial interface IResizeMode : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$ResizeMode", DoNotGenerateAcw=true)]
		internal partial class IResizeModeInvoker : global::Java.Lang.Object, IResizeMode {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$ResizeMode", typeof (IResizeModeInvoker));

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

			public static IResizeMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResizeMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.AspectRatioFrameLayout.ResizeMode'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResizeModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IResizeMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IResizeMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IResizeMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IResizeMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout", typeof (AspectRatioFrameLayout));

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

		internal AspectRatioFrameLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/constructor[@name='AspectRatioFrameLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AspectRatioFrameLayout (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/constructor[@name='AspectRatioFrameLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AspectRatioFrameLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		public unsafe int ResizeMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/method[@name='getResizeMode' and count(parameter)=0]"
			[Register ("getResizeMode", "()I", "")]
			get {
				const string __id = "getResizeMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/method[@name='setResizeMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResizeMode", "(I)V", "")]
			set {
				const string __id = "setResizeMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/method[@name='setAspectRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setAspectRatio", "(F)V", "")]
		public unsafe void SetAspectRatio (float widthHeightRatio)
		{
			const string __id = "setAspectRatio.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (widthHeightRatio);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='AspectRatioFrameLayout']/method[@name='setAspectRatioListener' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.AspectRatioFrameLayout.AspectRatioListener']]"
		[Register ("setAspectRatioListener", "(Lcom/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener;)V", "")]
		public unsafe void SetAspectRatioListener (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener listener)
		{
			const string __id = "setAspectRatioListener.(Lcom/example/androidtvlibrary/main/adapter/player/AspectRatioFrameLayout$AspectRatioListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		#region "Event implementation for Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener"

		public event EventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.AspectRatioEventArgs> AspectRatio {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor>(
				ref weak_implementor_SetAspectRatioListener,
				__CreateIAspectRatioListenerImplementor,
				SetAspectRatioListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListener, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor>(
				ref weak_implementor_SetAspectRatioListener,
				global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor.__IsEmpty,
				__v => SetAspectRatioListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetAspectRatioListener;

		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor __CreateIAspectRatioListenerImplementor ()
		{
			return new global::Com.Example.Androidtvlibrary.Main.Adapter.Player.AspectRatioFrameLayout.IAspectRatioListenerImplementor (this);
		}

		#endregion

	}
}
