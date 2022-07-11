using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public tank_spawner tankSpawner;
public void BlueTankSelected()
    {
        tankSpawner.createTank(Tank_Types.Blue_Tank);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        tankSpawner.createTank(Tank_Types.Green_Tank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.createTank(Tank_Types.Red_Tank);
        this.gameObject.SetActive(false);
    }
}
