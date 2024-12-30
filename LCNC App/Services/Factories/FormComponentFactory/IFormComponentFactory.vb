Imports LCNC_App.FormComponentFactory

Public Interface IFormComponentFactory
    Function CreateComponent(type As FormComponentType) As FormControlComponent
End Interface
