using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownLives : MonoBehaviour
{
    List<string> Rounds = new List<string>() { "Rounds", "1", "2", "3", "4", "5" };

    public Dropdown dropdown;
    public static int myIndex;
    public static int rounds;

    public void Dropdown_IndexChanged(int index)
    {
        myIndex = index;
        rounds = index;
    }

    private void Update()
    {
        if (myIndex == 0)
        {
            myIndex = 1;
          
        }
        if (rounds == 0)
        {
            rounds = 1;

        }


    }
    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.AddOptions(Rounds);
    }
}
