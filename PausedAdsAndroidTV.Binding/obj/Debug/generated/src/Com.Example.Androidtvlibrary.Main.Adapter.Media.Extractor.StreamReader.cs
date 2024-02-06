using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/StreamReader", DoNotGenerateAcw=true)]
	public abstract partial class StreamReader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/StreamReader", typeof (StreamReader));

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

		protected StreamReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/constructor[@name='StreamReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StreamReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_convertGranuleToTime_J;
#pragma warning disable 0169
		static Delegate GetConvertGranuleToTime_JHandler ()
		{
			if (cb_convertGranuleToTime_J == null)
				cb_convertGranuleToTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_ConvertGranuleToTime_J);
			return cb_convertGranuleToTime_J;
		}

		static long n_ConvertGranuleToTime_J (IntPtr jnienv, IntPtr native__this, long granule)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConvertGranuleToTime (granule);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/method[@name='convertGranuleToTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertGranuleToTime", "(J)J", "GetConvertGranuleToTime_JHandler")]
		protected virtual unsafe long ConvertGranuleToTime (long granule)
		{
			const string __id = "convertGranuleToTime.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (granule);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_convertTimeToGranule_J;
#pragma warning disable 0169
		static Delegate GetConvertTimeToGranule_JHandler ()
		{
			if (cb_convertTimeToGranule_J == null)
				cb_convertTimeToGranule_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_ConvertTimeToGranule_J);
			return cb_convertTimeToGranule_J;
		}

		static long n_ConvertTimeToGranule_J (IntPtr jnienv, IntPtr native__this, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConvertTimeToGranule (timeUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/method[@name='convertTimeToGranule' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertTimeToGranule", "(J)J", "GetConvertTimeToGranule_JHandler")]
		protected virtual unsafe long ConvertTimeToGranule (long timeUs)
		{
			const string __id = "convertTimeToGranule.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onSeekEnd_J;
#pragma warning disable 0169
		static Delegate GetOnSeekEnd_JHandler ()
		{
			if (cb_onSeekEnd_J == null)
				cb_onSeekEnd_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_OnSeekEnd_J);
			return cb_onSeekEnd_J;
		}

		static void n_OnSeekEnd_J (IntPtr jnienv, IntPtr native__this, long currentGranule)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSeekEnd (currentGranule);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/method[@name='onSeekEnd' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onSeekEnd", "(J)V", "GetOnSeekEnd_JHandler")]
		protected virtual unsafe void OnSeekEnd (long currentGranule)
		{
			const string __id = "onSeekEnd.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentGranule);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_preparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
#pragma warning disable 0169
		static Delegate GetPreparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler ()
		{
			if (cb_preparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ == null)
				cb_preparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_PreparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_);
			return cb_preparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
		}

		static long n_PreparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.PreparePayload (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/method[@name='preparePayload' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("preparePayload", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)J", "GetPreparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler")]
		protected abstract long PreparePayload (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0);

		static Delegate cb_reset_Z;
#pragma warning disable 0169
		static Delegate GetReset_ZHandler ()
		{
			if (cb_reset_Z == null)
				cb_reset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Reset_Z);
			return cb_reset_Z;
		}

		static void n_Reset_Z (IntPtr jnienv, IntPtr native__this, bool headerData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.StreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset (headerData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reset", "(Z)V", "GetReset_ZHandler")]
		protected virtual unsafe void Reset (bool headerData)
		{
			const string __id = "reset.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (headerData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/StreamReader", DoNotGenerateAcw=true)]
	internal partial class StreamReaderInvoker : StreamReader {
		public StreamReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/StreamReader", typeof (StreamReaderInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='StreamReader']/method[@name='preparePayload' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("preparePayload", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)J", "GetPreparePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler")]
		protected override unsafe long PreparePayload (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0)
		{
			const string __id = "preparePayload.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
