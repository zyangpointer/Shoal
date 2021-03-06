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
''' DROP TABLE IF EXISTS `lib_wikitag_summary`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikitag_summary` (
'''   `ts_rc_id` int(11) DEFAULT NULL,
'''   `ts_log_id` int(11) DEFAULT NULL,
'''   `ts_rev_id` int(11) DEFAULT NULL,
'''   `ts_tags` blob NOT NULL,
'''   UNIQUE KEY `tag_summary_rc_id` (`ts_rc_id`),
'''   UNIQUE KEY `tag_summary_log_id` (`ts_log_id`),
'''   UNIQUE KEY `tag_summary_rev_id` (`ts_rev_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikitag_summary", Database:="wiki")>
Public Class lib_wikitag_summary: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("ts_rc_id"), PrimaryKey, DataType(MySqlDbType.Int64, "11")> Public Property ts_rc_id As Long
    <DatabaseField("ts_log_id"), DataType(MySqlDbType.Int64, "11")> Public Property ts_log_id As Long
    <DatabaseField("ts_rev_id"), DataType(MySqlDbType.Int64, "11")> Public Property ts_rev_id As Long
    <DatabaseField("ts_tags"), NotNull, DataType(MySqlDbType.Blob)> Public Property ts_tags As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikitag_summary` (`ts_rc_id`, `ts_log_id`, `ts_rev_id`, `ts_tags`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikitag_summary` (`ts_rc_id`, `ts_log_id`, `ts_rev_id`, `ts_tags`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikitag_summary` WHERE `ts_rc_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikitag_summary` SET `ts_rc_id`='{0}', `ts_log_id`='{1}', `ts_rev_id`='{2}', `ts_tags`='{3}' WHERE `ts_rc_id` = '{4}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, ts_rc_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, ts_rc_id, ts_log_id, ts_rev_id, ts_tags)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, ts_rc_id, ts_log_id, ts_rev_id, ts_tags)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, ts_rc_id, ts_log_id, ts_rev_id, ts_tags, ts_rc_id)
    End Function
#End Region
End Class


End Namespace
