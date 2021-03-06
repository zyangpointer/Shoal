REM  Oracle.LinuxCompatibility.MySQL.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 

REM  Dump @12/3/2015 8:20:41 PM


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace Wiki.MySQL

''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `lib_wikimsg_resource_links`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikimsg_resource_links` (
'''   `mrl_resource` varbinary(255) NOT NULL,
'''   `mrl_message` varbinary(255) NOT NULL,
'''   UNIQUE KEY `mrl_message_resource` (`mrl_message`,`mrl_resource`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikimsg_resource_links", Database:="wiki")>
Public Class lib_wikimsg_resource_links: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("mrl_resource"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property mrl_resource As Byte()
    <DatabaseField("mrl_message"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property mrl_message As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikimsg_resource_links` (`mrl_resource`, `mrl_message`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikimsg_resource_links` (`mrl_resource`, `mrl_message`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikimsg_resource_links` WHERE `mrl_message`='{0}' and `mrl_resource`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikimsg_resource_links` SET `mrl_resource`='{0}', `mrl_message`='{1}' WHERE `mrl_message`='{2}' and `mrl_resource`='{3}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, mrl_message, mrl_resource)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, mrl_resource, mrl_message)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, mrl_resource, mrl_message)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, mrl_resource, mrl_message, mrl_message, mrl_resource)
    End Function
#End Region
End Class


End Namespace
