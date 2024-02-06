using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory", DoNotGenerateAcw=true)]
	public sealed partial class DefaultExtractorsFactory : global::Java.Lang.Object, global::Com.Example.Androidtvlibrary.Main.Adapter.Mp3.IExtractorsFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory", typeof (DefaultExtractorsFactory));

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

		internal DefaultExtractorsFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/constructor[@name='DefaultExtractorsFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultExtractorsFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='createExtractors' and count(parameter)=0]"
		[Register ("createExtractors", "()[Lcom/example/androidtvlibrary/main/adapter/Media/Extractor;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1[] CreateExtractors ()
		{
			const string __id = "createExtractors.()[Lcom/example/androidtvlibrary/main/adapter/Media/Extractor;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor1));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setAdtsExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAdtsExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetAdtsExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.AdtsExtractor", Fields = new string [] {"FlagEnableConstantBitrateSeeking"})]
		int flags)
		{
			const string __id = "setAdtsExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setAmrExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAmrExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetAmrExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.AmrExtractor", Fields = new string [] {"FlagEnableConstantBitrateSeeking"})]
		int flags)
		{
			const string __id = "setAmrExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setConstantBitrateSeekingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setConstantBitrateSeekingEnabled", "(Z)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetConstantBitrateSeekingEnabled (bool constantBitrateSeekingEnabled)
		{
			const string __id = "setConstantBitrateSeekingEnabled.(Z)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (constantBitrateSeekingEnabled);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setFragmentedMp4ExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFragmentedMp4ExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetFragmentedMp4ExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.FragmentedMp4Extractor", Fields = new string [] {"FlagWorkaroundEveryVideoFrameIsSyncFrame", "FlagWorkaroundIgnoreTfdtBox", "FlagEnableEmsgTrack", "FlagWorkaroundIgnoreEditLists"})][global::Android.Runtime.IntDef (Flag = true, Type = "", Fields = new string [] {""})]
		int flags)
		{
			const string __id = "setFragmentedMp4ExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setMatroskaExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMatroskaExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetMatroskaExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.MatroskaExtractor", Fields = new string [] {"FlagDisableSeekForCues"})]
		int flags)
		{
			const string __id = "setMatroskaExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setMp3ExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMp3ExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetMp3ExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Mp3Extractor", Fields = new string [] {"FlagEnableConstantBitrateSeeking", "FlagDisableId3Metadata"})]
		int flags)
		{
			const string __id = "setMp3ExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setMp4ExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMp4ExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetMp4ExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.Mp4Extractor", Fields = new string [] {"FlagWorkaroundIgnoreEditLists"})]
		int flags)
		{
			const string __id = "setMp4ExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setTsExtractorFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTsExtractorFlags", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetTsExtractorFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.DefaultTsPayloadReaderFactory", Fields = new string [] {"FlagAllowNonIdrKeyframes", "FlagIgnoreAacStream", "FlagIgnoreH264Stream", "FlagDetectAccessUnits", "FlagIgnoreSpliceInfoStream", "FlagOverrideCaptionDescriptors", "FlagEnableHdmvDtsAudioStreams"})]
		int flags)
		{
			const string __id = "setTsExtractorFlags.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media']/class[@name='DefaultExtractorsFactory']/method[@name='setTsExtractorMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTsExtractorMode", "(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory SetTsExtractorMode ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsExtractor", Fields = new string [] {"ModeMultiPmt", "ModeSinglePmt", "ModeHls"})]
		int mode)
		{
			const string __id = "setTsExtractorMode.(I)Lcom/example/androidtvlibrary/main/adapter/Media/DefaultExtractorsFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Media.DefaultExtractorsFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
