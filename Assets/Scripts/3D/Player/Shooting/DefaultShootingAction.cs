using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultShootingAction : ShootingAction
{
    public override void Shoot(Vector3 dir)
    {
        var projectile = Instantiate(_projectile, _fireFrom[0].position, transform.rotation) as GameObject;
        projectile.GetComponentInChildren<Projectile>().Fire(dir, 10);
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
