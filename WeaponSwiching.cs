using UnityEngine;

public class WeaponSwiching : MonoBehaviour {
    public int selectionofweapon = 0;

	// Use this for initialization
	void Start () {
        SelectWeapon();
	}
	
	// Update is called once per frame
	void Update () {

        int previousweapon = selectionofweapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectionofweapon >= transform.childCount - 1)
                selectionofweapon = 0;
            else
                selectionofweapon++;

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectionofweapon >= transform.childCount +1)
                selectionofweapon = 0;
            else
                selectionofweapon--;

        }

        if (previousweapon != selectionofweapon )
        {
            SelectWeapon();
        }
    }

    void SelectWeapon ()
    {
        int i = 0;
        foreach (Transform Weapon in transform)
        {
            if (i == selectionofweapon)
                Weapon.gameObject.SetActive(true);
            else
                Weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
