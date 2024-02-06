using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/Projection", DoNotGenerateAcw=true)]
	public sealed partial class Projection : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='DRAW_MODE_TRIANGLES']"
		[Register ("DRAW_MODE_TRIANGLES")]
		public const int DrawModeTriangles = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='DRAW_MODE_TRIANGLES_FAN']"
		[Register ("DRAW_MODE_TRIANGLES_FAN")]
		public const int DrawModeTrianglesFan = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='DRAW_MODE_TRIANGLES_STRIP']"
		[Register ("DRAW_MODE_TRIANGLES_STRIP")]
		public const int DrawModeTrianglesStrip = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='leftMesh']"
		[Register ("leftMesh")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh LeftMesh {
			get {
				const string __id = "leftMesh.Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "leftMesh.Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='POSITION_COORDS_PER_VERTEX']"
		[Register ("POSITION_COORDS_PER_VERTEX")]
		public const int PositionCoordsPerVertex = (int) 3;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='rightMesh']"
		[Register ("rightMesh")]
		public global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh RightMesh {
			get {
				const string __id = "rightMesh.Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rightMesh.Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='singleMesh']"
		[Register ("singleMesh")]
		public bool SingleMesh {
			get {
				const string __id = "singleMesh.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "singleMesh.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='stereoMode']"
		[Register ("stereoMode")]
		public int StereoMode {
			get {
				const string __id = "stereoMode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stereoMode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/field[@name='TEXTURE_COORDS_PER_VERTEX']"
		[Register ("TEXTURE_COORDS_PER_VERTEX")]
		public const int TextureCoordsPerVertex = (int) 2;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/interface[@name='Projection.DrawMode']"
		[Register ("com/example/androidtvlibrary/main/adapter/player/Projection$DrawMode", "", "Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection/IDrawModeInvoker")]
		public partial interface IDrawMode : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/Projection$DrawMode", DoNotGenerateAcw=true)]
		internal partial class IDrawModeInvoker : global::Java.Lang.Object, IDrawMode {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/Projection$DrawMode", typeof (IDrawModeInvoker));

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

			public static IDrawMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDrawMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.example.androidtvlibrary.main.adapter.player.Projection.DrawMode'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDrawModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.IDrawMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.IDrawMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe bool Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.IDrawMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe int GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.IDrawMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.Mesh']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/Projection$Mesh", DoNotGenerateAcw=true)]
		public sealed partial class Mesh : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/Projection$Mesh", typeof (Mesh));

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

			internal Mesh (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.Mesh']/constructor[@name='Projection.Mesh' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.Projection.SubMesh...']]"
			[Register (".ctor", "([Lcom/example/androidtvlibrary/main/adapter/player/Projection$SubMesh;)V", "")]
			public unsafe Mesh (params global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.SubMesh[] subMeshes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([Lcom/example/androidtvlibrary/main/adapter/player/Projection$SubMesh;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_subMeshes = JNIEnv.NewArray (subMeshes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_subMeshes);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (subMeshes != null) {
						JNIEnv.CopyArray (native_subMeshes, subMeshes);
						JNIEnv.DeleteLocalRef (native_subMeshes);
					}
					global::System.GC.KeepAlive (subMeshes);
				}
			}

			public unsafe int SubMeshCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.Mesh']/method[@name='getSubMeshCount' and count(parameter)=0]"
				[Register ("getSubMeshCount", "()I", "")]
				get {
					const string __id = "getSubMeshCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.Mesh']/method[@name='getSubMesh' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getSubMesh", "(I)Lcom/example/androidtvlibrary/main/adapter/player/Projection$SubMesh;", "")]
			public unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.SubMesh GetSubMesh (int index)
			{
				const string __id = "getSubMesh.(I)Lcom/example/androidtvlibrary/main/adapter/player/Projection$SubMesh;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.SubMesh> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/Projection$SubMesh", DoNotGenerateAcw=true)]
		public sealed partial class SubMesh : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/field[@name='mode']"
			[Register ("mode")]
			public int Mode {
				get {
					const string __id = "mode.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "mode.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/field[@name='textureCoords']"
			[Register ("textureCoords")]
			public IList<float> TextureCoords {
				get {
					const string __id = "textureCoords.[F";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "textureCoords.[F";

					IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/field[@name='textureId']"
			[Register ("textureId")]
			public int TextureId {
				get {
					const string __id = "textureId.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "textureId.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/field[@name='vertices']"
			[Register ("vertices")]
			public IList<float> Vertices {
				get {
					const string __id = "vertices.[F";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "vertices.[F";

					IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/field[@name='VIDEO_TEXTURE_ID']"
			[Register ("VIDEO_TEXTURE_ID")]
			public const int VideoTextureId = (int) 0;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/Projection$SubMesh", typeof (SubMesh));

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

			internal SubMesh (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/constructor[@name='Projection.SubMesh' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
			[Register (".ctor", "(I[F[FI)V", "")]
			public unsafe SubMesh (int textureId, float[] vertices, float[] textureCoords, int mode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I[F[FI)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_vertices = JNIEnv.NewArray (vertices);
				IntPtr native_textureCoords = JNIEnv.NewArray (textureCoords);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (textureId);
					__args [1] = new JniArgumentValue (native_vertices);
					__args [2] = new JniArgumentValue (native_textureCoords);
					__args [3] = new JniArgumentValue (mode);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (vertices != null) {
						JNIEnv.CopyArray (native_vertices, vertices);
						JNIEnv.DeleteLocalRef (native_vertices);
					}
					if (textureCoords != null) {
						JNIEnv.CopyArray (native_textureCoords, textureCoords);
						JNIEnv.DeleteLocalRef (native_textureCoords);
					}
					global::System.GC.KeepAlive (vertices);
					global::System.GC.KeepAlive (textureCoords);
				}
			}

			public unsafe int VertexCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection.SubMesh']/method[@name='getVertexCount' and count(parameter)=0]"
				[Register ("getVertexCount", "()I", "")]
				get {
					const string __id = "getVertexCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/Projection", typeof (Projection));

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

		internal Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/constructor[@name='Projection' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.Projection.Mesh'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.player.Projection.Mesh'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;I)V", "")]
		public unsafe Projection (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh leftMesh, global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh rightMesh, int stereoMode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((leftMesh == null) ? IntPtr.Zero : ((global::Java.Lang.Object) leftMesh).Handle);
				__args [1] = new JniArgumentValue ((rightMesh == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rightMesh).Handle);
				__args [2] = new JniArgumentValue (stereoMode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (leftMesh);
				global::System.GC.KeepAlive (rightMesh);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/constructor[@name='Projection' and count(parameter)=2 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.player.Projection.Mesh'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;I)V", "")]
		public unsafe Projection (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection.Mesh mesh, int stereoMode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/example/androidtvlibrary/main/adapter/player/Projection$Mesh;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mesh == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mesh).Handle);
				__args [1] = new JniArgumentValue (stereoMode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mesh);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/method[@name='createEquirectangular' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='int']]"
		[Register ("createEquirectangular", "(FIIFFI)Lcom/example/androidtvlibrary/main/adapter/player/Projection;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection CreateEquirectangular (float radius, int latitudes, int longitudes, float verticalFovDegrees, float horizontalFovDegrees, [global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", ""})]
		int stereoMode)
		{
			const string __id = "createEquirectangular.(FIIFFI)Lcom/example/androidtvlibrary/main/adapter/player/Projection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (latitudes);
				__args [2] = new JniArgumentValue (longitudes);
				__args [3] = new JniArgumentValue (verticalFovDegrees);
				__args [4] = new JniArgumentValue (horizontalFovDegrees);
				__args [5] = new JniArgumentValue (stereoMode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='Projection']/method[@name='createEquirectangular' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createEquirectangular", "(I)Lcom/example/androidtvlibrary/main/adapter/player/Projection;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection CreateEquirectangular ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", ""})]
		int stereoMode)
		{
			const string __id = "createEquirectangular.(I)Lcom/example/androidtvlibrary/main/adapter/player/Projection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stereoMode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Example.Androidtvlibrary.Main.Adapter.Player.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
