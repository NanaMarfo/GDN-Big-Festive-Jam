using UnityEngine;

public class Guns : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float FireRate = 15f;
    public Camera fpscam;

    private float nextTimeToFire = 0f;

	// Update is called once per frame
	void Update () {
		
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / FireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

           EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
