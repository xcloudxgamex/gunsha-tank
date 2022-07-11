using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_spawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public Tank_Types tankType;

        public Material color;
    }

    public List<Tank> tankList;

    public TankView tankView;
    public Rigidbody rb;
    // Start is called before the first frame update

    public void createTank(Tank_Types tankType)
    {
        if(tankType == Tank_Types.Blue_Tank)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            TankController tankController = new TankController(tankModel, tankView);
        }

        else if (tankType == Tank_Types.Green_Tank)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
            TankController tankController = new TankController(tankModel, tankView);
        }

        else if (tankType == Tank_Types.Red_Tank)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
            TankController tankController = new TankController(tankModel, tankView);
        }

    }
}
