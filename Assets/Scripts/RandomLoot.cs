using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLoot : MonoBehaviour
{
    public int[] rarityTable =  {45, 25, 15, 10, 5};
    int rarityTotal;
    int randomRarityNumber;
    public int rarity;

    public int[] categoryTable = { 1, 1, 1, 1, 1, 1};
    int categoryTotal;
    int randomCategoryNumber;
    public int category;


    void Start()
    {
        Rarity();
        Category();
        if (category == 1)
        {
            if(rarity == 1)
            {

            }
            if (rarity == 2)
            {

            }
            if (rarity == 3)
            {

            }
            if (rarity == 4)
            {

            }
            if (rarity == 5)
            {

            }
        }
    }

    public void Rarity()
    {
        foreach (var rarityItem in rarityTable)
        {
            rarityTotal += rarityItem;
        }
        randomRarityNumber = Random.Range(0, rarityTotal);
        print("Original Rarity is " + randomRarityNumber);
        for (int r = 0; r < rarityTable.Length; r++)
        {
            if (randomRarityNumber <= rarityTable[r])
            {
                rarity = r + 1;
                return;
            }
            else
            {
                randomRarityNumber -= rarityTable[r];
            }
        }
    }

    public void Category()
    {
        foreach (var categoryItem in categoryTable)
        {
            categoryTotal += categoryItem;
        }
        randomCategoryNumber = Random.Range(0, categoryTotal);
        print("Original Category is " + randomCategoryNumber);
        for (int c = 0; c < categoryTable.Length; c++)
        {
            if (randomCategoryNumber <= categoryTable[c])
            {
                category = c + 1;
                return;
            }
            else
            {
                randomCategoryNumber -= categoryTable[c];
            }
        }
    }
}
