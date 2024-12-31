Public Interface ISpecialized

    ReadOnly Property View As UserControl
    Sub Show(control As FormControlComponent, model As FormComponentModel)
    Sub Hide()
End Interface
