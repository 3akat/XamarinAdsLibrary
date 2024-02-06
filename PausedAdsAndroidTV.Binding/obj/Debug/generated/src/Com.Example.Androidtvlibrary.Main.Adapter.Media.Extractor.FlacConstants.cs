using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacConstants", DoNotGenerateAcw=true)]
	public sealed partial class FlacConstants : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='MAX_FRAME_HEADER_SIZE']"
		[Register ("MAX_FRAME_HEADER_SIZE")]
		public const int MaxFrameHeaderSize = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='METADATA_BLOCK_HEADER_SIZE']"
		[Register ("METADATA_BLOCK_HEADER_SIZE")]
		public const int MetadataBlockHeaderSize = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='METADATA_TYPE_PICTURE']"
		[Register ("METADATA_TYPE_PICTURE")]
		public const int MetadataTypePicture = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='METADATA_TYPE_SEEK_TABLE']"
		[Register ("METADATA_TYPE_SEEK_TABLE")]
		public const int MetadataTypeSeekTable = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='METADATA_TYPE_STREAM_INFO']"
		[Register ("METADATA_TYPE_STREAM_INFO")]
		public const int MetadataTypeStreamInfo = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='METADATA_TYPE_VORBIS_COMMENT']"
		[Register ("METADATA_TYPE_VORBIS_COMMENT")]
		public const int MetadataTypeVorbisComment = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='MIN_FRAME_HEADER_SIZE']"
		[Register ("MIN_FRAME_HEADER_SIZE")]
		public const int MinFrameHeaderSize = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='STREAM_INFO_BLOCK_SIZE']"
		[Register ("STREAM_INFO_BLOCK_SIZE")]
		public const int StreamInfoBlockSize = (int) 38;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='FlacConstants']/field[@name='STREAM_MARKER_SIZE']"
		[Register ("STREAM_MARKER_SIZE")]
		public const int StreamMarkerSize = (int) 4;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/FlacConstants", typeof (FlacConstants));

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

		internal FlacConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
