package crc644fa4ca156627177a;


public class MainActivity
	extends crc643f46942d9dd1fff9.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.displayunits.DisplayUnitListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_onDisplayUnitsLoaded:(Ljava/util/ArrayList;)V:GetOnDisplayUnitsLoaded_Ljava_util_ArrayList_Handler:Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("XmrinIntegration.Droid.MainActivity, XmrinIntegration.Android", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("XmrinIntegration.Droid.MainActivity, XmrinIntegration.Android", "", this, new java.lang.Object[] {  });
	}


	public MainActivity (int p0)
	{
		super (p0);
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("XmrinIntegration.Droid.MainActivity, XmrinIntegration.Android", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public void onDisplayUnitsLoaded (java.util.ArrayList p0)
	{
		n_onDisplayUnitsLoaded (p0);
	}

	private native void n_onDisplayUnitsLoaded (java.util.ArrayList p0);

	private java.util.ArrayList refList;
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
