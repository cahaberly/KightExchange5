'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class cours
    Public Property crn As String
    Public Property course_id As String
    Public Property course_name As String
    Public Property instructor_lname As String

    Public Overridable Property books As ICollection(Of book) = New HashSet(Of book)

End Class
