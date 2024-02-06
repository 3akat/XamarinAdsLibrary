using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Wow {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl", DoNotGenerateAcw=true)]
	public partial class DefaultLoadControl : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.ILoadControl {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_AUDIO_BUFFER_SIZE']"
		[Register ("DEFAULT_AUDIO_BUFFER_SIZE")]
		public const int DefaultAudioBufferSize = (int) 3538944;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_BACK_BUFFER_DURATION_MS']"
		[Register ("DEFAULT_BACK_BUFFER_DURATION_MS")]
		public const int DefaultBackBufferDurationMs = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_BUFFER_FOR_PLAYBACK_AFTER_REBUFFER_MS']"
		[Register ("DEFAULT_BUFFER_FOR_PLAYBACK_AFTER_REBUFFER_MS")]
		public const int DefaultBufferForPlaybackAfterRebufferMs = (int) 5000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_BUFFER_FOR_PLAYBACK_MS']"
		[Register ("DEFAULT_BUFFER_FOR_PLAYBACK_MS")]
		public const int DefaultBufferForPlaybackMs = (int) 2500;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_CAMERA_MOTION_BUFFER_SIZE']"
		[Register ("DEFAULT_CAMERA_MOTION_BUFFER_SIZE")]
		public const int DefaultCameraMotionBufferSize = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_MAX_BUFFER_MS']"
		[Register ("DEFAULT_MAX_BUFFER_MS")]
		public const int DefaultMaxBufferMs = (int) 50000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_METADATA_BUFFER_SIZE']"
		[Register ("DEFAULT_METADATA_BUFFER_SIZE")]
		public const int DefaultMetadataBufferSize = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_MIN_BUFFER_MS']"
		[Register ("DEFAULT_MIN_BUFFER_MS")]
		public const int DefaultMinBufferMs = (int) 15000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_MUXED_BUFFER_SIZE']"
		[Register ("DEFAULT_MUXED_BUFFER_SIZE")]
		public const int DefaultMuxedBufferSize = (int) 36438016;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_PRIORITIZE_TIME_OVER_SIZE_THRESHOLDS']"
		[Register ("DEFAULT_PRIORITIZE_TIME_OVER_SIZE_THRESHOLDS")]
		public const bool DefaultPrioritizeTimeOverSizeThresholds = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_RETAIN_BACK_BUFFER_FROM_KEYFRAME']"
		[Register ("DEFAULT_RETAIN_BACK_BUFFER_FROM_KEYFRAME")]
		public const bool DefaultRetainBackBufferFromKeyframe = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_TARGET_BUFFER_BYTES']"
		[Register ("DEFAULT_TARGET_BUFFER_BYTES")]
		public const int DefaultTargetBufferBytes = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_TEXT_BUFFER_SIZE']"
		[Register ("DEFAULT_TEXT_BUFFER_SIZE")]
		public const int DefaultTextBufferSize = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/field[@name='DEFAULT_VIDEO_BUFFER_SIZE']"
		[Register ("DEFAULT_VIDEO_BUFFER_SIZE")]
		public const int DefaultVideoBufferSize = (int) 32768000;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/constructor[@name='DefaultLoadControl.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/method[@name='createDefaultLoadControl' and count(parameter)=0]"
			[Register ("createDefaultLoadControl", "()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl CreateDefaultLoadControl ()
			{
				const string __id = "createDefaultLoadControl.()Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/method[@name='setAllocator' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultAllocator']]"
			[Register ("setAllocator", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder SetAllocator (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultAllocator allocator)
			{
				const string __id = "setAllocator.(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (allocator);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/method[@name='setBackBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("setBackBuffer", "(IZ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder SetBackBuffer (int backBufferDurationMs, bool retainBackBufferFromKeyframe)
			{
				const string __id = "setBackBuffer.(IZ)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (backBufferDurationMs);
					__args [1] = new JniArgumentValue (retainBackBufferFromKeyframe);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/method[@name='setBufferDurationsMs' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("setBufferDurationsMs", "(IIII)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder SetBufferDurationsMs (int minBufferMs, int maxBufferMs, int bufferForPlaybackMs, int bufferForPlaybackAfterRebufferMs)
			{
				const string __id = "setBufferDurationsMs.(IIII)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (minBufferMs);
					__args [1] = new JniArgumentValue (maxBufferMs);
					__args [2] = new JniArgumentValue (bufferForPlaybackMs);
					__args [3] = new JniArgumentValue (bufferForPlaybackAfterRebufferMs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/method[@name='setPrioritizeTimeOverSizeThresholds' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrioritizeTimeOverSizeThresholds", "(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder SetPrioritizeTimeOverSizeThresholds (bool prioritizeTimeOverSizeThresholds)
			{
				const string __id = "setPrioritizeTimeOverSizeThresholds.(Z)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (prioritizeTimeOverSizeThresholds);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl.Builder']/method[@name='setTargetBufferBytes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTargetBufferBytes", "(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder SetTargetBufferBytes (int targetBufferBytes)
			{
				const string __id = "setTargetBufferBytes.(I)Lcom/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (targetBufferBytes);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/wow/DefaultLoadControl", typeof (DefaultLoadControl));

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

		protected DefaultLoadControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/constructor[@name='DefaultLoadControl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultLoadControl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/constructor[@name='DefaultLoadControl' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultAllocator']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultLoadControl (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultAllocator allocator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/constructor[@name='DefaultLoadControl' and count(parameter)=7 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultAllocator'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;IIIIIZ)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DefaultLoadControl (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultAllocator allocator, int minBufferMs, int maxBufferMs, int bufferForPlaybackMs, int bufferForPlaybackAfterRebufferMs, int targetBufferBytes, bool prioritizeTimeOverSizeThresholds) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;IIIIIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				__args [1] = new JniArgumentValue (minBufferMs);
				__args [2] = new JniArgumentValue (maxBufferMs);
				__args [3] = new JniArgumentValue (bufferForPlaybackMs);
				__args [4] = new JniArgumentValue (bufferForPlaybackAfterRebufferMs);
				__args [5] = new JniArgumentValue (targetBufferBytes);
				__args [6] = new JniArgumentValue (prioritizeTimeOverSizeThresholds);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (allocator);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/constructor[@name='DefaultLoadControl' and count(parameter)=10 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.DefaultAllocator'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='boolean'] and parameter[9][@type='int'] and parameter[10][@type='boolean']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;IIIIIIZIZ)V", "")]
		protected unsafe DefaultLoadControl (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultAllocator allocator, int minBufferAudioMs, int minBufferVideoMs, int maxBufferMs, int bufferForPlaybackMs, int bufferForPlaybackAfterRebufferMs, int targetBufferBytes, bool prioritizeTimeOverSizeThresholds, int backBufferDurationMs, bool retainBackBufferFromKeyframe) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/wow/DefaultAllocator;IIIIIIZIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((allocator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocator).Handle);
				__args [1] = new JniArgumentValue (minBufferAudioMs);
				__args [2] = new JniArgumentValue (minBufferVideoMs);
				__args [3] = new JniArgumentValue (maxBufferMs);
				__args [4] = new JniArgumentValue (bufferForPlaybackMs);
				__args [5] = new JniArgumentValue (bufferForPlaybackAfterRebufferMs);
				__args [6] = new JniArgumentValue (targetBufferBytes);
				__args [7] = new JniArgumentValue (prioritizeTimeOverSizeThresholds);
				__args [8] = new JniArgumentValue (backBufferDurationMs);
				__args [9] = new JniArgumentValue (retainBackBufferFromKeyframe);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (allocator);
			}
		}

		static Delegate cb_getAllocator;
#pragma warning disable 0169
		static Delegate GetGetAllocatorHandler ()
		{
			if (cb_getAllocator == null)
				cb_getAllocator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllocator);
			return cb_getAllocator;
		}

		static IntPtr n_GetAllocator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Allocator);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator Allocator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='getAllocator' and count(parameter)=0]"
			[Register ("getAllocator", "()Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;", "GetGetAllocatorHandler")]
			get {
				const string __id = "getAllocator.()Lcom/example/androidtvlibrary/main/adapter/wow/Allocator;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IAllocator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBackBufferDurationUs;
#pragma warning disable 0169
		static Delegate GetGetBackBufferDurationUsHandler ()
		{
			if (cb_getBackBufferDurationUs == null)
				cb_getBackBufferDurationUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBackBufferDurationUs);
			return cb_getBackBufferDurationUs;
		}

		static long n_GetBackBufferDurationUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackBufferDurationUs;
		}
#pragma warning restore 0169

		public virtual unsafe long BackBufferDurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='getBackBufferDurationUs' and count(parameter)=0]"
			[Register ("getBackBufferDurationUs", "()J", "GetGetBackBufferDurationUsHandler")]
			get {
				const string __id = "getBackBufferDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_calculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
#pragma warning disable 0169
		static Delegate GetCalculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_Handler ()
		{
			if (cb_calculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ == null)
				cb_calculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_CalculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_);
			return cb_calculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
		}

		static int n_CalculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renderers, IntPtr native_trackSelectionArray)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var renderers = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[]) JNIEnv.GetArray (native_renderers, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer));
			var trackSelectionArray = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray> (native_trackSelectionArray, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CalculateTargetBufferSize (renderers, trackSelectionArray);
			if (renderers != null)
				JNIEnv.CopyArray (renderers, native_renderers);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='calculateTargetBufferSize' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackSelectionArray']]"
		[Register ("calculateTargetBufferSize", "([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;)I", "GetCalculateTargetBufferSize_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_Handler")]
		protected virtual unsafe int CalculateTargetBufferSize (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] renderers, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray trackSelectionArray)
		{
			const string __id = "calculateTargetBufferSize.([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;)I";
			IntPtr native_renderers = JNIEnv.NewArray (renderers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_renderers);
				__args [1] = new JniArgumentValue ((trackSelectionArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelectionArray).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (renderers != null) {
					JNIEnv.CopyArray (native_renderers, renderers);
					JNIEnv.DeleteLocalRef (native_renderers);
				}
				global::System.GC.KeepAlive (renderers);
				global::System.GC.KeepAlive (trackSelectionArray);
			}
		}

		static Delegate cb_onPrepared;
#pragma warning disable 0169
		static Delegate GetOnPreparedHandler ()
		{
			if (cb_onPrepared == null)
				cb_onPrepared = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPrepared);
			return cb_onPrepared;
		}

		static void n_OnPrepared (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='onPrepared' and count(parameter)=0]"
		[Register ("onPrepared", "()V", "GetOnPreparedHandler")]
		public virtual unsafe void OnPrepared ()
		{
			const string __id = "onPrepared.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onReleased;
#pragma warning disable 0169
		static Delegate GetOnReleasedHandler ()
		{
			if (cb_onReleased == null)
				cb_onReleased = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReleased);
			return cb_onReleased;
		}

		static void n_OnReleased (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReleased ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='onReleased' and count(parameter)=0]"
		[Register ("onReleased", "()V", "GetOnReleasedHandler")]
		public virtual unsafe void OnReleased ()
		{
			const string __id = "onReleased.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStopped;
#pragma warning disable 0169
		static Delegate GetOnStoppedHandler ()
		{
			if (cb_onStopped == null)
				cb_onStopped = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStopped);
			return cb_onStopped;
		}

		static void n_OnStopped (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='onStopped' and count(parameter)=0]"
		[Register ("onStopped", "()V", "GetOnStoppedHandler")]
		public virtual unsafe void OnStopped ()
		{
			const string __id = "onStopped.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
#pragma warning disable 0169
		static Delegate GetOnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_Handler ()
		{
			if (cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ == null)
				cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_);
			return cb_onTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_;
		}

		static void n_OnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renderers, IntPtr native_trackGroups, IntPtr native_trackSelections)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var renderers = (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[]) JNIEnv.GetArray (native_renderers, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer));
			var trackGroups = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray> (native_trackGroups, JniHandleOwnership.DoNotTransfer);
			var trackSelections = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray> (native_trackSelections, JniHandleOwnership.DoNotTransfer);
			__this.OnTracksSelected (renderers, trackGroups, trackSelections);
			if (renderers != null)
				JNIEnv.CopyArray (renderers, native_renderers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='onTracksSelected' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.wow.Renderer[]'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.TrackGroupArray'] and parameter[3][@type='com.example.androidtvlibrary.main.adapter.TrackSelectionArray']]"
		[Register ("onTracksSelected", "([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;)V", "GetOnTracksSelected_arrayLcom_example_androidtvlibrary_main_adapter_wow_Renderer_Lcom_example_androidtvlibrary_main_adapter_TrackGroupArray_Lcom_example_androidtvlibrary_main_adapter_TrackSelectionArray_Handler")]
		public virtual unsafe void OnTracksSelected (global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.IRenderer[] renderers, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackGroupArray trackGroups, global::Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionArray trackSelections)
		{
			const string __id = "onTracksSelected.([Lcom/example/androidtvlibrary/main/adapter/wow/Renderer;Lcom/example/androidtvlibrary/main/adapter/TrackGroupArray;Lcom/example/androidtvlibrary/main/adapter/TrackSelectionArray;)V";
			IntPtr native_renderers = JNIEnv.NewArray (renderers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_renderers);
				__args [1] = new JniArgumentValue ((trackGroups == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackGroups).Handle);
				__args [2] = new JniArgumentValue ((trackSelections == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackSelections).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (renderers != null) {
					JNIEnv.CopyArray (native_renderers, renderers);
					JNIEnv.DeleteLocalRef (native_renderers);
				}
				global::System.GC.KeepAlive (renderers);
				global::System.GC.KeepAlive (trackGroups);
				global::System.GC.KeepAlive (trackSelections);
			}
		}

		static Delegate cb_retainBackBufferFromKeyframe;
#pragma warning disable 0169
		static Delegate GetRetainBackBufferFromKeyframeHandler ()
		{
			if (cb_retainBackBufferFromKeyframe == null)
				cb_retainBackBufferFromKeyframe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RetainBackBufferFromKeyframe);
			return cb_retainBackBufferFromKeyframe;
		}

		static bool n_RetainBackBufferFromKeyframe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetainBackBufferFromKeyframe ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='retainBackBufferFromKeyframe' and count(parameter)=0]"
		[Register ("retainBackBufferFromKeyframe", "()Z", "GetRetainBackBufferFromKeyframeHandler")]
		public virtual unsafe bool RetainBackBufferFromKeyframe ()
		{
			const string __id = "retainBackBufferFromKeyframe.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_shouldContinueLoading_JF;
#pragma warning disable 0169
		static Delegate GetShouldContinueLoading_JFHandler ()
		{
			if (cb_shouldContinueLoading_JF == null)
				cb_shouldContinueLoading_JF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJF_Z) n_ShouldContinueLoading_JF);
			return cb_shouldContinueLoading_JF;
		}

		static bool n_ShouldContinueLoading_JF (IntPtr jnienv, IntPtr native__this, long bufferedDurationUs, float playbackSpeed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldContinueLoading (bufferedDurationUs, playbackSpeed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='shouldContinueLoading' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
		[Register ("shouldContinueLoading", "(JF)Z", "GetShouldContinueLoading_JFHandler")]
		public virtual unsafe bool ShouldContinueLoading (long bufferedDurationUs, float playbackSpeed)
		{
			const string __id = "shouldContinueLoading.(JF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bufferedDurationUs);
				__args [1] = new JniArgumentValue (playbackSpeed);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_shouldStartPlayback_JFZ;
#pragma warning disable 0169
		static Delegate GetShouldStartPlayback_JFZHandler ()
		{
			if (cb_shouldStartPlayback_JFZ == null)
				cb_shouldStartPlayback_JFZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJFZ_Z) n_ShouldStartPlayback_JFZ);
			return cb_shouldStartPlayback_JFZ;
		}

		static bool n_ShouldStartPlayback_JFZ (IntPtr jnienv, IntPtr native__this, long bufferedDurationUs, float playbackSpeed, bool rebuffering)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.DefaultLoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldStartPlayback (bufferedDurationUs, playbackSpeed, rebuffering);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.wow']/class[@name='DefaultLoadControl']/method[@name='shouldStartPlayback' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("shouldStartPlayback", "(JFZ)Z", "GetShouldStartPlayback_JFZHandler")]
		public virtual unsafe bool ShouldStartPlayback (long bufferedDurationUs, float playbackSpeed, bool rebuffering)
		{
			const string __id = "shouldStartPlayback.(JFZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (bufferedDurationUs);
				__args [1] = new JniArgumentValue (playbackSpeed);
				__args [2] = new JniArgumentValue (rebuffering);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
