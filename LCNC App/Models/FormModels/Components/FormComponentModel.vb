Imports MongoDB.Bson.Serialization.Attributes

<BsonDiscriminator(RootClass:=True)>
Public MustInherit Class FormComponentModel

    Property Label As String

    Property Location As Point

    Property Size As Size
End Class
