using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Cengalabs.Flatui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']"
	[global::Android.Runtime.Register ("com/cengalabs/flatui/TouchEffectAnimator", DoNotGenerateAcw=true)]
	public partial class TouchEffectAnimator : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.cengalabs.flatui']/interface[@name='TouchEffectAnimator.InterpolatedTimeCallback']"
		[Register ("com/cengalabs/flatui/TouchEffectAnimator$InterpolatedTimeCallback", "", "Com.Cengalabs.Flatui.TouchEffectAnimator/IInterpolatedTimeCallbackInvoker")]
		public partial interface IInterpolatedTimeCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/interface[@name='TouchEffectAnimator.InterpolatedTimeCallback']/method[@name='onTimeUpdate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("onTimeUpdate", "(F)V", "GetOnTimeUpdate_FHandler:Com.Cengalabs.Flatui.TouchEffectAnimator/IInterpolatedTimeCallbackInvoker, FlatUI")]
			void OnTimeUpdate (float p0);

		}

		[global::Android.Runtime.Register ("com/cengalabs/flatui/TouchEffectAnimator$InterpolatedTimeCallback", DoNotGenerateAcw=true)]
		internal class IInterpolatedTimeCallbackInvoker : global::Java.Lang.Object, IInterpolatedTimeCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/cengalabs/flatui/TouchEffectAnimator$InterpolatedTimeCallback");
			IntPtr class_ref;

			public static IInterpolatedTimeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInterpolatedTimeCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.cengalabs.flatui.TouchEffectAnimator.InterpolatedTimeCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInterpolatedTimeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInterpolatedTimeCallbackInvoker); }
			}

			static Delegate cb_onTimeUpdate_F;
#pragma warning disable 0169
			static Delegate GetOnTimeUpdate_FHandler ()
			{
				if (cb_onTimeUpdate_F == null)
					cb_onTimeUpdate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnTimeUpdate_F);
				return cb_onTimeUpdate_F;
			}

			static void n_OnTimeUpdate_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Cengalabs.Flatui.TouchEffectAnimator.IInterpolatedTimeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator.IInterpolatedTimeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTimeUpdate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTimeUpdate_F;
			public unsafe void OnTimeUpdate (float p0)
			{
				if (id_onTimeUpdate_F == IntPtr.Zero)
					id_onTimeUpdate_F = JNIEnv.GetMethodID (class_ref, "onTimeUpdate", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onTimeUpdate_F, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator.ValueGeneratorAnim']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/TouchEffectAnimator$ValueGeneratorAnim", DoNotGenerateAcw=true)]
		public partial class ValueGeneratorAnim : global::Android.Views.Animations.Animation {

			protected ValueGeneratorAnim (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/cengalabs/flatui/TouchEffectAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TouchEffectAnimator); }
		}

		protected TouchEffectAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/constructor[@name='TouchEffectAnimator' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe TouchEffectAnimator (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TouchEffectAnimator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_ == null)
				cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraw_Landroid_graphics_Canvas_);
			return cb_onDraw_Landroid_graphics_Canvas_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Cengalabs.Flatui.TouchEffectAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/method[@name='onDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void OnDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_onDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static void n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Cengalabs.Flatui.TouchEffectAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTouchEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)V", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAnimDuration_I;
#pragma warning disable 0169
		static Delegate GetSetAnimDuration_IHandler ()
		{
			if (cb_setAnimDuration_I == null)
				cb_setAnimDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimDuration_I);
			return cb_setAnimDuration_I;
		}

		static void n_SetAnimDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.TouchEffectAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/method[@name='setAnimDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimDuration", "(I)V", "GetSetAnimDuration_IHandler")]
		public virtual unsafe void SetAnimDuration (int p0)
		{
			if (id_setAnimDuration_I == IntPtr.Zero)
				id_setAnimDuration_I = JNIEnv.GetMethodID (class_ref, "setAnimDuration", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAnimDuration_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimDuration", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setClipRadius_I;
#pragma warning disable 0169
		static Delegate GetSetClipRadius_IHandler ()
		{
			if (cb_setClipRadius_I == null)
				cb_setClipRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetClipRadius_I);
			return cb_setClipRadius_I;
		}

		static void n_SetClipRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.TouchEffectAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetClipRadius (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClipRadius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/method[@name='setClipRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setClipRadius", "(I)V", "GetSetClipRadius_IHandler")]
		public virtual unsafe void SetClipRadius (int p0)
		{
			if (id_setClipRadius_I == IntPtr.Zero)
				id_setClipRadius_I = JNIEnv.GetMethodID (class_ref, "setClipRadius", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClipRadius_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClipRadius", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEffectColor_I;
#pragma warning disable 0169
		static Delegate GetSetEffectColor_IHandler ()
		{
			if (cb_setEffectColor_I == null)
				cb_setEffectColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEffectColor_I);
			return cb_setEffectColor_I;
		}

		static void n_SetEffectColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Cengalabs.Flatui.TouchEffectAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEffectColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEffectColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/method[@name='setEffectColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEffectColor", "(I)V", "GetSetEffectColor_IHandler")]
		public virtual unsafe void SetEffectColor (int p0)
		{
			if (id_setEffectColor_I == IntPtr.Zero)
				id_setEffectColor_I = JNIEnv.GetMethodID (class_ref, "setEffectColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setEffectColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEffectColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHasRippleEffect_Z;
#pragma warning disable 0169
		static Delegate GetSetHasRippleEffect_ZHandler ()
		{
			if (cb_setHasRippleEffect_Z == null)
				cb_setHasRippleEffect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHasRippleEffect_Z);
			return cb_setHasRippleEffect_Z;
		}

		static void n_SetHasRippleEffect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Cengalabs.Flatui.TouchEffectAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Cengalabs.Flatui.TouchEffectAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHasRippleEffect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHasRippleEffect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='TouchEffectAnimator']/method[@name='setHasRippleEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHasRippleEffect", "(Z)V", "GetSetHasRippleEffect_ZHandler")]
		public virtual unsafe void SetHasRippleEffect (bool p0)
		{
			if (id_setHasRippleEffect_Z == IntPtr.Zero)
				id_setHasRippleEffect_Z = JNIEnv.GetMethodID (class_ref, "setHasRippleEffect", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHasRippleEffect_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHasRippleEffect", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
