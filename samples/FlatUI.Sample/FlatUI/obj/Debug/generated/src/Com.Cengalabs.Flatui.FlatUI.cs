using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Cengalabs.Flatui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']"
	[global::Android.Runtime.Register ("com/cengalabs/flatui/FlatUI", DoNotGenerateAcw=true)]
	public partial class FlatUI : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='BLOOD']"
		[Register ("BLOOD")]
		public const int Blood = (int) 2130968587;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='BLOSSOM']"
		[Register ("BLOSSOM")]
		public const int Blossom = (int) 2130968579;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='CANDY']"
		[Register ("CANDY")]
		public const int Candy = (int) 2130968578;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='DARK']"
		[Register ("DARK")]
		public const int Dark = (int) 2130968584;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='DEEP']"
		[Register ("DEEP")]
		public const int Deep = (int) 2130968581;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='GRAPE']"
		[Register ("GRAPE")]
		public const int Grape = (int) 2130968580;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='GRASS']"
		[Register ("GRASS")]
		public const int Grass = (int) 2130968583;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='ORANGE']"
		[Register ("ORANGE")]
		public const int Orange = (int) 2130968577;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='SAND']"
		[Register ("SAND")]
		public const int Sand = (int) 2130968576;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='SEA']"
		[Register ("SEA")]
		public const int Sea = (int) 2130968586;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='SKY']"
		[Register ("SKY")]
		public const int Sky = (int) 2130968582;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='SNOW']"
		[Register ("SNOW")]
		public const int Snow = (int) 2130968585;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/field[@name='androidStyleNameSpace']"
		[Register ("androidStyleNameSpace")]
		public const string AndroidStyleNameSpace = (string) "http://schemas.android.com/apk/res/android";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/cengalabs/flatui/FlatUI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatUI); }
		}

		protected FlatUI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/constructor[@name='FlatUI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlatUI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlatUI)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getActionBarDrawable_Landroid_app_Activity_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/method[@name='getActionBarDrawable' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getActionBarDrawable", "(Landroid/app/Activity;IZ)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetActionBarDrawable (global::Android.App.Activity p0, int p1, bool p2)
		{
			if (id_getActionBarDrawable_Landroid_app_Activity_IZ == IntPtr.Zero)
				id_getActionBarDrawable_Landroid_app_Activity_IZ = JNIEnv.GetStaticMethodID (class_ref, "getActionBarDrawable", "(Landroid/app/Activity;IZ)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getActionBarDrawable_Landroid_app_Activity_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getActionBarDrawable_Landroid_app_Activity_IZF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/method[@name='getActionBarDrawable' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='float']]"
		[Register ("getActionBarDrawable", "(Landroid/app/Activity;IZF)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetActionBarDrawable (global::Android.App.Activity p0, int p1, bool p2, float p3)
		{
			if (id_getActionBarDrawable_Landroid_app_Activity_IZF == IntPtr.Zero)
				id_getActionBarDrawable_Landroid_app_Activity_IZF = JNIEnv.GetStaticMethodID (class_ref, "getActionBarDrawable", "(Landroid/app/Activity;IZF)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getActionBarDrawable_Landroid_app_Activity_IZF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFont_Landroid_content_Context_Lcom_cengalabs_flatui_Attributes_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/method[@name='getFont' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.cengalabs.flatui.Attributes']]"
		[Register ("getFont", "(Landroid/content/Context;Lcom/cengalabs/flatui/Attributes;)Landroid/graphics/Typeface;", "")]
		public static unsafe global::Android.Graphics.Typeface GetFont (global::Android.Content.Context p0, global::Com.Cengalabs.Flatui.Attributes p1)
		{
			if (id_getFont_Landroid_content_Context_Lcom_cengalabs_flatui_Attributes_ == IntPtr.Zero)
				id_getFont_Landroid_content_Context_Lcom_cengalabs_flatui_Attributes_ = JNIEnv.GetStaticMethodID (class_ref, "getFont", "(Landroid/content/Context;Lcom/cengalabs/flatui/Attributes;)Landroid/graphics/Typeface;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Typeface __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFont_Landroid_content_Context_Lcom_cengalabs_flatui_Attributes_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initDefaultValues_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/method[@name='initDefaultValues' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initDefaultValues", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitDefaultValues (global::Android.Content.Context p0)
		{
			if (id_initDefaultValues_Landroid_content_Context_ == IntPtr.Zero)
				id_initDefaultValues_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initDefaultValues", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initDefaultValues_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setDefaultTheme_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='FlatUI']/method[@name='setDefaultTheme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultTheme", "(I)V", "")]
		public static unsafe void SetDefaultTheme (int p0)
		{
			if (id_setDefaultTheme_I == IntPtr.Zero)
				id_setDefaultTheme_I = JNIEnv.GetStaticMethodID (class_ref, "setDefaultTheme", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultTheme_I, __args);
			} finally {
			}
		}

	}
}
