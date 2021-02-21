using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public float damage = 10f;
    public int fireRate = 5;
    public int ammo = 30;
    public float reloadTime = 2f;
    public Camera FpsCam;
    private float nextTimeToFire = 0f;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            if (ammo > 0)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
            else
            {
                // reloading
            }
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
<<<<<<< HEAD
            if (target != null)
            {
                target.takeDamage(damage);
                --ammo;
=======
            if (target != null) { target.takeDamage(damage); }
        }
        --ammo;
        AmmoUI.text = ammo + " / " + totalAmmo;
    }

    void ReloadWeapon()
    {
        if (ammo != maxAmmo)
        {
            int deltaAmmo = maxAmmo - ammo;
            totalAmmo -= deltaAmmo;
            if (totalAmmo < 0)
            {
                deltaAmmo += totalAmmo;
                totalAmmo = 0;
>>>>>>> e7d8db80a646fca2c0dd37e9183415e9e02f11f3
            }
        }
    }
}
