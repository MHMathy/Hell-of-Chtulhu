using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public float damage = 10f;
    public int fireRate = 5;
    public Camera FpsCam;
    private float nextTimeToFire = 0f;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.takeDamage(damage);
            }
        }
    }
}
