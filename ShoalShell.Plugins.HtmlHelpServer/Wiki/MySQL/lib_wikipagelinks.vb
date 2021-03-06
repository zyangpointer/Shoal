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
''' DROP TABLE IF EXISTS `lib_wikipagelinks`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikipagelinks` (
'''   `pl_from` int(10) unsigned NOT NULL DEFAULT '0',
'''   `pl_from_namespace` int(11) NOT NULL DEFAULT '0',
'''   `pl_namespace` int(11) NOT NULL DEFAULT '0',
'''   `pl_title` varbinary(255) NOT NULL DEFAULT '',
'''   UNIQUE KEY `pl_from` (`pl_from`,`pl_namespace`,`pl_title`),
'''   KEY `pl_namespace` (`pl_namespace`,`pl_title`,`pl_from`),
'''   KEY `pl_backlinks_namespace` (`pl_namespace`,`pl_title`,`pl_from_namespace`,`pl_from`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikipagelinks", Database:="wiki")>
Public Class lib_wikipagelinks: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("pl_from"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property pl_from As Long
    <DatabaseField("pl_from_namespace"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property pl_from_namespace As Long
    <DatabaseField("pl_namespace"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property pl_namespace As Long
    <DatabaseField("pl_title"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property pl_title As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikipagelinks` (`pl_from`, `pl_from_namespace`, `pl_namespace`, `pl_title`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikipagelinks` (`pl_from`, `pl_from_namespace`, `pl_namespace`, `pl_title`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikipagelinks` WHERE `pl_from`='{0}' and `pl_namespace`='{1}' and `pl_title`='{2}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikipagelinks` SET `pl_from`='{0}', `pl_from_namespace`='{1}', `pl_namespace`='{2}', `pl_title`='{3}' WHERE `pl_from`='{4}' and `pl_namespace`='{5}' and `pl_title`='{6}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, pl_from, pl_namespace, pl_title)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, pl_from, pl_from_namespace, pl_namespace, pl_title)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, pl_from, pl_from_namespace, pl_namespace, pl_title)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, pl_from, pl_from_namespace, pl_namespace, pl_title, pl_from, pl_namespace, pl_title)
    End Function
#End Region
End Class


End Namespace
