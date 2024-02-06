using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Media/extractor/WavUtil", DoNotGenerateAcw=true)]
	public sealed partial class WavUtil : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='DATA_FOURCC']"
		[Register ("DATA_FOURCC")]
		public const int DataFourcc = (int) 1684108385;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='FMT_FOURCC']"
		[Register ("FMT_FOURCC")]
		public const int FmtFourcc = (int) 1718449184;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='RIFF_FOURCC']"
		[Register ("RIFF_FOURCC")]
		public const int RiffFourcc = (int) 1380533830;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='TYPE_ALAW']"
		[Register ("TYPE_ALAW")]
		public const int TypeAlaw = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='TYPE_FLOAT']"
		[Register ("TYPE_FLOAT")]
		public const int TypeFloat = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='TYPE_IMA_ADPCM']"
		[Register ("TYPE_IMA_ADPCM")]
		public const int TypeImaAdpcm = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='TYPE_MLAW']"
		[Register ("TYPE_MLAW")]
		public const int TypeMlaw = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='TYPE_PCM']"
		[Register ("TYPE_PCM")]
		public const int TypePcm = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='TYPE_WAVE_FORMAT_EXTENSIBLE']"
		[Register ("TYPE_WAVE_FORMAT_EXTENSIBLE")]
		public const int TypeWaveFormatExtensible = (int) 65534;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/field[@name='WAVE_FOURCC']"
		[Register ("WAVE_FOURCC")]
		public const int WaveFourcc = (int) 1463899717;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Media/extractor/WavUtil", typeof (WavUtil));

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

		internal WavUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/method[@name='getPcmEncodingForType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPcmEncodingForType", "(II)I", "")]
		public static unsafe int GetPcmEncodingForType (int type, int bitsPerSample)
		{
			const string __id = "getPcmEncodingForType.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (bitsPerSample);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.Media.extractor']/class[@name='WavUtil']/method[@name='getTypeForPcmEncoding' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTypeForPcmEncoding", "(I)I", "")]
		public static unsafe int GetTypeForPcmEncoding ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", ""})]
		int pcmEncoding)
		{
			const string __id = "getTypeForPcmEncoding.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pcmEncoding);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
