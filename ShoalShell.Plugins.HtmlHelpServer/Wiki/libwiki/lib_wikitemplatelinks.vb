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
''' DROP TABLE IF EXISTS `lib_wikitemplatelinks`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikitemplatelinks` (
'''   `tl_from` int(10) unsigned NOT NULL DEFAULT '0',
'''   `tl_from_namespace` int(11) NOT NULL DEFAULT '0',
'''   `tl_namespace` int(11) NOT NULL DEFAULT '0',
'''   `tl_title` varbinary(255) NOT NULL DEFAULT '',
'''   UNIQUE KEY `tl_from` (`tl_from`,`tl_namespace`,`tl_title`),
'''   KEY `tl_namespace` (`tl_namespace`,`tl_title`,`tl_from`),
'''   KEY `tl_backlinks_namespace` (`tl_namespace`,`tl_title`,`tl_from_namespace`,`tl_from`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikitemplatelinks", Database:="wiki")>
Public Class lib_wikitemplatelinks: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("tl_from"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property tl_from As Long
    <DatabaseField("tl_from_namespace"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property tl_from_namespace As Long
    <DatabaseField("tl_namespace"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property tl_namespace As Long
    <DatabaseField("tl_title"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property tl_title As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikitemplatelinks` (`tl_from`, `tl_from_namespace`, `tl_namespace`, `tl_title`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikitemplatelinks` (`tl_from`, `tl_from_namespace`, `tl_namespace`, `tl_title`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikitemplatelinks` WHERE `tl_from`='{0}' and `tl_namespace`='{1}' and `tl_title`='{2}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikitemplatelinks` SET `tl_from`='{0}', `tl_from_namespace`='{1}', `tl_namespace`='{2}', `tl_title`='{3}' WHERE `tl_from`='{4}' and `tl_namespace`='{5}' and `tl_title`='{6}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, tl_from, tl_namespace, tl_title)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, tl_from, tl_from_namespace, tl_namespace, tl_title)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, tl_from, tl_from_namespace, tl_namespace, tl_title)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, tl_from, tl_from_namespace, tl_namespace, tl_title, tl_from, tl_namespace, tl_title)
    End Function
#End Region
End Class


End Namespace
