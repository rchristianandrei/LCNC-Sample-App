Public Class FormComponentModelFactory
    Implements IFormComponentModelFactory

    Public Function CreateComponent(type As FormComponentType) As FormComponentModel Implements IFormComponentModelFactory.CreateComponent
        Dim model As FormComponentModel = Nothing
        Select Case type
            Case FormComponentType.Textbox
                model = New FormTextboxModel

            Case FormComponentType.Dropdownbox
                model = New FormDropdownboxModel
        End Select

        Return model
    End Function
End Class
