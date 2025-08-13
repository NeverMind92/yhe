using Content.Shared.Hands.Components;
using Content.Shared.Hands.EntitySystems;
using Content.Client.Hands.Systems;
using Content.Shared.Inventory;

namespace jerk.Some;

public class JerkCrash : EntitySystem
{
    public static bool tog = false;
    
    [Dependency] private readonly SharedHandsSystem _Shand = default!;
    [Dependency] private readonly HandsSystem _Chand = default!;
    public void jerk(Entity<HandsComponent> ent)
    {
        while (_Shand.CountFreeHands(ent) == 1 && tog == true)
        {
            _Chand.UIHandClick(ent, "body_part_slot_right_hand" );
            _Chand.UIHandClick(ent, "body_part_slot_left_hand" );
        }
    }
}