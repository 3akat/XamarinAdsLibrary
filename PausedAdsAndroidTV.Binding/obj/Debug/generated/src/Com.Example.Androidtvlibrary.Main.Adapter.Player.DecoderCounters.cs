using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/DecoderCounters", DoNotGenerateAcw=true)]
	public sealed partial class DecoderCounters : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='decoderInitCount']"
		[Register ("decoderInitCount")]
		public int DecoderInitCount {
			get {
				const string __id = "decoderInitCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "decoderInitCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='decoderReleaseCount']"
		[Register ("decoderReleaseCount")]
		public int DecoderReleaseCount {
			get {
				const string __id = "decoderReleaseCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "decoderReleaseCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='droppedBufferCount']"
		[Register ("droppedBufferCount")]
		public int DroppedBufferCount {
			get {
				const string __id = "droppedBufferCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "droppedBufferCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='droppedToKeyframeCount']"
		[Register ("droppedToKeyframeCount")]
		public int DroppedToKeyframeCount {
			get {
				const string __id = "droppedToKeyframeCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "droppedToKeyframeCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='inputBufferCount']"
		[Register ("inputBufferCount")]
		public int InputBufferCount {
			get {
				const string __id = "inputBufferCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "inputBufferCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='maxConsecutiveDroppedBufferCount']"
		[Register ("maxConsecutiveDroppedBufferCount")]
		public int MaxConsecutiveDroppedBufferCount {
			get {
				const string __id = "maxConsecutiveDroppedBufferCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxConsecutiveDroppedBufferCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='renderedOutputBufferCount']"
		[Register ("renderedOutputBufferCount")]
		public int RenderedOutputBufferCount {
			get {
				const string __id = "renderedOutputBufferCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "renderedOutputBufferCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='skippedInputBufferCount']"
		[Register ("skippedInputBufferCount")]
		public int SkippedInputBufferCount {
			get {
				const string __id = "skippedInputBufferCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "skippedInputBufferCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/field[@name='skippedOutputBufferCount']"
		[Register ("skippedOutputBufferCount")]
		public int SkippedOutputBufferCount {
			get {
				const string __id = "skippedOutputBufferCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "skippedOutputBufferCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/DecoderCounters", typeof (DecoderCounters));

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

		internal DecoderCounters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/constructor[@name='DecoderCounters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DecoderCounters () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/method[@name='ensureUpdated' and count(parameter)=0]"
		[Register ("ensureUpdated", "()V", "")]
		public unsafe void EnsureUpdated ()
		{
			const string __id = "ensureUpdated.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='DecoderCounters']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.DecoderCounters']]"
		[Register ("merge", "(Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;)V", "")]
		public unsafe void Merge (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.DecoderCounters other)
		{
			const string __id = "merge.(Lcom/example/androidtvlibrary/main/adapter/player/DecoderCounters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

	}
}
