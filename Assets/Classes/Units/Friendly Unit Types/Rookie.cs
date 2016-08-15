using UnityEngine;
using System.Collections;

public class Rookie : BasicSquadMember
{
    public enum Mood {Placeholder1, Placeholder2, Placeholder3}
    public enum Race {Blasian, NornIrish, GayAssElf, IndianDrawf}
    //Weapon currentWeapon;
    //ArrayList<Weapon> weapons;
    //Armour armour;
    Mood mood;
    Race race;
    int health, moveSpeed, currentExp, maxExp, currentHealth, MaxHealth, sanity, strength, intelligence, dexterity, constitution, wisdom, charisma;
    public string name, biography;
    public Vector3 position;
    //We will use this to change the animation displayed
    int currentAnimation;
    World world;
    public Rookie()
    {

    }

    public Rookie(string _name, string _biography, Race _race, Vector3 _position, World _world)
    {
        //Assign the stats passed in
        name = _name;
        biography = _biography;
        race = _race;
        position = _position;
        world = _world;
        //Deal with generic stats oustide of here to keep the constructor clean
        setUpStats();

        //Assign some starter weapon and armour here
        //The character will derive it's damage stat from the weapon + current stats

        //Example of how race will affect stats e.g. movespeed/Health/Weapons...
        //This will tune the standard RPG stats, int/strenght/dex etc etc
        if (race == Race.NornIrish)
        {
            //For running after taegs
            moveSpeed = 6;
        }
        else
        {
            //Fucking slow bastards
            moveSpeed = 5;
        }
    }

    public void setUpStats()
    {
        currentExp = 0;
        maxExp = 100;
        currentHealth = 10;
        MaxHealth = 10;
        sanity = 0;
    }

    //Will eventually return a tile object, cba doing it now
    public Vector3 getCurrentTileCoords()
    {
        
        return position;
    }

    public void move()
    {

    }
    public void changeAnimation()
    {

    }
    public void attack()
    {

    }

    public Vector3 getLocation()
    {
        return world.GetLocation(position);

    }


}
