using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	[Register ("com/example/androidtvlibrary/main/adapter/MediaChunkIterator", DoNotGenerateAcw=true)]
	public abstract class MediaChunkIterator : Java.Lang.Object {
		internal MediaChunkIterator ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator Empty {
			get {
				const string __id = "EMPTY.Lcom/example/androidtvlibrary/main/adapter/MediaChunkIterator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/MediaChunkIterator", typeof (MediaChunkIterator));

	}

	[Register ("com/example/androidtvlibrary/main/adapter/MediaChunkIterator", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MediaChunkIterator' type. This type will be removed in a future release.", error: true)]
	public abstract class MediaChunkIteratorConsts : MediaChunkIterator {
		private MediaChunkIteratorConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']"
	[Register ("com/example/androidtvlibrary/main/adapter/MediaChunkIterator", "", "Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker")]
	public partial interface IMediaChunkIterator : IJavaObject, IJavaPeerable {
		long ChunkEndTimeUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/method[@name='getChunkEndTimeUs' and count(parameter)=0]"
			[Register ("getChunkEndTimeUs", "()J", "GetGetChunkEndTimeUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long ChunkStartTimeUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/method[@name='getChunkStartTimeUs' and count(parameter)=0]"
			[Register ("getChunkStartTimeUs", "()J", "GetGetChunkStartTimeUsHandler:Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec DataSpec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/method[@name='getDataSpec' and count(parameter)=0]"
			[Register ("getDataSpec", "()Lcom/example/androidtvlibrary/main/adapter/DataSpec;", "GetGetDataSpecHandler:Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		bool IsEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/method[@name='isEnded' and count(parameter)=0]"
			[Register ("isEnded", "()Z", "GetIsEndedHandler:Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Z", "GetNextHandler:Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker, PausedAdsAndroidTV.Binding")]
		bool Next ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='MediaChunkIterator']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIteratorInvoker, PausedAdsAndroidTV.Binding")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/MediaChunkIterator", DoNotGenerateAcw=true)]
	internal partial class IMediaChunkIteratorInvoker : global::Java.Lang.Object, IMediaChunkIterator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/MediaChunkIterator", typeof (IMediaChunkIteratorInvoker));

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

		public static IMediaChunkIterator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaChunkIterator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.MediaChunkIterator'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaChunkIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getChunkEndTimeUs;
#pragma warning disable 0169
		static Delegate GetGetChunkEndTimeUsHandler ()
		{
			if (cb_getChunkEndTimeUs == null)
				cb_getChunkEndTimeUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetChunkEndTimeUs);
			return cb_getChunkEndTimeUs;
		}

		static long n_GetChunkEndTimeUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChunkEndTimeUs;
		}
#pragma warning restore 0169

		IntPtr id_getChunkEndTimeUs;
		public unsafe long ChunkEndTimeUs {
			get {
				if (id_getChunkEndTimeUs == IntPtr.Zero)
					id_getChunkEndTimeUs = JNIEnv.GetMethodID (class_ref, "getChunkEndTimeUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getChunkEndTimeUs);
			}
		}

		static Delegate cb_getChunkStartTimeUs;
#pragma warning disable 0169
		static Delegate GetGetChunkStartTimeUsHandler ()
		{
			if (cb_getChunkStartTimeUs == null)
				cb_getChunkStartTimeUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetChunkStartTimeUs);
			return cb_getChunkStartTimeUs;
		}

		static long n_GetChunkStartTimeUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChunkStartTimeUs;
		}
#pragma warning restore 0169

		IntPtr id_getChunkStartTimeUs;
		public unsafe long ChunkStartTimeUs {
			get {
				if (id_getChunkStartTimeUs == IntPtr.Zero)
					id_getChunkStartTimeUs = JNIEnv.GetMethodID (class_ref, "getChunkStartTimeUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getChunkStartTimeUs);
			}
		}

		static Delegate cb_getDataSpec;
#pragma warning disable 0169
		static Delegate GetGetDataSpecHandler ()
		{
			if (cb_getDataSpec == null)
				cb_getDataSpec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataSpec);
			return cb_getDataSpec;
		}

		static IntPtr n_GetDataSpec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSpec);
		}
#pragma warning restore 0169

		IntPtr id_getDataSpec;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec DataSpec {
			get {
				if (id_getDataSpec == IntPtr.Zero)
					id_getDataSpec = JNIEnv.GetMethodID (class_ref, "getDataSpec", "()Lcom/example/androidtvlibrary/main/adapter/DataSpec;");
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DataSpec> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSpec), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Next);
			return cb_next;
		}

		static bool n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Next ();
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe bool Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_next);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.IMediaChunkIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}
}
