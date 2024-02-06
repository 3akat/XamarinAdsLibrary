using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/SampleDataQueue", DoNotGenerateAcw=true)]
	public partial class SampleDataQueue : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/SampleDataQueue", typeof (SampleDataQueue));

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

		protected SampleDataQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/constructor[@name='SampleDataQueue' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Allocator']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;)V", "")]
		public unsafe SampleDataQueue (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator allocator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (allocator);
			}
		}

		static Delegate cb_getTotalBytesWritten;
#pragma warning disable 0169
		static Delegate GetGetTotalBytesWrittenHandler ()
		{
			if (cb_getTotalBytesWritten == null)
				cb_getTotalBytesWritten = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTotalBytesWritten);
			return cb_getTotalBytesWritten;
		}

		static long n_GetTotalBytesWritten (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalBytesWritten;
		}
#pragma warning restore 0169

		public virtual unsafe long TotalBytesWritten {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='getTotalBytesWritten' and count(parameter)=0]"
			[Register ("getTotalBytesWritten", "()J", "GetGetTotalBytesWrittenHandler")]
			get {
				const string __id = "getTotalBytesWritten.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_discardDownstreamTo_J;
#pragma warning disable 0169
		static Delegate GetDiscardDownstreamTo_JHandler ()
		{
			if (cb_discardDownstreamTo_J == null)
				cb_discardDownstreamTo_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_DiscardDownstreamTo_J);
			return cb_discardDownstreamTo_J;
		}

		static void n_DiscardDownstreamTo_J (IntPtr jnienv, IntPtr native__this, long absolutePosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiscardDownstreamTo (absolutePosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='discardDownstreamTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("discardDownstreamTo", "(J)V", "GetDiscardDownstreamTo_JHandler")]
		public virtual unsafe void DiscardDownstreamTo (long absolutePosition)
		{
			const string __id = "discardDownstreamTo.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (absolutePosition);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_discardUpstreamSampleBytes_J;
#pragma warning disable 0169
		static Delegate GetDiscardUpstreamSampleBytes_JHandler ()
		{
			if (cb_discardUpstreamSampleBytes_J == null)
				cb_discardUpstreamSampleBytes_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_DiscardUpstreamSampleBytes_J);
			return cb_discardUpstreamSampleBytes_J;
		}

		static void n_DiscardUpstreamSampleBytes_J (IntPtr jnienv, IntPtr native__this, long totalBytesWritten)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiscardUpstreamSampleBytes (totalBytesWritten);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='discardUpstreamSampleBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("discardUpstreamSampleBytes", "(J)V", "GetDiscardUpstreamSampleBytes_JHandler")]
		public virtual unsafe void DiscardUpstreamSampleBytes (long totalBytesWritten)
		{
			const string __id = "discardUpstreamSampleBytes.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (totalBytesWritten);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_rewind;
#pragma warning disable 0169
		static Delegate GetRewindHandler ()
		{
			if (cb_rewind == null)
				cb_rewind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Rewind);
			return cb_rewind;
		}

		static void n_Rewind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rewind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='rewind' and count(parameter)=0]"
		[Register ("rewind", "()V", "GetRewindHandler")]
		public virtual unsafe void Rewind ()
		{
			const string __id = "rewind.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZHandler ()
		{
			if (cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ == null)
				cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZ_I) n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ);
			return cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ;
		}

		static int n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_input, int length, bool allowEndOfInput)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (native_input, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SampleData (input, length, allowEndOfInput);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I", "GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ExtractorInput_IZHandler")]
		public virtual unsafe int SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput input, int length, bool allowEndOfInput)
		{
			const string __id = "sampleData.(Lcom/example/androidtvlibrary/main/adapter/Media/ExtractorInput;IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue (length);
				__args [2] = new JniArgumentValue (allowEndOfInput);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
			}
		}

		static Delegate cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler ()
		{
			if (cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I == null)
				cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I);
			return cb_sampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I;
		}

		static void n_SampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.SampleDataQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buffer = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.SampleData (buffer, length);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='SampleDataQueue']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V", "GetSampleData_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_IHandler")]
		public virtual unsafe void SampleData (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray buffer, int length)
		{
			const string __id = "sampleData.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

	}
}
