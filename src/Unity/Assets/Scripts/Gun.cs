using UnityEngine;

public class Gun : MonoBehaviour
{
    public readonly float range = 100f;
    public int fireRate = 5;
    public float damage;
    public int gunMagazine;
    public int totalAmmo;
    private int bulletUse = 0;
    public int maxAmmo;
    public float reloadTime = 2f;
    public Camera FpsCam;
    private float nextTimeToFire = 0f;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            if (gunMagazine > 0)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }
        else if (Input.GetKey(KeyCode.R))
        {
            ReloadWeapon();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null) { target.takeDamage(damage); }
        }
        --gunMagazine;
        ++bulletUse;
    }

    void ReloadWeapon()
    {
        if (totalAmmo >= maxAmmo)
        {
            gunMagazine = maxAmmo;
        } else {
            gunMagazine = totalAmmo;
        }
        totalAmmo -= bulletUse;
        bulletUse = 0;
    }
}
