using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Cengalabs.Flatui.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui.views']/class[@name='FlatToggleButton']"
	[global::Android.Runtime.Register ("com/cengalabs/flatui/views/FlatToggleButton", DoNotGenerateAcw=true)]
	public partial class FlatToggleButton : global::Android.Widget.ToggleButton, global::Com.Cengalabs.Flatui.Attributes.IAttributeChangeListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/cengalabs/flatui/views/FlatToggleButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatToggleButton); }
		}

		protected FlatToggleButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui.views']/class[@name='FlatToggleButton']/constructor[@name='FlatToggleButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe FlatToggleButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (FlatToggleButton)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui.views']/class[@name='FlatToggleButton']/constructor[@name='FlatToggleButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FlatToggleButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FlatToggleButton)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui.views']/class[@name='FlatToggleButton']/constructor[@name='FlatToggleButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FlatToggleButton (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FlatToggleButton)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Cengalabs.Flatui.Views.FlatToggleButton __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Views.FlatToggleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributes;
		public virtual unsafe global::Com.Cengalabs.Flatui.Attributes Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui.views']/class[@name='FlatToggleButton']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Lcom/cengalabs/flatui/Attributes;", "GetGetAttributesHandler")]
			get {
				if (id_getAttributes == IntPtr.Zero)
					id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()Lcom/cengalabs/flatui/Attributes;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (JNIEnv.CallObjectMethod  (Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Attributes> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributes", "()Lcom/cengalabs/flatui/Attributes;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Cengalabs.Flatui.Views.FlatToggleButton __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.Views.FlatToggleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnThemeChange ();
		}
#pragma warning restore 0169

		static IntPtr id_onThemeChange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui.views']/class[@name='FlatToggleButton']/method[@name='onThemeChange' and count(parameter)=0]"
		[Register ("onThemeChange", "()V", "GetOnThemeChangeHandler")]
		public virtual unsafe void OnThemeChange ()
		{
			if (id_onThemeChange == IntPtr.Zero)
				id_onThemeChange = JNIEnv.GetMethodID (class_ref, "onThemeChange", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onThemeChange);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onThemeChange", "()V"));
			} finally {
			}
		}

	}
}
