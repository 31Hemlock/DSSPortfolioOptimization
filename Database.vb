Imports System.Data.OleDb

Public Class Database
    'NZ: Creates variables for our database connection
    Private objDataAdapter As New OleDbDataAdapter
    Private objConnection As New OleDbConnection
    Private objConnectionString As String
    Private objDataSet As New DataSet
    Private objSQL As String
    Private objCommand As New OleDbCommand
    Private objTableName As String

    'NZ: New method.

    Public Sub New()

    End Sub

    Public Sub RunSQL(objConnectionString, objSQL, objDataSet, objTableName)
        'NZ: We set up a Connection object
        objConnection.ConnectionString = objConnectionString


        'NZ: We set up the Command object
        objCommand = objConnection.CreateCommand()
        objCommand.CommandText = objSQL

        'NZ: We set up the DataAdapter object
        objDataAdapter.SelectCommand = objCommand
        objDataAdapter.Fill(objDataSet, objTableName)


    End Sub

End Class
