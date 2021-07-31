using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShootingAction : ShootingAction
{
    public override void Shoot(Vector3 dir)
    {
        var projectile1 = Instantiate(_projectile, _fireFrom[0].position, transform.rotation) as GameObject;
        projectile1.GetComponentInChildren<Projectile>().Fire(dir, 10);
        var projectile2 = Instantiate(_projectile, _fireFrom[1].position, transform.rotation) as GameObject;
        projectile2.GetComponentInChildren<Projectile>().Fire(dir, 10);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
