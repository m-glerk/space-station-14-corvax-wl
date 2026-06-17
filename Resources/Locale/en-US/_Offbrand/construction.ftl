construction-presenter-to-node-to-node = To perform this, first you need to:

construction-examine-status-effect-should-have = The target needs to have { $effect }.
construction-examine-status-effect-should-not-have = The target needs to not have { $effect }.
construction-step-condition-status-effect-should-have = The target needs to have { $effect }.
construction-step-condition-status-effect-should-not-have = The target needs to not have { $effect }.

construction-examine-heart-damage-range = { $max ->
    [2147483648] The target needs to have at least { $locMin } heart damage.
    *[other] { $min ->
                [0] The target needs to have at most { $locMax } heart damage.
                *[other] The target needs to have between { $locMin } and { $locMax } heart damage.
             }
}

construction-step-heart-damage-range = { $max ->
    [2147483648] The target needs to have at least { $locMin } heart damage.
    *[other] { $min ->
                [0] The target needs to have at most { $locMax } heart damage.
                *[other] The target needs to have between { $locMin } and { $locMax } heart damage.
             }
}

construction-examine-lung-damage-range = { $max ->
    [2147483648] The target needs to have at least { $locMin } lung damage.
    *[other] { $min ->
                [0] The target needs to have at most { $locMax } lung damage.
                *[other] The target needs to have between { $locMin } and { $locMax } lung damage.
             }
}

construction-step-lung-damage-range = { $max ->
    [2147483648] The target needs to have at least { $locMin } lung damage.
    *[other] { $min ->
                [0] The target needs to have at most { $locMax } lung damage.
                *[other] The target needs to have between { $locMin } and { $locMax } lung damage.
             }
}

construction-component-to-perform-header = To perform {$targetName}...
