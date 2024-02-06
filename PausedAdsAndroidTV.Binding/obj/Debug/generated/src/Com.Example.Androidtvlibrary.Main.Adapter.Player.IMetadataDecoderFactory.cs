using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	[Register ("com/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory", DoNotGenerateAcw=true)]
	public abstract class MetadataDecoderFactory : Java.Lang.Object {
		internal MetadataDecoderFactory ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MetadataDecoderFactory']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactory Default {
			get {
				const string __id = "DEFAULT.Lcom/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory", typeof (MetadataDecoderFactory));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MetadataDecoderFactory' type. This type will be removed in a future release.", error: true)]
	public abstract class MetadataDecoderFactoryConsts : MetadataDecoderFactory {
		private MetadataDecoderFactoryConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MetadataDecoderFactory']"
	[Register ("com/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactoryInvoker")]
	public partial interface IMetadataDecoderFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MetadataDecoderFactory']/method[@name='createDecoder' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("createDecoder", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataDecoder;", "GetCreateDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactoryInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoder CreateDecoder (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='MetadataDecoderFactory']/method[@name='supportsFormat' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Format']]"
		[Register ("supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Z", "GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactoryInvoker, PausedAdsAndroidTV.Binding")]
		bool SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory", DoNotGenerateAcw=true)]
	internal partial class IMetadataDecoderFactoryInvoker : global::Java.Lang.Object, IMetadataDecoderFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/MetadataDecoderFactory", typeof (IMetadataDecoderFactoryInvoker));

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

		public static IMetadataDecoderFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataDecoderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.MetadataDecoderFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataDecoderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetCreateDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static IntPtr n_CreateDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDecoder (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoder CreateDecoder (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
		{
			if (id_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_ == IntPtr.Zero)
				id_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNIEnv.GetMethodID (class_ref, "createDecoder", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataDecoder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createDecoder_Lcom_example_androidtvlibrary_main_adapter_Format_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
#pragma warning disable 0169
		static Delegate GetSupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_Handler ()
		{
			if (cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ == null)
				cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_);
			return cb_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
		}

		static bool n_SupportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.IMetadataDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Format> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SupportsFormat (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_;
		public unsafe bool SupportsFormat (global::Com.Example.Androidtvlibrary.Main.Adapter.Format p0)
		{
			if (id_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ == IntPtr.Zero)
				id_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_ = JNIEnv.GetMethodID (class_ref, "supportsFormat", "(Lcom/example/androidtvlibrary/main/adapter/Format;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supportsFormat_Lcom_example_androidtvlibrary_main_adapter_Format_, __args);
			return __ret;
		}

	}
}
