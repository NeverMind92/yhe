using Content.Shared.Hands.Components;
using Content.Shared.Hands.EntitySystems;

namespace jerk.Some;

public class JerkCrash : EntitySystem
{
    public static bool tog = false;
    
    [Dependency] private readonly SharedHandsSystem _hand = default!;
    public void jerk(Entity<HandsComponent?> ent)
    {
        while (_hand.CountFreeHands(ent) == 1 && tog == true)
        {
            
        }
    }
}