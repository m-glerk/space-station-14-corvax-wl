construction-presenter-to-node-to-node = Чтобы сделать это, тебе нужно:

construction-examine-status-effect-should-have = У цели должно быть { $effect }.
construction-examine-status-effect-should-not-have = У цели не должно быть { $effect }.
construction-step-condition-status-effect-should-have = У цели должно быть { $effect }.
construction-step-condition-status-effect-should-not-have = У цели не должно быть { $effect }.

construction-examine-heart-damage-range = { $min ->
    [2147483648] Цель должна иметь минимум { $locMin } повреждений сердца.
    *[other] { $max ->
                [0] Цель должна иметь не более { $locMax } повреждений сердца.
                *[other] Сердце цели должно быть повреждено между { $locMin } и { $locMax }.
             }
}

construction-step-heart-damage-range = { $min ->
    [2147483648] Цель должна иметь минимум { $locMin } повреждений сердца.
    *[other] { $max ->
                [0] Цель должна иметь не более { $locMax } повреждений сердца.
                *[other] Сердце цели должно быть повреждено между { $locMin } и { $locMax }.
             }
}

construction-examine-lung-damage-range = { $min ->
    [2147483648] Цель должна иметь минимум { $locMin } повреждений лёгких.
    *[other] { $max ->
                [0] Цель должна иметь не более { $locMax } повреждений лёгких.
                *[other] Лёгкие цели должны быть повреждены между { $locMin } и { $locMax }.
             }
}

construction-step-lung-damage-range = { $min ->
    [2147483648] Цель должна иметь минимум { $locMin } повреждений лёгких.
    *[other] { $max ->
                [0] Цель должна иметь не более { $locMax } повреждений лёгких.
                *[other] Лёгкие цели должны быть повреждены между { $locMin } и { $locMax }.
             }
}

construction-component-to-perform-header = Чтобы выполнить { $targetName }...
