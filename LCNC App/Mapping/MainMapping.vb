Imports MongoDB.Bson.Serialization

Module MainMapping
    Public Sub SetMapping()
        BsonClassMap.RegisterClassMap(Of FormComponentModel)(Function(cm)
                                                                 cm.AutoMap()
                                                                 cm.SetIsRootClass(True)
                                                                 Return cm
                                                             End Function)
        BsonClassMap.RegisterClassMap(Of FormTextboxModel)()
        BsonClassMap.RegisterClassMap(Of FormDropdownboxModel)()
    End Sub
End Module
