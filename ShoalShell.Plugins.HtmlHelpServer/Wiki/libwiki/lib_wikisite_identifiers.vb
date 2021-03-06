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
''' DROP TABLE IF EXISTS `lib_wikisite_identifiers`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikisite_identifiers` (
'''   `si_site` int(10) unsigned NOT NULL,
'''   `si_type` varbinary(32) NOT NULL,
'''   `si_key` varbinary(32) NOT NULL,
'''   UNIQUE KEY `site_ids_type` (`si_type`,`si_key`),
'''   KEY `site_ids_site` (`si_site`),
'''   KEY `site_ids_key` (`si_key`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikisite_identifiers", Database:="wiki")>
Public Class lib_wikisite_identifiers: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("si_site"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property si_site As Long
    <DatabaseField("si_type"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property si_type As Byte()
    <DatabaseField("si_key"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property si_key As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikisite_identifiers` (`si_site`, `si_type`, `si_key`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikisite_identifiers` (`si_site`, `si_type`, `si_key`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikisite_identifiers` WHERE `si_type`='{0}' and `si_key`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikisite_identifiers` SET `si_site`='{0}', `si_type`='{1}', `si_key`='{2}' WHERE `si_type`='{3}' and `si_key`='{4}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, si_type, si_key)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, si_site, si_type, si_key)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, si_site, si_type, si_key)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, si_site, si_type, si_key, si_type, si_key)
    End Function
#End Region
End Class


End Namespace
