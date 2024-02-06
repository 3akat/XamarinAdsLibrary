using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/GlUtil", DoNotGenerateAcw=true)]
	public sealed partial class GlUtil : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Attribute']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/GlUtil$Attribute", DoNotGenerateAcw=true)]
		public sealed partial class Attribute : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Attribute']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					const string __id = "name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/GlUtil$Attribute", typeof (Attribute));

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

			internal Attribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Attribute']/constructor[@name='GlUtil.Attribute' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Attribute (int program, int index) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (program);
					__args [1] = new JniArgumentValue (index);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Attribute']/method[@name='bind' and count(parameter)=0]"
			[Register ("bind", "()V", "")]
			public unsafe void Bind ()
			{
				const string __id = "bind.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Attribute']/method[@name='setBuffer' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
			[Register ("setBuffer", "([FI)V", "")]
			public unsafe void SetBuffer (float[] buffer, int size)
			{
				const string __id = "setBuffer.([FI)V";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_buffer);
					__args [1] = new JniArgumentValue (size);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
					global::System.GC.KeepAlive (buffer);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Uniform']"
		[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/player/GlUtil$Uniform", DoNotGenerateAcw=true)]
		public sealed partial class Uniform : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Uniform']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					const string __id = "name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/GlUtil$Uniform", typeof (Uniform));

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

			internal Uniform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Uniform']/constructor[@name='GlUtil.Uniform' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Uniform (int program, int index) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (program);
					__args [1] = new JniArgumentValue (index);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Uniform']/method[@name='bind' and count(parameter)=0]"
			[Register ("bind", "()V", "")]
			public unsafe void Bind ()
			{
				const string __id = "bind.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Uniform']/method[@name='setFloat' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFloat", "(F)V", "")]
			public unsafe void SetFloat (float value)
			{
				const string __id = "setFloat.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil.Uniform']/method[@name='setSamplerTexId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setSamplerTexId", "(II)V", "")]
			public unsafe void SetSamplerTexId (int texId, int unit)
			{
				const string __id = "setSamplerTexId.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (texId);
					__args [1] = new JniArgumentValue (unit);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/player/GlUtil", typeof (GlUtil));

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

		internal GlUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe bool IsSurfacelessContextExtensionSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='isSurfacelessContextExtensionSupported' and count(parameter)=0]"
			[Register ("isSurfacelessContextExtensionSupported", "()Z", "")]
			get {
				const string __id = "isSurfacelessContextExtensionSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='checkGlError' and count(parameter)=0]"
		[Register ("checkGlError", "()V", "")]
		public static unsafe void CheckGlError ()
		{
			const string __id = "checkGlError.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='compileProgram' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compileProgram", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompileProgram (string vertexCode, string fragmentCode)
		{
			const string __id = "compileProgram.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_vertexCode = JNIEnv.NewString (vertexCode);
			IntPtr native_fragmentCode = JNIEnv.NewString (fragmentCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_vertexCode);
				__args [1] = new JniArgumentValue (native_fragmentCode);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_vertexCode);
				JNIEnv.DeleteLocalRef (native_fragmentCode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='compileProgram' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("compileProgram", "([Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public static unsafe int CompileProgram (string[] vertexCode, string[] fragmentCode)
		{
			const string __id = "compileProgram.([Ljava/lang/String;[Ljava/lang/String;)I";
			IntPtr native_vertexCode = JNIEnv.NewArray (vertexCode);
			IntPtr native_fragmentCode = JNIEnv.NewArray (fragmentCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_vertexCode);
				__args [1] = new JniArgumentValue (native_fragmentCode);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (vertexCode != null) {
					JNIEnv.CopyArray (native_vertexCode, vertexCode);
					JNIEnv.DeleteLocalRef (native_vertexCode);
				}
				if (fragmentCode != null) {
					JNIEnv.CopyArray (native_fragmentCode, fragmentCode);
					JNIEnv.DeleteLocalRef (native_fragmentCode);
				}
				global::System.GC.KeepAlive (vertexCode);
				global::System.GC.KeepAlive (fragmentCode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='createBuffer' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("createBuffer", "([F)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer CreateBuffer (float[] data)
		{
			const string __id = "createBuffer.([F)Ljava/nio/FloatBuffer;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='createBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createBuffer", "(I)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer CreateBuffer (int capacity)
		{
			const string __id = "createBuffer.(I)Ljava/nio/FloatBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (capacity);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='createExternalTexture' and count(parameter)=0]"
		[Register ("createExternalTexture", "()I", "")]
		public static unsafe int CreateExternalTexture ()
		{
			const string __id = "createExternalTexture.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='getAttributes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAttributes", "(I)[Lcom/example/androidtvlibrary/main/adapter/player/GlUtil$Attribute;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.GlUtil.Attribute[] GetAttributes (int program)
		{
			const string __id = "getAttributes.(I)[Lcom/example/androidtvlibrary/main/adapter/player/GlUtil$Attribute;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (program);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.GlUtil.Attribute[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.GlUtil.Attribute));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='getUniforms' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUniforms", "(I)[Lcom/example/androidtvlibrary/main/adapter/player/GlUtil$Uniform;", "")]
		public static unsafe global::Com.Example.Androidtvlibrary.Main.Adapter.Player.GlUtil.Uniform[] GetUniforms (int program)
		{
			const string __id = "getUniforms.(I)[Lcom/example/androidtvlibrary/main/adapter/player/GlUtil$Uniform;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (program);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.GlUtil.Uniform[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Example.Androidtvlibrary.Main.Adapter.Player.GlUtil.Uniform));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter.player']/class[@name='GlUtil']/method[@name='isProtectedContentExtensionSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isProtectedContentExtensionSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsProtectedContentExtensionSupported (global::Android.Content.Context context)
		{
			const string __id = "isProtectedContentExtensionSupported.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
