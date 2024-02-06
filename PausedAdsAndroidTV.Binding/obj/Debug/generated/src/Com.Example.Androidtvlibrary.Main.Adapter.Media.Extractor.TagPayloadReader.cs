using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TagPayloadReader", DoNotGenerateAcw=true)]
	public abstract partial class TagPayloadReader : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/field[@name='output']"
		[Register ("output")]
		protected global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput Output {
			get {
				const string __id = "output.Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "output.Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader.UnsupportedFormatException']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TagPayloadReader$UnsupportedFormatException", DoNotGenerateAcw=true)]
		public sealed partial class UnsupportedFormatException : global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParserException {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TagPayloadReader$UnsupportedFormatException", typeof (UnsupportedFormatException));

			internal static new IntPtr class_ref {
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

			internal UnsupportedFormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader.UnsupportedFormatException']/constructor[@name='TagPayloadReader.UnsupportedFormatException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe UnsupportedFormatException (string msg) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_msg = JNIEnv.NewString (msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_msg);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_msg);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TagPayloadReader", typeof (TagPayloadReader));

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

		protected TagPayloadReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/constructor[@name='TagPayloadReader' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.TrackOutput']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V", "")]
		protected unsafe TagPayloadReader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ITrackOutput output) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/Media/TrackOutput;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (output);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='consume' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='long']]"
		[Register ("consume", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;J)Z", "")]
		public unsafe bool Consume (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray data, long timeUs)
		{
			const string __id = "consume.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (timeUs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_parseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
#pragma warning disable 0169
		static Delegate GetParseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler ()
		{
			if (cb_parseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ == null)
				cb_parseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ParseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_);
			return cb_parseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_;
		}

		static bool n_ParseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TagPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ParseHeader (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='parseHeader' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("parseHeader", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Z", "GetParseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler")]
		protected abstract bool ParseHeader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0);

		static Delegate cb_parsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_J;
#pragma warning disable 0169
		static Delegate GetParsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_JHandler ()
		{
			if (cb_parsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_J == null)
				cb_parsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_Z) n_ParsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_J);
			return cb_parsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_J;
		}

		static bool n_ParsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TagPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ParsePayload (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='parsePayload' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='long']]"
		[Register ("parsePayload", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;J)Z", "GetParsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_JHandler")]
		protected abstract bool ParsePayload (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0, long p1);

		static Delegate cb_seek;
#pragma warning disable 0169
		static Delegate GetSeekHandler ()
		{
			if (cb_seek == null)
				cb_seek = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Seek);
			return cb_seek;
		}

		static void n_Seek (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TagPayloadReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "GetSeekHandler")]
		public abstract void Seek ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/TagPayloadReader", DoNotGenerateAcw=true)]
	internal partial class TagPayloadReaderInvoker : TagPayloadReader {
		public TagPayloadReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/TagPayloadReader", typeof (TagPayloadReaderInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='parseHeader' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray']]"
		[Register ("parseHeader", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Z", "GetParseHeader_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_Handler")]
		protected override unsafe bool ParseHeader (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0)
		{
			const string __id = "parseHeader.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='parsePayload' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='long']]"
		[Register ("parsePayload", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;J)Z", "GetParsePayload_Lcom_example_androidtvlibrary_main_adapter_Media_ParsableByteArray_JHandler")]
		protected override unsafe bool ParsePayload (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray p0, long p1)
		{
			const string __id = "parsePayload.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='TagPayloadReader']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "GetSeekHandler")]
		public override unsafe void Seek ()
		{
			const string __id = "seek.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
