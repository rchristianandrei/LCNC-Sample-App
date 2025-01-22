Imports MongoDB.Bson.Serialization.Attributes

<BsonDiscriminator("FormDropdownboxModel")>
Public Class FormDropdownboxModel
    Inherits FormComponentModel

    Property Items As IEnumerable(Of String)
End Class
