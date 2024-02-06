using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Metadata", DoNotGenerateAcw=true)]
	public sealed partial class Metadata : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/interface[@name='Metadata.Entry']"
		[Register ("com/example/androidtvlibrary/main/adapter/Metadata$Entry", "", "Com.Example.Androidtvlibrary.Main.Adapter.Metadata/IEntryInvoker")]
		public partial interface IEntry : global::Android.OS.IParcelable {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Metadata$Entry", DoNotGenerateAcw=true)]
		internal partial class IEntryInvoker : global::Java.Lang.Object, IEntry {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Metadata$Entry", typeof (IEntryInvoker));

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

			public static IEntry GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEntry> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.Metadata.Entry'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			IntPtr id_describeContents;
			public unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
				var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
				__this.WriteToParcel (dest, flags);
			}
#pragma warning restore 0169

			IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Metadata", typeof (Metadata));

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

		internal Metadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata.Entry...']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/Metadata$Entry;)V", "")]
		public unsafe Metadata (params global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry[] entries) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/Metadata$Entry;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_entries = JNIEnv.NewArray (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (entries != null) {
					JNIEnv.CopyArray (native_entries, entries);
					JNIEnv.DeleteLocalRef (native_entries);
				}
				global::System.GC.KeepAlive (entries);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.example.androidtvlibrary.main.adapter.Metadata.Entry&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe Metadata (global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry> entries) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_entries = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry>.ToLocalJniHandle (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entries);
				global::System.GC.KeepAlive (entries);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/method[@name='copyWithAppendedEntries' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata.Entry...']]"
		[Register ("copyWithAppendedEntries", "([Lcom/example/androidtvlibrary/main/adapter/Metadata$Entry;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata CopyWithAppendedEntries (params global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry[] entriesToAppend)
		{
			const string __id = "copyWithAppendedEntries.([Lcom/example/androidtvlibrary/main/adapter/Metadata$Entry;)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			IntPtr native_entriesToAppend = JNIEnv.NewArray (entriesToAppend);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entriesToAppend);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (entriesToAppend != null) {
					JNIEnv.CopyArray (native_entriesToAppend, entriesToAppend);
					JNIEnv.DeleteLocalRef (native_entriesToAppend);
				}
				global::System.GC.KeepAlive (entriesToAppend);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/method[@name='copyWithAppendedEntriesFrom' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Metadata']]"
		[Register ("copyWithAppendedEntriesFrom", "(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Metadata;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata CopyWithAppendedEntriesFrom (global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata other)
		{
			const string __id = "copyWithAppendedEntriesFrom.(Lcom/example/androidtvlibrary/main/adapter/Metadata;)Lcom/example/androidtvlibrary/main/adapter/Metadata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/example/androidtvlibrary/main/adapter/Metadata$Entry;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry Get (int index)
		{
			const string __id = "get.(I)Lcom/example/androidtvlibrary/main/adapter/Metadata$Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Metadata.IEntry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "")]
		public unsafe int Length ()
		{
			const string __id = "length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Metadata']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

	}
}
