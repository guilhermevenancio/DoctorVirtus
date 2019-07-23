Imports System.Data.Entity.Migrations

Namespace Migrations

    Friend NotInheritable Class Configuration 
        Inherits DbMigrationsConfiguration(Of _ContextoBD)

        Public Sub New()
            AutomaticMigrationsEnabled = True
            AutomaticMigrationDataLossAllowed = True
        End Sub

        Protected Overrides Sub Seed(context As _ContextoBD)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data.
        End Sub

    End Class

End Namespace
