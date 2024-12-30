Public Class FormComponentFactory

    Public Enum FormComponentType
        Textbox
        Dropdownbox
    End Enum

    Public Function CreateComponent(type As FormComponentType) As FormControlComponent
        Dim control As FormControlComponent = Nothing
        Select Case type
            Case FormComponentType.Textbox
                control = New FormTextbox

            Case FormComponentType.Dropdownbox
                control = New FormDropdownbox
        End Select

        Return control
    End Function
End Class
