using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultAllocator", DoNotGenerateAcw=true)]
	public sealed partial class DefaultAllocator : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultAllocator", typeof (DefaultAllocator));

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

		internal DefaultAllocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/constructor[@name='DefaultAllocator' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register (".ctor", "(ZI)V", "")]
		public unsafe DefaultAllocator (bool trimOnReset, int individualAllocationSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (trimOnReset);
				__args [1] = new JniArgumentValue (individualAllocationSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/constructor[@name='DefaultAllocator' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ZII)V", "")]
		public unsafe DefaultAllocator (bool trimOnReset, int individualAllocationSize, int initialAllocationCount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (trimOnReset);
				__args [1] = new JniArgumentValue (individualAllocationSize);
				__args [2] = new JniArgumentValue (initialAllocationCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int IndividualAllocationLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='getIndividualAllocationLength' and count(parameter)=0]"
			[Register ("getIndividualAllocationLength", "()I", "")]
			get {
				const string __id = "getIndividualAllocationLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TotalBytesAllocated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='getTotalBytesAllocated' and count(parameter)=0]"
			[Register ("getTotalBytesAllocated", "()I", "")]
			get {
				const string __id = "getTotalBytesAllocated.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='allocate' and count(parameter)=0]"
		[Register ("allocate", "()Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation Allocate ()
		{
			const string __id = "allocate.()Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Allocation']]"
		[Register ("release", "(Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V", "")]
		public unsafe void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation allocation)
		{
			const string __id = "release.(Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((allocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocation).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (allocation);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Allocation[]']]"
		[Register ("release", "([Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V", "")]
		public unsafe void Release (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.Allocation[] allocations)
		{
			const string __id = "release.([Lcom/example/androidtvlibrary/main/adapter/wow/Allocation;)V";
			IntPtr native_allocations = JNIEnv.NewArray (allocations);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_allocations);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (allocations != null) {
					JNIEnv.CopyArray (native_allocations, allocations);
					JNIEnv.DeleteLocalRef (native_allocations);
				}
				global::System.GC.KeepAlive (allocations);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='setTargetBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTargetBufferSize", "(I)V", "")]
		public unsafe void SetTargetBufferSize (int targetBufferSize)
		{
			const string __id = "setTargetBufferSize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (targetBufferSize);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultAllocator']/method[@name='trim' and count(parameter)=0]"
		[Register ("trim", "()V", "")]
		public unsafe void Trim ()
		{
			const string __id = "trim.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
