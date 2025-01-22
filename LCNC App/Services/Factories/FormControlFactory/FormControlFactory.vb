Public Class FormControlFactory
    Implements IFormControlFactory

    Public Function CreateComponent(type As FormComponentType) As FormControlComponent Implements IFormControlFactory.CreateComponent
        Dim control As FormControlComponent = Nothing
        Select Case type
            Case FormComponentType.Textbox
                control = New FormTextbox

            Case FormComponentType.Dropdownbox
                control = New FormDropdownbox
        End Select

        Return control
    End Function

    Public Function CreateFromModel(model As FormComponentModel) As FormControlComponent Implements IFormControlFactory.CreateFromModel
        Dim control As FormControlComponent = Nothing
        Select Case model.GetType
            Case GetType(FormTextboxModel)
                Dim temp = DirectCast(model, FormTextboxModel)
                Dim textbox = New FormTextbox
                control = textbox

                textbox.Textbox.Multiline = temp.Multiline

            Case GetType(FormDropdownboxModel)
                Dim temp = DirectCast(model, FormDropdownboxModel)
                Dim dropdownbox = New FormDropdownbox
                control = dropdownbox

                If temp.Items IsNot Nothing Then
                    dropdownbox.Dropdownbox.Items.Clear()
                    For Each item In temp.Items
                        dropdownbox.Dropdownbox.Items.Add(item)
                    Next
                End If
        End Select

        control.Label = model.Label
        control.Location = model.Location
        control.Size = model.Size

        Return control
    End Function
End Class
