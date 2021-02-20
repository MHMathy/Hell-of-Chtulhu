using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    public readonly float range = 100f;
    public int health;
    public int fireRate = 5;
    public float damage;
    public int ammo;
    public int totalAmmo;
    public int maxAmmo;
    public float reloadTime = 2f;
    public TextMeshProUGUI AmmoUI;
    public TextMeshProUGUI HeathUI;
    public Camera FpsCam;
    private float nextTimeToFire = 0f;

    private void Start()
    {
        AmmoUI.text = ammo + " / " + totalAmmo;
        HeathUI.text = health.ToString();
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            if (ammo > 0)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
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
            }
            ammo += deltaAmmo;
        }
        AmmoUI.text = ammo + " / " + totalAmmo;
    }
}
