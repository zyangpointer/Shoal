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
''' DROP TABLE IF EXISTS `lib_wikiiwlinks`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiiwlinks` (
'''   `iwl_from` int(10) unsigned NOT NULL DEFAULT '0',
'''   `iwl_prefix` varbinary(20) NOT NULL DEFAULT '',
'''   `iwl_title` varbinary(255) NOT NULL DEFAULT '',
'''   UNIQUE KEY `iwl_from` (`iwl_from`,`iwl_prefix`,`iwl_title`),
'''   KEY `iwl_prefix_title_from` (`iwl_prefix`,`iwl_title`,`iwl_from`),
'''   KEY `iwl_prefix_from_title` (`iwl_prefix`,`iwl_from`,`iwl_title`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiiwlinks", Database:="wiki")>
Public Class lib_wikiiwlinks: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("iwl_from"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property iwl_from As Long
    <DatabaseField("iwl_prefix"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property iwl_prefix As Byte()
    <DatabaseField("iwl_title"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property iwl_title As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiiwlinks` (`iwl_from`, `iwl_prefix`, `iwl_title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiiwlinks` (`iwl_from`, `iwl_prefix`, `iwl_title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiiwlinks` WHERE `iwl_from`='{0}' and `iwl_prefix`='{1}' and `iwl_title`='{2}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiiwlinks` SET `iwl_from`='{0}', `iwl_prefix`='{1}', `iwl_title`='{2}' WHERE `iwl_from`='{3}' and `iwl_prefix`='{4}' and `iwl_title`='{5}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, iwl_from, iwl_prefix, iwl_title)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, iwl_from, iwl_prefix, iwl_title)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, iwl_from, iwl_prefix, iwl_title)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, iwl_from, iwl_prefix, iwl_title, iwl_from, iwl_prefix, iwl_title)
    End Function
#End Region
End Class


End Namespace
