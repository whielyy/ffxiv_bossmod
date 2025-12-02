namespace BossMod.RealmReborn.Trial.theAkhAfahAmphitheatre.C1Shiva;

public enum OID : uint
{
    Boss = 0xC1C,
}



public enum AID : uint
{

}

class C1ShivaStates : StateMachineBuilder
{
    public C1ShivaStates(BossModule module) : base(module)
    {
        TrivialPhase()
            ;
    }
}

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "Meow", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 79, NameID = 18)]
public class C1Shiva(WorldState ws, Actor primary) : BossModule(ws, primary, new(0.046, -4.379), new ArenaBoundsSquare(20));