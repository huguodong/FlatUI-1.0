package mono.com.cengalabs.flatui;


public class Attributes_AttributeChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.cengalabs.flatui.Attributes.AttributeChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onThemeChange:()V:GetOnThemeChangeHandler:Com.Cengalabs.Flatui.Attributes/IAttributeChangeListenerInvoker, FlatUI\n" +
			"";
		mono.android.Runtime.register ("Com.Cengalabs.Flatui.Attributes+IAttributeChangeListenerImplementor, FlatUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Attributes_AttributeChangeListenerImplementor.class, __md_methods);
	}


	public Attributes_AttributeChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Attributes_AttributeChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Cengalabs.Flatui.Attributes+IAttributeChangeListenerImplementor, FlatUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onThemeChange ()
	{
		n_onThemeChange ();
	}

	private native void n_onThemeChange ();

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
