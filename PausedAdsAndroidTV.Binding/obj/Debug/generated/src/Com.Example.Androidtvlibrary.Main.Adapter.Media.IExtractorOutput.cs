using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorOutput']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/ExtractorOutput", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutputInvoker")]
	public partial interface IExtractorOutput : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorOutput']/method[@name='endTracks' and count(parameter)=0]"
		[Register ("endTracks", "()V", "GetEndTracksHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutputInvoker, PausedAdsAndroidTV.Binding")]
		void EndTracks ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorOutput']/method[@name='seekMap' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.SeekMap']]"
		[Register ("seekMap", "(Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap;)V", "GetSeekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutputInvoker, PausedAdsAndroidTV.Binding")]
		void SeekMap (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorOutput']/method[@name='track' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("track", "(II)Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;", "GetTrack_IIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutputInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput Track (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/ExtractorOutput", DoNotGenerateAcw=true)]
	internal partial class IExtractorOutputInvoker : global::Java.Lang.Object, IExtractorOutput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/ExtractorOutput", typeof (IExtractorOutputInvoker));

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

		public static IExtractorOutput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExtractorOutput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.ExtractorOutput'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExtractorOutputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_endTracks;
#pragma warning disable 0169
		static Delegate GetEndTracksHandler ()
		{
			if (cb_endTracks == null)
				cb_endTracks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EndTracks);
			return cb_endTracks;
		}

		static void n_EndTracks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTracks ();
		}
#pragma warning restore 0169

		IntPtr id_endTracks;
		public unsafe void EndTracks ()
		{
			if (id_endTracks == IntPtr.Zero)
				id_endTracks = JNIEnv.GetMethodID (class_ref, "endTracks", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endTracks);
		}

		static Delegate cb_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_;
#pragma warning disable 0169
		static Delegate GetSeekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_Handler ()
		{
			if (cb_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_ == null)
				cb_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SeekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_);
			return cb_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_;
		}

		static void n_SeekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SeekMap (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_;
		public unsafe void SeekMap (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ISeekMap p0)
		{
			if (id_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_ == IntPtr.Zero)
				id_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_ = JNIEnv.GetMethodID (class_ref, "seekMap", "(Lcom/example/androidtvlibrary/main/adapter/Media/SeekMap;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekMap_Lcom_example_androidtvlibrary_main_adapter_Media_SeekMap_, __args);
		}

		static Delegate cb_track_II;
#pragma warning disable 0169
		static Delegate GetTrack_IIHandler ()
		{
			if (cb_track_II == null)
				cb_track_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_Track_II);
			return cb_track_II;
		}

		static IntPtr n_Track_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Track (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_track_II;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput Track (int p0, int p1)
		{
			if (id_track_II == IntPtr.Zero)
				id_track_II = JNIEnv.GetMethodID (class_ref, "track", "(II)Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_track_II, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
