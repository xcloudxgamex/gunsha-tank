using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_spawner : MonoBehaviour
{
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        createTank();
    }

    private void createTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel, tankView);
    }
}
