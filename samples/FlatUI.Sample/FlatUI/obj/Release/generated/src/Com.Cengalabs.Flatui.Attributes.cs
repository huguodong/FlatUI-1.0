using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Cengalabs.Flatui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']"
	[global::Android.Runtime.Register ("com/cengalabs/flatui/Attributes", DoNotGenerateAcw=true)]
	public partial class Attributes : global::Java.Lang.Object {


		static IntPtr DEFAULT_BORDER_WIDTH_DP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_BORDER_WIDTH_DP']"
		[Register ("DEFAULT_BORDER_WIDTH_DP")]
		public static int DefaultBorderWidthDp {
			get {
				if (DEFAULT_BORDER_WIDTH_DP_jfieldId == IntPtr.Zero)
					DEFAULT_BORDER_WIDTH_DP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_BORDER_WIDTH_DP", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_BORDER_WIDTH_DP_jfieldId);
			}
			set {
				if (DEFAULT_BORDER_WIDTH_DP_jfieldId == IntPtr.Zero)
					DEFAULT_BORDER_WIDTH_DP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_BORDER_WIDTH_DP", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_BORDER_WIDTH_DP_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr DEFAULT_BORDER_WIDTH_PX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_BORDER_WIDTH_PX']"
		[Register ("DEFAULT_BORDER_WIDTH_PX")]
		public static int DefaultBorderWidthPx {
			get {
				if (DEFAULT_BORDER_WIDTH_PX_jfieldId == IntPtr.Zero)
					DEFAULT_BORDER_WIDTH_PX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_BORDER_WIDTH_PX", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_BORDER_WIDTH_PX_jfieldId);
			}
			set {
				if (DEFAULT_BORDER_WIDTH_PX_jfieldId == IntPtr.Zero)
					DEFAULT_BORDER_WIDTH_PX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_BORDER_WIDTH_PX", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_BORDER_WIDTH_PX_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_FONT_EXTENSION']"
		[Register ("DEFAULT_FONT_EXTENSION")]
		public const string DefaultFontExtension = (string) "ttf";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_FONT_FAMILY']"
		[Register ("DEFAULT_FONT_FAMILY")]
		public const string DefaultFontFamily = (string) "roboto";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_FONT_WEIGHT']"
		[Register ("DEFAULT_FONT_WEIGHT")]
		public const string DefaultFontWeight = (string) "light";

		static IntPtr DEFAULT_RADIUS_DP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_RADIUS_DP']"
		[Register ("DEFAULT_RADIUS_DP")]
		public static int DefaultRadiusDp {
			get {
				if (DEFAULT_RADIUS_DP_jfieldId == IntPtr.Zero)
					DEFAULT_RADIUS_DP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_RADIUS_DP", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_RADIUS_DP_jfieldId);
			}
			set {
				if (DEFAULT_RADIUS_DP_jfieldId == IntPtr.Zero)
					DEFAULT_RADIUS_DP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_RADIUS_DP", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_RADIUS_DP_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr DEFAULT_RADIUS_PX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_RADIUS_PX']"
		[Register ("DEFAULT_RADIUS_PX")]
		public static int DefaultRadiusPx {
			get {
				if (DEFAULT_RADIUS_PX_jfieldId == IntPtr.Zero)
					DEFAULT_RADIUS_PX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_RADIUS_PX", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_RADIUS_PX_jfieldId);
			}
			set {
				if (DEFAULT_RADIUS_PX_jfieldId == IntPtr.Zero)
					DEFAULT_RADIUS_PX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_RADIUS_PX", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_RADIUS_PX_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr DEFAULT_SIZE_DP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_SIZE_DP']"
		[Register ("DEFAULT_SIZE_DP")]
		public static int DefaultSizeDp {
			get {
				if (DEFAULT_SIZE_DP_jfieldId == IntPtr.Zero)
					DEFAULT_SIZE_DP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_SIZE_DP", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_SIZE_DP_jfieldId);
			}
			set {
				if (DEFAULT_SIZE_DP_jfieldId == IntPtr.Zero)
					DEFAULT_SIZE_DP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_SIZE_DP", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_SIZE_DP_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr DEFAULT_SIZE_PX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_SIZE_PX']"
		[Register ("DEFAULT_SIZE_PX")]
		public static int DefaultSizePx {
			get {
				if (DEFAULT_SIZE_PX_jfieldId == IntPtr.Zero)
					DEFAULT_SIZE_PX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_SIZE_PX", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_SIZE_PX_jfieldId);
			}
			set {
				if (DEFAULT_SIZE_PX_jfieldId == IntPtr.Zero)
					DEFAULT_SIZE_PX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_SIZE_PX", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_SIZE_PX_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_TEXT_APPEARANCE']"
		[Register ("DEFAULT_TEXT_APPEARANCE")]
		public const int DefaultTextAppearance = (int) 0;

		static IntPtr DEFAULT_THEME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_THEME']"
		[Register ("DEFAULT_THEME")]
		public static int DefaultTheme {
			get {
				if (DEFAULT_THEME_jfieldId == IntPtr.Zero)
					DEFAULT_THEME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_THEME", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULT_THEME_jfieldId);
			}
			set {
				if (DEFAULT_THEME_jfieldId == IntPtr.Zero)
					DEFAULT_THEME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_THEME", "I");
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_THEME_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='DEFAULT_TOUCH_EFFECT']"
		[Register ("DEFAULT_TOUCH_EFFECT")]
		public const int DefaultTouchEffect = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='EASE_TOUCH_EFFECT']"
		[Register ("EASE_TOUCH_EFFECT")]
		public const int EaseTouchEffect = (int) 1;

		static IntPtr INVALID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='INVALID']"
		[Register ("INVALID")]
		public static int Invalid {
			get {
				if (INVALID_jfieldId == IntPtr.Zero)
					INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID", "I");
				return JNIEnv.GetStaticIntField (class_ref, INVALID_jfieldId);
			}
			set {
				if (INVALID_jfieldId == IntPtr.Zero)
					INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID", "I");
				try {
					JNIEnv.SetStaticField (class_ref, INVALID_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/field[@name='RIPPLE_TOUCH_EFFECT']"
		[Register ("RIPPLE_TOUCH_EFFECT")]
		public const int RippleTouchEffect = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.cengalabs.flatui']/interface[@name='Attributes.AttributeChangeListener']"
		[Register ("com/cengalabs/flatui/Attributes$AttributeChangeListener", "", "Com.Cengalabs.Flatui.Attributes/IAttributeChangeListenerInvoker")]
		public partial interface IAttributeChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/interface[@name='Attributes.AttributeChangeListener']/method[@name='onThemeChange' and count(parameter)=0]"
			[Register ("onThemeChange", "()V", "GetOnThemeChangeHandler:Com.Cengalabs.Flatui.Attributes/IAttributeChangeListenerInvoker, FlatUI")]
			void OnThemeChange ();

		}

		[global::Android.Runtime.Register ("com/cengalabs/flatui/Attributes$AttributeChangeListener", DoNotGenerateAcw=true)]
		internal class IAttributeChangeListenerInvoker : global::Java.Lang.Object, IAttributeChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/cengalabs/flatui/Attributes$AttributeChangeListener");
			IntPtr class_ref;

			public static IAttributeChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAttributeChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.cengalabs.flatui.Attributes.AttributeChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAttributeChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAttributeChangeListenerInvoker); }
			}

			static Delegate cb_onThemeChange;
#pragma warning disable 0169
			static Delegate GetOnThemeChangeHandler ()
			{
				if (cb_onThemeChange == null)
					cb_onThemeChange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnThemeChange);
				return cb_onThemeChange;
			}

			static void n_OnThemeChange (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Cengalabs.Flatui.Attributes.IAttributeChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes.IAttributeChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnThemeChange ();
			}
#pragma warning restore 0169

			IntPtr id_onThemeChange;
			public unsafe void OnThemeChange ()
			{
				if (id_onThemeChange == IntPtr.Zero)
					id_onThemeChange = JNIEnv.GetMethodID (class_ref, "onThemeChange", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onThemeChange);
			}

		}

		[global::Android.Runtime.Register ("mono/com/cengalabs/flatui/Attributes_AttributeChangeListenerImplementor")]
		internal sealed partial class IAttributeChangeListenerImplementor : global::Java.Lang.Object, IAttributeChangeListener {

			object sender;

			public IAttributeChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/cengalabs/flatui/Attributes_AttributeChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnThemeChange ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IAttributeChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/cengalabs/flatui/Attributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Attributes); }
		}

		protected Attributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_cengalabs_flatui_Attributes_AttributeChangeListener_Landroid_content_res_Resources_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/constructor[@name='Attributes' and count(parameter)=2 and parameter[1][@type='com.cengalabs.flatui.Attributes.AttributeChangeListener'] and parameter[2][@type='android.content.res.Resources']]"
		[Register (".ctor", "(Lcom/cengalabs/flatui/Attributes$AttributeChangeListener;Landroid/content/res/Resources;)V", "")]
		public unsafe Attributes (global::Com.Cengalabs.Flatui.Attributes.IAttributeChangeListener p0, global::Android.Content.Res.Resources p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/cengalabs/flatui/Attributes$AttributeChangeListener;Landroid/content/res/Resources;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/cengalabs/flatui/Attributes$AttributeChangeListener;Landroid/content/res/Resources;)V", __args);
					return;
				}

				if (id_ctor_Lcom_cengalabs_flatui_Attributes_AttributeChangeListener_Landroid_content_res_Resources_ == IntPtr.Zero)
					id_ctor_Lcom_cengalabs_flatui_Attributes_AttributeChangeListener_Landroid_content_res_Resources_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/cengalabs/flatui/Attributes$AttributeChangeListener;Landroid/content/res/Resources;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_cengalabs_flatui_Attributes_AttributeChangeListener_Landroid_content_res_Resources_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_cengalabs_flatui_Attributes_AttributeChangeListener_Landroid_content_res_Resources_, __args);
			} finally {
			}
		}

		static Delegate cb_getBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetBorderWidthHandler ()
		{
			if (cb_getBorderWidth == null)
				cb_getBorderWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBorderWidth);
			return cb_getBorderWidth;
		}

		static int n_GetBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_IHandler ()
		{
			if (cb_setBorderWidth_I == null)
				cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBorderWidth_I);
			return cb_setBorderWidth_I;
		}

		static void n_SetBorderWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderWidth;
		static IntPtr id_setBorderWidth_I;
		public virtual unsafe int BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getBorderWidth' and count(parameter)=0]"
			[Register ("getBorderWidth", "()I", "GetGetBorderWidthHandler")]
			get {
				if (id_getBorderWidth == IntPtr.Zero)
					id_getBorderWidth = JNIEnv.GetMethodID (class_ref, "getBorderWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBorderWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler")]
			set {
				if (id_setBorderWidth_I == IntPtr.Zero)
					id_setBorderWidth_I = JNIEnv.GetMethodID (class_ref, "setBorderWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBorderWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFontExtension;
#pragma warning disable 0169
		static Delegate GetGetFontExtensionHandler ()
		{
			if (cb_getFontExtension == null)
				cb_getFontExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontExtension);
			return cb_getFontExtension;
		}

		static IntPtr n_GetFontExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FontExtension);
		}
#pragma warning restore 0169

		static Delegate cb_setFontExtension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFontExtension_Ljava_lang_String_Handler ()
		{
			if (cb_setFontExtension_Ljava_lang_String_ == null)
				cb_setFontExtension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontExtension_Ljava_lang_String_);
			return cb_setFontExtension_Ljava_lang_String_;
		}

		static void n_SetFontExtension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FontExtension = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFontExtension;
		static IntPtr id_setFontExtension_Ljava_lang_String_;
		public virtual unsafe string FontExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getFontExtension' and count(parameter)=0]"
			[Register ("getFontExtension", "()Ljava/lang/String;", "GetGetFontExtensionHandler")]
			get {
				if (id_getFontExtension == IntPtr.Zero)
					id_getFontExtension = JNIEnv.GetMethodID (class_ref, "getFontExtension", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFontExtension), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontExtension", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setFontExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontExtension", "(Ljava/lang/String;)V", "GetSetFontExtension_Ljava_lang_String_Handler")]
			set {
				if (id_setFontExtension_Ljava_lang_String_ == IntPtr.Zero)
					id_setFontExtension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFontExtension", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFontExtension_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFontExtension", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFontFamily;
#pragma warning disable 0169
		static Delegate GetGetFontFamilyHandler ()
		{
			if (cb_getFontFamily == null)
				cb_getFontFamily = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontFamily);
			return cb_getFontFamily;
		}

		static IntPtr n_GetFontFamily (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FontFamily);
		}
#pragma warning restore 0169

		static Delegate cb_setFontFamily_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFontFamily_Ljava_lang_String_Handler ()
		{
			if (cb_setFontFamily_Ljava_lang_String_ == null)
				cb_setFontFamily_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontFamily_Ljava_lang_String_);
			return cb_setFontFamily_Ljava_lang_String_;
		}

		static void n_SetFontFamily_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FontFamily = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFontFamily;
		static IntPtr id_setFontFamily_Ljava_lang_String_;
		public virtual unsafe string FontFamily {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getFontFamily' and count(parameter)=0]"
			[Register ("getFontFamily", "()Ljava/lang/String;", "GetGetFontFamilyHandler")]
			get {
				if (id_getFontFamily == IntPtr.Zero)
					id_getFontFamily = JNIEnv.GetMethodID (class_ref, "getFontFamily", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFontFamily), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontFamily", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setFontFamily' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontFamily", "(Ljava/lang/String;)V", "GetSetFontFamily_Ljava_lang_String_Handler")]
			set {
				if (id_setFontFamily_Ljava_lang_String_ == IntPtr.Zero)
					id_setFontFamily_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFontFamily", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFontFamily_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFontFamily", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFontWeight;
#pragma warning disable 0169
		static Delegate GetGetFontWeightHandler ()
		{
			if (cb_getFontWeight == null)
				cb_getFontWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontWeight);
			return cb_getFontWeight;
		}

		static IntPtr n_GetFontWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FontWeight);
		}
#pragma warning restore 0169

		static Delegate cb_setFontWeight_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFontWeight_Ljava_lang_String_Handler ()
		{
			if (cb_setFontWeight_Ljava_lang_String_ == null)
				cb_setFontWeight_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontWeight_Ljava_lang_String_);
			return cb_setFontWeight_Ljava_lang_String_;
		}

		static void n_SetFontWeight_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FontWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFontWeight;
		static IntPtr id_setFontWeight_Ljava_lang_String_;
		public virtual unsafe string FontWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getFontWeight' and count(parameter)=0]"
			[Register ("getFontWeight", "()Ljava/lang/String;", "GetGetFontWeightHandler")]
			get {
				if (id_getFontWeight == IntPtr.Zero)
					id_getFontWeight = JNIEnv.GetMethodID (class_ref, "getFontWeight", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFontWeight), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontWeight", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setFontWeight' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontWeight", "(Ljava/lang/String;)V", "GetSetFontWeight_Ljava_lang_String_Handler")]
			set {
				if (id_setFontWeight_Ljava_lang_String_ == IntPtr.Zero)
					id_setFontWeight_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFontWeight", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFontWeight_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFontWeight", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hasTouchEffect;
#pragma warning disable 0169
		static Delegate GetHasTouchEffectHandler ()
		{
			if (cb_hasTouchEffect == null)
				cb_hasTouchEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTouchEffect);
			return cb_hasTouchEffect;
		}

		static bool n_HasTouchEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTouchEffect;
		}
#pragma warning restore 0169

		static IntPtr id_hasTouchEffect;
		public virtual unsafe bool HasTouchEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='hasTouchEffect' and count(parameter)=0]"
			[Register ("hasTouchEffect", "()Z", "GetHasTouchEffectHandler")]
			get {
				if (id_hasTouchEffect == IntPtr.Zero)
					id_hasTouchEffect = JNIEnv.GetMethodID (class_ref, "hasTouchEffect", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasTouchEffect);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasTouchEffect", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_I;
		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRadius);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRadius", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				if (id_setRadius_I == IntPtr.Zero)
					id_setRadius_I = JNIEnv.GetMethodID (class_ref, "setRadius", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRadius_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRadius", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		static IntPtr id_setSize_I;
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
			set {
				if (id_setSize_I == IntPtr.Zero)
					id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextAppearance;
#pragma warning disable 0169
		static Delegate GetGetTextAppearanceHandler ()
		{
			if (cb_getTextAppearance == null)
				cb_getTextAppearance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextAppearance);
			return cb_getTextAppearance;
		}

		static int n_GetTextAppearance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextAppearance;
		}
#pragma warning restore 0169

		static Delegate cb_setTextAppearance_I;
#pragma warning disable 0169
		static Delegate GetSetTextAppearance_IHandler ()
		{
			if (cb_setTextAppearance_I == null)
				cb_setTextAppearance_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextAppearance_I);
			return cb_setTextAppearance_I;
		}

		static void n_SetTextAppearance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextAppearance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextAppearance;
		static IntPtr id_setTextAppearance_I;
		public virtual unsafe int TextAppearance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getTextAppearance' and count(parameter)=0]"
			[Register ("getTextAppearance", "()I", "GetGetTextAppearanceHandler")]
			get {
				if (id_getTextAppearance == IntPtr.Zero)
					id_getTextAppearance = JNIEnv.GetMethodID (class_ref, "getTextAppearance", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTextAppearance);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextAppearance", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setTextAppearance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextAppearance", "(I)V", "GetSetTextAppearance_IHandler")]
			set {
				if (id_setTextAppearance_I == IntPtr.Zero)
					id_setTextAppearance_I = JNIEnv.GetMethodID (class_ref, "setTextAppearance", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTextAppearance_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextAppearance", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTheme;
#pragma warning disable 0169
		static Delegate GetGetThemeHandler ()
		{
			if (cb_getTheme == null)
				cb_getTheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTheme);
			return cb_getTheme;
		}

		static int n_GetTheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Theme;
		}
#pragma warning restore 0169

		static IntPtr id_getTheme;
		public virtual unsafe int Theme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getTheme' and count(parameter)=0]"
			[Register ("getTheme", "()I", "GetGetThemeHandler")]
			get {
				if (id_getTheme == IntPtr.Zero)
					id_getTheme = JNIEnv.GetMethodID (class_ref, "getTheme", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTheme);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTheme", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTouchEffect;
#pragma warning disable 0169
		static Delegate GetGetTouchEffectHandler ()
		{
			if (cb_getTouchEffect == null)
				cb_getTouchEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTouchEffect);
			return cb_getTouchEffect;
		}

		static int n_GetTouchEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchEffect;
		}
#pragma warning restore 0169

		static Delegate cb_setTouchEffect_I;
#pragma warning disable 0169
		static Delegate GetSetTouchEffect_IHandler ()
		{
			if (cb_setTouchEffect_I == null)
				cb_setTouchEffect_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTouchEffect_I);
			return cb_setTouchEffect_I;
		}

		static void n_SetTouchEffect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TouchEffect = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTouchEffect;
		static IntPtr id_setTouchEffect_I;
		public virtual unsafe int TouchEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getTouchEffect' and count(parameter)=0]"
			[Register ("getTouchEffect", "()I", "GetGetTouchEffectHandler")]
			get {
				if (id_getTouchEffect == IntPtr.Zero)
					id_getTouchEffect = JNIEnv.GetMethodID (class_ref, "getTouchEffect", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTouchEffect);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTouchEffect", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setTouchEffect' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTouchEffect", "(I)V", "GetSetTouchEffect_IHandler")]
			set {
				if (id_setTouchEffect_I == IntPtr.Zero)
					id_setTouchEffect_I = JNIEnv.GetMethodID (class_ref, "setTouchEffect", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTouchEffect_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTouchEffect", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getColor_I;
#pragma warning disable 0169
		static Delegate GetGetColor_IHandler ()
		{
			if (cb_getColor_I == null)
				cb_getColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetColor_I);
			return cb_getColor_I;
		}

		static int n_GetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColor", "(I)I", "GetGetColor_IHandler")]
		public virtual unsafe int GetColor (int p0)
		{
			if (id_getColor_I == IntPtr.Zero)
				id_getColor_I = JNIEnv.GetMethodID (class_ref, "getColor", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getOuterRadius;
#pragma warning disable 0169
		static Delegate GetGetOuterRadiusHandler ()
		{
			if (cb_getOuterRadius == null)
				cb_getOuterRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOuterRadius);
			return cb_getOuterRadius;
		}

		static IntPtr n_GetOuterRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOuterRadius ());
		}
#pragma warning restore 0169

		static IntPtr id_getOuterRadius;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='getOuterRadius' and count(parameter)=0]"
		[Register ("getOuterRadius", "()[F", "GetGetOuterRadiusHandler")]
		public virtual unsafe float[] GetOuterRadius ()
		{
			if (id_getOuterRadius == IntPtr.Zero)
				id_getOuterRadius = JNIEnv.GetMethodID (class_ref, "getOuterRadius", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOuterRadius), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOuterRadius", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_setColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColors_arrayIHandler ()
		{
			if (cb_setColors_arrayI == null)
				cb_setColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColors_arrayI);
			return cb_setColors_arrayI;
		}

		static void n_SetColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColors (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColors_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setColors' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setColors", "([I)V", "GetSetColors_arrayIHandler")]
		public virtual unsafe void SetColors (int[] p0)
		{
			if (id_setColors_arrayI == IntPtr.Zero)
				id_setColors_arrayI = JNIEnv.GetMethodID (class_ref, "setColors", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColors_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColors", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setTheme_ILandroid_content_res_Resources_;
#pragma warning disable 0169
		static Delegate GetSetTheme_ILandroid_content_res_Resources_Handler ()
		{
			if (cb_setTheme_ILandroid_content_res_Resources_ == null)
				cb_setTheme_ILandroid_content_res_Resources_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetTheme_ILandroid_content_res_Resources_);
			return cb_setTheme_ILandroid_content_res_Resources_;
		}

		static void n_SetTheme_ILandroid_content_res_Resources_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTheme (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTheme_ILandroid_content_res_Resources_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setTheme' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.res.Resources']]"
		[Register ("setTheme", "(ILandroid/content/res/Resources;)V", "GetSetTheme_ILandroid_content_res_Resources_Handler")]
		public virtual unsafe void SetTheme (int p0, global::Android.Content.Res.Resources p1)
		{
			if (id_setTheme_ILandroid_content_res_Resources_ == IntPtr.Zero)
				id_setTheme_ILandroid_content_res_Resources_ = JNIEnv.GetMethodID (class_ref, "setTheme", "(ILandroid/content/res/Resources;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTheme_ILandroid_content_res_Resources_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTheme", "(ILandroid/content/res/Resources;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setThemeSilent_ILandroid_content_res_Resources_;
#pragma warning disable 0169
		static Delegate GetSetThemeSilent_ILandroid_content_res_Resources_Handler ()
		{
			if (cb_setThemeSilent_ILandroid_content_res_Resources_ == null)
				cb_setThemeSilent_ILandroid_content_res_Resources_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetThemeSilent_ILandroid_content_res_Resources_);
			return cb_setThemeSilent_ILandroid_content_res_Resources_;
		}

		static void n_SetThemeSilent_ILandroid_content_res_Resources_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Cengalabs.Flatui.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetThemeSilent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setThemeSilent_ILandroid_content_res_Resources_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='Attributes']/method[@name='setThemeSilent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.res.Resources']]"
		[Register ("setThemeSilent", "(ILandroid/content/res/Resources;)V", "GetSetThemeSilent_ILandroid_content_res_Resources_Handler")]
		public virtual unsafe void SetThemeSilent (int p0, global::Android.Content.Res.Resources p1)
		{
			if (id_setThemeSilent_ILandroid_content_res_Resources_ == IntPtr.Zero)
				id_setThemeSilent_ILandroid_content_res_Resources_ = JNIEnv.GetMethodID (class_ref, "setThemeSilent", "(ILandroid/content/res/Resources;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setThemeSilent_ILandroid_content_res_Resources_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThemeSilent", "(ILandroid/content/res/Resources;)V"), __args);
			} finally {
			}
		}

	}
}
