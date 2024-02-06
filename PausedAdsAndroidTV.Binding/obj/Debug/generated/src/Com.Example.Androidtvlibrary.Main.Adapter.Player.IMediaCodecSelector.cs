using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	[Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecSelector", DoNotGenerateAcw=true)]
	public abstract class MediaCodecSelector : Java.Lang.Object {
		internal MediaCodecSelector ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MediaCodecSelector']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector Default {
			get {
				const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecSelector;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecSelector", typeof (MediaCodecSelector));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecSelector", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MediaCodecSelector' type. This type will be removed in a future release.", error: true)]
	public abstract class MediaCodecSelectorConsts : MediaCodecSelector {
		private MediaCodecSelectorConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MediaCodecSelector']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecSelector", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelectorInvoker")]
	public partial interface IMediaCodecSelector : IJavaObject, IJavaPeerable {
		global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo PassthroughDecoderInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MediaCodecSelector']/method[@name='getPassthroughDecoderInfo' and count(parameter)=0]"
			[Register ("getPassthroughDecoderInfo", "()Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;", "GetGetPassthroughDecoderInfoHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelectorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MediaCodecSelector']/method[@name='getDecoderInfos' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("getDecoderInfos", "(Ljava/lang/String;ZZ)Ljava/util/List;", "GetGetDecoderInfos_Ljava_lang_String_ZZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelectorInvoker, PausedAdsAndroidTV.Binding")]
		global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfos (string p0, bool p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MediaCodecSelector", DoNotGenerateAcw=true)]
	internal partial class IMediaCodecSelectorInvoker : global::Java.Lang.Object, IMediaCodecSelector {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MediaCodecSelector", typeof (IMediaCodecSelectorInvoker));

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

		public static IMediaCodecSelector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaCodecSelector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.MediaCodecSelector'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaCodecSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPassthroughDecoderInfo;
#pragma warning disable 0169
		static Delegate GetGetPassthroughDecoderInfoHandler ()
		{
			if (cb_getPassthroughDecoderInfo == null)
				cb_getPassthroughDecoderInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPassthroughDecoderInfo);
			return cb_getPassthroughDecoderInfo;
		}

		static IntPtr n_GetPassthroughDecoderInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PassthroughDecoderInfo);
		}
#pragma warning restore 0169

		IntPtr id_getPassthroughDecoderInfo;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo PassthroughDecoderInfo {
			get {
				if (id_getPassthroughDecoderInfo == IntPtr.Zero)
					id_getPassthroughDecoderInfo = JNIEnv.GetMethodID (class_ref, "getPassthroughDecoderInfo", "()Lcom/example/androidtvlibrary/main/adapter/player/MediaCodecInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassthroughDecoderInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDecoderInfos_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetGetDecoderInfos_Ljava_lang_String_ZZHandler ()
		{
			if (cb_getDecoderInfos_Ljava_lang_String_ZZ == null)
				cb_getDecoderInfos_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_L) n_GetDecoderInfos_Ljava_lang_String_ZZ);
			return cb_getDecoderInfos_Ljava_lang_String_ZZ;
		}

		static IntPtr n_GetDecoderInfos_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMediaCodecSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.ToLocalJniHandle (__this.GetDecoderInfos (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDecoderInfos_Ljava_lang_String_ZZ;
		public unsafe global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo> GetDecoderInfos (string p0, bool p1, bool p2)
		{
			if (id_getDecoderInfos_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_getDecoderInfos_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "getDecoderInfos", "(Ljava/lang/String;ZZ)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.MediaCodecInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDecoderInfos_Ljava_lang_String_ZZ, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
