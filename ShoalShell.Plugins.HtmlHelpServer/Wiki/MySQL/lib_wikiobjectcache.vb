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
''' DROP TABLE IF EXISTS `lib_wikiobjectcache`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiobjectcache` (
'''   `keyname` varbinary(255) NOT NULL DEFAULT '',
'''   `value` mediumblob,
'''   `exptime` datetime DEFAULT NULL,
'''   PRIMARY KEY (`keyname`),
'''   KEY `exptime` (`exptime`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiobjectcache", Database:="wiki")>
Public Class lib_wikiobjectcache: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("keyname"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property keyname As Byte()
    <DatabaseField("value"), DataType(MySqlDbType.Blob)> Public Property value As Byte()
    <DatabaseField("exptime"), DataType(MySqlDbType.DateTime)> Public Property exptime As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiobjectcache` (`keyname`, `value`, `exptime`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiobjectcache` (`keyname`, `value`, `exptime`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiobjectcache` WHERE `keyname` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiobjectcache` SET `keyname`='{0}', `value`='{1}', `exptime`='{2}' WHERE `keyname` = '{3}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, keyname)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, keyname, value, DataType.ToMySqlDateTimeString(exptime))
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, keyname, value, DataType.ToMySqlDateTimeString(exptime))
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, keyname, value, DataType.ToMySqlDateTimeString(exptime), keyname)
    End Function
#End Region
End Class


End Namespace
