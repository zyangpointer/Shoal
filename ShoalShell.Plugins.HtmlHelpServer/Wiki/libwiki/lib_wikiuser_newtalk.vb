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
''' DROP TABLE IF EXISTS `lib_wikiuser_newtalk`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiuser_newtalk` (
'''   `user_id` int(10) unsigned NOT NULL DEFAULT '0',
'''   `user_ip` varbinary(40) NOT NULL DEFAULT '',
'''   `user_last_timestamp` varbinary(14) DEFAULT NULL,
'''   KEY `user_id` (`user_id`),
'''   KEY `user_ip` (`user_ip`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiuser_newtalk", Database:="wiki")>
Public Class lib_wikiuser_newtalk: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("user_id"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property user_id As Long
    <DatabaseField("user_ip"), NotNull, DataType(MySqlDbType.Blob)> Public Property user_ip As Byte()
    <DatabaseField("user_last_timestamp"), DataType(MySqlDbType.Blob)> Public Property user_last_timestamp As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiuser_newtalk` (`user_id`, `user_ip`, `user_last_timestamp`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiuser_newtalk` (`user_id`, `user_ip`, `user_last_timestamp`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiuser_newtalk` WHERE `user_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiuser_newtalk` SET `user_id`='{0}', `user_ip`='{1}', `user_last_timestamp`='{2}' WHERE `user_id` = '{3}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, user_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, user_id, user_ip, user_last_timestamp)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, user_id, user_ip, user_last_timestamp)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, user_id, user_ip, user_last_timestamp, user_id)
    End Function
#End Region
End Class


End Namespace
