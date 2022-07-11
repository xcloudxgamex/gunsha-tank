using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_spawner : MonoBehaviour
{
    public TankView tankView;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        createTank();
    }

    private void createTank()
    {
        TankModel tankModel = new TankModel(30, 80);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
