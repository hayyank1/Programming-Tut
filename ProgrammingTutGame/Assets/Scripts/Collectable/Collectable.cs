using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    RandomPick rand = new RandomPick();

    [SerializeField] GameObject collectable;
    [SerializeField] GameObject[] allCollectables;

    enum eachCollectables {coin = 1, boost = 2}
    int randNum;
    // Start is called before the first frame update
    void Start()
    {
        //randNum = rand.RandomNumPick(1, 2, randNum);
        randNum = 1;
        PickCollectable();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    void PickCollectable()
    {
        eachCollectables pickedCollectable;
        if(randNum == 1)
        {
            print("is this running");
            pickedCollectable = eachCollectables.coin;
            SpawnCollectable(pickedCollectable);

        }
        else if(randNum == 2)
        {
            pickedCollectable = eachCollectables.boost;
            SpawnCollectable(pickedCollectable);
        }
    }

    void SpawnCollectable(eachCollectables picked)
    {
        if(picked == eachCollectables.coin)
        {
            print("is this running");
            collectable = allCollectables[0];
            Instantiate(collectable, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(picked == eachCollectables.boost)
        {
            collectable = allCollectables[1];
            Instantiate(collectable, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
