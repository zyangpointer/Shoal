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
''' DROP TABLE IF EXISTS `lib_wikiquerycache_info`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiquerycache_info` (
'''   `qci_type` varbinary(32) NOT NULL DEFAULT '',
'''   `qci_timestamp` binary(14) NOT NULL DEFAULT '19700101000000',
'''   UNIQUE KEY `qci_type` (`qci_type`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiquerycache_info", Database:="wiki")>
Public Class lib_wikiquerycache_info: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("qci_type"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property qci_type As Byte()
    <DatabaseField("qci_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property qci_timestamp As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiquerycache_info` (`qci_type`, `qci_timestamp`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiquerycache_info` (`qci_type`, `qci_timestamp`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiquerycache_info` WHERE `qci_type` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiquerycache_info` SET `qci_type`='{0}', `qci_timestamp`='{1}' WHERE `qci_type` = '{2}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, qci_type)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, qci_type, qci_timestamp)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, qci_type, qci_timestamp)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, qci_type, qci_timestamp, qci_type)
    End Function
#End Region
End Class


End Namespace
