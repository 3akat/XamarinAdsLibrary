using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/example/androidtvlibrary/main/adapter/drmsession",
						"com/example/androidtvlibrary/main/adapter/factory",
						"com/example/androidtvlibrary/main/adapter/Media/extractor",
						"com/example/androidtvlibrary/main/adapter/Media",
						"com/example/androidtvlibrary/main/adapter/mp3",
						"com/example/androidtvlibrary/main/adapter/player",
						"com/example/androidtvlibrary/main/adapter",
						"com/example/androidtvlibrary/main/adapter/wow",
					},
					new Converter<string, Type>[]{
						lookup_com_example_androidtvlibrary_main_adapter_drmsession_package,
						lookup_com_example_androidtvlibrary_main_adapter_factory_package,
						lookup_com_example_androidtvlibrary_main_adapter_Media_extractor_package,
						lookup_com_example_androidtvlibrary_main_adapter_Media_package,
						lookup_com_example_androidtvlibrary_main_adapter_mp3_package,
						lookup_com_example_androidtvlibrary_main_adapter_player_package,
						lookup_com_example_androidtvlibrary_main_adapter_package,
						lookup_com_example_androidtvlibrary_main_adapter_wow_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_drmsession_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_drmsession_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_drmsession_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_drmsession_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$AppManagedProvider:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmAppManagedProvider",
					"com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyRequest:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyRequest",
					"com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$KeyStatus:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmKeyStatus",
					"com/example/androidtvlibrary/main/adapter/drmsession/ExoMediaDrm$ProvisionRequest:Com.Example.Androidtvlibrary.Main.Adapter.Drmsession.ExoMediaDrmProvisionRequest",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_drmsession_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_factory_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_factory_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_factory_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_factory_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$BaseFactory:Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceBaseFactory",
					"com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$HttpDataSourceException:Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceHttpDataSourceException",
					"com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$InvalidContentTypeException:Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceInvalidContentTypeException",
					"com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$InvalidResponseCodeException:Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceInvalidResponseCodeException",
					"com/example/androidtvlibrary/main/adapter/factory/HttpDataSource$RequestProperties:Com.Example.Androidtvlibrary.Main.Adapter.Factory.HttpDataSourceRequestProperties",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_factory_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_Media_extractor_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_Media_extractor_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_Media_extractor_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_Media_extractor_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$DvbSubtitleInfo:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderDvbSubtitleInfo",
					"com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$EsInfo:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderEsInfo",
					"com/example/androidtvlibrary/main/adapter/Media/extractor/TsPayloadReader$TrackIdGenerator:Com.Example.Androidtvlibrary.Main.Adapter.Media.Extractor.TsPayloadReaderTrackIdGenerator",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_Media_extractor_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_Media_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_Media_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_Media_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_Media_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/Media/LoaderErrorThrower$Dummy:Com.Example.Androidtvlibrary.Main.Adapter.Media.LoaderErrorThrowerDummy",
					"com/example/androidtvlibrary/main/adapter/Media/SeekMap$SeekPoints:Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapSeekPoints",
					"com/example/androidtvlibrary/main/adapter/Media/SeekMap$Unseekable:Com.Example.Androidtvlibrary.Main.Adapter.Media.SeekMapUnseekable",
					"com/example/androidtvlibrary/main/adapter/Media/TrackOutput$CryptoData:Com.Example.Androidtvlibrary.Main.Adapter.Media.TrackOutputCryptoData",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_Media_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_mp3_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_mp3_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_mp3_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_mp3_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/mp3/Seeker$UnseekableSeeker:Com.Example.Androidtvlibrary.Main.Adapter.Mp3.SeekerUnseekableSeeker",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_mp3_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_player_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_player_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_player_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_player_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/player/AudioProcessor$AudioFormat:Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorAudioFormat",
					"com/example/androidtvlibrary/main/adapter/player/AudioProcessor$UnhandledAudioFormatException:Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioProcessorUnhandledAudioFormatException",
					"com/example/androidtvlibrary/main/adapter/player/AudioRendererEventListener$EventDispatcher:Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioRendererEventListenerEventDispatcher",
					"com/example/androidtvlibrary/main/adapter/player/AudioSink$ConfigurationException:Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioSinkConfigurationException",
					"com/example/androidtvlibrary/main/adapter/player/AudioSink$InitializationException:Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioSinkInitializationException",
					"com/example/androidtvlibrary/main/adapter/player/AudioSink$WriteException:Com.Example.Androidtvlibrary.Main.Adapter.Player.AudioSinkWriteException",
					"com/example/androidtvlibrary/main/adapter/player/VideoRendererEventListener$EventDispatcher:Com.Example.Androidtvlibrary.Main.Adapter.Player.VideoRendererEventListenerEventDispatcher",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_player_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/TestPlayer$DefaultEventListener:Com.Example.Androidtvlibrary.Main.Adapter.TestPlayerDefaultEventListener",
					"com/example/androidtvlibrary/main/adapter/TrackSelection$Definition:Com.Example.Androidtvlibrary.Main.Adapter.TrackSelectionDefinition",
					"com/example/androidtvlibrary/main/adapter/WowPlayer$Builder:Com.Example.Androidtvlibrary.Main.Adapter.WowPlayerBuilder",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_mappings, klass);
		}

		static string[] package_com_example_androidtvlibrary_main_adapter_wow_mappings;
		static Type lookup_com_example_androidtvlibrary_main_adapter_wow_package (string klass)
		{
			if (package_com_example_androidtvlibrary_main_adapter_wow_mappings == null) {
				package_com_example_androidtvlibrary_main_adapter_wow_mappings = new string[]{
					"com/example/androidtvlibrary/main/adapter/wow/DrmSession$DrmSessionException:Com.Example.Androidtvlibrary.Main.Adapter.Wow.DrmSessionDrmSessionException",
					"com/example/androidtvlibrary/main/adapter/wow/MediaSource$MediaPeriodId:Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceMediaPeriodId",
					"com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$EventDispatcher:Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerEventDispatcher",
					"com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$LoadEventInfo:Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerLoadEventInfo",
					"com/example/androidtvlibrary/main/adapter/wow/MediaSourceEventListener$MediaLoadData:Com.Example.Androidtvlibrary.Main.Adapter.Wow.MediaSourceEventListenerMediaLoadData",
				};
			}

			return Lookup (package_com_example_androidtvlibrary_main_adapter_wow_mappings, klass);
		}
	}
}