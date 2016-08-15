using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class NameGenerator {


    public enum Type { Friendly, Enemy};
    List<String> firstNameFriendly = new List<String>();
    List<String> firstNameEnemy = new List<String>();
    List<String> lastNameFriendly = new List<String>();
    List<String> lastNameEnemy = new List<String>();
    List<String> titleFriendly = new List<String>();
    List<String> titleEnemy = new List<String>();
    System.Random rnd = new System.Random();
    public NameGenerator()
    {

        addNames();

    }

    public NameGenerator(Type _type)
    {

        

    }

    public String generateName(Type _type)
    {
        String name;
        if (_type == Type.Friendly)
        {
            if (rnd.Next(1, 3) == 1)
            {
                name = firstNameFriendly[rnd.Next(1, firstNameFriendly.Count)] + " " + lastNameFriendly[rnd.Next(1, lastNameFriendly.Count)];
            }
            else if (rnd.Next(1, 3) == 2)
            {
                name = firstNameFriendly[rnd.Next(1, firstNameFriendly.Count)] + " the " + titleFriendly[rnd.Next(1, titleFriendly.Count)];
            }
            else
            {
                name = "Harambe";
            }
            return name;
        }

        else if(_type == Type.Enemy)
        {
            if (rnd.Next(1, 3) == 1)
            {
                name = firstNameEnemy[rnd.Next(1, firstNameEnemy.Count)] + " " + lastNameEnemy[rnd.Next(1, lastNameEnemy.Count)];
            }
            else if (rnd.Next(1, 3) == 2)
            {
                name = firstNameEnemy[rnd.Next(1, firstNameEnemy.Count)] + " the " + titleEnemy[rnd.Next(1, titleEnemy.Count)];
            }
            else
            {
                name = "Yogg Saron";
            }
            return name;
        }

        else
        {
            return null;
        }

    }

    public void addNames()
    {
        firstNameFriendly.Add("Alot");
        firstNameFriendly.Add("Stefan");
        firstNameFriendly.Add("Alfonso");
        firstNameFriendly.Add("Alfred");
        firstNameFriendly.Add("Bobbi");
        lastNameFriendly.Add("Scott");
        lastNameFriendly.Add("Gaines");
        lastNameFriendly.Add("Braveslash");
        lastNameFriendly.Add("Sharpe");
        lastNameFriendly.Add("Townsend");
        titleFriendly.Add("Champion");
        titleFriendly.Add("Knight");
        titleFriendly.Add("Noble");
        titleFriendly.Add("Honorable");

        firstNameFriendly.Add("Logan");
        firstNameFriendly.Add("Tatheo");
        firstNameFriendly.Add("Bane");
        firstNameFriendly.Add("Bedlam");
        firstNameFriendly.Add("Gale");
        firstNameFriendly.Add("Graves");
        firstNameFriendly.Add("Talon");
        lastNameEnemy.Add("Cairnworm");
        lastNameEnemy.Add("Ashdevil");
        lastNameEnemy.Add("Cursehunter");
        lastNameEnemy.Add("Redhail");
        lastNameEnemy.Add("Vilebane");
        titleEnemy.Add("Deserter");
        titleEnemy.Add("Upsurper");
        titleEnemy.Add("Grim");
        titleEnemy.Add("Unending");
        titleEnemy.Add("Basher");
        titleEnemy.Add("Hellbound");
        titleEnemy.Add("Hound");
        titleEnemy.Add("Hungry");


    }

}


