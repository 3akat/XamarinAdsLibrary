using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Androidtvlibrary.Main.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/example/androidtvlibrary/main/adapter/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/field[@name='DEVICE']"
		[Register ("DEVICE")]
		public static string Device {
			get {
				const string __id = "DEVICE.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/field[@name='DEVICE_DEBUG_INFO']"
		[Register ("DEVICE_DEBUG_INFO")]
		public static string DeviceDebugInfo {
			get {
				const string __id = "DEVICE_DEBUG_INFO.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/field[@name='EMPTY_BYTE_ARRAY']"
		[Register ("EMPTY_BYTE_ARRAY")]
		public static IList<byte> EmptyByteArray {
			get {
				const string __id = "EMPTY_BYTE_ARRAY.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/field[@name='MANUFACTURER']"
		[Register ("MANUFACTURER")]
		public static string Manufacturer {
			get {
				const string __id = "MANUFACTURER.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/field[@name='MODEL']"
		[Register ("MODEL")]
		public static string Model {
			get {
				const string __id = "MODEL.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/field[@name='SDK_INT']"
		[Register ("SDK_INT")]
		public static int SdkInt {
			get {
				const string __id = "SDK_INT.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/example/androidtvlibrary/main/adapter/Util", typeof (Util));

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

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Android.OS.Looper Looper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getLooper' and count(parameter)=0]"
			[Register ("getLooper", "()Landroid/os/Looper;", "")]
			get {
				const string __id = "getLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='addWithOverflowDefault' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("addWithOverflowDefault", "(JJJ)J", "")]
		public static unsafe long AddWithOverflowDefault (long x, long y, long overflowResult)
		{
			const string __id = "addWithOverflowDefault.(JJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (overflowResult);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='areEqual' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("areEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool AreEqual (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			const string __id = "areEqual.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o1).Handle);
				__args [1] = new JniArgumentValue ((o2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o2).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o1);
				global::System.GC.KeepAlive (o2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='binarySearchCeil' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("binarySearchCeil", "([IIZZ)I", "")]
		public static unsafe int BinarySearchCeil (int[] array, int value, bool inclusive, bool stayInBounds)
		{
			const string __id = "binarySearchCeil.([IIZZ)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				__args [2] = new JniArgumentValue (inclusive);
				__args [3] = new JniArgumentValue (stayInBounds);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='binarySearchCeil' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;? extends java.lang.Comparable&lt;? super T&gt;&gt;'] and parameter[2][@type='T'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("binarySearchCeil", "(Ljava/util/List;Ljava/lang/Comparable;ZZ)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe int BinarySearchCeil (global::System.Collections.Generic.IList<global::Java.Lang.IComparable> list, global::Java.Lang.Object value, bool inclusive, bool stayInBounds)
		{
			const string __id = "binarySearchCeil.(Ljava/util/List;Ljava/lang/Comparable;ZZ)I";
			IntPtr native_list = global::Android.Runtime.JavaList<global::Java.Lang.IComparable>.ToLocalJniHandle (list);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_list);
				__args [1] = new JniArgumentValue (native_value);
				__args [2] = new JniArgumentValue (inclusive);
				__args [3] = new JniArgumentValue (stayInBounds);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (list);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='binarySearchCeil' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("binarySearchCeil", "([JJZZ)I", "")]
		public static unsafe int BinarySearchCeil (long[] array, long value, bool inclusive, bool stayInBounds)
		{
			const string __id = "binarySearchCeil.([JJZZ)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				__args [2] = new JniArgumentValue (inclusive);
				__args [3] = new JniArgumentValue (stayInBounds);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='binarySearchFloor' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("binarySearchFloor", "([IIZZ)I", "")]
		public static unsafe int BinarySearchFloor (int[] array, int value, bool inclusive, bool stayInBounds)
		{
			const string __id = "binarySearchFloor.([IIZZ)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				__args [2] = new JniArgumentValue (inclusive);
				__args [3] = new JniArgumentValue (stayInBounds);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='binarySearchFloor' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;? extends java.lang.Comparable&lt;? super T&gt;&gt;'] and parameter[2][@type='T'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("binarySearchFloor", "(Ljava/util/List;Ljava/lang/Comparable;ZZ)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe int BinarySearchFloor (global::System.Collections.Generic.IList<global::Java.Lang.IComparable> list, global::Java.Lang.Object value, bool inclusive, bool stayInBounds)
		{
			const string __id = "binarySearchFloor.(Ljava/util/List;Ljava/lang/Comparable;ZZ)I";
			IntPtr native_list = global::Android.Runtime.JavaList<global::Java.Lang.IComparable>.ToLocalJniHandle (list);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_list);
				__args [1] = new JniArgumentValue (native_value);
				__args [2] = new JniArgumentValue (inclusive);
				__args [3] = new JniArgumentValue (stayInBounds);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (list);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='binarySearchFloor' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("binarySearchFloor", "([JJZZ)I", "")]
		public static unsafe int BinarySearchFloor (long[] array, long value, bool inclusive, bool stayInBounds)
		{
			const string __id = "binarySearchFloor.([JJZZ)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				__args [2] = new JniArgumentValue (inclusive);
				__args [3] = new JniArgumentValue (stayInBounds);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='castNonNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("castNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CastNonNull (global::Java.Lang.Object value)
		{
			const string __id = "castNonNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='castNonNullTypeArray' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("castNonNullTypeArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] CastNonNullTypeArray (global::Java.Lang.Object[] value)
		{
			const string __id = "castNonNullTypeArray.([Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='ceilDivide' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ceilDivide", "(II)I", "")]
		public static unsafe int CeilDivide (int numerator, int denominator)
		{
			const string __id = "ceilDivide.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (numerator);
				__args [1] = new JniArgumentValue (denominator);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='ceilDivide' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("ceilDivide", "(JJ)J", "")]
		public static unsafe long CeilDivide (long numerator, long denominator)
		{
			const string __id = "ceilDivide.(JJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (numerator);
				__args [1] = new JniArgumentValue (denominator);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='checkCleartextTrafficPermitted' and count(parameter)=1 and parameter[1][@type='android.net.Uri...']]"
		[Register ("checkCleartextTrafficPermitted", "([Landroid/net/Uri;)Z", "")]
		public static unsafe bool CheckCleartextTrafficPermitted (params global::Android.Net.Uri[] uris)
		{
			const string __id = "checkCleartextTrafficPermitted.([Landroid/net/Uri;)Z";
			IntPtr native_uris = JNIEnv.NewArray (uris);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uris);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (uris != null) {
					JNIEnv.CopyArray (native_uris, uris);
					JNIEnv.DeleteLocalRef (native_uris);
				}
				global::System.GC.KeepAlive (uris);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.DataSource']]"
		[Register ("closeQuietly", "(Lcom/example/androidtvlibrary/main/adapter/DataSource;)V", "")]
		public static unsafe void CloseQuietly (global::Com.Example.Androidtvlibrary.Main.Adapter.IDataSource dataSource)
		{
			const string __id = "closeQuietly.(Lcom/example/androidtvlibrary/main/adapter/DataSource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (dataSource);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable closeable)
		{
			const string __id = "closeQuietly.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (closeable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='compareLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("compareLong", "(JJ)I", "")]
		public static unsafe int CompareLong (long left, long right)
		{
			const string __id = "compareLong.(JJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (right);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='constrainValue' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("constrainValue", "(FFF)F", "")]
		public static unsafe float ConstrainValue (float value, float min, float max)
		{
			const string __id = "constrainValue.(FFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (min);
				__args [2] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='constrainValue' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("constrainValue", "(III)I", "")]
		public static unsafe int ConstrainValue (int value, int min, int max)
		{
			const string __id = "constrainValue.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (min);
				__args [2] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='constrainValue' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("constrainValue", "(JJJ)J", "")]
		public static unsafe long ConstrainValue (long value, long min, long max)
		{
			const string __id = "constrainValue.(JJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (min);
				__args [2] = new JniArgumentValue (max);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register ("contains", "([Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Contains (global::Java.Lang.Object[] items, global::Java.Lang.Object item)
		{
			const string __id = "contains.([Ljava/lang/Object;Ljava/lang/Object;)Z";
			IntPtr native_items = JNIEnv.NewArray (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_items);
				__args [1] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (items != null) {
					JNIEnv.CopyArray (native_items, items);
					JNIEnv.DeleteLocalRef (native_items);
				}
				global::System.GC.KeepAlive (items);
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='crc32' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crc32", "([BIII)I", "")]
		public static unsafe int Crc32 (byte[] bytes, int start, int end, int initialValue)
		{
			const string __id = "crc32.([BIII)I";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				__args [3] = new JniArgumentValue (initialValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='crc8' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crc8", "([BIII)I", "")]
		public static unsafe int Crc8 (byte[] bytes, int start, int end, int initialValue)
		{
			const string __id = "crc8.([BIII)I";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				__args [3] = new JniArgumentValue (initialValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='createHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "createHandler.(Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='createHandler' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='android.os.Handler.Callback']]"
		[Register ("createHandler", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler CreateHandler (global::Android.OS.Looper looper, global::Android.OS.Handler.ICallback @callback)
		{
			const string __id = "createHandler.(Landroid/os/Looper;Landroid/os/Handler$Callback;)Landroid/os/Handler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (looper);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='createTempDirectory' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createTempDirectory", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File CreateTempDirectory (global::Android.Content.Context context, string prefix)
		{
			const string __id = "createTempDirectory.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_prefix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='createTempFile' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createTempFile", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File CreateTempFile (global::Android.Content.Context context, string prefix)
		{
			const string __id = "createTempFile.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_prefix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='escapeFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escapeFileName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EscapeFileName (string fileName)
		{
			const string __id = "escapeFileName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='fixSmoothStreamingIsmManifestUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("fixSmoothStreamingIsmManifestUri", "(Landroid/net/Uri;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri FixSmoothStreamingIsmManifestUri (global::Android.Net.Uri uri)
		{
			const string __id = "fixSmoothStreamingIsmManifestUri.(Landroid/net/Uri;)Landroid/net/Uri;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='formatInvariant' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("formatInvariant", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string FormatInvariant (string format, params global::Java.Lang.Object[] args)
		{
			const string __id = "formatInvariant.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='fromUtf8Bytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fromUtf8Bytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string FromUtf8Bytes (byte[] bytes)
		{
			const string __id = "fromUtf8Bytes.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='fromUtf8Bytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fromUtf8Bytes", "([BII)Ljava/lang/String;", "")]
		public static unsafe string FromUtf8Bytes (byte[] bytes, int offset, int length)
		{
			const string __id = "fromUtf8Bytes.([BII)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getAudioContentTypeForStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAudioContentTypeForStreamType", "(I)I", "")]
		public static unsafe int GetAudioContentTypeForStreamType ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"StreamTypeAlarm", "StreamTypeDtmf", "StreamTypeMusic", "StreamTypeNotification", "StreamTypeRing", "StreamTypeSystem", "StreamTypeVoiceCall", "StreamTypeUseDefault"})]
		int streamType)
		{
			const string __id = "getAudioContentTypeForStreamType.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamType);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getAudioTrackChannelConfig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAudioTrackChannelConfig", "(I)I", "")]
		public static unsafe int GetAudioTrackChannelConfig (int channelCount)
		{
			const string __id = "getAudioTrackChannelConfig.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channelCount);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getAudioUsageForStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAudioUsageForStreamType", "(I)I", "")]
		public static unsafe int GetAudioUsageForStreamType ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"StreamTypeAlarm", "StreamTypeDtmf", "StreamTypeMusic", "StreamTypeNotification", "StreamTypeRing", "StreamTypeSystem", "StreamTypeVoiceCall", "StreamTypeUseDefault"})]
		int streamType)
		{
			const string __id = "getAudioUsageForStreamType.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamType);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getBytesFromHexString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesFromHexString", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesFromHexString (string hexString)
		{
			const string __id = "getBytesFromHexString.(Ljava/lang/String;)[B";
			IntPtr native_hexString = JNIEnv.NewString (hexString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hexString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_hexString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getCodecsOfType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getCodecsOfType", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string GetCodecsOfType (string codecs, int trackType)
		{
			const string __id = "getCodecsOfType.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_codecs);
				__args [1] = new JniArgumentValue (trackType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_codecs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getCommaDelimitedSimpleClassNames' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("getCommaDelimitedSimpleClassNames", "([Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetCommaDelimitedSimpleClassNames (global::Java.Lang.Object[] objects)
		{
			const string __id = "getCommaDelimitedSimpleClassNames.([Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_objects = JNIEnv.NewArray (objects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objects);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (objects != null) {
					JNIEnv.CopyArray (native_objects, objects);
					JNIEnv.DeleteLocalRef (native_objects);
				}
				global::System.GC.KeepAlive (objects);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getCountryCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCountryCode", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCountryCode (global::Android.Content.Context context)
		{
			const string __id = "getCountryCode.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getCurrentDisplayModeSize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCurrentDisplayModeSize", "(Landroid/content/Context;)Landroid/graphics/Point;", "")]
		public static unsafe global::Android.Graphics.Point GetCurrentDisplayModeSize (global::Android.Content.Context context)
		{
			const string __id = "getCurrentDisplayModeSize.(Landroid/content/Context;)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getCurrentDisplayModeSize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.Display']]"
		[Register ("getCurrentDisplayModeSize", "(Landroid/content/Context;Landroid/view/Display;)Landroid/graphics/Point;", "")]
		public static unsafe global::Android.Graphics.Point GetCurrentDisplayModeSize (global::Android.Content.Context context, global::Android.Views.Display display)
		{
			const string __id = "getCurrentDisplayModeSize.(Landroid/content/Context;Landroid/view/Display;)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((display == null) ? IntPtr.Zero : ((global::Java.Lang.Object) display).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (display);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getDrmUuid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDrmUuid", "(Ljava/lang/String;)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID GetDrmUuid (string drmScheme)
		{
			const string __id = "getDrmUuid.(Ljava/lang/String;)Ljava/util/UUID;";
			IntPtr native_drmScheme = JNIEnv.NewString (drmScheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_drmScheme);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_drmScheme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getIntegerCodeForString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIntegerCodeForString", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetIntegerCodeForString (string @string)
		{
			const string __id = "getIntegerCodeForString.(Ljava/lang/String;)I";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getLocaleLanguageTag' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("getLocaleLanguageTag", "(Ljava/util/Locale;)Ljava/lang/String;", "")]
		public static unsafe string GetLocaleLanguageTag (global::Java.Util.Locale locale)
		{
			const string __id = "getLocaleLanguageTag.(Ljava/util/Locale;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (locale);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getMediaDurationForPlayoutDuration' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
		[Register ("getMediaDurationForPlayoutDuration", "(JF)J", "")]
		public static unsafe long GetMediaDurationForPlayoutDuration (long playoutDuration, float speed)
		{
			const string __id = "getMediaDurationForPlayoutDuration.(JF)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (playoutDuration);
				__args [1] = new JniArgumentValue (speed);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getNetworkType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkType", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNetworkType (global::Android.Content.Context context)
		{
			const string __id = "getNetworkType.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getPcmEncoding' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPcmEncoding", "(I)I", "")]
		public static unsafe int GetPcmEncoding (int bitDepth)
		{
			const string __id = "getPcmEncoding.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitDepth);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getPcmFrameSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPcmFrameSize", "(II)I", "")]
		public static unsafe int GetPcmFrameSize ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", ""})]
		int pcmEncoding, int channelCount)
		{
			const string __id = "getPcmFrameSize.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pcmEncoding);
				__args [1] = new JniArgumentValue (channelCount);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getPlayoutDurationForMediaDuration' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
		[Register ("getPlayoutDurationForMediaDuration", "(JF)J", "")]
		public static unsafe long GetPlayoutDurationForMediaDuration (long mediaDuration, float speed)
		{
			const string __id = "getPlayoutDurationForMediaDuration.(JF)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (mediaDuration);
				__args [1] = new JniArgumentValue (speed);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getStreamTypeForAudioUsage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStreamTypeForAudioUsage", "(I)I", "")]
		public static unsafe int GetStreamTypeForAudioUsage ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.C", Fields = new string [] {"UsageAlarm", "UsageAssistanceAccessibility", "UsageAssistanceNavigationGuidance", "UsageAssistanceSonification", "UsageAssistant", "UsageGame", "UsageMedia", "UsageNotification", "UsageNotificationCommunicationDelayed", "UsageNotificationCommunicationInstant", "UsageNotificationCommunicationRequest", "UsageNotificationEvent", "UsageNotificationRingtone", "UsageUnknown", "UsageVoiceCommunication", "UsageVoiceCommunicationSignalling"})]
		int usage)
		{
			const string __id = "getStreamTypeForAudioUsage.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usage);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getStringForTime' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='java.util.Formatter'] and parameter[3][@type='long']]"
		[Register ("getStringForTime", "(Ljava/lang/StringBuilder;Ljava/util/Formatter;J)Ljava/lang/String;", "")]
		public static unsafe string GetStringForTime (global::Java.Lang.StringBuilder builder, global::Java.Util.Formatter formatter, long timeMs)
		{
			const string __id = "getStringForTime.(Ljava/lang/StringBuilder;Ljava/util/Formatter;J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				__args [1] = new JniArgumentValue ((formatter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatter).Handle);
				__args [2] = new JniArgumentValue (timeMs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (builder);
				global::System.GC.KeepAlive (formatter);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getSystemLanguageCodes' and count(parameter)=0]"
		[Register ("getSystemLanguageCodes", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetSystemLanguageCodes ()
		{
			const string __id = "getSystemLanguageCodes.()[Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getTrackTypeString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTrackTypeString", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetTrackTypeString (int trackType)
		{
			const string __id = "getTrackTypeString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (trackType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getUserAgent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getUserAgent", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetUserAgent (global::Android.Content.Context context, string applicationName)
		{
			const string __id = "getUserAgent.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_applicationName = JNIEnv.NewString (applicationName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_applicationName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationName);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='getUtf8Bytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUtf8Bytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetUtf8Bytes (string value)
		{
			const string __id = "getUtf8Bytes.(Ljava/lang/String;)[B";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='inferContentType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("inferContentType", "(Landroid/net/Uri;)I", "")]
		public static unsafe int InferContentType (global::Android.Net.Uri uri)
		{
			const string __id = "inferContentType.(Landroid/net/Uri;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='inferContentType' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String']]"
		[Register ("inferContentType", "(Landroid/net/Uri;Ljava/lang/String;)I", "")]
		public static unsafe int InferContentType (global::Android.Net.Uri uri, string overrideExtension)
		{
			const string __id = "inferContentType.(Landroid/net/Uri;Ljava/lang/String;)I";
			IntPtr native_overrideExtension = JNIEnv.NewString (overrideExtension);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_overrideExtension);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_overrideExtension);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='inferContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("inferContentType", "(Ljava/lang/String;)I", "")]
		public static unsafe int InferContentType (string fileName)
		{
			const string __id = "inferContentType.(Ljava/lang/String;)I";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='inflate' and count(parameter)=3 and parameter[1][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.Media.ParsableByteArray'] and parameter[3][@type='java.util.zip.Inflater']]"
		[Register ("inflate", "(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/util/zip/Inflater;)Z", "")]
		public static unsafe bool Inflate (global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray input, global::Com.Example.Androidtvlibrary.Main.Adapter.Media.ParsableByteArray output, global::Java.Util.Zip.Inflater inflater)
		{
			const string __id = "inflate.(Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Lcom/example/androidtvlibrary/main/adapter/Media/ParsableByteArray;Ljava/util/zip/Inflater;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [2] = new JniArgumentValue ((inflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inflater).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (output);
				global::System.GC.KeepAlive (inflater);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='isEncodingHighResolutionPcm' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEncodingHighResolutionPcm", "(I)Z", "")]
		public static unsafe bool IsEncodingHighResolutionPcm ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", ""})]
		int encoding)
		{
			const string __id = "isEncodingHighResolutionPcm.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (encoding);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='isEncodingLinearPcm' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEncodingLinearPcm", "(I)Z", "")]
		public static unsafe bool IsEncodingLinearPcm ([global::Android.Runtime.IntDef (Type = "Com.Example.Androidtvlibrary.Main.Adapter.Format", Fields = new string [] {"NoValue"})][global::Android.Runtime.IntDef (Type = "", Fields = new string [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""})]
		int encoding)
		{
			const string __id = "isEncodingLinearPcm.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (encoding);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='isLinebreak' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLinebreak", "(I)Z", "")]
		public static unsafe bool IsLinebreak (int c)
		{
			const string __id = "isLinebreak.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='isLocalFileUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isLocalFileUri", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsLocalFileUri (global::Android.Net.Uri uri)
		{
			const string __id = "isLocalFileUri.(Landroid/net/Uri;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='isTv' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isTv", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsTv (global::Android.Content.Context context)
		{
			const string __id = "isTv.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='linearSearch' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("linearSearch", "([II)I", "")]
		public static unsafe int LinearSearch (int[] array, int value)
		{
			const string __id = "linearSearch.([II)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='linearSearch' and count(parameter)=2 and parameter[1][@type='long[]'] and parameter[2][@type='long']]"
		[Register ("linearSearch", "([JJ)I", "")]
		public static unsafe int LinearSearch (long[] array, long value)
		{
			const string __id = "linearSearch.([JJ)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='maybeRequestReadExternalStoragePermission' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.net.Uri...']]"
		[Register ("maybeRequestReadExternalStoragePermission", "(Landroid/app/Activity;[Landroid/net/Uri;)Z", "")]
		public static unsafe bool MaybeRequestReadExternalStoragePermission (global::Android.App.Activity activity, params global::Android.Net.Uri[] uris)
		{
			const string __id = "maybeRequestReadExternalStoragePermission.(Landroid/app/Activity;[Landroid/net/Uri;)Z";
			IntPtr native_uris = JNIEnv.NewArray (uris);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_uris);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (uris != null) {
					JNIEnv.CopyArray (native_uris, uris);
					JNIEnv.DeleteLocalRef (native_uris);
				}
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (uris);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='newSingleThreadExecutor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newSingleThreadExecutor", "(Ljava/lang/String;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor (string threadName)
		{
			const string __id = "newSingleThreadExecutor.(Ljava/lang/String;)Ljava/util/concurrent/ExecutorService;";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_threadName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='normalizeLanguageCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizeLanguageCode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NormalizeLanguageCode (string language)
		{
			const string __id = "normalizeLanguageCode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_language = JNIEnv.NewString (language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_language);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='nullSafeArrayAppend' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T']]"
		[Register ("nullSafeArrayAppend", "([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NullSafeArrayAppend (global::Java.Lang.Object[] original, global::Java.Lang.Object newElement)
		{
			const string __id = "nullSafeArrayAppend.([Ljava/lang/Object;Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_original = JNIEnv.NewArray (original);
			IntPtr native_newElement = JNIEnv.ToLocalJniHandle (newElement);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_original);
				__args [1] = new JniArgumentValue (native_newElement);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (original != null) {
					JNIEnv.CopyArray (native_original, original);
					JNIEnv.DeleteLocalRef (native_original);
				}
				JNIEnv.DeleteLocalRef (native_newElement);
				global::System.GC.KeepAlive (original);
				global::System.GC.KeepAlive (newElement);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='nullSafeArrayConcatenation' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='T[]']]"
		[Register ("nullSafeArrayConcatenation", "([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NullSafeArrayConcatenation (global::Java.Lang.Object[] first, global::Java.Lang.Object[] second)
		{
			const string __id = "nullSafeArrayConcatenation.([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_first = JNIEnv.NewArray (first);
			IntPtr native_second = JNIEnv.NewArray (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_first);
				__args [1] = new JniArgumentValue (native_second);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (first != null) {
					JNIEnv.CopyArray (native_first, first);
					JNIEnv.DeleteLocalRef (native_first);
				}
				if (second != null) {
					JNIEnv.CopyArray (native_second, second);
					JNIEnv.DeleteLocalRef (native_second);
				}
				global::System.GC.KeepAlive (first);
				global::System.GC.KeepAlive (second);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='nullSafeArrayCopy' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("nullSafeArrayCopy", "([Ljava/lang/Object;I)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NullSafeArrayCopy (global::Java.Lang.Object[] input, int length)
		{
			const string __id = "nullSafeArrayCopy.([Ljava/lang/Object;I)[Ljava/lang/Object;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='nullSafeArrayCopyOfRange' and count(parameter)=3 and parameter[1][@type='T[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("nullSafeArrayCopyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object[] NullSafeArrayCopyOfRange (global::Java.Lang.Object[] input, int from, int to)
		{
			const string __id = "nullSafeArrayCopyOfRange.([Ljava/lang/Object;II)[Ljava/lang/Object;";
			IntPtr native_input = JNIEnv.NewArray (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (from);
				__args [2] = new JniArgumentValue (to);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (input != null) {
					JNIEnv.CopyArray (native_input, input);
					JNIEnv.DeleteLocalRef (native_input);
				}
				global::System.GC.KeepAlive (input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='parseXsDuration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseXsDuration", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseXsDuration (string value)
		{
			const string __id = "parseXsDuration.(Ljava/lang/String;)J";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='readBoolean' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("readBoolean", "(Landroid/os/Parcel;)Z", "")]
		public static unsafe bool ReadBoolean (global::Android.OS.Parcel parcel)
		{
			const string __id = "readBoolean.(Landroid/os/Parcel;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (parcel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='recursiveDelete' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("recursiveDelete", "(Ljava/io/File;)V", "")]
		public static unsafe void RecursiveDelete (global::Java.IO.File fileOrDirectory)
		{
			const string __id = "recursiveDelete.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fileOrDirectory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileOrDirectory).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (fileOrDirectory);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='removeRange' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("removeRange", "(Ljava/util/List;II)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void RemoveRange (global::System.Collections.IList list, int fromIndex, int toIndex)
		{
			const string __id = "removeRange.(Ljava/util/List;II)V";
			IntPtr native_list = global::Android.Runtime.JavaList.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_list);
				__args [1] = new JniArgumentValue (fromIndex);
				__args [2] = new JniArgumentValue (toIndex);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (list);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='resolveSeekPositionUs' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.example.androidtvlibrary.main.adapter.wow.SeekParameters'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("resolveSeekPositionUs", "(JLcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;JJ)J", "")]
		public static unsafe long ResolveSeekPositionUs (long positionUs, global::Com.Example.Androidtvlibrary.Main.Adapter.Wow.SeekParameters seekParameters, long firstSyncUs, long secondSyncUs)
		{
			const string __id = "resolveSeekPositionUs.(JLcom/example/androidtvlibrary/main/adapter/wow/SeekParameters;JJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (positionUs);
				__args [1] = new JniArgumentValue ((seekParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seekParameters).Handle);
				__args [2] = new JniArgumentValue (firstSyncUs);
				__args [3] = new JniArgumentValue (secondSyncUs);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (seekParameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='scaleLargeTimestamp' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("scaleLargeTimestamp", "(JJJ)J", "")]
		public static unsafe long ScaleLargeTimestamp (long timestamp, long multiplier, long divisor)
		{
			const string __id = "scaleLargeTimestamp.(JJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (timestamp);
				__args [1] = new JniArgumentValue (multiplier);
				__args [2] = new JniArgumentValue (divisor);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='scaleLargeTimestamps' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;java.lang.Long&gt;'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("scaleLargeTimestamps", "(Ljava/util/List;JJ)[J", "")]
		public static unsafe long[] ScaleLargeTimestamps (global::System.Collections.Generic.IList<global::Java.Lang.Long> timestamps, long multiplier, long divisor)
		{
			const string __id = "scaleLargeTimestamps.(Ljava/util/List;JJ)[J";
			IntPtr native_timestamps = global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (timestamps);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_timestamps);
				__args [1] = new JniArgumentValue (multiplier);
				__args [2] = new JniArgumentValue (divisor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
				JNIEnv.DeleteLocalRef (native_timestamps);
				global::System.GC.KeepAlive (timestamps);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='scaleLargeTimestampsInPlace' and count(parameter)=3 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("scaleLargeTimestampsInPlace", "([JJJ)V", "")]
		public static unsafe void ScaleLargeTimestampsInPlace (long[] timestamps, long multiplier, long divisor)
		{
			const string __id = "scaleLargeTimestampsInPlace.([JJJ)V";
			IntPtr native_timestamps = JNIEnv.NewArray (timestamps);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_timestamps);
				__args [1] = new JniArgumentValue (multiplier);
				__args [2] = new JniArgumentValue (divisor);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (timestamps != null) {
					JNIEnv.CopyArray (native_timestamps, timestamps);
					JNIEnv.DeleteLocalRef (native_timestamps);
				}
				global::System.GC.KeepAlive (timestamps);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='sneakyThrow' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("sneakyThrow", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void SneakyThrow (global::Java.Lang.Throwable t)
		{
			const string __id = "sneakyThrow.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='split' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] Split (string value, string regex)
		{
			const string __id = "split.(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (native_regex);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='splitAtFirst' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("splitAtFirst", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitAtFirst (string value, string regex)
		{
			const string __id = "splitAtFirst.(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (native_regex);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='splitCodecs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("splitCodecs", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] SplitCodecs (string codecs)
		{
			const string __id = "splitCodecs.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_codecs = JNIEnv.NewString (codecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_codecs);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_codecs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='startForegroundService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("startForegroundService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/content/ComponentName;", "")]
		public static unsafe global::Android.Content.ComponentName StartForegroundService (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "startForegroundService.(Landroid/content/Context;Landroid/content/Intent;)Landroid/content/ComponentName;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (intent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='subtractWithOverflowDefault' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("subtractWithOverflowDefault", "(JJJ)J", "")]
		public static unsafe long SubtractWithOverflowDefault (long x, long y, long overflowResult)
		{
			const string __id = "subtractWithOverflowDefault.(JJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (overflowResult);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("toArray", "(Ljava/util/List;)[I", "")]
		public static unsafe int[] ToArray (global::System.Collections.Generic.IList<global::Java.Lang.Integer> list)
		{
			const string __id = "toArray.(Ljava/util/List;)[I";
			IntPtr native_list = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (list);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("toByteArray", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] ToByteArray (global::System.IO.Stream inputStream)
		{
			const string __id = "toByteArray.(Ljava/io/InputStream;)[B";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputStream);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				global::System.GC.KeepAlive (inputStream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='toLong' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("toLong", "(II)J", "")]
		public static unsafe long ToLong (int mostSignificantBits, int leastSignificantBits)
		{
			const string __id = "toLong.(II)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (mostSignificantBits);
				__args [1] = new JniArgumentValue (leastSignificantBits);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='toLowerInvariant' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLowerInvariant", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToLowerInvariant (string text)
		{
			const string __id = "toLowerInvariant.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toUnsignedLong", "(I)J", "")]
		public static unsafe long ToUnsignedLong (int x)
		{
			const string __id = "toUnsignedLong.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='toUpperInvariant' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toUpperInvariant", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToUpperInvariant (string text)
		{
			const string __id = "toUpperInvariant.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='unescapeFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeFileName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UnescapeFileName (string fileName)
		{
			const string __id = "unescapeFileName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.androidtvlibrary.main.adapter']/class[@name='Util']/method[@name='writeBoolean' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='boolean']]"
		[Register ("writeBoolean", "(Landroid/os/Parcel;Z)V", "")]
		public static unsafe void WriteBoolean (global::Android.OS.Parcel parcel, bool value)
		{
			const string __id = "writeBoolean.(Landroid/os/Parcel;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (parcel);
			}
		}

	}
}
