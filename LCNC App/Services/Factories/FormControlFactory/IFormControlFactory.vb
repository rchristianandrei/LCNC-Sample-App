Imports LCNC_App.FormControlFactory

Public Interface IFormControlFactory
    Function CreateComponent(type As FormComponentType) As FormControlComponent
End Interface
