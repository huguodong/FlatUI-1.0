using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Cengalabs.Flatui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R']"
	[global::Android.Runtime.Register ("com/cengalabs/flatui/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/R$array", DoNotGenerateAcw=true)]
		public sealed partial class Array : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='blood']"
			[Register ("blood")]
			public const int Blood = (int) 2130968587;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='blossom']"
			[Register ("blossom")]
			public const int Blossom = (int) 2130968579;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='candy']"
			[Register ("candy")]
			public const int Candy = (int) 2130968578;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='dark']"
			[Register ("dark")]
			public const int Dark = (int) 2130968584;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='deep']"
			[Register ("deep")]
			public const int Deep = (int) 2130968581;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='grape']"
			[Register ("grape")]
			public const int Grape = (int) 2130968580;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='grass']"
			[Register ("grass")]
			public const int Grass = (int) 2130968583;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='orange']"
			[Register ("orange")]
			public const int Orange = (int) 2130968577;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='sand']"
			[Register ("sand")]
			public const int Sand = (int) 2130968576;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='sea']"
			[Register ("sea")]
			public const int Sea = (int) 2130968586;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='sky']"
			[Register ("sky")]
			public const int Sky = (int) 2130968582;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/field[@name='snow']"
			[Register ("snow")]
			public const int Snow = (int) 2130968585;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/cengalabs/flatui/R$array", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Array); }
			}

			internal Array (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.array']/constructor[@name='R.array' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Array ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Array)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_autoFieldStyle']"
			[Register ("fl_autoFieldStyle")]
			public const int FlAutoFieldStyle = (int) 2130771980;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_backgroundColor']"
			[Register ("fl_backgroundColor")]
			public const int FlBackgroundColor = (int) 2130771982;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_blockButtonEffectHeight']"
			[Register ("fl_blockButtonEffectHeight")]
			public const int FlBlockButtonEffectHeight = (int) 2130771978;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_borderWidth']"
			[Register ("fl_borderWidth")]
			public const int FlBorderWidth = (int) 2130771974;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_cornerRadius']"
			[Register ("fl_cornerRadius")]
			public const int FlCornerRadius = (int) 2130771973;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_customBackgroundColor']"
			[Register ("fl_customBackgroundColor")]
			public const int FlCustomBackgroundColor = (int) 2130771983;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_dotMargin']"
			[Register ("fl_dotMargin")]
			public const int FlDotMargin = (int) 2130771977;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_fieldStyle']"
			[Register ("fl_fieldStyle")]
			public const int FlFieldStyle = (int) 2130771979;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_fontExtension']"
			[Register ("fl_fontExtension")]
			public const int FlFontExtension = (int) 2130771971;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_fontFamily']"
			[Register ("fl_fontFamily")]
			public const int FlFontFamily = (int) 2130771969;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_fontWeight']"
			[Register ("fl_fontWeight")]
			public const int FlFontWeight = (int) 2130771970;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_size']"
			[Register ("fl_size")]
			public const int FlSize = (int) 2130771975;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_space']"
			[Register ("fl_space")]
			public const int FlSpace = (int) 2130771984;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_textAppearance']"
			[Register ("fl_textAppearance")]
			public const int FlTextAppearance = (int) 2130771972;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_textColor']"
			[Register ("fl_textColor")]
			public const int FlTextColor = (int) 2130771981;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_theme']"
			[Register ("fl_theme")]
			public const int FlTheme = (int) 2130771968;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/field[@name='fl_touchEffect']"
			[Register ("fl_touchEffect")]
			public const int FlTouchEffect = (int) 2130771976;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/cengalabs/flatui/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Attr ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Attr)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/R$color", DoNotGenerateAcw=true)]
		public sealed partial class Color : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blood_dark']"
			[Register ("blood_dark")]
			public const int BloodDark = (int) 2130903085;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blood_darker']"
			[Register ("blood_darker")]
			public const int BloodDarker = (int) 2130903084;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blood_light']"
			[Register ("blood_light")]
			public const int BloodLight = (int) 2130903087;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blood_primary']"
			[Register ("blood_primary")]
			public const int BloodPrimary = (int) 2130903086;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blossom_dark']"
			[Register ("blossom_dark")]
			public const int BlossomDark = (int) 2130903053;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blossom_darker']"
			[Register ("blossom_darker")]
			public const int BlossomDarker = (int) 2130903052;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blossom_light']"
			[Register ("blossom_light")]
			public const int BlossomLight = (int) 2130903055;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='blossom_primary']"
			[Register ("blossom_primary")]
			public const int BlossomPrimary = (int) 2130903054;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='candy_dark']"
			[Register ("candy_dark")]
			public const int CandyDark = (int) 2130903049;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='candy_darker']"
			[Register ("candy_darker")]
			public const int CandyDarker = (int) 2130903048;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='candy_light']"
			[Register ("candy_light")]
			public const int CandyLight = (int) 2130903051;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='candy_primary']"
			[Register ("candy_primary")]
			public const int CandyPrimary = (int) 2130903050;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='dark_dark']"
			[Register ("dark_dark")]
			public const int DarkDark = (int) 2130903073;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='dark_darker']"
			[Register ("dark_darker")]
			public const int DarkDarker = (int) 2130903072;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='dark_light']"
			[Register ("dark_light")]
			public const int DarkLight = (int) 2130903075;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='dark_primary']"
			[Register ("dark_primary")]
			public const int DarkPrimary = (int) 2130903074;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='deep_dark']"
			[Register ("deep_dark")]
			public const int DeepDark = (int) 2130903061;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='deep_darker']"
			[Register ("deep_darker")]
			public const int DeepDarker = (int) 2130903060;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='deep_light']"
			[Register ("deep_light")]
			public const int DeepLight = (int) 2130903063;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='deep_primary']"
			[Register ("deep_primary")]
			public const int DeepPrimary = (int) 2130903062;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grape_dark']"
			[Register ("grape_dark")]
			public const int GrapeDark = (int) 2130903057;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grape_darker']"
			[Register ("grape_darker")]
			public const int GrapeDarker = (int) 2130903056;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grape_light']"
			[Register ("grape_light")]
			public const int GrapeLight = (int) 2130903059;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grape_primary']"
			[Register ("grape_primary")]
			public const int GrapePrimary = (int) 2130903058;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grass_dark']"
			[Register ("grass_dark")]
			public const int GrassDark = (int) 2130903069;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grass_darker']"
			[Register ("grass_darker")]
			public const int GrassDarker = (int) 2130903068;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grass_light']"
			[Register ("grass_light")]
			public const int GrassLight = (int) 2130903071;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='grass_primary']"
			[Register ("grass_primary")]
			public const int GrassPrimary = (int) 2130903070;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='orange_dark']"
			[Register ("orange_dark")]
			public const int OrangeDark = (int) 2130903045;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='orange_darker']"
			[Register ("orange_darker")]
			public const int OrangeDarker = (int) 2130903044;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='orange_light']"
			[Register ("orange_light")]
			public const int OrangeLight = (int) 2130903047;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='orange_primary']"
			[Register ("orange_primary")]
			public const int OrangePrimary = (int) 2130903046;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sand_dark']"
			[Register ("sand_dark")]
			public const int SandDark = (int) 2130903041;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sand_darker']"
			[Register ("sand_darker")]
			public const int SandDarker = (int) 2130903040;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sand_light']"
			[Register ("sand_light")]
			public const int SandLight = (int) 2130903043;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sand_primary']"
			[Register ("sand_primary")]
			public const int SandPrimary = (int) 2130903042;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sea_dark']"
			[Register ("sea_dark")]
			public const int SeaDark = (int) 2130903081;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sea_darker']"
			[Register ("sea_darker")]
			public const int SeaDarker = (int) 2130903080;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sea_light']"
			[Register ("sea_light")]
			public const int SeaLight = (int) 2130903083;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sea_primary']"
			[Register ("sea_primary")]
			public const int SeaPrimary = (int) 2130903082;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sky_dark']"
			[Register ("sky_dark")]
			public const int SkyDark = (int) 2130903065;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sky_darker']"
			[Register ("sky_darker")]
			public const int SkyDarker = (int) 2130903064;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sky_light']"
			[Register ("sky_light")]
			public const int SkyLight = (int) 2130903067;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='sky_primary']"
			[Register ("sky_primary")]
			public const int SkyPrimary = (int) 2130903066;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='snow_dark']"
			[Register ("snow_dark")]
			public const int SnowDark = (int) 2130903077;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='snow_darker']"
			[Register ("snow_darker")]
			public const int SnowDarker = (int) 2130903076;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='snow_light']"
			[Register ("snow_light")]
			public const int SnowLight = (int) 2130903079;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/field[@name='snow_primary']"
			[Register ("snow_primary")]
			public const int SnowPrimary = (int) 2130903078;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/cengalabs/flatui/R$color", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Color); }
			}

			internal Color (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.color']/constructor[@name='R.color' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Color ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Color)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='box']"
			[Register ("box")]
			public const int Box = (int) 2130837513;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_box']"
			[Register ("fl_box")]
			public const int FlBox = (int) 2130837510;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_dark']"
			[Register ("fl_dark")]
			public const int FlDark = (int) 2130837505;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_darker']"
			[Register ("fl_darker")]
			public const int FlDarker = (int) 2130837515;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_ease']"
			[Register ("fl_ease")]
			public const int FlEase = (int) 2130837507;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_flat']"
			[Register ("fl_flat")]
			public const int FlFlat = (int) 2130837509;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_light']"
			[Register ("fl_light")]
			public const int FlLight = (int) 2130837506;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_main']"
			[Register ("fl_main")]
			public const int FlMain = (int) 2130837516;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_none']"
			[Register ("fl_none")]
			public const int FlNone = (int) 2130837504;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_ripple']"
			[Register ("fl_ripple")]
			public const int FlRipple = (int) 2130837508;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='fl_transparent']"
			[Register ("fl_transparent")]
			public const int FlTransparent = (int) 2130837511;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='flat']"
			[Register ("flat")]
			public const int Flat = (int) 2130837512;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/field[@name='transparent']"
			[Register ("transparent")]
			public const int Transparent = (int) 2130837514;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/cengalabs/flatui/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Id ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Id)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.string']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.string']/field[@name='app_name']"
			[Register ("app_name")]
			public const int AppName = (int) 2131034112;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/cengalabs/flatui/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe String ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (String)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']"
		[global::Android.Runtime.Register ("com/cengalabs/flatui/R$styleable", DoNotGenerateAcw=true)]
		public sealed partial class Styleable : global::Java.Lang.Object {


			static IntPtr fl_FlatAutoCompleteTextView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView']"
			[Register ("fl_FlatAutoCompleteTextView")]
			public static IList<int> FlFlatAutoCompleteTextView {
				get {
					if (fl_FlatAutoCompleteTextView_jfieldId == IntPtr.Zero)
						fl_FlatAutoCompleteTextView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatAutoCompleteTextView", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatAutoCompleteTextView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_autoFieldStyle']"
			[Register ("fl_FlatAutoCompleteTextView_fl_autoFieldStyle")]
			public const int FlFlatAutoCompleteTextViewFlAutoFieldStyle = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_borderWidth']"
			[Register ("fl_FlatAutoCompleteTextView_fl_borderWidth")]
			public const int FlFlatAutoCompleteTextViewFlBorderWidth = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_cornerRadius']"
			[Register ("fl_FlatAutoCompleteTextView_fl_cornerRadius")]
			public const int FlFlatAutoCompleteTextViewFlCornerRadius = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_fontExtension']"
			[Register ("fl_FlatAutoCompleteTextView_fl_fontExtension")]
			public const int FlFlatAutoCompleteTextViewFlFontExtension = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_fontFamily']"
			[Register ("fl_FlatAutoCompleteTextView_fl_fontFamily")]
			public const int FlFlatAutoCompleteTextViewFlFontFamily = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_fontWeight']"
			[Register ("fl_FlatAutoCompleteTextView_fl_fontWeight")]
			public const int FlFlatAutoCompleteTextViewFlFontWeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_textAppearance']"
			[Register ("fl_FlatAutoCompleteTextView_fl_textAppearance")]
			public const int FlFlatAutoCompleteTextViewFlTextAppearance = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatAutoCompleteTextView_fl_theme']"
			[Register ("fl_FlatAutoCompleteTextView_fl_theme")]
			public const int FlFlatAutoCompleteTextViewFlTheme = (int) 0;

			static IntPtr fl_FlatButton_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton']"
			[Register ("fl_FlatButton")]
			public static IList<int> FlFlatButton {
				get {
					if (fl_FlatButton_jfieldId == IntPtr.Zero)
						fl_FlatButton_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatButton", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatButton_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_blockButtonEffectHeight']"
			[Register ("fl_FlatButton_fl_blockButtonEffectHeight")]
			public const int FlFlatButtonFlBlockButtonEffectHeight = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_cornerRadius']"
			[Register ("fl_FlatButton_fl_cornerRadius")]
			public const int FlFlatButtonFlCornerRadius = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_fontExtension']"
			[Register ("fl_FlatButton_fl_fontExtension")]
			public const int FlFlatButtonFlFontExtension = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_fontFamily']"
			[Register ("fl_FlatButton_fl_fontFamily")]
			public const int FlFlatButtonFlFontFamily = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_fontWeight']"
			[Register ("fl_FlatButton_fl_fontWeight")]
			public const int FlFlatButtonFlFontWeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_textAppearance']"
			[Register ("fl_FlatButton_fl_textAppearance")]
			public const int FlFlatButtonFlTextAppearance = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_theme']"
			[Register ("fl_FlatButton_fl_theme")]
			public const int FlFlatButtonFlTheme = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatButton_fl_touchEffect']"
			[Register ("fl_FlatButton_fl_touchEffect")]
			public const int FlFlatButtonFlTouchEffect = (int) 6;

			static IntPtr fl_FlatCheckBox_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox']"
			[Register ("fl_FlatCheckBox")]
			public static IList<int> FlFlatCheckBox {
				get {
					if (fl_FlatCheckBox_jfieldId == IntPtr.Zero)
						fl_FlatCheckBox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatCheckBox", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatCheckBox_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_cornerRadius']"
			[Register ("fl_FlatCheckBox_fl_cornerRadius")]
			public const int FlFlatCheckBoxFlCornerRadius = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_dotMargin']"
			[Register ("fl_FlatCheckBox_fl_dotMargin")]
			public const int FlFlatCheckBoxFlDotMargin = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_fontExtension']"
			[Register ("fl_FlatCheckBox_fl_fontExtension")]
			public const int FlFlatCheckBoxFlFontExtension = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_fontFamily']"
			[Register ("fl_FlatCheckBox_fl_fontFamily")]
			public const int FlFlatCheckBoxFlFontFamily = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_fontWeight']"
			[Register ("fl_FlatCheckBox_fl_fontWeight")]
			public const int FlFlatCheckBoxFlFontWeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_size']"
			[Register ("fl_FlatCheckBox_fl_size")]
			public const int FlFlatCheckBoxFlSize = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatCheckBox_fl_theme']"
			[Register ("fl_FlatCheckBox_fl_theme")]
			public const int FlFlatCheckBoxFlTheme = (int) 0;

			static IntPtr fl_FlatEditText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText']"
			[Register ("fl_FlatEditText")]
			public static IList<int> FlFlatEditText {
				get {
					if (fl_FlatEditText_jfieldId == IntPtr.Zero)
						fl_FlatEditText_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatEditText", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatEditText_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_borderWidth']"
			[Register ("fl_FlatEditText_fl_borderWidth")]
			public const int FlFlatEditTextFlBorderWidth = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_cornerRadius']"
			[Register ("fl_FlatEditText_fl_cornerRadius")]
			public const int FlFlatEditTextFlCornerRadius = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_fieldStyle']"
			[Register ("fl_FlatEditText_fl_fieldStyle")]
			public const int FlFlatEditTextFlFieldStyle = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_fontExtension']"
			[Register ("fl_FlatEditText_fl_fontExtension")]
			public const int FlFlatEditTextFlFontExtension = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_fontFamily']"
			[Register ("fl_FlatEditText_fl_fontFamily")]
			public const int FlFlatEditTextFlFontFamily = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_fontWeight']"
			[Register ("fl_FlatEditText_fl_fontWeight")]
			public const int FlFlatEditTextFlFontWeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_textAppearance']"
			[Register ("fl_FlatEditText_fl_textAppearance")]
			public const int FlFlatEditTextFlTextAppearance = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatEditText_fl_theme']"
			[Register ("fl_FlatEditText_fl_theme")]
			public const int FlFlatEditTextFlTheme = (int) 0;

			static IntPtr fl_FlatRadioButton_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton']"
			[Register ("fl_FlatRadioButton")]
			public static IList<int> FlFlatRadioButton {
				get {
					if (fl_FlatRadioButton_jfieldId == IntPtr.Zero)
						fl_FlatRadioButton_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatRadioButton", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatRadioButton_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_borderWidth']"
			[Register ("fl_FlatRadioButton_fl_borderWidth")]
			public const int FlFlatRadioButtonFlBorderWidth = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_dotMargin']"
			[Register ("fl_FlatRadioButton_fl_dotMargin")]
			public const int FlFlatRadioButtonFlDotMargin = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_fontExtension']"
			[Register ("fl_FlatRadioButton_fl_fontExtension")]
			public const int FlFlatRadioButtonFlFontExtension = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_fontFamily']"
			[Register ("fl_FlatRadioButton_fl_fontFamily")]
			public const int FlFlatRadioButtonFlFontFamily = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_fontWeight']"
			[Register ("fl_FlatRadioButton_fl_fontWeight")]
			public const int FlFlatRadioButtonFlFontWeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_size']"
			[Register ("fl_FlatRadioButton_fl_size")]
			public const int FlFlatRadioButtonFlSize = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatRadioButton_fl_theme']"
			[Register ("fl_FlatRadioButton_fl_theme")]
			public const int FlFlatRadioButtonFlTheme = (int) 0;

			static IntPtr fl_FlatSeekBar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatSeekBar']"
			[Register ("fl_FlatSeekBar")]
			public static IList<int> FlFlatSeekBar {
				get {
					if (fl_FlatSeekBar_jfieldId == IntPtr.Zero)
						fl_FlatSeekBar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatSeekBar", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatSeekBar_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatSeekBar_fl_size']"
			[Register ("fl_FlatSeekBar_fl_size")]
			public const int FlFlatSeekBarFlSize = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatSeekBar_fl_theme']"
			[Register ("fl_FlatSeekBar_fl_theme")]
			public const int FlFlatSeekBarFlTheme = (int) 0;

			static IntPtr fl_FlatTextView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView']"
			[Register ("fl_FlatTextView")]
			public static IList<int> FlFlatTextView {
				get {
					if (fl_FlatTextView_jfieldId == IntPtr.Zero)
						fl_FlatTextView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatTextView", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatTextView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_backgroundColor']"
			[Register ("fl_FlatTextView_fl_backgroundColor")]
			public const int FlFlatTextViewFlBackgroundColor = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_borderWidth']"
			[Register ("fl_FlatTextView_fl_borderWidth")]
			public const int FlFlatTextViewFlBorderWidth = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_cornerRadius']"
			[Register ("fl_FlatTextView_fl_cornerRadius")]
			public const int FlFlatTextViewFlCornerRadius = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_customBackgroundColor']"
			[Register ("fl_FlatTextView_fl_customBackgroundColor")]
			public const int FlFlatTextViewFlCustomBackgroundColor = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_fontExtension']"
			[Register ("fl_FlatTextView_fl_fontExtension")]
			public const int FlFlatTextViewFlFontExtension = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_fontFamily']"
			[Register ("fl_FlatTextView_fl_fontFamily")]
			public const int FlFlatTextViewFlFontFamily = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_fontWeight']"
			[Register ("fl_FlatTextView_fl_fontWeight")]
			public const int FlFlatTextViewFlFontWeight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_textColor']"
			[Register ("fl_FlatTextView_fl_textColor")]
			public const int FlFlatTextViewFlTextColor = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatTextView_fl_theme']"
			[Register ("fl_FlatTextView_fl_theme")]
			public const int FlFlatTextViewFlTheme = (int) 0;

			static IntPtr fl_FlatToggleButton_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatToggleButton']"
			[Register ("fl_FlatToggleButton")]
			public static IList<int> FlFlatToggleButton {
				get {
					if (fl_FlatToggleButton_jfieldId == IntPtr.Zero)
						fl_FlatToggleButton_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fl_FlatToggleButton", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, fl_FlatToggleButton_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatToggleButton_fl_cornerRadius']"
			[Register ("fl_FlatToggleButton_fl_cornerRadius")]
			public const int FlFlatToggleButtonFlCornerRadius = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatToggleButton_fl_space']"
			[Register ("fl_FlatToggleButton_fl_space")]
			public const int FlFlatToggleButtonFlSpace = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/field[@name='fl_FlatToggleButton_fl_theme']"
			[Register ("fl_FlatToggleButton_fl_theme")]
			public const int FlFlatToggleButtonFlTheme = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/cengalabs/flatui/R$styleable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Styleable); }
			}

			internal Styleable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R.styleable']/constructor[@name='R.styleable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Styleable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Styleable)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/cengalabs/flatui/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cengalabs.flatui']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (R)) {
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

	}
}
