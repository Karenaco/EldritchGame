using UnityEngine;
using System.Collections;

public class Warrior : Rookie {
    //Purely an example of what our high level class system could be like
    public enum Spec { Arms, Fury, Prot}
    Spec spec;
    //The constructor of the derived class implicitly calls the constructor for the base class, or the superclass in Java terminology.
    public  Warrior(Spec _spec)
    {
        spec = _spec;
    }

}
