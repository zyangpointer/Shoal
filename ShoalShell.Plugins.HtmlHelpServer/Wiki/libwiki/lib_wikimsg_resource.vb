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
''' DROP TABLE IF EXISTS `lib_wikimsg_resource`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikimsg_resource` (
'''   `mr_resource` varbinary(255) NOT NULL,
'''   `mr_lang` varbinary(32) NOT NULL,
'''   `mr_blob` mediumblob NOT NULL,
'''   `mr_timestamp` binary(14) NOT NULL,
'''   UNIQUE KEY `mr_resource_lang` (`mr_resource`,`mr_lang`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikimsg_resource", Database:="wiki")>
Public Class lib_wikimsg_resource: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("mr_resource"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property mr_resource As Byte()
    <DatabaseField("mr_lang"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property mr_lang As Byte()
    <DatabaseField("mr_blob"), NotNull, DataType(MySqlDbType.Blob)> Public Property mr_blob As Byte()
    <DatabaseField("mr_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property mr_timestamp As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikimsg_resource` (`mr_resource`, `mr_lang`, `mr_blob`, `mr_timestamp`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikimsg_resource` (`mr_resource`, `mr_lang`, `mr_blob`, `mr_timestamp`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikimsg_resource` WHERE `mr_resource`='{0}' and `mr_lang`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikimsg_resource` SET `mr_resource`='{0}', `mr_lang`='{1}', `mr_blob`='{2}', `mr_timestamp`='{3}' WHERE `mr_resource`='{4}' and `mr_lang`='{5}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, mr_resource, mr_lang)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, mr_resource, mr_lang, mr_blob, mr_timestamp)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, mr_resource, mr_lang, mr_blob, mr_timestamp)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, mr_resource, mr_lang, mr_blob, mr_timestamp, mr_resource, mr_lang)
    End Function
#End Region
End Class


End Namespace
