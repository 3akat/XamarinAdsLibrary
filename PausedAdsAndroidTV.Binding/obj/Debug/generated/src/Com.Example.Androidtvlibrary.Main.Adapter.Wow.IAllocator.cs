using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']"
	[Register ("com/example/androidtvlibrary/main/adapter/wow/Allocator", "", "Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker")]
	public partial interface IAllocator : IJavaObject, IJavaPeerable {
		int IndividualAllocationLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']/method[@name='getIndividualAllocationLength' and count(parameter)=0]"
			[Register ("getIndividualAllocationLength", "()I", "GetGetIndividualAllocationLengthHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		int TotalBytesAllocated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']/method[@name='getTotalBytesAllocated' and count(parameter)=0]"
			[Register ("getTotalBytesAllocated", "()I", "GetGetTotalBytesAllocatedHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker, PausedAdsAndroidTV.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']/method[@name='allocate' and count(parameter)=0]"
		[Register ("allocate", "()Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;", "GetAllocateHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker, PausedAdsAndroidTV.Binding")]
		global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation Allocate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Allocation']]"
		[Register ("release", "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V", "GetRelease_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker, PausedAdsAndroidTV.Binding")]
		void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Allocation[]']]"
		[Register ("release", "([Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V", "GetRelease_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_Handler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker, PausedAdsAndroidTV.Binding")]
		void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/interface[@name='Allocator']/method[@name='trim' and count(parameter)=0]"
		[Register ("trim", "()V", "GetTrimHandler:Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocatorInvoker, PausedAdsAndroidTV.Binding")]
		void Trim ();

	}

	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/Allocator", DoNotGenerateAcw=true)]
	internal partial class IAllocatorInvoker : global::Java.Lang.Object, IAllocator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/Allocator", typeof (IAllocatorInvoker));

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

		public static IAllocator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAllocator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.wow.Allocator'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAllocatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIndividualAllocationLength;
#pragma warning disable 0169
		static Delegate GetGetIndividualAllocationLengthHandler ()
		{
			if (cb_getIndividualAllocationLength == null)
				cb_getIndividualAllocationLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndividualAllocationLength);
			return cb_getIndividualAllocationLength;
		}

		static int n_GetIndividualAllocationLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndividualAllocationLength;
		}
#pragma warning restore 0169

		IntPtr id_getIndividualAllocationLength;
		public unsafe int IndividualAllocationLength {
			get {
				if (id_getIndividualAllocationLength == IntPtr.Zero)
					id_getIndividualAllocationLength = JNIEnv.GetMethodID (class_ref, "getIndividualAllocationLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndividualAllocationLength);
			}
		}

		static Delegate cb_getTotalBytesAllocated;
#pragma warning disable 0169
		static Delegate GetGetTotalBytesAllocatedHandler ()
		{
			if (cb_getTotalBytesAllocated == null)
				cb_getTotalBytesAllocated = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTotalBytesAllocated);
			return cb_getTotalBytesAllocated;
		}

		static int n_GetTotalBytesAllocated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalBytesAllocated;
		}
#pragma warning restore 0169

		IntPtr id_getTotalBytesAllocated;
		public unsafe int TotalBytesAllocated {
			get {
				if (id_getTotalBytesAllocated == IntPtr.Zero)
					id_getTotalBytesAllocated = JNIEnv.GetMethodID (class_ref, "getTotalBytesAllocated", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalBytesAllocated);
			}
		}

		static Delegate cb_allocate;
#pragma warning disable 0169
		static Delegate GetAllocateHandler ()
		{
			if (cb_allocate == null)
				cb_allocate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Allocate);
			return cb_allocate;
		}

		static IntPtr n_Allocate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Allocate ());
		}
#pragma warning restore 0169

		IntPtr id_allocate;
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation Allocate ()
		{
			if (id_allocate == IntPtr.Zero)
				id_allocate = JNIEnv.GetMethodID (class_ref, "allocate", "()Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;");
			return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allocate), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_;
#pragma warning disable 0169
		static Delegate GetRelease_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_Handler ()
		{
			if (cb_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_ == null)
				cb_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_);
			return cb_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_;
		}

		static void n_Release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Release (p0);
		}
#pragma warning restore 0169

		IntPtr id_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_;
		public unsafe void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation p0)
		{
			if (id_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_ == IntPtr.Zero)
				id_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_ = JNIEnv.GetMethodID (class_ref, "release", "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_Lcom_example_androidtvlibrary_main_adapter_wow_Allocation_, __args);
		}

		static Delegate cb_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_;
#pragma warning disable 0169
		static Delegate GetRelease_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_Handler ()
		{
			if (cb_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_ == null)
				cb_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_);
			return cb_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_;
		}

		static void n_Release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation));
			__this.Release (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_;
		public unsafe void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation[] p0)
		{
			if (id_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_ == IntPtr.Zero)
				id_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_ = JNIEnv.GetMethodID (class_ref, "release", "([Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_arrayLcom_example_androidtvlibrary_main_adapter_wow_Allocation_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_trim;
#pragma warning disable 0169
		static Delegate GetTrimHandler ()
		{
			if (cb_trim == null)
				cb_trim = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Trim);
			return cb_trim;
		}

		static void n_Trim (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Trim ();
		}
#pragma warning restore 0169

		IntPtr id_trim;
		public unsafe void Trim ()
		{
			if (id_trim == IntPtr.Zero)
				id_trim = JNIEnv.GetMethodID (class_ref, "trim", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trim);
		}

	}
}
