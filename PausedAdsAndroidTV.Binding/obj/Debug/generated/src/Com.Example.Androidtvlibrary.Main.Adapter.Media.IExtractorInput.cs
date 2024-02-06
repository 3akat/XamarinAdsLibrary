using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']"
	[Register ("com/example/androidtvlibrary/main/adapter/Media/ExtractorInput", "", "Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker")]
	public partial interface IExtractorInput : IJavaObject, IJavaPeerable {
		long Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()J", "GetGetLengthHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long PeekPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='getPeekPosition' and count(parameter)=0]"
			[Register ("getPeekPosition", "()J", "GetGetPeekPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		long Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()J", "GetGetPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("advancePeekPosition", "(I)V", "GetAdvancePeekPosition_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		void AdvancePeekPosition (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("advancePeekPosition", "(IZ)Z", "GetAdvancePeekPosition_IZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		bool AdvancePeekPosition (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='peek' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("peek", "([BII)I", "GetPeek_arrayBIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		int Peek (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='peekFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("peekFully", "([BII)V", "GetPeekFully_arrayBIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		void PeekFully (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='peekFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("peekFully", "([BIIZ)Z", "GetPeekFully_arrayBIIZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		bool PeekFully (byte[] p0, int p1, int p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		int Read (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='readFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readFully", "([BII)V", "GetReadFully_arrayBIIHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		void ReadFully (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("readFully", "([BIIZ)Z", "GetReadFully_arrayBIIZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		bool ReadFully (byte[] p0, int p1, int p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='resetPeekPosition' and count(parameter)=0]"
		[Register ("resetPeekPosition", "()V", "GetResetPeekPositionHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		void ResetPeekPosition ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='setRetryPosition' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='E']]"
		[Register ("setRetryPosition", "(JLjava/lang/Throwable;)V", "GetSetRetryPosition_JLjava_lang_Throwable_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		void SetRetryPosition (long p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)I", "GetSkip_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		int Skip (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='skipFully' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipFully", "(I)V", "GetSkipFully_IHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		void SkipFully (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/interface[@name='ExtractorInput']/method[@name='skipFully' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("skipFully", "(IZ)Z", "GetSkipFully_IZHandler:Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInputInvoker, PausedAdsAndroidTV.Binding")]
		bool SkipFully (int p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/ExtractorInput", DoNotGenerateAcw=true)]
	internal partial class IExtractorInputInvoker : global::Java.Lang.Object, IExtractorInput {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/ExtractorInput", typeof (IExtractorInputInvoker));

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

		public static IExtractorInput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExtractorInput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Media.ExtractorInput'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExtractorInputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLength);
			return cb_getLength;
		}

		static long n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		IntPtr id_getLength;
		public unsafe long Length {
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLength);
			}
		}

		static Delegate cb_getPeekPosition;
#pragma warning disable 0169
		static Delegate GetGetPeekPositionHandler ()
		{
			if (cb_getPeekPosition == null)
				cb_getPeekPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPeekPosition);
			return cb_getPeekPosition;
		}

		static long n_GetPeekPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeekPosition;
		}
#pragma warning restore 0169

		IntPtr id_getPeekPosition;
		public unsafe long PeekPosition {
			get {
				if (id_getPeekPosition == IntPtr.Zero)
					id_getPeekPosition = JNIEnv.GetMethodID (class_ref, "getPeekPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPeekPosition);
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPosition);
			return cb_getPosition;
		}

		static long n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		IntPtr id_getPosition;
		public unsafe long Position {
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
			}
		}

		static Delegate cb_advancePeekPosition_I;
#pragma warning disable 0169
		static Delegate GetAdvancePeekPosition_IHandler ()
		{
			if (cb_advancePeekPosition_I == null)
				cb_advancePeekPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_AdvancePeekPosition_I);
			return cb_advancePeekPosition_I;
		}

		static void n_AdvancePeekPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdvancePeekPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_advancePeekPosition_I;
		public unsafe void AdvancePeekPosition (int p0)
		{
			if (id_advancePeekPosition_I == IntPtr.Zero)
				id_advancePeekPosition_I = JNIEnv.GetMethodID (class_ref, "advancePeekPosition", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advancePeekPosition_I, __args);
		}

		static Delegate cb_advancePeekPosition_IZ;
#pragma warning disable 0169
		static Delegate GetAdvancePeekPosition_IZHandler ()
		{
			if (cb_advancePeekPosition_IZ == null)
				cb_advancePeekPosition_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_Z) n_AdvancePeekPosition_IZ);
			return cb_advancePeekPosition_IZ;
		}

		static bool n_AdvancePeekPosition_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdvancePeekPosition (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_advancePeekPosition_IZ;
		public unsafe bool AdvancePeekPosition (int p0, bool p1)
		{
			if (id_advancePeekPosition_IZ == IntPtr.Zero)
				id_advancePeekPosition_IZ = JNIEnv.GetMethodID (class_ref, "advancePeekPosition", "(IZ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_advancePeekPosition_IZ, __args);
		}

		static Delegate cb_peek_arrayBII;
#pragma warning disable 0169
		static Delegate GetPeek_arrayBIIHandler ()
		{
			if (cb_peek_arrayBII == null)
				cb_peek_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_Peek_arrayBII);
			return cb_peek_arrayBII;
		}

		static int n_Peek_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Peek (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_peek_arrayBII;
		public unsafe int Peek (byte[] p0, int p1, int p2)
		{
			if (id_peek_arrayBII == IntPtr.Zero)
				id_peek_arrayBII = JNIEnv.GetMethodID (class_ref, "peek", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_peek_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_peekFully_arrayBII;
#pragma warning disable 0169
		static Delegate GetPeekFully_arrayBIIHandler ()
		{
			if (cb_peekFully_arrayBII == null)
				cb_peekFully_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_PeekFully_arrayBII);
			return cb_peekFully_arrayBII;
		}

		static void n_PeekFully_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PeekFully (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_peekFully_arrayBII;
		public unsafe void PeekFully (byte[] p0, int p1, int p2)
		{
			if (id_peekFully_arrayBII == IntPtr.Zero)
				id_peekFully_arrayBII = JNIEnv.GetMethodID (class_ref, "peekFully", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_peekFully_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_peekFully_arrayBIIZ;
#pragma warning disable 0169
		static Delegate GetPeekFully_arrayBIIZHandler ()
		{
			if (cb_peekFully_arrayBIIZ == null)
				cb_peekFully_arrayBIIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_Z) n_PeekFully_arrayBIIZ);
			return cb_peekFully_arrayBIIZ;
		}

		static bool n_PeekFully_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PeekFully (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_peekFully_arrayBIIZ;
		public unsafe bool PeekFully (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_peekFully_arrayBIIZ == IntPtr.Zero)
				id_peekFully_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "peekFully", "([BIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_peekFully_arrayBIIZ, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBII;
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_readFully_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadFully_arrayBIIHandler ()
		{
			if (cb_readFully_arrayBII == null)
				cb_readFully_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_ReadFully_arrayBII);
			return cb_readFully_arrayBII;
		}

		static void n_ReadFully_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ReadFully (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_readFully_arrayBII;
		public unsafe void ReadFully (byte[] p0, int p1, int p2)
		{
			if (id_readFully_arrayBII == IntPtr.Zero)
				id_readFully_arrayBII = JNIEnv.GetMethodID (class_ref, "readFully", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_readFully_arrayBIIZ;
#pragma warning disable 0169
		static Delegate GetReadFully_arrayBIIZHandler ()
		{
			if (cb_readFully_arrayBIIZ == null)
				cb_readFully_arrayBIIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_Z) n_ReadFully_arrayBIIZ);
			return cb_readFully_arrayBIIZ;
		}

		static bool n_ReadFully_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ReadFully (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readFully_arrayBIIZ;
		public unsafe bool ReadFully (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_readFully_arrayBIIZ == IntPtr.Zero)
				id_readFully_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "readFully", "([BIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayBIIZ, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_resetPeekPosition;
#pragma warning disable 0169
		static Delegate GetResetPeekPositionHandler ()
		{
			if (cb_resetPeekPosition == null)
				cb_resetPeekPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetPeekPosition);
			return cb_resetPeekPosition;
		}

		static void n_ResetPeekPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetPeekPosition ();
		}
#pragma warning restore 0169

		IntPtr id_resetPeekPosition;
		public unsafe void ResetPeekPosition ()
		{
			if (id_resetPeekPosition == IntPtr.Zero)
				id_resetPeekPosition = JNIEnv.GetMethodID (class_ref, "resetPeekPosition", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetPeekPosition);
		}

		static Delegate cb_setRetryPosition_JLjava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetRetryPosition_JLjava_lang_Throwable_Handler ()
		{
			if (cb_setRetryPosition_JLjava_lang_Throwable_ == null)
				cb_setRetryPosition_JLjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_V) n_SetRetryPosition_JLjava_lang_Throwable_);
			return cb_setRetryPosition_JLjava_lang_Throwable_;
		}

		static void n_SetRetryPosition_JLjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRetryPosition (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setRetryPosition_JLjava_lang_Throwable_;
		public unsafe void SetRetryPosition (long p0, global::Java.Lang.Object p1)
		{
			if (id_setRetryPosition_JLjava_lang_Throwable_ == IntPtr.Zero)
				id_setRetryPosition_JLjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "setRetryPosition", "(JLjava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetryPosition_JLjava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_skip_I;
#pragma warning disable 0169
		static Delegate GetSkip_IHandler ()
		{
			if (cb_skip_I == null)
				cb_skip_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Skip_I);
			return cb_skip_I;
		}

		static int n_Skip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip (p0);
		}
#pragma warning restore 0169

		IntPtr id_skip_I;
		public unsafe int Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
		}

		static Delegate cb_skipFully_I;
#pragma warning disable 0169
		static Delegate GetSkipFully_IHandler ()
		{
			if (cb_skipFully_I == null)
				cb_skipFully_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SkipFully_I);
			return cb_skipFully_I;
		}

		static void n_SkipFully_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipFully (p0);
		}
#pragma warning restore 0169

		IntPtr id_skipFully_I;
		public unsafe void SkipFully (int p0)
		{
			if (id_skipFully_I == IntPtr.Zero)
				id_skipFully_I = JNIEnv.GetMethodID (class_ref, "skipFully", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipFully_I, __args);
		}

		static Delegate cb_skipFully_IZ;
#pragma warning disable 0169
		static Delegate GetSkipFully_IZHandler ()
		{
			if (cb_skipFully_IZ == null)
				cb_skipFully_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_Z) n_SkipFully_IZ);
			return cb_skipFully_IZ;
		}

		static bool n_SkipFully_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipFully (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_skipFully_IZ;
		public unsafe bool SkipFully (int p0, bool p1)
		{
			if (id_skipFully_IZ == IntPtr.Zero)
				id_skipFully_IZ = JNIEnv.GetMethodID (class_ref, "skipFully", "(IZ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_skipFully_IZ, __args);
		}

	}
}
