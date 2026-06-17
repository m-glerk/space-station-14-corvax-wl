using Content.Shared.EntityEffects;
using Content.Shared.Mobs.Components;
using Content.Shared.Gibbing;
using Content.Shared.Popups;
using Robust.Shared.Prototypes;

namespace Content.Shared._WL._Offbrand.EntityEffects.Effects;

/// <summary>
/// Makes this entity emote.
/// </summary>
/// <inheritdoc cref="EntityEffectSystem{T,TEffect}"/>
public sealed partial class GibEntityEffectSystem : EntityEffectSystem<MobStateComponent, Gib>
{
    [Dependency] private GibbingSystem _gibbing = default!;
    [Dependency] private SharedPopupSystem _popupSystem = default!;

    protected override void Effect(Entity<MobStateComponent> ent, ref EntityEffectEvent<Gib> args)
    {

        if (args.Effect.ShowPopup && args.Effect.PopupText is not null)
            _popupSystem.PopupCoordinates(Loc.GetString(args.Effect.PopupText, ("target", ent)),
                    Transform(ent).Coordinates,
                    PopupType.LargeCaution);

        _gibbing.Gib(ent);
    }
}

/// <inheritdoc cref="EntityEffect"/>
public sealed partial class Gib : EntityEffectBase<Gib>
{
    /// <summary>
    ///     The emote the entity will preform.
    /// </summary>
    [DataField("popup")]
    public string PopupText = "gib-effect-popup";

    /// <summary>
    ///     If the emote should be recorded in chat.
    /// </summary>
    [DataField]
    public bool ShowPopup = true;

    public override string? EntityEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
    {
        return Loc.GetString("entity-effect-guidebook-gib", ("chance", Probability));
    }
}
