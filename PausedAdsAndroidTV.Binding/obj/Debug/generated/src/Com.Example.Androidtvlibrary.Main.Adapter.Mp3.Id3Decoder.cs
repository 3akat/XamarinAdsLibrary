using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/Id3Decoder", DoNotGenerateAcw=true)]
	public sealed partial class Id3Decoder : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IMetadataDecoder {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/field[@name='ID3_HEADER_LENGTH']"
		[Register ("ID3_HEADER_LENGTH")]
		public const int Id3HeaderLength = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/field[@name='ID3_TAG']"
		[Register ("ID3_TAG")]
		public const int Id3Tag = (int) 4801587;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/field[@name='NO_FRAMES_PREDICATE']"
		[Register ("NO_FRAMES_PREDICATE")]
		public static global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder.IFramePredicate NoFramesPredicate {
			get {
				const string __id = "NO_FRAMES_PREDICATE.Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder.IFramePredicate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='Id3Decoder.FramePredicate']"
		[Register ("com/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate", "", "Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder/IFramePredicateInvoker")]
		public partial interface IFramePredicate : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/interface[@name='Id3Decoder.FramePredicate']/method[@name='evaluate' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("evaluate", "(IIIII)Z", "GetEvaluate_IIIIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder/IFramePredicateInvoker, PausedAdsAndroidTV.Binding")]
			bool Evaluate (int p0, int p1, int p2, int p3, int p4);

		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate", DoNotGenerateAcw=true)]
		internal partial class IFramePredicateInvoker : global::Java.Lang.Object, IFramePredicate {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate", typeof (IFramePredicateInvoker));

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

			public static IFramePredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFramePredicate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.mp3.Id3Decoder.FramePredicate'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFramePredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_evaluate_IIIII;
#pragma warning disable 0169
			static Delegate GetEvaluate_IIIIIHandler ()
			{
				if (cb_evaluate_IIIII == null)
					cb_evaluate_IIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIII_Z) n_Evaluate_IIIII);
				return cb_evaluate_IIIII;
			}

			static bool n_Evaluate_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder.IFramePredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Evaluate (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_evaluate_IIIII;
			public unsafe bool Evaluate (int p0, int p1, int p2, int p3, int p4)
			{
				if (id_evaluate_IIIII == IntPtr.Zero)
					id_evaluate_IIIII = JNIEnv.GetMethodID (class_ref, "evaluate", "(IIIII)Z");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_evaluate_IIIII, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/mp3/Id3Decoder", typeof (Id3Decoder));

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

		internal Id3Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/constructor[@name='Id3Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Id3Decoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/constructor[@name='Id3Decoder' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.mp3.Id3Decoder.FramePredicate']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate;)V", "")]
		public unsafe Id3Decoder (global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.Id3Decoder.IFramePredicate framePredicate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/mp3/Id3Decoder$FramePredicate;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((framePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framePredicate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (framePredicate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decode", "([BI)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata Decode (byte[] data, int size)
		{
			const string __id = "decode.([BI)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.mp3']/class[@name='Id3Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.mp3.MetadataInputBuffer']]"
		[Register ("decode", "(Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataInputBuffer;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata Decode (global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.MetadataInputBuffer inputBuffer)
		{
			const string __id = "decode.(Lcom/example/androidtvlibrary/main/adapter/mp3/MetadataInputBuffer;)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputBuffer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputBuffer);
			}
		}

	}
}
