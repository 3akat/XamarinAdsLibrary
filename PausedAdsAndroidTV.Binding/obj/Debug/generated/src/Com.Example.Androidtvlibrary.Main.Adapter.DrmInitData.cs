using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DrmInitData", DoNotGenerateAcw=true)]
	public sealed partial class DrmInitData : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Java.Util.IComparator {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/field[@name='schemeDataCount']"
		[Register ("schemeDataCount")]
		public int SchemeDataCount {
			get {
				const string __id = "schemeDataCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "schemeDataCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/field[@name='schemeType']"
		[Register ("schemeType")]
		public string SchemeType {
			get {
				const string __id = "schemeType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "schemeType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData", DoNotGenerateAcw=true)]
		public sealed partial class SchemeData : global::Java.Lang.Object, global::Android.OS.IParcelable {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/field[@name='data']"
			[Register ("data")]
			public IList<byte> Data {
				get {
					const string __id = "data.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "data.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/field[@name='licenseServerUrl']"
			[Register ("licenseServerUrl")]
			public string LicenseServerUrl {
				get {
					const string __id = "licenseServerUrl.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "licenseServerUrl.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/field[@name='mimeType']"
			[Register ("mimeType")]
			public string MimeType {
				get {
					const string __id = "mimeType.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mimeType.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData", typeof (SchemeData));

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

			internal SchemeData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/constructor[@name='DrmInitData.SchemeData' and count(parameter)=3 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
			[Register (".ctor", "(Ljava/util/UUID;Ljava/lang/String;[B)V", "")]
			public unsafe SchemeData (global::Java.Util.UUID uuid, string mimeType, byte[] data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/UUID;Ljava/lang/String;[B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_mimeType = JNIEnv.NewString (mimeType);
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
					__args [1] = new JniArgumentValue (native_mimeType);
					__args [2] = new JniArgumentValue (native_data);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_mimeType);
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (uuid);
					global::System.GC.KeepAlive (data);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/constructor[@name='DrmInitData.SchemeData' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]']]"
			[Register (".ctor", "(Ljava/util/UUID;Ljava/lang/String;Ljava/lang/String;[B)V", "")]
			public unsafe SchemeData (global::Java.Util.UUID uuid, string licenseServerUrl, string mimeType, byte[] data) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/UUID;Ljava/lang/String;Ljava/lang/String;[B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_licenseServerUrl = JNIEnv.NewString (licenseServerUrl);
				IntPtr native_mimeType = JNIEnv.NewString (mimeType);
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
					__args [1] = new JniArgumentValue (native_licenseServerUrl);
					__args [2] = new JniArgumentValue (native_mimeType);
					__args [3] = new JniArgumentValue (native_data);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_licenseServerUrl);
					JNIEnv.DeleteLocalRef (native_mimeType);
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (uuid);
					global::System.GC.KeepAlive (data);
				}
			}

			public unsafe bool HasData {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/method[@name='hasData' and count(parameter)=0]"
				[Register ("hasData", "()Z", "")]
				get {
					const string __id = "hasData.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/method[@name='canReplace' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData']]"
			[Register ("canReplace", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)Z", "")]
			public unsafe bool CanReplace (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData other)
			{
				const string __id = "canReplace.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (other);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/method[@name='copyWithData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("copyWithData", "([B)Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData CopyWithData (byte[] data)
			{
				const string __id = "copyWithData.([B)Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;";
				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_data);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
					global::System.GC.KeepAlive (data);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/method[@name='describeContents' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
			[Register ("matches", "(Ljava/util/UUID;)Z", "")]
			public unsafe bool Matches (global::Java.Util.UUID schemeUuid)
			{
				const string __id = "matches.(Ljava/util/UUID;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((schemeUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) schemeUuid).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (schemeUuid);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData.SchemeData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/DrmInitData", typeof (DrmInitData));

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

		internal DrmInitData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/constructor[@name='DrmInitData' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData...']]"
		[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)V", "")]
		public unsafe DrmInitData (params global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData[] schemeDatas) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_schemeDatas = JNIEnv.NewArray (schemeDatas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_schemeDatas);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (schemeDatas != null) {
					JNIEnv.CopyArray (native_schemeDatas, schemeDatas);
					JNIEnv.DeleteLocalRef (native_schemeDatas);
				}
				global::System.GC.KeepAlive (schemeDatas);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/constructor[@name='DrmInitData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData...']]"
		[Register (".ctor", "(Ljava/lang/String;[Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)V", "")]
		public unsafe DrmInitData (string schemeType, params global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData[] schemeDatas) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_schemeType = JNIEnv.NewString (schemeType);
			IntPtr native_schemeDatas = JNIEnv.NewArray (schemeDatas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_schemeType);
				__args [1] = new JniArgumentValue (native_schemeDatas);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_schemeType);
				if (schemeDatas != null) {
					JNIEnv.CopyArray (native_schemeDatas, schemeDatas);
					JNIEnv.DeleteLocalRef (native_schemeDatas);
				}
				global::System.GC.KeepAlive (schemeDatas);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/constructor[@name='DrmInitData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe DrmInitData (string schemeType, global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> schemeDatas) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_schemeType = JNIEnv.NewString (schemeType);
			IntPtr native_schemeDatas = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData>.ToLocalJniHandle (schemeDatas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_schemeType);
				__args [1] = new JniArgumentValue (native_schemeDatas);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_schemeType);
				JNIEnv.DeleteLocalRef (native_schemeDatas);
				global::System.GC.KeepAlive (schemeDatas);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/constructor[@name='DrmInitData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe DrmInitData (global::System.Collections.Generic.IList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> schemeDatas) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_schemeDatas = global::Android.Runtime.JavaList<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData>.ToLocalJniHandle (schemeDatas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_schemeDatas);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_schemeDatas);
				global::System.GC.KeepAlive (schemeDatas);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DrmInitData.SchemeData']]"
		[Register ("compare", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)I", "")]
		public unsafe int Compare (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData first, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData second)
		{
			const string __id = "compare.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((second == null) ? IntPtr.Zero : ((global::Java.Lang.Object) second).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (first);
				global::System.GC.KeepAlive (second);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='copyWithSchemeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("copyWithSchemeType", "(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData CopyWithSchemeType (string schemeType)
		{
			const string __id = "copyWithSchemeType.(Ljava/lang/String;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData;";
			IntPtr native_schemeType = JNIEnv.NewString (schemeType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_schemeType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_schemeType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='createSessionCreationData' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("createSessionCreationData", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData CreateSessionCreationData (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData manifestData, global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData mediaData)
		{
			const string __id = "createSessionCreationData.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((manifestData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manifestData).Handle);
				__args [1] = new JniArgumentValue ((mediaData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (manifestData);
				global::System.GC.KeepAlive (mediaData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData Get (int index)
		{
			const string __id = "get.(I)Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Obsolete (@"deprecated")]
		[Register ("get", "(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData Get (global::Java.Util.UUID uuid)
		{
			const string __id = "get.(Ljava/util/UUID;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData$SchemeData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuid).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData.SchemeData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='merge' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DrmInitData']]"
		[Register ("merge", "(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData;", "")]
		public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData Merge (global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData drmInitData)
		{
			const string __id = "merge.(Lcom/example/androidtvlibrary/main/adapter/DrmInitData;)Lcom/example/androidtvlibrary/main/adapter/DrmInitData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drmInitData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drmInitData).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.DrmInitData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drmInitData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='DrmInitData']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "compare.(Ljava/lang/Object;Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
