Public Interface IFormControlFactory
    Function CreateComponent(type As FormComponentType) As FormControlComponent

    Function CreateFromModel(model As FormComponentModel) As FormControlComponent
End Interface
