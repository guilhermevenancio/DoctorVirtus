Imports System.Data.Entity

Public Class _ContextoBD
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=DoctorVirtus")
        Configuration.LazyLoadingEnabled = False
    End Sub

    Public Sub Atualizar()
        Database.SetInitializer(New MigrateDatabaseToLatestVersion(Of _ContextoBD, Migrations.Configuration)("DoctorVirtus"))
    End Sub

    Public Overridable Property Agenda As DbSet(Of Agenda)
    Public Overridable Property AgendaAnexo As DbSet(Of AgendaAnexo)
    Public Overridable Property AgendaProcedimento As DbSet(Of AgendaProcedimento)
    Public Overridable Property Estado As DbSet(Of Estado)
    Public Overridable Property Imposto As DbSet(Of Imposto)
    Public Overridable Property LocalAtendimento As DbSet(Of LocalAtendimento)
    Public Overridable Property Municipio As DbSet(Of Municipio)
    Public Overridable Property Negociacao As DbSet(Of Negociacao)
    Public Overridable Property Operadora As DbSet(Of Operadora)
    Public Overridable Property Prestador As DbSet(Of Prestador)
    Public Overridable Property PrestadorAnexo As DbSet(Of PrestadorAnexo)
    Public Overridable Property Procedimento As DbSet(Of Procedimento)
    Public Overridable Property ProcedimentoItem As DbSet(Of ProcedimentoItem)
    Public Overridable Property ProcedimentoGrupo As DbSet(Of ProcedimentoGrupo)
    Public Overridable Property Tabela As DbSet(Of Tabela)
    Public Overridable Property Usuario As DbSet(Of Usuario)


    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)

        modelBuilder.Entity(Of ProcedimentoItem)() _
            .Property(Function(e) e.QuantidadeCH_UCO) _
            .HasPrecision(18, 4)

        modelBuilder.Entity(Of ProcedimentoItem)() _
            .Property(Function(e) e.QuantidadeFilmeM2) _
            .HasPrecision(18, 4)



    End Sub

End Class