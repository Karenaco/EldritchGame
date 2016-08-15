using UnityEngine;
using System.Collections;

public class Mage : Rookie {

    public enum Spec { Fire, Frost, Arcane, Eldritch };
    Spec spec;

    public Mage(Spec _spec)
        {

        spec = _spec;

        }


}
