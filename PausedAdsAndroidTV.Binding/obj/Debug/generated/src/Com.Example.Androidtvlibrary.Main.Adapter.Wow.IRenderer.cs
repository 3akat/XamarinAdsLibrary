using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer.State']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/Renderer$State", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererStateInvoker")]
	public partial interface IRendererState : global::Java.Lang.Annotation.IAnnotation {
	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/Renderer$State", DoNotGenerateAcw=true)]
	internal partial class IRendererStateInvoker : global::Java.Lang.Object, IRendererState {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/Renderer$State", typeof (IRendererStateInvoker));

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

		public static IRendererState GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRendererState> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.Renderer.State'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRendererStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[Register ("com/example/androidtvlibrary/main/adapter/wow/Renderer", DoNotGenerateAcw=true)]
	public abstract class Renderer : Java.Lang.Object {
		internal Renderer ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/field[@name='STATE_DISABLED']"
		[Register ("STATE_DISABLED")]
		public const int StateDisabled = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/field[@name='STATE_ENABLED']"
		[Register ("STATE_ENABLED")]
		public const int StateEnabled = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/field[@name='STATE_STARTED']"
		[Register ("STATE_STARTED")]
		public const int StateStarted = (int) 2;

		// The following are fields from: com.example.androidtvlibrary.main.adapter.wow.PlayerMessage.Target

	}

	[Register ("com/example/androidtvlibrary/main/adapter/wow/Renderer", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Renderer' type. This type will be removed in a future release.", error: true)]
	public abstract class RendererConsts : Renderer {
		private RendererConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/Renderer", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker")]
	public partial interface IRenderer : global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.PlayerMessage.ITarget {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities Capabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='getCapabilities' and count(parameter)=0]"
			[Register ("getCapabilities", "()Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;", "GetGetCapabilitiesHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool HasReadStreamToEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='hasReadStreamToEnd' and count(parameter)=0]"
			[Register ("hasReadStreamToEnd", "()Z", "GetHasReadStreamToEndHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsCurrentStreamFinal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='isCurrentStreamFinal' and count(parameter)=0]"
			[Register ("isCurrentStreamFinal", "()Z", "GetIsCurrentStreamFinalHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock MediaClock {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='getMediaClock' and count(parameter)=0]"
			[Register ("getMediaClock", "()Lcom/example/androidtvlibrary/main/adapter/wow/MediaClock;", "GetGetMediaClockHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long ReadingPositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='getReadingPositionUs' and count(parameter)=0]"
			[Register ("getReadingPositionUs", "()J", "GetGetReadingPositionUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;", "GetGetStreamHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int TrackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='getTrackType' and count(parameter)=0]"
			[Register ("getTrackType", "()I", "GetGetTrackTypeHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='enable' and count(parameter)=6 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.RendererConfiguration'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Format[]'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.wow.SampleStream'] and parameter[4][@type='long'] and parameter[5][@type='boolean'] and parameter[6][@type='long']]"
		[Register ("enable", "(Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;[Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;JZJ)V", "GetEnable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void Enable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream p2, long p3, bool p4, long p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='maybeThrowStreamError' and count(parameter)=0]"
		[Register ("maybeThrowStreamError", "()V", "GetMaybeThrowStreamErrorHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void MaybeThrowStreamError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='render' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("render", "(JJ)V", "GetRender_JJHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void Render (long p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='replaceStream' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.SampleStream'] and parameter[3][@type='long']]"
		[Register ("replaceStream", "([Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;J)V", "GetReplaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void ReplaceStream (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='resetPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("resetPosition", "(J)V", "GetResetPosition_JHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void ResetPosition (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='setCurrentStreamFinal' and count(parameter)=0]"
		[Register ("setCurrentStreamFinal", "()V", "GetSetCurrentStreamFinalHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void SetCurrentStreamFinal ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='setIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndex", "(I)V", "GetSetIndex_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void SetIndex (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Renderer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererInvoker, PausedAdsAndroidTV.Binding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/Renderer", DoNotGenerateAcw=true)]
	internal partial class IRendererInvoker : global::Java.Lang.Object, IRenderer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/Renderer", typeof (IRendererInvoker));

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

		public static IRenderer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRenderer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.Renderer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCapabilities;
#pragma warning disable 0169
		static Delegate GetGetCapabilitiesHandler ()
		{
			if (cb_getCapabilities == null)
				cb_getCapabilities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCapabilities);
			return cb_getCapabilities;
		}

		static IntPtr n_GetCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Capabilities);
		}
#pragma warning restore 0169

		IntPtr id_getCapabilities;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities Capabilities {
			get {
				if (id_getCapabilities == IntPtr.Zero)
					id_getCapabilities = JNIEnv.GetMethodID (class_ref, "getCapabilities", "()Lcom/example/androidtvlibrary/main/adapter/wow/RendererCapabilities;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRendererCapabilities> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCapabilities), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasReadStreamToEnd;
#pragma warning disable 0169
		static Delegate GetHasReadStreamToEndHandler ()
		{
			if (cb_hasReadStreamToEnd == null)
				cb_hasReadStreamToEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasReadStreamToEnd);
			return cb_hasReadStreamToEnd;
		}

		static bool n_HasReadStreamToEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasReadStreamToEnd;
		}
#pragma warning restore 0169

		IntPtr id_hasReadStreamToEnd;
		public unsafe bool HasReadStreamToEnd {
			get {
				if (id_hasReadStreamToEnd == IntPtr.Zero)
					id_hasReadStreamToEnd = JNIEnv.GetMethodID (class_ref, "hasReadStreamToEnd", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasReadStreamToEnd);
			}
		}

		static Delegate cb_isCurrentStreamFinal;
#pragma warning disable 0169
		static Delegate GetIsCurrentStreamFinalHandler ()
		{
			if (cb_isCurrentStreamFinal == null)
				cb_isCurrentStreamFinal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCurrentStreamFinal);
			return cb_isCurrentStreamFinal;
		}

		static bool n_IsCurrentStreamFinal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentStreamFinal;
		}
#pragma warning restore 0169

		IntPtr id_isCurrentStreamFinal;
		public unsafe bool IsCurrentStreamFinal {
			get {
				if (id_isCurrentStreamFinal == IntPtr.Zero)
					id_isCurrentStreamFinal = JNIEnv.GetMethodID (class_ref, "isCurrentStreamFinal", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentStreamFinal);
			}
		}

		static Delegate cb_isEnded;
#pragma warning disable 0169
		static Delegate GetIsEndedHandler ()
		{
			if (cb_isEnded == null)
				cb_isEnded = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnded);
			return cb_isEnded;
		}

		static bool n_IsEnded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnded;
		}
#pragma warning restore 0169

		IntPtr id_isEnded;
		public unsafe bool IsEnded {
			get {
				if (id_isEnded == IntPtr.Zero)
					id_isEnded = JNIEnv.GetMethodID (class_ref, "isEnded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnded);
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		IntPtr id_isReady;
		public unsafe bool IsReady {
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReady);
			}
		}

		static Delegate cb_getMediaClock;
#pragma warning disable 0169
		static Delegate GetGetMediaClockHandler ()
		{
			if (cb_getMediaClock == null)
				cb_getMediaClock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMediaClock);
			return cb_getMediaClock;
		}

		static IntPtr n_GetMediaClock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaClock);
		}
#pragma warning restore 0169

		IntPtr id_getMediaClock;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock MediaClock {
			get {
				if (id_getMediaClock == IntPtr.Zero)
					id_getMediaClock = JNIEnv.GetMethodID (class_ref, "getMediaClock", "()Lcom/example/androidtvlibrary/main/adapter/wow/MediaClock;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IMediaClock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaClock), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReadingPositionUs;
#pragma warning disable 0169
		static Delegate GetGetReadingPositionUsHandler ()
		{
			if (cb_getReadingPositionUs == null)
				cb_getReadingPositionUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetReadingPositionUs);
			return cb_getReadingPositionUs;
		}

		static long n_GetReadingPositionUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadingPositionUs;
		}
#pragma warning restore 0169

		IntPtr id_getReadingPositionUs;
		public unsafe long ReadingPositionUs {
			get {
				if (id_getReadingPositionUs == IntPtr.Zero)
					id_getReadingPositionUs = JNIEnv.GetMethodID (class_ref, "getReadingPositionUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getReadingPositionUs);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe int State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getState);
			}
		}

		static Delegate cb_getStream;
#pragma warning disable 0169
		static Delegate GetGetStreamHandler ()
		{
			if (cb_getStream == null)
				cb_getStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStream);
			return cb_getStream;
		}

		static IntPtr n_GetStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Stream);
		}
#pragma warning restore 0169

		IntPtr id_getStream;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream Stream {
			get {
				if (id_getStream == IntPtr.Zero)
					id_getStream = JNIEnv.GetMethodID (class_ref, "getStream", "()Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTrackType;
#pragma warning disable 0169
		static Delegate GetGetTrackTypeHandler ()
		{
			if (cb_getTrackType == null)
				cb_getTrackType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTrackType);
			return cb_getTrackType;
		}

		static int n_GetTrackType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackType;
		}
#pragma warning restore 0169

		IntPtr id_getTrackType;
		public unsafe int TrackType {
			get {
				if (id_getTrackType == IntPtr.Zero)
					id_getTrackType = JNIEnv.GetMethodID (class_ref, "getTrackType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackType);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ;
#pragma warning disable 0169
		static Delegate GetEnable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJHandler ()
		{
			if (cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ == null)
				cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLJZJ_V) n_Enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ);
			return cb_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ;
		}

		static void n_Enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, bool p4, long p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			var p2 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1, p2, p3, p4, p5);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ;
		public unsafe void Enable (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.RendererConfiguration p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] p1, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream p2, long p3, bool p4, long p5)
		{
			if (id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ == IntPtr.Zero)
				id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ = JNIEnv.GetMethodID (class_ref, "enable", "(Lcom/example/androidtvlibrary/main/adapter/wow/RendererConfiguration;[Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;JZJ)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_Lcom_example_androidtvlibrary_main_adapter_wow_RendererConfiguration_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JZJ, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_maybeThrowStreamError;
#pragma warning disable 0169
		static Delegate GetMaybeThrowStreamErrorHandler ()
		{
			if (cb_maybeThrowStreamError == null)
				cb_maybeThrowStreamError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MaybeThrowStreamError);
			return cb_maybeThrowStreamError;
		}

		static void n_MaybeThrowStreamError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaybeThrowStreamError ();
		}
#pragma warning restore 0169

		IntPtr id_maybeThrowStreamError;
		public unsafe void MaybeThrowStreamError ()
		{
			if (id_maybeThrowStreamError == IntPtr.Zero)
				id_maybeThrowStreamError = JNIEnv.GetMethodID (class_ref, "maybeThrowStreamError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_maybeThrowStreamError);
		}

		static Delegate cb_render_JJ;
#pragma warning disable 0169
		static Delegate GetRender_JJHandler ()
		{
			if (cb_render_JJ == null)
				cb_render_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_Render_JJ);
			return cb_render_JJ;
		}

		static void n_Render_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Render (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_render_JJ;
		public unsafe void Render (long p0, long p1)
		{
			if (id_render_JJ == IntPtr.Zero)
				id_render_JJ = JNIEnv.GetMethodID (class_ref, "render", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_render_JJ, __args);
		}

		static Delegate cb_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J;
#pragma warning disable 0169
		static Delegate GetReplaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_JHandler ()
		{
			if (cb_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J == null)
				cb_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_ReplaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J);
			return cb_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J;
		}

		static void n_ReplaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Format));
			var p1 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceStream (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J;
		public unsafe void ReplaceStream (global::Com.Example.Androidtvlibrary.Main.Adapter.Format[] p0, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ISampleStream p1, long p2)
		{
			if (id_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J == IntPtr.Zero)
				id_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J = JNIEnv.GetMethodID (class_ref, "replaceStream", "([Lcom/example/androidtvlibrary/main/adapter/Format;Lcom/example/androidtvlibrary/main/adapter/wow/SampleStream;J)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replaceStream_arrayLcom_example_androidtvlibrary_main_adapter_Format_Lcom_example_androidtvlibrary_main_adapter_wow_SampleStream_J, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

		static Delegate cb_resetPosition_J;
#pragma warning disable 0169
		static Delegate GetResetPosition_JHandler ()
		{
			if (cb_resetPosition_J == null)
				cb_resetPosition_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_ResetPosition_J);
			return cb_resetPosition_J;
		}

		static void n_ResetPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_resetPosition_J;
		public unsafe void ResetPosition (long p0)
		{
			if (id_resetPosition_J == IntPtr.Zero)
				id_resetPosition_J = JNIEnv.GetMethodID (class_ref, "resetPosition", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetPosition_J, __args);
		}

		static Delegate cb_setCurrentStreamFinal;
#pragma warning disable 0169
		static Delegate GetSetCurrentStreamFinalHandler ()
		{
			if (cb_setCurrentStreamFinal == null)
				cb_setCurrentStreamFinal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetCurrentStreamFinal);
			return cb_setCurrentStreamFinal;
		}

		static void n_SetCurrentStreamFinal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentStreamFinal ();
		}
#pragma warning restore 0169

		IntPtr id_setCurrentStreamFinal;
		public unsafe void SetCurrentStreamFinal ()
		{
			if (id_setCurrentStreamFinal == IntPtr.Zero)
				id_setCurrentStreamFinal = JNIEnv.GetMethodID (class_ref, "setCurrentStreamFinal", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentStreamFinal);
		}

		static Delegate cb_setIndex_I;
#pragma warning disable 0169
		static Delegate GetSetIndex_IHandler ()
		{
			if (cb_setIndex_I == null)
				cb_setIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetIndex_I);
			return cb_setIndex_I;
		}

		static void n_SetIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndex (p0);
		}
#pragma warning restore 0169

		IntPtr id_setIndex_I;
		public unsafe void SetIndex (int p0)
		{
			if (id_setIndex_I == IntPtr.Zero)
				id_setIndex_I = JNIEnv.GetMethodID (class_ref, "setIndex", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndex_I, __args);
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

		static Delegate cb_handleMessage_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_ILjava_lang_Object_Handler ()
		{
			if (cb_handleMessage_ILjava_lang_Object_ == null)
				cb_handleMessage_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_HandleMessage_ILjava_lang_Object_);
			return cb_handleMessage_ILjava_lang_Object_;
		}

		static void n_HandleMessage_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_handleMessage_ILjava_lang_Object_;
		public unsafe void HandleMessage (int p0, global::Java.Lang.Object p1)
		{
			if (id_handleMessage_ILjava_lang_Object_ == IntPtr.Zero)
				id_handleMessage_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleMessage_ILjava_lang_Object_, __args);
		}

	}
}
